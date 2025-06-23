using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool isBirdAlive = true ;


    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isBirdAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }


        if (transform.position.y > 20 || transform.position.y < -25)
        {
            logic.gameOver();
            isBirdAlive = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isBirdAlive = false;
    }
}
