using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	[AddComponentMenu("Effects/Post-Processing Behaviour", -1)]
	[RequireComponent(typeof(Camera))]
	[ImageEffectAllowedInSceneView]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class PostProcessingBehaviour : MonoBehaviour
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x542B730", Offset = "0x542A330", VA = "0x18542B730")]
		private void OnEnable()
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x542C690", Offset = "0x542B290", VA = "0x18542C690")]
		private void OnPreCull()
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x542CED0", Offset = "0x542BAD0", VA = "0x18542CED0")]
		private void OnPreRender()
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x542C590", Offset = "0x542B190", VA = "0x18542C590")]
		private void OnPostRender()
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x542CFE0", Offset = "0x542BBE0", VA = "0x18542CFE0")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x542C230", Offset = "0x542AE30", VA = "0x18542C230")]
		private void OnGUI()
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x542B2C0", Offset = "0x5429EC0", VA = "0x18542B2C0")]
		private void OnDisable()
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x542D740", Offset = "0x542C340", VA = "0x18542D740")]
		public void ResetTemporalEffects()
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x542ADA0", Offset = "0x54299A0", VA = "0x18542ADA0")]
		private void CheckObservers()
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x542B180", Offset = "0x5429D80", VA = "0x18542B180")]
		private void DisableComponents()
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BC")]
		private CommandBuffer AddCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			return null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BD")]
		private void RemoveCommandBuffer<T>() where T : PostProcessingModel
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BE")]
		private CommandBuffer GetCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			return null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BF")]
		private void TryExecuteCommandBuffer<T>(PostProcessingComponentCommandBuffer<T> component) where T : PostProcessingModel
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x60003C0")]
		private bool TryPrepareUberImageEffect<T>(PostProcessingComponentRenderTexture<T> component, Material material) where T : PostProcessingModel
		{
			return default(bool);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C1")]
		private T AddComponent<T>(T component) where T : PostProcessingComponentBase
		{
			return null;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x542D7B0", Offset = "0x542C3B0", VA = "0x18542D7B0")]
		public PostProcessingBehaviour()
		{
		}

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0x18")]
		public PostProcessingProfile profile;

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0x20")]
		public Func<Vector2, Matrix4x4> jitteredMatrixFunc;

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>> m_CommandBuffers;

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x30")]
		private List<PostProcessingComponentBase> m_Components;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<PostProcessingComponentBase, bool> m_ComponentStates;

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x40")]
		private MaterialFactory m_MaterialFactory;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x48")]
		private RenderTextureFactory m_RenderTextureFactory;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x50")]
		private PostProcessingContext m_Context;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x58")]
		private Camera m_Camera;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x60")]
		private PostProcessingProfile m_PreviousProfile;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x68")]
		private bool m_RenderingInSceneView;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x70")]
		private BuiltinDebugViewsComponent m_DebugViews;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x78")]
		private AmbientOcclusionComponent m_AmbientOcclusion;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x80")]
		private ScreenSpaceReflectionComponent m_ScreenSpaceReflection;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x88")]
		private FogComponent m_FogComponent;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x90")]
		private MotionBlurComponent m_MotionBlur;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x98")]
		private TaaComponent m_Taa;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0xA0")]
		private EyeAdaptationComponent m_EyeAdaptation;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0xA8")]
		private DepthOfFieldComponent m_DepthOfField;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0xB0")]
		private BloomComponent m_Bloom;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0xB8")]
		private ChromaticAberrationComponent m_ChromaticAberration;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0xC0")]
		private ColorGradingComponent m_ColorGrading;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0xC8")]
		private UserLutComponent m_UserLut;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0xD0")]
		private GrainComponent m_Grain;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0xD8")]
		private VignetteComponent m_Vignette;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0xE0")]
		private DitheringComponent m_Dithering;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0xE8")]
		private FxaaComponent m_Fxaa;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0xF0")]
		private List<PostProcessingComponentBase> m_ComponentsToEnable;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0xF8")]
		private List<PostProcessingComponentBase> m_ComponentsToDisable;
	}
}
