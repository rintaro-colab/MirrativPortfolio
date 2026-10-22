using UnityEngine;

public class CameraFollow : MonoBehaviour
{

public Transform target ;
public Vector3 offset = new Vector3(0, 0.5f, -10);
//smoothSpeed = Cmeraが目的位置へ近づく速さ
public float smoothSpeed = 5.0f;
//Playerの移動後にCameraを追従させる
    void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        /*Vector3.Lerp(A, B, t)
        A = 出発地点(Cameraの現在位置)
        B = 目的地点(targetPosition)
        t = AからBへ、どれくらい近づくか*/
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
    }
}
