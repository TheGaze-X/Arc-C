using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020005AF RID: 1455
	[Token(Token = "0x20005AF")]
	[System.AttributeUsage(System.AttributeTargets.Method)]
	public sealed class EventAttribute : System.Attribute
	{
		// Token: 0x06002B67 RID: 11111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B67")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public EventAttribute(int eventId)
		{
		}

		// Token: 0x170006A8 RID: 1704
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A8")]
		private int EventId
		{
			[Token(Token = "0x6002B68")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (set) Token: 0x06002B69 RID: 11113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A9")]
		public EventLevel Level
		{
			[Token(Token = "0x6002B69")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006AA RID: 1706
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AA")]
		public EventKeywords Keywords
		{
			[Token(Token = "0x6002B6A")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006AB RID: 1707
		// (set) Token: 0x06002B6B RID: 11115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AB")]
		public string Message
		{
			[Token(Token = "0x6002B6B")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}
	}
}
