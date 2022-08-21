using TMPro;
using UnityEngine;

public class ShowVelocity : MonoBehaviour
{
	public Rigidbody rb;
	public TMP_Text text;

	private void Update()
	{
		text.text = $"{rb.velocity.magnitude:N1} m/s";
	}
}