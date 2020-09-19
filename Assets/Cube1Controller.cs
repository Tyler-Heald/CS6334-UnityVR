using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cube1Controller : MonoBehaviour
{
    bool shouldMove;

    // Start is called before the first frame update
    void Start()
    {
        shouldMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldMove)
        {
            transform.position += new Vector3(0, 0, -1 * Time.deltaTime);
        }
    }

    // Called on pointer down
    public void StartTranslation(BaseEventData eventData)
    {
        if (IsLeftClick(eventData as PointerEventData))
        {
            shouldMove = true;
        }
    }

    // Called on pointer up
    public void StopTranslation(BaseEventData eventData)
    {
        if (IsLeftClick(eventData as PointerEventData))
        {
            shouldMove = false;
        }
    }

    bool IsLeftClick(PointerEventData pointerEvent)
    {
        return pointerEvent != null && pointerEvent.button == PointerEventData.InputButton.Left;
    }
}
