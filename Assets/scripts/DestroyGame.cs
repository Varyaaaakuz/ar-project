using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGame : MonoBehaviour
{
    // ������, � ������� ����� ����������� ������������
    public GameObject otherObject;
    public PlayerMoney playerMoney;
    public int _pointsForFlower = 20;
    [SerializeField] public ParticleSystem destroyParticles;

    private void OnCollisionEnter(Collision collision)
    {
        // ��������� ������������ � ������ ��������
        if (collision.gameObject == otherObject)
        {
            // ������ ������ ���������� (������������ ���)
            Destroy(gameObject);
            playerMoney.ProcessWin(_pointsForFlower);
            Instantiate(destroyParticles, transform.position, Quaternion.identity);
        }
    }
}