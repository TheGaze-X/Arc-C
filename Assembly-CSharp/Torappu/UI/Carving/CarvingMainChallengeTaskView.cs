using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006078 RID: 24696
	[Token(Token = "0x2006078")]
	public class CarvingMainChallengeTaskView : DataBinder<CarvingMainProperty>
	{
		// Token: 0x06023B53 RID: 146259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B53")]
		[Address(RVA = "0x1E5B120", Offset = "0x1E59D20", VA = "0x181E5B120", Slot = "7")]
		public override void OnValueChanged(CarvingMainProperty property)
		{
		}

		// Token: 0x06023B54 RID: 146260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B54")]
		[Address(RVA = "0x1E5B300", Offset = "0x1E59F00", VA = "0x181E5B300")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023B55 RID: 146261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B55")]
		[Address(RVA = "0x1E5BED0", Offset = "0x1E5AAD0", VA = "0x181E5BED0")]
		private void _Render(CarvingMainChallengeTaskViewModel model, bool isFirstUpdate)
		{
		}

		// Token: 0x06023B56 RID: 146262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B56")]
		[Address(RVA = "0x1E5B400", Offset = "0x1E5A000", VA = "0x181E5B400")]
		private void _PlayAnim(CarvingMainViewModel model, bool isFirstUpdate)
		{
		}

		// Token: 0x06023B57 RID: 146263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B57")]
		[Address(RVA = "0x1E5B660", Offset = "0x1E5A260", VA = "0x181E5B660")]
		private void _PlayChangeStateAnim(PlayerActivity.PlayerAct35SideActivity.GameState curState, bool isProcessing, bool firstUpdate)
		{
		}

		// Token: 0x06023B58 RID: 146264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B58")]
		[Address(RVA = "0x1E5B770", Offset = "0x1E5A370", VA = "0x181E5B770")]
		private void _PlayTaskAnim(CarvingMainChallengeTaskViewModel taskModel)
		{
		}

		// Token: 0x06023B59 RID: 146265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B59")]
		[Address(RVA = "0x1E5BA70", Offset = "0x1E5A670", VA = "0x181E5BA70")]
		private void _PlayTaskShowHideAnim(CarvingMainChallengeTaskViewModel taskModel)
		{
		}

		// Token: 0x06023B5A RID: 146266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B5A")]
		[Address(RVA = "0x1E5B880", Offset = "0x1E5A480", VA = "0x181E5B880")]
		private void _PlayTaskRefreshAnim(CarvingMainChallengeTaskViewModel taskModel)
		{
		}

		// Token: 0x06023B5B RID: 146267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B5B")]
		[Address(RVA = "0x1E5C2C0", Offset = "0x1E5AEC0", VA = "0x181E5C2C0")]
		public CarvingMainChallengeTaskView()
		{
		}

		// Token: 0x040317C5 RID: 202693
		[Token(Token = "0x40317C5")]
		private const string ADD_COIN_TEXT_FORMAT = "+{0}";

		// Token: 0x040317C6 RID: 202694
		[Token(Token = "0x40317C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _animPanelSwitchLocation;

		// Token: 0x040317C7 RID: 202695
		[Token(Token = "0x40317C7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _animTaskShowLocation;

		// Token: 0x040317C8 RID: 202696
		[Token(Token = "0x40317C8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _animTaskRefreshLocation;

		// Token: 0x040317C9 RID: 202697
		[Token(Token = "0x40317C9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _animTaskCompleteLocation;

		// Token: 0x040317CA RID: 202698
		[Token(Token = "0x40317CA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _animTaskHideLocation;

		// Token: 0x040317CB RID: 202699
		[Token(Token = "0x40317CB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _goldCntText;

		// Token: 0x040317CC RID: 202700
		[Token(Token = "0x40317CC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _extraGoldText;

		// Token: 0x040317CD RID: 202701
		[Token(Token = "0x40317CD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _materialIcon;

		// Token: 0x040317CE RID: 202702
		[Token(Token = "0x40317CE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _descText;

		// Token: 0x040317CF RID: 202703
		[Token(Token = "0x40317CF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _missionGroup;

		// Token: 0x040317D0 RID: 202704
		[Token(Token = "0x40317D0")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x040317D1 RID: 202705
		[Token(Token = "0x40317D1")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040317D2 RID: 202706
		[Token(Token = "0x40317D2")]
		[FieldOffset(Offset = "0xB0")]
		private PlayerActivity.PlayerAct35SideActivity.GameState m_cachedState;

		// Token: 0x040317D3 RID: 202707
		[Token(Token = "0x40317D3")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedIconId;

		// Token: 0x040317D4 RID: 202708
		[Token(Token = "0x40317D4")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_cachedActiveTask;

		// Token: 0x040317D5 RID: 202709
		[Token(Token = "0x40317D5")]
		[FieldOffset(Offset = "0xC4")]
		private int m_cachedMaterialNum;

		// Token: 0x040317D6 RID: 202710
		[Token(Token = "0x40317D6")]
		[FieldOffset(Offset = "0xC8")]
		private int m_cachedLoadSeqNum;

		// Token: 0x040317D7 RID: 202711
		[Token(Token = "0x40317D7")]
		[FieldOffset(Offset = "0xD0")]
		private AnimationSwitchTween m_panelSwitchTween;

		// Token: 0x040317D8 RID: 202712
		[Token(Token = "0x40317D8")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_taskTween;

		// Token: 0x040317D9 RID: 202713
		[Token(Token = "0x40317D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040317DA RID: 202714
		[Token(Token = "0x40317DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040317DB RID: 202715
		[Token(Token = "0x40317DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040317DC RID: 202716
		[Token(Token = "0x40317DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x040317DD RID: 202717
		[Token(Token = "0x40317DD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayChangeStateAnim;

		// Token: 0x040317DE RID: 202718
		[Token(Token = "0x40317DE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayTaskAnim;

		// Token: 0x040317DF RID: 202719
		[Token(Token = "0x40317DF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayTaskShowHideAnim;

		// Token: 0x040317E0 RID: 202720
		[Token(Token = "0x40317E0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayTaskRefreshAnim;

		// Token: 0x040317E1 RID: 202721
		[Token(Token = "0x40317E1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
