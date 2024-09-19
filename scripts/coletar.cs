using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletar : MonoBehaviour
{
    int pegar;

    // Start is called before the first frame update
    void Start(){
        pegar = 0;

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        switch (collision.gameObject.tag)
        {
            case "estatua":
                Destroy(collision.gameObject);
                break;

        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.tag);
        Debug.Log(pegar);
    }

}
