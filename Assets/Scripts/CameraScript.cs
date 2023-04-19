using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 25f;
    [SerializeField] private float lookDownSpeed = 5.0f;
    [SerializeField] private float movementSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.rotation.eulerAngles;

        rotation.y += rotateSpeed * Time.deltaTime;
        rotation.x += lookDownSpeed * Time.deltaTime;
        if (rotation.x >= 45f || rotation.x <= 10f)
        {
            lookDownSpeed *= -1f;
        }

        transform.localRotation = Quaternion.Euler(rotation);

        //- 5 to 1.4

        transform.localPosition = new Vector3(transform.localPosition.x + movementSpeed * Time.deltaTime, 
            transform.localPosition.y, transform.localPosition.z);        
        if (transform.position.x <= -5f || transform.position.x > 1.4f)
        {
            movementSpeed *= -1f;
        }

    }
}
