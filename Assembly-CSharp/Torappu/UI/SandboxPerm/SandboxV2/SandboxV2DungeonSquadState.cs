using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041ED RID: 16877
	[Token(Token = "0x20041ED")]
	public class SandboxV2DungeonSquadState : PopupFadeState, ISandboxV2SquadPanelContext, ICompDialogCallBack, IValueMsgReceiver
	{
		// Token: 0x0601A0A9 RID: 106665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0A9")]
		[Address(RVA = "0x12F3DD0", Offset = "0x12F29D0", VA = "0x1812F3DD0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A0AA RID: 106666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0AA")]
		[Address(RVA = "0x12F40E0", Offset = "0x12F2CE0", VA = "0x1812F40E0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601A0AB RID: 106667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0AB")]
		[Address(RVA = "0x12F5220", Offset = "0x12F3E20", VA = "0x1812F5220")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A0AC RID: 106668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0AC")]
		[Address(RVA = "0x12F4F30", Offset = "0x12F3B30", VA = "0x1812F4F30")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x0601A0AD RID: 106669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0AD")]
		[Address(RVA = "0x12F37E0", Offset = "0x12F23E0", VA = "0x1812F37E0")]
		public void EventOnBtnBack()
		{
		}

		// Token: 0x0601A0AE RID: 106670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0AE")]
		[Address(RVA = "0x12F3960", Offset = "0x12F2560", VA = "0x1812F3960", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A0AF RID: 106671 RVA: 0x000A0290 File Offset: 0x0009E490
		[Token(Token = "0x601A0AF")]
		[Address(RVA = "0x12F4AB0", Offset = "0x12F36B0", VA = "0x1812F4AB0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0601A0B0 RID: 106672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0B0")]
		[Address(RVA = "0x12F4630", Offset = "0x12F3230", VA = "0x1812F4630", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601A0B1 RID: 106673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0B1")]
		[Address(RVA = "0x12F4870", Offset = "0x12F3470", VA = "0x1812F4870", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601A0B2 RID: 106674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0B2")]
		[Address(RVA = "0x12F56B0", Offset = "0x12F42B0", VA = "0x1812F56B0")]
		private void _OnJumpFromToolSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601A0B3 RID: 106675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0B3")]
		[Address(RVA = "0x12F5A60", Offset = "0x12F4660", VA = "0x1812F5A60")]
		private void _OnJumpToToolSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601A0B4 RID: 106676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0B4")]
		[Address(RVA = "0x12F5450", Offset = "0x12F4050", VA = "0x1812F5450")]
		private void _OnJumpFromCharSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601A0B5 RID: 106677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0B5")]
		[Address(RVA = "0x12F5830", Offset = "0x12F4430", VA = "0x1812F5830")]
		private void _OnJumpToCharSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601A0B6 RID: 106678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0B6")]
		[Address(RVA = "0x12F5630", Offset = "0x12F4230", VA = "0x1812F5630")]
		private void _OnJumpFromDineState(IStateBean obj)
		{
		}

		// Token: 0x0601A0B7 RID: 106679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0B7")]
		[Address(RVA = "0x12F5970", Offset = "0x12F4570", VA = "0x1812F5970")]
		private void _OnJumpToDineState(IStateBean stateBean)
		{
		}

		// Token: 0x0601A0B8 RID: 106680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0B8")]
		[Address(RVA = "0x12F41B0", Offset = "0x12F2DB0", VA = "0x1812F41B0", Slot = "32")]
		public void OpenCharSelectState(SandboxV2AdminCharSelectStateBean.OpenOption option)
		{
		}

		// Token: 0x0601A0B9 RID: 106681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0B9")]
		[Address(RVA = "0x12F42E0", Offset = "0x12F2EE0", VA = "0x1812F42E0", Slot = "31")]
		public void OpenDineState(int charInstId)
		{
		}

		// Token: 0x0601A0BA RID: 106682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0BA")]
		[Address(RVA = "0x12F4380", Offset = "0x12F2F80", VA = "0x1812F4380", Slot = "33")]
		public void OpenToolSelectState(SandboxV2ToolSelectStateBean.Input toolSelectInput)
		{
		}

		// Token: 0x0601A0BB RID: 106683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0BB")]
		[Address(RVA = "0x12F3900", Offset = "0x12F2500", VA = "0x1812F3900", Slot = "35")]
		public DataBinder<SandboxV2SquadGroupProp> GetBinderView()
		{
			return null;
		}

		// Token: 0x0601A0BC RID: 106684 RVA: 0x000A02A8 File Offset: 0x0009E4A8
		[Token(Token = "0x601A0BC")]
		[Address(RVA = "0x12F3D30", Offset = "0x12F2930", VA = "0x1812F3D30", Slot = "36")]
		public bool IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601A0BD RID: 106685 RVA: 0x000A02C0 File Offset: 0x0009E4C0
		[Token(Token = "0x601A0BD")]
		[Address(RVA = "0x12F3CD0", Offset = "0x12F28D0", VA = "0x1812F3CD0", Slot = "37")]
		public bool IsRepoShow()
		{
			return default(bool);
		}

		// Token: 0x0601A0BE RID: 106686 RVA: 0x000A02D8 File Offset: 0x0009E4D8
		[Token(Token = "0x601A0BE")]
		[Address(RVA = "0x12F3C70", Offset = "0x12F2870", VA = "0x1812F3C70", Slot = "38")]
		public bool IsNaviPanelShow()
		{
			return default(bool);
		}

		// Token: 0x0601A0BF RID: 106687 RVA: 0x000A02F0 File Offset: 0x0009E4F0
		[Token(Token = "0x601A0BF")]
		[Address(RVA = "0x12F39C0", Offset = "0x12F25C0", VA = "0x1812F39C0", Slot = "39")]
		public SandboxV2SquadPanelShowMode GetPanelShowMode()
		{
			return SandboxV2SquadPanelShowMode.NORMAL;
		}

		// Token: 0x0601A0C0 RID: 106688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0C0")]
		[Address(RVA = "0x12F4460", Offset = "0x12F3060", VA = "0x1812F4460", Slot = "34")]
		public void OpenWorkbenchDialog(SandboxV2WorkbenchMakeDialog.Options options)
		{
		}

		// Token: 0x0601A0C1 RID: 106689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0C1")]
		[Address(RVA = "0x12F3A80", Offset = "0x12F2680", VA = "0x1812F3A80", Slot = "40")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601A0C2 RID: 106690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0C2")]
		[Address(RVA = "0x12F50D0", Offset = "0x12F3CD0", VA = "0x1812F50D0")]
		private void _HandleWorkbenchCallback(ValueBundle output)
		{
		}

		// Token: 0x0601A0C3 RID: 106691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0C3")]
		[Address(RVA = "0x12F3F70", Offset = "0x12F2B70", VA = "0x1812F3F70", Slot = "42")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601A0C4 RID: 106692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0C4")]
		[Address(RVA = "0x12F4B20", Offset = "0x12F3720", VA = "0x1812F4B20")]
		private void _EventOnBattleStart()
		{
		}

		// Token: 0x0601A0C5 RID: 106693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0C5")]
		[Address(RVA = "0x12F5010", Offset = "0x12F3C10", VA = "0x1812F5010")]
		private void _EventOnMakeDrink()
		{
		}

		// Token: 0x0601A0C6 RID: 106694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0C6")]
		[Address(RVA = "0x12F5B60", Offset = "0x12F4760", VA = "0x1812F5B60")]
		public SandboxV2DungeonSquadState()
		{
		}

		// Token: 0x0601A0C8 RID: 106696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0C8")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A0C9 RID: 106697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0C9")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601A0CA RID: 106698 RVA: 0x000A0308 File Offset: 0x0009E508
		[Token(Token = "0x601A0CA")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0601A0CB RID: 106699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0CB")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601A0CC RID: 106700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0CC")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04020CD1 RID: 134353
		[Token(Token = "0x4020CD1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2SquadGroupPanel _squadGroupPanelPrefab;

		// Token: 0x04020CD2 RID: 134354
		[Token(Token = "0x4020CD2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _charRepoContainer;

		// Token: 0x04020CD3 RID: 134355
		[Token(Token = "0x4020CD3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SandboxV2SquadStartBattleView _startBattleView;

		// Token: 0x04020CD4 RID: 134356
		[Token(Token = "0x4020CD4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04020CD5 RID: 134357
		[Token(Token = "0x4020CD5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textActionCost;

		// Token: 0x04020CD6 RID: 134358
		[Token(Token = "0x4020CD6")]
		[NonSerialized]
		public const int MSG_START_BATTLE = 1;

		// Token: 0x04020CD7 RID: 134359
		[Token(Token = "0x4020CD7")]
		[NonSerialized]
		public const int MSG_MAKE_DRINK = 2;

		// Token: 0x04020CD8 RID: 134360
		[Token(Token = "0x4020CD8")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x04020CD9 RID: 134361
		[Token(Token = "0x4020CD9")]
		[FieldOffset(Offset = "0xA0")]
		private string m_topicId;

		// Token: 0x04020CDA RID: 134362
		[Token(Token = "0x4020CDA")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2DungeonSquadStateBean m_stateBean;

		// Token: 0x04020CDB RID: 134363
		[Token(Token = "0x4020CDB")]
		[FieldOffset(Offset = "0xB0")]
		private SandboxV2SquadGroupPanel m_squadGroupPanel;

		// Token: 0x04020CDC RID: 134364
		[Token(Token = "0x4020CDC")]
		[FieldOffset(Offset = "0xB8")]
		private SandboxV2AdminCharSelectStateBean.OpenOption m_cachedOpenOption;

		// Token: 0x04020CDD RID: 134365
		[Token(Token = "0x4020CDD")]
		[FieldOffset(Offset = "0x110")]
		private int m_cachedDineCharInstId;

		// Token: 0x04020CDE RID: 134366
		[Token(Token = "0x4020CDE")]
		[FieldOffset(Offset = "0x118")]
		private SandboxV2ToolSelectStateBean.Input m_cachedToolSelectInput;

		// Token: 0x04020CDF RID: 134367
		[Token(Token = "0x4020CDF")]
		[FieldOffset(Offset = "0x148")]
		private int m_workbenchMakeDialogInst;

		// Token: 0x04020CE0 RID: 134368
		[Token(Token = "0x4020CE0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020CE1 RID: 134369
		[Token(Token = "0x4020CE1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04020CE2 RID: 134370
		[Token(Token = "0x4020CE2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020CE3 RID: 134371
		[Token(Token = "0x4020CE3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x04020CE4 RID: 134372
		[Token(Token = "0x4020CE4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBtnBack;

		// Token: 0x04020CE5 RID: 134373
		[Token(Token = "0x4020CE5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020CE6 RID: 134374
		[Token(Token = "0x4020CE6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04020CE7 RID: 134375
		[Token(Token = "0x4020CE7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04020CE8 RID: 134376
		[Token(Token = "0x4020CE8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04020CE9 RID: 134377
		[Token(Token = "0x4020CE9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnJumpFromToolSelectState;

		// Token: 0x04020CEA RID: 134378
		[Token(Token = "0x4020CEA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnJumpToToolSelectState;

		// Token: 0x04020CEB RID: 134379
		[Token(Token = "0x4020CEB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnJumpFromCharSelectState;

		// Token: 0x04020CEC RID: 134380
		[Token(Token = "0x4020CEC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnJumpToCharSelectState;

		// Token: 0x04020CED RID: 134381
		[Token(Token = "0x4020CED")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnJumpFromDineState;

		// Token: 0x04020CEE RID: 134382
		[Token(Token = "0x4020CEE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnJumpToDineState;

		// Token: 0x04020CEF RID: 134383
		[Token(Token = "0x4020CEF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OpenCharSelectState;

		// Token: 0x04020CF0 RID: 134384
		[Token(Token = "0x4020CF0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OpenDineState;

		// Token: 0x04020CF1 RID: 134385
		[Token(Token = "0x4020CF1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OpenToolSelectState;

		// Token: 0x04020CF2 RID: 134386
		[Token(Token = "0x4020CF2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetBinderView;

		// Token: 0x04020CF3 RID: 134387
		[Token(Token = "0x4020CF3")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_IsStateStable;

		// Token: 0x04020CF4 RID: 134388
		[Token(Token = "0x4020CF4")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_IsRepoShow;

		// Token: 0x04020CF5 RID: 134389
		[Token(Token = "0x4020CF5")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_IsNaviPanelShow;

		// Token: 0x04020CF6 RID: 134390
		[Token(Token = "0x4020CF6")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetPanelShowMode;

		// Token: 0x04020CF7 RID: 134391
		[Token(Token = "0x4020CF7")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OpenWorkbenchDialog;

		// Token: 0x04020CF8 RID: 134392
		[Token(Token = "0x4020CF8")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04020CF9 RID: 134393
		[Token(Token = "0x4020CF9")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__HandleWorkbenchCallback;

		// Token: 0x04020CFA RID: 134394
		[Token(Token = "0x4020CFA")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04020CFB RID: 134395
		[Token(Token = "0x4020CFB")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__EventOnBattleStart;

		// Token: 0x04020CFC RID: 134396
		[Token(Token = "0x4020CFC")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__EventOnMakeDrink;

		// Token: 0x04020CFD RID: 134397
		[Token(Token = "0x4020CFD")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
