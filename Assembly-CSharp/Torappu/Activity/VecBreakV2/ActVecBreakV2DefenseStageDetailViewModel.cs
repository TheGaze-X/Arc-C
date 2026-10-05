using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.EventTrack;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E25 RID: 28197
	[Token(Token = "0x2006E25")]
	public class ActVecBreakV2DefenseStageDetailViewModel : IHotfixable
	{
		// Token: 0x06028227 RID: 164391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028227")]
		[Address(RVA = "0x2366430", Offset = "0x2365030", VA = "0x182366430")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06028228 RID: 164392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028228")]
		[Address(RVA = "0x2366F70", Offset = "0x2365B70", VA = "0x182366F70")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x06028229 RID: 164393 RVA: 0x000D0C20 File Offset: 0x000CEE20
		[Token(Token = "0x6028229")]
		[Address(RVA = "0x2367840", Offset = "0x2366440", VA = "0x182367840")]
		public bool TryGetStageDetailModel(string stageId, out ActVecBreakV2DefenseStageDetailItemModel detailModel)
		{
			return default(bool);
		}

		// Token: 0x0602822A RID: 164394 RVA: 0x000D0C38 File Offset: 0x000CEE38
		[Token(Token = "0x602822A")]
		[Address(RVA = "0x23674C0", Offset = "0x23660C0", VA = "0x1823674C0")]
		public bool TryGetCompletedAdvancedBuffNameStr(string stageId, out string buffNameStr)
		{
			return default(bool);
		}

		// Token: 0x0602822B RID: 164395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602822B")]
		[Address(RVA = "0x23660A0", Offset = "0x2364CA0", VA = "0x1823660A0")]
		public void FetchAdavanceStageList(string stageId, List<EventLogTrace.EventLogVecBreakV2Context.DefenseStageInfo> stageInfoList)
		{
		}

		// Token: 0x0602822C RID: 164396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602822C")]
		[Address(RVA = "0x2367930", Offset = "0x2366530", VA = "0x182367930")]
		private static string _GenUnlockConditionStr(string stageId, string groupId, Dictionary<string, ActVecBreakV2DefenseGroupData> stageGroupDict, Dictionary<string, ActVecBreakV2DefenseDetailData> stageDetailDict, Dictionary<string, ActVecBreakV2BattleBuffData> buffDict)
		{
			return null;
		}

		// Token: 0x0602822D RID: 164397 RVA: 0x000D0C50 File Offset: 0x000CEE50
		[Token(Token = "0x602822D")]
		[Address(RVA = "0x2367CA0", Offset = "0x23668A0", VA = "0x182367CA0")]
		private bool _PostCheckIfStageLocked(string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602822E RID: 164398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602822E")]
		[Address(RVA = "0x2367EB0", Offset = "0x2366AB0", VA = "0x182367EB0")]
		public ActVecBreakV2DefenseStageDetailViewModel()
		{
		}

		// Token: 0x04038FDC RID: 233436
		[Token(Token = "0x4038FDC")]
		private const int DEFENSE_CHAR_SLOT_NUM = 3;

		// Token: 0x04038FDD RID: 233437
		[Token(Token = "0x4038FDD")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04038FDE RID: 233438
		[Token(Token = "0x4038FDE")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ActVecBreakV2DefenseStageDetailItemModel> stageDetailDict;

		// Token: 0x04038FDF RID: 233439
		[Token(Token = "0x4038FDF")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, List<string>> m_groupIdRefMap;

		// Token: 0x04038FE0 RID: 233440
		[Token(Token = "0x4038FE0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038FE1 RID: 233441
		[Token(Token = "0x4038FE1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04038FE2 RID: 233442
		[Token(Token = "0x4038FE2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetStageDetailModel;

		// Token: 0x04038FE3 RID: 233443
		[Token(Token = "0x4038FE3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryGetCompletedAdvancedBuffNameStr;

		// Token: 0x04038FE4 RID: 233444
		[Token(Token = "0x4038FE4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FetchAdavanceStageList;

		// Token: 0x04038FE5 RID: 233445
		[Token(Token = "0x4038FE5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenUnlockConditionStr;

		// Token: 0x04038FE6 RID: 233446
		[Token(Token = "0x4038FE6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PostCheckIfStageLocked;

		// Token: 0x04038FE7 RID: 233447
		[Token(Token = "0x4038FE7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
