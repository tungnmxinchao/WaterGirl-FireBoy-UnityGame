using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ele_1 : MonoBehaviour
{
    [SerializeField] Button_1 b1;
    Vector3 newposition;
    Vector3 oldPosition;
    // Start is called before the first frame update
    void Start()
    {
        newposition = new Vector3(transform.position.x, transform.position.y - 1.2f, transform.position.z);
        oldPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (b1.MoveELe1 == true)
        {
            if (transform.position != newposition)
                transform.position = Vector3.Lerp(transform.position, newposition, 0.01f);
        }
        else
        {
            if (transform.position != oldPosition)
                transform.position = Vector3.Lerp(transform.position, oldPosition, 0.01f);
        }
    }
}
