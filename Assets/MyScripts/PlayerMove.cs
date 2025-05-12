using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class PlayerMove : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Ray ray;
    private RaycastHit raycastHit;
    private Animator animator;

    private float x, z, velocitySpeed;

    private CinemachineTransposer cinemachineTransposer;
    public CinemachineVirtualCamera cinemachineVirtualCamera;
    private Vector3 position;
    private Vector3 currentPosition;

    public static bool canMove = true;
    public static bool moving = false;

    public LayerMask layerMask;

    public GameObject cameraFree;
    public GameObject cameraStatic;
    private bool isFreeCameraActive;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        cinemachineTransposer = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>();
        currentPosition = cinemachineTransposer.m_FollowOffset;
        
        SwichCamera();
    }

    // Update is called once per frame
    void Update()
    {
        position = Input.mousePosition;
        cinemachineTransposer.m_FollowOffset = currentPosition;

        if (Input.GetMouseButtonDown(0) && canMove)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit, 300, layerMask))
            {
                navMeshAgent.destination = raycastHit.point;
            }
        }

        CalculateVelocitySpeed();
        if (velocitySpeed != 0)
        {
            animator.SetBool("Sprinting", true);
            moving = true;
        }
        if (velocitySpeed == 0)
        {
            animator.SetBool("Sprinting", false);
            moving = false;
        }

        if (Input.GetMouseButton(1))
        {
            if (position.x != 0 && position.y != 0)
            {
                currentPosition = position / 200;
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SwichCamera();
        }
    }

    void CalculateVelocitySpeed()
    {
        x = navMeshAgent.velocity.x;
        z = navMeshAgent.velocity.z;
        velocitySpeed = x + z;
    }

    void SwichCamera()
    {
        isFreeCameraActive = !isFreeCameraActive;
        cameraFree.SetActive(isFreeCameraActive);
        cameraStatic.SetActive(!isFreeCameraActive);
    }
}
