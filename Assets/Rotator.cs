using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update

    public float yawDegreesPerSecond = 0f; 
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Transform myTransform = GetComponent<Transform>();
        myTransform.Rotate(new Vector3(0f,yawDegreesPerSecond * Time.deltaTime,0f), Space.World);
    }
}
