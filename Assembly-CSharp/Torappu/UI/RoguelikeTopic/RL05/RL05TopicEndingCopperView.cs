using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic.Ending;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x020045A3 RID: 17827
	[Token(Token = "0x20045A3")]
	public class RL05TopicEndingCopperView : RoguelikeTopicEndingPageFadeView<RL05TopicEndingCopperViewModel>
	{
		// Token: 0x0601B22B RID: 111147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B22B")]
		[Address(RVA = "0x1453700", Offset = "0x1452300", VA = "0x181453700", Slot = "8")]
		protected override void Render(RL05TopicEndingCopperViewModel viewModel)
		{
		}

		// Token: 0x0601B22C RID: 111148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B22C")]
		[Address(RVA = "0x1453CD0", Offset = "0x14528D0", VA = "0x181453CD0")]
		public RL05TopicEndingCopperView()
		{
		}

		// Token: 0x04022ECB RID: 143051
		[Token(Token = "0x4022ECB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _title;

		// Token: 0x04022ECC RID: 143052
		[Token(Token = "0x4022ECC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x04022ECD RID: 143053
		[Token(Token = "0x4022ECD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RL05TopicEndingCopperItemView _itemPrefab;

		// Token: 0x04022ECE RID: 143054
		[Token(Token = "0x4022ECE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _addBpRoot;

		// Token: 0x04022ECF RID: 143055
		[Token(Token = "0x4022ECF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imageTitle;

		// Token: 0x04022ED0 RID: 143056
		[Token(Token = "0x4022ED0")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTopicEndingAddBPView m_addBp;

		// Token: 0x04022ED1 RID: 143057
		[Token(Token = "0x4022ED1")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04022ED2 RID: 143058
		[Token(Token = "0x4022ED2")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeTopicEndingStyle m_style;

		// Token: 0x04022ED3 RID: 143059
		[Token(Token = "0x4022ED3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022ED4 RID: 143060
		[Token(Token = "0x4022ED4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
