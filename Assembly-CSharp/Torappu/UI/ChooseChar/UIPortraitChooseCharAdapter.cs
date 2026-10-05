using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A24 RID: 23076
	[Token(Token = "0x2005A24")]
	public class UIPortraitChooseCharAdapter : LoopScrollAdapter<UIPortraitChooseCharAdapter.ViewHolder, UIPortraitChooseCharCardViewModel>, IHotfixable
	{
		// Token: 0x17004EEA RID: 20202
		// (get) Token: 0x060219BC RID: 137660 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060219BD RID: 137661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004EEA")]
		public List<string> selectCharIdList
		{
			[Token(Token = "0x60219BC")]
			[Address(RVA = "0x1C14290", Offset = "0x1C12E90", VA = "0x181C14290")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60219BD")]
			[Address(RVA = "0x1C142F0", Offset = "0x1C12EF0", VA = "0x181C142F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060219BE RID: 137662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60219BE")]
		[Address(RVA = "0x1C13FB0", Offset = "0x1C12BB0", VA = "0x181C13FB0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060219BF RID: 137663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219BF")]
		[Address(RVA = "0x1C14060", Offset = "0x1C12C60", VA = "0x181C14060", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, UIPortraitChooseCharAdapter.ViewHolder holder, UIPortraitChooseCharCardViewModel data)
		{
		}

		// Token: 0x060219C0 RID: 137664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219C0")]
		[Address(RVA = "0x1C14220", Offset = "0x1C12E20", VA = "0x181C14220")]
		public UIPortraitChooseCharAdapter()
		{
		}

		// Token: 0x0402DF21 RID: 188193
		[Token(Token = "0x402DF21")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefabCharCard;

		// Token: 0x0402DF22 RID: 188194
		[Token(Token = "0x402DF22")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0402DF24 RID: 188196
		[Token(Token = "0x402DF24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectCharIdList;

		// Token: 0x0402DF25 RID: 188197
		[Token(Token = "0x402DF25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectCharIdList;

		// Token: 0x0402DF26 RID: 188198
		[Token(Token = "0x402DF26")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402DF27 RID: 188199
		[Token(Token = "0x402DF27")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402DF28 RID: 188200
		[Token(Token = "0x402DF28")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A25 RID: 23077
		[Token(Token = "0x2005A25")]
		public class ViewHolder
		{
			// Token: 0x060219C1 RID: 137665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219C1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402DF29 RID: 188201
			[Token(Token = "0x402DF29")]
			[FieldOffset(Offset = "0x10")]
			public UIPortraitChooseCharCardView cardView;
		}
	}
}
