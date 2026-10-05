using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061C6 RID: 25030
	[Token(Token = "0x20061C6")]
	public class BossRushStageGroupDropModel : IHotfixable
	{
		// Token: 0x060241EC RID: 147948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241EC")]
		[Address(RVA = "0x1EE2730", Offset = "0x1EE1330", VA = "0x181EE2730")]
		private BossRushStageGroupDropModel()
		{
		}

		// Token: 0x060241ED RID: 147949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241ED")]
		[Address(RVA = "0x1EE27E0", Offset = "0x1EE13E0", VA = "0x181EE27E0")]
		public BossRushStageGroupDropModel(int waveCount, Dictionary<ActivityBossRushData.BossRushStageType, string> stageIdMap, Dictionary<string, Dictionary<int, ActivityBossRushData.BossRushDropInfo>> dropDataMap)
		{
		}

		// Token: 0x04032371 RID: 205681
		[Token(Token = "0x4032371")]
		[FieldOffset(Offset = "0x10")]
		public int waveCount;

		// Token: 0x04032372 RID: 205682
		[Token(Token = "0x4032372")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<ActivityBossRushData.BossRushStageType, BossRushStageDropModel> dropModelMap;

		// Token: 0x04032373 RID: 205683
		[Token(Token = "0x4032373")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04032374 RID: 205684
		[Token(Token = "0x4032374")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix1_ctor;
	}
}
