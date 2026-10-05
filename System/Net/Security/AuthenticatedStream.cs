using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Net.Security
{
	// Token: 0x020003CF RID: 975
	[Token(Token = "0x20003CF")]
	public abstract class AuthenticatedStream : Stream
	{
		// Token: 0x06001A44 RID: 6724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A44")]
		[Address(RVA = "0x50BA9F0", Offset = "0x50B95F0", VA = "0x1850BA9F0")]
		protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
		{
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C3")]
		protected Stream InnerStream
		{
			[Token(Token = "0x6001A45")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x50BA8F0", Offset = "0x50B94F0", VA = "0x1850BA8F0", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001A47 RID: 6727
		[Token(Token = "0x170005C4")]
		public abstract bool IsAuthenticated { [Token(Token = "0x6001A47")] get; }

		// Token: 0x0400111C RID: 4380
		[Token(Token = "0x400111C")]
		[FieldOffset(Offset = "0x28")]
		private Stream _InnerStream;

		// Token: 0x0400111D RID: 4381
		[Token(Token = "0x400111D")]
		[FieldOffset(Offset = "0x30")]
		private bool _LeaveStreamOpen;
	}
}
