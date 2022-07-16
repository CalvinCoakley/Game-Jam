using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Vector3 Vec;
    [SerializeField] float playerSpeed;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        Vec = transform.localPosition;
        Vec.y += Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        transform.localPosition = Vec;

        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
