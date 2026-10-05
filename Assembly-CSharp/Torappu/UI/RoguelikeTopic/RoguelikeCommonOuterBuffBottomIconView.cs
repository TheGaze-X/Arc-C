using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044F6 RID: 17654
	[Token(Token = "0x20044F6")]
	public class RoguelikeCommonOuterBuffBottomIconView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF23 RID: 110371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF23")]
		[Address(RVA = "0x14190E0", Offset = "0x1417CE0", VA = "0x1814190E0")]
		public void Render(RoguelikeCommonOuterBuffNodeBaseViewModel viewModel)
		{
		}

		// Token: 0x0601AF24 RID: 110372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AF24")]
		[Address(RVA = "0x1419310", Offset = "0x1417F10", VA = "0x181419310")]
		private Sprite _LoadIcon(ILoadAsset loader, RoguelikeCommonOuterBuffNodeBaseViewModel viewModel)
		{
			return null;
		}

		// Token: 0x0601AF25 RID: 110373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF25")]
		[Address(RVA = "0x1419410", Offset = "0x1418010", VA = "0x181419410")]
		public RoguelikeCommonOuterBuffBottomIconView()
		{
		}

		// Token: 0x0402291E RID: 141598
		[Token(Token = "0x402291E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<RoguelikeCommonOuterBuffBottomIconView.IconGroup> _iconGroups;

		// Token: 0x0402291F RID: 141599
		[Token(Token = "0x402291F")]
		[FieldOffset(Offset = "0x20")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04022920 RID: 141600
		[Token(Token = "0x4022920")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022921 RID: 141601
		[Token(Token = "0x4022921")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadIcon;

		// Token: 0x04022922 RID: 141602
		[Token(Token = "0x4022922")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020044F7 RID: 17655
		[Token(Token = "0x20044F7")]
		[Serializable]
		private struct IconGroup
		{
			// Token: 0x04022923 RID: 141603
			[Token(Token = "0x4022923")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeCommonDevelopmentNodeType nodeType;

			// Token: 0x04022924 RID: 141604
			[Token(Token = "0x4022924")]
			[FieldOffset(Offset = "0x8")]
			public GameObject groupPanel;

			// Token: 0x04022925 RID: 141605
			[Token(Token = "0x4022925")]
			[FieldOffset(Offset = "0x10")]
			public Image iconImage;
		}
	}
}
