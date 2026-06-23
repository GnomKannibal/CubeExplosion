using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const int ClickIndex = 0;

    public event Action<Vector3> ButtonClicked;

    private void Update()
    {
        bool playerClick = Input.GetMouseButtonDown(ClickIndex);

        if (playerClick)
        {
            Vector3 mousePosition = Input.mousePosition;

            ButtonClicked?.Invoke(mousePosition);
        }    
    }
}
