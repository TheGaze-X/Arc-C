using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004177 RID: 16759
	[Token(Token = "0x2004177")]
	public class SandboxV2ChallengeSettleViewModel : IHotfixable
	{
		// Token: 0x06019DDB RID: 105947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DDB")]
		[Address(RVA = "0x12B8870", Offset = "0x12B7470", VA = "0x1812B8870")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x06019DDC RID: 105948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DDC")]
		[Address(RVA = "0x12B8A60", Offset = "0x12B7660", VA = "0x1812B8A60")]
		public SandboxV2ChallengeSettleViewModel()
		{
		}

		// Token: 0x040207F3 RID: 133107
		[Token(Token = "0x40207F3")]
		[FieldOffset(Offset = "0x10")]
		public string userName;

		// Token: 0x040207F4 RID: 133108
		[Token(Token = "0x40207F4")]
		[FieldOffset(Offset = "0x18")]
		public int challengeDay;

		// Token: 0x040207F5 RID: 133109
		[Token(Token = "0x40207F5")]
		[FieldOffset(Offset = "0x1C")]
		public int enemyRushKilledCount;

		// Token: 0x040207F6 RID: 133110
		[Token(Token = "0x40207F6")]
		[FieldOffset(Offset = "0x20")]
		public int startDay;

		// Token: 0x040207F7 RID: 133111
		[Token(Token = "0x40207F7")]
		[FieldOffset(Offset = "0x24")]
		public int startLoadTimes;

		// Token: 0x040207F8 RID: 133112
		[Token(Token = "0x40207F8")]
		[FieldOffset(Offset = "0x28")]
		public bool hasNewRecord;

		// Token: 0x040207F9 RID: 133113
		[Token(Token = "0x40207F9")]
		[FieldOffset(Offset = "0x30")]
		public string topicId;

		// Token: 0x040207FA RID: 133114
		[Token(Token = "0x40207FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040207FB RID: 133115
		[Token(Token = "0x40207FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
