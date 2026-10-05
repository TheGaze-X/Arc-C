using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200627A RID: 25210
	[Token(Token = "0x200627A")]
	public class AutoChessQuitSingleGameRequest
	{
		// Token: 0x0602459D RID: 148893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602459D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessQuitSingleGameRequest()
		{
		}

		// Token: 0x040328E4 RID: 207076
		[Token(Token = "0x40328E4")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040328E5 RID: 207077
		[Token(Token = "0x40328E5")]
		[FieldOffset(Offset = "0x18")]
		public string sceneId;
	}
}
