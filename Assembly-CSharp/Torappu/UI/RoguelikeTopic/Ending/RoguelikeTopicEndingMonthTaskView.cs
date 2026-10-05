using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x02004680 RID: 18048
	[Token(Token = "0x2004680")]
	public class RoguelikeTopicEndingMonthTaskView : RoguelikeTopicEndingPageFadeView<RoguelikeTopicEndingMonthTaskViewModel>
	{
		// Token: 0x0601B66D RID: 112237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B66D")]
		[Address(RVA = "0x14B4A40", Offset = "0x14B3640", VA = "0x1814B4A40", Slot = "8")]
		protected override void Render(RoguelikeTopicEndingMonthTaskViewModel model)
		{
		}

		// Token: 0x0601B66E RID: 112238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B66E")]
		[Address(RVA = "0x14B52D0", Offset = "0x14B3ED0", VA = "0x1814B52D0")]
		public RoguelikeTopicEndingMonthTaskView()
		{
		}

		// Token: 0x040236C4 RID: 145092
		[Token(Token = "0x40236C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x040236C5 RID: 145093
		[Token(Token = "0x40236C5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _addBpRoot;

		// Token: 0x040236C6 RID: 145094
		[Token(Token = "0x40236C6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _taskDur;

		// Token: 0x040236C7 RID: 145095
		[Token(Token = "0x40236C7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imageTitle;

		// Token: 0x040236C8 RID: 145096
		[Token(Token = "0x40236C8")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040236C9 RID: 145097
		[Token(Token = "0x40236C9")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeTopicEndingStyle m_style;

		// Token: 0x040236CA RID: 145098
		[Token(Token = "0x40236CA")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeTopicMonthTaskStyle m_taskStyle;

		// Token: 0x040236CB RID: 145099
		[Token(Token = "0x40236CB")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeTopicEndingAddBPView m_addBp;

		// Token: 0x040236CC RID: 145100
		[Token(Token = "0x40236CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040236CD RID: 145101
		[Token(Token = "0x40236CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
