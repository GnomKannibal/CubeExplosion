using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const int ClickIndex = 0;

    public event Action ButtonClicked;

    private void Update()
    {
        bool playerClick = Input.GetMouseButtonDown(ClickIndex);

        if (playerClick)
            ButtonClicked?.Invoke();
    }
}
