using UnityEngine;

public class asteroid: MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadZone = -100f;
    public bool movingRight = false;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);

        if (movingRight == false)
            if (transform.position.x < deadZone)
            {
                Destroy(gameObject);
            }
            
        else if (movingRight);
        {
            if (transform.position.x > deadZone)
                Destroy(gameObject);
        }
    }
}
