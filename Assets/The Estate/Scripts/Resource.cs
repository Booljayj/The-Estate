using UnityEngine;
using System.Collections;

[System.Serializable]
public class Resource {
	[SerializeField] int maxHealth;
	[SerializeField] int curHealth;
	public int Health {
		get {
			return curHealth;
		}
		set {
			curHealth = Mathf.Clamp(curHealth + value, 0, maxHealth);
		}
	}
	
	[SerializeField] float regenHealth;
}
