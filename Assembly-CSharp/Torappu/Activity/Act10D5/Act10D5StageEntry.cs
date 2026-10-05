using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B1A RID: 31514
	[Token(Token = "0x2007B1A")]
	public class Act10D5StageEntry : ActivityStageSingleComponent
	{
		// Token: 0x0602C1ED RID: 180717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1ED")]
		[Address(RVA = "0x28093E0", Offset = "0x2807FE0", VA = "0x1828093E0", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602C1EE RID: 180718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1EE")]
		[Address(RVA = "0x2809CE0", Offset = "0x28088E0", VA = "0x182809CE0")]
		private void _EventOnStageTimeout()
		{
		}

		// Token: 0x0602C1EF RID: 180719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1EF")]
		[Address(RVA = "0x2809C20", Offset = "0x2808820", VA = "0x182809C20")]
		private void _EventOnRewardTimeout()
		{
		}

		// Token: 0x0602C1F0 RID: 180720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1F0")]
		[Address(RVA = "0x2808DF0", Offset = "0x28079F0", VA = "0x182808DF0")]
		public void EventOnShopClicked()
		{
		}

		// Token: 0x0602C1F1 RID: 180721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1F1")]
		[Address(RVA = "0x2808FB0", Offset = "0x2807BB0", VA = "0x182808FB0")]
		public void EventOnStoryClicked()
		{
		}

		// Token: 0x0602C1F2 RID: 180722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1F2")]
		[Address(RVA = "0x2808CF0", Offset = "0x28078F0", VA = "0x182808CF0")]
		public void EventOnFavorUpClicked()
		{
		}

		// Token: 0x0602C1F3 RID: 180723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1F3")]
		[Address(RVA = "0x28090C0", Offset = "0x2807CC0", VA = "0x1828090C0")]
		public void EventOnUngroupedMedalClicked()
		{
		}

		// Token: 0x0602C1F4 RID: 180724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1F4")]
		[Address(RVA = "0x2809230", Offset = "0x2807E30", VA = "0x182809230")]
		public void EventOnZoneAllTimeoutClicked()
		{
		}

		// Token: 0x0602C1F5 RID: 180725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1F5")]
		[Address(RVA = "0x28092E0", Offset = "0x2807EE0", VA = "0x1828092E0")]
		private void OnEnable()
		{
		}

		// Token: 0x0602C1F6 RID: 180726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1F6")]
		[Address(RVA = "0x2809D40", Offset = "0x2808940", VA = "0x182809D40")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0602C1F7 RID: 180727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1F7")]
		[Address(RVA = "0x2809EE0", Offset = "0x2808AE0", VA = "0x182809EE0")]
		private IEnumerator _TryStartAnim()
		{
			return null;
		}

		// Token: 0x0602C1F8 RID: 180728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1F8")]
		[Address(RVA = "0x2809F90", Offset = "0x2808B90", VA = "0x182809F90")]
		public Act10D5StageEntry()
		{
		}

		// Token: 0x0602C1FA RID: 180730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1FA")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0403FF65 RID: 261989
		[Token(Token = "0x403FF65")]
		private const string ANIM_NORMAL_START_KEY = "start_normal";

		// Token: 0x0403FF66 RID: 261990
		[Token(Token = "0x403FF66")]
		private const string ANIM_ALL_TIMEOUT_START_KEY = "start_all_timeout";

		// Token: 0x0403FF67 RID: 261991
		[Token(Token = "0x403FF67")]
		private const string ANIM_SKIP_KEY = "skip";

		// Token: 0x0403FF68 RID: 261992
		[Token(Token = "0x403FF68")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Animator> _animatorList;

		// Token: 0x0403FF69 RID: 261993
		[Token(Token = "0x403FF69")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act10D5EntryView _view;

		// Token: 0x0403FF6A RID: 261994
		[Token(Token = "0x403FF6A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act10D5CoinView _coinView;

		// Token: 0x0403FF6B RID: 261995
		[Token(Token = "0x403FF6B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act10D5EntryZoneGroupView _zoneGroupView;

		// Token: 0x0403FF6C RID: 261996
		[Token(Token = "0x403FF6C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonTrackPoint _favorUpTrackPoint;

		// Token: 0x0403FF6D RID: 261997
		[Token(Token = "0x403FF6D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _buttonShop;

		// Token: 0x0403FF6E RID: 261998
		[Token(Token = "0x403FF6E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _buttonStory;

		// Token: 0x0403FF6F RID: 261999
		[Token(Token = "0x403FF6F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403FF70 RID: 262000
		[Token(Token = "0x403FF70")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _favorUpObj;

		// Token: 0x0403FF71 RID: 262001
		[Token(Token = "0x403FF71")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _useCommonFavorState;

		// Token: 0x0403FF72 RID: 262002
		[Token(Token = "0x403FF72")]
		[FieldOffset(Offset = "0x70")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403FF73 RID: 262003
		[Token(Token = "0x403FF73")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isLoaded;

		// Token: 0x0403FF74 RID: 262004
		[Token(Token = "0x403FF74")]
		[FieldOffset(Offset = "0x79")]
		private bool m_isAnimPlayed;

		// Token: 0x0403FF75 RID: 262005
		[Token(Token = "0x403FF75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403FF76 RID: 262006
		[Token(Token = "0x403FF76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EventOnStageTimeout;

		// Token: 0x0403FF77 RID: 262007
		[Token(Token = "0x403FF77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnRewardTimeout;

		// Token: 0x0403FF78 RID: 262008
		[Token(Token = "0x403FF78")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnShopClicked;

		// Token: 0x0403FF79 RID: 262009
		[Token(Token = "0x403FF79")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnStoryClicked;

		// Token: 0x0403FF7A RID: 262010
		[Token(Token = "0x403FF7A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnFavorUpClicked;

		// Token: 0x0403FF7B RID: 262011
		[Token(Token = "0x403FF7B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnUngroupedMedalClicked;

		// Token: 0x0403FF7C RID: 262012
		[Token(Token = "0x403FF7C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnZoneAllTimeoutClicked;

		// Token: 0x0403FF7D RID: 262013
		[Token(Token = "0x403FF7D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403FF7E RID: 262014
		[Token(Token = "0x403FF7E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0403FF7F RID: 262015
		[Token(Token = "0x403FF7F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryStartAnim;

		// Token: 0x0403FF80 RID: 262016
		[Token(Token = "0x403FF80")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
