using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200769B RID: 30363
	[Token(Token = "0x200769B")]
	public class Act20sideEntertainCompBattleFinishViewModel : IHotfixable
	{
		// Token: 0x0602AB31 RID: 174897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB31")]
		[Address(RVA = "0x2673410", Offset = "0x2672010", VA = "0x182673410")]
		public void LoadData(CommonFinishBattleResponse response)
		{
		}

		// Token: 0x0602AB32 RID: 174898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB32")]
		[Address(RVA = "0x2673610", Offset = "0x2672210", VA = "0x182673610")]
		public Act20sideEntertainCompBattleFinishViewModel()
		{
		}

		// Token: 0x0403D865 RID: 252005
		[Token(Token = "0x403D865")]
		[FieldOffset(Offset = "0x10")]
		public string stageName;

		// Token: 0x0403D866 RID: 252006
		[Token(Token = "0x403D866")]
		[FieldOffset(Offset = "0x18")]
		public int performanceScore;

		// Token: 0x0403D867 RID: 252007
		[Token(Token = "0x403D867")]
		[FieldOffset(Offset = "0x1C")]
		public int expressionScore;

		// Token: 0x0403D868 RID: 252008
		[Token(Token = "0x403D868")]
		[FieldOffset(Offset = "0x20")]
		public int operationScore;

		// Token: 0x0403D869 RID: 252009
		[Token(Token = "0x403D869")]
		[FieldOffset(Offset = "0x24")]
		public int totalScore;

		// Token: 0x0403D86A RID: 252010
		[Token(Token = "0x403D86A")]
		[FieldOffset(Offset = "0x28")]
		public CartCompetitionRank rank;

		// Token: 0x0403D86B RID: 252011
		[Token(Token = "0x403D86B")]
		[FieldOffset(Offset = "0x2C")]
		public bool isNewRank;

		// Token: 0x0403D86C RID: 252012
		[Token(Token = "0x403D86C")]
		[FieldOffset(Offset = "0x30")]
		public int rankIndex;

		// Token: 0x0403D86D RID: 252013
		[Token(Token = "0x403D86D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D86E RID: 252014
		[Token(Token = "0x403D86E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
