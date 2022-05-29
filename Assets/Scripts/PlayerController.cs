using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;

    [SerializeField] private DynamicJoystick dynamicJoystick;

    [SerializeField] private float reangMoveX = 10.0f;

    private Rigidbody rbPlayer;
    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        _transform = this.transform;
    }

    private Vector3 offSet;
    //private Vector3 vectorJoystick;
    // Update is called once per frame
    void Update()
    {
        if(dynamicJoystick != null)
        {
            if (_transform.position.x > reangMoveX)
            {
                if (dynamicJoystick.Horizontal > 0) return;
                offSet = new Vector3(dynamicJoystick.Horizontal * moveSpeed * Time.deltaTime, 0, 0);
                rbPlayer.MovePosition(rbPlayer.position + offSet);
            }else
                if (_transform.position.x < -reangMoveX)
                {
                    if (dynamicJoystick.Horizontal < 0) return;
                    offSet = new Vector3(dynamicJoystick.Horizontal * moveSpeed * Time.deltaTime, 0, 0);
                    rbPlayer.MovePosition(rbPlayer.position + offSet);
                }
                else
                {
                    offSet = new Vector3(dynamicJoystick.Horizontal * moveSpeed * Time.deltaTime, 0, 0);
                    rbPlayer.MovePosition(rbPlayer.position + offSet);
                }

        }
        
        offSet = new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0);
        rbPlayer.MovePosition(rbPlayer.position + offSet);

       
       

    }
}
