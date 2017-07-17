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

		[Tooltip("Post-processing profile for EM vision")]
		[SerializeField]
		private PostProcessingProfile emVisionProfile;

		[Tooltip("Shader to overwrite normal shaders with for thermal vision effect")]
		[SerializeField]
		private Shader thermalShader;

		[Tooltip("Shader to overwrite normal shaders for EM vision effect")]
		[SerializeField]
		private Shader emShader;

		[Tooltip("Container for the thumbnail cameras")]
		[SerializeField]
		private Transform thumbnailCameraContainer;

		private Camera postProcessingCamera;
		private PostProcessingBehaviour postProcessingBehaviour;

		private void Awake()
		{
			postProcessingCamera = GetComponent<Camera>();
			postProcessingBehaviour = GetComponent<PostProcessingBehaviour>();
		}

		private void Start()
		{
			EnableNormalVision();
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
			thumbnailCameraContainer.gameObject.SetActive(false);
			postProcessingBehaviour.profile = normalVisionProfile;
			postProcessingCamera.ResetReplacementShader();
		}

		/// <summary>
		/// Makes the camera render thermal vision
		/// </summary>
		private void EnableThermalVision()
		{
			thumbnailCameraContainer.gameObject.SetActive(false);
			postProcessingBehaviour.profile = thermalVisionProfile;
			postProcessingCamera.SetReplacementShader(thermalShader, DefaultShaderTag);
		}

		/// <summary>
		/// Makes the camera render in night vision
		/// </summary>
		private void EnableNightVision()
		{
			thumbnailCameraContainer.gameObject.SetActive(false);
			postProcessingBehaviour.profile = nightVisionProfile;
			postProcessingCamera.ResetReplacementShader();
		}

		/// <summary>
		/// Makes the camera render EM vision
		/// </summary>
		private void EnableEMVision()
		{
			thumbnailCameraContainer.gameObject.SetActive(false);
			postProcessingBehaviour.profile = emVisionProfile;
			postProcessingCamera.SetReplacementShader(emShader, DefaultShaderTag);
		}

		/// <summary>
		/// Makes the camera render normal vision, with 3 picture in pictures rendered in night, thermal, and EM visions
		/// </summary>
		private void EnableSpecialVision()
		{
			postProcessingBehaviour.profile = normalVisionProfile;
			postProcessingCamera.ResetReplacementShader();
			thumbnailCameraContainer.gameObject.SetActive(true);
		}
	}
}