using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000323 RID: 803
	[Token(Token = "0x2000323")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class SHA384Managed : SHA384
	{
		// Token: 0x06001A93 RID: 6803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x4B4D310", Offset = "0x4B4BF10", VA = "0x184B4D310")]
		public SHA384Managed()
		{
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A94")]
		[Address(RVA = "0x4B4BDC0", Offset = "0x4B4A9C0", VA = "0x184B4BDC0", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x4B4BC70", Offset = "0x4B4A870", VA = "0x184B4BC70", Slot = "18")]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x4B4BC80", Offset = "0x4B4A880", VA = "0x184B4BC80", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x4B4BC90", Offset = "0x4B4A890", VA = "0x184B4BC90")]
		private void InitializeState()
		{
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x4B4D0A0", Offset = "0x4B4BCA0", VA = "0x184B4D0A0")]
		private void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x4B4CDA0", Offset = "0x4B4B9A0", VA = "0x184B4CDA0")]
		private byte[] _EndHash()
		{
			return null;
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x4B4BFA0", Offset = "0x4B4ABA0", VA = "0x184B4BFA0")]
		private unsafe static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block)
		{
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00012240 File Offset: 0x00010440
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x4B4BE20", Offset = "0x4B4AA20", VA = "0x184B4BE20")]
		private static ulong RotateRight(ulong x, int n)
		{
			return 0UL;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00012258 File Offset: 0x00010458
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x4B4BC60", Offset = "0x4B4A860", VA = "0x184B4BC60")]
		private static ulong Ch(ulong x, ulong y, ulong z)
		{
			return 0UL;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00012270 File Offset: 0x00010470
		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0x4B4BE10", Offset = "0x4B4AA10", VA = "0x184B4BE10")]
		private static ulong Maj(ulong x, ulong y, ulong z)
		{
			return 0UL;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00012288 File Offset: 0x00010488
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x4B4CCA0", Offset = "0x4B4B8A0", VA = "0x184B4CCA0")]
		private static ulong Sigma_0(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x000122A0 File Offset: 0x000104A0
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x4B4CD20", Offset = "0x4B4B920", VA = "0x184B4CD20")]
		private static ulong Sigma_1(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x000122B8 File Offset: 0x000104B8
		[Token(Token = "0x6001AA0")]
		[Address(RVA = "0x4B4D3F0", Offset = "0x4B4BFF0", VA = "0x184B4D3F0")]
		private static ulong sigma_0(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x000122D0 File Offset: 0x000104D0
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x4B4D460", Offset = "0x4B4C060", VA = "0x184B4D460")]
		private static ulong sigma_1(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x4B4BE40", Offset = "0x4B4AA40", VA = "0x184B4BE40")]
		private unsafe static void SHA384Expand(ulong* x)
		{
		}

		// Token: 0x04000E40 RID: 3648
		[Token(Token = "0x4000E40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		// Token: 0x04000E41 RID: 3649
		[Token(Token = "0x4000E41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ulong _count;

		// Token: 0x04000E42 RID: 3650
		[Token(Token = "0x4000E42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ulong[] _stateSHA384;

		// Token: 0x04000E43 RID: 3651
		[Token(Token = "0x4000E43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ulong[] _W;

		// Token: 0x04000E44 RID: 3652
		[Token(Token = "0x4000E44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ulong[] _K;
	}
}
