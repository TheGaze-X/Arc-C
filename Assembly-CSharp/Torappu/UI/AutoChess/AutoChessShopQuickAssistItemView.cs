using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200636B RID: 25451
	[Token(Token = "0x200636B")]
	public class AutoChessShopQuickAssistItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024B8B RID: 150411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B8B")]
		[Address(RVA = "0x1FA0AD0", Offset = "0x1F9F6D0", VA = "0x181FA0AD0")]
		public void Render(AutoChessShopQuickAssistItemViewModel itemViewModel)
		{
		}

		// Token: 0x06024B8C RID: 150412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B8C")]
		[Address(RVA = "0x1FA12D0", Offset = "0x1F9FED0", VA = "0x181FA12D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024B8D RID: 150413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B8D")]
		[Address(RVA = "0x1FA1460", Offset = "0x1FA0060", VA = "0x181FA1460")]
		private void _PlayStateChangeAnim(bool isToBorrowState, bool isFastMode)
		{
		}

		// Token: 0x06024B8E RID: 150414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B8E")]
		[Address(RVA = "0x1FA09C0", Offset = "0x1F9F5C0", VA = "0x181FA09C0")]
		public void OnCancelClick()
		{
		}

		// Token: 0x06024B8F RID: 150415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B8F")]
		[Address(RVA = "0x1FA0870", Offset = "0x1F9F470", VA = "0x181FA0870")]
		public void OnAssistClick()
		{
		}

		// Token: 0x06024B90 RID: 150416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B90")]
		[Address(RVA = "0x1FA1530", Offset = "0x1FA0130", VA = "0x181FA1530")]
		public AutoChessShopQuickAssistItemView()
		{
		}

		// Token: 0x0403346F RID: 210031
		[Token(Token = "0x403346F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgChessLevelReplace;

		// Token: 0x04033470 RID: 210032
		[Token(Token = "0x4033470")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgChessLevelNotHave;

		// Token: 0x04033471 RID: 210033
		[Token(Token = "0x4033471")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgBackupCharPortraitReplace;

		// Token: 0x04033472 RID: 210034
		[Token(Token = "0x4033472")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgBackupCharPortraitNotHave;

		// Token: 0x04033473 RID: 210035
		[Token(Token = "0x4033473")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _transCardHolder;

		// Token: 0x04033474 RID: 210036
		[Token(Token = "0x4033474")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AutoChessShopCharChessCardView _cardViewPrefab;

		// Token: 0x04033475 RID: 210037
		[Token(Token = "0x4033475")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objFriendAliasInfo;

		// Token: 0x04033476 RID: 210038
		[Token(Token = "0x4033476")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtFriendAlias;

		// Token: 0x04033477 RID: 210039
		[Token(Token = "0x4033477")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objFriendBaseInfo;

		// Token: 0x04033478 RID: 210040
		[Token(Token = "0x4033478")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _txtFriendNickName;

		// Token: 0x04033479 RID: 210041
		[Token(Token = "0x4033479")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtFriendCode;

		// Token: 0x0403347A RID: 210042
		[Token(Token = "0x403347A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TwoStateToggle _btnAssistState;

		// Token: 0x0403347B RID: 210043
		[Token(Token = "0x403347B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _stateAnim;

		// Token: 0x0403347C RID: 210044
		[Token(Token = "0x403347C")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0403347D RID: 210045
		[Token(Token = "0x403347D")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403347E RID: 210046
		[Token(Token = "0x403347E")]
		[FieldOffset(Offset = "0xA0")]
		private AutoChessShopCharChessCardView m_cardView;

		// Token: 0x0403347F RID: 210047
		[Token(Token = "0x403347F")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_cachedIsAssisting;

		// Token: 0x04033480 RID: 210048
		[Token(Token = "0x4033480")]
		[FieldOffset(Offset = "0xA9")]
		private bool m_cachedCanAssistMore;

		// Token: 0x04033481 RID: 210049
		[Token(Token = "0x4033481")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedFriendUid;

		// Token: 0x04033482 RID: 210050
		[Token(Token = "0x4033482")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedChessId;

		// Token: 0x04033483 RID: 210051
		[Token(Token = "0x4033483")]
		[FieldOffset(Offset = "0xC0")]
		private AutoChessShopQuickAssistItemView.AssistItemInfo m_cachedAssistItemInfo;

		// Token: 0x04033484 RID: 210052
		[Token(Token = "0x4033484")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033485 RID: 210053
		[Token(Token = "0x4033485")]
		[FieldOffset(Offset = "0xD8")]
		private AnimationSwitchTween m_animSwitchTween;

		// Token: 0x04033486 RID: 210054
		[Token(Token = "0x4033486")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033487 RID: 210055
		[Token(Token = "0x4033487")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033488 RID: 210056
		[Token(Token = "0x4033488")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayStateChangeAnim;

		// Token: 0x04033489 RID: 210057
		[Token(Token = "0x4033489")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCancelClick;

		// Token: 0x0403348A RID: 210058
		[Token(Token = "0x403348A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAssistClick;

		// Token: 0x0403348B RID: 210059
		[Token(Token = "0x403348B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200636C RID: 25452
		[Token(Token = "0x200636C")]
		public class AssistItemInfo
		{
			// Token: 0x06024B91 RID: 150417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B91")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AssistItemInfo()
			{
			}

			// Token: 0x0403348C RID: 210060
			[Token(Token = "0x403348C")]
			[FieldOffset(Offset = "0x10")]
			public string chessId;

			// Token: 0x0403348D RID: 210061
			[Token(Token = "0x403348D")]
			[FieldOffset(Offset = "0x18")]
			public CharQuery charQuery;
		}
	}
}
