using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005548 RID: 21832
	[Token(Token = "0x2005548")]
	public class RoguelikeStashedTicketUseViewScrollAdapter : LoopScrollAdapter<RoguelikeStashedTicketUseViewScrollAdapter.ViewHolder, IRoguelikeStashedTicketItemViewModel>
	{
		// Token: 0x17004B54 RID: 19284
		// (get) Token: 0x060201AE RID: 131502 RVA: 0x000B49F0 File Offset: 0x000B2BF0
		// (set) Token: 0x060201AF RID: 131503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B54")]
		public int selectedItemIdx
		{
			[Token(Token = "0x60201AE")]
			[Address(RVA = "0x1A42ED0", Offset = "0x1A41AD0", VA = "0x181A42ED0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60201AF")]
			[Address(RVA = "0x1A42F30", Offset = "0x1A41B30", VA = "0x181A42F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060201B0 RID: 131504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60201B0")]
		[Address(RVA = "0x1A42BF0", Offset = "0x1A417F0", VA = "0x181A42BF0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060201B1 RID: 131505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201B1")]
		[Address(RVA = "0x1A42CA0", Offset = "0x1A418A0", VA = "0x181A42CA0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RoguelikeStashedTicketUseViewScrollAdapter.ViewHolder holder, IRoguelikeStashedTicketItemViewModel data)
		{
		}

		// Token: 0x060201B2 RID: 131506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201B2")]
		[Address(RVA = "0x1A42E60", Offset = "0x1A41A60", VA = "0x181A42E60")]
		public RoguelikeStashedTicketUseViewScrollAdapter()
		{
		}

		// Token: 0x0402B5E2 RID: 177634
		[Token(Token = "0x402B5E2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x0402B5E4 RID: 177636
		[Token(Token = "0x402B5E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedItemIdx;

		// Token: 0x0402B5E5 RID: 177637
		[Token(Token = "0x402B5E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedItemIdx;

		// Token: 0x0402B5E6 RID: 177638
		[Token(Token = "0x402B5E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402B5E7 RID: 177639
		[Token(Token = "0x402B5E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402B5E8 RID: 177640
		[Token(Token = "0x402B5E8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005549 RID: 21833
		[Token(Token = "0x2005549")]
		public class ViewHolder
		{
			// Token: 0x060201B3 RID: 131507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60201B3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402B5E9 RID: 177641
			[Token(Token = "0x402B5E9")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeStashedTicketUseItemView item;
		}
	}
}
