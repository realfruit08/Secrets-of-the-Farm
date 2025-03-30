using UnityEngine;

public class AnimalMovementScript : MonoBehaviour
{
    //setting variables
    public GameObject BorderTL;
    public GameObject BorderBR;
    //make an extra object to attach to the script !!!Important!!!
    public GameObject moveToPoint;
    bool moving;
    public float speed;
    float resting;
    Vector2 toThis;
    Vector2 xAxis;
    Vector2 yAxis;

    private void Start()
    {
        //turn off the circles so that the player doesn't see them, we only need their positions 
        BorderTL.SetActive(false);
        BorderBR.SetActive(false);
        moveToPoint.SetActive(false);

        //making an imaginary box between the two points
        xAxis = new Vector2(BorderTL.transform.position.x, BorderBR.transform.position.x);
        yAxis = new Vector2(BorderTL.transform.position.y, BorderBR.transform.position.y);

        newPoint();
    }

    // Update is called once per frame
    void Update()
    {
        //if the animal is not moving then check to see if the animal has rested enough, if both are true then set a new position otherwise continue to move the animal.
        if (!moving && resting <= 0)
        {
            newPoint();
        }
        else
        {
            move();
        }
    }

    void newPoint()
    {
        //find a new point for the animal to move to
        moveToPoint.transform.position = new Vector2(Random.Range(xAxis.x, xAxis.y), Random.Range(yAxis.x, yAxis.y));

        resting = Random.Range(1, 3);
    }
    void move()
    {
        //check to see if the animal has arrived at the resting point, if it has then start resting, otherwise move towards it.
        if (transform.position == moveToPoint.transform.position)
        {
            resting -= Time.deltaTime;
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, moveToPoint.transform.position, speed * Time.deltaTime);
        }
    }
}