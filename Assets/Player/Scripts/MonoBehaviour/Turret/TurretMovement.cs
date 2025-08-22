using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    [Header("Turret Movement Vars")]
    [SerializeField] float TurretMoveSpeed;
    
    //Input Manager and Character Controller reference vars
    private InputManager inputManager;
    private CharacterController controller;

    //Turret Platform Transform reference var
    private Transform turretPlatform;

    private void Start()
    {
        inputManager = InputManager.Instance;
        controller = GetComponent<CharacterController>();
        turretPlatform = transform.parent.GetChild(0).gameObject.transform;
    }


    private void Update()
    {

        Move();
    }

    //Handles horizontal movement of turret
    private void Move()
    {
        float x = inputManager.GetPlayerMovement().x;
        float z = inputManager.GetPlayerMovement().y;
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * Time.deltaTime * TurretMoveSpeed);

        ClampMovement();
    }

    //Clamps turret horizontal movement to the size of the platform game object (Prevents turret from moving off of the train)
    private void ClampMovement()
    {
        //Clamp turret X position to platform length
        if (this.transform.position.x > turretPlatform.transform.localScale.x / 2)
        {
            this.transform.position = new Vector3(turretPlatform.transform.localScale.x / 2, transform.position.y, transform.position.z);
        }
        else if (this.transform.position.x < -turretPlatform.transform.localScale.z / 2)
        {
            this.transform.position = new Vector3(-turretPlatform.transform.localScale.x / 2, transform.position.y, transform.position.z);
        }

        //Clamp turret Z position to platform width
        if (this.transform.position.z > turretPlatform.transform.localScale.z / 2)
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y, turretPlatform.transform.localScale.z / 2);
        }
        else if (this.transform.position.z < -turretPlatform.transform.localScale.z / 2)
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y, -turretPlatform.transform.localScale.z / 2);
        }
    }


}
