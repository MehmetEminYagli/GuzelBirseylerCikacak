using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SagsolSpawner : MonoBehaviour
{
    [SerializeField] private GameObject wallEngel;
    [SerializeField] private float baslang�cYdegeri;
    [SerializeField] private float Artt�r�lacakYdegeri;
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            duvarengelspawner();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
  
    private void duvarengelspawner()
    {
        Vector3 spawnposition = new Vector3(transform.position.x , baslang�cYdegeri, transform.position.z);
        Instantiate(wallEngel, spawnposition, Quaternion.identity);

        baslang�cYdegeri += Artt�r�lacakYdegeri;
    }



}
