using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nube : MonoBehaviour {
    public GameObject cloud;


    // Use this for initialization
    void Start()
    {
        Destroy(cloud, 10);

    }

    // Update is called once per frame
    void Update()
    {
        cloud.transform.Translate(Vector3.back * Time.deltaTime * 3);
    }
}
