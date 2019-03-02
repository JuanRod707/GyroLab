using UnityEngine;

namespace Assets
{
    public class RotateCube : MonoBehaviour
    {
        void Update()
        {
            transform.rotation = Input.gyro.attitude;
        }
    }
}
