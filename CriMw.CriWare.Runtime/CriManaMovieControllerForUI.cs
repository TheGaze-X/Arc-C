using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CriWare
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[AddComponentMenu("CRIWARE/CriManaMovieControllerForUI")]
	public class CriManaMovieControllerForUI : CriManaMovieMaterial
	{
		// Token: 0x0600071B RID: 1819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x36FEBE0", Offset = "0x36FD7E0", VA = "0x1836FEBE0", Slot = "16")]
		protected override void Awake()
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x36FEDC0", Offset = "0x36FD9C0", VA = "0x1836FEDC0", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00003E0C File Offset: 0x0000200C
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x36FF080", Offset = "0x36FDC80", VA = "0x1836FF080", Slot = "14")]
		public override bool RenderTargetManualSetup()
		{
			return default(bool);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x36FEFA0", Offset = "0x36FDBA0", VA = "0x1836FEFA0", Slot = "15")]
		public override void RenderTargetManualFinalize()
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x36FEE80", Offset = "0x36FDA80", VA = "0x1836FEE80", Slot = "12")]
		protected override void OnMaterialAvailableChanged()
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x36FF210", Offset = "0x36FDE10", VA = "0x1836FF210")]
		public CriManaMovieControllerForUI()
		{
		}

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x98")]
		public Graphic target;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0xA0")]
		public bool useOriginalMaterial;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0xA8")]
		private Material originalMaterial;
	}
}
