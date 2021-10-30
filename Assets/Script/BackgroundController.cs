using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = -0.5f;
    [SerializeField] private float deadLine = -15f;

    public static bool isComingBoss = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // deadLine‚Å’âŽ~‚·‚é
        if (transform.position.y > this.deadLine)
        {
            transform.Translate(0, this.scrollSpeed * Time.deltaTime, 0);
        }

        if (transform.position.y <= this.deadLine)
        {
            isComingBoss = true;
        }
    }
}
