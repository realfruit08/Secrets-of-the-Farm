using Unity.VisualScripting;
using UnityEngine;

public class PoopMiniGameScript : MonoBehaviour
{
    public GameObject player;
    public float poopCollected = 0;

    void Start()
    {
        GameObject[] temp = GameObject.FindGameObjectsWithTag("Violet");
        player = temp[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (poopCollected == 5)
        {
            player.GetComponent<Movement>().speed = 4;
            player.GetComponent<Movement>().run = 3;
            player.GetComponent<Movement>().sneak = 0.5f;
            Destroy(gameObject);
        }
    }
    public void poopPickedUp()
    {
        poopCollected++;
    }
}