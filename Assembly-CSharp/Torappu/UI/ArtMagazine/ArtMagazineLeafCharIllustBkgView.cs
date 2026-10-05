using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065B2 RID: 26034
	[Token(Token = "0x20065B2")]
	public class ArtMagazineLeafCharIllustBkgView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060256AB RID: 153259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256AB")]
		[Address(RVA = "0x2065910", Offset = "0x2064510", VA = "0x182065910")]
		public void Render(ArtMagazineLeafViewModelBase leafViewModel)
		{
		}

		// Token: 0x060256AC RID: 153260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256AC")]
		[Address(RVA = "0x2065720", Offset = "0x2064320", VA = "0x182065720")]
		public void GenLeafTransformData(ref ArtMagazineLeafView.LeafTransformData leafTransformData)
		{
		}

		// Token: 0x060256AD RID: 153261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256AD")]
		[Address(RVA = "0x20659B0", Offset = "0x20645B0", VA = "0x1820659B0")]
		public ArtMagazineLeafCharIllustBkgView()
		{
		}

		// Token: 0x04034830 RID: 215088
		[Token(Token = "0x4034830")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtMagazineLeafCharIllustHolderBase _charIllustHolder;

		// Token: 0x04034831 RID: 215089
		[Token(Token = "0x4034831")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034832 RID: 215090
		[Token(Token = "0x4034832")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenLeafTransformData;

		// Token: 0x04034833 RID: 215091
		[Token(Token = "0x4034833")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
