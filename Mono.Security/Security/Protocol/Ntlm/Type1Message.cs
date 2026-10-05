using System;
using Il2CppDummyDll;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class Type1Message : MessageBase
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4AA67E0", Offset = "0x4AA53E0", VA = "0x184AA67E0")]
		public Type1Message()
		{
		}

		// Token: 0x17000056 RID: 86
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000056")]
		public string Domain
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x4AA6870", Offset = "0x4AA5470", VA = "0x184AA6870")]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000057")]
		public string Host
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x4AA68F0", Offset = "0x4AA54F0", VA = "0x184AA68F0")]
			set
			{
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x4AA63B0", Offset = "0x4AA4FB0", VA = "0x184AA63B0", Slot = "4")]
		protected override void Decode(byte[] message)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x4AA64F0", Offset = "0x4AA50F0", VA = "0x184AA64F0", Slot = "5")]
		public override byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x18")]
		private string _host;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x20")]
		private string _domain;
	}
}
