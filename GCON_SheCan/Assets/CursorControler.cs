using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum CursorStatus
{
    Non,
    N_Walk,
    Walk,
    Water

}
public class CursorControler : MonoBehaviour
{
    static public CursorControler cursorControler;
    // Start is called before the first frame update
    [SerializeField] Texture2D cursor_cant_walk, cursor_walk_area, Turn_on_water ;
    [SerializeField] Vector2 _hotspot = Vector2.zero;
    [SerializeField] CursorMode cursorMode= CursorMode.Auto;


    CursorStatus current_cursorStatus;

    void Start()
    {
        cursorControler = this;
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void WalkArea() 
    {
        Cursor.SetCursor(cursor_walk_area, _hotspot, cursorMode);

    }

    public void CantWalk() 
    {
        Cursor.SetCursor(cursor_cant_walk, _hotspot, cursorMode);
    }

    public void TurnOnWater() 
    {
        Cursor.SetCursor(Turn_on_water, _hotspot, cursorMode);

    }

    //public bool ItIsSame(string a, Texture2D b) 
    //{
    //    switch (a) 
    //    {
    //        case "cursor_forbidden":
    //            return true;
    //        case "cursor_forbidden":
    //            return true;
    //        case "cursor_forbidden":
    //            return true;

    //    }
    //    return a == b;
    
    //}
    public void SetCurrentCursorState(CursorStatus s) 
    {
        current_cursorStatus = s;
    }

    public bool SameCrusor(CursorStatus s) 
    {
        if (s == current_cursorStatus)
            return true;
        return false;
    
    }
}
