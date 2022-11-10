using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab4_zad3i4 : MonoBehaviour
{
// ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;
    private float xRotation;
    private float yRotation;
    public float sensitivity = 200f;

    void Start()
    {
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartości dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // wykonujemy rotację wokół osi Y
        player.Rotate(Vector3.up * mouseXMove);
        yRotation += mouseXMove;
        xRotation += mouseYMove;
        xRotation = Mathf.Clamp(xRotation, -90f,90f);

        transform.localRotation = Quaternion.Euler(-xRotation, 0, 0);
    }
}
