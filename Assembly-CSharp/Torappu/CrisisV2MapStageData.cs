using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FBE RID: 4030
	[Token(Token = "0x2000FBE")]
	public class CrisisV2MapStageData
	{
		// Token: 0x06006D05 RID: 27909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D05")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2MapStageData()
		{
		}

		// Token: 0x04005581 RID: 21889
		[Token(Token = "0x4005581")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04005582 RID: 21890
		[Token(Token = "0x4005582")]
		[FieldOffset(Offset = "0x18")]
		public string mapId;

		// Token: 0x04005583 RID: 21891
		[Token(Token = "0x4005583")]
		[FieldOffset(Offset = "0x20")]
		public string levelId;

		// Token: 0x04005584 RID: 21892
		[Token(Token = "0x4005584")]
		[FieldOffset(Offset = "0x28")]
		public CrisisV2StageType stageType;

		// Token: 0x04005585 RID: 21893
		[Token(Token = "0x4005585")]
		[FieldOffset(Offset = "0x30")]
		public string code;

		// Token: 0x04005586 RID: 21894
		[Token(Token = "0x4005586")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x04005587 RID: 21895
		[Token(Token = "0x4005587")]
		[FieldOffset(Offset = "0x40")]
		public string loadingPicId;

		// Token: 0x04005588 RID: 21896
		[Token(Token = "0x4005588")]
		[FieldOffset(Offset = "0x48")]
		public string description;

		// Token: 0x04005589 RID: 21897
		[Token(Token = "0x4005589")]
		[FieldOffset(Offset = "0x50")]
		public string picId;

		// Token: 0x0400558A RID: 21898
		[Token(Token = "0x400558A")]
		[FieldOffset(Offset = "0x58")]
		public string logoPicId;

		// Token: 0x0400558B RID: 21899
		[Token(Token = "0x400558B")]
		[FieldOffset(Offset = "0x60")]
		public long startTime;

		// Token: 0x0400558C RID: 21900
		[Token(Token = "0x400558C")]
		[FieldOffset(Offset = "0x68")]
		public long rewardEndTime;

		// Token: 0x0400558D RID: 21901
		[Token(Token = "0x400558D")]
		[FieldOffset(Offset = "0x70")]
		public bool showTip;
	}
}
