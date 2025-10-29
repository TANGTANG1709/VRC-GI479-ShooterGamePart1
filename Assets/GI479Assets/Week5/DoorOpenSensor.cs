using UnityEngine;
using UnityEngine.Events;

public class DoorOpenSensor : MonoBehaviour
{
    public Transform PlayerTransform;
    public Animator DoorAnimator;
    public float Distance = 3;

    public UnityEvent OnDoorOpen;
    public UnityEvent OnDoorClose;

    private bool isDoorOpen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isDoorOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDoorOpen && Vector3.Distance(transform.position, PlayerTransform.position) < Distance)
        {
<<<<<<< HEAD
            Open();
        }
        else if (isDoorOpen && Vector3.Distance(transform.position, PlayerTransform.position) > Distance)
        {
            Close();
        }
    }

    public void Open()
    {
        DoorAnimator.Play("Open");
        isDoorOpen = true;
        OnDoorOpen?.Invoke();
    }

    public void Close()
    {
        DoorAnimator.Play("Close");
        isDoorOpen = false;
        OnDoorClose?.Invoke();
    }

=======
            DoorAnimator.Play("Open");
            isDoorOpen = true;

            // if (OnDoorOpen != null)
            // {
            //     OnDoorOpen.Invoke();
            // }
            OnDoorOpen?.Invoke();
        }
        else if (isDoorOpen && Vector3.Distance(transform.position, PlayerTransform.position) > Distance)
        {
            DoorAnimator.Play("Close");
            isDoorOpen = false;
            OnDoorClose?.Invoke();
        }
    }

>>>>>>> 5f5fc35a554c643ae90d9aa19fe6370c73aee576
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Distance);
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 5f5fc35a554c643ae90d9aa19fe6370c73aee576
