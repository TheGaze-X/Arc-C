using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045C6 RID: 17862
	[Token(Token = "0x20045C6")]
	public class Rl03OuterBuffBottomView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B2D0 RID: 111312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2D0")]
		[Address(RVA = "0x1455160", Offset = "0x1453D60", VA = "0x181455160")]
		public void Render(Rl03OuterBuffViewModel viewModel, Rl03OuterBuffNodeBaseViewModel nodeViewModel)
		{
		}

		// Token: 0x0601B2D1 RID: 111313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2D1")]
		[Address(RVA = "0x14554A0", Offset = "0x14540A0", VA = "0x1814554A0")]
		private void _RenderIcon(Rl03OuterBuffNodeBaseViewModel viewModel)
		{
		}

		// Token: 0x0601B2D2 RID: 111314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2D2")]
		[Address(RVA = "0x14550E0", Offset = "0x1453CE0", VA = "0x1814550E0")]
		public void OnConfirmUpgrade()
		{
		}

		// Token: 0x0601B2D3 RID: 111315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2D3")]
		[Address(RVA = "0x1455650", Offset = "0x1454250", VA = "0x181455650")]
		public Rl03OuterBuffBottomView()
		{
		}

		// Token: 0x0402301C RID: 143388
		[Token(Token = "0x402301C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402301D RID: 143389
		[Token(Token = "0x402301D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Rl03OuterBuffBottomView.IconGroup> _iconGroups;

		// Token: 0x0402301E RID: 143390
		[Token(Token = "0x402301E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x0402301F RID: 143391
		[Token(Token = "0x402301F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _difficultPanel;

		// Token: 0x04023020 RID: 143392
		[Token(Token = "0x4023020")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Rl03OuterBuffBottomDifficultyView _diffView;

		// Token: 0x04023021 RID: 143393
		[Token(Token = "0x4023021")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Rl03OuterBuffBottomNormalView _normalView;

		// Token: 0x04023022 RID: 143394
		[Token(Token = "0x4023022")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string> onConfirmUpgrade;

		// Token: 0x04023023 RID: 143395
		[Token(Token = "0x4023023")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04023024 RID: 143396
		[Token(Token = "0x4023024")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04023025 RID: 143397
		[Token(Token = "0x4023025")]
		[FieldOffset(Offset = "0x68")]
		private Rl03OuterBuffNodeBaseViewModel m_cachedNodeViewModel;

		// Token: 0x04023026 RID: 143398
		[Token(Token = "0x4023026")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023027 RID: 143399
		[Token(Token = "0x4023027")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderIcon;

		// Token: 0x04023028 RID: 143400
		[Token(Token = "0x4023028")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirmUpgrade;

		// Token: 0x04023029 RID: 143401
		[Token(Token = "0x4023029")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045C7 RID: 17863
		[Token(Token = "0x20045C7")]
		[Serializable]
		private struct IconGroup
		{
			// Token: 0x0402302A RID: 143402
			[Token(Token = "0x402302A")]
			[FieldOffset(Offset = "0x0")]
			public RL03DevelopmentNodeType nodeType;

			// Token: 0x0402302B RID: 143403
			[Token(Token = "0x402302B")]
			[FieldOffset(Offset = "0x8")]
			public GameObject nodePanel;
		}
	}
}
