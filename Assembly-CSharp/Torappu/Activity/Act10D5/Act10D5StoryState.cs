using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.StoryReview;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B27 RID: 31527
	[Token(Token = "0x2007B27")]
	public class Act10D5StoryState : PopupFadeState
	{
		// Token: 0x0602C236 RID: 180790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C236")]
		[Address(RVA = "0x280B2C0", Offset = "0x2809EC0", VA = "0x18280B2C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602C237 RID: 180791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C237")]
		[Address(RVA = "0x280B320", Offset = "0x2809F20", VA = "0x18280B320", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602C238 RID: 180792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C238")]
		[Address(RVA = "0x280B890", Offset = "0x280A490", VA = "0x18280B890")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C239 RID: 180793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C239")]
		[Address(RVA = "0x280BC20", Offset = "0x280A820", VA = "0x18280BC20")]
		private void _OnStoryRead(string storyId)
		{
		}

		// Token: 0x0602C23A RID: 180794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C23A")]
		[Address(RVA = "0x280B710", Offset = "0x280A310", VA = "0x18280B710")]
		private void _OnStoryReadSuc()
		{
		}

		// Token: 0x0602C23B RID: 180795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C23B")]
		[Address(RVA = "0x280B970", Offset = "0x280A570", VA = "0x18280B970")]
		private void _OnStoryClicked(string storyId)
		{
		}

		// Token: 0x0602C23C RID: 180796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C23C")]
		[Address(RVA = "0x280C160", Offset = "0x280AD60", VA = "0x18280C160")]
		private void _OnUnlockClicked(string storyId)
		{
		}

		// Token: 0x0602C23D RID: 180797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C23D")]
		[Address(RVA = "0x280BE30", Offset = "0x280AA30", VA = "0x18280BE30")]
		private void _OnStoryUnlock(StoryReviewViewModel viewModel)
		{
		}

		// Token: 0x0602C23E RID: 180798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C23E")]
		[Address(RVA = "0x280B7D0", Offset = "0x280A3D0", VA = "0x18280B7D0")]
		private void _OnStoryUnlocked()
		{
		}

		// Token: 0x0602C23F RID: 180799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C23F")]
		[Address(RVA = "0x280C550", Offset = "0x280B150", VA = "0x18280C550")]
		public Act10D5StoryState()
		{
		}

		// Token: 0x0602C243 RID: 180803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C243")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403FFB9 RID: 262073
		[Token(Token = "0x403FFB9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403FFBA RID: 262074
		[Token(Token = "0x403FFBA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act10D5StoryBinder _storyBinder;

		// Token: 0x0403FFBB RID: 262075
		[Token(Token = "0x403FFBB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _maskPanel;

		// Token: 0x0403FFBC RID: 262076
		[Token(Token = "0x403FFBC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act10D5StoryUnlockConfirmView _unlockPanel;

		// Token: 0x0403FFBD RID: 262077
		[Token(Token = "0x403FFBD")]
		[FieldOffset(Offset = "0x90")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403FFBE RID: 262078
		[Token(Token = "0x403FFBE")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x0403FFBF RID: 262079
		[Token(Token = "0x403FFBF")]
		[FieldOffset(Offset = "0xA0")]
		private Act10D5StoryStateBean m_stateBean;

		// Token: 0x0403FFC0 RID: 262080
		[Token(Token = "0x403FFC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FFC1 RID: 262081
		[Token(Token = "0x403FFC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FFC2 RID: 262082
		[Token(Token = "0x403FFC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FFC3 RID: 262083
		[Token(Token = "0x403FFC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnStoryRead;

		// Token: 0x0403FFC4 RID: 262084
		[Token(Token = "0x403FFC4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnStoryReadSuc;

		// Token: 0x0403FFC5 RID: 262085
		[Token(Token = "0x403FFC5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnStoryClicked;

		// Token: 0x0403FFC6 RID: 262086
		[Token(Token = "0x403FFC6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnUnlockClicked;

		// Token: 0x0403FFC7 RID: 262087
		[Token(Token = "0x403FFC7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnStoryUnlock;

		// Token: 0x0403FFC8 RID: 262088
		[Token(Token = "0x403FFC8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnStoryUnlocked;

		// Token: 0x0403FFC9 RID: 262089
		[Token(Token = "0x403FFC9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
