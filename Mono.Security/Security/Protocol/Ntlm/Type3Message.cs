using System;
using Il2CppDummyDll;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public class Type3Message : MessageBase
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x4AA7A30", Offset = "0x4AA6630", VA = "0x184AA7A30")]
		public Type3Message(Type2Message type2)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x4AA7170", Offset = "0x4AA5D70", VA = "0x184AA7170", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x1700005B RID: 91
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005B")]
		public string Domain
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x4AA7CD0", Offset = "0x4AA68D0", VA = "0x184AA7CD0")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005C")]
		public string Password
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005D")]
		public string Username
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			set
			{
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x4AA6E30", Offset = "0x4AA5A30", VA = "0x184AA6E30", Slot = "4")]
		protected override void Decode(byte[] message)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x4AA6DD0", Offset = "0x4AA59D0", VA = "0x184AA6DD0")]
		private string DecodeString(byte[] buffer, int offset, int len)
		{
			return null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x4AA70D0", Offset = "0x4AA5CD0", VA = "0x184AA70D0")]
		private byte[] EncodeString(string text)
		{
			return null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x4AA7220", Offset = "0x4AA5E20", VA = "0x184AA7220", Slot = "5")]
		public override byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x18")]
		private NtlmAuthLevel _level;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x20")]
		private byte[] _challenge;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x28")]
		private string _host;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x30")]
		private string _domain;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x38")]
		private string _username;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x40")]
		private string _password;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x48")]
		private Type2Message _type2;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x50")]
		private byte[] _lm;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x58")]
		private byte[] _nt;
	}
}
