using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		protected BufferOffsetSize UserBuffer
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000021")]
		protected int CurrentSize
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x4F4D810", Offset = "0x4F4C410", VA = "0x184F4D810")]
		public AsyncReadOrWriteRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x4F4D780", Offset = "0x4F4C380", VA = "0x184F4D780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
