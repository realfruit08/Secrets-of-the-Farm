using UnityEngine;

public class walk_randomly : MonoBehaviour
{
    // Script that holds the boolean of whether or not the player is spotted
    public PlayerIsSeen playerIsSeen;

    // Holds the angle that the NPC is facing
    public float direction;

    // Determines how much the NPC will change direction
    public float turning_force;

    // Speed on npc
    public float speed;

    // Determines how often the player should be turning
    public int turn_period;

    // Holds number of frames that have passed
    public int turn_frame_counter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if it's ok for the AI to wander about
        if (playerIsSeen.playerIsSeen == false) {

            Debug.Log("Not Seeing Player");

            

            // Moves the npc
            transform.position += new Vector3(Mathf.Cos(direction),
            Mathf.Sin(direction)) 
            * Time.deltaTime
            * speed;

            //Counts a frame
            turn_frame_counter++;

            // Checks if it's time to turn
            if (turn_frame_counter >= turn_period) {
                turn_frame_counter = 0;

                // Makes the NPC change direction
                float direction_change = Random.Range(-turning_force, turning_force);
                direction += direction_change;
            }

            

            




        }
    }
}
