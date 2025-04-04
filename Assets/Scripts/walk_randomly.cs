using UnityEngine;

public class walk_randomly : MonoBehaviour
{
    // Script that holds the boolean of whether or not the player is spotted
    public PlayerIsSeen playerIsSeen;

    public Vector3 velocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if it's ok for the AI to wander about
        if (playerIsSeen == false) {

            transform.position += velocity * Time.deltaTime;



        }
    }
}
