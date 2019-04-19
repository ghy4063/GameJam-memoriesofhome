using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{
    //slider
    public Slider StaminaBarSlider;
    //stamina values
    [Header("Stamina variables")]
    public float stamina;
    public float staminaMax;
    public float staminaDepletion;
    public float staminaRegen;
   // private transform
    private Transform tf;
    //speed of the player
    [Header("Speed at which the player moves")]
    public float speed;
    public float speedMax;

    private float originalspeed;
	// Use this for initialization
	void Start ()
	{
	    tf = GetComponent<Transform>();
	    originalspeed = speed;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    //isRunning = false;
	    if (Input.GetKey(KeyCode.LeftShift))
	    {
	        stamina -= Time.deltaTime / staminaDepletion;
	        if (stamina > 0f)
	        {
	            speed = speed * 2;
	            speed = Mathf.Clamp(speed, 0, speedMax);
	        }
	    }
	    else
	    {
	        stamina += Time.deltaTime / staminaRegen;
	        speed = originalspeed;
        }

	    stamina = Mathf.Clamp(stamina,0,staminaMax);

	    if (Input.GetKey(KeyCode.D))
	    {
            
            Vector3 movement= new Vector3(speed,0,0);
            tf.Translate(movement*Time.deltaTime,Space.World);

	    }

	    if (Input.GetKey((KeyCode.A)))
	    {
	        Vector3 movement = new Vector3(-speed, 0, 0);
	        tf.Translate(movement * Time.deltaTime, Space.World);

        }

	    if (Input.GetKey(KeyCode.S))
	    {
	        Vector3 movement = new Vector3(0, 0,-speed );
	        tf.Translate(movement * Time.deltaTime, Space.World);

        }

	    if (Input.GetKey(KeyCode.W))
	    {
	        Vector3 movement = new Vector3(0,0, speed);
	        tf.Translate(movement * Time.deltaTime, Space.World);

        }


	    //updates the slider with the value stamina 
	    StaminaBarSlider.value = stamina;

    }


}
