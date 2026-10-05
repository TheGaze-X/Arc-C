using System;
using Il2CppDummyDll;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public class Type2Message : MessageBase
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x4AA6C20", Offset = "0x4AA5820", VA = "0x184AA6C20")]
		public Type2Message(byte[] message)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x4AA6AF0", Offset = "0x4AA56F0", VA = "0x184AA6AF0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public byte[] Nonce
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x4AA6CD0", Offset = "0x4AA58D0", VA = "0x184AA6CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public string TargetName
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public byte[] TargetInfo
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x4AA6D50", Offset = "0x4AA5950", VA = "0x184AA6D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4AA6970", Offset = "0x4AA5570", VA = "0x184AA6970", Slot = "4")]
		protected override void Decode(byte[] message)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4AA6B60", Offset = "0x4AA5760", VA = "0x184AA6B60", Slot = "5")]
		public override byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _nonce;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x20")]
		private string _targetName;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x28")]
		private byte[] _targetInfo;
	}
}
