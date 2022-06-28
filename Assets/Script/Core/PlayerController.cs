using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("MovementSpeed")]
    public int speedPlayer = 10;
    private Rigidbody RIG;

    [Header("KeyCode")]
    public KeyCode zValueFB;
    public KeyCode xValueFB;

    [Header("Component")]
    public List<GameObject> Player;
    private List<GameObject> player;


    // Start is called before the first frame update
    void Start()
    {
        RIG = GetComponent<Rigidbody>();
        player = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement(getInputFB());
    }

    // ============ Movement ==================
    private void inputMove()
    {

    }
    private Vector3 getInputFB()
    {
        if (Input.GetKey(zValueFB))
        {
            return Vector3.forward * speedPlayer;
        }
        else if (Input.GetKey(xValueFB))
        {
            return Vector3.back * speedPlayer;
        }
        return Vector3.zero;
    }

    private void Movement(Vector3 Movement)
    {
        RIG.velocity = Movement;
    }
    // =======================================
}
