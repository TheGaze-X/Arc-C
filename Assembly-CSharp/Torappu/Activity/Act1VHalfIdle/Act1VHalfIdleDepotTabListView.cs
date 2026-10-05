using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007739 RID: 30521
	[Token(Token = "0x2007739")]
	public class Act1VHalfIdleDepotTabListView : DataBinder<UITabPager.TabPageGroupProperty>
	{
		// Token: 0x0602AE17 RID: 175639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE17")]
		[Address(RVA = "0x26AEDA0", Offset = "0x26AD9A0", VA = "0x1826AEDA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AE18 RID: 175640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE18")]
		[Address(RVA = "0x26AE730", Offset = "0x26AD330", VA = "0x1826AE730", Slot = "7")]
		public override void OnValueChanged(UITabPager.TabPageGroupProperty property)
		{
		}

		// Token: 0x0602AE19 RID: 175641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE19")]
		[Address(RVA = "0x26AEFD0", Offset = "0x26ADBD0", VA = "0x1826AEFD0")]
		private void _RenderCharTab(Act1VHalfIdleDepotTabViewModel tabViewModel)
		{
		}

		// Token: 0x0602AE1A RID: 175642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE1A")]
		[Address(RVA = "0x26AEF10", Offset = "0x26ADB10", VA = "0x1826AEF10")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x0602AE1B RID: 175643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE1B")]
		[Address(RVA = "0x26AE670", Offset = "0x26AD270", VA = "0x1826AE670")]
		public void OnBtnRecruitClicked()
		{
		}

		// Token: 0x0602AE1C RID: 175644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE1C")]
		[Address(RVA = "0x26AF1D0", Offset = "0x26ADDD0", VA = "0x1826AF1D0")]
		public Act1VHalfIdleDepotTabListView()
		{
		}

		// Token: 0x0403DD28 RID: 253224
		[Token(Token = "0x403DD28")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1VHalfIdleDepotTabItemView[] _tabViews;

		// Token: 0x0403DD29 RID: 253225
		[Token(Token = "0x403DD29")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animBtnRecruitShow;

		// Token: 0x0403DD2A RID: 253226
		[Token(Token = "0x403DD2A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIActTrackPoint _recruitTrackpoint;

		// Token: 0x0403DD2B RID: 253227
		[Token(Token = "0x403DD2B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _charTabTrackpointHolder;

		// Token: 0x0403DD2C RID: 253228
		[Token(Token = "0x403DD2C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIActTrackPoint _charTabTrackpoint;

		// Token: 0x0403DD2D RID: 253229
		[Token(Token = "0x403DD2D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _btnRecruitGO;

		// Token: 0x0403DD2E RID: 253230
		[Token(Token = "0x403DD2E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlRecruitCount;

		// Token: 0x0403DD2F RID: 253231
		[Token(Token = "0x403DD2F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textRecruitCount;

		// Token: 0x0403DD30 RID: 253232
		[Token(Token = "0x403DD30")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedSelectedTabId;

		// Token: 0x0403DD31 RID: 253233
		[Token(Token = "0x403DD31")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DD32 RID: 253234
		[Token(Token = "0x403DD32")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_btnRecruitShowTween;

		// Token: 0x0403DD33 RID: 253235
		[Token(Token = "0x403DD33")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x0403DD34 RID: 253236
		[Token(Token = "0x403DD34")]
		[FieldOffset(Offset = "0x8C")]
		private int m_cachedInitSeqNum;

		// Token: 0x0403DD35 RID: 253237
		[Token(Token = "0x403DD35")]
		[FieldOffset(Offset = "0x90")]
		private TrackPointViewProperty m_recruitTrackpoint;

		// Token: 0x0403DD36 RID: 253238
		[Token(Token = "0x403DD36")]
		[FieldOffset(Offset = "0x98")]
		private TrackPointViewProperty m_charTabTrackpoint;

		// Token: 0x0403DD37 RID: 253239
		[Token(Token = "0x403DD37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DD38 RID: 253240
		[Token(Token = "0x403DD38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403DD39 RID: 253241
		[Token(Token = "0x403DD39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCharTab;

		// Token: 0x0403DD3A RID: 253242
		[Token(Token = "0x403DD3A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x0403DD3B RID: 253243
		[Token(Token = "0x403DD3B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnRecruitClicked;

		// Token: 0x0403DD3C RID: 253244
		[Token(Token = "0x403DD3C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200773A RID: 30522
		[Token(Token = "0x200773A")]
		private class RecruitTrackpointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700648E RID: 25742
			// (get) Token: 0x0602AE1D RID: 175645 RVA: 0x000DA538 File Offset: 0x000D8738
			[Token(Token = "0x1700648E")]
			public bool isShow
			{
				[Token(Token = "0x602AE1D")]
				[Address(RVA = "0x26C2A90", Offset = "0x26C1690", VA = "0x1826C2A90", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602AE1E RID: 175646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE1E")]
			[Address(RVA = "0x26C2950", Offset = "0x26C1550", VA = "0x1826C2950", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602AE1F RID: 175647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE1F")]
			[Address(RVA = "0x26C2A30", Offset = "0x26C1630", VA = "0x1826C2A30")]
			public RecruitTrackpointModel()
			{
			}

			// Token: 0x0403DD3D RID: 253245
			[Token(Token = "0x403DD3D")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0403DD3E RID: 253246
			[Token(Token = "0x403DD3E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403DD3F RID: 253247
			[Token(Token = "0x403DD3F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403DD40 RID: 253248
			[Token(Token = "0x403DD40")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200773B RID: 30523
			[Token(Token = "0x200773B")]
			public class Param
			{
				// Token: 0x0602AE20 RID: 175648 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602AE20")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x0403DD41 RID: 253249
				[Token(Token = "0x403DD41")]
				[FieldOffset(Offset = "0x10")]
				public string actId;
			}
		}

		// Token: 0x0200773C RID: 30524
		[Token(Token = "0x200773C")]
		public class TabCharTrackpointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700648F RID: 25743
			// (get) Token: 0x0602AE21 RID: 175649 RVA: 0x000DA550 File Offset: 0x000D8750
			[Token(Token = "0x1700648F")]
			public bool isShow
			{
				[Token(Token = "0x602AE21")]
				[Address(RVA = "0x26C3380", Offset = "0x26C1F80", VA = "0x1826C3380", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602AE22 RID: 175650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE22")]
			[Address(RVA = "0x26C31C0", Offset = "0x26C1DC0", VA = "0x1826C31C0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602AE23 RID: 175651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE23")]
			[Address(RVA = "0x26C32D0", Offset = "0x26C1ED0", VA = "0x1826C32D0")]
			public TabCharTrackpointModel()
			{
			}

			// Token: 0x0403DD42 RID: 253250
			[Token(Token = "0x403DD42")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0403DD43 RID: 253251
			[Token(Token = "0x403DD43")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<int, List<Act1VHalfIdleCharAvatarViewModel>> m_profMap;

			// Token: 0x0403DD44 RID: 253252
			[Token(Token = "0x403DD44")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403DD45 RID: 253253
			[Token(Token = "0x403DD45")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403DD46 RID: 253254
			[Token(Token = "0x403DD46")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200773D RID: 30525
			[Token(Token = "0x200773D")]
			public class Param
			{
				// Token: 0x0602AE24 RID: 175652 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602AE24")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x0403DD47 RID: 253255
				[Token(Token = "0x403DD47")]
				[FieldOffset(Offset = "0x10")]
				public string actId;
			}
		}
	}
}
