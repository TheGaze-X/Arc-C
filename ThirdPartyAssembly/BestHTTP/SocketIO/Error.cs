using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO
{
	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x2000516")]
	public sealed class Error
	{
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x00012570 File Offset: 0x00010770
		// (set) Token: 0x06002B04 RID: 11012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000647")]
		public SocketIOErrors Code
		{
			[Token(Token = "0x6002B03")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return SocketIOErrors.UnknownTransport;
			}
			[Token(Token = "0x6002B04")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B06 RID: 11014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000648")]
		public string Message
		{
			[Token(Token = "0x6002B05")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B06")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B07")]
		[Address(RVA = "0x3437250", Offset = "0x3435E50", VA = "0x183437250")]
		public Error(SocketIOErrors code, string msg)
		{
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B08")]
		[Address(RVA = "0x53CD470", Offset = "0x53CC070", VA = "0x1853CD470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
