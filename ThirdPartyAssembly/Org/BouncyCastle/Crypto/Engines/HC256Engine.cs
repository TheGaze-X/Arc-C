using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000336 RID: 822
	[Token(Token = "0x2000336")]
	public class HC256Engine : IStreamCipher
	{
		// Token: 0x06001BB5 RID: 7093 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x6001BB5")]
		[Address(RVA = "0x52C0460", Offset = "0x52BF060", VA = "0x1852C0460")]
		private uint Step()
		{
			return 0U;
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB6")]
		[Address(RVA = "0x52BF950", Offset = "0x52BE550", VA = "0x1852BF950")]
		private void Init()
		{
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D6")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001BB7")]
			[Address(RVA = "0x52C07A0", Offset = "0x52BF3A0", VA = "0x1852C07A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB8")]
		[Address(RVA = "0x52BFD80", Offset = "0x52BE980", VA = "0x1852BFD80", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0000D680 File Offset: 0x0000B880
		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x52BF8F0", Offset = "0x52BE4F0", VA = "0x1852BF8F0")]
		private byte GetByte()
		{
			return 0;
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0x52C0200", Offset = "0x52BEE00", VA = "0x1852C0200", Slot = "11")]
		public virtual void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBB")]
		[Address(RVA = "0x52C03E0", Offset = "0x52BEFE0", VA = "0x1852C03E0", Slot = "12")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0000D698 File Offset: 0x0000B898
		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0x52C03F0", Offset = "0x52BEFF0", VA = "0x1852C03F0", Slot = "13")]
		public virtual byte ReturnByte(byte input)
		{
			return 0;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0x4B4A670", Offset = "0x4B49270", VA = "0x184B4A670")]
		private static uint RotateRight(uint x, int bits)
		{
			return 0U;
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x52C0700", Offset = "0x52BF300", VA = "0x1852C0700")]
		public HC256Engine()
		{
		}

		// Token: 0x04000EE6 RID: 3814
		[Token(Token = "0x4000EE6")]
		[FieldOffset(Offset = "0x10")]
		private uint[] p;

		// Token: 0x04000EE7 RID: 3815
		[Token(Token = "0x4000EE7")]
		[FieldOffset(Offset = "0x18")]
		private uint[] q;

		// Token: 0x04000EE8 RID: 3816
		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x20")]
		private uint cnt;

		// Token: 0x04000EE9 RID: 3817
		[Token(Token = "0x4000EE9")]
		[FieldOffset(Offset = "0x28")]
		private byte[] key;

		// Token: 0x04000EEA RID: 3818
		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x30")]
		private byte[] iv;

		// Token: 0x04000EEB RID: 3819
		[Token(Token = "0x4000EEB")]
		[FieldOffset(Offset = "0x38")]
		private bool initialised;

		// Token: 0x04000EEC RID: 3820
		[Token(Token = "0x4000EEC")]
		[FieldOffset(Offset = "0x40")]
		private byte[] buf;

		// Token: 0x04000EED RID: 3821
		[Token(Token = "0x4000EED")]
		[FieldOffset(Offset = "0x48")]
		private int idx;
	}
}
