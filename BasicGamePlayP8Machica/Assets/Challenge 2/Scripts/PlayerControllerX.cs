using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float timer = 2f;
    public GameObject dogPrefab;
    private float elapsedTime;

    private void Start()
    {
        elapsedTime = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= elapsedTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            elapsedTime = Time.deltaTime;
            timer = 2f;
        }
    }
}
