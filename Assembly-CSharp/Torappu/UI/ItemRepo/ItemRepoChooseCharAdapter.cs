using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ChooseChar;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E95 RID: 24213
	[Token(Token = "0x2005E95")]
	public class ItemRepoChooseCharAdapter : SimpleLayoutAdapter, IHotfixable
	{
		// Token: 0x1700531D RID: 21277
		// (get) Token: 0x06023146 RID: 143686 RVA: 0x000BFE38 File Offset: 0x000BE038
		[Token(Token = "0x1700531D")]
		public override int count
		{
			[Token(Token = "0x6023146")]
			[Address(RVA = "0x1D905E0", Offset = "0x1D8F1E0", VA = "0x181D905E0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06023147 RID: 143687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023147")]
		[Address(RVA = "0x1D902F0", Offset = "0x1D8EEF0", VA = "0x181D902F0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x06023148 RID: 143688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023148")]
		[Address(RVA = "0x1D90580", Offset = "0x1D8F180", VA = "0x181D90580")]
		public ItemRepoChooseCharAdapter()
		{
		}

		// Token: 0x04030516 RID: 197910
		[Token(Token = "0x4030516")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemRepoChooseCharViewModel.ChooseCharItem> charDatas;

		// Token: 0x04030517 RID: 197911
		[Token(Token = "0x4030517")]
		[FieldOffset(Offset = "0x28")]
		public CommonSingleChooseCharGroupView.AbstractViewBuilder viewBuilder;

		// Token: 0x04030518 RID: 197912
		[Token(Token = "0x4030518")]
		[FieldOffset(Offset = "0x30")]
		public bool clickable;

		// Token: 0x04030519 RID: 197913
		[Token(Token = "0x4030519")]
		[FieldOffset(Offset = "0x38")]
		public Action<string> onItemClick;

		// Token: 0x0403051A RID: 197914
		[Token(Token = "0x403051A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0403051B RID: 197915
		[Token(Token = "0x403051B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403051C RID: 197916
		[Token(Token = "0x403051C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
