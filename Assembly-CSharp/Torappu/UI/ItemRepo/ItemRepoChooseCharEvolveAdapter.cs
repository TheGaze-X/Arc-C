using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E99 RID: 24217
	[Token(Token = "0x2005E99")]
	public class ItemRepoChooseCharEvolveAdapter : SimpleLayoutAdapter, IHotfixable
	{
		// Token: 0x1700531E RID: 21278
		// (get) Token: 0x06023155 RID: 143701 RVA: 0x000BFE50 File Offset: 0x000BE050
		[Token(Token = "0x1700531E")]
		public override int count
		{
			[Token(Token = "0x6023155")]
			[Address(RVA = "0x1D91A50", Offset = "0x1D90650", VA = "0x181D91A50", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06023156 RID: 143702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023156")]
		[Address(RVA = "0x1D91830", Offset = "0x1D90430", VA = "0x181D91830", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x06023157 RID: 143703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023157")]
		[Address(RVA = "0x1D919F0", Offset = "0x1D905F0", VA = "0x181D919F0")]
		public ItemRepoChooseCharEvolveAdapter()
		{
		}

		// Token: 0x04030530 RID: 197936
		[Token(Token = "0x4030530")]
		[FieldOffset(Offset = "0x20")]
		public List<CharacterCardViewModel> itemList;

		// Token: 0x04030531 RID: 197937
		[Token(Token = "0x4030531")]
		[FieldOffset(Offset = "0x28")]
		public CharClickEvent itemEvent;

		// Token: 0x04030532 RID: 197938
		[Token(Token = "0x4030532")]
		[FieldOffset(Offset = "0x30")]
		public bool clickable;

		// Token: 0x04030533 RID: 197939
		[Token(Token = "0x4030533")]
		[FieldOffset(Offset = "0x34")]
		public CharCardType charCardType;

		// Token: 0x04030534 RID: 197940
		[Token(Token = "0x4030534")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04030535 RID: 197941
		[Token(Token = "0x4030535")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04030536 RID: 197942
		[Token(Token = "0x4030536")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
