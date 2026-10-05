using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E55 RID: 15957
	[Token(Token = "0x2003E55")]
	public class SpecialOperatorBoardState : PopupFadeState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x06018D0F RID: 101647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D0F")]
		[Address(RVA = "0x1172650", Offset = "0x1171250", VA = "0x181172650", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018D10 RID: 101648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D10")]
		[Address(RVA = "0x1173370", Offset = "0x1171F70", VA = "0x181173370")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018D11 RID: 101649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D11")]
		[Address(RVA = "0x1174ED0", Offset = "0x1173AD0", VA = "0x181174ED0")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x06018D12 RID: 101650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D12")]
		[Address(RVA = "0x11732C0", Offset = "0x1171EC0", VA = "0x1811732C0")]
		private void _GameAnalyticsRecordBoardTabType(SpecialOperatorBoardMainModel model)
		{
		}

		// Token: 0x06018D13 RID: 101651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D13")]
		[Address(RVA = "0x11727C0", Offset = "0x11713C0", VA = "0x1811727C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018D14 RID: 101652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D14")]
		[Address(RVA = "0x1173070", Offset = "0x1171C70", VA = "0x181173070", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06018D15 RID: 101653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D15")]
		[Address(RVA = "0x1173100", Offset = "0x1171D00", VA = "0x181173100", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06018D16 RID: 101654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D16")]
		[Address(RVA = "0x1173260", Offset = "0x1171E60", VA = "0x181173260")]
		public LatchUtils.InvokeWhenUnlock TriggerGuideBook()
		{
			return null;
		}

		// Token: 0x06018D17 RID: 101655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D17")]
		[Address(RVA = "0x1175940", Offset = "0x1174540", VA = "0x181175940")]
		private void _TryTriggerGuideBook()
		{
		}

		// Token: 0x06018D18 RID: 101656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D18")]
		[Address(RVA = "0x1175440", Offset = "0x1174040", VA = "0x181175440")]
		private void _TriggerGuideBook()
		{
		}

		// Token: 0x06018D19 RID: 101657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D19")]
		[Address(RVA = "0x1172910", Offset = "0x1171510", VA = "0x181172910", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06018D1A RID: 101658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D1A")]
		[Address(RVA = "0x1174AC0", Offset = "0x11736C0", VA = "0x181174AC0")]
		private void _OnTabSelected(SpecialOperatorBoardTabType tabType)
		{
		}

		// Token: 0x06018D1B RID: 101659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D1B")]
		[Address(RVA = "0x1173F70", Offset = "0x1172B70", VA = "0x181173F70")]
		private void _OnLvlupSubTabSelected(SpecialOperatorDetailNodeType lvlupTabType)
		{
		}

		// Token: 0x06018D1C RID: 101660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D1C")]
		[Address(RVA = "0x1173CA0", Offset = "0x11728A0", VA = "0x181173CA0")]
		private void _OnLvlupEvolveCursorClick()
		{
		}

		// Token: 0x06018D1D RID: 101661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D1D")]
		[Address(RVA = "0x1173ED0", Offset = "0x1172AD0", VA = "0x181173ED0")]
		private void _OnLvlupNodeClick(ValueBundle msg)
		{
		}

		// Token: 0x06018D1E RID: 101662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D1E")]
		[Address(RVA = "0x1173E20", Offset = "0x1172A20", VA = "0x181173E20")]
		private void _OnLvlupNodeCancel()
		{
		}

		// Token: 0x06018D1F RID: 101663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D1F")]
		[Address(RVA = "0x11740B0", Offset = "0x1172CB0", VA = "0x1811740B0")]
		private void _OnNodeUnlockConfirm()
		{
		}

		// Token: 0x06018D20 RID: 101664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D20")]
		[Address(RVA = "0x1173620", Offset = "0x1172220", VA = "0x181173620")]
		private void _OnCharInfoNav()
		{
		}

		// Token: 0x06018D21 RID: 101665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D21")]
		[Address(RVA = "0x11750E0", Offset = "0x1173CE0", VA = "0x1811750E0")]
		private void _RefreshData()
		{
		}

		// Token: 0x06018D22 RID: 101666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D22")]
		[Address(RVA = "0x1174390", Offset = "0x1172F90", VA = "0x181174390")]
		private void _OnNodeUnlockResponse(SpecialOperatorDetailNodeType nodeType)
		{
		}

		// Token: 0x06018D23 RID: 101667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D23")]
		[Address(RVA = "0x1174440", Offset = "0x1173040", VA = "0x181174440")]
		private void _OnNodeUnlockResponse()
		{
		}

		// Token: 0x06018D24 RID: 101668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D24")]
		[Address(RVA = "0x1174FD0", Offset = "0x1173BD0", VA = "0x181174FD0")]
		private void _PlayUnlockTipAnim()
		{
		}

		// Token: 0x06018D25 RID: 101669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D25")]
		[Address(RVA = "0x1174640", Offset = "0x1173240", VA = "0x181174640")]
		private void _OnSkillNodeUnlockResponse()
		{
		}

		// Token: 0x06018D26 RID: 101670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D26")]
		[Address(RVA = "0x1174C20", Offset = "0x1173820", VA = "0x181174C20")]
		private void _OnUniEquipNodeUnlockResponse()
		{
		}

		// Token: 0x06018D27 RID: 101671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D27")]
		[Address(RVA = "0x1173890", Offset = "0x1172490", VA = "0x181173890")]
		private void _OnEvolveConfirm()
		{
		}

		// Token: 0x06018D28 RID: 101672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D28")]
		[Address(RVA = "0x11751A0", Offset = "0x1173DA0", VA = "0x1811751A0")]
		private static void _SendNodeUnlockRequest(string instId, string nodeId, Action onConfirm)
		{
		}

		// Token: 0x06018D29 RID: 101673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D29")]
		[Address(RVA = "0x1175870", Offset = "0x1174470", VA = "0x181175870")]
		private void _TrySelectedNode(string nodeId)
		{
		}

		// Token: 0x06018D2A RID: 101674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D2A")]
		[Address(RVA = "0x11726B0", Offset = "0x11712B0", VA = "0x1811726B0", Slot = "32")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06018D2B RID: 101675 RVA: 0x0009C138 File Offset: 0x0009A338
		[Token(Token = "0x6018D2B")]
		[Address(RVA = "0x11754C0", Offset = "0x11740C0", VA = "0x1811754C0")]
		private bool _TryOpenUniEquipUnlockDialog()
		{
			return default(bool);
		}

		// Token: 0x06018D2C RID: 101676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D2C")]
		[Address(RVA = "0x1173820", Offset = "0x1172420", VA = "0x181173820")]
		private void _OnConfirmEquipUnlockDialog()
		{
		}

		// Token: 0x06018D2D RID: 101677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D2D")]
		[Address(RVA = "0x1175A60", Offset = "0x1174660", VA = "0x181175A60")]
		public SpecialOperatorBoardState()
		{
		}

		// Token: 0x06018D2E RID: 101678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D2E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06018D2F RID: 101679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D2F")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06018D30 RID: 101680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D30")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0401E81F RID: 124959
		[Token(Token = "0x401E81F")]
		private const string GUIDE_SUB_SIGNAL = "board";

		// Token: 0x0401E820 RID: 124960
		[Token(Token = "0x401E820")]
		[NonSerialized]
		public const int ON_TAB_SELECTED = 1;

		// Token: 0x0401E821 RID: 124961
		[Token(Token = "0x401E821")]
		[NonSerialized]
		public const int ON_LVLUP_SUB_TAB_SELECTED = 2;

		// Token: 0x0401E822 RID: 124962
		[Token(Token = "0x401E822")]
		[NonSerialized]
		public const int ON_LVLUP_EVOLVE_CURSOR_CLICK = 3;

		// Token: 0x0401E823 RID: 124963
		[Token(Token = "0x401E823")]
		[NonSerialized]
		public const int ON_LVLUP_NODE_CLICK = 4;

		// Token: 0x0401E824 RID: 124964
		[Token(Token = "0x401E824")]
		[NonSerialized]
		public const int ON_LVLUP_NODE_CANCEL = 5;

		// Token: 0x0401E825 RID: 124965
		[Token(Token = "0x401E825")]
		[NonSerialized]
		public const int ON_EVOLVE_CONFIRM = 6;

		// Token: 0x0401E826 RID: 124966
		[Token(Token = "0x401E826")]
		[NonSerialized]
		public const int ON_NODE_UNLOCK_CONFIRM = 7;

		// Token: 0x0401E827 RID: 124967
		[Token(Token = "0x401E827")]
		[NonSerialized]
		public const int ON_CHAR_INFO_NAV = 8;

		// Token: 0x0401E828 RID: 124968
		[Token(Token = "0x401E828")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SpecialOperatorBoardSideBar _sideBar;

		// Token: 0x0401E829 RID: 124969
		[Token(Token = "0x401E829")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SpecialOperatorBoardContentViewContainer _contentContainer;

		// Token: 0x0401E82A RID: 124970
		[Token(Token = "0x401E82A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SpecialOperatorDiagramView _diagramViewPrefab;

		// Token: 0x0401E82B RID: 124971
		[Token(Token = "0x401E82B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _diagramContainer;

		// Token: 0x0401E82C RID: 124972
		[Token(Token = "0x401E82C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _unlockTipAnim;

		// Token: 0x0401E82D RID: 124973
		[Token(Token = "0x401E82D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0401E82E RID: 124974
		[Token(Token = "0x401E82E")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x0401E82F RID: 124975
		[Token(Token = "0x401E82F")]
		[FieldOffset(Offset = "0xB8")]
		private SpecialOperatorDiagramView m_diagramView;

		// Token: 0x0401E830 RID: 124976
		[Token(Token = "0x401E830")]
		[FieldOffset(Offset = "0xC0")]
		private int m_equipUnlockDlgInst;

		// Token: 0x0401E831 RID: 124977
		[Token(Token = "0x401E831")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_unlockTipTween;

		// Token: 0x0401E832 RID: 124978
		[Token(Token = "0x401E832")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_enterTween;

		// Token: 0x0401E833 RID: 124979
		[Token(Token = "0x401E833")]
		[FieldOffset(Offset = "0xD8")]
		private LatchUtils.InvokeWhenUnlock m_trigGuideBook;

		// Token: 0x0401E834 RID: 124980
		[Token(Token = "0x401E834")]
		[FieldOffset(Offset = "0xE0")]
		private SpecialOperatorBoardProp m_prop;

		// Token: 0x0401E835 RID: 124981
		[Token(Token = "0x401E835")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401E836 RID: 124982
		[Token(Token = "0x401E836")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E837 RID: 124983
		[Token(Token = "0x401E837")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x0401E838 RID: 124984
		[Token(Token = "0x401E838")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GameAnalyticsRecordBoardTabType;

		// Token: 0x0401E839 RID: 124985
		[Token(Token = "0x401E839")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401E83A RID: 124986
		[Token(Token = "0x401E83A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0401E83B RID: 124987
		[Token(Token = "0x401E83B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401E83C RID: 124988
		[Token(Token = "0x401E83C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TriggerGuideBook;

		// Token: 0x0401E83D RID: 124989
		[Token(Token = "0x401E83D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryTriggerGuideBook;

		// Token: 0x0401E83E RID: 124990
		[Token(Token = "0x401E83E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TriggerGuideBook;

		// Token: 0x0401E83F RID: 124991
		[Token(Token = "0x401E83F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401E840 RID: 124992
		[Token(Token = "0x401E840")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnTabSelected;

		// Token: 0x0401E841 RID: 124993
		[Token(Token = "0x401E841")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnLvlupSubTabSelected;

		// Token: 0x0401E842 RID: 124994
		[Token(Token = "0x401E842")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnLvlupEvolveCursorClick;

		// Token: 0x0401E843 RID: 124995
		[Token(Token = "0x401E843")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnLvlupNodeClick;

		// Token: 0x0401E844 RID: 124996
		[Token(Token = "0x401E844")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnLvlupNodeCancel;

		// Token: 0x0401E845 RID: 124997
		[Token(Token = "0x401E845")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnNodeUnlockConfirm;

		// Token: 0x0401E846 RID: 124998
		[Token(Token = "0x401E846")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnCharInfoNav;

		// Token: 0x0401E847 RID: 124999
		[Token(Token = "0x401E847")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x0401E848 RID: 125000
		[Token(Token = "0x401E848")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnNodeUnlockResponse;

		// Token: 0x0401E849 RID: 125001
		[Token(Token = "0x401E849")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix1__OnNodeUnlockResponse;

		// Token: 0x0401E84A RID: 125002
		[Token(Token = "0x401E84A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__PlayUnlockTipAnim;

		// Token: 0x0401E84B RID: 125003
		[Token(Token = "0x401E84B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnSkillNodeUnlockResponse;

		// Token: 0x0401E84C RID: 125004
		[Token(Token = "0x401E84C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnUniEquipNodeUnlockResponse;

		// Token: 0x0401E84D RID: 125005
		[Token(Token = "0x401E84D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnEvolveConfirm;

		// Token: 0x0401E84E RID: 125006
		[Token(Token = "0x401E84E")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__SendNodeUnlockRequest;

		// Token: 0x0401E84F RID: 125007
		[Token(Token = "0x401E84F")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__TrySelectedNode;

		// Token: 0x0401E850 RID: 125008
		[Token(Token = "0x401E850")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0401E851 RID: 125009
		[Token(Token = "0x401E851")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__TryOpenUniEquipUnlockDialog;

		// Token: 0x0401E852 RID: 125010
		[Token(Token = "0x401E852")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnConfirmEquipUnlockDialog;

		// Token: 0x0401E853 RID: 125011
		[Token(Token = "0x401E853")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
