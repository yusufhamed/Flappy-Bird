using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMove : MonoBehaviour
{

    public float movespeed = 4;
    public GameObject Clouds;

    // Start is called before the first frame update
    void Start()
    {
        print(Clouds);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
    }
}
