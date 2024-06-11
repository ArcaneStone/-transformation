using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedRotating;

    private void Update()
    {
        transform.Rotate(Vector3.up * _speedRotating * Time.deltaTime);
    }
}