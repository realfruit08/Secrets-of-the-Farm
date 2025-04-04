using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Garde : MonoBehaviour
{
    public GameObject player;
    public float cropsWatered = 0;

    void Start()
    {
        GameObject[] temp = GameObject.FindGameObjectsWithTag("Violet");
        player = temp[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (cropsWatered == 14)
        {
            player.GetComponent<Movement>().speed = 4;
            player.GetComponent<Movement>().run = 3;
            player.GetComponent<Movement>().sneak = 0.5f;
            Destroy(gameObject);
        }
    }
    public void Watered(Image img)
    {
        img.color = Color.white;
        cropsWatered++;
    }
}
