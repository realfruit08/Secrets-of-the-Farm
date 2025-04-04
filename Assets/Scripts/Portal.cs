using UnityEngine;

public class Portal : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("working");
        if (collision.gameObject.layer == 6)
        {
            Debug.Log("touching");
            player.transform.position = new Vector3(x, y, z);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
}
