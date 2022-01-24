using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float sensitivity;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        float x = transform.position.x + Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        x = Mathf.Clamp(x, -11f, 11f);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
