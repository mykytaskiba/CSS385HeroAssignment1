using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private MouseController mouseController;
    private KeyboardController keyboardController;

    bool usingMouse = true;

    //Separate into weapon


    void updateControlScheme()
    {
        mouseController.enabled = usingMouse;
        keyboardController.enabled = !usingMouse;

        VisualUI.Get().setMode(usingMouse);
    }
    // Start is called before the first frame update
    void Start()
    {
        mouseController = GetComponent<MouseController>();
        keyboardController = GetComponent<KeyboardController>();

        usingMouse = true;
        updateControlScheme();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            usingMouse = !usingMouse;
            updateControlScheme();
        }

    }
}
