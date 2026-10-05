using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200031F RID: 799
	[Token(Token = "0x200031F")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class SHA1Managed : SHA1
	{
		// Token: 0x06001A73 RID: 6771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x4B4A2B0", Offset = "0x4B48EB0", VA = "0x184B4A2B0")]
		public SHA1Managed()
		{
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x4B49840", Offset = "0x4B48440", VA = "0x184B49840", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x4B49820", Offset = "0x4B48420", VA = "0x184B49820", Slot = "18")]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x4B49830", Offset = "0x4B48430", VA = "0x184B49830", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x4B3E810", Offset = "0x4B3D410", VA = "0x184B3E810")]
		private void InitializeState()
		{
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A78")]
		[Address(RVA = "0x4B4A120", Offset = "0x4B48D20", VA = "0x184B4A120")]
		private void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A79")]
		[Address(RVA = "0x4B49EC0", Offset = "0x4B48AC0", VA = "0x184B49EC0")]
		private byte[] _EndHash()
		{
			return null;
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x4B498D0", Offset = "0x4B484D0", VA = "0x184B498D0")]
		private unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
		{
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x4B49890", Offset = "0x4B48490", VA = "0x184B49890")]
		private unsafe static void SHAExpand(uint* x)
		{
		}

		// Token: 0x04000E37 RID: 3639
		[Token(Token = "0x4000E37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		// Token: 0x04000E38 RID: 3640
		[Token(Token = "0x4000E38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long _count;

		// Token: 0x04000E39 RID: 3641
		[Token(Token = "0x4000E39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private uint[] _stateSHA1;

		// Token: 0x04000E3A RID: 3642
		[Token(Token = "0x4000E3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private uint[] _expandedBuffer;
	}
}
