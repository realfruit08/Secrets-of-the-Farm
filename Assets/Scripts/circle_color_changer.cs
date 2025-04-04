using UnityEngine;

public class circle_color_changer : MonoBehaviour
{

    // Gameobjects for the circles
    public GameObject circle1;
    public GameObject circle2;

    // Sight script
    public PlayerIsSeen playerIsSeen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsSeen.playerIsSeen) {
            circle1.SetActive(true);
            circle2.SetActive(false);
        }
        else {
            circle1.SetActive(false);
            circle2.SetActive(true);
        }
    }
}
