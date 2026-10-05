using System;
using Il2CppDummyDll;

namespace UnityEngine.Assertions
{
	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	public class AssertionException : Exception
	{
		// Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x5979E00", Offset = "0x5978A00", VA = "0x185979E00")]
		public AssertionException(string message, string userMessage)
		{
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000306")]
		public override string Message
		{
			[Token(Token = "0x6000FD3")]
			[Address(RVA = "0x5979E80", Offset = "0x5978A80", VA = "0x185979E80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[FieldOffset(Offset = "0x90")]
		private string m_UserMessage;
	}
}
