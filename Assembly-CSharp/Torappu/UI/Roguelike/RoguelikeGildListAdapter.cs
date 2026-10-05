using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200536C RID: 21356
	[Token(Token = "0x200536C")]
	public class RoguelikeGildListAdapter : LoopScrollAdapter<RoguelikeGildListAdapter.ViewHolder, RoguelikePlayerCopperItemViewModel>
	{
		// Token: 0x170049D7 RID: 18903
		// (get) Token: 0x0601F7BB RID: 128955 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F7BC RID: 128956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049D7")]
		public string selectedItem
		{
			[Token(Token = "0x601F7BB")]
			[Address(RVA = "0x1924FD0", Offset = "0x1923BD0", VA = "0x181924FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F7BC")]
			[Address(RVA = "0x1925030", Offset = "0x1923C30", VA = "0x181925030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F7BD RID: 128957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7BD")]
		[Address(RVA = "0x1924D20", Offset = "0x1923920", VA = "0x181924D20", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601F7BE RID: 128958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7BE")]
		[Address(RVA = "0x1924DD0", Offset = "0x19239D0", VA = "0x181924DD0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RoguelikeGildListAdapter.ViewHolder holder, RoguelikePlayerCopperItemViewModel data)
		{
		}

		// Token: 0x0601F7BF RID: 128959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7BF")]
		[Address(RVA = "0x1924F60", Offset = "0x1923B60", VA = "0x181924F60")]
		public RoguelikeGildListAdapter()
		{
		}

		// Token: 0x0402A5B2 RID: 173490
		[Token(Token = "0x402A5B2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x0402A5B4 RID: 173492
		[Token(Token = "0x402A5B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedItem;

		// Token: 0x0402A5B5 RID: 173493
		[Token(Token = "0x402A5B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedItem;

		// Token: 0x0402A5B6 RID: 173494
		[Token(Token = "0x402A5B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402A5B7 RID: 173495
		[Token(Token = "0x402A5B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402A5B8 RID: 173496
		[Token(Token = "0x402A5B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200536D RID: 21357
		[Token(Token = "0x200536D")]
		public class ViewHolder
		{
			// Token: 0x0601F7C0 RID: 128960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F7C0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402A5B9 RID: 173497
			[Token(Token = "0x402A5B9")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeGildListItem itemView;
		}
	}
}
