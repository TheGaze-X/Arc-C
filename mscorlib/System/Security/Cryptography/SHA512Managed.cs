using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000325 RID: 805
	[Token(Token = "0x2000325")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class SHA512Managed : SHA512
	{
		// Token: 0x06001AA7 RID: 6823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x4B4ECC0", Offset = "0x4B4D8C0", VA = "0x184B4ECC0")]
		public SHA512Managed()
		{
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x4B4D7A0", Offset = "0x4B4C3A0", VA = "0x184B4D7A0", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x4B4D650", Offset = "0x4B4C250", VA = "0x184B4D650", Slot = "18")]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x4B4D660", Offset = "0x4B4C260", VA = "0x184B4D660", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0x4B4D670", Offset = "0x4B4C270", VA = "0x184B4D670")]
		private void InitializeState()
		{
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x4B4EA50", Offset = "0x4B4D650", VA = "0x184B4EA50")]
		private void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0x4B4E750", Offset = "0x4B4D350", VA = "0x184B4E750")]
		private byte[] _EndHash()
		{
			return null;
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0x4B4D950", Offset = "0x4B4C550", VA = "0x184B4D950")]
		private unsafe static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block)
		{
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x000122E8 File Offset: 0x000104E8
		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x4B4BE20", Offset = "0x4B4AA20", VA = "0x184B4BE20")]
		private static ulong RotateRight(ulong x, int n)
		{
			return 0UL;
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00012300 File Offset: 0x00010500
		[Token(Token = "0x6001AB0")]
		[Address(RVA = "0x4B4BC60", Offset = "0x4B4A860", VA = "0x184B4BC60")]
		private static ulong Ch(ulong x, ulong y, ulong z)
		{
			return 0UL;
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00012318 File Offset: 0x00010518
		[Token(Token = "0x6001AB1")]
		[Address(RVA = "0x4B4BE10", Offset = "0x4B4AA10", VA = "0x184B4BE10")]
		private static ulong Maj(ulong x, ulong y, ulong z)
		{
			return 0UL;
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00012330 File Offset: 0x00010530
		[Token(Token = "0x6001AB2")]
		[Address(RVA = "0x4B4E650", Offset = "0x4B4D250", VA = "0x184B4E650")]
		private static ulong Sigma_0(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00012348 File Offset: 0x00010548
		[Token(Token = "0x6001AB3")]
		[Address(RVA = "0x4B4E6D0", Offset = "0x4B4D2D0", VA = "0x184B4E6D0")]
		private static ulong Sigma_1(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00012360 File Offset: 0x00010560
		[Token(Token = "0x6001AB4")]
		[Address(RVA = "0x4B4EDA0", Offset = "0x4B4D9A0", VA = "0x184B4EDA0")]
		private static ulong sigma_0(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00012378 File Offset: 0x00010578
		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x4B4EE10", Offset = "0x4B4DA10", VA = "0x184B4EE10")]
		private static ulong sigma_1(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0x4B4D7F0", Offset = "0x4B4C3F0", VA = "0x184B4D7F0")]
		private unsafe static void SHA512Expand(ulong* x)
		{
		}

		// Token: 0x04000E45 RID: 3653
		[Token(Token = "0x4000E45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		// Token: 0x04000E46 RID: 3654
		[Token(Token = "0x4000E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ulong _count;

		// Token: 0x04000E47 RID: 3655
		[Token(Token = "0x4000E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ulong[] _stateSHA512;

		// Token: 0x04000E48 RID: 3656
		[Token(Token = "0x4000E48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ulong[] _W;

		// Token: 0x04000E49 RID: 3657
		[Token(Token = "0x4000E49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ulong[] _K;
	}
}
