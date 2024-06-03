using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] KeyCode teleportKey = KeyCode.T;
    [SerializeField] Transform objToBeTeleported;
    [SerializeField] Transform markersHolder;
    private TeleportType teleportType;
    private int teleportIndex = 0;
    private int maxTeleportIndex;


    private void Start()
    {
        maxTeleportIndex = markersHolder.childCount;

        if (maxTeleportIndex > 1)
        {
            teleportType = TeleportType.Sequential;
        }
        else
        {
            teleportType = TeleportType.OnePoint;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(teleportKey))
        {
            if (teleportType == TeleportType.OnePoint)
            {
                TeleportObjOnePoint();
            }
            else if (teleportType == TeleportType.Sequential)
            {
                TeleportObjSequential();
            }
        }
    }

    private void TeleportObjOnePoint()
    {
        Transform targetMarker = markersHolder.GetChild(0);
        objToBeTeleported.position = new Vector3(targetMarker.position.x,targetMarker.position.y, targetMarker.position.z);
    }

    private void TeleportObjSequential()
    {
        Transform targetMarker = markersHolder.GetChild(teleportIndex);
        objToBeTeleported.position = new Vector3(targetMarker.position.x, targetMarker.position.y, targetMarker.position.z);

        if (teleportIndex == maxTeleportIndex - 1)
        {
            teleportIndex = 0;
        }
        else
        {
            teleportIndex++;
        }
    }
}

public enum TeleportType
{
    OnePoint,
    Sequential
}