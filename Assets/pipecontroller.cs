using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float pipeSpeed; //mengatur kecepatan pergerakan pipa

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * pipeSpeed * Time.deltaTime); //menggeser pipa ke arah kiri
    }
}