using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045DA RID: 17882
	[Token(Token = "0x20045DA")]
	public class Rl03OuterBuffSummaryMergeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B322 RID: 111394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B322")]
		[Address(RVA = "0x1468EE0", Offset = "0x1467AE0", VA = "0x181468EE0")]
		public void Render(string topicId, Rl03OuterBuffSummaryMergedItemModel viewModel)
		{
		}

		// Token: 0x0601B323 RID: 111395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B323")]
		[Address(RVA = "0x1469090", Offset = "0x1467C90", VA = "0x181469090")]
		public Rl03OuterBuffSummaryMergeItemView()
		{
		}

		// Token: 0x040230C2 RID: 143554
		[Token(Token = "0x40230C2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040230C3 RID: 143555
		[Token(Token = "0x40230C3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x040230C4 RID: 143556
		[Token(Token = "0x40230C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _value;

		// Token: 0x040230C5 RID: 143557
		[Token(Token = "0x40230C5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelValue;

		// Token: 0x040230C6 RID: 143558
		[Token(Token = "0x40230C6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040230C7 RID: 143559
		[Token(Token = "0x40230C7")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040230C8 RID: 143560
		[Token(Token = "0x40230C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040230C9 RID: 143561
		[Token(Token = "0x40230C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
