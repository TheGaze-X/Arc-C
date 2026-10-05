using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007948 RID: 31048
	[Token(Token = "0x2007948")]
	public class Act1ArcadeEntryView : DataBinder<Act1ArcadeEntryProperty>
	{
		// Token: 0x0602B907 RID: 178439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B907")]
		[Address(RVA = "0x2776860", Offset = "0x2775460", VA = "0x182776860")]
		private void _NotifyToast(string toastStr)
		{
		}

		// Token: 0x0602B908 RID: 178440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B908")]
		[Address(RVA = "0x27763D0", Offset = "0x2774FD0", VA = "0x1827763D0", Slot = "7")]
		public override void OnValueChanged(Act1ArcadeEntryProperty property)
		{
		}

		// Token: 0x0602B909 RID: 178441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B909")]
		[Address(RVA = "0x2776220", Offset = "0x2774E20", VA = "0x182776220")]
		public void EventOnBadgeEntryClick()
		{
		}

		// Token: 0x0602B90A RID: 178442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B90A")]
		[Address(RVA = "0x2776340", Offset = "0x2774F40", VA = "0x182776340")]
		public void EventOnMileStoneClick()
		{
		}

		// Token: 0x0602B90B RID: 178443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B90B")]
		[Address(RVA = "0x27762B0", Offset = "0x2774EB0", VA = "0x1827762B0")]
		public void EventOnMedalClick()
		{
		}

		// Token: 0x0602B90C RID: 178444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B90C")]
		[Address(RVA = "0x2776940", Offset = "0x2775540", VA = "0x182776940")]
		public Act1ArcadeEntryView()
		{
		}

		// Token: 0x0403F03D RID: 258109
		[Token(Token = "0x403F03D")]
		private const int SCORE_NUM_DIGIT_CNT = 9;

		// Token: 0x0403F03E RID: 258110
		[Token(Token = "0x403F03E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1ArcadeEntryGameEntryItemView[] _itemViews;

		// Token: 0x0403F03F RID: 258111
		[Token(Token = "0x403F03F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _allZoneScoreTxt;

		// Token: 0x0403F040 RID: 258112
		[Token(Token = "0x403F040")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _badgeBookEntryOpenIconObjs;

		// Token: 0x0403F041 RID: 258113
		[Token(Token = "0x403F041")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _badgeBookEntryCloseIconObjs;

		// Token: 0x0403F042 RID: 258114
		[Token(Token = "0x403F042")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _badgeBookEntryTrackpointObj;

		// Token: 0x0403F043 RID: 258115
		[Token(Token = "0x403F043")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Act1ArcadeToast _notifyToastPrefab;

		// Token: 0x0403F044 RID: 258116
		[Token(Token = "0x403F044")]
		[FieldOffset(Offset = "0x50")]
		private Act1ArcadeEntryViewModel m_viewModel;

		// Token: 0x0403F045 RID: 258117
		[Token(Token = "0x403F045")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403F046 RID: 258118
		[Token(Token = "0x403F046")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__NotifyToast;

		// Token: 0x0403F047 RID: 258119
		[Token(Token = "0x403F047")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F048 RID: 258120
		[Token(Token = "0x403F048")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBadgeEntryClick;

		// Token: 0x0403F049 RID: 258121
		[Token(Token = "0x403F049")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnMileStoneClick;

		// Token: 0x0403F04A RID: 258122
		[Token(Token = "0x403F04A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnMedalClick;

		// Token: 0x0403F04B RID: 258123
		[Token(Token = "0x403F04B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
