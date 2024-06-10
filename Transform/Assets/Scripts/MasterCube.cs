using UnityEngine;

public class MasterCube : MonoBehaviour
{
    [SerializeField] private GameObject _masterCube;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _growthSpeed;
    [SerializeField] private float _rotationSpeed;

    private float _cubeScale = 1f;

    private void Update()
    {
        _masterCube.transform.Translate(_masterCube.transform.forward * _movementSpeed * Time.deltaTime);

        _masterCube.transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);

        _cubeScale += _growthSpeed * Time.deltaTime;
        _masterCube.transform.localScale = new Vector3(_cubeScale, _cubeScale, _cubeScale);
    }
}
