using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changecolor : MonoBehaviour
{
    public SpriteRenderer square;
    // Start is called before the first frame update
    void Start()
    {
        square = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        square.color = Random.ColorHSV();
        print("Changed");
        //system and unity both have random so if there is an error add "UnityEngine." before random
    }
}
