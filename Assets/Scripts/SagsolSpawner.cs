using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SagsolSpawner : MonoBehaviour
{
    [SerializeField] private GameObject wallEngel;
    [SerializeField] private float baslangýcYdegeri;
    [SerializeField] private float ArttýrýlacakYdegeri;
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
        Vector3 spawnposition = new Vector3(transform.position.x , baslangýcYdegeri, transform.position.z);
        Instantiate(wallEngel, spawnposition, Quaternion.identity);

        baslangýcYdegeri += ArttýrýlacakYdegeri;
    }



}
