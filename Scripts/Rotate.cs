using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotate : MonoBehaviour
{
    [SerializeField] Vector3 Rotasyon;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void FixedUpdate()
    {
        // gameObject.transform.rotation *= RotationAngle;
        gameObject.transform.Rotate(Rotasyon);
    }

}
