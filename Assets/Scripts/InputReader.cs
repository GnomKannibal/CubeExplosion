using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const int MouseLeftClickIndex = 0;

    private bool playerClick = false;

    public event Action ButtonClicked;

    private void Update()
    {
        playerClick = Input.GetMouseButtonDown(MouseLeftClickIndex);

        if (playerClick)
            ButtonClicked?.Invoke();
    }
}
