using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005946 RID: 22854
	[Token(Token = "0x2005946")]
	public class CrisisV2MissionState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x060214E5 RID: 136421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214E5")]
		[Address(RVA = "0x1BB87D0", Offset = "0x1BB73D0", VA = "0x181BB87D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060214E6 RID: 136422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214E6")]
		[Address(RVA = "0x1BB7E30", Offset = "0x1BB6A30", VA = "0x181BB7E30", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060214E7 RID: 136423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214E7")]
		[Address(RVA = "0x1BB7E90", Offset = "0x1BB6A90", VA = "0x181BB7E90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060214E8 RID: 136424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214E8")]
		[Address(RVA = "0x1BB8EE0", Offset = "0x1BB7AE0", VA = "0x181BB8EE0")]
		private void _TryDismissSelf()
		{
		}

		// Token: 0x060214E9 RID: 136425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214E9")]
		[Address(RVA = "0x1BB8030", Offset = "0x1BB6C30", VA = "0x181BB8030", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060214EA RID: 136426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214EA")]
		[Address(RVA = "0x1BB8920", Offset = "0x1BB7520", VA = "0x181BB8920")]
		private void _OnClaimSingleMission(object msgObjVal)
		{
		}

		// Token: 0x060214EB RID: 136427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214EB")]
		[Address(RVA = "0x1BB8870", Offset = "0x1BB7470", VA = "0x181BB8870")]
		private void _OnClaimAllMissions()
		{
		}

		// Token: 0x060214EC RID: 136428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214EC")]
		[Address(RVA = "0x1BB8B00", Offset = "0x1BB7700", VA = "0x181BB8B00")]
		private void _OnJumpToSlot(object msgObjVal)
		{
		}

		// Token: 0x060214ED RID: 136429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214ED")]
		[Address(RVA = "0x1BB8440", Offset = "0x1BB7040", VA = "0x181BB8440")]
		private void _ClaimMissionReward(string mapId, List<CrisisV2MissionInfo> missions)
		{
		}

		// Token: 0x060214EE RID: 136430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214EE")]
		[Address(RVA = "0x1BB8C40", Offset = "0x1BB7840", VA = "0x181BB8C40")]
		private void _OnMissionClaimed(CrisisV2GetMissionRewardsResponse response)
		{
		}

		// Token: 0x060214EF RID: 136431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214EF")]
		[Address(RVA = "0x1BB8E30", Offset = "0x1BB7A30", VA = "0x181BB8E30")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x060214F0 RID: 136432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214F0")]
		[Address(RVA = "0x1BB82E0", Offset = "0x1BB6EE0", VA = "0x181BB82E0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060214F1 RID: 136433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214F1")]
		[Address(RVA = "0x1BB86B0", Offset = "0x1BB72B0", VA = "0x181BB86B0")]
		private void _DataToMapState(IStateBean stateBean)
		{
		}

		// Token: 0x060214F2 RID: 136434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214F2")]
		[Address(RVA = "0x1BB8F80", Offset = "0x1BB7B80", VA = "0x181BB8F80")]
		public CrisisV2MissionState()
		{
		}

		// Token: 0x060214F3 RID: 136435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214F3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060214F4 RID: 136436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214F4")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402D6A6 RID: 186022
		[Token(Token = "0x402D6A6")]
		[NonSerialized]
		public const int CLAIM_SINGLE_MISSION = 1;

		// Token: 0x0402D6A7 RID: 186023
		[Token(Token = "0x402D6A7")]
		[NonSerialized]
		public const int CLAIM_ALL_MISSION = 2;

		// Token: 0x0402D6A8 RID: 186024
		[Token(Token = "0x402D6A8")]
		[NonSerialized]
		public const int JUMP_TO_SLOT = 3;

		// Token: 0x0402D6A9 RID: 186025
		[Token(Token = "0x402D6A9")]
		[NonSerialized]
		public const int CLOSE_SELF = 4;

		// Token: 0x0402D6AA RID: 186026
		[Token(Token = "0x402D6AA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CrisisV2MissionView _view;

		// Token: 0x0402D6AB RID: 186027
		[Token(Token = "0x402D6AB")]
		[FieldOffset(Offset = "0x78")]
		private CrisisV2MissionStateBean m_stateBean;

		// Token: 0x0402D6AC RID: 186028
		[Token(Token = "0x402D6AC")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0402D6AD RID: 186029
		[Token(Token = "0x402D6AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D6AE RID: 186030
		[Token(Token = "0x402D6AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402D6AF RID: 186031
		[Token(Token = "0x402D6AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402D6B0 RID: 186032
		[Token(Token = "0x402D6B0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryDismissSelf;

		// Token: 0x0402D6B1 RID: 186033
		[Token(Token = "0x402D6B1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402D6B2 RID: 186034
		[Token(Token = "0x402D6B2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnClaimSingleMission;

		// Token: 0x0402D6B3 RID: 186035
		[Token(Token = "0x402D6B3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnClaimAllMissions;

		// Token: 0x0402D6B4 RID: 186036
		[Token(Token = "0x402D6B4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToSlot;

		// Token: 0x0402D6B5 RID: 186037
		[Token(Token = "0x402D6B5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClaimMissionReward;

		// Token: 0x0402D6B6 RID: 186038
		[Token(Token = "0x402D6B6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnMissionClaimed;

		// Token: 0x0402D6B7 RID: 186039
		[Token(Token = "0x402D6B7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0402D6B8 RID: 186040
		[Token(Token = "0x402D6B8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402D6B9 RID: 186041
		[Token(Token = "0x402D6B9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DataToMapState;

		// Token: 0x0402D6BA RID: 186042
		[Token(Token = "0x402D6BA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
