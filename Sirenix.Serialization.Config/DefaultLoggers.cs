using System;
using Il2CppDummyDll;

namespace Sirenix.Serialization
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public static class DefaultLoggers
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000001")]
		public static ILogger DefaultLogger
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x4E1C9F0", Offset = "0x4E1B5F0", VA = "0x184E1C9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000002")]
		public static ILogger UnityLogger
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x4E1CA30", Offset = "0x4E1B630", VA = "0x184E1CA30")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object LOCK;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x8")]
		private static ILogger unityLogger;
	}
}
