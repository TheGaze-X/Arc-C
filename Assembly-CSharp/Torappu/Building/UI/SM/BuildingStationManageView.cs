using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CCA RID: 7370
	[Token(Token = "0x2001CCA")]
	public class BuildingStationManageView : DataBinder<StationManageViewProp>
	{
		// Token: 0x0600B682 RID: 46722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B682")]
		[Address(RVA = "0x330DC60", Offset = "0x330C860", VA = "0x18330DC60", Slot = "7")]
		public override void OnValueChanged(StationManageViewProp property)
		{
		}

		// Token: 0x0600B683 RID: 46723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B683")]
		[Address(RVA = "0x330DBF0", Offset = "0x330C7F0", VA = "0x18330DBF0")]
		public void EventOnSwitchClicked()
		{
		}

		// Token: 0x0600B684 RID: 46724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B684")]
		[Address(RVA = "0x330E040", Offset = "0x330CC40", VA = "0x18330E040")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B685 RID: 46725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B685")]
		[Address(RVA = "0x330E230", Offset = "0x330CE30", VA = "0x18330E230")]
		public BuildingStationManageView()
		{
		}

		// Token: 0x0400B3BD RID: 46013
		[Token(Token = "0x400B3BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _workPanel;

		// Token: 0x0400B3BE RID: 46014
		[Token(Token = "0x400B3BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _dormPanel;

		// Token: 0x0400B3BF RID: 46015
		[Token(Token = "0x400B3BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildingStationManageWorkView _workView;

		// Token: 0x0400B3C0 RID: 46016
		[Token(Token = "0x400B3C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuildingStationManageDormView _dormView;

		// Token: 0x0400B3C1 RID: 46017
		[Token(Token = "0x400B3C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _switchToWork;

		// Token: 0x0400B3C2 RID: 46018
		[Token(Token = "0x400B3C2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _switchToRest;

		// Token: 0x0400B3C3 RID: 46019
		[Token(Token = "0x400B3C3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _switchBtnTrackPoint;

		// Token: 0x0400B3C4 RID: 46020
		[Token(Token = "0x400B3C4")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action onSwitch;

		// Token: 0x0400B3C5 RID: 46021
		[Token(Token = "0x400B3C5")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0400B3C6 RID: 46022
		[Token(Token = "0x400B3C6")]
		[FieldOffset(Offset = "0x78")]
		private FadeSwitchTween m_workPanelShowTween;

		// Token: 0x0400B3C7 RID: 46023
		[Token(Token = "0x400B3C7")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_dormPanelShowTween;

		// Token: 0x0400B3C8 RID: 46024
		[Token(Token = "0x400B3C8")]
		[FieldOffset(Offset = "0x88")]
		private UIBiAnimClipSwitchTween m_switchTween;

		// Token: 0x0400B3C9 RID: 46025
		[Token(Token = "0x400B3C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B3CA RID: 46026
		[Token(Token = "0x400B3CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnSwitchClicked;

		// Token: 0x0400B3CB RID: 46027
		[Token(Token = "0x400B3CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B3CC RID: 46028
		[Token(Token = "0x400B3CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
