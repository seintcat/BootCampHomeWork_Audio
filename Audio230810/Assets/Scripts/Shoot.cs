using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public GameObject[] animals;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject randomAnimal = animals[Random.Range(0, animals.Length)];

            // Load animal prefab
            Instantiate(randomAnimal, transform.position, transform.rotation);
        }
    }
}
