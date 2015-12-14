using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerPicups : MonoBehaviour {
	
	public Text countText;
	public Text winText;
	private int count;

	void Start ()
	{
		count = 0;
		SetCountText();
		winText.text = "";
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();
        }
    }
	void SetCountText()
	{
		countText.text = "Count: " + count.ToString() + " out of 20";
		if (count >= 20) {
			winText.text = "YOU WIN!";
		}
}
}