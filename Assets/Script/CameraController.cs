using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerController player;
    private float sensitivity = 500f;
    private float clampAngle = 85f;
    private float verticalRotation;
    private float horizontalRotation;
    // Start is called before the first frame update
    void Start()
    {
        verticalRotation = transform.localEulerAngles.x;
        horizontalRotation = transform.eulerAngles.y;
    }
    // Update is called once per frame
    private void Update()
    {
        Look();
        Debug.DrawRay(transform.position, transform.forward * 2,
        Color.red);
    }
    private void Look()
    {
        //float mouseVertical = -Input.GetAxis("Mouse Y");
        //float mouseHorizontal = -Input.GetAxis("Mouse X");
        //verticalRotation += mouseVertical * sensitivity *
        //Time.deltaTime;
        //horizontalRotation += mouseHorizontal * sensitivity *
        //Time.deltaTime;
        //verticalRotation = Mathf.Clamp(verticalRotation, -
        //clampAngle, clampAngle);
        //transform.localRotation = Quaternion.Euler(verticalRotation,
        //0f, 0f);
        //player.transform.localRotation =
        //Quaternion.Euler(0f, horizontalRotation, 0f);
    }
}
