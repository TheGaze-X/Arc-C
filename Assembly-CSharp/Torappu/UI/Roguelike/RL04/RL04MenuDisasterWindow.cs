using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056E7 RID: 22247
	[Token(Token = "0x20056E7")]
	public class RL04MenuDisasterWindow : RoguelikeMenuWindow<RL04MenuDisasterViewModel>
	{
		// Token: 0x17004C77 RID: 19575
		// (get) Token: 0x06020A11 RID: 133649 RVA: 0x000B6958 File Offset: 0x000B4B58
		[Token(Token = "0x17004C77")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x6020A11")]
			[Address(RVA = "0x1AC3090", Offset = "0x1AC1C90", VA = "0x181AC3090", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020A12 RID: 133650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A12")]
		[Address(RVA = "0x1AC2B90", Offset = "0x1AC1790", VA = "0x181AC2B90", Slot = "10")]
		public override void Render(RL04MenuDisasterViewModel viewModel)
		{
		}

		// Token: 0x06020A13 RID: 133651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A13")]
		[Address(RVA = "0x1AC2FC0", Offset = "0x1AC1BC0", VA = "0x181AC2FC0")]
		public RL04MenuDisasterWindow()
		{
		}

		// Token: 0x0402C418 RID: 181272
		[Token(Token = "0x402C418")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgDisaster;

		// Token: 0x0402C419 RID: 181273
		[Token(Token = "0x402C419")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _prefabLevel;

		// Token: 0x0402C41A RID: 181274
		[Token(Token = "0x402C41A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _levelContainer;

		// Token: 0x0402C41B RID: 181275
		[Token(Token = "0x402C41B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtDisasterName;

		// Token: 0x0402C41C RID: 181276
		[Token(Token = "0x402C41C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtStep;

		// Token: 0x0402C41D RID: 181277
		[Token(Token = "0x402C41D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtFuncDesc;

		// Token: 0x0402C41E RID: 181278
		[Token(Token = "0x402C41E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x0402C41F RID: 181279
		[Token(Token = "0x402C41F")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C420 RID: 181280
		[Token(Token = "0x402C420")]
		[FieldOffset(Offset = "0x70")]
		private List<GameObject> m_levelObjs;

		// Token: 0x0402C421 RID: 181281
		[Token(Token = "0x402C421")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402C422 RID: 181282
		[Token(Token = "0x402C422")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C423 RID: 181283
		[Token(Token = "0x402C423")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
