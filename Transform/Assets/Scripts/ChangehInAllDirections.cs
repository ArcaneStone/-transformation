using UnityEngine;

public class ChangehInAllDirections : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;

    private float _increaseScale = 1;

    private void Update()
    {
        _increaseScale += _growthSpeed * Time.deltaTime;
        transform.localScale = new Vector3(_increaseScale, _increaseScale, _increaseScale);
    }
}
