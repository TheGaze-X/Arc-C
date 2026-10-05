using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	public sealed class RenderTextureFactory : IDisposable
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x54308C0", Offset = "0x542F4C0", VA = "0x1854308C0")]
		public RenderTextureFactory()
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x5430510", Offset = "0x542F110", VA = "0x185430510")]
		public RenderTexture Get(RenderTexture baseRenderTexture)
		{
			return null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x5430440", Offset = "0x542F040", VA = "0x185430440")]
		public RenderTexture Get(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite rw = RenderTextureReadWrite.Default, FilterMode filterMode = FilterMode.Bilinear, TextureWrapMode wrapMode = TextureWrapMode.Clamp, string name = "FactoryTempTexture")
		{
			return null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x54307A0", Offset = "0x542F3A0", VA = "0x1854307A0")]
		public void Release(RenderTexture rt)
		{
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x54306C0", Offset = "0x542F2C0", VA = "0x1854306C0")]
		public void ReleaseAll()
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x5430430", Offset = "0x542F030", VA = "0x185430430", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<RenderTexture> m_TemporaryRTs;
	}
}
