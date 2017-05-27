using UnityEngine;

public class SceneCameraMovement : MonoBehaviour 
{
	public float sensitivityX = 4F;
	public float sensitivityY = 4F;

	private float origMoveSpeed;
	public float moveSpeed = 1f;
	
	private float mHdg = 0f;
	private float mPitch = 0f;

	private void Start()
	{
		origMoveSpeed = moveSpeed;
		mPitch = transform.localEulerAngles.x;
		mHdg = transform.localEulerAngles.y;
	}

	private void Update()
	{
		if (Input.GetKey(KeyCode.LeftShift))
			moveSpeed = 5.0f * origMoveSpeed;
		else
			moveSpeed = origMoveSpeed;

		if (Input.GetMouseButton(1))
		{
			float deltaX = Input.GetAxisRaw("Mouse X") * sensitivityX;
			float deltaY = Input.GetAxisRaw("Mouse Y") * sensitivityY;

			ChangeHeading(deltaX);
			ChangePitch(-deltaY);
		}

		if (Input.GetKey(KeyCode.D))
			Strafe(moveSpeed * Time.smoothDeltaTime);
		else if(Input.GetKey(KeyCode.A))
			Strafe(-moveSpeed * Time.smoothDeltaTime);

		if (Input.GetKey (KeyCode.W))
			MoveForwards (moveSpeed * Time.smoothDeltaTime);
		else if(Input.GetKey(KeyCode.S))
			MoveForwards(-moveSpeed * Time.smoothDeltaTime);

		if (Input.GetKey(KeyCode.Space))
			ChangeHeight(moveSpeed * Time.smoothDeltaTime);
	}
	
	void MoveForwards(float aVal)
	{
		transform.position += aVal * transform.forward;
	}
	
	void Strafe(float aVal)
	{
		transform.position += aVal * transform.right;
	}
	
	void ChangeHeight(float aVal)
	{
		transform.position += aVal * Vector3.up;
	}
	
	void ChangeHeading(float aVal)
	{
		mHdg += aVal;
		mHdg = WrapAngle(mHdg);
		transform.localEulerAngles = new Vector3(mPitch, mHdg, 0);
	}
	
	void ChangePitch(float aVal)
	{
		mPitch += aVal;
		mPitch = WrapAngle(mPitch);
		transform.localEulerAngles = new Vector3(mPitch, mHdg, 0);
	}
	
	public static float WrapAngle(float angle)
	{
		if (angle < -360F)
			return angle + 360F;

		if (angle > 360F)
			return angle - 360F;

		return angle;
	}
}
