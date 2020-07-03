using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public float arrowDamage;
    public float arrowSpeed;
    public float arrowLifeTime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, arrowLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * arrowSpeed * Time.deltaTime);
    }
}
