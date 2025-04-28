using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recompensa : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 rotationSpeed;
    private void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddPoints(10);
            Destroy(gameObject);
        }
    }

}
