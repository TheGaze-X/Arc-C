using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct int2x3 : IEquatable<int2x3>, IFormattable
	{
		// Token: 0x060018E3 RID: 6371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x4C2F060", Offset = "0x4C2DC60", VA = "0x184C2F060")]
		[MethodImpl(256)]
		public int2x3(int2 c0, int2 c1, int2 c2)
		{
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x57D9450", Offset = "0x57D8050", VA = "0x1857D9450")]
		[MethodImpl(256)]
		public int2x3(int m00, int m01, int m02, int m10, int m11, int m12)
		{
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E5")]
		[Address(RVA = "0x57D93C0", Offset = "0x57D7FC0", VA = "0x1857D93C0")]
		[MethodImpl(256)]
		public int2x3(int v)
		{
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E6")]
		[Address(RVA = "0x56FF160", Offset = "0x56FDD60", VA = "0x1856FF160")]
		[MethodImpl(256)]
		public int2x3(bool v)
		{
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E7")]
		[Address(RVA = "0x56FF080", Offset = "0x56FDC80", VA = "0x1856FF080")]
		[MethodImpl(256)]
		public int2x3(bool2x3 v)
		{
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x57D93C0", Offset = "0x57D7FC0", VA = "0x1857D93C0")]
		[MethodImpl(256)]
		public int2x3(uint v)
		{
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x57D9400", Offset = "0x57D8000", VA = "0x1857D9400")]
		[MethodImpl(256)]
		public int2x3(uint2x3 v)
		{
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x57D9320", Offset = "0x57D7F20", VA = "0x1857D9320")]
		[MethodImpl(256)]
		public int2x3(float v)
		{
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x57D9360", Offset = "0x57D7F60", VA = "0x1857D9360")]
		[MethodImpl(256)]
		public int2x3(float2x3 v)
		{
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x57D9280", Offset = "0x57D7E80", VA = "0x1857D9280")]
		[MethodImpl(256)]
		public int2x3(double v)
		{
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x57D92C0", Offset = "0x57D7EC0", VA = "0x1857D92C0")]
		[MethodImpl(256)]
		public int2x3(double2x3 v)
		{
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00022728 File Offset: 0x00020928
		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x5728CC0", Offset = "0x57278C0", VA = "0x185728CC0")]
		[MethodImpl(256)]
		public static implicit operator int2x3(int v)
		{
			return default(int2x3);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00022740 File Offset: 0x00020940
		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x57D9E20", Offset = "0x57D8A20", VA = "0x1857D9E20")]
		[MethodImpl(256)]
		public static explicit operator int2x3(bool v)
		{
			return default(int2x3);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00022758 File Offset: 0x00020958
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x57D9E50", Offset = "0x57D8A50", VA = "0x1857D9E50")]
		[MethodImpl(256)]
		public static explicit operator int2x3(bool2x3 v)
		{
			return default(int2x3);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00022770 File Offset: 0x00020970
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x5728CC0", Offset = "0x57278C0", VA = "0x185728CC0")]
		[MethodImpl(256)]
		public static explicit operator int2x3(uint v)
		{
			return default(int2x3);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00022788 File Offset: 0x00020988
		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x5728C30", Offset = "0x5727830", VA = "0x185728C30")]
		[MethodImpl(256)]
		public static explicit operator int2x3(uint2x3 v)
		{
			return default(int2x3);
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x000227A0 File Offset: 0x000209A0
		[Token(Token = "0x60018F3")]
		[Address(RVA = "0x5728BA0", Offset = "0x57277A0", VA = "0x185728BA0")]
		[MethodImpl(256)]
		public static explicit operator int2x3(float v)
		{
			return default(int2x3);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x000227B8 File Offset: 0x000209B8
		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x5728F50", Offset = "0x5727B50", VA = "0x185728F50")]
		[MethodImpl(256)]
		public static explicit operator int2x3(float2x3 v)
		{
			return default(int2x3);
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x000227D0 File Offset: 0x000209D0
		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x5728D00", Offset = "0x5727900", VA = "0x185728D00")]
		[MethodImpl(256)]
		public static explicit operator int2x3(double v)
		{
			return default(int2x3);
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x000227E8 File Offset: 0x000209E8
		[Token(Token = "0x60018F6")]
		[Address(RVA = "0x5728E60", Offset = "0x5727A60", VA = "0x185728E60")]
		[MethodImpl(256)]
		public static explicit operator int2x3(double2x3 v)
		{
			return default(int2x3);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00022800 File Offset: 0x00020A00
		[Token(Token = "0x60018F7")]
		[Address(RVA = "0x57DA8E0", Offset = "0x57D94E0", VA = "0x1857DA8E0")]
		[MethodImpl(256)]
		public static int2x3 operator *(int2x3 lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00022818 File Offset: 0x00020A18
		[Token(Token = "0x60018F8")]
		[Address(RVA = "0x57DA7E0", Offset = "0x57D93E0", VA = "0x1857DA7E0")]
		[MethodImpl(256)]
		public static int2x3 operator *(int2x3 lhs, int rhs)
		{
			return default(int2x3);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00022830 File Offset: 0x00020A30
		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x57DA860", Offset = "0x57D9460", VA = "0x1857DA860")]
		[MethodImpl(256)]
		public static int2x3 operator *(int lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00022848 File Offset: 0x00020A48
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x57D9510", Offset = "0x57D8110", VA = "0x1857D9510")]
		[MethodImpl(256)]
		public static int2x3 operator +(int2x3 lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00022860 File Offset: 0x00020A60
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x57D95A0", Offset = "0x57D81A0", VA = "0x1857D95A0")]
		[MethodImpl(256)]
		public static int2x3 operator +(int2x3 lhs, int rhs)
		{
			return default(int2x3);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00022878 File Offset: 0x00020A78
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x57D94A0", Offset = "0x57D80A0", VA = "0x1857D94A0")]
		[MethodImpl(256)]
		public static int2x3 operator +(int lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00022890 File Offset: 0x00020A90
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x57DAAF0", Offset = "0x57D96F0", VA = "0x1857DAAF0")]
		[MethodImpl(256)]
		public static int2x3 operator -(int2x3 lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x000228A8 File Offset: 0x00020AA8
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x57DAB80", Offset = "0x57D9780", VA = "0x1857DAB80")]
		[MethodImpl(256)]
		public static int2x3 operator -(int2x3 lhs, int rhs)
		{
			return default(int2x3);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x000228C0 File Offset: 0x00020AC0
		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x57DAA70", Offset = "0x57D9670", VA = "0x1857DAA70")]
		[MethodImpl(256)]
		public static int2x3 operator -(int lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000228D8 File Offset: 0x00020AD8
		[Token(Token = "0x6001900")]
		[Address(RVA = "0x57D9990", Offset = "0x57D8590", VA = "0x1857D9990")]
		[MethodImpl(256)]
		public static int2x3 operator /(int2x3 lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x000228F0 File Offset: 0x00020AF0
		[Token(Token = "0x6001901")]
		[Address(RVA = "0x57D9AC0", Offset = "0x57D86C0", VA = "0x1857D9AC0")]
		[MethodImpl(256)]
		public static int2x3 operator /(int2x3 lhs, int rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00022908 File Offset: 0x00020B08
		[Token(Token = "0x6001902")]
		[Address(RVA = "0x57D9A30", Offset = "0x57D8630", VA = "0x1857D9A30")]
		[MethodImpl(256)]
		public static int2x3 operator /(int lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00022920 File Offset: 0x00020B20
		[Token(Token = "0x6001903")]
		[Address(RVA = "0x57DA6B0", Offset = "0x57D92B0", VA = "0x1857DA6B0")]
		[MethodImpl(256)]
		public static int2x3 operator %(int2x3 lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00022938 File Offset: 0x00020B38
		[Token(Token = "0x6001904")]
		[Address(RVA = "0x57DA750", Offset = "0x57D9350", VA = "0x1857DA750")]
		[MethodImpl(256)]
		public static int2x3 operator %(int2x3 lhs, int rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00022950 File Offset: 0x00020B50
		[Token(Token = "0x6001905")]
		[Address(RVA = "0x57DA620", Offset = "0x57D9220", VA = "0x1857DA620")]
		[MethodImpl(256)]
		public static int2x3 operator %(int lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00022968 File Offset: 0x00020B68
		[Token(Token = "0x6001906")]
		[Address(RVA = "0x57DA130", Offset = "0x57D8D30", VA = "0x1857DA130")]
		[MethodImpl(256)]
		public static int2x3 operator ++(int2x3 val)
		{
			return default(int2x3);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00022980 File Offset: 0x00020B80
		[Token(Token = "0x6001907")]
		[Address(RVA = "0x57D9910", Offset = "0x57D8510", VA = "0x1857D9910")]
		[MethodImpl(256)]
		public static int2x3 operator --(int2x3 val)
		{
			return default(int2x3);
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00022998 File Offset: 0x00020B98
		[Token(Token = "0x6001908")]
		[Address(RVA = "0x57DA5A0", Offset = "0x57D91A0", VA = "0x1857DA5A0")]
		[MethodImpl(256)]
		public static bool2x3 operator <(int2x3 lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x000229B0 File Offset: 0x00020BB0
		[Token(Token = "0x6001909")]
		[Address(RVA = "0x57DA4D0", Offset = "0x57D90D0", VA = "0x1857DA4D0")]
		[MethodImpl(256)]
		public static bool2x3 operator <(int2x3 lhs, int rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x000229C8 File Offset: 0x00020BC8
		[Token(Token = "0x600190A")]
		[Address(RVA = "0x57DA540", Offset = "0x57D9140", VA = "0x1857DA540")]
		[MethodImpl(256)]
		public static bool2x3 operator <(int lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x000229E0 File Offset: 0x00020BE0
		[Token(Token = "0x600190B")]
		[Address(RVA = "0x57DA3F0", Offset = "0x57D8FF0", VA = "0x1857DA3F0")]
		[MethodImpl(256)]
		public static bool2x3 operator <=(int2x3 lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x000229F8 File Offset: 0x00020BF8
		[Token(Token = "0x600190C")]
		[Address(RVA = "0x57DA380", Offset = "0x57D8F80", VA = "0x1857DA380")]
		[MethodImpl(256)]
		public static bool2x3 operator <=(int2x3 lhs, int rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00022A10 File Offset: 0x00020C10
		[Token(Token = "0x600190D")]
		[Address(RVA = "0x57DA470", Offset = "0x57D9070", VA = "0x1857DA470")]
		[MethodImpl(256)]
		public static bool2x3 operator <=(int lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00022A28 File Offset: 0x00020C28
		[Token(Token = "0x600190E")]
		[Address(RVA = "0x57D9FE0", Offset = "0x57D8BE0", VA = "0x1857D9FE0")]
		[MethodImpl(256)]
		public static bool2x3 operator >(int2x3 lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00022A40 File Offset: 0x00020C40
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x57DA060", Offset = "0x57D8C60", VA = "0x1857DA060")]
		[MethodImpl(256)]
		public static bool2x3 operator >(int2x3 lhs, int rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00022A58 File Offset: 0x00020C58
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x57DA0D0", Offset = "0x57D8CD0", VA = "0x1857DA0D0")]
		[MethodImpl(256)]
		public static bool2x3 operator >(int lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00022A70 File Offset: 0x00020C70
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x57D9F60", Offset = "0x57D8B60", VA = "0x1857D9F60")]
		[MethodImpl(256)]
		public static bool2x3 operator >=(int2x3 lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00022A88 File Offset: 0x00020C88
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x57D9E90", Offset = "0x57D8A90", VA = "0x1857D9E90")]
		[MethodImpl(256)]
		public static bool2x3 operator >=(int2x3 lhs, int rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00022AA0 File Offset: 0x00020CA0
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x57D9F00", Offset = "0x57D8B00", VA = "0x1857D9F00")]
		[MethodImpl(256)]
		public static bool2x3 operator >=(int lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00022AB8 File Offset: 0x00020CB8
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x57DAC00", Offset = "0x57D9800", VA = "0x1857DAC00")]
		[MethodImpl(256)]
		public static int2x3 operator -(int2x3 val)
		{
			return default(int2x3);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00022AD0 File Offset: 0x00020CD0
		[Token(Token = "0x6001915")]
		[Address(RVA = "0x57DAC70", Offset = "0x57D9870", VA = "0x1857DAC70")]
		[MethodImpl(256)]
		public static int2x3 operator +(int2x3 val)
		{
			return default(int2x3);
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00022AE8 File Offset: 0x00020CE8
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x57DA300", Offset = "0x57D8F00", VA = "0x1857DA300")]
		[MethodImpl(256)]
		public static int2x3 operator <<(int2x3 x, int n)
		{
			return default(int2x3);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00022B00 File Offset: 0x00020D00
		[Token(Token = "0x6001917")]
		[Address(RVA = "0x57DA9F0", Offset = "0x57D95F0", VA = "0x1857DA9F0")]
		[MethodImpl(256)]
		public static int2x3 operator >>(int2x3 x, int n)
		{
			return default(int2x3);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00022B18 File Offset: 0x00020D18
		[Token(Token = "0x6001918")]
		[Address(RVA = "0x57D9B50", Offset = "0x57D8750", VA = "0x1857D9B50")]
		[MethodImpl(256)]
		public static bool2x3 operator ==(int2x3 lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00022B30 File Offset: 0x00020D30
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x57D9BD0", Offset = "0x57D87D0", VA = "0x1857D9BD0")]
		[MethodImpl(256)]
		public static bool2x3 operator ==(int2x3 lhs, int rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00022B48 File Offset: 0x00020D48
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x57D9C40", Offset = "0x57D8840", VA = "0x1857D9C40")]
		[MethodImpl(256)]
		public static bool2x3 operator ==(int lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00022B60 File Offset: 0x00020D60
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x57DA1B0", Offset = "0x57D8DB0", VA = "0x1857DA1B0")]
		[MethodImpl(256)]
		public static bool2x3 operator !=(int2x3 lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00022B78 File Offset: 0x00020D78
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x57DA230", Offset = "0x57D8E30", VA = "0x1857DA230")]
		[MethodImpl(256)]
		public static bool2x3 operator !=(int2x3 lhs, int rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00022B90 File Offset: 0x00020D90
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x57DA2A0", Offset = "0x57D8EA0", VA = "0x1857DA2A0")]
		[MethodImpl(256)]
		public static bool2x3 operator !=(int lhs, int2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00022BA8 File Offset: 0x00020DA8
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x57DA980", Offset = "0x57D9580", VA = "0x1857DA980")]
		[MethodImpl(256)]
		public static int2x3 operator ~(int2x3 val)
		{
			return default(int2x3);
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00022BC0 File Offset: 0x00020DC0
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x57D9610", Offset = "0x57D8210", VA = "0x1857D9610")]
		[MethodImpl(256)]
		public static int2x3 operator &(int2x3 lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00022BD8 File Offset: 0x00020DD8
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x57D96A0", Offset = "0x57D82A0", VA = "0x1857D96A0")]
		[MethodImpl(256)]
		public static int2x3 operator &(int2x3 lhs, int rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00022BF0 File Offset: 0x00020DF0
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x57D9720", Offset = "0x57D8320", VA = "0x1857D9720")]
		[MethodImpl(256)]
		public static int2x3 operator &(int lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00022C08 File Offset: 0x00020E08
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x57D9800", Offset = "0x57D8400", VA = "0x1857D9800")]
		[MethodImpl(256)]
		public static int2x3 operator |(int2x3 lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00022C20 File Offset: 0x00020E20
		[Token(Token = "0x6001923")]
		[Address(RVA = "0x57D9890", Offset = "0x57D8490", VA = "0x1857D9890")]
		[MethodImpl(256)]
		public static int2x3 operator |(int2x3 lhs, int rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00022C38 File Offset: 0x00020E38
		[Token(Token = "0x6001924")]
		[Address(RVA = "0x57D9790", Offset = "0x57D8390", VA = "0x1857D9790")]
		[MethodImpl(256)]
		public static int2x3 operator |(int lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00022C50 File Offset: 0x00020E50
		[Token(Token = "0x6001925")]
		[Address(RVA = "0x57D9D90", Offset = "0x57D8990", VA = "0x1857D9D90")]
		[MethodImpl(256)]
		public static int2x3 operator ^(int2x3 lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00022C68 File Offset: 0x00020E68
		[Token(Token = "0x6001926")]
		[Address(RVA = "0x57D9D10", Offset = "0x57D8910", VA = "0x1857D9D10")]
		[MethodImpl(256)]
		public static int2x3 operator ^(int2x3 lhs, int rhs)
		{
			return default(int2x3);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00022C80 File Offset: 0x00020E80
		[Token(Token = "0x6001927")]
		[Address(RVA = "0x57D9CA0", Offset = "0x57D88A0", VA = "0x1857D9CA0")]
		[MethodImpl(256)]
		public static int2x3 operator ^(int lhs, int2x3 rhs)
		{
			return default(int2x3);
		}

		// Token: 0x170007CE RID: 1998
		[Token(Token = "0x170007CE")]
		public int2 this[int index]
		{
			[Token(Token = "0x6001928")]
			[Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00022C98 File Offset: 0x00020E98
		[Token(Token = "0x6001929")]
		[Address(RVA = "0x57D8B40", Offset = "0x57D7740", VA = "0x1857D8B40", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(int2x3 rhs)
		{
			return default(bool);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00022CB0 File Offset: 0x00020EB0
		[Token(Token = "0x600192A")]
		[Address(RVA = "0x57D8BB0", Offset = "0x57D77B0", VA = "0x1857D8BB0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00022CC8 File Offset: 0x00020EC8
		[Token(Token = "0x600192B")]
		[Address(RVA = "0x57D8CB0", Offset = "0x57D78B0", VA = "0x1857D8CB0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x57D8CE0", Offset = "0x57D78E0", VA = "0x1857D8CE0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x600192D")]
		[Address(RVA = "0x57D8FB0", Offset = "0x57D7BB0", VA = "0x1857D8FB0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x0")]
		public int2 c0;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x8")]
		public int2 c1;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x10")]
		public int2 c2;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int2x3 zero;
	}
}
