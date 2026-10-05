using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046D6 RID: 18134
	[Token(Token = "0x20046D6")]
	public class RL04NormalModePlugin : RoguelikeTopicNormalModeViewPlugin
	{
		// Token: 0x0601B7F8 RID: 112632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7F8")]
		[Address(RVA = "0x14CDA40", Offset = "0x14CC640", VA = "0x1814CDA40", Slot = "4")]
		public override void Init(RoguelikeTopicNormalModeView view)
		{
		}

		// Token: 0x0601B7F9 RID: 112633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7F9")]
		[Address(RVA = "0x14CDCC0", Offset = "0x14CC8C0", VA = "0x1814CDCC0", Slot = "5")]
		public override void Render(RoguelikeTopicModeViewModel viewModel)
		{
		}

		// Token: 0x0601B7FA RID: 112634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7FA")]
		[Address(RVA = "0x14CDAA0", Offset = "0x14CC6A0", VA = "0x1814CDAA0")]
		public void OnNodeUpgradeClick()
		{
		}

		// Token: 0x0601B7FB RID: 112635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7FB")]
		[Address(RVA = "0x14CE1A0", Offset = "0x14CCDA0", VA = "0x1814CE1A0")]
		public RL04NormalModePlugin()
		{
		}

		// Token: 0x040239E1 RID: 145889
		[Token(Token = "0x40239E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelNodeUpgrade;

		// Token: 0x040239E2 RID: 145890
		[Token(Token = "0x40239E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnComplete;

		// Token: 0x040239E3 RID: 145891
		[Token(Token = "0x40239E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelAllComplete;

		// Token: 0x040239E4 RID: 145892
		[Token(Token = "0x40239E4")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040239E5 RID: 145893
		[Token(Token = "0x40239E5")]
		[FieldOffset(Offset = "0x40")]
		private int m_dialogInst;

		// Token: 0x040239E6 RID: 145894
		[Token(Token = "0x40239E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040239E7 RID: 145895
		[Token(Token = "0x40239E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040239E8 RID: 145896
		[Token(Token = "0x40239E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnNodeUpgradeClick;

		// Token: 0x040239E9 RID: 145897
		[Token(Token = "0x40239E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
