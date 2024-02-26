using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static CameraShakeManager Instance;

    [SerializeField]
    private float impulseForce_mg = 1f;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }


    public void shakeCamera(CinemachineImpulseSource impulseSource)
    {
        impulseSource.GenerateImpulseWithForce(impulseForce_mg);
    }
}
