using System;
using Il2CppDummyDll;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public abstract class MessageBase
	{
		// Token: 0x0600011F RID: 287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		protected MessageBase(int messageType)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00002550 File Offset: 0x00000750
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000053")]
		public NtlmFlags Flags
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return (NtlmFlags)0;
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x17000054")]
		public int Type
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x4A9D800", Offset = "0x4A9C400", VA = "0x184A9D800")]
		protected byte[] PrepareMessage(int messageSize)
		{
			return null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x4A9D560", Offset = "0x4A9C160", VA = "0x184A9D560", Slot = "4")]
		protected virtual void Decode(byte[] message)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x4A9D450", Offset = "0x4A9C050", VA = "0x184A9D450")]
		protected bool CheckHeader(byte[] message)
		{
			return default(bool);
		}

		// Token: 0x06000126 RID: 294
		[Token(Token = "0x6000126")]
		public abstract byte[] GetBytes();

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] header;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x10")]
		private int _type;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x14")]
		private NtlmFlags _flags;
	}
}
