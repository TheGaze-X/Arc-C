using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur")]
	public class Blur : MonoBehaviour
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		protected Material material
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x51D7950", Offset = "0x51D6550", VA = "0x1851D7950")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x51D7450", Offset = "0x51D6050", VA = "0x1851D7450")]
		protected void OnDisable()
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x51D7880", Offset = "0x51D6480", VA = "0x1851D7880")]
		protected void Start()
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x51D7320", Offset = "0x51D5F20", VA = "0x1851D7320")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x51D7200", Offset = "0x51D5E00", VA = "0x1851D7200")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x51D74F0", Offset = "0x51D60F0", VA = "0x1851D74F0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x51D7930", Offset = "0x51D6530", VA = "0x1851D7930")]
		public Blur()
		{
		}

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 10f)]
		public int iterations;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float blurSpread;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x0")]
		private static Material m_Material;
	}
}
