using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const int MouseLeftClickIndex = 0;

    public event Action ButtonClicked;

    private void Update()
    {
        bool playerClick = Input.GetMouseButtonDown(MouseLeftClickIndex);

        if (playerClick)
            ButtonClicked?.Invoke();
    }
}
