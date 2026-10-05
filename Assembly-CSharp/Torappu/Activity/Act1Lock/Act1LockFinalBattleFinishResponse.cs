using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x0200786E RID: 30830
	[Token(Token = "0x200786E")]
	public class Act1LockFinalBattleFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x0602B342 RID: 176962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B342")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public Act1LockFinalBattleFinishResponse()
		{
		}

		// Token: 0x0403E76B RID: 255851
		[Token(Token = "0x403E76B")]
		[FieldOffset(Offset = "0xA0")]
		public int basicDrop;

		// Token: 0x0403E76C RID: 255852
		[Token(Token = "0x403E76C")]
		[FieldOffset(Offset = "0xA8")]
		public List<StageKeyDropData> stageKeyDropList;
	}
}
