using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private float _sphereSpeed;

    private void Update()
    {
        transform.Translate(Vector3.forward * _sphereSpeed * Time.deltaTime);
    }
}
