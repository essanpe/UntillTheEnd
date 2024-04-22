using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("Story");
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }

    public void OnOkayClick()
    {
        SceneManager.LoadScene("Menu");
    }

}
