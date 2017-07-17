using UnityEngine;
using UnityEngine.PostProcessing;

namespace Syncity
{
	[RequireComponent(typeof(Camera))]
	[RequireComponent(typeof(PostProcessingBehaviour))]
	public class VisionCamera : MonoBehaviour
	{
		private const string DefaultShaderTag = "RenderType";

		[Tooltip("Post-processing profile for vision")]
		[SerializeField]
		private PostProcessingProfile postProcessingProfile;

		[Tooltip("Shader to overwrite normal shaders with for vision effect")]
		[SerializeField]
		private Shader shader;

		private Camera postProcessingCamera;
		private PostProcessingBehaviour postProcessingBehaviour;

		private void Awake()
		{
			postProcessingCamera = GetComponent<Camera>();
			postProcessingBehaviour = GetComponent<PostProcessingBehaviour>();
		}

		private void Start()
		{
			BeginRenderingVisionEffect();
		}

		/// <summary>
		/// Renders the vision effect
		/// </summary>
		private void BeginRenderingVisionEffect()
		{
			if (postProcessingProfile)
			{
				postProcessingBehaviour.profile = postProcessingProfile;
			}
			if (shader)
			{
				postProcessingCamera.SetReplacementShader(shader, DefaultShaderTag);
			}
		}
	}
}