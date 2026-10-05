using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056E8 RID: 22248
	[Token(Token = "0x20056E8")]
	public class RL04MenuInspirationWindow : RoguelikeMenuWindow<RL04MenuInspirationViewModel>
	{
		// Token: 0x17004C78 RID: 19576
		// (get) Token: 0x06020A14 RID: 133652 RVA: 0x000B6970 File Offset: 0x000B4B70
		[Token(Token = "0x17004C78")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x6020A14")]
			[Address(RVA = "0x1AC7550", Offset = "0x1AC6150", VA = "0x181AC7550", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020A15 RID: 133653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A15")]
		[Address(RVA = "0x1AC72D0", Offset = "0x1AC5ED0", VA = "0x181AC72D0", Slot = "10")]
		public override void Render(RL04MenuInspirationViewModel viewModel)
		{
		}

		// Token: 0x06020A16 RID: 133654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A16")]
		[Address(RVA = "0x1AC74E0", Offset = "0x1AC60E0", VA = "0x181AC74E0")]
		public RL04MenuInspirationWindow()
		{
		}

		// Token: 0x0402C424 RID: 181284
		[Token(Token = "0x402C424")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _itemIconImg;

		// Token: 0x0402C425 RID: 181285
		[Token(Token = "0x402C425")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0402C426 RID: 181286
		[Token(Token = "0x402C426")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _itemUsage;

		// Token: 0x0402C427 RID: 181287
		[Token(Token = "0x402C427")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C428 RID: 181288
		[Token(Token = "0x402C428")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402C429 RID: 181289
		[Token(Token = "0x402C429")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C42A RID: 181290
		[Token(Token = "0x402C42A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
