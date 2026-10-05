using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending.RL03
{
	// Token: 0x02004692 RID: 18066
	[Token(Token = "0x2004692")]
	public class RL03TopicEndingTotemView : RoguelikeTopicEndingPageFadeView<RL03TopicEndingTotemViewModel>
	{
		// Token: 0x0601B6B2 RID: 112306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6B2")]
		[Address(RVA = "0x14AC450", Offset = "0x14AB050", VA = "0x1814AC450", Slot = "8")]
		protected override void Render(RL03TopicEndingTotemViewModel model)
		{
		}

		// Token: 0x0601B6B3 RID: 112307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6B3")]
		[Address(RVA = "0x14ACA30", Offset = "0x14AB630", VA = "0x1814ACA30")]
		public RL03TopicEndingTotemView()
		{
		}

		// Token: 0x0402377B RID: 145275
		[Token(Token = "0x402377B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _title;

		// Token: 0x0402377C RID: 145276
		[Token(Token = "0x402377C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x0402377D RID: 145277
		[Token(Token = "0x402377D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RL03TopicEndingTotemItemView _itemPrefab;

		// Token: 0x0402377E RID: 145278
		[Token(Token = "0x402377E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _addBpRoot;

		// Token: 0x0402377F RID: 145279
		[Token(Token = "0x402377F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imageTitle;

		// Token: 0x04023780 RID: 145280
		[Token(Token = "0x4023780")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTopicEndingAddBPView m_addBp;

		// Token: 0x04023781 RID: 145281
		[Token(Token = "0x4023781")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04023782 RID: 145282
		[Token(Token = "0x4023782")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeTopicEndingStyle m_style;

		// Token: 0x04023783 RID: 145283
		[Token(Token = "0x4023783")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023784 RID: 145284
		[Token(Token = "0x4023784")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
