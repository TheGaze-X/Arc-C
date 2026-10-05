using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007770 RID: 30576
	[Token(Token = "0x2007770")]
	public class Act1VHalfidlePlotSquadState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0602AF17 RID: 175895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF17")]
		[Address(RVA = "0x26BFD60", Offset = "0x26BE960", VA = "0x1826BFD60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AF18 RID: 175896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF18")]
		[Address(RVA = "0x26BF550", Offset = "0x26BE150", VA = "0x1826BF550", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602AF19 RID: 175897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF19")]
		[Address(RVA = "0x26BF720", Offset = "0x26BE320", VA = "0x1826BF720", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602AF1A RID: 175898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF1A")]
		[Address(RVA = "0x26BF160", Offset = "0x26BDD60", VA = "0x1826BF160", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AF1B RID: 175899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF1B")]
		[Address(RVA = "0x26BF1C0", Offset = "0x26BDDC0", VA = "0x1826BF1C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AF1C RID: 175900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF1C")]
		[Address(RVA = "0x26BF470", Offset = "0x26BE070", VA = "0x1826BF470", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602AF1D RID: 175901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF1D")]
		[Address(RVA = "0x26BF390", Offset = "0x26BDF90", VA = "0x1826BF390", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602AF1E RID: 175902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF1E")]
		[Address(RVA = "0x26C0400", Offset = "0x26BF000", VA = "0x1826C0400")]
		private void _OnJumpFromSquadState(IStateBean stateBean)
		{
		}

		// Token: 0x0602AF1F RID: 175903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF1F")]
		[Address(RVA = "0x26C0010", Offset = "0x26BEC10", VA = "0x1826C0010")]
		private void _OnJumpFromPlotSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0602AF20 RID: 175904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF20")]
		[Address(RVA = "0x26C1420", Offset = "0x26C0020", VA = "0x1826C1420")]
		private void _RegisterToPlotSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0602AF21 RID: 175905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF21")]
		[Address(RVA = "0x26C09D0", Offset = "0x26BF5D0", VA = "0x1826C09D0")]
		private void _OnPlotClick(ValueBundle msg)
		{
		}

		// Token: 0x0602AF22 RID: 175906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF22")]
		[Address(RVA = "0x26C12E0", Offset = "0x26BFEE0", VA = "0x1826C12E0")]
		private void _OnTopMenuCreated(GameObject obj)
		{
		}

		// Token: 0x0602AF23 RID: 175907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF23")]
		[Address(RVA = "0x26BFEF0", Offset = "0x26BEAF0", VA = "0x1826BFEF0")]
		private void _OnBtnBackClicked()
		{
		}

		// Token: 0x0602AF24 RID: 175908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF24")]
		[Address(RVA = "0x26C0D10", Offset = "0x26BF910", VA = "0x1826C0D10")]
		private void _OnStartBattle()
		{
		}

		// Token: 0x0602AF25 RID: 175909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF25")]
		[Address(RVA = "0x26BF880", Offset = "0x26BE480", VA = "0x1826BF880")]
		private AdvancedCharacterInst _ConvertToCharInst(ICommonSquadChar charViewModel)
		{
			return null;
		}

		// Token: 0x0602AF26 RID: 175910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF26")]
		[Address(RVA = "0x26C1A10", Offset = "0x26C0610", VA = "0x1826C1A10")]
		private void _TryRaiseAVGSignal()
		{
		}

		// Token: 0x0602AF27 RID: 175911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF27")]
		[Address(RVA = "0x26C1AB0", Offset = "0x26C06B0", VA = "0x1826C1AB0")]
		public Act1VHalfidlePlotSquadState()
		{
		}

		// Token: 0x0602AF28 RID: 175912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF28")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602AF29 RID: 175913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF29")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602AF2A RID: 175914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF2A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602AF2B RID: 175915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF2B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403DF5A RID: 253786
		[Token(Token = "0x403DF5A")]
		[NonSerialized]
		public const int MSG_ON_PLOT_SLOT_CLICKED = 0;

		// Token: 0x0403DF5B RID: 253787
		[Token(Token = "0x403DF5B")]
		[NonSerialized]
		public const int MSG_ON_START_BATTLE = 1;

		// Token: 0x0403DF5C RID: 253788
		[Token(Token = "0x403DF5C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PrefabInstHolder _topMenuPrefabHolder;

		// Token: 0x0403DF5D RID: 253789
		[Token(Token = "0x403DF5D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1VHalfidlePlotSquadView _view;

		// Token: 0x0403DF5E RID: 253790
		[Token(Token = "0x403DF5E")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x0403DF5F RID: 253791
		[Token(Token = "0x403DF5F")]
		[FieldOffset(Offset = "0x88")]
		private Act1VHalfIdlePlotSquadStateBean m_stateBean;

		// Token: 0x0403DF60 RID: 253792
		[Token(Token = "0x403DF60")]
		[FieldOffset(Offset = "0x90")]
		private string m_cacheActId;

		// Token: 0x0403DF61 RID: 253793
		[Token(Token = "0x403DF61")]
		[FieldOffset(Offset = "0x98")]
		private string m_cacheStageId;

		// Token: 0x0403DF62 RID: 253794
		[Token(Token = "0x403DF62")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cachedPlotId;

		// Token: 0x0403DF63 RID: 253795
		[Token(Token = "0x403DF63")]
		[FieldOffset(Offset = "0xA8")]
		private Act1VHalfIdlePlotType m_type;

		// Token: 0x0403DF64 RID: 253796
		[Token(Token = "0x403DF64")]
		[FieldOffset(Offset = "0xB0")]
		private CommonSquadSingleSquadViewModel m_cachedSquad;

		// Token: 0x0403DF65 RID: 253797
		[Token(Token = "0x403DF65")]
		[FieldOffset(Offset = "0xB8")]
		private List<AdvancedCharacterInst> m_advancedCharacterInsts;

		// Token: 0x0403DF66 RID: 253798
		[Token(Token = "0x403DF66")]
		[FieldOffset(Offset = "0xC0")]
		private BattleStartController.Param m_cachedBasicStartBattleParam;

		// Token: 0x0403DF67 RID: 253799
		[Token(Token = "0x403DF67")]
		[FieldOffset(Offset = "0x348")]
		private bool m_isInTutorial;

		// Token: 0x0403DF68 RID: 253800
		[Token(Token = "0x403DF68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DF69 RID: 253801
		[Token(Token = "0x403DF69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0403DF6A RID: 253802
		[Token(Token = "0x403DF6A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403DF6B RID: 253803
		[Token(Token = "0x403DF6B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403DF6C RID: 253804
		[Token(Token = "0x403DF6C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403DF6D RID: 253805
		[Token(Token = "0x403DF6D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403DF6E RID: 253806
		[Token(Token = "0x403DF6E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403DF6F RID: 253807
		[Token(Token = "0x403DF6F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpFromSquadState;

		// Token: 0x0403DF70 RID: 253808
		[Token(Token = "0x403DF70")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnJumpFromPlotSelectState;

		// Token: 0x0403DF71 RID: 253809
		[Token(Token = "0x403DF71")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RegisterToPlotSelectState;

		// Token: 0x0403DF72 RID: 253810
		[Token(Token = "0x403DF72")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnPlotClick;

		// Token: 0x0403DF73 RID: 253811
		[Token(Token = "0x403DF73")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnTopMenuCreated;

		// Token: 0x0403DF74 RID: 253812
		[Token(Token = "0x403DF74")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnBtnBackClicked;

		// Token: 0x0403DF75 RID: 253813
		[Token(Token = "0x403DF75")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnStartBattle;

		// Token: 0x0403DF76 RID: 253814
		[Token(Token = "0x403DF76")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ConvertToCharInst;

		// Token: 0x0403DF77 RID: 253815
		[Token(Token = "0x403DF77")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TryRaiseAVGSignal;

		// Token: 0x0403DF78 RID: 253816
		[Token(Token = "0x403DF78")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
