using UnityEngine;

public class EnemiesDemo : MonoBehaviour
{
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
        transform.position = Vector2.MoveTowards(transform.position, violet.transform.position, enemyspeed * Time.deltaTime);

    }
}
