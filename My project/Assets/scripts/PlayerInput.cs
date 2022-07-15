using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Vector3 Vec;
    [SerializeField] float playerSpeed;
void Update()
{
        Vec = transform.localPosition;
        Vec.y += Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        transform.localPosition = Vec;
        Mathf.Clamp(transform.localPosition.y, -4.77f, 4.77f);
        Mathf.Clamp(transform.localPosition.x, -8.85f, 8.85f);
    }
}
