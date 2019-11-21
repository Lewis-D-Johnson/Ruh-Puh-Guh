using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
	[SerializeField] Transform Target;
	[SerializeField] float followSpeed;

    void FixedUpdate()
    {
		Vector3 MoveToPos = new Vector3(Target.position.x, Target.position.y, -10);

		transform.position = Vector3.Lerp(transform.position, MoveToPos, followSpeed * Time.deltaTime);
    }
}
