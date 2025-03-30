using UnityEngine;
using static Unity.Collections.Unicode;

public class InteractionScript : MonoBehaviour
{
    public GameObject player;
    Collider2D playerCollider;
    public GameObject minigame;
    bool canInteract;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(minigame);
            player.GetComponent<Movement>().speed = 0;
            player.GetComponent<Movement>().run = 0;
            player.GetComponent<Movement>().sneak = 0;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Violet") //is it the player?
        {
            canInteract = true;

            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Violet") //is it the player?
        {
            canInteract = false;

            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}