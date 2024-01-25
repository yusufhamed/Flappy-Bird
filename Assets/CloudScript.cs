using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public GameObject Clouds;
    private float timer = 0;
    public float cloudSpawnRate = 4;

    // Start is called before the first frame update
    void Start()
    {
        cloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < cloudSpawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            cloud();
            timer = 0;
        }
    }

    public void cloud()
    {
        Instantiate(Clouds, transform.position, transform.rotation);
    }
}
