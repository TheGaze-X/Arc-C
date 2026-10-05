using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000230 RID: 560
	[Token(Token = "0x2000230")]
	public abstract class PbeParametersGenerator
	{
		// Token: 0x06001364 RID: 4964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001364")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected PbeParametersGenerator()
		{
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x524C9E0", Offset = "0x524B5E0", VA = "0x18524C9E0", Slot = "4")]
		public virtual void Init(byte[] password, byte[] salt, int iterationCount)
		{
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B3")]
		public virtual byte[] Password
		{
			[Token(Token = "0x6001366")]
			[Address(RVA = "0x524CEA0", Offset = "0x524BAA0", VA = "0x18524CEA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001367")]
		[Address(RVA = "0x4FEC330", Offset = "0x4FEAF30", VA = "0x184FEC330")]
		[Obsolete("Use 'Password' property")]
		public byte[] GetPassword()
		{
			return null;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B4")]
		public virtual byte[] Salt
		{
			[Token(Token = "0x6001368")]
			[Address(RVA = "0x524CEB0", Offset = "0x524BAB0", VA = "0x18524CEB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001369")]
		[Address(RVA = "0x4FA9390", Offset = "0x4FA7F90", VA = "0x184FA9390")]
		[Obsolete("Use 'Salt' property")]
		public byte[] GetSalt()
		{
			return null;
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0000A7A0 File Offset: 0x000089A0
		[Token(Token = "0x170002B5")]
		public virtual int IterationCount
		{
			[Token(Token = "0x600136A")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600136B RID: 4971
		[Token(Token = "0x600136B")]
		[Obsolete("Use version with 'algorithm' parameter")]
		public abstract ICipherParameters GenerateDerivedParameters(int keySize);

		// Token: 0x0600136C RID: 4972
		[Token(Token = "0x600136C")]
		public abstract ICipherParameters GenerateDerivedParameters(string algorithm, int keySize);

		// Token: 0x0600136D RID: 4973
		[Token(Token = "0x600136D")]
		[Obsolete("Use version with 'algorithm' parameter")]
		public abstract ICipherParameters GenerateDerivedParameters(int keySize, int ivSize);

		// Token: 0x0600136E RID: 4974
		[Token(Token = "0x600136E")]
		public abstract ICipherParameters GenerateDerivedParameters(string algorithm, int keySize, int ivSize);

		// Token: 0x0600136F RID: 4975
		[Token(Token = "0x600136F")]
		public abstract ICipherParameters GenerateDerivedMacParameters(int keySize);

		// Token: 0x06001370 RID: 4976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x524CCE0", Offset = "0x524B8E0", VA = "0x18524CCE0")]
		public static byte[] Pkcs5PasswordToBytes(char[] password)
		{
			return null;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x524CD30", Offset = "0x524B930", VA = "0x18524CD30")]
		[Obsolete("Use version taking 'char[]' instead")]
		public static byte[] Pkcs5PasswordToBytes(string password)
		{
			return null;
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x524CD80", Offset = "0x524B980", VA = "0x18524CD80")]
		public static byte[] Pkcs5PasswordToUtf8Bytes(char[] password)
		{
			return null;
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x524CE10", Offset = "0x524BA10", VA = "0x18524CE10")]
		[Obsolete("Use version taking 'char[]' instead")]
		public static byte[] Pkcs5PasswordToUtf8Bytes(string password)
		{
			return null;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x524CAF0", Offset = "0x524B6F0", VA = "0x18524CAF0")]
		public static byte[] Pkcs12PasswordToBytes(char[] password)
		{
			return null;
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x524CBF0", Offset = "0x524B7F0", VA = "0x18524CBF0")]
		public static byte[] Pkcs12PasswordToBytes(char[] password, bool wrongPkcs12Zero)
		{
			return null;
		}

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x10")]
		protected byte[] mPassword;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x18")]
		protected byte[] mSalt;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x20")]
		protected int mIterationCount;
	}
}
