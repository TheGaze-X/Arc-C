using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	public static class FastBitConverter
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x3699AC0", Offset = "0x36986C0", VA = "0x183699AC0")]
		private static void WriteLittleEndian(byte[] buffer, int offset, ulong data)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x36999D0", Offset = "0x36985D0", VA = "0x1836999D0")]
		private static void WriteLittleEndian(byte[] buffer, int offset, int data)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x3699990", Offset = "0x3698590", VA = "0x183699990")]
		public static void WriteLittleEndian(byte[] buffer, int offset, short data)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x3699970", Offset = "0x3698570", VA = "0x183699970")]
		public static void GetBytes(byte[] bytes, int startIndex, double value)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x3699A50", Offset = "0x3698650", VA = "0x183699A50")]
		public static void GetBytes(byte[] bytes, int startIndex, float value)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x3699990", Offset = "0x3698590", VA = "0x183699990")]
		public static void GetBytes(byte[] bytes, int startIndex, short value)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x3699990", Offset = "0x3698590", VA = "0x183699990")]
		public static void GetBytes(byte[] bytes, int startIndex, ushort value)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x36999D0", Offset = "0x36985D0", VA = "0x1836999D0")]
		public static void GetBytes(byte[] bytes, int startIndex, int value)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x36999D0", Offset = "0x36985D0", VA = "0x1836999D0")]
		public static void GetBytes(byte[] bytes, int startIndex, uint value)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x3699A40", Offset = "0x3698640", VA = "0x183699A40")]
		public static void GetBytes(byte[] bytes, int startIndex, long value)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x3699A40", Offset = "0x3698640", VA = "0x183699A40")]
		public static void GetBytes(byte[] bytes, int startIndex, ulong value)
		{
		}

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x2000044")]
		[StructLayout(2)]
		private struct ConverterHelperDouble
		{
			// Token: 0x0400014F RID: 335
			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong Along;

			// Token: 0x04000150 RID: 336
			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double Adouble;
		}

		// Token: 0x02000045 RID: 69
		[Token(Token = "0x2000045")]
		[StructLayout(2)]
		private struct ConverterHelperFloat
		{
			// Token: 0x04000151 RID: 337
			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Aint;

			// Token: 0x04000152 RID: 338
			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float Afloat;
		}
	}
}
