using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	internal abstract class AsyncProtocolRequest
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public MobileAuthenticatedStream Parent
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x1700001D")]
		public bool RunSynchronously
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public string Name
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x4F4D730", Offset = "0x4F4C330", VA = "0x184F4D730")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000023A0 File Offset: 0x000005A0
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001F")]
		public int UserResult
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x4F4D690", Offset = "0x4F4C290", VA = "0x184F4D690")]
		public AsyncProtocolRequest(MobileAuthenticatedStream parent, bool sync)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x4F4D440", Offset = "0x4F4C040", VA = "0x184F4D440")]
		internal void RequestRead(int size)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x4F4D4D0", Offset = "0x4F4C0D0", VA = "0x184F4D4D0")]
		internal void RequestWrite()
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x4F4D4E0", Offset = "0x4F4C0E0", VA = "0x184F4D4E0")]
		internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4F4D330", Offset = "0x4F4BF30", VA = "0x184F4D330")]
		private Task ProcessOperation(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4F4D200", Offset = "0x4F4BE00", VA = "0x184F4D200")]
		private Task<int?> InnerRead(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000BE RID: 190
		[Token(Token = "0x60000BE")]
		protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4F4D610", Offset = "0x4F4C210", VA = "0x184F4D610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x20")]
		private int Started;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x24")]
		private int RequestedSize;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x28")]
		private int WriteRequested;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x30")]
		private readonly object locker;
	}
}
