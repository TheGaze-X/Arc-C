using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[AddComponentMenu("CRIWARE/CriManaMovieController")]
	public class CriManaMovieController : CriManaMovieMaterial
	{
		// Token: 0x06000716 RID: 1814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x36FF220", Offset = "0x36FDE20", VA = "0x1836FF220", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x36FF470", Offset = "0x36FE070", VA = "0x1836FF470", Slot = "14")]
		public override bool RenderTargetManualSetup()
		{
			return default(bool);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x36FF3B0", Offset = "0x36FDFB0", VA = "0x1836FF3B0", Slot = "15")]
		public override void RenderTargetManualFinalize()
		{
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x36FF2D0", Offset = "0x36FDED0", VA = "0x1836FF2D0", Slot = "12")]
		protected override void OnMaterialAvailableChanged()
		{
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x36FF210", Offset = "0x36FDE10", VA = "0x1836FF210")]
		public CriManaMovieController()
		{
		}

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x98")]
		public Renderer target;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0xA0")]
		public bool useOriginalMaterial;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0xA8")]
		private Material originalMaterial;
	}
}
