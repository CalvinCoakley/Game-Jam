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
    }
}
