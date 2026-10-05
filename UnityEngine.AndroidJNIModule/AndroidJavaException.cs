using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public sealed class AndroidJavaException : Exception
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5908EB0", Offset = "0x5907AB0", VA = "0x185908EB0")]
		internal AndroidJavaException(string message, string javaStackTrace)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000001")]
		public override string StackTrace
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x5908F30", Offset = "0x5907B30", VA = "0x185908F30", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x90")]
		private string mJavaStackTrace;
	}
}
