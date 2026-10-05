using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	[System.Serializable]
	public sealed class ConsoleCancelEventArgs : System.EventArgs
	{
		// Token: 0x06000C74 RID: 3188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x4CF4A40", Offset = "0x4CF3640", VA = "0x184CF4A40")]
		internal ConsoleCancelEventArgs(System.ConsoleSpecialKey type)
		{
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x1700010E")]
		public bool Cancel
		{
			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x4CF4AA0", Offset = "0x4CF36A0", VA = "0x184CF4AA0")]
		internal ConsoleCancelEventArgs()
		{
		}

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0x10")]
		private readonly System.ConsoleSpecialKey _type;
	}
}
