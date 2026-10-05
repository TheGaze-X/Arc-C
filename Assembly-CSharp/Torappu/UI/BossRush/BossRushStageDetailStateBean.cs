using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061C2 RID: 25026
	[Token(Token = "0x20061C2")]
	public class BossRushStageDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060241DE RID: 147934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241DE")]
		[Address(RVA = "0x1EDE870", Offset = "0x1EDD470", VA = "0x181EDE870")]
		public void LoadData(string actId, string selectStageId, string selectTeam)
		{
		}

		// Token: 0x060241DF RID: 147935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241DF")]
		[Address(RVA = "0x1EDEB50", Offset = "0x1EDD750", VA = "0x181EDEB50")]
		public BossRushStageDetailStateBean()
		{
		}

		// Token: 0x04032347 RID: 205639
		[Token(Token = "0x4032347")]
		[FieldOffset(Offset = "0x10")]
		public string stageGroupId;

		// Token: 0x04032348 RID: 205640
		[Token(Token = "0x4032348")]
		[FieldOffset(Offset = "0x18")]
		public BossRushStageDetailProperty viewProperty;

		// Token: 0x04032349 RID: 205641
		[Token(Token = "0x4032349")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403234A RID: 205642
		[Token(Token = "0x403234A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
