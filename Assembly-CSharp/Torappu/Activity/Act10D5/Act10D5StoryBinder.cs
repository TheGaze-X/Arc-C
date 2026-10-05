using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B26 RID: 31526
	[Token(Token = "0x2007B26")]
	public class Act10D5StoryBinder : DataBinder<Act10D5StoryProperty>, IHotfixable
	{
		// Token: 0x0602C232 RID: 180786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C232")]
		[Address(RVA = "0x280A800", Offset = "0x2809400", VA = "0x18280A800")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C233 RID: 180787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C233")]
		[Address(RVA = "0x280A520", Offset = "0x2809120", VA = "0x18280A520", Slot = "7")]
		public override void OnValueChanged(Act10D5StoryProperty property)
		{
		}

		// Token: 0x0602C234 RID: 180788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C234")]
		[Address(RVA = "0x280A720", Offset = "0x2809320", VA = "0x18280A720")]
		public void SetCallbacks(Action<string> onReviewStoryClicked, Action<string> onUnlockStoryClicked, Action<string> onStoryRead)
		{
		}

		// Token: 0x0602C235 RID: 180789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C235")]
		[Address(RVA = "0x280A970", Offset = "0x2809570", VA = "0x18280A970")]
		public Act10D5StoryBinder()
		{
		}

		// Token: 0x0403FFB2 RID: 262066
		[Token(Token = "0x403FFB2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x0403FFB3 RID: 262067
		[Token(Token = "0x403FFB3")]
		[FieldOffset(Offset = "0x28")]
		private Act10D5StoryAdapter m_storyAdapter;

		// Token: 0x0403FFB4 RID: 262068
		[Token(Token = "0x403FFB4")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0403FFB5 RID: 262069
		[Token(Token = "0x403FFB5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FFB6 RID: 262070
		[Token(Token = "0x403FFB6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403FFB7 RID: 262071
		[Token(Token = "0x403FFB7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCallbacks;

		// Token: 0x0403FFB8 RID: 262072
		[Token(Token = "0x403FFB8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
