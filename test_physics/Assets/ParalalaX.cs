using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float parallaxFactor;
    private Vector2 lastCameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        lastCameraPosition = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = (Vector2)Camera.main.transform.position - lastCameraPosition;
        transform.position = new Vector2(transform.position.x + offset.x * parallaxFactor, transform.position.y + offset.y * parallaxFactor);
        lastCameraPosition = Camera.main.transform.position;
    }
}
