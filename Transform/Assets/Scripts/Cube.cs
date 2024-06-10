using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private float _speedRotating;

    private void Update()
    {
        _cube.transform.Rotate(Vector3.up * _speedRotating * Time.deltaTime);
    }
}