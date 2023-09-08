using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectCollisions : MonoBehaviour
{
	// OnTriggerEnter2D kullanmalısınız, çünkü 2D Box Collider kullanıyorsunuz.
	private void OnTriggerEnter2D(Collider2D other)
	{
		// Sadece "Bullet" etiketine sahip nesnelerle çarpışmayı kontrol edelim
		
		
			// Çarpışan mermiyi yok et
			Destroy(other.gameObject);

			// Kendi nesnenizi yok et
			Destroy(gameObject);
		
	}
}