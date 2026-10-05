using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005803 RID: 22531
	[Token(Token = "0x2005803")]
	public class RL03TotemDetailNodeDialogView : RoguelikeDetailNodeDialog.View<RL03TotemDetailNodeDialogView.Option>
	{
		// Token: 0x06020EF0 RID: 134896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EF0")]
		[Address(RVA = "0x1B33970", Offset = "0x1B32570", VA = "0x181B33970", Slot = "4")]
		public override void OnInit()
		{
		}

		// Token: 0x06020EF1 RID: 134897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EF1")]
		[Address(RVA = "0x1B33A70", Offset = "0x1B32670", VA = "0x181B33A70", Slot = "6")]
		public override void Render(RL03TotemDetailNodeDialogView.Option option)
		{
		}

		// Token: 0x06020EF2 RID: 134898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EF2")]
		[Address(RVA = "0x1B33B30", Offset = "0x1B32730", VA = "0x181B33B30")]
		public RL03TotemDetailNodeDialogView()
		{
		}

		// Token: 0x0402CC79 RID: 183417
		[Token(Token = "0x402CC79")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402CC7A RID: 183418
		[Token(Token = "0x402CC7A")]
		[FieldOffset(Offset = "0x20")]
		private RL03TotemEffectAdapter m_adapter;

		// Token: 0x0402CC7B RID: 183419
		[Token(Token = "0x402CC7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402CC7C RID: 183420
		[Token(Token = "0x402CC7C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CC7D RID: 183421
		[Token(Token = "0x402CC7D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005804 RID: 22532
		[Token(Token = "0x2005804")]
		public class Option : RoguelikeDetailNodeDialog.OptionBase
		{
			// Token: 0x06020EF3 RID: 134899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020EF3")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Option()
			{
			}

			// Token: 0x0402CC7E RID: 183422
			[Token(Token = "0x402CC7E")]
			[FieldOffset(Offset = "0x18")]
			public List<string> list;
		}
	}
}
