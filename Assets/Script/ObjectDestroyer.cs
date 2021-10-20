using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private float rangeX = 2.8f;
    private float rangeY = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -this.rangeX || this.rangeX < transform.position.x ||
            transform.position.y < -this.rangeY || this.rangeY < transform.position.y)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
            Destroy(other);
    }
}
