using UnityEngine;
using System.Collections;

public class Tractor : MonoBehaviour
{

    public int speed;
    private bool isMovingLeft = false;
    public AudioClip deathSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isMovingLeft)
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime,
                transform.position.y, transform.position.z);

            if (transform.position.x <= -14)
            {
                isMovingLeft = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
                transform.position.y, transform.position.z);

            if (transform.position.x >= -1)
            {
                isMovingLeft = true;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Animal>() && !col.gameObject.GetComponent<Animal>().isDead)
        {
            Destroy(col.gameObject);
        }
    }
}
