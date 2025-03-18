using Cinemachine;

using UnityEngine;
using UnityEngine.InputSystem;

using BACKND;
using StarterAssets;

public class PlayerController : NetworkBehaviour
{
    public CharacterController controller;
    public ThirdPersonController thirdPersonController;
    public PlayerInput playerInput;
    public CinemachineVirtualCamera cinemachineVirtualCamera;

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        controller = GetComponent<CharacterController>();
        thirdPersonController = GetComponent<ThirdPersonController>();
        playerInput = GetComponent<PlayerInput>();

        controller.enabled = true;
        thirdPersonController.enabled = true;
        playerInput.enabled = true;

        cinemachineVirtualCamera = FindObjectOfType<CinemachineVirtualCamera>();
        cinemachineVirtualCamera.Follow = transform.Find("PlayerCameraRoot");
    }
}
