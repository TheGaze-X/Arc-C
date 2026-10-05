using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x02004682 RID: 18050
	[Token(Token = "0x2004682")]
	public class RoguelikeTopicEndingRelicView : RoguelikeTopicEndingPageFadeView<RoguelikeTopicEndingRelicViewModel>
	{
		// Token: 0x0601B671 RID: 112241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B671")]
		[Address(RVA = "0x14B5FB0", Offset = "0x14B4BB0", VA = "0x1814B5FB0", Slot = "8")]
		protected override void Render(RoguelikeTopicEndingRelicViewModel model)
		{
		}

		// Token: 0x0601B672 RID: 112242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B672")]
		[Address(RVA = "0x14B65B0", Offset = "0x14B51B0", VA = "0x1814B65B0")]
		public RoguelikeTopicEndingRelicView()
		{
		}

		// Token: 0x040236D3 RID: 145107
		[Token(Token = "0x40236D3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _title;

		// Token: 0x040236D4 RID: 145108
		[Token(Token = "0x40236D4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x040236D5 RID: 145109
		[Token(Token = "0x40236D5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeTopicEndingRelicItem _itemPrefab;

		// Token: 0x040236D6 RID: 145110
		[Token(Token = "0x40236D6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _addBpRoot;

		// Token: 0x040236D7 RID: 145111
		[Token(Token = "0x40236D7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imageTitle;

		// Token: 0x040236D8 RID: 145112
		[Token(Token = "0x40236D8")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTopicEndingAddBPView m_addBp;

		// Token: 0x040236D9 RID: 145113
		[Token(Token = "0x40236D9")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040236DA RID: 145114
		[Token(Token = "0x40236DA")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeTopicEndingStyle m_style;

		// Token: 0x040236DB RID: 145115
		[Token(Token = "0x40236DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040236DC RID: 145116
		[Token(Token = "0x40236DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
