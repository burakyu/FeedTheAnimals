using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public FloatingJoystick variableJoystick;
    public float speed;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNewFood", 1, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed * variableJoystick.Horizontal);
    }

    private void LateUpdate()
    {
        if (transform.position.x < -7)
        {
            transform.position = new Vector3(-7, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 7)
        {
            transform.position = new Vector3(7, transform.position.y, transform.position.z);
        }
    }

    public void SpawnNewFood()
    {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
}
