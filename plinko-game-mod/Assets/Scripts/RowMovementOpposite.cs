using UnityEngine;

public class RowMovementOpposite : MonoBehaviour
{
    public GameObject row;
    public Vector2 pos;
    public float speed = 1f;
    public float leftMax = 10f;
    public float rightMax = 18f;

    int direction = -1;

    public void Start()
    {
        // starting position
        pos = row.transform.position;
    }

    public void Update()
    {
        Movement();
    }

    public void Movement()
    {
        pos.x += direction * speed * Time.deltaTime;

        //changes row to the left
        if (pos.x >= rightMax)
        {
            direction = -1;
        }

        //moves row to the right
        else if (pos.x <= leftMax)
        {
            direction = 1;
        }

        // new position
        row.transform.position = pos;
    }
}
