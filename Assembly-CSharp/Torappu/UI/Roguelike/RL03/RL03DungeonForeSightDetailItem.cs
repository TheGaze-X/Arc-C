using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x020057FD RID: 22525
	[Token(Token = "0x20057FD")]
	public class RL03DungeonForeSightDetailItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020ED0 RID: 134864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ED0")]
		[Address(RVA = "0x1B309C0", Offset = "0x1B2F5C0", VA = "0x181B309C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020ED1 RID: 134865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ED1")]
		[Address(RVA = "0x1B30780", Offset = "0x1B2F380", VA = "0x181B30780")]
		public void RenderRelic(string topicId, string relicId)
		{
		}

		// Token: 0x06020ED2 RID: 134866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ED2")]
		[Address(RVA = "0x1B306E0", Offset = "0x1B2F2E0", VA = "0x181B306E0")]
		public void RenderClear()
		{
		}

		// Token: 0x06020ED3 RID: 134867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ED3")]
		[Address(RVA = "0x1B308A0", Offset = "0x1B2F4A0", VA = "0x181B308A0")]
		public void RenderTotem(string topicId, RL03TotemViewModel viewModel)
		{
		}

		// Token: 0x06020ED4 RID: 134868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ED4")]
		[Address(RVA = "0x1B30A90", Offset = "0x1B2F690", VA = "0x181B30A90")]
		public RL03DungeonForeSightDetailItem()
		{
		}

		// Token: 0x0402CC2D RID: 183341
		[Token(Token = "0x402CC2D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _nodeContainer;

		// Token: 0x0402CC2E RID: 183342
		[Token(Token = "0x402CC2E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL03TotemItemView _totemItemView;

		// Token: 0x0402CC2F RID: 183343
		[Token(Token = "0x402CC2F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _relicPic;

		// Token: 0x0402CC30 RID: 183344
		[Token(Token = "0x402CC30")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scaler;

		// Token: 0x0402CC31 RID: 183345
		[Token(Token = "0x402CC31")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402CC32 RID: 183346
		[Token(Token = "0x402CC32")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0402CC33 RID: 183347
		[Token(Token = "0x402CC33")]
		[FieldOffset(Offset = "0x50")]
		private RL03TotemItemView m_totemItemView;

		// Token: 0x0402CC34 RID: 183348
		[Token(Token = "0x402CC34")]
		[FieldOffset(Offset = "0x58")]
		private RL03TotemViewModel m_totemViewModel;

		// Token: 0x0402CC35 RID: 183349
		[Token(Token = "0x402CC35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CC36 RID: 183350
		[Token(Token = "0x402CC36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderRelic;

		// Token: 0x0402CC37 RID: 183351
		[Token(Token = "0x402CC37")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderClear;

		// Token: 0x0402CC38 RID: 183352
		[Token(Token = "0x402CC38")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderTotem;

		// Token: 0x0402CC39 RID: 183353
		[Token(Token = "0x402CC39")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
