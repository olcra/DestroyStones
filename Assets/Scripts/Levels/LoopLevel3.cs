using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoopLevel3: MonoBehaviour {

	public GameObject[] stones = new GameObject[3];
	public GameObject[] bombs = new GameObject[1];
	public GameObject[] lives = new GameObject[1];
	public float torque = 5.0f;
	public float minAntiGravity = 20.0f, maxAntiGravity = 40.0f;
	public float minLateralForce = -15.0f, maxLateralForce = 15.0f;
	public float minTimeBetweenStones = 0.5f, maxTimeBetweenStones = 1f;
	public float minTimeBetweenBomb = 1f, maxTimeBetweenBomb = 3f;
	public float minTimeBetweenLife = 20f, maxTimeBetweenLife = 30f;
	public float minX = -30.0f, maxX = 30.0f;
	public float minZ = -5.0f, maxZ = 20.0f;

	private bool enableStones = true;
	private bool enableBomb = true;
	private bool enableLife = true;
	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		StartCoroutine (ThrowStones ());
		StartCoroutine (ThrowBomb ());
		StartCoroutine (ThrowLife ());
	}

	// Update is called once per frame
	void Update () {
		if (GameManager.lives == 0 || GameManager.currentNumberStonesThrown == 20 || GameManager.currentNumberDestroyedStones == 20) {
			SceneManager.LoadScene ("Final");
		}
	}

	IEnumerator ThrowStones()
	{
		// Initial delay
		yield return new WaitForSeconds(2.0f);

		while(enableStones) {							

			GameObject stone = (GameObject) Instantiate(stones[Random.Range(0, stones.Length)]);
			stone.transform.position = new Vector3(Random.Range(minX, maxX), -30.0f, Random.Range(minZ, maxZ));
			stone.transform.rotation = Random.rotation;

			rigidbody = stone.GetComponent<Rigidbody>();

			rigidbody.AddTorque(Vector3.up * torque, ForceMode.Impulse);
			rigidbody.AddTorque(Vector3.right * torque, ForceMode.Impulse);
			rigidbody.AddTorque(Vector3.forward * torque, ForceMode.Impulse);

			rigidbody.AddForce(Vector3.up * Random.Range(minAntiGravity, maxAntiGravity), ForceMode.Impulse);
			rigidbody.AddForce(Vector3.right * Random.Range(minLateralForce, maxLateralForce), ForceMode.Impulse);

			GameManager.currentNumberStonesThrown++;

			yield return new WaitForSeconds(Random.Range(minTimeBetweenStones, maxTimeBetweenStones));

		}

	}

	IEnumerator ThrowBomb ()
	{
		yield return new WaitForSeconds(5.0f);

		while (enableBomb) {

			GameObject bomb = (GameObject) Instantiate(bombs[0]);
			bomb.transform.position = new Vector3 (Random.Range (minX, maxX), -30.0f, Random.Range (minZ, maxZ));
			bomb.transform.rotation = Random.rotation;
			rigidbody = bomb.GetComponent<Rigidbody> ();

			rigidbody.AddTorque (Vector3.up * torque, ForceMode.Impulse);
			rigidbody.AddTorque (Vector3.right * torque, ForceMode.Impulse);
			rigidbody.AddTorque (Vector3.forward * torque, ForceMode.Impulse);
			rigidbody.AddForce (Vector3.up * Random.Range (minAntiGravity, maxAntiGravity), ForceMode.Impulse);
			rigidbody.AddForce (Vector3.right * Random.Range (minLateralForce, maxLateralForce), ForceMode.Impulse);

			yield return new WaitForSeconds (Random.Range (minTimeBetweenBomb, maxTimeBetweenBomb));
		}
	}

	IEnumerator ThrowLife ()
	{
		yield return new WaitForSeconds(10.0f);

		while (enableLife && GameManager.lives < 5) {

			GameObject life = (GameObject) Instantiate(lives[0]);
			life.transform.position = new Vector3 (Random.Range (minX, maxX), -30.0f, Random.Range (minZ, maxZ));
			life.transform.rotation = Random.rotation;
			rigidbody = life.GetComponent<Rigidbody> ();

			rigidbody.AddTorque (Vector3.up * torque, ForceMode.Impulse);
			rigidbody.AddTorque (Vector3.right * torque, ForceMode.Impulse);
			rigidbody.AddTorque (Vector3.forward * torque, ForceMode.Impulse);
			rigidbody.AddForce (Vector3.up * Random.Range (minAntiGravity, maxAntiGravity), ForceMode.Impulse);
			rigidbody.AddForce (Vector3.right * Random.Range (minLateralForce, maxLateralForce), ForceMode.Impulse);

			yield return new WaitForSeconds (Random.Range (minTimeBetweenLife, maxTimeBetweenLife));
		}
	}
}

