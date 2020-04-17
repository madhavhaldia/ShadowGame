using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("script loaded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        Debug.Log("Mouse used");
        float rotateX = Input.GetAxisRaw("Mouse X") * speed * Time.deltaTime;
        float rotateY = Input.GetAxisRaw("Mouse Y") * speed * Time.deltaTime;
        

        transform.Rotate(transform.up, -rotateX);
        transform.Rotate(transform.right, -rotateY);
        
       

    }

}
