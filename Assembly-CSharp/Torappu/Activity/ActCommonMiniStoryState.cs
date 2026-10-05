using System;
using Il2CppDummyDll;
using Torappu.Activity.Act10D5;
using Torappu.UI;
using Torappu.UI.StoryReview;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D99 RID: 28057
	[Token(Token = "0x2006D99")]
	public class ActCommonMiniStoryState : PopupFadeState
	{
		// Token: 0x06027F66 RID: 163686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F66")]
		[Address(RVA = "0x232F2D0", Offset = "0x232DED0", VA = "0x18232F2D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027F67 RID: 163687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F67")]
		[Address(RVA = "0x232F330", Offset = "0x232DF30", VA = "0x18232F330", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06027F68 RID: 163688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F68")]
		[Address(RVA = "0x232F9A0", Offset = "0x232E5A0", VA = "0x18232F9A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027F69 RID: 163689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F69")]
		[Address(RVA = "0x232FD20", Offset = "0x232E920", VA = "0x18232FD20")]
		private void _OnStoryRead(string storyId)
		{
		}

		// Token: 0x06027F6A RID: 163690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F6A")]
		[Address(RVA = "0x232F820", Offset = "0x232E420", VA = "0x18232F820")]
		private void _OnStoryReadSuc()
		{
		}

		// Token: 0x06027F6B RID: 163691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F6B")]
		[Address(RVA = "0x232FB60", Offset = "0x232E760", VA = "0x18232FB60")]
		private void _OnStoryClicked(string storyId)
		{
		}

		// Token: 0x06027F6C RID: 163692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F6C")]
		[Address(RVA = "0x2330260", Offset = "0x232EE60", VA = "0x182330260")]
		private void _OnUnlockClicked(string storyId)
		{
		}

		// Token: 0x06027F6D RID: 163693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F6D")]
		[Address(RVA = "0x232FF30", Offset = "0x232EB30", VA = "0x18232FF30")]
		private void _OnStoryUnlock(StoryReviewViewModel viewModel)
		{
		}

		// Token: 0x06027F6E RID: 163694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F6E")]
		[Address(RVA = "0x232F8E0", Offset = "0x232E4E0", VA = "0x18232F8E0")]
		private void _OnStoryUnlocked()
		{
		}

		// Token: 0x06027F6F RID: 163695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F6F")]
		[Address(RVA = "0x23304C0", Offset = "0x232F0C0", VA = "0x1823304C0")]
		public ActCommonMiniStoryState()
		{
		}

		// Token: 0x06027F73 RID: 163699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F73")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04038A3D RID: 231997
		[Token(Token = "0x4038A3D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04038A3E RID: 231998
		[Token(Token = "0x4038A3E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActCommonMiniStoryBinder _storyBinder;

		// Token: 0x04038A3F RID: 231999
		[Token(Token = "0x4038A3F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _maskPanel;

		// Token: 0x04038A40 RID: 232000
		[Token(Token = "0x4038A40")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act10D5StoryUnlockConfirmView _unlockPanel;

		// Token: 0x04038A41 RID: 232001
		[Token(Token = "0x4038A41")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _chapterTitleImage;

		// Token: 0x04038A42 RID: 232002
		[Token(Token = "0x4038A42")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _chapterBg;

		// Token: 0x04038A43 RID: 232003
		[Token(Token = "0x4038A43")]
		[FieldOffset(Offset = "0xA0")]
		private CommonTopMenu m_topMenu;

		// Token: 0x04038A44 RID: 232004
		[Token(Token = "0x4038A44")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_inited;

		// Token: 0x04038A45 RID: 232005
		[Token(Token = "0x4038A45")]
		[FieldOffset(Offset = "0xB0")]
		private ActCommonMiniStoryStateBean m_stateBean;

		// Token: 0x04038A46 RID: 232006
		[Token(Token = "0x4038A46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04038A47 RID: 232007
		[Token(Token = "0x4038A47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04038A48 RID: 232008
		[Token(Token = "0x4038A48")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038A49 RID: 232009
		[Token(Token = "0x4038A49")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnStoryRead;

		// Token: 0x04038A4A RID: 232010
		[Token(Token = "0x4038A4A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnStoryReadSuc;

		// Token: 0x04038A4B RID: 232011
		[Token(Token = "0x4038A4B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnStoryClicked;

		// Token: 0x04038A4C RID: 232012
		[Token(Token = "0x4038A4C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnUnlockClicked;

		// Token: 0x04038A4D RID: 232013
		[Token(Token = "0x4038A4D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnStoryUnlock;

		// Token: 0x04038A4E RID: 232014
		[Token(Token = "0x4038A4E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnStoryUnlocked;

		// Token: 0x04038A4F RID: 232015
		[Token(Token = "0x4038A4F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
