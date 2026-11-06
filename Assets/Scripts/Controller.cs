using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
