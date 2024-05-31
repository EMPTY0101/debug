using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowChildObject : MonoBehaviour
{
    public Transform parentObject; // ссылка на родительский объект
    private Transform childObject; // ссылка на дочерний объект
    public CinemachineVirtualCamera virtualCamera; // ссылка на виртуальную камеру Cinemachine

    void Start()
    {
        if (parentObject != null)
        {
            childObject = parentObject.GetChild(0); // предполагаем, что дочерний объект находится в нулевом индексе родительского объекта
        }
        
        if (virtualCamera != null && childObject != null)
        {
            CinemachineTransposer transposer = virtualCamera.GetCinemachineComponent<CinemachineTransposer>();

            if (transposer != null)
            {
                transposer.m_FollowOffset = childObject.position; // исправлено на использование позиции дочернего объекта
            }
        }
    }
}