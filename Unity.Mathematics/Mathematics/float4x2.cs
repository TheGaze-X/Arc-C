using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct float4x2 : IEquatable<float4x2>, IFormattable
	{
		// Token: 0x060014B9 RID: 5305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x371F730", Offset = "0x371E330", VA = "0x18371F730")]
		[MethodImpl(256)]
		public float4x2(float4 c0, float4 c1)
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x57C2FC0", Offset = "0x57C1BC0", VA = "0x1857C2FC0")]
		[MethodImpl(256)]
		public float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31)
		{
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x57C2ED0", Offset = "0x57C1AD0", VA = "0x1857C2ED0")]
		[MethodImpl(256)]
		public float4x2(float v)
		{
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x57C3040", Offset = "0x57C1C40", VA = "0x1857C3040")]
		[MethodImpl(256)]
		public float4x2(bool v)
		{
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x56FE330", Offset = "0x56FCF30", VA = "0x1856FE330")]
		[MethodImpl(256)]
		public float4x2(bool4x2 v)
		{
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x57C2D80", Offset = "0x57C1980", VA = "0x1857C2D80")]
		[MethodImpl(256)]
		public float4x2(int v)
		{
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x57C2E00", Offset = "0x57C1A00", VA = "0x1857C2E00")]
		[MethodImpl(256)]
		public float4x2(int4x2 v)
		{
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x57C2F90", Offset = "0x57C1B90", VA = "0x1857C2F90")]
		[MethodImpl(256)]
		public float4x2(uint v)
		{
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x56FE230", Offset = "0x56FCE30", VA = "0x1856FE230")]
		[MethodImpl(256)]
		public float4x2(uint4x2 v)
		{
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x57C2DB0", Offset = "0x57C19B0", VA = "0x1857C2DB0")]
		[MethodImpl(256)]
		public float4x2(double v)
		{
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x57C2EF0", Offset = "0x57C1AF0", VA = "0x1857C2EF0")]
		[MethodImpl(256)]
		public float4x2(double4x2 v)
		{
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0001D5E0 File Offset: 0x0001B7E0
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x5718D50", Offset = "0x5717950", VA = "0x185718D50")]
		[MethodImpl(256)]
		public static implicit operator float4x2(float v)
		{
			return default(float4x2);
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x5718FD0", Offset = "0x5717BD0", VA = "0x185718FD0")]
		[MethodImpl(256)]
		public static explicit operator float4x2(bool v)
		{
			return default(float4x2);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0001D610 File Offset: 0x0001B810
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x57C3990", Offset = "0x57C2590", VA = "0x1857C3990")]
		[MethodImpl(256)]
		public static explicit operator float4x2(bool4x2 v)
		{
			return default(float4x2);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0001D628 File Offset: 0x0001B828
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x5718F70", Offset = "0x5717B70", VA = "0x185718F70")]
		[MethodImpl(256)]
		public static implicit operator float4x2(int v)
		{
			return default(float4x2);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0001D640 File Offset: 0x0001B840
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x5718E30", Offset = "0x5717A30", VA = "0x185718E30")]
		[MethodImpl(256)]
		public static implicit operator float4x2(int4x2 v)
		{
			return default(float4x2);
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0001D658 File Offset: 0x0001B858
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x5718FA0", Offset = "0x5717BA0", VA = "0x185718FA0")]
		[MethodImpl(256)]
		public static implicit operator float4x2(uint v)
		{
			return default(float4x2);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0001D670 File Offset: 0x0001B870
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x57C3D60", Offset = "0x57C2960", VA = "0x1857C3D60")]
		[MethodImpl(256)]
		public static implicit operator float4x2(uint4x2 v)
		{
			return default(float4x2);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0001D688 File Offset: 0x0001B888
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x5718BF0", Offset = "0x57177F0", VA = "0x185718BF0")]
		[MethodImpl(256)]
		public static explicit operator float4x2(double v)
		{
			return default(float4x2);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0001D6A0 File Offset: 0x0001B8A0
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x5718D80", Offset = "0x5717980", VA = "0x185718D80")]
		[MethodImpl(256)]
		public static explicit operator float4x2(double4x2 v)
		{
			return default(float4x2);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0001D6B8 File Offset: 0x0001B8B8
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x57C4970", Offset = "0x57C3570", VA = "0x1857C4970")]
		[MethodImpl(256)]
		public static float4x2 operator *(float4x2 lhs, float4x2 rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0001D6D0 File Offset: 0x0001B8D0
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x57C4B50", Offset = "0x57C3750", VA = "0x1857C4B50")]
		[MethodImpl(256)]
		public static float4x2 operator *(float4x2 lhs, float rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x57C4A80", Offset = "0x57C3680", VA = "0x1857C4A80")]
		[MethodImpl(256)]
		public static float4x2 operator *(float lhs, float4x2 rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0001D700 File Offset: 0x0001B900
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x57C3210", Offset = "0x57C1E10", VA = "0x1857C3210")]
		[MethodImpl(256)]
		public static float4x2 operator +(float4x2 lhs, float4x2 rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0001D718 File Offset: 0x0001B918
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0x57C3070", Offset = "0x57C1C70", VA = "0x1857C3070")]
		[MethodImpl(256)]
		public static float4x2 operator +(float4x2 lhs, float rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0001D730 File Offset: 0x0001B930
		[Token(Token = "0x60014D2")]
		[Address(RVA = "0x57C3140", Offset = "0x57C1D40", VA = "0x1857C3140")]
		[MethodImpl(256)]
		public static float4x2 operator +(float lhs, float4x2 rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0001D748 File Offset: 0x0001B948
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x57C4C20", Offset = "0x57C3820", VA = "0x1857C4C20")]
		[MethodImpl(256)]
		public static float4x2 operator -(float4x2 lhs, float4x2 rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0001D760 File Offset: 0x0001B960
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x57C4E20", Offset = "0x57C3A20", VA = "0x1857C4E20")]
		[MethodImpl(256)]
		public static float4x2 operator -(float4x2 lhs, float rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0001D778 File Offset: 0x0001B978
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x57C4D30", Offset = "0x57C3930", VA = "0x1857C4D30")]
		[MethodImpl(256)]
		public static float4x2 operator -(float lhs, float4x2 rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0001D790 File Offset: 0x0001B990
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x57C34C0", Offset = "0x57C20C0", VA = "0x1857C34C0")]
		[MethodImpl(256)]
		public static float4x2 operator /(float4x2 lhs, float4x2 rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x57C35D0", Offset = "0x57C21D0", VA = "0x1857C35D0")]
		[MethodImpl(256)]
		public static float4x2 operator /(float4x2 lhs, float rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x57C33D0", Offset = "0x57C1FD0", VA = "0x1857C33D0")]
		[MethodImpl(256)]
		public static float4x2 operator /(float lhs, float4x2 rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x57C4650", Offset = "0x57C3250", VA = "0x1857C4650")]
		[MethodImpl(256)]
		public static float4x2 operator %(float4x2 lhs, float4x2 rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x57C44E0", Offset = "0x57C30E0", VA = "0x1857C44E0")]
		[MethodImpl(256)]
		public static float4x2 operator %(float4x2 lhs, float rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0001D808 File Offset: 0x0001BA08
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x57C47F0", Offset = "0x57C33F0", VA = "0x1857C47F0")]
		[MethodImpl(256)]
		public static float4x2 operator %(float lhs, float4x2 rhs)
		{
			return default(float4x2);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0001D820 File Offset: 0x0001BA20
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x57C3DA0", Offset = "0x57C29A0", VA = "0x1857C3DA0")]
		[MethodImpl(256)]
		public static float4x2 operator ++(float4x2 val)
		{
			return default(float4x2);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0001D838 File Offset: 0x0001BA38
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0x57C3320", Offset = "0x57C1F20", VA = "0x1857C3320")]
		[MethodImpl(256)]
		public static float4x2 operator --(float4x2 val)
		{
			return default(float4x2);
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0001D850 File Offset: 0x0001BA50
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x57C4310", Offset = "0x57C2F10", VA = "0x1857C4310")]
		[MethodImpl(256)]
		public static bool4x2 operator <(float4x2 lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0001D868 File Offset: 0x0001BA68
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x57C43C0", Offset = "0x57C2FC0", VA = "0x1857C43C0")]
		[MethodImpl(256)]
		public static bool4x2 operator <(float4x2 lhs, float rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0001D880 File Offset: 0x0001BA80
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x57C4450", Offset = "0x57C3050", VA = "0x1857C4450")]
		[MethodImpl(256)]
		public static bool4x2 operator <(float lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0001D898 File Offset: 0x0001BA98
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x57C41D0", Offset = "0x57C2DD0", VA = "0x1857C41D0")]
		[MethodImpl(256)]
		public static bool4x2 operator <=(float4x2 lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x57C4280", Offset = "0x57C2E80", VA = "0x1857C4280")]
		[MethodImpl(256)]
		public static bool4x2 operator <=(float4x2 lhs, float rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x57C4140", Offset = "0x57C2D40", VA = "0x1857C4140")]
		[MethodImpl(256)]
		public static bool4x2 operator <=(float lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0001D8E0 File Offset: 0x0001BAE0
		[Token(Token = "0x60014E4")]
		[Address(RVA = "0x57C3C20", Offset = "0x57C2820", VA = "0x1857C3C20")]
		[MethodImpl(256)]
		public static bool4x2 operator >(float4x2 lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0001D8F8 File Offset: 0x0001BAF8
		[Token(Token = "0x60014E5")]
		[Address(RVA = "0x57C3CD0", Offset = "0x57C28D0", VA = "0x1857C3CD0")]
		[MethodImpl(256)]
		public static bool4x2 operator >(float4x2 lhs, float rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0001D910 File Offset: 0x0001BB10
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x57C3B90", Offset = "0x57C2790", VA = "0x1857C3B90")]
		[MethodImpl(256)]
		public static bool4x2 operator >(float lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0001D928 File Offset: 0x0001BB28
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x57C3AE0", Offset = "0x57C26E0", VA = "0x1857C3AE0")]
		[MethodImpl(256)]
		public static bool4x2 operator >=(float4x2 lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0001D940 File Offset: 0x0001BB40
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x57C3A50", Offset = "0x57C2650", VA = "0x1857C3A50")]
		[MethodImpl(256)]
		public static bool4x2 operator >=(float4x2 lhs, float rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0001D958 File Offset: 0x0001BB58
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x57C39C0", Offset = "0x57C25C0", VA = "0x1857C39C0")]
		[MethodImpl(256)]
		public static bool4x2 operator >=(float lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0001D970 File Offset: 0x0001BB70
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x57C4EF0", Offset = "0x57C3AF0", VA = "0x1857C4EF0")]
		[MethodImpl(256)]
		public static float4x2 operator -(float4x2 val)
		{
			return default(float4x2);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0001D988 File Offset: 0x0001BB88
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x57C4FC0", Offset = "0x57C3BC0", VA = "0x1857C4FC0")]
		[MethodImpl(256)]
		public static float4x2 operator +(float4x2 val)
		{
			return default(float4x2);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x57C3870", Offset = "0x57C2470", VA = "0x1857C3870")]
		[MethodImpl(256)]
		public static bool4x2 operator ==(float4x2 lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0001D9B8 File Offset: 0x0001BBB8
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x57C3780", Offset = "0x57C2380", VA = "0x1857C3780")]
		[MethodImpl(256)]
		public static bool4x2 operator ==(float4x2 lhs, float rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x57C36A0", Offset = "0x57C22A0", VA = "0x1857C36A0")]
		[MethodImpl(256)]
		public static bool4x2 operator ==(float lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x57C4020", Offset = "0x57C2C20", VA = "0x1857C4020")]
		[MethodImpl(256)]
		public static bool4x2 operator !=(float4x2 lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0001DA00 File Offset: 0x0001BC00
		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x57C3E50", Offset = "0x57C2A50", VA = "0x1857C3E50")]
		[MethodImpl(256)]
		public static bool4x2 operator !=(float4x2 lhs, float rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0001DA18 File Offset: 0x0001BC18
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x57C3F40", Offset = "0x57C2B40", VA = "0x1857C3F40")]
		[MethodImpl(256)]
		public static bool4x2 operator !=(float lhs, float4x2 rhs)
		{
			return default(bool4x2);
		}

		// Token: 0x170005C5 RID: 1477
		[Token(Token = "0x170005C5")]
		public float4 this[int index]
		{
			[Token(Token = "0x60014F2")]
			[Address(RVA = "0x3D28160", Offset = "0x3D26D60", VA = "0x183D28160")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0001DA30 File Offset: 0x0001BC30
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x57C2480", Offset = "0x57C1080", VA = "0x1857C2480", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(float4x2 rhs)
		{
			return default(bool);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0001DA48 File Offset: 0x0001BC48
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x57C2510", Offset = "0x57C1110", VA = "0x1857C2510", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0001DA60 File Offset: 0x0001BC60
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x57C2620", Offset = "0x57C1220", VA = "0x1857C2620", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x57C29D0", Offset = "0x57C15D0", VA = "0x1857C29D0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x57C2650", Offset = "0x57C1250", VA = "0x1857C2650", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x0")]
		public float4 c0;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x10")]
		public float4 c1;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float4x2 zero;
	}
}
