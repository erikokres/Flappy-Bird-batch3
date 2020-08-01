using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    float graund;
    // Start is called before the first frame update
    void Start()
    {
        graund = -1.55f;
        transform.position = new Vector2(transform.position.x, graund);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left*100, Time.deltaTime*2);
    }
}
