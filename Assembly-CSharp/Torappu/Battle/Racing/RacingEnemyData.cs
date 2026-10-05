using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Racing
{
	// Token: 0x02002979 RID: 10617
	[Token(Token = "0x2002979")]
	[Serializable]
	public class RacingEnemyData : IHotfixable
	{
		// Token: 0x06011909 RID: 71945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011909")]
		[Address(RVA = "0x95DB50", Offset = "0x95C750", VA = "0x18095DB50")]
		public RacingEnemyData()
		{
		}

		// Token: 0x04013A17 RID: 80407
		[Token(Token = "0x4013A17")]
		[FieldOffset(Offset = "0x10")]
		public string instId;

		// Token: 0x04013A18 RID: 80408
		[Token(Token = "0x4013A18")]
		[FieldOffset(Offset = "0x18")]
		public bool isMine;

		// Token: 0x04013A19 RID: 80409
		[Token(Token = "0x4013A19")]
		[FieldOffset(Offset = "0x20")]
		public string enemyKey;

		// Token: 0x04013A1A RID: 80410
		[Token(Token = "0x4013A1A")]
		[FieldOffset(Offset = "0x28")]
		public float maxRacingSpeed;

		// Token: 0x04013A1B RID: 80411
		[Token(Token = "0x4013A1B")]
		[FieldOffset(Offset = "0x2C")]
		public float racingAcceleration;

		// Token: 0x04013A1C RID: 80412
		[Token(Token = "0x4013A1C")]
		[FieldOffset(Offset = "0x30")]
		public float maxRacingHp;

		// Token: 0x04013A1D RID: 80413
		[Token(Token = "0x4013A1D")]
		[FieldOffset(Offset = "0x34")]
		public float endurance;

		// Token: 0x04013A1E RID: 80414
		[Token(Token = "0x4013A1E")]
		[FieldOffset(Offset = "0x38")]
		public int massLevel;

		// Token: 0x04013A1F RID: 80415
		[Token(Token = "0x4013A1F")]
		[FieldOffset(Offset = "0x40")]
		public List<Blackboard> talentBlackboards;

		// Token: 0x04013A20 RID: 80416
		[Token(Token = "0x4013A20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
