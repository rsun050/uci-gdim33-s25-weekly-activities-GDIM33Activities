using Unity;
using UnityEngine;

public class VFX : MonoBehaviour
{
	[SerializeField] ParticleSystem vfx;

	public void Handler()
	{
		vfx.Play();
	}
}