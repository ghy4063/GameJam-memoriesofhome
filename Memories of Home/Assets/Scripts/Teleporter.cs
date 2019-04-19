using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {
    //Grabs the script from the other game object to dictate where it will teleport to
    public Teleporter destinationTeleporter;
    //stops infinite teleportation from occuring 
    public float cooldown;
    //how long it will be before you will teleport again
    public float delay = 0.1f;

    public AudioClip doorNoise;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        cooldown -= Time.deltaTime;
    }
    //
    public void OnTriggerEnter(Collider otherObject)
    {
        //checks if cool down is ready 
        if (cooldown < 0)
        {
            //grabs the transform of the place that you will be teleporting to 
            SoundManager.instance.PlaySingle(doorNoise);
            Transform otherTransform;
            otherTransform = otherObject.GetComponent<Transform>();
            otherTransform.position = destinationTeleporter.GetComponent<Transform>().position;
            //sets my cool down to delay
            destinationTeleporter.GetComponent<Teleporter>().cooldown = delay;
        }
    }
}
