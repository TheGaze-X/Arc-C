using System;
using Il2CppDummyDll;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
	public class ChallengeResponse : IDisposable
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4A799E0", Offset = "0x4A785E0", VA = "0x184A799E0")]
		public ChallengeResponse()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4A797F0", Offset = "0x4A783F0", VA = "0x184A797F0")]
		public ChallengeResponse(string password, byte[] challenge)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x4A78FE0", Offset = "0x4A77BE0", VA = "0x184A78FE0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x1700004F RID: 79
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004F")]
		public string Password
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x4A79CD0", Offset = "0x4A788D0", VA = "0x184A79CD0")]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000050")]
		public byte[] Challenge
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x4A79B60", Offset = "0x4A78760", VA = "0x184A79B60")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public byte[] LM
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x4A79A60", Offset = "0x4A78660", VA = "0x184A79A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		public byte[] NT
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x4A79AE0", Offset = "0x4A786E0", VA = "0x184A79AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x4A78ED0", Offset = "0x4A77AD0", VA = "0x184A78ED0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x4A78F70", Offset = "0x4A77B70", VA = "0x184A78F70")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x4A790E0", Offset = "0x4A77CE0", VA = "0x184A790E0")]
		private byte[] GetResponse(byte[] pwd)
		{
			return null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x4A79500", Offset = "0x4A78100", VA = "0x184A79500")]
		private byte[] PrepareDESKey(byte[] key56bits, int position)
		{
			return null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x4A79390", Offset = "0x4A77F90", VA = "0x184A79390")]
		private byte[] PasswordToKey(string password, int position)
		{
			return null;
		}

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] magic;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] nullEncMagic;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x10")]
		private bool _disposed;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _challenge;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x20")]
		private byte[] _lmpwd;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x28")]
		private byte[] _ntpwd;
	}
}
