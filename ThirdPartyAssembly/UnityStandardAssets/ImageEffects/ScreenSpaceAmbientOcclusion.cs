using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x52FE550", Offset = "0x52FD150", VA = "0x1852FE550")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x52FE760", Offset = "0x52FD360", VA = "0x1852FE760")]
		private static void DestroyMaterial(Material mat)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x52FE7E0", Offset = "0x52FD3E0", VA = "0x1852FE7E0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x52FF010", Offset = "0x52FDC10", VA = "0x1852FF010")]
		private void Start()
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x52FE860", Offset = "0x52FD460", VA = "0x1852FE860")]
		private void OnEnable()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x52FE600", Offset = "0x52FD200", VA = "0x1852FE600")]
		private void CreateMaterials()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x52FE8D0", Offset = "0x52FD4D0", VA = "0x1852FE8D0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x52FF0D0", Offset = "0x52FDCD0", VA = "0x1852FF0D0")]
		public ScreenSpaceAmbientOcclusion()
		{
		}

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x18")]
		[Range(0.05f, 1f)]
		public float m_Radius;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x1C")]
		public ScreenSpaceAmbientOcclusion.SSAOSamples m_SampleCount;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x20")]
		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 4f)]
		public int m_Blur;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 6f)]
		public int m_Downsampling;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x30")]
		[Range(1E-05f, 0.5f)]
		public float m_MinZ;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		// Token: 0x02000061 RID: 97
		[Token(Token = "0x2000061")]
		public enum SSAOSamples
		{
			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400028D")]
			Low,
			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			Medium,
			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			High
		}
	}
}
