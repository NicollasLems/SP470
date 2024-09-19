using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{Vector3 m;
    // Start is called before the first frame update
    void Start()
    {
        m.x = 8.09f;
        m.y = 2.89f;
        m.z = -20.11f;
        transform.position = m;
        m.Set(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            m.x = 0.1f;
            transform.Translate(m);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            m.x = -0.1f;
            transform.Translate(m);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            m.z = 0.1f;
            transform.Translate(m);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            m.z = -0.1f;
            transform.Translate(m);
        }

        if (transform.position.x < -34.59)
        {
            transform.position = new Vector3(-34.59f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 29.8)
        {
            transform.position = new Vector3(29.8f, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -44.13)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -44.13f);
        }

        if (transform.position.z > 13.74)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 13.74f);
        }

        if (transform.position.y < 2.89)
        {
            transform.position = new Vector3(transform.position.x, 2.89f, transform.position.z);
        }

        if (transform.position.y > 2.89)
        {
            transform.position = new Vector3(transform.position.x, 2.89f, transform.position.z);
        }

        m.Set(0, 0, 0);
    }
}
