using UnityEngine;

public class Teleport : MonoBehaviour
{

    [SerializeField]
    GameObject xrOrigin;
    [SerializeField]
    Transform teleportTo;

    //
    public void TeleportUser()
    {
        xrOrigin.transform.position = teleportTo.position;
    }

}
