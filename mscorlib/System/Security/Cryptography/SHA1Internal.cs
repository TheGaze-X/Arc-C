using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200033D RID: 829
	[Token(Token = "0x200033D")]
	internal class SHA1Internal
	{
		// Token: 0x06001B86 RID: 7046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x4B685C0", Offset = "0x4B671C0", VA = "0x184B685C0")]
		public SHA1Internal()
		{
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x4B67360", Offset = "0x4B65F60", VA = "0x184B67360")]
		public void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x4B67480", Offset = "0x4B66080", VA = "0x184B67480")]
		public byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x4B67C50", Offset = "0x4B66850", VA = "0x184B67C50")]
		public void Initialize()
		{
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x4B67CE0", Offset = "0x4B668E0", VA = "0x184B67CE0")]
		private void ProcessBlock(byte[] inputBuffer, uint inputOffset)
		{
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x4B67570", Offset = "0x4B66170", VA = "0x184B67570")]
		private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset)
		{
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x4B67000", Offset = "0x4B65C00", VA = "0x184B67000")]
		private static void FillBuff(uint[] buff)
		{
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x4B683A0", Offset = "0x4B66FA0", VA = "0x184B683A0")]
		private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x4B66F20", Offset = "0x4B65B20", VA = "0x184B66F20")]
		internal void AddLength(ulong length, byte[] buffer, int position)
		{
		}

		// Token: 0x04000ED2 RID: 3794
		[Token(Token = "0x4000ED2")]
		private const int BLOCK_SIZE_BYTES = 64;

		// Token: 0x04000ED3 RID: 3795
		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0x10")]
		private uint[] _H;

		// Token: 0x04000ED4 RID: 3796
		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x18")]
		private ulong count;

		// Token: 0x04000ED5 RID: 3797
		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x20")]
		private byte[] _ProcessingBuffer;

		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x28")]
		private int _ProcessingBufferCount;

		// Token: 0x04000ED7 RID: 3799
		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x30")]
		private uint[] buff;
	}
}
