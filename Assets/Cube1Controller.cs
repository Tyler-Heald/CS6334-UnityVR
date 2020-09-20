using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cube1Controller : MonoBehaviour
{
    public float translationUnits = 1.0f;

    bool pointerIsClicked;
    bool pointerIsOverObject;

    // Start is called before the first frame update
    void Start()
    {
        pointerIsClicked = false;
        pointerIsOverObject = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pointerIsClicked && pointerIsOverObject)
        {
            transform.position += new Vector3(0, 0, -translationUnits * Time.deltaTime);
        }
    }

    public void OnPointerDown(BaseEventData eventData)
    {
        pointerIsClicked = true;
    }

    public void OnPointerUp(BaseEventData eventData)
    {
        pointerIsClicked = false;
    }

    public void OnPointerEnter(BaseEventData eventData)
    {
        pointerIsOverObject = true;
    }
    
    public void OnPointerExit(BaseEventData eventData)
    {
        pointerIsOverObject = false;
    }
}
