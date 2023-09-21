using UnityEngine;
using System.Collections;

public class Barn : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Animal>())
        {
            Destroy(col.gameObject);
        }
    }
}
