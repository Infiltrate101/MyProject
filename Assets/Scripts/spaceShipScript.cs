using UnityEngine;

public class spaceShipScript : MonoBehaviour
{
    public int speed = 10;
    public KeyCode moveUpButton = KeyCode.W;
    public KeyCode moveDownButton = KeyCode.S;
    public float startingPoint;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingPoint = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveUpButton))
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        
        if (Input.GetKey(moveDownButton))
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector3(transform.position.x, startingPoint, transform.position.z);
    }
}
