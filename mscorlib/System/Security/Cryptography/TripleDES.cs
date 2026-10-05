using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200032E RID: 814
	[Token(Token = "0x200032E")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class TripleDES : SymmetricAlgorithm
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x4B51050", Offset = "0x4B4FC50", VA = "0x184B51050")]
		protected TripleDES()
		{
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001AEC RID: 6892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EC")]
		public override byte[] Key
		{
			[Token(Token = "0x6001AEB")]
			[Address(RVA = "0x4B51100", Offset = "0x4B4FD00", VA = "0x184B51100", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AEC")]
			[Address(RVA = "0x4B511E0", Offset = "0x4B4FDE0", VA = "0x184B511E0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x4B509A0", Offset = "0x4B4F5A0", VA = "0x184B509A0")]
		public new static TripleDES Create()
		{
			return null;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x4B50890", Offset = "0x4B4F490", VA = "0x184B50890")]
		public new static TripleDES Create(string str)
		{
			return null;
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00012420 File Offset: 0x00010620
		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0x4B50C60", Offset = "0x4B4F860", VA = "0x184B50C60")]
		public static bool IsWeakKey(byte[] rgbKey)
		{
			return default(bool);
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00012438 File Offset: 0x00010638
		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0x4B509F0", Offset = "0x4B4F5F0", VA = "0x184B509F0")]
		private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count)
		{
			return default(bool);
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00012450 File Offset: 0x00010650
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x4B50C40", Offset = "0x4B4F840", VA = "0x184B50C40")]
		private static bool IsLegalKeySize(byte[] rgbKey)
		{
			return default(bool);
		}

		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static KeySizes[] s_legalKeySizes;
	}
}
