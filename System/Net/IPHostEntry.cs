using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	public class IPHostEntry
	{
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000404")]
		public string HostName
		{
			[Token(Token = "0x600134D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600134E")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000405 RID: 1029
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000405")]
		public string[] Aliases
		{
			[Token(Token = "0x600134F")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000406")]
		public IPAddress[] AddressList
		{
			[Token(Token = "0x6001350")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001351")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x3509420", Offset = "0x3508020", VA = "0x183509420")]
		public IPHostEntry()
		{
		}

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		[FieldOffset(Offset = "0x10")]
		private string hostName;

		// Token: 0x04000A51 RID: 2641
		[Token(Token = "0x4000A51")]
		[FieldOffset(Offset = "0x18")]
		private string[] aliases;

		// Token: 0x04000A52 RID: 2642
		[Token(Token = "0x4000A52")]
		[FieldOffset(Offset = "0x20")]
		private IPAddress[] addressList;

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4000A53")]
		[FieldOffset(Offset = "0x28")]
		internal bool isTrustedHost;
	}
}
