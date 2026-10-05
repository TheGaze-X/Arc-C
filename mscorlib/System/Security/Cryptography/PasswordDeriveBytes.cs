using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200030C RID: 780
	[Token(Token = "0x200030C")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class PasswordDeriveBytes : DeriveBytes
	{
		// Token: 0x0600198B RID: 6539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198B")]
		[Address(RVA = "0x4B30B90", Offset = "0x4B2F790", VA = "0x184B30B90")]
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt)
		{
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198C")]
		[Address(RVA = "0x4B30730", Offset = "0x4B2F330", VA = "0x184B30730")]
		public PasswordDeriveBytes(byte[] password, byte[] salt)
		{
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198D")]
		[Address(RVA = "0x4B30640", Offset = "0x4B2F240", VA = "0x184B30640")]
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations)
		{
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x4B30900", Offset = "0x4B2F500", VA = "0x184B30900")]
		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations)
		{
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x4B30C90", Offset = "0x4B2F890", VA = "0x184B30C90")]
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, CspParameters cspParams)
		{
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001990")]
		[Address(RVA = "0x4B30D10", Offset = "0x4B2F910", VA = "0x184B30D10")]
		public PasswordDeriveBytes(byte[] password, byte[] salt, CspParameters cspParams)
		{
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x4B30830", Offset = "0x4B2F430", VA = "0x184B30830")]
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations, CspParameters cspParams)
		{
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001992")]
		[Address(RVA = "0x4B309F0", Offset = "0x4B2F5F0", VA = "0x184B309F0")]
		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations, CspParameters cspParams)
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BD")]
		public string HashName
		{
			[Token(Token = "0x6001993")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001994")]
			[Address(RVA = "0x4B30E10", Offset = "0x4B2FA10", VA = "0x184B30E10")]
			set
			{
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BE")]
		public int IterationCount
		{
			[Token(Token = "0x6001995")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001996")]
			[Address(RVA = "0x4B31050", Offset = "0x4B2FC50", VA = "0x184B31050")]
			set
			{
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BF")]
		public byte[] Salt
		{
			[Token(Token = "0x6001997")]
			[Address(RVA = "0x4B30D90", Offset = "0x4B2F990", VA = "0x184B30D90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001998")]
			[Address(RVA = "0x4B311A0", Offset = "0x4B2FDA0", VA = "0x184B311A0")]
			set
			{
			}
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001999")]
		[Address(RVA = "0x4B30270", Offset = "0x4B2EE70", VA = "0x184B30270", Slot = "5")]
		[System.Obsolete("Rfc2898DeriveBytes replaces PasswordDeriveBytes for deriving key material from a password and is preferred in new applications.")]
		public override byte[] GetBytes(int cb)
		{
			return null;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600199A")]
		[Address(RVA = "0x4B30600", Offset = "0x4B2F200", VA = "0x184B30600", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600199B")]
		[Address(RVA = "0x4B30180", Offset = "0x4B2ED80", VA = "0x184B30180", Slot = "7")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600199C")]
		[Address(RVA = "0x4B300B0", Offset = "0x4B2ECB0", VA = "0x184B300B0")]
		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600199D")]
		[Address(RVA = "0x4B2F860", Offset = "0x4B2E460", VA = "0x184B2F860")]
		private byte[] ComputeBaseValue()
		{
			return null;
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600199E")]
		[Address(RVA = "0x4B2FBE0", Offset = "0x4B2E7E0", VA = "0x184B2FBE0")]
		private byte[] ComputeBytes(int cb)
		{
			return null;
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600199F")]
		[Address(RVA = "0x4B30420", Offset = "0x4B2F020", VA = "0x184B30420")]
		private void HashPrefix(CryptoStream cs)
		{
		}

		// Token: 0x04000DE9 RID: 3561
		[Token(Token = "0x4000DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _extraCount;

		// Token: 0x04000DEA RID: 3562
		[Token(Token = "0x4000DEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _prefix;

		// Token: 0x04000DEB RID: 3563
		[Token(Token = "0x4000DEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _iterations;

		// Token: 0x04000DEC RID: 3564
		[Token(Token = "0x4000DEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] _baseValue;

		// Token: 0x04000DED RID: 3565
		[Token(Token = "0x4000DED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _extra;

		// Token: 0x04000DEE RID: 3566
		[Token(Token = "0x4000DEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] _salt;

		// Token: 0x04000DEF RID: 3567
		[Token(Token = "0x4000DEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _hashName;

		// Token: 0x04000DF0 RID: 3568
		[Token(Token = "0x4000DF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte[] _password;

		// Token: 0x04000DF1 RID: 3569
		[Token(Token = "0x4000DF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HashAlgorithm _hash;
	}
}
