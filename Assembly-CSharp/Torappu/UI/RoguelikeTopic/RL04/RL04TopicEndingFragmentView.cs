using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic.Ending;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046DB RID: 18139
	[Token(Token = "0x20046DB")]
	public class RL04TopicEndingFragmentView : RoguelikeTopicEndingPageFadeView<RL04TopicEndingFragmentViewModel>
	{
		// Token: 0x0601B804 RID: 112644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B804")]
		[Address(RVA = "0x14CE920", Offset = "0x14CD520", VA = "0x1814CE920", Slot = "8")]
		protected override void Render(RL04TopicEndingFragmentViewModel viewModel)
		{
		}

		// Token: 0x0601B805 RID: 112645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B805")]
		[Address(RVA = "0x14CF0F0", Offset = "0x14CDCF0", VA = "0x1814CF0F0")]
		public RL04TopicEndingFragmentView()
		{
		}

		// Token: 0x040239F5 RID: 145909
		[Token(Token = "0x40239F5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _title;

		// Token: 0x040239F6 RID: 145910
		[Token(Token = "0x40239F6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x040239F7 RID: 145911
		[Token(Token = "0x40239F7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RL04TopicEndingFragmentItemView _itemPrefab;

		// Token: 0x040239F8 RID: 145912
		[Token(Token = "0x40239F8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _addBpRoot;

		// Token: 0x040239F9 RID: 145913
		[Token(Token = "0x40239F9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imageTitle;

		// Token: 0x040239FA RID: 145914
		[Token(Token = "0x40239FA")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTopicEndingAddBPView m_addBp;

		// Token: 0x040239FB RID: 145915
		[Token(Token = "0x40239FB")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040239FC RID: 145916
		[Token(Token = "0x40239FC")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeTopicEndingStyle m_style;

		// Token: 0x040239FD RID: 145917
		[Token(Token = "0x40239FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040239FE RID: 145918
		[Token(Token = "0x40239FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
