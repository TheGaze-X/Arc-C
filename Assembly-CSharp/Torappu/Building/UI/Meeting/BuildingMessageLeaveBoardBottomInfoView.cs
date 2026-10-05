using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D23 RID: 7459
	[Token(Token = "0x2001D23")]
	public class BuildingMessageLeaveBoardBottomInfoView : DataBinder<BuildingMessageLeaveBoardProperty>, IHotfixable
	{
		// Token: 0x0600B826 RID: 47142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B826")]
		[Address(RVA = "0x335CFD0", Offset = "0x335BBD0", VA = "0x18335CFD0")]
		private void Update()
		{
		}

		// Token: 0x0600B827 RID: 47143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B827")]
		[Address(RVA = "0x335D070", Offset = "0x335BC70", VA = "0x18335D070")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B828 RID: 47144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B828")]
		[Address(RVA = "0x335CC70", Offset = "0x335B870", VA = "0x18335CC70", Slot = "7")]
		public override void OnValueChanged(BuildingMessageLeaveBoardProperty property)
		{
		}

		// Token: 0x0600B829 RID: 47145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B829")]
		[Address(RVA = "0x335D5F0", Offset = "0x335C1F0", VA = "0x18335D5F0")]
		private void _RendPlayerInfoView(BuildingPayloadGetMessageBoardContentResponse response)
		{
		}

		// Token: 0x0600B82A RID: 47146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B82A")]
		[Address(RVA = "0x335D790", Offset = "0x335C390", VA = "0x18335D790")]
		private void _RendVisitorInfoView(BuildingPayloadGetOthersMessageBoardContentResponse response)
		{
		}

		// Token: 0x0600B82B RID: 47147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B82B")]
		[Address(RVA = "0x335D120", Offset = "0x335BD20", VA = "0x18335D120")]
		private void _RefreshTimeCountDown()
		{
		}

		// Token: 0x0600B82C RID: 47148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B82C")]
		[Address(RVA = "0x335D880", Offset = "0x335C480", VA = "0x18335D880")]
		public BuildingMessageLeaveBoardBottomInfoView()
		{
		}

		// Token: 0x0400B625 RID: 46629
		[Token(Token = "0x400B625")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _visitorNumThisWeek;

		// Token: 0x0400B626 RID: 46630
		[Token(Token = "0x400B626")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _visitorNumToday;

		// Token: 0x0400B627 RID: 46631
		[Token(Token = "0x400B627")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _rightText;

		// Token: 0x0400B628 RID: 46632
		[Token(Token = "0x400B628")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLeft;

		// Token: 0x0400B629 RID: 46633
		[Token(Token = "0x400B629")]
		[FieldOffset(Offset = "0x40")]
		private float m_timer;

		// Token: 0x0400B62A RID: 46634
		[Token(Token = "0x400B62A")]
		[FieldOffset(Offset = "0x48")]
		private DateTime m_countDownTime;

		// Token: 0x0400B62B RID: 46635
		[Token(Token = "0x400B62B")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0400B62C RID: 46636
		[Token(Token = "0x400B62C")]
		[FieldOffset(Offset = "0x51")]
		private bool m_needCountDown;

		// Token: 0x0400B62D RID: 46637
		[Token(Token = "0x400B62D")]
		[FieldOffset(Offset = "0x58")]
		private BuildingMessageLeaveBoardBottomInfoView.TimerData m_timeData;

		// Token: 0x0400B62E RID: 46638
		[Token(Token = "0x400B62E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400B62F RID: 46639
		[Token(Token = "0x400B62F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B630 RID: 46640
		[Token(Token = "0x400B630")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B631 RID: 46641
		[Token(Token = "0x400B631")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RendPlayerInfoView;

		// Token: 0x0400B632 RID: 46642
		[Token(Token = "0x400B632")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RendVisitorInfoView;

		// Token: 0x0400B633 RID: 46643
		[Token(Token = "0x400B633")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshTimeCountDown;

		// Token: 0x0400B634 RID: 46644
		[Token(Token = "0x400B634")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D24 RID: 7460
		[Token(Token = "0x2001D24")]
		private class TimerData
		{
			// Token: 0x0600B82D RID: 47149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B82D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TimerData()
			{
			}

			// Token: 0x0400B635 RID: 46645
			[Token(Token = "0x400B635")]
			[FieldOffset(Offset = "0x10")]
			public DateTime timeCountDown;
		}
	}
}
