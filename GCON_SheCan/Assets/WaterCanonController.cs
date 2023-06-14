using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCanonController : MonoBehaviour
{
   
    [SerializeField]
    private WaterCanon waterCanon;

    [SerializeField]
    private string fireTag;
    [SerializeField]
    private float cannonSpeed;

    public float rotationSpeed = 0.1f;
    private float cannonAngle;
    private Transform m_transform;

    void Start()
        {
            waterCanon.SetEnemyTag(fireTag);
        
        }

        void Update()
        {

        //RotateWaterCanon();
        if (Input.GetMouseButtonDown(1))
            {
            CursorControler.cursorControler.SetCurrentCursorState(CursorStatus.Water);

            CursorControler.cursorControler.TurnOnWater();

            waterCanon.Fire();
        }

            if (Input.GetMouseButtonUp(1))
            {
            CursorControler.cursorControler.SetCurrentCursorState(CursorStatus.Non);
            waterCanon.StopFire();
            }

        }

    public void RotateWaterCanon(float angle)
    {
        /* cannonAngle += Input.GetAxis("Mouse X") * cannonSpeed * -Time.deltaTime;
         cannonAngle = Mathf.Clamp(cannonAngle, 0, 180);*/
        /* transform.localRotation = Quaternion.AngleAxis(angle, Vector3.left);
         transform.localRotation = Quaternion.AngleAxis(17f, Vector3.down);*/
        transform.rotation = Quaternion.Euler(new Vector3(angle, transform.rotation.y, transform.rotation.z));

        /*Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        cannonAngle = Mathf.Atan2(direction.y, direction.x)* Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(cannonAngle , Vector3.left);
        transform.rotation = rotation;*/


    }
   /* void OnMouseDrag()
    { // calls when mouse or touch is dragged
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.RotateAround(Vector3.down, XaxisRotation);
        transform.RotateAround(Vector3.right, YaxisRotation);
    }*/
}


