using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    Vector2 cursorPosition;
    public GameObject customCursor;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        CustomCursorPositionig();
    }
    private void CustomCursorPositionig()
    {
        cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPosition;
    }
    public void ActivatingSelf()
    {
        customCursor.SetActive(true);
    }
    public void DeactivatingSelf()
    {
        customCursor.SetActive(false);
    }
}
