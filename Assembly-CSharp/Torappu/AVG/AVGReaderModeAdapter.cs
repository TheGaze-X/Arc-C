using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F1B RID: 7963
	[Token(Token = "0x2001F1B")]
	public class AVGReaderModeAdapter : ExecutorComponent
	{
		// Token: 0x0600C5A7 RID: 50599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C5A7")]
		[Address(RVA = "0x3460AB0", Offset = "0x345F6B0", VA = "0x183460AB0")]
		private AVGReaderModeViewModel _GetViewModel()
		{
			return null;
		}

		// Token: 0x0600C5A8 RID: 50600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A8")]
		[Address(RVA = "0x3461C30", Offset = "0x3460830", VA = "0x183461C30")]
		private void _NotifyViewModelChanged()
		{
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x0600C5A9 RID: 50601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001784")]
		private DecisionCommandPredicator m_decisionCommandPredicator
		{
			[Token(Token = "0x600C5A9")]
			[Address(RVA = "0x3464BA0", Offset = "0x34637A0", VA = "0x183464BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C5AA RID: 50602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C5AA")]
		[Address(RVA = "0x345EC80", Offset = "0x345D880", VA = "0x18345EC80", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C5AB RID: 50603 RVA: 0x00048510 File Offset: 0x00046710
		[Token(Token = "0x600C5AB")]
		[Address(RVA = "0x3462910", Offset = "0x3461510", VA = "0x183462910")]
		private bool _ProcessDialog(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600C5AC RID: 50604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5AC")]
		[Address(RVA = "0x3461E70", Offset = "0x3460A70", VA = "0x183461E70")]
		private void _OnClicked(object arg)
		{
		}

		// Token: 0x0600C5AD RID: 50605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5AD")]
		[Address(RVA = "0x345F880", Offset = "0x345E480", VA = "0x18345F880", Slot = "11")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600C5AE RID: 50606 RVA: 0x00048528 File Offset: 0x00046728
		[Token(Token = "0x600C5AE")]
		[Address(RVA = "0x3462730", Offset = "0x3461330", VA = "0x183462730")]
		private bool _ProcessDecision(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600C5AF RID: 50607 RVA: 0x00048540 File Offset: 0x00046740
		[Token(Token = "0x600C5AF")]
		[Address(RVA = "0x3463020", Offset = "0x3461C20", VA = "0x183463020")]
		private bool _ProcessPredicate(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600C5B0 RID: 50608 RVA: 0x00048558 File Offset: 0x00046758
		[Token(Token = "0x600C5B0")]
		[Address(RVA = "0x3462BA0", Offset = "0x34617A0", VA = "0x183462BA0")]
		private bool _ProcessEndtip(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600C5B1 RID: 50609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B1")]
		[Address(RVA = "0x3461FD0", Offset = "0x3460BD0", VA = "0x183461FD0")]
		private void _OnEndtipClicked(object arg)
		{
		}

		// Token: 0x0600C5B2 RID: 50610 RVA: 0x00048570 File Offset: 0x00046770
		[Token(Token = "0x600C5B2")]
		[Address(RVA = "0x3463630", Offset = "0x3462230", VA = "0x183463630")]
		private bool _ProcessSubtitle(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600C5B3 RID: 50611 RVA: 0x00048588 File Offset: 0x00046788
		[Token(Token = "0x600C5B3")]
		[Address(RVA = "0x34624A0", Offset = "0x34610A0", VA = "0x1834624A0")]
		private bool _ProcessAside(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600C5B4 RID: 50612 RVA: 0x000485A0 File Offset: 0x000467A0
		[Token(Token = "0x600C5B4")]
		[Address(RVA = "0x3463280", Offset = "0x3461E80", VA = "0x183463280")]
		private bool _ProcessSticker(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600C5B5 RID: 50613 RVA: 0x000485B8 File Offset: 0x000467B8
		[Token(Token = "0x600C5B5")]
		[Address(RVA = "0x3462210", Offset = "0x3460E10", VA = "0x183462210")]
		private bool _ProcessAnimText(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600C5B6 RID: 50614 RVA: 0x000485D0 File Offset: 0x000467D0
		[Token(Token = "0x600C5B6")]
		[Address(RVA = "0x3462DA0", Offset = "0x34619A0", VA = "0x183462DA0")]
		private bool _ProcessMultiline(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600C5B7 RID: 50615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B7")]
		[Address(RVA = "0x345E9D0", Offset = "0x345D5D0", VA = "0x18345E9D0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C5B8 RID: 50616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B8")]
		[Address(RVA = "0x345FCD0", Offset = "0x345E8D0", VA = "0x18345FCD0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C5B9 RID: 50617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B9")]
		[Address(RVA = "0x345FE80", Offset = "0x345EA80", VA = "0x18345FE80", Slot = "6")]
		public override void OnStoryEnd(Story story)
		{
		}

		// Token: 0x0600C5BA RID: 50618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5BA")]
		[Address(RVA = "0x3460780", Offset = "0x345F380", VA = "0x183460780")]
		private void _ClearViewModel()
		{
		}

		// Token: 0x0600C5BB RID: 50619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5BB")]
		[Address(RVA = "0x345F0A0", Offset = "0x345DCA0", VA = "0x18345F0A0")]
		public void Initialize(AVGUIStateEngineController host)
		{
		}

		// Token: 0x0600C5BC RID: 50620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5BC")]
		[Address(RVA = "0x345E860", Offset = "0x345D460", VA = "0x18345E860")]
		public void BindView(AVGReaderModeView view)
		{
		}

		// Token: 0x0600C5BD RID: 50621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5BD")]
		[Address(RVA = "0x34603D0", Offset = "0x345EFD0", VA = "0x1834603D0")]
		public void UnbindView(AVGReaderModeView view)
		{
		}

		// Token: 0x0600C5BE RID: 50622 RVA: 0x000485E8 File Offset: 0x000467E8
		[Token(Token = "0x600C5BE")]
		[Address(RVA = "0x3460250", Offset = "0x345EE50", VA = "0x183460250")]
		public bool ShouldScrollToEnd()
		{
			return default(bool);
		}

		// Token: 0x0600C5BF RID: 50623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5BF")]
		[Address(RVA = "0x3463EC0", Offset = "0x3462AC0", VA = "0x183463EC0")]
		private void _UninitView()
		{
		}

		// Token: 0x0600C5C0 RID: 50624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C0")]
		[Address(RVA = "0x3460490", Offset = "0x345F090", VA = "0x183460490")]
		private void _BindViewEvents()
		{
		}

		// Token: 0x0600C5C1 RID: 50625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C1")]
		[Address(RVA = "0x3463DD0", Offset = "0x34629D0", VA = "0x183463DD0")]
		private void _UnbindViewEvents()
		{
		}

		// Token: 0x0600C5C2 RID: 50626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C2")]
		[Address(RVA = "0x3460000", Offset = "0x345EC00", VA = "0x183460000")]
		public void SetAutoPlayController(AVGReaderModeAutoPlayController controller)
		{
		}

		// Token: 0x0600C5C3 RID: 50627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C3")]
		[Address(RVA = "0x3461CB0", Offset = "0x34608B0", VA = "0x183461CB0")]
		private void _OnAutoClickTriggered()
		{
		}

		// Token: 0x0600C5C4 RID: 50628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C5C4")]
		[Address(RVA = "0x3461DC0", Offset = "0x34609C0", VA = "0x183461DC0")]
		private Action _OnClickPress()
		{
			return null;
		}

		// Token: 0x0600C5C5 RID: 50629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C5")]
		[Address(RVA = "0x3463B30", Offset = "0x3462730", VA = "0x183463B30")]
		private void _ResetLastCurrentIcon()
		{
		}

		// Token: 0x0600C5C6 RID: 50630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C6")]
		[Address(RVA = "0x3464060", Offset = "0x3462C60", VA = "0x183464060")]
		private void _UpdateProp(Command cmd)
		{
		}

		// Token: 0x0600C5C7 RID: 50631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C7")]
		[Address(RVA = "0x34610A0", Offset = "0x345FCA0", VA = "0x1834610A0")]
		private void _HandleDialogCommand(Command cmd)
		{
		}

		// Token: 0x0600C5C8 RID: 50632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C8")]
		[Address(RVA = "0x3460F00", Offset = "0x345FB00", VA = "0x183460F00")]
		private void _HandleDecisionCommand(Command cmd)
		{
		}

		// Token: 0x0600C5C9 RID: 50633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C9")]
		[Address(RVA = "0x3461730", Offset = "0x3460330", VA = "0x183461730")]
		private void _HandlePredicateCommand(Command cmd)
		{
		}

		// Token: 0x0600C5CA RID: 50634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CA")]
		[Address(RVA = "0x3461A80", Offset = "0x3460680", VA = "0x183461A80")]
		private void _HandleSubtitleCommand(Command cmd)
		{
		}

		// Token: 0x0600C5CB RID: 50635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CB")]
		[Address(RVA = "0x3460DD0", Offset = "0x345F9D0", VA = "0x183460DD0")]
		private void _HandleAsideCommand(Command cmd)
		{
		}

		// Token: 0x0600C5CC RID: 50636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CC")]
		[Address(RVA = "0x3461290", Offset = "0x345FE90", VA = "0x183461290")]
		private void _HandleEndtipCommand(Command cmd)
		{
		}

		// Token: 0x0600C5CD RID: 50637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CD")]
		[Address(RVA = "0x3460B10", Offset = "0x345F710", VA = "0x183460B10")]
		private void _HandleAddDialogCell(string name, string content, bool isCurrent)
		{
		}

		// Token: 0x0600C5CE RID: 50638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CE")]
		[Address(RVA = "0x34618B0", Offset = "0x34604B0", VA = "0x1834618B0")]
		private void _HandleStickerCommand(Command cmd)
		{
		}

		// Token: 0x0600C5CF RID: 50639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CF")]
		[Address(RVA = "0x3461360", Offset = "0x345FF60", VA = "0x183461360")]
		private void _HandleMultilineCommand(Command cmd)
		{
		}

		// Token: 0x0600C5D0 RID: 50640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D0")]
		[Address(RVA = "0x3460C10", Offset = "0x345F810", VA = "0x183460C10")]
		private void _HandleAnimTextCommand(Command cmd)
		{
		}

		// Token: 0x0600C5D1 RID: 50641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D1")]
		[Address(RVA = "0x3463C80", Offset = "0x3462880", VA = "0x183463C80")]
		private void _TryEndMultilineMode()
		{
		}

		// Token: 0x0600C5D2 RID: 50642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D2")]
		[Address(RVA = "0x34639C0", Offset = "0x34625C0", VA = "0x1834639C0")]
		private void _RenderPerformanceContext(Command cmd)
		{
		}

		// Token: 0x0600C5D3 RID: 50643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D3")]
		[Address(RVA = "0x34606D0", Offset = "0x345F2D0", VA = "0x1834606D0")]
		private void _BroadcastResetToOtherModules()
		{
		}

		// Token: 0x0600C5D4 RID: 50644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D4")]
		[Address(RVA = "0x345F820", Offset = "0x345E420", VA = "0x18345F820")]
		private void OnEnable()
		{
		}

		// Token: 0x0600C5D5 RID: 50645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D5")]
		[Address(RVA = "0x345F510", Offset = "0x345E110", VA = "0x18345F510")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C5D6 RID: 50646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D6")]
		[Address(RVA = "0x3463D10", Offset = "0x3462910", VA = "0x183463D10")]
		private void _TryRegisterComponent()
		{
		}

		// Token: 0x0600C5D7 RID: 50647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D7")]
		[Address(RVA = "0x3463FA0", Offset = "0x3462BA0", VA = "0x183463FA0")]
		private void _UnregisterComponent()
		{
		}

		// Token: 0x0600C5D8 RID: 50648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C5D8")]
		[Address(RVA = "0x345EA30", Offset = "0x345D630", VA = "0x18345EA30", Slot = "10")]
		protected override ICommandExecutor GenerateExecutorWrapper(ExecutorComponent.WrapperOptions options)
		{
			return null;
		}

		// Token: 0x0600C5D9 RID: 50649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D9")]
		[Address(RVA = "0x345F1C0", Offset = "0x345DDC0", VA = "0x18345F1C0")]
		public void OnDecisionOptionSelected(int index)
		{
		}

		// Token: 0x0600C5DA RID: 50650 RVA: 0x00048600 File Offset: 0x00046800
		[Token(Token = "0x600C5DA")]
		[Address(RVA = "0x3460800", Offset = "0x345F400", VA = "0x183460800")]
		private int _GetOptionValue(string valueString, int index)
		{
			return 0;
		}

		// Token: 0x0600C5DB RID: 50651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C5DB")]
		[Address(RVA = "0x3460980", Offset = "0x345F580", VA = "0x183460980")]
		private int[] _GetReferenceValue(string valueString)
		{
			return null;
		}

		// Token: 0x0600C5DC RID: 50652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5DC")]
		[Address(RVA = "0x345FF70", Offset = "0x345EB70", VA = "0x18345FF70")]
		public void ReaderModeSettingChanged()
		{
		}

		// Token: 0x0600C5DD RID: 50653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5DD")]
		[Address(RVA = "0x345FA70", Offset = "0x345E670", VA = "0x18345FA70")]
		public void OnReaderModeOpened()
		{
		}

		// Token: 0x0600C5DE RID: 50654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5DE")]
		[Address(RVA = "0x3464AE0", Offset = "0x34636E0", VA = "0x183464AE0")]
		public AVGReaderModeAdapter()
		{
		}

		// Token: 0x0600C5E0 RID: 50656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E0")]
		[Address(RVA = "0x33F4E00", Offset = "0x33F3A00", VA = "0x1833F4E00")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0600C5E1 RID: 50657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E1")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C5E2 RID: 50658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E2")]
		[Address(RVA = "0x33F0E80", Offset = "0x33EFA80", VA = "0x1833F0E80")]
		private void <>xLuaBaseProxy_OnStoryEnd(Story P0)
		{
		}

		// Token: 0x0600C5E3 RID: 50659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C5E3")]
		[Address(RVA = "0x340EC50", Offset = "0x340D850", VA = "0x18340EC50")]
		private ICommandExecutor <>xLuaBaseProxy_GenerateExecutorWrapper(ExecutorComponent.WrapperOptions P0)
		{
			return null;
		}

		// Token: 0x0400CA83 RID: 51843
		[Token(Token = "0x400CA83")]
		private const string PARAM_NAME_OPTIONS = "options";

		// Token: 0x0400CA84 RID: 51844
		[Token(Token = "0x400CA84")]
		private const string PARAM_NAME_VALUES = "values";

		// Token: 0x0400CA85 RID: 51845
		[Token(Token = "0x400CA85")]
		private const string PARAM_NAME_REFERENCES = "references";

		// Token: 0x0400CA86 RID: 51846
		[Token(Token = "0x400CA86")]
		private const string COMMAND_NAME_DECISION = "decision";

		// Token: 0x0400CA87 RID: 51847
		[Token(Token = "0x400CA87")]
		private const string COMMAND_NAME_PREDICATE = "predicate";

		// Token: 0x0400CA88 RID: 51848
		[Token(Token = "0x400CA88")]
		private const string COMMAND_NAME_DIALOG = "dialog";

		// Token: 0x0400CA89 RID: 51849
		[Token(Token = "0x400CA89")]
		private const string COMMAND_NAME_SUBTITLE = "subtitle";

		// Token: 0x0400CA8A RID: 51850
		[Token(Token = "0x400CA8A")]
		private const string COMMAND_NAME_ASIDE = "aside";

		// Token: 0x0400CA8B RID: 51851
		[Token(Token = "0x400CA8B")]
		private const string COMMAND_NAME_STICKER = "sticker";

		// Token: 0x0400CA8C RID: 51852
		[Token(Token = "0x400CA8C")]
		private const string COMMAND_NAME_MULTILINE = "multiline";

		// Token: 0x0400CA8D RID: 51853
		[Token(Token = "0x400CA8D")]
		private const string COMMAND_NAME_ANIMTEXT = "animtext";

		// Token: 0x0400CA8E RID: 51854
		[Token(Token = "0x400CA8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AVGReaderModeViewModel m_viewModel;

		// Token: 0x0400CA8F RID: 51855
		[Token(Token = "0x400CA8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AVGDataDriver<AVGReaderModeViewModel> m_viewModelDriver;

		// Token: 0x0400CA90 RID: 51856
		[Token(Token = "0x400CA90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AVGReaderModeView m_view;

		// Token: 0x0400CA91 RID: 51857
		[Token(Token = "0x400CA91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_isRegistered;

		// Token: 0x0400CA92 RID: 51858
		[Token(Token = "0x400CA92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0400CA93 RID: 51859
		[Token(Token = "0x400CA93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Command m_currentDecisionCommand;

		// Token: 0x0400CA94 RID: 51860
		[Token(Token = "0x400CA94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AVGReaderModeAutoPlayController m_autoPlayController;

		// Token: 0x0400CA95 RID: 51861
		[Token(Token = "0x400CA95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Action m_cachedClickAction;

		// Token: 0x0400CA96 RID: 51862
		[Token(Token = "0x400CA96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ListDict<int, string> m_cachedAnimTextContent;

		// Token: 0x0400CA97 RID: 51863
		[Token(Token = "0x400CA97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AVGUIStateEngineController m_host;

		// Token: 0x0400CA98 RID: 51864
		[Token(Token = "0x400CA98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool m_isProcessingMultiline;

		// Token: 0x0400CA99 RID: 51865
		[Token(Token = "0x400CA99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private StringBuilder m_cachedStrBuilder;

		// Token: 0x0400CA9A RID: 51866
		[Token(Token = "0x400CA9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int m_multilineCellIndex;

		// Token: 0x0400CA9B RID: 51867
		[Token(Token = "0x400CA9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_isWaitingForClick;

		// Token: 0x0400CA9C RID: 51868
		[Token(Token = "0x400CA9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetViewModel;

		// Token: 0x0400CA9D RID: 51869
		[Token(Token = "0x400CA9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__NotifyViewModelChanged;

		// Token: 0x0400CA9E RID: 51870
		[Token(Token = "0x400CA9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_m_decisionCommandPredicator;

		// Token: 0x0400CA9F RID: 51871
		[Token(Token = "0x400CA9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400CAA0 RID: 51872
		[Token(Token = "0x400CAA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ProcessDialog;

		// Token: 0x0400CAA1 RID: 51873
		[Token(Token = "0x400CAA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnClicked;

		// Token: 0x0400CAA2 RID: 51874
		[Token(Token = "0x400CAA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400CAA3 RID: 51875
		[Token(Token = "0x400CAA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ProcessDecision;

		// Token: 0x0400CAA4 RID: 51876
		[Token(Token = "0x400CAA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ProcessPredicate;

		// Token: 0x0400CAA5 RID: 51877
		[Token(Token = "0x400CAA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ProcessEndtip;

		// Token: 0x0400CAA6 RID: 51878
		[Token(Token = "0x400CAA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnEndtipClicked;

		// Token: 0x0400CAA7 RID: 51879
		[Token(Token = "0x400CAA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ProcessSubtitle;

		// Token: 0x0400CAA8 RID: 51880
		[Token(Token = "0x400CAA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ProcessAside;

		// Token: 0x0400CAA9 RID: 51881
		[Token(Token = "0x400CAA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ProcessSticker;

		// Token: 0x0400CAAA RID: 51882
		[Token(Token = "0x400CAAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ProcessAnimText;

		// Token: 0x0400CAAB RID: 51883
		[Token(Token = "0x400CAAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ProcessMultiline;

		// Token: 0x0400CAAC RID: 51884
		[Token(Token = "0x400CAAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400CAAD RID: 51885
		[Token(Token = "0x400CAAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400CAAE RID: 51886
		[Token(Token = "0x400CAAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnStoryEnd;

		// Token: 0x0400CAAF RID: 51887
		[Token(Token = "0x400CAAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ClearViewModel;

		// Token: 0x0400CAB0 RID: 51888
		[Token(Token = "0x400CAB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Initialize;

		// Token: 0x0400CAB1 RID: 51889
		[Token(Token = "0x400CAB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_BindView;

		// Token: 0x0400CAB2 RID: 51890
		[Token(Token = "0x400CAB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_UnbindView;

		// Token: 0x0400CAB3 RID: 51891
		[Token(Token = "0x400CAB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ShouldScrollToEnd;

		// Token: 0x0400CAB4 RID: 51892
		[Token(Token = "0x400CAB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UninitView;

		// Token: 0x0400CAB5 RID: 51893
		[Token(Token = "0x400CAB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__BindViewEvents;

		// Token: 0x0400CAB6 RID: 51894
		[Token(Token = "0x400CAB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UnbindViewEvents;

		// Token: 0x0400CAB7 RID: 51895
		[Token(Token = "0x400CAB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_SetAutoPlayController;

		// Token: 0x0400CAB8 RID: 51896
		[Token(Token = "0x400CAB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnAutoClickTriggered;

		// Token: 0x0400CAB9 RID: 51897
		[Token(Token = "0x400CAB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnClickPress;

		// Token: 0x0400CABA RID: 51898
		[Token(Token = "0x400CABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ResetLastCurrentIcon;

		// Token: 0x0400CABB RID: 51899
		[Token(Token = "0x400CABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__UpdateProp;

		// Token: 0x0400CABC RID: 51900
		[Token(Token = "0x400CABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__HandleDialogCommand;

		// Token: 0x0400CABD RID: 51901
		[Token(Token = "0x400CABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__HandleDecisionCommand;

		// Token: 0x0400CABE RID: 51902
		[Token(Token = "0x400CABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__HandlePredicateCommand;

		// Token: 0x0400CABF RID: 51903
		[Token(Token = "0x400CABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__HandleSubtitleCommand;

		// Token: 0x0400CAC0 RID: 51904
		[Token(Token = "0x400CAC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__HandleAsideCommand;

		// Token: 0x0400CAC1 RID: 51905
		[Token(Token = "0x400CAC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__HandleEndtipCommand;

		// Token: 0x0400CAC2 RID: 51906
		[Token(Token = "0x400CAC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__HandleAddDialogCell;

		// Token: 0x0400CAC3 RID: 51907
		[Token(Token = "0x400CAC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__HandleStickerCommand;

		// Token: 0x0400CAC4 RID: 51908
		[Token(Token = "0x400CAC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__HandleMultilineCommand;

		// Token: 0x0400CAC5 RID: 51909
		[Token(Token = "0x400CAC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__HandleAnimTextCommand;

		// Token: 0x0400CAC6 RID: 51910
		[Token(Token = "0x400CAC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__TryEndMultilineMode;

		// Token: 0x0400CAC7 RID: 51911
		[Token(Token = "0x400CAC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__RenderPerformanceContext;

		// Token: 0x0400CAC8 RID: 51912
		[Token(Token = "0x400CAC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__BroadcastResetToOtherModules;

		// Token: 0x0400CAC9 RID: 51913
		[Token(Token = "0x400CAC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400CACA RID: 51914
		[Token(Token = "0x400CACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400CACB RID: 51915
		[Token(Token = "0x400CACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__TryRegisterComponent;

		// Token: 0x0400CACC RID: 51916
		[Token(Token = "0x400CACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__UnregisterComponent;

		// Token: 0x0400CACD RID: 51917
		[Token(Token = "0x400CACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_GenerateExecutorWrapper;

		// Token: 0x0400CACE RID: 51918
		[Token(Token = "0x400CACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_OnDecisionOptionSelected;

		// Token: 0x0400CACF RID: 51919
		[Token(Token = "0x400CACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__GetOptionValue;

		// Token: 0x0400CAD0 RID: 51920
		[Token(Token = "0x400CAD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__GetReferenceValue;

		// Token: 0x0400CAD1 RID: 51921
		[Token(Token = "0x400CAD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_ReaderModeSettingChanged;

		// Token: 0x0400CAD2 RID: 51922
		[Token(Token = "0x400CAD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_OnReaderModeOpened;

		// Token: 0x0400CAD3 RID: 51923
		[Token(Token = "0x400CAD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F1C RID: 7964
		[Token(Token = "0x2001F1C")]
		private class InternalCommand : CommandExecutorWrapper, IUIInputCommand
		{
			// Token: 0x0600C5E4 RID: 50660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C5E4")]
			[Address(RVA = "0x3472DE0", Offset = "0x34719E0", VA = "0x183472DE0")]
			public InternalCommand(string command, CommandExecuteDelegate executor, [Optional] Action forceEnd, [Optional] RaiseSignalDelegate signalReceiver)
			{
			}

			// Token: 0x0400CAD4 RID: 51924
			[Token(Token = "0x400CAD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
