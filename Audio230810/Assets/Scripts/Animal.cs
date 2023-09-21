using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour
{
    private float speed = 9f;
    public bool isDead = false;

    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

        transform.Rotate(Vector3.forward * Time.deltaTime * 50, Space.World);

        if (isDead)
        {
            Destroy(gameObject);
        }
    }
}
