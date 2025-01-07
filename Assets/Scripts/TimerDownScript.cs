using UnityEngine;

public class TimerDownScript : MonoBehaviour
{
    public float speed = 0.1f;
    private float posY;
    public int count;
    private float stop = -0.1f;

    // Update is called once per frame
    void Update()
    {
        if (posY > stop)
        {
            if (count == 120)
            {
                count = 0;
                posY = transform.position.y;
                transform.position = new Vector2(transform.position.x, posY - speed * Time.deltaTime);
            }
            else
            {
                count += 1;
            }

        }
    }
}
