using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputes : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] Camera mainCameera;
    [SerializeField] LayerMask layerMask;
    [SerializeField] float playerSpeed;
    [SerializeField] WaterCanonController waterCanonController;
    // Start is called before the first frame update
    //input system = mouse buttons
    //actions = 

    public Vector2 turn;
    public float sensetivety = 0.001f;
    Ray ray;
    bool canWalk=false;
    private void Start()
    {
        //waterCanonController = GetComponentInChildren<WaterCanonController>();
    }
    // Update is called once per frame
    void Update()
    {
        //turn.x += Input.GetAxis("Mouse X") * sensetivety;
        //turn.y += Input.GetAxis("Mouse Y")* sensetivety;
        //transform.localRotation = Quaternion.Euler(-turn.y,turn.x,0);



        //Vector3 mousWordPostion = mainCameera.ScreenToWorldPoint(Input.mousePosition);
        //mousWordPostion.z = 0f;
        //transform.position = mousWordPostion;

        //Ray ray = mainCameera.ScreenPointToRay(Input.mousePosition);
        //if (Physics.Raycast(ray,out RaycastHit raycastHit,float.MaxValue,layerMask)) 
        //{
        //    transform.position = raycastHit.point;
        //}

        Ray ray = mainCameera.ScreenPointToRay(Input.mousePosition);


        if (Input.GetMouseButton(0)&&!canWalk)
        {
            //Indecatoer();
      
                if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask))
                {
                    Vector3 target = new Vector3(raycastHit.point.x, 0.5f, raycastHit.point.z);
                    transform.position = Vector3.MoveTowards(transform.position, target, playerSpeed * Time.deltaTime);
                    changeCanonAngle();

                }
            



        }

        //if (Input.GetMouseButtonDown(1))
        //{
        //    print("hello");
        //    obj.transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        //}
        //if (Input.GetMouseButtonDown(3))
        //{
        //    print("hihi");

        //}
    }

    private void changeCanonAngle()
    {
        if (transform.position.z > 3.6)
        {
            waterCanonController.RotateWaterCanon(-2.66f);
        }else if (transform.position.z < 1)
        {
            waterCanonController.RotateWaterCanon(-44f);
        }
        else
        {
            waterCanonController.RotateWaterCanon(-32f);
        }



    }

    public void Indecatoer() 
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        print("hi");
        //obj.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            if (hit.transform != null)
            {
                print(hit.transform.name);
            }
        }

    }



}
