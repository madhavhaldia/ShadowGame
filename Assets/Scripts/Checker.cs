using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{ public float angleX;
    public float angleY;
    public float angleZ;
    float x;
    float y;
    float z;
    public GameObject image;
    public GameObject target;
    void Start()
    {
        transform.SetPositionAndRotation(transform.position, Random.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        x = transform.localEulerAngles.x;
        y = transform.localEulerAngles.y;
        z = transform.localEulerAngles.z;
        if (x < angleX + 10 && x > angleX - 10 && y < angleY + 10 && y > angleY - 10 && z < angleZ + 10 && z > angleZ - 10)
        {
            Debug.Log("Match");
            image.SetActive(true);
            target.SetActive(false);
        }
        else
        {
            Debug.Log(angleX);
            image.SetActive(false);
            target.SetActive(true);
            Debug.Log(x);

            Debug.Log(angleY);
            Debug.Log(y);

            Debug.Log(angleZ);
            Debug.Log(z);
        }
            
    }
}
