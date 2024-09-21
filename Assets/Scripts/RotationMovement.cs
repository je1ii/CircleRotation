using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 200f;
    [SerializeField] private Transform rotateAround;

    private bool autoRotate = false;

    void Update()
    {
        if(autoRotate)
        {
            this.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            this.transform.RotateAround(rotateAround.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        }
        else if(!autoRotate)
        {
            this.transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
            this.transform.RotateAround(rotateAround.position, Vector3.forward, -rotationSpeed * Time.deltaTime);
        }

        if(Input.GetMouseButtonDown(0))
        {
            ToggleAutoRotation();
        }
    }

    private void ToggleAutoRotation()
    {
        this.autoRotate = !this.autoRotate;
    }
}
