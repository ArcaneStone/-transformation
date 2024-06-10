using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private GameObject _sphere;
    [SerializeField] private float _sphereSpeed;

    private void Update()
    {
        _sphere.transform.Translate(Vector3.forward * _sphereSpeed * Time.deltaTime);
    }
}
