using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody Rig;
    [SerializeField] float maxSpeed;
    public Vector3 speedBall;

    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody>();
        Rig.velocity = speedBall;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall" ||
            other.gameObject.tag == "Player")
        {
            if (Rig.velocity.magnitude < maxSpeed)
            {
                Rig.velocity = Rig.velocity.normalized * maxSpeed;
            }
        }
    }
}
