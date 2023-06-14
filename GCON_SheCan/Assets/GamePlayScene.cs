using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayScene : MonoBehaviour
{
    [SerializeField] Texture2D png;
    [SerializeField] Vector2 _hotspot = Vector2.zero;
    [SerializeField] CursorMode cursorMode = CursorMode.Auto;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(png, _hotspot, cursorMode);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GamePlay() 
    {
        SceneManager.LoadScene("SheCan_GamePlay_Scene");


    }
    public void MainMenu()
    {
        SceneManager.LoadScene("SheCan_MainMenu_Scene");


    }
}
