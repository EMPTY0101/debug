using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowChildObject : MonoBehaviour
{
    public Transform parentObject; // ������ �� ������������ ������
    private Transform childObject; // ������ �� �������� ������
    public CinemachineVirtualCamera virtualCamera; // ������ �� ����������� ������ Cinemachine

    void Start()
    {
        if (parentObject != null)
        {
            childObject = parentObject.GetChild(0); // ������������, ��� �������� ������ ��������� � ������� ������� ������������� �������
        }
        
        if (virtualCamera != null && childObject != null)
        {
            CinemachineTransposer transposer = virtualCamera.GetCinemachineComponent<CinemachineTransposer>();

            if (transposer != null)
            {
                transposer.m_FollowOffset = childObject.position; // ���������� �� ������������� ������� ��������� �������
            }
        }
    }
}