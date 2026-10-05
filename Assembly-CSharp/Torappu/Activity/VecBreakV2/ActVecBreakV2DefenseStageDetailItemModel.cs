using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E24 RID: 28196
	[Token(Token = "0x2006E24")]
	public class ActVecBreakV2DefenseStageDetailItemModel : IHotfixable
	{
		// Token: 0x06028226 RID: 164390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028226")]
		[Address(RVA = "0x2364D20", Offset = "0x2363920", VA = "0x182364D20")]
		public ActVecBreakV2DefenseStageDetailItemModel()
		{
		}

		// Token: 0x04038FC4 RID: 233412
		[Token(Token = "0x4038FC4")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x04038FC5 RID: 233413
		[Token(Token = "0x4038FC5")]
		[FieldOffset(Offset = "0x18")]
		public string buffIconId;

		// Token: 0x04038FC6 RID: 233414
		[Token(Token = "0x4038FC6")]
		[FieldOffset(Offset = "0x20")]
		public string buffName;

		// Token: 0x04038FC7 RID: 233415
		[Token(Token = "0x4038FC7")]
		[FieldOffset(Offset = "0x28")]
		public string buffDesc;

		// Token: 0x04038FC8 RID: 233416
		[Token(Token = "0x4038FC8")]
		[FieldOffset(Offset = "0x30")]
		public string stageId;

		// Token: 0x04038FC9 RID: 233417
		[Token(Token = "0x4038FC9")]
		[FieldOffset(Offset = "0x38")]
		public string stageGroupId;

		// Token: 0x04038FCA RID: 233418
		[Token(Token = "0x4038FCA")]
		[FieldOffset(Offset = "0x40")]
		public string bossIconId;

		// Token: 0x04038FCB RID: 233419
		[Token(Token = "0x4038FCB")]
		[FieldOffset(Offset = "0x48")]
		public string stageName;

		// Token: 0x04038FCC RID: 233420
		[Token(Token = "0x4038FCC")]
		[FieldOffset(Offset = "0x50")]
		public string stageCode;

		// Token: 0x04038FCD RID: 233421
		[Token(Token = "0x4038FCD")]
		[FieldOffset(Offset = "0x58")]
		public string stageDesc;

		// Token: 0x04038FCE RID: 233422
		[Token(Token = "0x4038FCE")]
		[FieldOffset(Offset = "0x60")]
		public int normalRewardCnt;

		// Token: 0x04038FCF RID: 233423
		[Token(Token = "0x4038FCF")]
		[FieldOffset(Offset = "0x64")]
		public int timeLimitRewardCnt;

		// Token: 0x04038FD0 RID: 233424
		[Token(Token = "0x4038FD0")]
		[FieldOffset(Offset = "0x68")]
		public string unlockConditionStr;

		// Token: 0x04038FD1 RID: 233425
		[Token(Token = "0x4038FD1")]
		[FieldOffset(Offset = "0x70")]
		public int defenseCharLimitNum;

		// Token: 0x04038FD2 RID: 233426
		[Token(Token = "0x4038FD2")]
		[FieldOffset(Offset = "0x78")]
		public long timeLimitRewardStartTs;

		// Token: 0x04038FD3 RID: 233427
		[Token(Token = "0x4038FD3")]
		[FieldOffset(Offset = "0x80")]
		public long timeLimitRewardEndTs;

		// Token: 0x04038FD4 RID: 233428
		[Token(Token = "0x4038FD4")]
		[FieldOffset(Offset = "0x88")]
		public List<string> orderedPrevStageList;

		// Token: 0x04038FD5 RID: 233429
		[Token(Token = "0x4038FD5")]
		[FieldOffset(Offset = "0x90")]
		public bool isNormalRewardClaimed;

		// Token: 0x04038FD6 RID: 233430
		[Token(Token = "0x4038FD6")]
		[FieldOffset(Offset = "0x91")]
		public bool isTimeLimitRewardClaimed;

		// Token: 0x04038FD7 RID: 233431
		[Token(Token = "0x4038FD7")]
		[FieldOffset(Offset = "0x92")]
		public bool showTimeLimitRewardPanel;

		// Token: 0x04038FD8 RID: 233432
		[Token(Token = "0x4038FD8")]
		[FieldOffset(Offset = "0x98")]
		public List<ActVecBreakV2DefenseCharSlotModel> defenseCharList;

		// Token: 0x04038FD9 RID: 233433
		[Token(Token = "0x4038FD9")]
		[FieldOffset(Offset = "0xA0")]
		public bool isStageComplete;

		// Token: 0x04038FDA RID: 233434
		[Token(Token = "0x4038FDA")]
		[FieldOffset(Offset = "0xA1")]
		public bool isStageLocked;

		// Token: 0x04038FDB RID: 233435
		[Token(Token = "0x4038FDB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
