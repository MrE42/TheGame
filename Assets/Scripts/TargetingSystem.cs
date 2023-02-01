using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TargetingSystem : MonoBehaviour
{
    public GameObject p;
    public int initialized = 0;
    private Vector3 p_position;
    private Vector3 bit_position;
    private float speed = (float) 0.2;



    // Start is called before the first frame update
    void Start()
    {
        initialized = 0;
        p = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (initialized == 1)
        {
            p_position = GameObject.FindGameObjectWithTag("MainCamera").transform.position;
            transform.position = Vector3.MoveTowards(transform.position, p_position, speed);
            if (transform.position == p_position)
            {
                p.GetComponent<PlayerController>().StarBitCollision(gameObject);
            }

        }

    }
}
