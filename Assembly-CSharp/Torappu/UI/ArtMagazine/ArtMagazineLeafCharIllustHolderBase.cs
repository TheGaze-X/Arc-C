using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065B3 RID: 26035
	[Token(Token = "0x20065B3")]
	public abstract class ArtMagazineLeafCharIllustHolderBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x060256AE RID: 153262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256AE")]
		[Address(RVA = "0x2065BB0", Offset = "0x20647B0", VA = "0x182065BB0", Slot = "4")]
		protected virtual void LoadCharSkin(CharUISkinStruct charSkin)
		{
		}

		// Token: 0x060256AF RID: 153263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256AF")]
		[Address(RVA = "0x2065A10", Offset = "0x2064610", VA = "0x182065A10")]
		public void GenLeafTransformData(ref ArtMagazineLeafView.LeafTransformData leafTransformData)
		{
		}

		// Token: 0x060256B0 RID: 153264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256B0")]
		[Address(RVA = "0x2065DD0", Offset = "0x20649D0", VA = "0x182065DD0", Slot = "5")]
		public virtual void Render(ArtMagazineLeafViewModelBase leafViewModel)
		{
		}

		// Token: 0x060256B1 RID: 153265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256B1")]
		[Address(RVA = "0x20660B0", Offset = "0x2064CB0", VA = "0x1820660B0")]
		protected ArtMagazineLeafCharIllustHolderBase()
		{
		}

		// Token: 0x04034834 RID: 215092
		[Token(Token = "0x4034834")]
		[FieldOffset(Offset = "0x18")]
		protected CharUISkinStruct cachedCharSkin;

		// Token: 0x04034835 RID: 215093
		[Token(Token = "0x4034835")]
		[FieldOffset(Offset = "0x30")]
		protected UICharacterIllust charIllust;

		// Token: 0x04034836 RID: 215094
		[Token(Token = "0x4034836")]
		[FieldOffset(Offset = "0x38")]
		protected UIPageFinder pageFinder;

		// Token: 0x04034837 RID: 215095
		[Token(Token = "0x4034837")]
		[FieldOffset(Offset = "0x48")]
		protected string cachedItemId;

		// Token: 0x04034838 RID: 215096
		[Token(Token = "0x4034838")]
		[FieldOffset(Offset = "0x50")]
		private int m_cacheLayoutSeqNum;

		// Token: 0x04034839 RID: 215097
		[Token(Token = "0x4034839")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadCharSkin;

		// Token: 0x0403483A RID: 215098
		[Token(Token = "0x403483A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenLeafTransformData;

		// Token: 0x0403483B RID: 215099
		[Token(Token = "0x403483B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403483C RID: 215100
		[Token(Token = "0x403483C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
