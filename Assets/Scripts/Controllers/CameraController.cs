using System;
using UnityEngine;

namespace Syncity
{
	public class CameraController : MonoBehaviour
	{
		private void Update()
		{
			if (Input.GetButtonDown(InputNames.NormalVision))
			{
				EnableNormalVision();
			}
			if (Input.GetButtonDown(InputNames.ThermalVision))
			{
				EnableThermalVision();
			}
			if (Input.GetButtonDown(InputNames.NightVision))
			{
				EnableNightVision();
			}
			if (Input.GetButtonDown(InputNames.EMVision))
			{
				EnableEMVision();
			}
			if (Input.GetButtonDown(InputNames.SpecialVision))
			{
				EnableSpecialVision();
			}
		}

		/// <summary>
		/// Makes the camera render normally without any added effects
		/// </summary>
		private void EnableNormalVision()
		{
			throw new NotImplementedException("Normal Vision");
		}

		/// <summary>
		/// Makes the camera render thermal vision
		/// </summary>
		private void EnableThermalVision()
		{
			throw new NotImplementedException("Thermal Vision");
		}

		/// <summary>
		/// Makes the camera render in night vision
		/// </summary>
		private void EnableNightVision()
		{
			throw new NotImplementedException("Night Vision");
		}

		/// <summary>
		/// Makes the camera render EM vision
		/// </summary>
		private void EnableEMVision()
		{
			throw new NotImplementedException("EM Vision");
		}

		/// <summary>
		/// Makes the camera render normal vision, with 3 picture in pictures rendered in night, thermal, and EM visions
		/// </summary>
		private void EnableSpecialVision()
		{
			throw new NotImplementedException("Special Vision");
		}
	}
}