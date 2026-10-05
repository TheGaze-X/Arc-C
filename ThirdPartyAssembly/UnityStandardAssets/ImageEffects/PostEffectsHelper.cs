using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class PostEffectsHelper : MonoBehaviour
	{
		// Token: 0x0600023E RID: 574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x52FB880", Offset = "0x52FA480", VA = "0x1852FB880")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x52FB3F0", Offset = "0x52F9FF0", VA = "0x1852FB3F0")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x52FB070", Offset = "0x52F9C70", VA = "0x1852FB070")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x52FB6B0", Offset = "0x52FA2B0", VA = "0x1852FB6B0")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public PostEffectsHelper()
		{
		}
	}
}
