using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRL : MonoBehaviour
{

    [Header("MovementSpeed")]
    public int speedPlayer = 10;
    private Rigidbody RIG;

    [Header("KeyCode")]
    public KeyCode zValueRL;
    public KeyCode xValueRL;

    // Start is called before the first frame update
    void Start()
    {
        RIG = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement(getInputRL());
    }

    // ============ Movement ==================
    private Vector3 getInputRL()
    {
        if (Input.GetKey(zValueRL))
        {
            return Vector3.right * speedPlayer;
        }
        else if (Input.GetKey(xValueRL))
        {
            return Vector3.left * speedPlayer;
        }
        return Vector3.zero;
    }

    private void Movement(Vector3 Movement)
    {
        RIG.velocity = Movement;
    }
    // =======================================
}
