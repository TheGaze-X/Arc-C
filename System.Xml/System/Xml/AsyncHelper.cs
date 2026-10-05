using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	internal static class AsyncHelper
	{
		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Task DoneTask;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Task<bool> DoneTaskTrue;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Task<bool> DoneTaskFalse;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Task<int> DoneTaskZero;
	}
}
