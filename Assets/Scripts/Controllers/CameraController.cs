using System;
using UnityEngine;
using UnityEngine.PostProcessing;

namespace Syncity
{
	[RequireComponent(typeof(PostProcessingBehaviour))]
	public class CameraController : MonoBehaviour
	{
		[Tooltip("Post-processing profile for normal vision")]
		[SerializeField]
		private PostProcessingProfile normalVision;

		[Tooltip("Post-processing profile for thermal vision")]
		[SerializeField]
		private PostProcessingProfile thermalVision;

		[Tooltip("Post-processing profile for night vision")]
		[SerializeField]
		private PostProcessingProfile nightVision;
		
		private PostProcessingBehaviour postProcessingBehaviour;

		private void Awake()
		{
			postProcessingBehaviour = GetComponent<PostProcessingBehaviour>();
		}

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
			postProcessingBehaviour.profile = normalVision;
		}

		/// <summary>
		/// Makes the camera render thermal vision
		/// </summary>
		private void EnableThermalVision()
		{
			postProcessingBehaviour.profile = thermalVision;
		}

		/// <summary>
		/// Makes the camera render in night vision
		/// </summary>
		private void EnableNightVision()
		{
			postProcessingBehaviour.profile = nightVision;
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