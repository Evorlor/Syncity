using System;
using UnityEngine;
using UnityEngine.PostProcessing;

namespace Syncity
{
	[RequireComponent(typeof(Camera))]
	[RequireComponent(typeof(PostProcessingBehaviour))]
	public class CameraController : MonoBehaviour
	{
		private const string DefaultShaderTag = "RenderType";

		[Tooltip("Post-processing profile for normal vision")]
		[SerializeField]
		private PostProcessingProfile normalVisionProfile;

		[Tooltip("Post-processing profile for thermal vision")]
		[SerializeField]
		private PostProcessingProfile thermalVisionProfile;

		[Tooltip("Post-processing profile for night vision")]
		[SerializeField]
		private PostProcessingProfile nightVisionProfile;

		[Tooltip("Shader to overwrite normal shaders with for thermal vision effect")]
		[SerializeField]
		private Shader thermalShader;

		private Camera postProcessingCamera;
		private PostProcessingBehaviour postProcessingBehaviour;

		private void Awake()
		{
			postProcessingCamera = GetComponent<Camera>();
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
			postProcessingBehaviour.profile = normalVisionProfile;
			postProcessingCamera.ResetReplacementShader();
		}

		/// <summary>
		/// Makes the camera render thermal vision
		/// </summary>
		private void EnableThermalVision()
		{
			postProcessingBehaviour.profile = thermalVisionProfile;
			postProcessingCamera.SetReplacementShader(thermalShader, DefaultShaderTag);
		}

		/// <summary>
		/// Makes the camera render in night vision
		/// </summary>
		private void EnableNightVision()
		{
			postProcessingBehaviour.profile = nightVisionProfile;
			postProcessingCamera.ResetReplacementShader();
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