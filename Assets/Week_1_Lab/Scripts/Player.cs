using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float moveSpeed = 2;

    // �÷��̾� �̵� ���
    // 1. Ű �Է��� �޴´�.
    // 2. Ű �Է¿� ����, �÷��̾� ������Ʈ�� �̵���Ų��.
    private void Update() // �� �����Ӹ��� ������ �Ѵ�. ��ǻ�ͳ� �����ϴ� ȯ���� ���ɿ� ���� 1�ʴ� �� ������������ �޶���.
    {
        //Input.GetKeyDown()
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Debug.Log("Press W!");
        //    transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    Debug.Log("Press A!");
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    Debug.Log("Press S!");
        //    transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    Debug.Log("Press D!");
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}

        //Input.GetAxis()
        transform.position += Vector3.right * Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        transform.position += Vector3.up * Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
    }
}
