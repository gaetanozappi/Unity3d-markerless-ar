using UnityEngine;

public class PlayerExample : MonoBehaviour {

    public float moveSpeed;
    public Joystick joystick;

	void Update () 
	{
        //Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical).normalized;
        //transform.Translate(-moveVector * moveSpeed * Time.deltaTime);
        //transform.Translate(-joystick.Horizontal,0,0);
        //transform.Rotate(0,-joystick.Horizontal,0);
        //transform.Translate(-joystick.Horizontal,0,0);
        Debug.Log("H:"+joystick.Horizontal+" V:"+joystick.Vertical);
        float H = joystick.Horizontal;
        float V = joystick.Vertical;
        if(H>0.5){
        	float yRotation = 90;
            Quaternion target = Quaternion.Euler(0, yRotation, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.time*0.1f);
            Vector3 moveVector = (Vector3.forward * joystick.Horizontal).normalized;
        	transform.Translate(moveVector * moveSpeed * Time.deltaTime);
        }else if(H<0 && H<-0.5){
			float yRotation = 270;
            Quaternion target = Quaternion.Euler(0, yRotation, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.time*0.1f);
            Vector3 moveVector = (Vector3.forward * joystick.Horizontal).normalized;
        	transform.Translate(-moveVector * moveSpeed * Time.deltaTime);
        }
        if(V>0.5){
        	float yRotation = 0;
            Quaternion target = Quaternion.Euler(0, yRotation, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.time*0.1f);
            Vector3 moveVector = (Vector3.forward * joystick.Vertical).normalized;
        	transform.Translate(moveVector * moveSpeed * Time.deltaTime);
            //transform.localScale += new Vector3(0.001F, 0.001F, 0);
        }else if(V<0 && V<-0.5){
			float yRotation = 180;
            Quaternion target = Quaternion.Euler(0, yRotation, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.time*0.1f);
            Vector3 moveVector = (Vector3.forward * joystick.Vertical).normalized;
        	transform.Translate(-moveVector * moveSpeed * Time.deltaTime);
            //transform.localScale -= new Vector3(0.001F, 0.001F, 0);
        }

      
	}
}