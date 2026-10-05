using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A35 RID: 18997
	[Token(Token = "0x2004A35")]
	public class InformantSelectChoiceView : DataBinder<InformantSelectChoiceProperty>
	{
		// Token: 0x0601C929 RID: 117033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C929")]
		[Address(RVA = "0x1619480", Offset = "0x1618080", VA = "0x181619480", Slot = "7")]
		public override void OnValueChanged(InformantSelectChoiceProperty property)
		{
		}

		// Token: 0x0601C92A RID: 117034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C92A")]
		[Address(RVA = "0x1619A10", Offset = "0x1618610", VA = "0x181619A10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C92B RID: 117035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C92B")]
		[Address(RVA = "0x16193F0", Offset = "0x1617FF0", VA = "0x1816193F0")]
		public void EventOnSettle()
		{
		}

		// Token: 0x0601C92C RID: 117036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C92C")]
		[Address(RVA = "0x1619360", Offset = "0x1617F60", VA = "0x181619360")]
		public void EventOnRequestOrOpenInsight()
		{
		}

		// Token: 0x0601C92D RID: 117037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C92D")]
		[Address(RVA = "0x16192D0", Offset = "0x1617ED0", VA = "0x1816192D0")]
		public void EventOnCloseInsight()
		{
		}

		// Token: 0x0601C92E RID: 117038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C92E")]
		[Address(RVA = "0x1619240", Offset = "0x1617E40", VA = "0x181619240")]
		public void EventOnBackgroundClicked()
		{
		}

		// Token: 0x0601C92F RID: 117039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C92F")]
		[Address(RVA = "0x1619FC0", Offset = "0x1618BC0", VA = "0x181619FC0")]
		private void _TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x0601C930 RID: 117040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C930")]
		[Address(RVA = "0x1619DD0", Offset = "0x16189D0", VA = "0x181619DD0")]
		private void _TutorialOnly_OnChangeItemListChanged()
		{
		}

		// Token: 0x0601C931 RID: 117041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C931")]
		[Address(RVA = "0x161A110", Offset = "0x1618D10", VA = "0x18161A110")]
		public InformantSelectChoiceView()
		{
		}

		// Token: 0x040257D7 RID: 153559
		[Token(Token = "0x40257D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Customer")]
		private InformantArrowComponent _trustArrow;

		// Token: 0x040257D8 RID: 153560
		[Token(Token = "0x40257D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Customer")]
		private TwoStateToggle _trustPositiveToggle;

		// Token: 0x040257D9 RID: 153561
		[Token(Token = "0x40257D9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Customer")]
		private InformantArrowComponent _attentionArrow;

		// Token: 0x040257DA RID: 153562
		[Token(Token = "0x40257DA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Customer")]
		private TwoStateToggle _attentionPositiveToggle;

		// Token: 0x040257DB RID: 153563
		[Token(Token = "0x40257DB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Keeper")]
		private TwoStateToggle _keeperDialogToggle;

		// Token: 0x040257DC RID: 153564
		[Token(Token = "0x40257DC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Keeper")]
		private Text _keeperDialog;

		// Token: 0x040257DD RID: 153565
		[Token(Token = "0x40257DD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Keeper")]
		private Text _round;

		// Token: 0x040257DE RID: 153566
		[Token(Token = "0x40257DE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Choice")]
		private SimpleLayoutContent _choiceContent;

		// Token: 0x040257DF RID: 153567
		[Token(Token = "0x40257DF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Choice")]
		private UIAnimationLocation _settleSwitchAnim;

		// Token: 0x040257E0 RID: 153568
		[Token(Token = "0x40257E0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Choice")]
		private UILayoutDimensionListener _choiceItemListListener;

		// Token: 0x040257E1 RID: 153569
		[Token(Token = "0x40257E1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Insight Closed")]
		private GameObject _panelInsightClosed;

		// Token: 0x040257E2 RID: 153570
		[Token(Token = "0x40257E2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Insight Closed")]
		private TwoStateToggle _requestInsightToggle;

		// Token: 0x040257E3 RID: 153571
		[Token(Token = "0x40257E3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Insight Closed")]
		private Text _remainInsightTime;

		// Token: 0x040257E4 RID: 153572
		[Token(Token = "0x40257E4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Insight Open")]
		private GameObject _panelInsightOpen;

		// Token: 0x040257E5 RID: 153573
		[Token(Token = "0x40257E5")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Insight Open")]
		private Text _patienceDesc;

		// Token: 0x040257E6 RID: 153574
		[Token(Token = "0x40257E6")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Insight Open")]
		private Text _trustDesc;

		// Token: 0x040257E7 RID: 153575
		[Token(Token = "0x40257E7")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Insight Open")]
		private Text _attentionDesc;

		// Token: 0x040257E8 RID: 153576
		[Token(Token = "0x40257E8")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Insight Open")]
		private GameObject _trustLowBg;

		// Token: 0x040257E9 RID: 153577
		[Token(Token = "0x40257E9")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Insight Open")]
		private GameObject _trustRCBg;

		// Token: 0x040257EA RID: 153578
		[Token(Token = "0x40257EA")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Insight Open")]
		private GameObject _trustMaxBg;

		// Token: 0x040257EB RID: 153579
		[Token(Token = "0x40257EB")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Insight Open")]
		private GameObject _attentionLowBg;

		// Token: 0x040257EC RID: 153580
		[Token(Token = "0x40257EC")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Insight Open")]
		private GameObject _attentionRCBg;

		// Token: 0x040257ED RID: 153581
		[Token(Token = "0x40257ED")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Insight Open")]
		private GameObject _attentionMaxBg;

		// Token: 0x040257EE RID: 153582
		[Token(Token = "0x40257EE")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Insight")]
		private InformantInsightBarView _insightBar;

		// Token: 0x040257EF RID: 153583
		[Token(Token = "0x40257EF")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Insight")]
		private float _normalInsightBarTweenDelay;

		// Token: 0x040257F0 RID: 153584
		[Token(Token = "0x40257F0")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[Group("Insight")]
		private float _noPatienceInsightBarTweenDelay;

		// Token: 0x040257F1 RID: 153585
		[Token(Token = "0x40257F1")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Insight")]
		private float _insightBarTweenDuration;

		// Token: 0x040257F2 RID: 153586
		[Token(Token = "0x40257F2")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _objInsightTutorialDetail;

		// Token: 0x040257F3 RID: 153587
		[Token(Token = "0x40257F3")]
		[FieldOffset(Offset = "0x100")]
		private InformantSelectChoiceViewModel m_viewModel;

		// Token: 0x040257F4 RID: 153588
		[Token(Token = "0x40257F4")]
		[FieldOffset(Offset = "0x108")]
		private InformantSelectChoiceView.ChoiceListAdapter m_choiceListAdapter;

		// Token: 0x040257F5 RID: 153589
		[Token(Token = "0x40257F5")]
		[FieldOffset(Offset = "0x110")]
		private bool m_hasInited;

		// Token: 0x040257F6 RID: 153590
		[Token(Token = "0x40257F6")]
		[FieldOffset(Offset = "0x118")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x040257F7 RID: 153591
		[Token(Token = "0x40257F7")]
		[FieldOffset(Offset = "0x128")]
		private int m_enterSeqNum;

		// Token: 0x040257F8 RID: 153592
		[Token(Token = "0x40257F8")]
		[FieldOffset(Offset = "0x130")]
		private UISwitchTween m_settleShowTween;

		// Token: 0x040257F9 RID: 153593
		[Token(Token = "0x40257F9")]
		private const int TUTORIAL_CHOICE_ITEM_INDEX = 0;

		// Token: 0x040257FA RID: 153594
		[Token(Token = "0x40257FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040257FB RID: 153595
		[Token(Token = "0x40257FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040257FC RID: 153596
		[Token(Token = "0x40257FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnSettle;

		// Token: 0x040257FD RID: 153597
		[Token(Token = "0x40257FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnRequestOrOpenInsight;

		// Token: 0x040257FE RID: 153598
		[Token(Token = "0x40257FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCloseInsight;

		// Token: 0x040257FF RID: 153599
		[Token(Token = "0x40257FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBackgroundClicked;

		// Token: 0x04025800 RID: 153600
		[Token(Token = "0x4025800")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RegisterTutorialGo;

		// Token: 0x04025801 RID: 153601
		[Token(Token = "0x4025801")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TutorialOnly_OnChangeItemListChanged;

		// Token: 0x04025802 RID: 153602
		[Token(Token = "0x4025802")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A36 RID: 18998
		[Token(Token = "0x2004A36")]
		private class ChoiceListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601C932 RID: 117042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C932")]
			[Address(RVA = "0x1609E00", Offset = "0x1608A00", VA = "0x181609E00")]
			public ChoiceListAdapter(InformantSelectChoiceView closure)
			{
			}

			// Token: 0x17004374 RID: 17268
			// (get) Token: 0x0601C933 RID: 117043 RVA: 0x000A8A98 File Offset: 0x000A6C98
			[Token(Token = "0x17004374")]
			public override int count
			{
				[Token(Token = "0x601C933")]
				[Address(RVA = "0x1609E80", Offset = "0x1608A80", VA = "0x181609E80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C934 RID: 117044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C934")]
			[Address(RVA = "0x1609C20", Offset = "0x1608820", VA = "0x181609C20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04025803 RID: 153603
			[Token(Token = "0x4025803")]
			[FieldOffset(Offset = "0x20")]
			private InformantSelectChoiceView m_closure;

			// Token: 0x04025804 RID: 153604
			[Token(Token = "0x4025804")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04025805 RID: 153605
			[Token(Token = "0x4025805")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04025806 RID: 153606
			[Token(Token = "0x4025806")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
