using System;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Authenticode
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	public class AuthenticodeBase
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x4A91A90", Offset = "0x4A90690", VA = "0x184A91A90")]
		public AuthenticodeBase()
		{
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x1700008C")]
		internal int PEOffset
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x4A91AF0", Offset = "0x4A906F0", VA = "0x184A91AF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x4A91520", Offset = "0x4A90120", VA = "0x184A91520")]
		internal void Open(string filename)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x4A91610", Offset = "0x4A90210", VA = "0x184A91610")]
		internal void Open(byte[] rawdata)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x4A90E50", Offset = "0x4A8FA50", VA = "0x184A90E50")]
		internal void Close()
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x4A919B0", Offset = "0x4A905B0", VA = "0x184A919B0")]
		internal void ReadFirstBlock()
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x4A916E0", Offset = "0x4A902E0", VA = "0x184A916E0")]
		internal int ProcessFirstBlock()
		{
			return 0;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x4A91410", Offset = "0x4A90010", VA = "0x184A91410")]
		internal byte[] GetSecurityEntry()
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x4A90EB0", Offset = "0x4A8FAB0", VA = "0x184A90EB0")]
		internal byte[] GetHash(HashAlgorithm hash)
		{
			return null;
		}

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x10")]
		private byte[] fileblock;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x18")]
		private Stream fs;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x20")]
		private int blockNo;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x24")]
		private int blockLength;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x28")]
		private int peOffset;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x2C")]
		private int dirSecurityOffset;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x30")]
		private int dirSecuritySize;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x34")]
		private int coffSymbolTableOffset;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x38")]
		private bool pe64;
	}
}
