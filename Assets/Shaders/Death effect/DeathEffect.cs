using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffect : MonoBehaviour
{
    public SkinnedMeshRenderer[] _skinnedMeshRenderer;
    private SkinnedMeshRenderer skinnedMesh;
    public float dissoleRate = 0.0125f;
    public float refreshRate = 0.025f;
    public Material[] skinnedMaterials;
    void Start()
    {
        // if (_skinnedMeshRenderer != null)
        // for (int i = 0; i < skinnedMeshRenderer.Length; i++)
        // {
        //     skinnedMaterials = skinnedMeshRenderer[i].materials;
        // }

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
        if (skinnedMaterials.Length > 0)
        {
            float counter = 0;

            while (skinnedMaterials[0].GetFloat("_DissolveAmount") < 1)
            {
                counter += dissoleRate;
                for (int y = 0; y < skinnedMaterials.Length; y++)
                    skinnedMaterials[y].SetFloat("_DissolveAmount", counter);
                print("oui");
                yield return new WaitForSeconds(refreshRate);
            }
        }
        // }

        // }
    }


}
