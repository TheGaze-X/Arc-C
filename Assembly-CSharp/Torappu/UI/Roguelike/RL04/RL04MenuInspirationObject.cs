using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056E6 RID: 22246
	[Token(Token = "0x20056E6")]
	public class RL04MenuInspirationObject : RoguelikeMenuObject<RL04MenuInspirationViewModel>, IHotfixable
	{
		// Token: 0x17004C76 RID: 19574
		// (get) Token: 0x06020A0B RID: 133643 RVA: 0x000B6940 File Offset: 0x000B4B40
		[Token(Token = "0x17004C76")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x6020A0B")]
			[Address(RVA = "0x1AC6AF0", Offset = "0x1AC56F0", VA = "0x181AC6AF0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020A0C RID: 133644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A0C")]
		[Address(RVA = "0x1AC66A0", Offset = "0x1AC52A0", VA = "0x181AC66A0", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x06020A0D RID: 133645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A0D")]
		[Address(RVA = "0x1AC6840", Offset = "0x1AC5440", VA = "0x181AC6840", Slot = "16")]
		public override void Render(RL04MenuInspirationViewModel viewModel)
		{
		}

		// Token: 0x06020A0E RID: 133646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A0E")]
		[Address(RVA = "0x1AC6A60", Offset = "0x1AC5660", VA = "0x181AC6A60")]
		public RL04MenuInspirationObject()
		{
		}

		// Token: 0x06020A10 RID: 133648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A10")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0402C40D RID: 181261
		[Token(Token = "0x402C40D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 HIDE_POS;

		// Token: 0x0402C40E RID: 181262
		[Token(Token = "0x402C40E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 SHOW_POS;

		// Token: 0x0402C40F RID: 181263
		[Token(Token = "0x402C40F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconImg;

		// Token: 0x0402C410 RID: 181264
		[Token(Token = "0x402C410")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402C411 RID: 181265
		[Token(Token = "0x402C411")]
		[FieldOffset(Offset = "0x38")]
		private FadeTranslationSwitchTween m_showSwitchTween;

		// Token: 0x0402C412 RID: 181266
		[Token(Token = "0x402C412")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C413 RID: 181267
		[Token(Token = "0x402C413")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedInspirationItemId;

		// Token: 0x0402C414 RID: 181268
		[Token(Token = "0x402C414")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402C415 RID: 181269
		[Token(Token = "0x402C415")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C416 RID: 181270
		[Token(Token = "0x402C416")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C417 RID: 181271
		[Token(Token = "0x402C417")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
