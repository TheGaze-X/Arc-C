using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CB4 RID: 31924
	[Token(Token = "0x2007CB4")]
	public static class fiLog
	{
		// Token: 0x0602C96E RID: 182638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C96E")]
		[Address(RVA = "0x2884540", Offset = "0x2883140", VA = "0x182884540")]
		public static void InsertAndClearMessagesTo(List<string> buffer)
		{
		}

		// Token: 0x0602C96F RID: 182639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C96F")]
		[Address(RVA = "0x2884210", Offset = "0x2882E10", VA = "0x182884210")]
		public static void Blank()
		{
		}

		// Token: 0x0602C970 RID: 182640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C970")]
		[Address(RVA = "0x2884390", Offset = "0x2882F90", VA = "0x182884390")]
		private static string GetTag(object tag)
		{
			return null;
		}

		// Token: 0x0602C971 RID: 182641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C971")]
		[Address(RVA = "0x28846C0", Offset = "0x28832C0", VA = "0x1828846C0")]
		public static void Log(object tag, string message)
		{
		}

		// Token: 0x0602C972 RID: 182642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C972")]
		[Address(RVA = "0x2884870", Offset = "0x2883470", VA = "0x182884870")]
		public static void Log(object tag, string format, params object[] args)
		{
		}

		// Token: 0x040403DE RID: 263134
		[Token(Token = "0x40403DE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<string> _messages;
	}
}
