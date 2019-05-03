using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
	
	private Image bgImg;
	private Image joystickImg;
	private Vector3 inputVector;
	private GameObject Camera;
	private Vector3 iV;
	private bool buttonClicked;
	private int count;


	private void Start()
	{
		Vector3 iV = new Vector3(0f,0f,-10f);
		bgImg = GetComponent<Image>();
		joystickImg = transform.GetChild(0).GetComponent<Image>();
		buttonClicked = false;
		count = 0;
	}	
	
	public void OnButtonClick()
	{

		
		if (buttonClicked)
		{
			buttonClicked = false;
		}
		
		if (!buttonClicked)
			buttonClicked = true;
		

	}
	
	private void Update()
	{
		
		{
			if (buttonClicked)
				count++;
			
			if (count == 10)
			{
				buttonClicked = false;
				count = 0;
			}
			
			Camera = GameObject.FindGameObjectWithTag("MainCamera");
			
			if (Camera.transform.position.x <= -0.08f)
				if (inputVector.x < 0)
					Camera.transform.position = new Vector3(-0.08f, iV.y, -10f);
			if (Camera.transform.position.x >= 2.32f)
				if (inputVector.x > 0)
					Camera.transform.position = new Vector3(2.32f, iV.y, -10f);
			
			if (Camera.transform.position.y >= -1.88f && Camera.transform.position.y < 0.28f)
			{
				if (inputVector.z < 0 && Camera.transform.position.y == -1.88)
					Camera.transform.position += new Vector3(inputVector.x * 0.05f, 0f);
				else 
					Camera.transform.position += new Vector3(inputVector.x * 0.05f, inputVector.z * 0.05f);
				iV = new Vector3(Camera.transform.position.x, Camera.transform.position.y, -10f);
			}
			if (Camera.transform.position.y == 0.28f)
			{
				if (inputVector.z > 0)
					Camera.transform.position += new Vector3(inputVector.x * 0.05f, 0f);
				else 
					Camera.transform.position += new Vector3(inputVector.x * 0.05f, inputVector.z * 0.05f);
				iV = new Vector3(Camera.transform.position.x, Camera.transform.position.y, -10f);
			}
		        if (Camera.transform.position.y > 0.28f)
			{
				Camera.transform.position = new Vector3(iV.x, 0.28f, -10f);
			}
			if (Camera.transform.position.y <= -1.88f)
			{
				Camera.transform.position = new Vector3(iV.x, -1.88f, -10f);
			
			}
		}
	}
	
	public virtual void OnDrag(PointerEventData ped)
	{
		

		Vector2 pos;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform,
																	ped.position,
																	ped.pressEventCamera,
																	out pos))
		{
			pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x);
			pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y);
			inputVector = new Vector3(pos.x*2 + 1,0,pos.y * 2 - 1);
			inputVector = (inputVector.magnitude > 1.0f)?inputVector.normalized:inputVector;
			
			joystickImg.rectTransform.anchoredPosition = 
				new Vector3(inputVector.x * (bgImg.rectTransform.sizeDelta.x/3)
							, inputVector.z * (bgImg.rectTransform.sizeDelta.y/3));				
		}

		

		
	}
	
	public virtual void OnPointerDown(PointerEventData ped)
	{
		OnDrag(ped);
		
	}
	public virtual void OnPointerUp(PointerEventData ped)
	{
		inputVector = Vector3.zero;
		joystickImg.rectTransform.anchoredPosition = Vector3.zero;
		
	}
	
	
}
