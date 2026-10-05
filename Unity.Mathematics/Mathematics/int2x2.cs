using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct int2x2 : IEquatable<int2x2>, IFormattable
	{
		// Token: 0x06001897 RID: 6295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x1787730", Offset = "0x1786330", VA = "0x181787730")]
		[MethodImpl(256)]
		public int2x2(int2 c0, int2 c1)
		{
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x57D7A30", Offset = "0x57D6630", VA = "0x1857D7A30")]
		[MethodImpl(256)]
		public int2x2(int m00, int m01, int m10, int m11)
		{
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x57D7920", Offset = "0x57D6520", VA = "0x1857D7920")]
		[MethodImpl(256)]
		public int2x2(int v)
		{
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x57D79D0", Offset = "0x57D65D0", VA = "0x1857D79D0")]
		[MethodImpl(256)]
		public int2x2(bool v)
		{
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x56FEFF0", Offset = "0x56FDBF0", VA = "0x1856FEFF0")]
		[MethodImpl(256)]
		public int2x2(bool2x2 v)
		{
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x57D7920", Offset = "0x57D6520", VA = "0x1857D7920")]
		[MethodImpl(256)]
		public int2x2(uint v)
		{
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x57D7A60", Offset = "0x57D6660", VA = "0x1857D7A60")]
		[MethodImpl(256)]
		public int2x2(uint2x2 v)
		{
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x57D78B0", Offset = "0x57D64B0", VA = "0x1857D78B0")]
		[MethodImpl(256)]
		public int2x2(float v)
		{
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x57D7980", Offset = "0x57D6580", VA = "0x1857D7980")]
		[MethodImpl(256)]
		public int2x2(float2x2 v)
		{
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x57D7950", Offset = "0x57D6550", VA = "0x1857D7950")]
		[MethodImpl(256)]
		public int2x2(double v)
		{
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x57D78E0", Offset = "0x57D64E0", VA = "0x1857D78E0")]
		[MethodImpl(256)]
		public int2x2(double2x2 v)
		{
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00022170 File Offset: 0x00020370
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x57289E0", Offset = "0x57275E0", VA = "0x1857289E0")]
		[MethodImpl(256)]
		public static implicit operator int2x2(int v)
		{
			return default(int2x2);
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00022188 File Offset: 0x00020388
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x5728B40", Offset = "0x5727740", VA = "0x185728B40")]
		[MethodImpl(256)]
		public static explicit operator int2x2(bool v)
		{
			return default(int2x2);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x000221A0 File Offset: 0x000203A0
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x57D8120", Offset = "0x57D6D20", VA = "0x1857D8120")]
		[MethodImpl(256)]
		public static explicit operator int2x2(bool2x2 v)
		{
			return default(int2x2);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x000221B8 File Offset: 0x000203B8
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x57289E0", Offset = "0x57275E0", VA = "0x1857289E0")]
		[MethodImpl(256)]
		public static explicit operator int2x2(uint v)
		{
			return default(int2x2);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x000221D0 File Offset: 0x000203D0
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x5728AC0", Offset = "0x57276C0", VA = "0x185728AC0")]
		[MethodImpl(256)]
		public static explicit operator int2x2(uint2x2 v)
		{
			return default(int2x2);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x000221E8 File Offset: 0x000203E8
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x5728A90", Offset = "0x5727690", VA = "0x185728A90")]
		[MethodImpl(256)]
		public static explicit operator int2x2(float v)
		{
			return default(int2x2);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00022200 File Offset: 0x00020400
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x5728990", Offset = "0x5727590", VA = "0x185728990")]
		[MethodImpl(256)]
		public static explicit operator int2x2(float2x2 v)
		{
			return default(int2x2);
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00022218 File Offset: 0x00020418
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x5728B10", Offset = "0x5727710", VA = "0x185728B10")]
		[MethodImpl(256)]
		public static explicit operator int2x2(double v)
		{
			return default(int2x2);
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00022230 File Offset: 0x00020430
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x5728A40", Offset = "0x5727640", VA = "0x185728A40")]
		[MethodImpl(256)]
		public static explicit operator int2x2(double2x2 v)
		{
			return default(int2x2);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00022248 File Offset: 0x00020448
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x57D8810", Offset = "0x57D7410", VA = "0x1857D8810")]
		[MethodImpl(256)]
		public static int2x2 operator *(int2x2 lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00022260 File Offset: 0x00020460
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x57D88C0", Offset = "0x57D74C0", VA = "0x1857D88C0")]
		[MethodImpl(256)]
		public static int2x2 operator *(int2x2 lhs, int rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00022278 File Offset: 0x00020478
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x57D8870", Offset = "0x57D7470", VA = "0x1857D8870")]
		[MethodImpl(256)]
		public static int2x2 operator *(int lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00022290 File Offset: 0x00020490
		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x57D7AF0", Offset = "0x57D66F0", VA = "0x1857D7AF0")]
		[MethodImpl(256)]
		public static int2x2 operator +(int2x2 lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x000222A8 File Offset: 0x000204A8
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x57D7B50", Offset = "0x57D6750", VA = "0x1857D7B50")]
		[MethodImpl(256)]
		public static int2x2 operator +(int2x2 lhs, int rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x000222C0 File Offset: 0x000204C0
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x57D7AA0", Offset = "0x57D66A0", VA = "0x1857D7AA0")]
		[MethodImpl(256)]
		public static int2x2 operator +(int lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x000222D8 File Offset: 0x000204D8
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x57D8A00", Offset = "0x57D7600", VA = "0x1857D8A00")]
		[MethodImpl(256)]
		public static int2x2 operator -(int2x2 lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x000222F0 File Offset: 0x000204F0
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x57D8A60", Offset = "0x57D7660", VA = "0x1857D8A60")]
		[MethodImpl(256)]
		public static int2x2 operator -(int2x2 lhs, int rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00022308 File Offset: 0x00020508
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x57D89B0", Offset = "0x57D75B0", VA = "0x1857D89B0")]
		[MethodImpl(256)]
		public static int2x2 operator -(int lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00022320 File Offset: 0x00020520
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x57D7EB0", Offset = "0x57D6AB0", VA = "0x1857D7EB0")]
		[MethodImpl(256)]
		public static int2x2 operator /(int2x2 lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00022338 File Offset: 0x00020538
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x57D7E50", Offset = "0x57D6A50", VA = "0x1857D7E50")]
		[MethodImpl(256)]
		public static int2x2 operator /(int2x2 lhs, int rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00022350 File Offset: 0x00020550
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x57D7DF0", Offset = "0x57D69F0", VA = "0x1857D7DF0")]
		[MethodImpl(256)]
		public static int2x2 operator /(int lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00022368 File Offset: 0x00020568
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x57D87A0", Offset = "0x57D73A0", VA = "0x1857D87A0")]
		[MethodImpl(256)]
		public static int2x2 operator %(int2x2 lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00022380 File Offset: 0x00020580
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x57D86E0", Offset = "0x57D72E0", VA = "0x1857D86E0")]
		[MethodImpl(256)]
		public static int2x2 operator %(int2x2 lhs, int rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00022398 File Offset: 0x00020598
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x57D8740", Offset = "0x57D7340", VA = "0x1857D8740")]
		[MethodImpl(256)]
		public static int2x2 operator %(int lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000223B0 File Offset: 0x000205B0
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x57D8340", Offset = "0x57D6F40", VA = "0x1857D8340")]
		[MethodImpl(256)]
		public static int2x2 operator ++(int2x2 val)
		{
			return default(int2x2);
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x000223C8 File Offset: 0x000205C8
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x57D7DA0", Offset = "0x57D69A0", VA = "0x1857D7DA0")]
		[MethodImpl(256)]
		public static int2x2 operator --(int2x2 val)
		{
			return default(int2x2);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x000223E0 File Offset: 0x000205E0
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x57D8630", Offset = "0x57D7230", VA = "0x1857D8630")]
		[MethodImpl(256)]
		public static bool2x2 operator <(int2x2 lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x000223F8 File Offset: 0x000205F8
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x57D8690", Offset = "0x57D7290", VA = "0x1857D8690")]
		[MethodImpl(256)]
		public static bool2x2 operator <(int2x2 lhs, int rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00022410 File Offset: 0x00020610
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x57D85E0", Offset = "0x57D71E0", VA = "0x1857D85E0")]
		[MethodImpl(256)]
		public static bool2x2 operator <(int lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00022428 File Offset: 0x00020628
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x57D84E0", Offset = "0x57D70E0", VA = "0x1857D84E0")]
		[MethodImpl(256)]
		public static bool2x2 operator <=(int2x2 lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00022440 File Offset: 0x00020640
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x57D8590", Offset = "0x57D7190", VA = "0x1857D8590")]
		[MethodImpl(256)]
		public static bool2x2 operator <=(int2x2 lhs, int rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00022458 File Offset: 0x00020658
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x57D8540", Offset = "0x57D7140", VA = "0x1857D8540")]
		[MethodImpl(256)]
		public static bool2x2 operator <=(int lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00022470 File Offset: 0x00020670
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x57D8240", Offset = "0x57D6E40", VA = "0x1857D8240")]
		[MethodImpl(256)]
		public static bool2x2 operator >(int2x2 lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00022488 File Offset: 0x00020688
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x57D82A0", Offset = "0x57D6EA0", VA = "0x1857D82A0")]
		[MethodImpl(256)]
		public static bool2x2 operator >(int2x2 lhs, int rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x000224A0 File Offset: 0x000206A0
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x57D82F0", Offset = "0x57D6EF0", VA = "0x1857D82F0")]
		[MethodImpl(256)]
		public static bool2x2 operator >(int lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000224B8 File Offset: 0x000206B8
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x57D81E0", Offset = "0x57D6DE0", VA = "0x1857D81E0")]
		[MethodImpl(256)]
		public static bool2x2 operator >=(int2x2 lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x000224D0 File Offset: 0x000206D0
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x57D8140", Offset = "0x57D6D40", VA = "0x1857D8140")]
		[MethodImpl(256)]
		public static bool2x2 operator >=(int2x2 lhs, int rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x000224E8 File Offset: 0x000206E8
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x57D8190", Offset = "0x57D6D90", VA = "0x1857D8190")]
		[MethodImpl(256)]
		public static bool2x2 operator >=(int lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00022500 File Offset: 0x00020700
		[Token(Token = "0x60018C8")]
		[Address(RVA = "0x57D8AB0", Offset = "0x57D76B0", VA = "0x1857D8AB0")]
		[MethodImpl(256)]
		public static int2x2 operator -(int2x2 val)
		{
			return default(int2x2);
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00022518 File Offset: 0x00020718
		[Token(Token = "0x60018C9")]
		[Address(RVA = "0x57D8B00", Offset = "0x57D7700", VA = "0x1857D8B00")]
		[MethodImpl(256)]
		public static int2x2 operator +(int2x2 val)
		{
			return default(int2x2);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00022530 File Offset: 0x00020730
		[Token(Token = "0x60018CA")]
		[Address(RVA = "0x57D8490", Offset = "0x57D7090", VA = "0x1857D8490")]
		[MethodImpl(256)]
		public static int2x2 operator <<(int2x2 x, int n)
		{
			return default(int2x2);
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x00022548 File Offset: 0x00020748
		[Token(Token = "0x60018CB")]
		[Address(RVA = "0x57D8960", Offset = "0x57D7560", VA = "0x1857D8960")]
		[MethodImpl(256)]
		public static int2x2 operator >>(int2x2 x, int n)
		{
			return default(int2x2);
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x00022560 File Offset: 0x00020760
		[Token(Token = "0x60018CC")]
		[Address(RVA = "0x57D7F70", Offset = "0x57D6B70", VA = "0x1857D7F70")]
		[MethodImpl(256)]
		public static bool2x2 operator ==(int2x2 lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00022578 File Offset: 0x00020778
		[Token(Token = "0x60018CD")]
		[Address(RVA = "0x57D7FD0", Offset = "0x57D6BD0", VA = "0x1857D7FD0")]
		[MethodImpl(256)]
		public static bool2x2 operator ==(int2x2 lhs, int rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00022590 File Offset: 0x00020790
		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x57D7F20", Offset = "0x57D6B20", VA = "0x1857D7F20")]
		[MethodImpl(256)]
		public static bool2x2 operator ==(int lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x000225A8 File Offset: 0x000207A8
		[Token(Token = "0x60018CF")]
		[Address(RVA = "0x57D8390", Offset = "0x57D6F90", VA = "0x1857D8390")]
		[MethodImpl(256)]
		public static bool2x2 operator !=(int2x2 lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x000225C0 File Offset: 0x000207C0
		[Token(Token = "0x60018D0")]
		[Address(RVA = "0x57D8440", Offset = "0x57D7040", VA = "0x1857D8440")]
		[MethodImpl(256)]
		public static bool2x2 operator !=(int2x2 lhs, int rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x000225D8 File Offset: 0x000207D8
		[Token(Token = "0x60018D1")]
		[Address(RVA = "0x57D83F0", Offset = "0x57D6FF0", VA = "0x1857D83F0")]
		[MethodImpl(256)]
		public static bool2x2 operator !=(int lhs, int2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x000225F0 File Offset: 0x000207F0
		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x57D8910", Offset = "0x57D7510", VA = "0x1857D8910")]
		[MethodImpl(256)]
		public static int2x2 operator ~(int2x2 val)
		{
			return default(int2x2);
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00022608 File Offset: 0x00020808
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x57D7C40", Offset = "0x57D6840", VA = "0x1857D7C40")]
		[MethodImpl(256)]
		public static int2x2 operator &(int2x2 lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00022620 File Offset: 0x00020820
		[Token(Token = "0x60018D4")]
		[Address(RVA = "0x57D7BF0", Offset = "0x57D67F0", VA = "0x1857D7BF0")]
		[MethodImpl(256)]
		public static int2x2 operator &(int2x2 lhs, int rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00022638 File Offset: 0x00020838
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x57D7BA0", Offset = "0x57D67A0", VA = "0x1857D7BA0")]
		[MethodImpl(256)]
		public static int2x2 operator &(int lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00022650 File Offset: 0x00020850
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x57D7CA0", Offset = "0x57D68A0", VA = "0x1857D7CA0")]
		[MethodImpl(256)]
		public static int2x2 operator |(int2x2 lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00022668 File Offset: 0x00020868
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x57D7D50", Offset = "0x57D6950", VA = "0x1857D7D50")]
		[MethodImpl(256)]
		public static int2x2 operator |(int2x2 lhs, int rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00022680 File Offset: 0x00020880
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x57D7D00", Offset = "0x57D6900", VA = "0x1857D7D00")]
		[MethodImpl(256)]
		public static int2x2 operator |(int lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00022698 File Offset: 0x00020898
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x57D8070", Offset = "0x57D6C70", VA = "0x1857D8070")]
		[MethodImpl(256)]
		public static int2x2 operator ^(int2x2 lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x000226B0 File Offset: 0x000208B0
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x57D8020", Offset = "0x57D6C20", VA = "0x1857D8020")]
		[MethodImpl(256)]
		public static int2x2 operator ^(int2x2 lhs, int rhs)
		{
			return default(int2x2);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x000226C8 File Offset: 0x000208C8
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x57D80D0", Offset = "0x57D6CD0", VA = "0x1857D80D0")]
		[MethodImpl(256)]
		public static int2x2 operator ^(int lhs, int2x2 rhs)
		{
			return default(int2x2);
		}

		// Token: 0x170007CD RID: 1997
		[Token(Token = "0x170007CD")]
		public int2 this[int index]
		{
			[Token(Token = "0x60018DC")]
			[Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000226E0 File Offset: 0x000208E0
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x57D7260", Offset = "0x57D5E60", VA = "0x1857D7260", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(int2x2 rhs)
		{
			return default(bool);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000226F8 File Offset: 0x000208F8
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x57D7290", Offset = "0x57D5E90", VA = "0x1857D7290", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00022710 File Offset: 0x00020910
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x57D7340", Offset = "0x57D5F40", VA = "0x1857D7340", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x57D7430", Offset = "0x57D6030", VA = "0x1857D7430", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x57D7630", Offset = "0x57D6230", VA = "0x1857D7630", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x0")]
		public int2 c0;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x8")]
		public int2 c1;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int2x2 identity;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int2x2 zero;
	}
}
