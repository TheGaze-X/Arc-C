using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000316 RID: 790
	[Token(Token = "0x2000316")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class RIPEMD160Managed : RIPEMD160
	{
		// Token: 0x060019E9 RID: 6633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019E9")]
		[Address(RVA = "0x4B40EC0", Offset = "0x4B3FAC0", VA = "0x184B40EC0")]
		public RIPEMD160Managed()
		{
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019EA")]
		[Address(RVA = "0x4B3E8A0", Offset = "0x4B3D4A0", VA = "0x184B3E8A0", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019EB")]
		[Address(RVA = "0x4B3E7E0", Offset = "0x4B3D3E0", VA = "0x184B3E7E0", Slot = "18")]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019EC")]
		[Address(RVA = "0x4B3E7F0", Offset = "0x4B3D3F0", VA = "0x184B3E7F0", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019ED")]
		[Address(RVA = "0x4B3E810", Offset = "0x4B3D410", VA = "0x184B3E810")]
		private void InitializeState()
		{
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019EE")]
		[Address(RVA = "0x4B40D30", Offset = "0x4B3F930", VA = "0x184B40D30")]
		private void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019EF")]
		[Address(RVA = "0x4B40AD0", Offset = "0x4B3F6D0", VA = "0x184B40AD0")]
		private byte[] _EndHash()
		{
			return null;
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019F0")]
		[Address(RVA = "0x4B3E900", Offset = "0x4B3D500", VA = "0x184B3E900")]
		private unsafe static void MDTransform(uint* blockDWords, uint* state, byte* block)
		{
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00011E98 File Offset: 0x00010098
		[Token(Token = "0x60019F1")]
		[Address(RVA = "0x4B3E7B0", Offset = "0x4B3D3B0", VA = "0x184B3E7B0")]
		private static uint F(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00011EB0 File Offset: 0x000100B0
		[Token(Token = "0x60019F2")]
		[Address(RVA = "0x4B3E7C0", Offset = "0x4B3D3C0", VA = "0x184B3E7C0")]
		private static uint G(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00011EC8 File Offset: 0x000100C8
		[Token(Token = "0x60019F3")]
		[Address(RVA = "0x4B3E7D0", Offset = "0x4B3D3D0", VA = "0x184B3E7D0")]
		private static uint H(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00011EE0 File Offset: 0x000100E0
		[Token(Token = "0x60019F4")]
		[Address(RVA = "0x4B3E800", Offset = "0x4B3D400", VA = "0x184B3E800")]
		private static uint I(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00011EF8 File Offset: 0x000100F8
		[Token(Token = "0x60019F5")]
		[Address(RVA = "0x4B3E8F0", Offset = "0x4B3D4F0", VA = "0x184B3E8F0")]
		private static uint J(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x04000E15 RID: 3605
		[Token(Token = "0x4000E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		// Token: 0x04000E16 RID: 3606
		[Token(Token = "0x4000E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long _count;

		// Token: 0x04000E17 RID: 3607
		[Token(Token = "0x4000E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private uint[] _stateMD160;

		// Token: 0x04000E18 RID: 3608
		[Token(Token = "0x4000E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private uint[] _blockDWords;
	}
}
