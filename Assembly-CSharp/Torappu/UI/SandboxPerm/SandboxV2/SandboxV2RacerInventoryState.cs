using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200435D RID: 17245
	[Token(Token = "0x200435D")]
	public class SandboxV2RacerInventoryState : SandboxV2RacerInventoryBaseState, IHotfixable
	{
		// Token: 0x0601A773 RID: 108403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A773")]
		[Address(RVA = "0x13907E0", Offset = "0x138F3E0", VA = "0x1813907E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A774 RID: 108404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A774")]
		[Address(RVA = "0x13911E0", Offset = "0x138FDE0", VA = "0x1813911E0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601A775 RID: 108405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A775")]
		[Address(RVA = "0x1390780", Offset = "0x138F380", VA = "0x181390780", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A776 RID: 108406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A776")]
		[Address(RVA = "0x13912D0", Offset = "0x138FED0", VA = "0x1813912D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601A777 RID: 108407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A777")]
		[Address(RVA = "0x1393120", Offset = "0x1391D20", VA = "0x181393120")]
		private void _OnJumpToTempInventory(IStateBean obj)
		{
		}

		// Token: 0x0601A778 RID: 108408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A778")]
		[Address(RVA = "0x1390D30", Offset = "0x138F930", VA = "0x181390D30", Slot = "32")]
		public override void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601A779 RID: 108409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A779")]
		[Address(RVA = "0x1391430", Offset = "0x1390030", VA = "0x181391430")]
		private void _EventOnBackBtnClicked()
		{
		}

		// Token: 0x0601A77A RID: 108410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A77A")]
		[Address(RVA = "0x1391900", Offset = "0x1390500", VA = "0x181391900")]
		private void _EventOnRacerCardClicked(string instId)
		{
		}

		// Token: 0x0601A77B RID: 108411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A77B")]
		[Address(RVA = "0x1391A40", Offset = "0x1390640", VA = "0x181391A40")]
		private void _EventOnRacerMarkClicked()
		{
		}

		// Token: 0x0601A77C RID: 108412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A77C")]
		[Address(RVA = "0x1392250", Offset = "0x1390E50", VA = "0x181392250")]
		private void _EventOnReleaseClicked()
		{
		}

		// Token: 0x0601A77D RID: 108413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A77D")]
		[Address(RVA = "0x1391D20", Offset = "0x1390920", VA = "0x181391D20")]
		private void _EventOnRefreshTalentClicked()
		{
		}

		// Token: 0x0601A77E RID: 108414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A77E")]
		[Address(RVA = "0x13925E0", Offset = "0x13911E0", VA = "0x1813925E0")]
		private void _EventOnStartBattleClicked()
		{
		}

		// Token: 0x0601A77F RID: 108415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A77F")]
		[Address(RVA = "0x1391810", Offset = "0x1390410", VA = "0x181391810")]
		private void _EventOnOpenTempBagClicked()
		{
		}

		// Token: 0x0601A780 RID: 108416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A780")]
		[Address(RVA = "0x1391530", Offset = "0x1390130", VA = "0x181391530")]
		private void _EventOnMedalGroupClicked()
		{
		}

		// Token: 0x0601A781 RID: 108417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A781")]
		[Address(RVA = "0x1393010", Offset = "0x1391C10", VA = "0x181393010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A782 RID: 108418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A782")]
		[Address(RVA = "0x1392EC0", Offset = "0x1391AC0", VA = "0x181392EC0")]
		private void _HandleSaveMarkProceed(SandboxV2RacingSaveMarkResponse response)
		{
		}

		// Token: 0x0601A783 RID: 108419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A783")]
		[Address(RVA = "0x1393230", Offset = "0x1391E30", VA = "0x181393230")]
		private void _RefreshTalent(string instId)
		{
		}

		// Token: 0x0601A784 RID: 108420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A784")]
		[Address(RVA = "0x1393500", Offset = "0x1392100", VA = "0x181393500")]
		private void _ReleaseRacer(string instId)
		{
		}

		// Token: 0x0601A785 RID: 108421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A785")]
		[Address(RVA = "0x1392CC0", Offset = "0x13918C0", VA = "0x181392CC0")]
		private void _HandleReleaseProceed(SandboxV2RacingReleaseResponse response)
		{
		}

		// Token: 0x0601A786 RID: 108422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A786")]
		[Address(RVA = "0x1392A70", Offset = "0x1391670", VA = "0x181392A70")]
		private void _HandleRefreshTalentProceed(SandboxV2RacingLearnTalentResponse response)
		{
		}

		// Token: 0x0601A787 RID: 108423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A787")]
		[Address(RVA = "0x1393820", Offset = "0x1392420", VA = "0x181393820")]
		public SandboxV2RacerInventoryState()
		{
		}

		// Token: 0x0601A788 RID: 108424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A788")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A789 RID: 108425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A789")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601A78A RID: 108426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A78A")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04021AC6 RID: 137926
		[Token(Token = "0x4021AC6")]
		[NonSerialized]
		public const int DEFAULT_FOCUS_SEQUENCE_NUM = 0;

		// Token: 0x04021AC7 RID: 137927
		[Token(Token = "0x4021AC7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2RacerInventoryTopView _topView;

		// Token: 0x04021AC8 RID: 137928
		[Token(Token = "0x4021AC8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SandboxV2RacerInventoryListView _listView;

		// Token: 0x04021AC9 RID: 137929
		[Token(Token = "0x4021AC9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SandboxV2RacerInventoryInfoView _infoView;

		// Token: 0x04021ACA RID: 137930
		[Token(Token = "0x4021ACA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Sprite _imgReleaseIcon;

		// Token: 0x04021ACB RID: 137931
		[Token(Token = "0x4021ACB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Sprite _imgRefreshTalentIcon;

		// Token: 0x04021ACC RID: 137932
		[Token(Token = "0x4021ACC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SandboxV2RacerInventoryRefreshTalentDeco _talentDialogDecoPrefab;

		// Token: 0x04021ACD RID: 137933
		[Token(Token = "0x4021ACD")]
		[FieldOffset(Offset = "0xA0")]
		private SandboxV2RacerInventoryStateBean m_stateBean;

		// Token: 0x04021ACE RID: 137934
		[Token(Token = "0x4021ACE")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x04021ACF RID: 137935
		[Token(Token = "0x4021ACF")]
		[FieldOffset(Offset = "0xAC")]
		private int m_dialogInstId;

		// Token: 0x04021AD0 RID: 137936
		[Token(Token = "0x4021AD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04021AD1 RID: 137937
		[Token(Token = "0x4021AD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04021AD2 RID: 137938
		[Token(Token = "0x4021AD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04021AD3 RID: 137939
		[Token(Token = "0x4021AD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04021AD4 RID: 137940
		[Token(Token = "0x4021AD4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToTempInventory;

		// Token: 0x04021AD5 RID: 137941
		[Token(Token = "0x4021AD5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04021AD6 RID: 137942
		[Token(Token = "0x4021AD6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnBackBtnClicked;

		// Token: 0x04021AD7 RID: 137943
		[Token(Token = "0x4021AD7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnRacerCardClicked;

		// Token: 0x04021AD8 RID: 137944
		[Token(Token = "0x4021AD8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnRacerMarkClicked;

		// Token: 0x04021AD9 RID: 137945
		[Token(Token = "0x4021AD9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnReleaseClicked;

		// Token: 0x04021ADA RID: 137946
		[Token(Token = "0x4021ADA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnRefreshTalentClicked;

		// Token: 0x04021ADB RID: 137947
		[Token(Token = "0x4021ADB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnStartBattleClicked;

		// Token: 0x04021ADC RID: 137948
		[Token(Token = "0x4021ADC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnOpenTempBagClicked;

		// Token: 0x04021ADD RID: 137949
		[Token(Token = "0x4021ADD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnMedalGroupClicked;

		// Token: 0x04021ADE RID: 137950
		[Token(Token = "0x4021ADE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021ADF RID: 137951
		[Token(Token = "0x4021ADF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HandleSaveMarkProceed;

		// Token: 0x04021AE0 RID: 137952
		[Token(Token = "0x4021AE0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RefreshTalent;

		// Token: 0x04021AE1 RID: 137953
		[Token(Token = "0x4021AE1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ReleaseRacer;

		// Token: 0x04021AE2 RID: 137954
		[Token(Token = "0x4021AE2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleReleaseProceed;

		// Token: 0x04021AE3 RID: 137955
		[Token(Token = "0x4021AE3")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandleRefreshTalentProceed;

		// Token: 0x04021AE4 RID: 137956
		[Token(Token = "0x4021AE4")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
