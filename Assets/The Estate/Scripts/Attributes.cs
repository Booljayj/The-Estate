using UnityEngine;
using System.Collections;

public class Attributes : MonoBehaviour {
	//==== Health
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

	//==== Mana
	[SerializeField] int maxMana;
	[SerializeField] int curMana;
	public int Mana {
		get {
			return curMana;
		}
		set {
			curMana = Mathf.Clamp(curMana + value, 0, maxMana);
		}
	}

	[SerializeField] float regenMana;

	//==== Stamina
	[SerializeField] int maxStamina;
	[SerializeField] int curStamina;
	public int Stamina {
		get {
			return curStamina;
		}
		set {
			curStamina = Mathf.Clamp(curStamina + value, 0, maxStamina);
		}
	}

	[SerializeField] float regenStamina;

	//==== Methods
	void Update() {

	}
}
