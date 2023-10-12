using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; // �����, �� ������� ������� ������
    public float distance = 10.0f; // ���������� ����� ������� � �������
    public float height = 5.0f; // ������ ������ ��� �������
    public float smoothSpeed = 0.125f; // �������� ����������� ������

    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(0, height, -distance);
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}