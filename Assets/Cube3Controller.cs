using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cube3Controller : MonoBehaviour
{
    public Color newColor = Color.red;

    Color originalColor;
    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Called on pointer click
    public void ChangeColor(BaseEventData eventData)
    {
        if (IsLeftClick(eventData as PointerEventData))
        {
            if (renderer.material.color == originalColor)
            {
                renderer.material.color = newColor;
            }
            else
            {
                renderer.material.color = originalColor;
            } 
        }
    }

    bool IsLeftClick(PointerEventData pointerEvent)
    {
        return pointerEvent != null && pointerEvent.button == PointerEventData.InputButton.Left;
    }
}
