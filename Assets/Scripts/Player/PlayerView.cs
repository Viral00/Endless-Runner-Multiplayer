using UnityEngine;
using Photon.Pun;

public class PlayerView : MonoBehaviourPunCallbacks
{
    private PlayerStates currentState;
    public PlayerIdle playerIdle;
    public PlayerRun playerRun;
    private PhotonView photonview;
    private Rigidbody rb;
    [SerializeField] private float moveSpeed = 20f;
    public bool isRun = false;

    public void Awake()
    {
        photonview = GetComponent<PhotonView>();
    }

    private void Start()
    {
        ChangeState(playerIdle);

        rb = GetComponent<Rigidbody>();

        if (!photonview.IsMine)
        {
            Destroy(GetComponentInChildren<Camera>().gameObject);
            Destroy(GetComponentInChildren<Light>().gameObject);
            Destroy(rb);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ChangeState(playerRun);
            Debug.Log("Changing State to Run");
        }

        else if (Input.GetKeyUp(KeyCode.Return))
        {
            ChangeState(playerIdle);
            Debug.Log("Changing State to Idle");
        }
    }

    private void FixedUpdate()
    {
        if (!photonview.IsMine)
            return;
        else if(isRun && photonview.IsMine)
            PLayerMove(rb, transform);
    }

    public void ChangeState(PlayerStates newState)
    {
        if (currentState != null)
        {
            currentState.OnExitState();
        }

        currentState = newState;

        newState.OnEnterState();
    }

    public void PLayerMove(Rigidbody rb, Transform transform)
    {
        Vector3 movedir = new Vector3(0, 0, 300).normalized;
        rb.MovePosition(rb.position + transform.TransformDirection(movedir) * moveSpeed * Time.fixedDeltaTime);
    }
}
