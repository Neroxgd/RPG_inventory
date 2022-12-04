using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class DeathEffect : MonoBehaviour
{
    public List<SkinnedMeshRenderer> _skinnedMeshRenderer;
    // private SkinnedMeshRenderer skinnedMesh;
    public VisualEffect VFXGraph;
    public float dissoleRate = 0.0125f;
    public float refreshRate = 0.025f;
    public List<Material> skinnedMaterials;
    void Start()
    {
        if (_skinnedMeshRenderer != null)
            for (int i = 0; i < _skinnedMeshRenderer.Count; i++)
            {
                skinnedMaterials.Add(_skinnedMeshRenderer[i].material);
            }
            
    }

    public void Death()
    {
        StartCoroutine(_DeathEffect());
    }
    IEnumerator _DeathEffect()
    {
        // if (skinnedMeshRenderer != null)
        //     for (int i = 0; i < skinnedMeshRenderer.Length; i++)
        // {
        // skinnedMaterials = skinnedMeshRenderer[i].materials;
        // if (_skinnedMeshRenderer != null)
        //     foreach (SkinnedMeshRenderer skinnedMeshRenderer in _skinnedMeshRenderer)
        //     {
        // skinnedMaterials = skinnedMeshRenderer.materials;
        if (VFXGraph != null)
            VFXGraph.Play();
        if (skinnedMaterials.Count > 0)
        {
            float counter = 0;

            while (skinnedMaterials[0].GetFloat("_DissolveAmount") < 1)
            {
                counter += dissoleRate;
                for (int y = 0; y < skinnedMaterials.Count; y++)
                    skinnedMaterials[y].SetFloat("_DissolveAmount", counter);
                print("oui");
                yield return new WaitForSeconds(refreshRate);
            }
        }
        // }

        // }
    }


}
