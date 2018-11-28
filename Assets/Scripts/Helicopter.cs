using UnityEngine;

public class Helicopter : MonoBehaviour
{
    private Rigidbody rigidBody;

    private bool called;


    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public void OnDispatchHelicopter()
    {
        if (!called)
        {
            rigidBody.velocity = new Vector3(0f, 0f, 50f);

            called = true;
        }
    }
}
