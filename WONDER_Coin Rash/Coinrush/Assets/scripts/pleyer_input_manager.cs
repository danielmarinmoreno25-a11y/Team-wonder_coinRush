using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pleyer_input_manager : MonoBehaviour
{
    public Player playerScript;
    public Rigidbody playerBody;
    private InputAction jump;
    private InputAction movement;
    public float jump_force;
    public float speed;
    public float small_motor_rumble;
    public float large_motor_rumble;

    public int coins_to_collect;
    public int Current_Coins_DO_NOT_TOUCH_IN_PLAYTEST;
    // Start is called before the first frame update
    void Start()
    {
        InputSystem.actions.FindActionMap("gameplay");

        jump = InputSystem.actions.FindAction("jump");
        movement = InputSystem.actions.FindAction("movement");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale >= 1f)
        {
            if (jump.WasPressedThisFrame())
            {
                //this how you make the player jump
                playerBody.AddForce(Vector3.up * jump_force, ForceMode.Impulse);
                //how to make it rumble
                Gamepad.current.ResumeHaptics();
                Gamepad.current.SetMotorSpeeds(large_motor_rumble, small_motor_rumble);
            }
            else if (jump.WasReleasedThisFrame())
            {
                //how to shut up the rumble
                Gamepad.current.ResetHaptics();
            }

            if (movement.ReadValue<float>() > 0f)
            {
                playerBody.AddForce(Vector3.right * speed * movement.ReadValue<float>(), ForceMode.Impulse);
            }
            if (movement.ReadValue<float>() < 0f)
            {
                playerBody.AddForce(Vector3.left * speed * (-1 * movement.ReadValue<float>()), ForceMode.Impulse);
            }
            if (movement.WasReleasedThisDynamicUpdate())
            {
                playerBody.AddForce(Vector3.down, ForceMode.Force);
            }
        }
        
    }
}
