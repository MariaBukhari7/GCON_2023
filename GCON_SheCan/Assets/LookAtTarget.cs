using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{

    [SerializeField] Transform target;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           MouseLocation();

        }
    }
    //Equation that calculat distanse between two point and applay tan to get rotation
    public void MouseLocation() 
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - target.position;

        print("The postion from CRUSER =  "+ Camera.main.WorldToScreenPoint(Input.mousePosition) +" TARGET= "+ target.position + " SO DIRECTION= "+direction);

    }

}
