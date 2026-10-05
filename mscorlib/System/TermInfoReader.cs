using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	internal class TermInfoReader
	{
		// Token: 0x060010A2 RID: 4258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x4D5C6C0", Offset = "0x4D5B2C0", VA = "0x184D5C6C0")]
		public TermInfoReader(string term, string filename)
		{
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x4D5C600", Offset = "0x4D5B200", VA = "0x184D5C600")]
		public TermInfoReader(string term, byte[] buffer)
		{
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x4D5BCC0", Offset = "0x4D5A8C0", VA = "0x184D5BCC0")]
		private void DetermineVersion(short magic)
		{
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x4D5C2C0", Offset = "0x4D5AEC0", VA = "0x184D5C2C0")]
		private void ReadHeader(byte[] buffer, ref int position)
		{
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x4D5C530", Offset = "0x4D5B130", VA = "0x184D5C530")]
		private void ReadNames(byte[] buffer, ref int position)
		{
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		[Token(Token = "0x60010A7")]
		[Address(RVA = "0x4D5C200", Offset = "0x4D5AE00", VA = "0x184D5C200")]
		public int Get(TermInfoNumbers number)
		{
			return 0;
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010A8")]
		[Address(RVA = "0x4D5C0B0", Offset = "0x4D5ACB0", VA = "0x184D5C0B0")]
		public string Get(TermInfoStrings tstr)
		{
			return null;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x4D5BEA0", Offset = "0x4D5AAA0", VA = "0x184D5BEA0")]
		public byte[] GetStringBytes(TermInfoStrings tstr)
		{
			return null;
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x4D5BD90", Offset = "0x4D5A990", VA = "0x184D5BD90")]
		private short GetInt16(byte[] buffer, int offset)
		{
			return 0;
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x4D5C000", Offset = "0x4D5AC00", VA = "0x184D5C000")]
		private string GetString(byte[] buffer, int offset)
		{
			return null;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x4D5BDF0", Offset = "0x4D5A9F0", VA = "0x184D5BDF0")]
		private byte[] GetStringBytes(byte[] buffer, int offset)
		{
			return null;
		}

		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0x10")]
		private int boolSize;

		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x14")]
		private int numSize;

		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x18")]
		private int strOffsets;

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0x20")]
		private byte[] buffer;

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x28")]
		private int booleansOffset;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0x2C")]
		private int intOffset;
	}
}
