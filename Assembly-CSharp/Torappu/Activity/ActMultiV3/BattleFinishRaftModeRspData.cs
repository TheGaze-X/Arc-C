using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ED1 RID: 28369
	[Token(Token = "0x2006ED1")]
	public class BattleFinishRaftModeRspData
	{
		// Token: 0x06028548 RID: 165192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028548")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleFinishRaftModeRspData()
		{
		}

		// Token: 0x0403953D RID: 234813
		[Token(Token = "0x403953D")]
		[FieldOffset(Offset = "0x10")]
		public int score;

		// Token: 0x0403953E RID: 234814
		[Token(Token = "0x403953E")]
		[FieldOffset(Offset = "0x14")]
		public bool newScore;
	}
}
