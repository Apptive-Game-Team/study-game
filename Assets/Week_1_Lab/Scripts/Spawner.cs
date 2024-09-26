using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // �� ������ ����Ƽ���� �� �� �ְ� ����ȭ�� ��, �������� �������� �ش�.
    [SerializeField] GameObject circleObject;

    // ����ð� ����
    float curTime = 0;
    
    //�� 10���� �����.
    private void Start()
    {
        //for (int i = 0; i < 10; i++)
        //{
        //    Instantiate(circleObject);// ��ü(��)�� �����Ѵ�.
        //    circleObject.transform.position = PickRandomPosition();
        //    circleObject.GetComponent<SpriteRenderer>().color = PickRandomColor();
        //}
    }

    // 1�ʸ��� ���� �����.
    private void Update()
    {
        curTime += Time.deltaTime;
        if (curTime >= 1) 
        {
            MakeRandomCircle();
            curTime = 0;
        }
    }

    void MakeRandomCircle() // ��ü(��)�� �����Ѵ�.
    {
        Instantiate(circleObject);
        circleObject.transform.position = PickRandomPosition();
        circleObject.GetComponent<SpriteRenderer>().color = PickRandomColor();
    }

    Vector3 PickRandomPosition() // ������ ��ġ(����3)�� ��ȯ�Ѵ�.
    {
        float x = Random.Range(-3f, 3f);
        float y = Random.Range(-3f, 3f);

        return new Vector3(x, y, 0);
    }

    Color PickRandomColor() // ������ ������ ��ȯ�Ѵ�.
    {
        float r = Random.Range(0, 1f);
        float g = Random.Range(0, 1f);
        float b = Random.Range(0, 1f);

        return new Color(r, g, b);
    }
}
