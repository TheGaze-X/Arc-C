using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200656F RID: 25967
	[Token(Token = "0x200656F")]
	public class ArtMagazineDiySkinSelectView : DataBinder<ArtMagazineDiyHomeProperty>
	{
		// Token: 0x06025568 RID: 152936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025568")]
		[Address(RVA = "0x2052C80", Offset = "0x2051880", VA = "0x182052C80", Slot = "7")]
		public override void OnValueChanged(ArtMagazineDiyHomeProperty property)
		{
		}

		// Token: 0x06025569 RID: 152937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025569")]
		[Address(RVA = "0x2052AA0", Offset = "0x20516A0", VA = "0x182052AA0")]
		public void EventOpenHomeState()
		{
		}

		// Token: 0x0602556A RID: 152938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602556A")]
		[Address(RVA = "0x2052B90", Offset = "0x2051790", VA = "0x182052B90")]
		public void EventOpenSkinEditState()
		{
		}

		// Token: 0x0602556B RID: 152939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602556B")]
		[Address(RVA = "0x2052F70", Offset = "0x2051B70", VA = "0x182052F70")]
		public ArtMagazineDiySkinSelectView()
		{
		}

		// Token: 0x04034645 RID: 214597
		[Token(Token = "0x4034645")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04034646 RID: 214598
		[Token(Token = "0x4034646")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtMagazineDiySkinSelectCommonView _commonView;

		// Token: 0x04034647 RID: 214599
		[Token(Token = "0x4034647")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034648 RID: 214600
		[Token(Token = "0x4034648")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034649 RID: 214601
		[Token(Token = "0x4034649")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOpenHomeState;

		// Token: 0x0403464A RID: 214602
		[Token(Token = "0x403464A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOpenSkinEditState;

		// Token: 0x0403464B RID: 214603
		[Token(Token = "0x403464B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
