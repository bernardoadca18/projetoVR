using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{
    // Vari�vel para armazenar a nova textura

    // Vari�vel para armazenar a tecla que ir� disparar a mudan�a de textura
    [SerializeField] KeyCode changeMaterialKey = KeyCode.C;
    [SerializeField] private List<Material> materials;
    private Material nextMaterial;
    private int materialIndex = 0;
    private int maxMaterialIndex;

    private void Start()
    {
        nextMaterial = materials[materialIndex];
        maxMaterialIndex = materials.Count;
    }

    private void Update()
    {
        // Verifica se a tecla especificada foi pressionada
        if (Input.GetKeyDown(changeMaterialKey))
        {
            Renderer renderer = GetComponent<Renderer>();

            renderer.material = nextMaterial;
            
            if (materialIndex == maxMaterialIndex - 1)
            {
                materialIndex = 0;
            }
            else
            {
                materialIndex++;
            }

            nextMaterial = materials[materialIndex];
        }
    }
}
