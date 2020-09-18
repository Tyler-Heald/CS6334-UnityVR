/* Programmers: Tyler Heald
 * Date: 9/18/2020
 * Class: CS 6334
 * Purpose: 
 * 9/18/20 - Give the player simple movement with the arrow keys
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    //VARIABLES
    private Vector3 playerMove;
    private float playerSpeed = 2.0f;
    private CharacterController characterController;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        //Getting the controller in order to provide movement to it
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get input for the player move
        playerMove = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Moving the character with the delta so it is based on how much time passed between frames
        characterController.Move(playerMove * Time.deltaTime * playerSpeed);
    }
}
