using UnityEngine;

public class SpinningAround : MonoBehaviour
{
    [SerializeField] private float _speedRotating;

    private void Update()
    {
        transform.Rotate(Vector3.up * _speedRotating * Time.deltaTime);
    }
}