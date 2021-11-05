using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDroper : MonoBehaviour
{
    public GameObject dropItem1;
    public GameObject dropItem2;
    public GameObject dropItem3;
    public void DropItem(GameObject gameObject, int rangeMax)
    {
        int n = Random.Range(1, rangeMax);
        if (n == 1)
        {
            GameObject item1 = Instantiate(dropItem1);
            item1.transform.position = gameObject.transform.position;
        }
        else if (n == 2)
        {
            GameObject item2 = Instantiate(dropItem2);
            item2.transform.position = gameObject.transform.position;
        }
        else if (n == 3)
        {
            GameObject item3 = Instantiate(dropItem3);
            item3.transform.position = gameObject.transform.position;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
