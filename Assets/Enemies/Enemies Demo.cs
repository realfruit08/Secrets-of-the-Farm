using UnityEngine;

public class EnemiesDemo : MonoBehaviour
{

    public PlayerIsSeen seen_script;

    public float enemyspeed = 3.0f;
    private GameObject violet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        violet = GameObject.FindGameObjectWithTag("Violet");
    }

    // Update is called once per frame
    void Update()
    {

        // Checks if the player is able to be seen and moves the enemy 
        if (seen_script.playerIsSeen) {
            transform.position = Vector2.MoveTowards(transform.position, violet.transform.position, enemyspeed * Time.deltaTime);
        }
        


    }
}
