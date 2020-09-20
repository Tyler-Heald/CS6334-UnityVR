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

    public void OnPointerClick(BaseEventData eventData)
    {
        // Change color back and forth between original color and new color
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
