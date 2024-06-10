using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private GameObject _capsule;
    [SerializeField] private float _growthSpeed;

    private float _capsuleScale = 1;

    private void Update()
    {
        _capsuleScale += _growthSpeed * Time.deltaTime;
        _capsule.transform.localScale = new Vector3(_capsuleScale, _capsuleScale, _capsuleScale);
    }
}
