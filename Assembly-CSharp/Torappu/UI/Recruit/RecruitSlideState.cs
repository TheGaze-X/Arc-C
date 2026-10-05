using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x020046F0 RID: 18160
	[Token(Token = "0x20046F0")]
	public class RecruitSlideState : State
	{
		// Token: 0x0601B889 RID: 112777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B889")]
		[Address(RVA = "0x14E3B10", Offset = "0x14E2710", VA = "0x1814E3B10", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601B88A RID: 112778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B88A")]
		[Address(RVA = "0x14E3DA0", Offset = "0x14E29A0", VA = "0x1814E3DA0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601B88B RID: 112779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B88B")]
		[Address(RVA = "0x14E3D20", Offset = "0x14E2920", VA = "0x1814E3D20", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601B88C RID: 112780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B88C")]
		[Address(RVA = "0x14E31A0", Offset = "0x14E1DA0", VA = "0x1814E31A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601B88D RID: 112781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B88D")]
		[Address(RVA = "0x14E4490", Offset = "0x14E3090", VA = "0x1814E4490")]
		public void SwitchPage(bool toNormalGacha)
		{
		}

		// Token: 0x0601B88E RID: 112782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B88E")]
		[Address(RVA = "0x14E1E90", Offset = "0x14E0A90", VA = "0x1814E1E90")]
		public void EventOnBuildingTimeUp(int slotIndex)
		{
		}

		// Token: 0x0601B88F RID: 112783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B88F")]
		[Address(RVA = "0x14E2DE0", Offset = "0x14E19E0", VA = "0x1814E2DE0")]
		public void EventOnStartBuildClick(int slotIndex)
		{
		}

		// Token: 0x0601B890 RID: 112784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B890")]
		[Address(RVA = "0x14E2C90", Offset = "0x14E1890", VA = "0x1814E2C90")]
		public void EventOnLockedSlotClick(int slotIndex)
		{
		}

		// Token: 0x0601B891 RID: 112785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B891")]
		[Address(RVA = "0x14E2080", Offset = "0x14E0C80", VA = "0x1814E2080")]
		public void EventOnFastFinishClick(int slotIndex)
		{
		}

		// Token: 0x0601B892 RID: 112786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B892")]
		[Address(RVA = "0x14E1F00", Offset = "0x14E0B00", VA = "0x1814E1F00")]
		public void EventOnBuySlot(int slotIndex)
		{
		}

		// Token: 0x0601B893 RID: 112787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B893")]
		[Address(RVA = "0x14E2980", Offset = "0x14E1580", VA = "0x1814E2980")]
		public void EventOnInterruptBuildClick(int slotIndex)
		{
		}

		// Token: 0x0601B894 RID: 112788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B894")]
		[Address(RVA = "0x14E21F0", Offset = "0x14E0DF0", VA = "0x1814E21F0")]
		public void EventOnFinishBuildClick(int slotIndex)
		{
		}

		// Token: 0x0601B895 RID: 112789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B895")]
		[Address(RVA = "0x14E37F0", Offset = "0x14E23F0", VA = "0x1814E37F0")]
		public void OnConfirmFastFinish(int slotId)
		{
		}

		// Token: 0x0601B896 RID: 112790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B896")]
		[Address(RVA = "0x14E34F0", Offset = "0x14E20F0", VA = "0x1814E34F0")]
		[Obsolete]
		public void OnBuyFastFinish(int slotId)
		{
		}

		// Token: 0x0601B897 RID: 112791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B897")]
		[Address(RVA = "0x14E3200", Offset = "0x14E1E00", VA = "0x1814E3200")]
		public void OnBuyFastDiamondShardFinish(int slotId)
		{
		}

		// Token: 0x0601B898 RID: 112792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B898")]
		[Address(RVA = "0x14E3EF0", Offset = "0x14E2AF0", VA = "0x1814E3EF0")]
		public void OpenDetail(string gachaPoolId, bool needScroll)
		{
		}

		// Token: 0x0601B899 RID: 112793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B899")]
		[Address(RVA = "0x14E5290", Offset = "0x14E3E90", VA = "0x1814E5290")]
		private void _OnConfirmStopBuild()
		{
		}

		// Token: 0x0601B89A RID: 112794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B89A")]
		[Address(RVA = "0x14E7120", Offset = "0x14E5D20", VA = "0x1814E7120")]
		private void _SyncBuildStatusProceedCallback(SyncNormalGachaResponse response)
		{
		}

		// Token: 0x0601B89B RID: 112795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B89B")]
		[Address(RVA = "0x14E7090", Offset = "0x14E5C90", VA = "0x1814E7090")]
		private void _SyncBuildStatusFinalCallback()
		{
		}

		// Token: 0x0601B89C RID: 112796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B89C")]
		[Address(RVA = "0x14E6280", Offset = "0x14E4E80", VA = "0x1814E6280")]
		private void _SendBuySlotService(string index)
		{
		}

		// Token: 0x0601B89D RID: 112797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B89D")]
		[Address(RVA = "0x14E5950", Offset = "0x14E4550", VA = "0x1814E5950")]
		private void _OnGiveDataToDetialState(IStateBean rawBean)
		{
		}

		// Token: 0x0601B89E RID: 112798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B89E")]
		[Address(RVA = "0x14E57B0", Offset = "0x14E43B0", VA = "0x1814E57B0")]
		private void _OnGiveDataToBuildConfigState(IStateBean rawBean)
		{
		}

		// Token: 0x0601B89F RID: 112799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B89F")]
		[Address(RVA = "0x14E5B50", Offset = "0x14E4750", VA = "0x1814E5B50")]
		private void _OnReceiveDataFromBuildConfigState(IStateBean rawBean)
		{
		}

		// Token: 0x0601B8A0 RID: 112800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B8A0")]
		[Address(RVA = "0x14E4250", Offset = "0x14E2E50", VA = "0x1814E4250", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601B8A1 RID: 112801 RVA: 0x000A5738 File Offset: 0x000A3938
		[Token(Token = "0x601B8A1")]
		[Address(RVA = "0x14E4C20", Offset = "0x14E3820", VA = "0x1814E4C20", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0601B8A2 RID: 112802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B8A2")]
		[Address(RVA = "0x14E40E0", Offset = "0x14E2CE0", VA = "0x1814E40E0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601B8A3 RID: 112803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8A3")]
		[Address(RVA = "0x14E5110", Offset = "0x14E3D10", VA = "0x1814E5110")]
		private void _InitIfNot(RecruitPage.Param pageParam)
		{
		}

		// Token: 0x0601B8A4 RID: 112804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8A4")]
		[Address(RVA = "0x14E6A00", Offset = "0x14E5600", VA = "0x1814E6A00")]
		private void _SendSyncBuildDataService()
		{
		}

		// Token: 0x0601B8A5 RID: 112805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8A5")]
		[Address(RVA = "0x14E4C90", Offset = "0x14E3890", VA = "0x1814E4C90")]
		private void _EventOnGacha(string inputPoolId, RecruitDataConverter.SingleGachaPolicy policy)
		{
		}

		// Token: 0x0601B8A6 RID: 112806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8A6")]
		[Address(RVA = "0x14E4E50", Offset = "0x14E3A50", VA = "0x1814E4E50")]
		private void _EventOnLimitGacha(string inputPoolId)
		{
		}

		// Token: 0x0601B8A7 RID: 112807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8A7")]
		[Address(RVA = "0x14E64C0", Offset = "0x14E50C0", VA = "0x1814E64C0")]
		private void _SendGachaReq(string inputPoolId, GachaType gType, [Optional] string itemId)
		{
		}

		// Token: 0x0601B8A8 RID: 112808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8A8")]
		[Address(RVA = "0x14E24A0", Offset = "0x14E10A0", VA = "0x1814E24A0")]
		public void EventOnGachaBtnClick(string inputPoolId)
		{
		}

		// Token: 0x0601B8A9 RID: 112809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8A9")]
		[Address(RVA = "0x14E4F30", Offset = "0x14E3B30", VA = "0x1814E4F30")]
		private void _EventOnTenGacha(string inputPoolId, RecruitDataConverter.TenGachaPolicy policy)
		{
		}

		// Token: 0x0601B8AA RID: 112810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8AA")]
		[Address(RVA = "0x14E2E90", Offset = "0x14E1A90", VA = "0x1814E2E90")]
		public void EventOnTenGachaBtnClick(string inputPoolId)
		{
		}

		// Token: 0x0601B8AB RID: 112811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8AB")]
		[Address(RVA = "0x14E6DF0", Offset = "0x14E59F0", VA = "0x1814E6DF0")]
		private void _SendTenGachaReq(string inputPoolId, GachaType gType, List<CombineGachaItem> itemList)
		{
		}

		// Token: 0x0601B8AC RID: 112812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8AC")]
		[Address(RVA = "0x14E2D50", Offset = "0x14E1950", VA = "0x1814E2D50")]
		public void EventOnRecruitFreeClick(string inputPoolId)
		{
		}

		// Token: 0x0601B8AD RID: 112813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8AD")]
		[Address(RVA = "0x14E6700", Offset = "0x14E5300", VA = "0x1814E6700")]
		private void _SendRecruitFreeCharReq(string inputPoolId)
		{
		}

		// Token: 0x0601B8AE RID: 112814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8AE")]
		[Address(RVA = "0x14E5CF0", Offset = "0x14E48F0", VA = "0x1814E5CF0")]
		private void _OnSingleAdvGachaSuc(AdvancedGachaResponse response)
		{
		}

		// Token: 0x0601B8AF RID: 112815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8AF")]
		[Address(RVA = "0x14E5E50", Offset = "0x14E4A50", VA = "0x1814E5E50")]
		private void _OnTenAdvGachaSuc(TenAdvancedGachaResponse response)
		{
		}

		// Token: 0x0601B8B0 RID: 112816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8B0")]
		[Address(RVA = "0x14E5490", Offset = "0x14E4090", VA = "0x1814E5490")]
		private void _OnGachaPoolBanned()
		{
		}

		// Token: 0x0601B8B1 RID: 112817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8B1")]
		[Address(RVA = "0x14E5520", Offset = "0x14E4120", VA = "0x1814E5520")]
		private void _OnGetCharacter(GachaResult gachaResult, bool isAdvanced, bool isSkippable)
		{
		}

		// Token: 0x0601B8B2 RID: 112818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8B2")]
		[Address(RVA = "0x14E5630", Offset = "0x14E4230", VA = "0x1814E5630")]
		private void _OnGetCharacters(GachaResult[] gachaResultList, bool isAdvanced, bool isSkippable)
		{
		}

		// Token: 0x0601B8B3 RID: 112819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8B3")]
		[Address(RVA = "0x14E6190", Offset = "0x14E4D90", VA = "0x1814E6190")]
		private void _PushGachaResultToGameAnalytics(GachaResult gachaResult, bool isAdvanced)
		{
		}

		// Token: 0x0601B8B4 RID: 112820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8B4")]
		[Address(RVA = "0x14E71A0", Offset = "0x14E5DA0", VA = "0x1814E71A0")]
		public RecruitSlideState()
		{
		}

		// Token: 0x0601B8BD RID: 112829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8BD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601B8BE RID: 112830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8BE")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601B8BF RID: 112831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8BF")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601B8C0 RID: 112832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B8C0")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601B8C1 RID: 112833 RVA: 0x000A5750 File Offset: 0x000A3950
		[Token(Token = "0x601B8C1")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0601B8C2 RID: 112834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B8C2")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04023AB7 RID: 146103
		[Token(Token = "0x4023AB7")]
		private const string SCROLL_INDEX = "scrollIndex";

		// Token: 0x04023AB8 RID: 146104
		[Token(Token = "0x4023AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RecruitStateBean _stateBean;

		// Token: 0x04023AB9 RID: 146105
		[Token(Token = "0x4023AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RecruitGachaView _gachaView;

		// Token: 0x04023ABA RID: 146106
		[Token(Token = "0x4023ABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RecruitBuildTopBarView _topBarView;

		// Token: 0x04023ABB RID: 146107
		[Token(Token = "0x4023ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RefCountReference m_buildingRef;

		// Token: 0x04023ABC RID: 146108
		[Token(Token = "0x4023ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x04023ABD RID: 146109
		[Token(Token = "0x4023ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RecruitPage m_page;

		// Token: 0x04023ABE RID: 146110
		[Token(Token = "0x4023ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private UISender.ResultHandler<SyncNormalGachaResponse> m_syncBuildStateHandler;

		// Token: 0x04023ABF RID: 146111
		[Token(Token = "0x4023ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_havePendingRequest;

		// Token: 0x04023AC0 RID: 146112
		[Token(Token = "0x4023AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int m_startBuildSlotCache;

		// Token: 0x04023AC1 RID: 146113
		[Token(Token = "0x4023AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int m_fastFinishSlotCache;

		// Token: 0x04023AC2 RID: 146114
		[Token(Token = "0x4023AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int m_stopBuildSlotCache;

		// Token: 0x04023AC3 RID: 146115
		[Token(Token = "0x4023AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int m_getResultSlostCache;

		// Token: 0x04023AC4 RID: 146116
		[Token(Token = "0x4023AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04023AC5 RID: 146117
		[Token(Token = "0x4023AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04023AC6 RID: 146118
		[Token(Token = "0x4023AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04023AC7 RID: 146119
		[Token(Token = "0x4023AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04023AC8 RID: 146120
		[Token(Token = "0x4023AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SwitchPage;

		// Token: 0x04023AC9 RID: 146121
		[Token(Token = "0x4023AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBuildingTimeUp;

		// Token: 0x04023ACA RID: 146122
		[Token(Token = "0x4023ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnStartBuildClick;

		// Token: 0x04023ACB RID: 146123
		[Token(Token = "0x4023ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnLockedSlotClick;

		// Token: 0x04023ACC RID: 146124
		[Token(Token = "0x4023ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnFastFinishClick;

		// Token: 0x04023ACD RID: 146125
		[Token(Token = "0x4023ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBuySlot;

		// Token: 0x04023ACE RID: 146126
		[Token(Token = "0x4023ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnInterruptBuildClick;

		// Token: 0x04023ACF RID: 146127
		[Token(Token = "0x4023ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnFinishBuildClick;

		// Token: 0x04023AD0 RID: 146128
		[Token(Token = "0x4023AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnConfirmFastFinish;

		// Token: 0x04023AD1 RID: 146129
		[Token(Token = "0x4023AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnBuyFastFinish;

		// Token: 0x04023AD2 RID: 146130
		[Token(Token = "0x4023AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnBuyFastDiamondShardFinish;

		// Token: 0x04023AD3 RID: 146131
		[Token(Token = "0x4023AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OpenDetail;

		// Token: 0x04023AD4 RID: 146132
		[Token(Token = "0x4023AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnConfirmStopBuild;

		// Token: 0x04023AD5 RID: 146133
		[Token(Token = "0x4023AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SyncBuildStatusProceedCallback;

		// Token: 0x04023AD6 RID: 146134
		[Token(Token = "0x4023AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SyncBuildStatusFinalCallback;

		// Token: 0x04023AD7 RID: 146135
		[Token(Token = "0x4023AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SendBuySlotService;

		// Token: 0x04023AD8 RID: 146136
		[Token(Token = "0x4023AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnGiveDataToDetialState;

		// Token: 0x04023AD9 RID: 146137
		[Token(Token = "0x4023AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnGiveDataToBuildConfigState;

		// Token: 0x04023ADA RID: 146138
		[Token(Token = "0x4023ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnReceiveDataFromBuildConfigState;

		// Token: 0x04023ADB RID: 146139
		[Token(Token = "0x4023ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04023ADC RID: 146140
		[Token(Token = "0x4023ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04023ADD RID: 146141
		[Token(Token = "0x4023ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04023ADE RID: 146142
		[Token(Token = "0x4023ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023ADF RID: 146143
		[Token(Token = "0x4023ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__SendSyncBuildDataService;

		// Token: 0x04023AE0 RID: 146144
		[Token(Token = "0x4023AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__EventOnGacha;

		// Token: 0x04023AE1 RID: 146145
		[Token(Token = "0x4023AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__EventOnLimitGacha;

		// Token: 0x04023AE2 RID: 146146
		[Token(Token = "0x4023AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__SendGachaReq;

		// Token: 0x04023AE3 RID: 146147
		[Token(Token = "0x4023AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_EventOnGachaBtnClick;

		// Token: 0x04023AE4 RID: 146148
		[Token(Token = "0x4023AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__EventOnTenGacha;

		// Token: 0x04023AE5 RID: 146149
		[Token(Token = "0x4023AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_EventOnTenGachaBtnClick;

		// Token: 0x04023AE6 RID: 146150
		[Token(Token = "0x4023AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__SendTenGachaReq;

		// Token: 0x04023AE7 RID: 146151
		[Token(Token = "0x4023AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_EventOnRecruitFreeClick;

		// Token: 0x04023AE8 RID: 146152
		[Token(Token = "0x4023AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__SendRecruitFreeCharReq;

		// Token: 0x04023AE9 RID: 146153
		[Token(Token = "0x4023AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnSingleAdvGachaSuc;

		// Token: 0x04023AEA RID: 146154
		[Token(Token = "0x4023AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__OnTenAdvGachaSuc;

		// Token: 0x04023AEB RID: 146155
		[Token(Token = "0x4023AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__OnGachaPoolBanned;

		// Token: 0x04023AEC RID: 146156
		[Token(Token = "0x4023AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__OnGetCharacter;

		// Token: 0x04023AED RID: 146157
		[Token(Token = "0x4023AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__OnGetCharacters;

		// Token: 0x04023AEE RID: 146158
		[Token(Token = "0x4023AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__PushGachaResultToGameAnalytics;

		// Token: 0x04023AEF RID: 146159
		[Token(Token = "0x4023AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
