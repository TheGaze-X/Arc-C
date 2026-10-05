using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200199A RID: 6554
	[Token(Token = "0x200199A")]
	public abstract class DIYListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A4A3 RID: 42147
		[Token(Token = "0x600A4A3")]
		public abstract void Render(DIYViewListData data, DIYViewListData funcData, DIYFurnitureExpandViewList.DIYViewDataOptions options);

		// Token: 0x0600A4A4 RID: 42148
		[Token(Token = "0x600A4A4")]
		public abstract int GetCurrIndex();

		// Token: 0x0600A4A5 RID: 42149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4A5")]
		[Address(RVA = "0x31E13F0", Offset = "0x31DFFF0", VA = "0x1831E13F0")]
		protected DIYListView()
		{
		}

		// Token: 0x04009BCF RID: 39887
		[Token(Token = "0x4009BCF")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> onButtonPressed;

		// Token: 0x04009BD0 RID: 39888
		[Token(Token = "0x4009BD0")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> onInfoPressed;

		// Token: 0x04009BD1 RID: 39889
		[Token(Token = "0x4009BD1")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public bool isThemeListView;

		// Token: 0x04009BD2 RID: 39890
		[Token(Token = "0x4009BD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
