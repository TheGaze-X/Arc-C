using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EB4 RID: 20148
	[Token(Token = "0x2004EB4")]
	public class FifthAnnivExplorePlanView : FifthAnnivExploreDetailViewBase
	{
		// Token: 0x1700468A RID: 18058
		// (get) Token: 0x0601E0F4 RID: 123124 RVA: 0x000AD508 File Offset: 0x000AB708
		[Token(Token = "0x1700468A")]
		protected override FifthAnnivExploreDecisionModel.DecisionStatus status
		{
			[Token(Token = "0x601E0F4")]
			[Address(RVA = "0x17C2FC0", Offset = "0x17C1BC0", VA = "0x1817C2FC0", Slot = "8")]
			get
			{
				return FifthAnnivExploreDecisionModel.DecisionStatus.NONE;
			}
		}

		// Token: 0x0601E0F5 RID: 123125 RVA: 0x000AD520 File Offset: 0x000AB720
		[Token(Token = "0x601E0F5")]
		[Address(RVA = "0x17C2120", Offset = "0x17C0D20", VA = "0x1817C2120", Slot = "10")]
		protected override UIAnimationLocation GetEnterAnim()
		{
			return default(UIAnimationLocation);
		}

		// Token: 0x0601E0F6 RID: 123126 RVA: 0x000AD538 File Offset: 0x000AB738
		[Token(Token = "0x601E0F6")]
		[Address(RVA = "0x17C21A0", Offset = "0x17C0DA0", VA = "0x1817C21A0", Slot = "11")]
		public override bool IsTweenPlaying()
		{
			return default(bool);
		}

		// Token: 0x0601E0F7 RID: 123127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0F7")]
		[Address(RVA = "0x17C2230", Offset = "0x17C0E30", VA = "0x1817C2230", Slot = "9")]
		protected override void OnDataUpdate()
		{
		}

		// Token: 0x0601E0F8 RID: 123128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0F8")]
		[Address(RVA = "0x17C28D0", Offset = "0x17C14D0", VA = "0x1817C28D0")]
		private void _PlaySwitchAnimIfNeed()
		{
		}

		// Token: 0x0601E0F9 RID: 123129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0F9")]
		[Address(RVA = "0x17C2A80", Offset = "0x17C1680", VA = "0x1817C2A80")]
		private void _RenderEventPart()
		{
		}

		// Token: 0x0601E0FA RID: 123130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0FA")]
		[Address(RVA = "0x17C2D70", Offset = "0x17C1970", VA = "0x1817C2D70")]
		private void _RenderTargetPart()
		{
		}

		// Token: 0x0601E0FB RID: 123131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0FB")]
		[Address(RVA = "0x17C27A0", Offset = "0x17C13A0", VA = "0x1817C27A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E0FC RID: 123132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0FC")]
		[Address(RVA = "0x17C2090", Offset = "0x17C0C90", VA = "0x1817C2090")]
		public void EventOnBtnPrevClick()
		{
		}

		// Token: 0x0601E0FD RID: 123133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0FD")]
		[Address(RVA = "0x17C2000", Offset = "0x17C0C00", VA = "0x1817C2000")]
		public void EventOnBtnNextClick()
		{
		}

		// Token: 0x0601E0FE RID: 123134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0FE")]
		[Address(RVA = "0x17C2F10", Offset = "0x17C1B10", VA = "0x1817C2F10")]
		public FifthAnnivExplorePlanView()
		{
		}

		// Token: 0x0601E0FF RID: 123135 RVA: 0x000AD550 File Offset: 0x000AB750
		[Token(Token = "0x601E0FF")]
		[Address(RVA = "0x17BA7D0", Offset = "0x17B93D0", VA = "0x1817BA7D0")]
		private UIAnimationLocation <>xLuaBaseProxy_GetEnterAnim()
		{
			return default(UIAnimationLocation);
		}

		// Token: 0x0601E100 RID: 123136 RVA: 0x000AD568 File Offset: 0x000AB768
		[Token(Token = "0x601E100")]
		[Address(RVA = "0x17BA850", Offset = "0x17B9450", VA = "0x1817BA850")]
		private bool <>xLuaBaseProxy_IsTweenPlaying()
		{
			return default(bool);
		}

		// Token: 0x04027FDF RID: 163807
		[Token(Token = "0x4027FDF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textPlanTypeName;

		// Token: 0x04027FE0 RID: 163808
		[Token(Token = "0x4027FE0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textPlanName;

		// Token: 0x04027FE1 RID: 163809
		[Token(Token = "0x4027FE1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04027FE2 RID: 163810
		[Token(Token = "0x4027FE2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _optionList;

		// Token: 0x04027FE3 RID: 163811
		[Token(Token = "0x4027FE3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04027FE4 RID: 163812
		[Token(Token = "0x4027FE4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x04027FE5 RID: 163813
		[Token(Token = "0x4027FE5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Event Part")]
		private GameObject _btnPrevGo;

		// Token: 0x04027FE6 RID: 163814
		[Token(Token = "0x4027FE6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Event Part")]
		private UIAtlasImage _imgPrevEventIcon;

		// Token: 0x04027FE7 RID: 163815
		[Token(Token = "0x4027FE7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Event Part")]
		private GameObject _btnNextGo;

		// Token: 0x04027FE8 RID: 163816
		[Token(Token = "0x4027FE8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Event Part")]
		private UIAtlasImage _imgNextEventIcon;

		// Token: 0x04027FE9 RID: 163817
		[Token(Token = "0x4027FE9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Event Part")]
		private UIAtlasObject _iconAtlas;

		// Token: 0x04027FEA RID: 163818
		[Token(Token = "0x4027FEA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Event Part")]
		private UIAtlasImage _imgEventIcon;

		// Token: 0x04027FEB RID: 163819
		[Token(Token = "0x4027FEB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Event Part")]
		private GameObject _eventIconGo;

		// Token: 0x04027FEC RID: 163820
		[Token(Token = "0x4027FEC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Target Part")]
		private Text _textStageNum;

		// Token: 0x04027FED RID: 163821
		[Token(Token = "0x4027FED")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Target Part")]
		private GameObject _stageNumGo;

		// Token: 0x04027FEE RID: 163822
		[Token(Token = "0x4027FEE")]
		[FieldOffset(Offset = "0xC0")]
		private FifthAnnivExplorePlanModel m_currPlanModel;

		// Token: 0x04027FEF RID: 163823
		[Token(Token = "0x4027FEF")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x04027FF0 RID: 163824
		[Token(Token = "0x4027FF0")]
		[FieldOffset(Offset = "0xD0")]
		private FifthAnnivExplorePlanView.OptionListAdapter m_optionListAdapter;

		// Token: 0x04027FF1 RID: 163825
		[Token(Token = "0x4027FF1")]
		[FieldOffset(Offset = "0xD8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027FF2 RID: 163826
		[Token(Token = "0x4027FF2")]
		[FieldOffset(Offset = "0xE8")]
		private int m_cacheSwitchPlanSeqNum;

		// Token: 0x04027FF3 RID: 163827
		[Token(Token = "0x4027FF3")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_switchTween;

		// Token: 0x04027FF4 RID: 163828
		[Token(Token = "0x4027FF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x04027FF5 RID: 163829
		[Token(Token = "0x4027FF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetEnterAnim;

		// Token: 0x04027FF6 RID: 163830
		[Token(Token = "0x4027FF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsTweenPlaying;

		// Token: 0x04027FF7 RID: 163831
		[Token(Token = "0x4027FF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDataUpdate;

		// Token: 0x04027FF8 RID: 163832
		[Token(Token = "0x4027FF8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlaySwitchAnimIfNeed;

		// Token: 0x04027FF9 RID: 163833
		[Token(Token = "0x4027FF9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderEventPart;

		// Token: 0x04027FFA RID: 163834
		[Token(Token = "0x4027FFA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderTargetPart;

		// Token: 0x04027FFB RID: 163835
		[Token(Token = "0x4027FFB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027FFC RID: 163836
		[Token(Token = "0x4027FFC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBtnPrevClick;

		// Token: 0x04027FFD RID: 163837
		[Token(Token = "0x4027FFD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBtnNextClick;

		// Token: 0x04027FFE RID: 163838
		[Token(Token = "0x4027FFE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004EB5 RID: 20149
		[Token(Token = "0x2004EB5")]
		private class OptionListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E101 RID: 123137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E101")]
			[Address(RVA = "0x17C7B60", Offset = "0x17C6760", VA = "0x1817C7B60")]
			public OptionListAdapter(FifthAnnivExplorePlanView closure)
			{
			}

			// Token: 0x1700468B RID: 18059
			// (get) Token: 0x0601E102 RID: 123138 RVA: 0x000AD580 File Offset: 0x000AB780
			[Token(Token = "0x1700468B")]
			public override int count
			{
				[Token(Token = "0x601E102")]
				[Address(RVA = "0x17C7BE0", Offset = "0x17C67E0", VA = "0x1817C7BE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E103 RID: 123139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E103")]
			[Address(RVA = "0x17C7740", Offset = "0x17C6340", VA = "0x1817C7740", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04027FFF RID: 163839
			[Token(Token = "0x4027FFF")]
			[FieldOffset(Offset = "0x20")]
			private FifthAnnivExplorePlanView m_closure;

			// Token: 0x04028000 RID: 163840
			[Token(Token = "0x4028000")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028001 RID: 163841
			[Token(Token = "0x4028001")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04028002 RID: 163842
			[Token(Token = "0x4028002")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
