using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowScript : MonoBehaviour
{
    public Transform Player;
    public float offset = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        Vector3 playerToMouseDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - Player.position;
        playerToMouseDir.z = 0;
        transform.position = Player.position + (offset * playerToMouseDir.normalized);
    }
}
