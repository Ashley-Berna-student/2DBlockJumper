using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudTreeDeleter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.tag);
        if (other.gameObject.CompareTag("Tree"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Cloud"))
        {
            Destroy(other.gameObject);
        }
    }
}
