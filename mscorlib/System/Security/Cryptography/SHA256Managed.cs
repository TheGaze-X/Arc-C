using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000321 RID: 801
	[Token(Token = "0x2000321")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class SHA256Managed : SHA256
	{
		// Token: 0x06001A7F RID: 6783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x4B4B940", Offset = "0x4B4A540", VA = "0x184B4B940")]
		public SHA256Managed()
		{
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x4B4A610", Offset = "0x4B49210", VA = "0x184B4A610", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x4B4A500", Offset = "0x4B49100", VA = "0x184B4A500", Slot = "18")]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x4B4A510", Offset = "0x4B49110", VA = "0x184B4A510", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x4B4A520", Offset = "0x4B49120", VA = "0x184B4A520")]
		private void InitializeState()
		{
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A84")]
		[Address(RVA = "0x4B4B6D0", Offset = "0x4B4A2D0", VA = "0x184B4B6D0")]
		private void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A85")]
		[Address(RVA = "0x4B4B470", Offset = "0x4B4A070", VA = "0x184B4B470")]
		private byte[] _EndHash()
		{
			return null;
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A86")]
		[Address(RVA = "0x4B4A7D0", Offset = "0x4B493D0", VA = "0x184B4A7D0")]
		private unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
		{
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00012198 File Offset: 0x00010398
		[Token(Token = "0x6001A87")]
		[Address(RVA = "0x4B4A670", Offset = "0x4B49270", VA = "0x184B4A670")]
		private static uint RotateRight(uint x, int n)
		{
			return 0U;
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x000121B0 File Offset: 0x000103B0
		[Token(Token = "0x6001A88")]
		[Address(RVA = "0x4B4A4F0", Offset = "0x4B490F0", VA = "0x184B4A4F0")]
		private static uint Ch(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000121C8 File Offset: 0x000103C8
		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x4B4A660", Offset = "0x4B49260", VA = "0x184B4A660")]
		private static uint Maj(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000121E0 File Offset: 0x000103E0
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x4B4BA20", Offset = "0x4B4A620", VA = "0x184B4BA20")]
		private static uint sigma_0(uint x)
		{
			return 0U;
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x000121F8 File Offset: 0x000103F8
		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x4B4BA80", Offset = "0x4B4A680", VA = "0x184B4BA80")]
		private static uint sigma_1(uint x)
		{
			return 0U;
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00012210 File Offset: 0x00010410
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x4B4B390", Offset = "0x4B49F90", VA = "0x184B4B390")]
		private static uint Sigma_0(uint x)
		{
			return 0U;
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00012228 File Offset: 0x00010428
		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x4B4B400", Offset = "0x4B4A000", VA = "0x184B4B400")]
		private static uint Sigma_1(uint x)
		{
			return 0U;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0x4B4A690", Offset = "0x4B49290", VA = "0x184B4A690")]
		private unsafe static void SHA256Expand(uint* x)
		{
		}

		// Token: 0x04000E3B RID: 3643
		[Token(Token = "0x4000E3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		// Token: 0x04000E3C RID: 3644
		[Token(Token = "0x4000E3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long _count;

		// Token: 0x04000E3D RID: 3645
		[Token(Token = "0x4000E3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private uint[] _stateSHA256;

		// Token: 0x04000E3E RID: 3646
		[Token(Token = "0x4000E3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private uint[] _W;

		// Token: 0x04000E3F RID: 3647
		[Token(Token = "0x4000E3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly uint[] _K;
	}
}
