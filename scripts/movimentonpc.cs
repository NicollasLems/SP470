using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.Hierarchy;
using UnityEngine;

public class movimentonpc : MonoBehaviour
{
    Vector3 m;
    float angulo = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = m;
        m.Set(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        int opc = Random.Range(1, 3);
        m.z++;
        switch (opc)
        {
            case 1:
                angulo += 0.1f;
                break;
            case 2:
                angulo -= 0.1f;
                break;
        }


        if (transform.position.x < -16.35)
        {
            transform.position = new Vector3(-16.35f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 78.51)
        {
            transform.position = new Vector3(78.51f, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -3.09)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -3.09f);
        }

        if (transform.position.z > 6.87)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 6.87f);
        }

        if (transform.position.y < -1.999993)
        {
            transform.position = new Vector3(transform.position.x, -1.999993f, transform.position.z);
        }

        if (transform.position.y > -1.999993)
        {
            transform.position = new Vector3(transform.position.x, -1.999993f, transform.position.z);

            transform.eulerAngles = new Vector3(0, angulo, 0);

            m.Set(0, 0, 0);

        }
    }
}
