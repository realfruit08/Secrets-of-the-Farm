using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerIsSeen : MonoBehaviour
{   
    // Stores weather or not the player is being seen by the enemy
    public bool playerIsSeen;

    // Player gameobject
    public GameObject player;

    // Keeps the distance from the player from which it can see it
    public float sightThreshold = 20.0f;

    //Tells us how often we should be doing the check (i.e. once every 10 frames)
    public int rayTracePeriod = 10;

    // Keeps track of what frame it is currently
    public int rayTraceFrameCounter = 0;

    // Keeps the layer for obstacle
    public int obstacle_layer_number;

    // Mask that contains the layers for the ojects that can block the sight of the enemy
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.DrawLine(player.transform.position, transform.position);
        // Counts one frame
        rayTraceFrameCounter++;

        // Checks if we should raytrace
        if (rayTraceFrameCounter >= rayTracePeriod) {

            // Resets the counter
            rayTraceFrameCounter = 0;

            // ##### Runs a raytrace #####

            // Calculates the player's distance from the object
            float distFromPlayer = (new Vector2(transform.position.x, transform.position.y) 
            - new Vector2(player.transform.position.x, player.transform.position.y)).magnitude;

            // Checks that the player is not too far away
            if (distFromPlayer >= sightThreshold) {
                playerIsSeen = false;   
            }
            else {
                // Calculates the direction from the enemy to the player
                Vector2 player_direction = (new Vector2(player.transform.position.x, player.transform.position.y) 
                - new Vector2(transform.position.x, transform.position.y)).normalized;


                // Does the raycast
                if (Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), 
                player_direction,
                distFromPlayer,
                layerMask)) {
                    playerIsSeen = false;
                }
                else {
                    playerIsSeen = true;
                }


                
            }


        }

    }
}
