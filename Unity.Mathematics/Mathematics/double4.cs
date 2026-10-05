using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(double4.DebuggerProxy))]
	[Serializable]
	public struct double4 : IEquatable<double4>, IFormattable
	{
		// Token: 0x06000D82 RID: 3458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x5797AA0", Offset = "0x57966A0", VA = "0x185797AA0")]
		[MethodImpl(256)]
		public double4(double x, double y, double z, double w)
		{
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x5797A20", Offset = "0x5796620", VA = "0x185797A20")]
		[MethodImpl(256)]
		public double4(double x, double y, double2 zw)
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x5797A40", Offset = "0x5796640", VA = "0x185797A40")]
		[MethodImpl(256)]
		public double4(double x, double2 yz, double w)
		{
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x5797A80", Offset = "0x5796680", VA = "0x185797A80")]
		[MethodImpl(256)]
		public double4(double x, double3 yzw)
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x5797C00", Offset = "0x5796800", VA = "0x185797C00")]
		[MethodImpl(256)]
		public double4(double2 xy, double z, double w)
		{
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D87")]
		[Address(RVA = "0x5797A60", Offset = "0x5796660", VA = "0x185797A60")]
		[MethodImpl(256)]
		public double4(double2 xy, double2 zw)
		{
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x5797BE0", Offset = "0x57967E0", VA = "0x185797BE0")]
		[MethodImpl(256)]
		public double4(double3 xyz, double w)
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x5797A00", Offset = "0x5796600", VA = "0x185797A00")]
		[MethodImpl(256)]
		public double4(double4 xyzw)
		{
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x5797C80", Offset = "0x5796880", VA = "0x185797C80")]
		[MethodImpl(256)]
		public double4(double v)
		{
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x5797AC0", Offset = "0x57966C0", VA = "0x185797AC0")]
		[MethodImpl(256)]
		public double4(bool v)
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x5797C20", Offset = "0x5796820", VA = "0x185797C20")]
		[MethodImpl(256)]
		public double4(bool4 v)
		{
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x5797B00", Offset = "0x5796700", VA = "0x185797B00")]
		[MethodImpl(256)]
		public double4(int v)
		{
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x5797BA0", Offset = "0x57967A0", VA = "0x185797BA0")]
		[MethodImpl(256)]
		public double4(int4 v)
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x5797C90", Offset = "0x5796890", VA = "0x185797C90")]
		[MethodImpl(256)]
		public double4(uint v)
		{
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x5797B20", Offset = "0x5796720", VA = "0x185797B20")]
		[MethodImpl(256)]
		public double4(uint4 v)
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x56FBFF0", Offset = "0x56FABF0", VA = "0x1856FBFF0")]
		[MethodImpl(256)]
		public double4(half v)
		{
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x56FBE10", Offset = "0x56FAA10", VA = "0x1856FBE10")]
		[MethodImpl(256)]
		public double4(half4 v)
		{
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x57979E0", Offset = "0x57965E0", VA = "0x1857979E0")]
		[MethodImpl(256)]
		public double4(float v)
		{
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x5797B60", Offset = "0x5796760", VA = "0x185797B60")]
		[MethodImpl(256)]
		public double4(float4 v)
		{
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00014940 File Offset: 0x00012B40
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x5710770", Offset = "0x570F370", VA = "0x185710770")]
		[MethodImpl(256)]
		public static implicit operator double4(double v)
		{
			return default(double4);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00014958 File Offset: 0x00012B58
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x57108D0", Offset = "0x570F4D0", VA = "0x1857108D0")]
		[MethodImpl(256)]
		public static explicit operator double4(bool v)
		{
			return default(double4);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00014970 File Offset: 0x00012B70
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x57106A0", Offset = "0x570F2A0", VA = "0x1857106A0")]
		[MethodImpl(256)]
		public static explicit operator double4(bool4 v)
		{
			return default(double4);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00014988 File Offset: 0x00012B88
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x57107B0", Offset = "0x570F3B0", VA = "0x1857107B0")]
		[MethodImpl(256)]
		public static implicit operator double4(int v)
		{
			return default(double4);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x000149A0 File Offset: 0x00012BA0
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x5710920", Offset = "0x570F520", VA = "0x185710920")]
		[MethodImpl(256)]
		public static implicit operator double4(int4 v)
		{
			return default(double4);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000149B8 File Offset: 0x00012BB8
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x56FC1E0", Offset = "0x56FADE0", VA = "0x1856FC1E0")]
		[MethodImpl(256)]
		public static implicit operator double4(uint v)
		{
			return default(double4);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000149D0 File Offset: 0x00012BD0
		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x5710980", Offset = "0x570F580", VA = "0x185710980")]
		[MethodImpl(256)]
		public static implicit operator double4(uint4 v)
		{
			return default(double4);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x000149E8 File Offset: 0x00012BE8
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x57107F0", Offset = "0x570F3F0", VA = "0x1857107F0")]
		[MethodImpl(256)]
		public static implicit operator double4(half v)
		{
			return default(double4);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00014A00 File Offset: 0x00012C00
		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x5710670", Offset = "0x570F270", VA = "0x185710670")]
		[MethodImpl(256)]
		public static implicit operator double4(half4 v)
		{
			return default(double4);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00014A18 File Offset: 0x00012C18
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x56FC1A0", Offset = "0x56FADA0", VA = "0x1856FC1A0")]
		[MethodImpl(256)]
		public static implicit operator double4(float v)
		{
			return default(double4);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00014A30 File Offset: 0x00012C30
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x5710880", Offset = "0x570F480", VA = "0x185710880")]
		[MethodImpl(256)]
		public static implicit operator double4(float4 v)
		{
			return default(double4);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00014A48 File Offset: 0x00012C48
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x579A560", Offset = "0x5799160", VA = "0x18579A560")]
		[MethodImpl(256)]
		public static double4 operator *(double4 lhs, double4 rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00014A60 File Offset: 0x00012C60
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x579A540", Offset = "0x5799140", VA = "0x18579A540")]
		[MethodImpl(256)]
		public static double4 operator *(double4 lhs, double rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00014A78 File Offset: 0x00012C78
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x579A5B0", Offset = "0x57991B0", VA = "0x18579A5B0")]
		[MethodImpl(256)]
		public static double4 operator *(double lhs, double4 rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00014A90 File Offset: 0x00012C90
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x5799D40", Offset = "0x5798940", VA = "0x185799D40")]
		[MethodImpl(256)]
		public static double4 operator +(double4 lhs, double4 rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00014AA8 File Offset: 0x00012CA8
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x5799DB0", Offset = "0x57989B0", VA = "0x185799DB0")]
		[MethodImpl(256)]
		public static double4 operator +(double4 lhs, double rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00014AC0 File Offset: 0x00012CC0
		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x5799D90", Offset = "0x5798990", VA = "0x185799D90")]
		[MethodImpl(256)]
		public static double4 operator +(double lhs, double4 rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00014AD8 File Offset: 0x00012CD8
		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x579A630", Offset = "0x5799230", VA = "0x18579A630")]
		[MethodImpl(256)]
		public static double4 operator -(double4 lhs, double4 rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00014AF0 File Offset: 0x00012CF0
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x579A610", Offset = "0x5799210", VA = "0x18579A610")]
		[MethodImpl(256)]
		public static double4 operator -(double4 lhs, double rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00014B08 File Offset: 0x00012D08
		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x579A5D0", Offset = "0x57991D0", VA = "0x18579A5D0")]
		[MethodImpl(256)]
		public static double4 operator -(double lhs, double4 rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00014B20 File Offset: 0x00012D20
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x5799E20", Offset = "0x5798A20", VA = "0x185799E20")]
		[MethodImpl(256)]
		public static double4 operator /(double4 lhs, double4 rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00014B38 File Offset: 0x00012D38
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x5799E00", Offset = "0x5798A00", VA = "0x185799E00")]
		[MethodImpl(256)]
		public static double4 operator /(double4 lhs, double rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00014B50 File Offset: 0x00012D50
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x5799E70", Offset = "0x5798A70", VA = "0x185799E70")]
		[MethodImpl(256)]
		public static double4 operator /(double lhs, double4 rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00014B68 File Offset: 0x00012D68
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x571A780", Offset = "0x5719380", VA = "0x18571A780")]
		[MethodImpl(256)]
		public static double4 operator %(double4 lhs, double4 rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00014B80 File Offset: 0x00012D80
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x579A4C0", Offset = "0x57990C0", VA = "0x18579A4C0")]
		[MethodImpl(256)]
		public static double4 operator %(double4 lhs, double rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00014B98 File Offset: 0x00012D98
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x579A440", Offset = "0x5799040", VA = "0x18579A440")]
		[MethodImpl(256)]
		public static double4 operator %(double lhs, double4 rhs)
		{
			return default(double4);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00014BB0 File Offset: 0x00012DB0
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x579A160", Offset = "0x5798D60", VA = "0x18579A160")]
		[MethodImpl(256)]
		public static double4 operator ++(double4 val)
		{
			return default(double4);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00014BC8 File Offset: 0x00012DC8
		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x5799DD0", Offset = "0x57989D0", VA = "0x185799DD0")]
		[MethodImpl(256)]
		public static double4 operator --(double4 val)
		{
			return default(double4);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00014BE0 File Offset: 0x00012DE0
		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x579A3C0", Offset = "0x5798FC0", VA = "0x18579A3C0")]
		[MethodImpl(256)]
		public static bool4 operator <(double4 lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00014BF8 File Offset: 0x00012DF8
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x579A390", Offset = "0x5798F90", VA = "0x18579A390")]
		[MethodImpl(256)]
		public static bool4 operator <(double4 lhs, double rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00014C10 File Offset: 0x00012E10
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x579A400", Offset = "0x5799000", VA = "0x18579A400")]
		[MethodImpl(256)]
		public static bool4 operator <(double lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00014C28 File Offset: 0x00012E28
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x579A350", Offset = "0x5798F50", VA = "0x18579A350")]
		[MethodImpl(256)]
		public static bool4 operator <=(double4 lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00014C40 File Offset: 0x00012E40
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x579A320", Offset = "0x5798F20", VA = "0x18579A320")]
		[MethodImpl(256)]
		public static bool4 operator <=(double4 lhs, double rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00014C58 File Offset: 0x00012E58
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x579A2E0", Offset = "0x5798EE0", VA = "0x18579A2E0")]
		[MethodImpl(256)]
		public static bool4 operator <=(double lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00014C70 File Offset: 0x00012E70
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x579A0B0", Offset = "0x5798CB0", VA = "0x18579A0B0")]
		[MethodImpl(256)]
		public static bool4 operator >(double4 lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00014C88 File Offset: 0x00012E88
		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x579A0F0", Offset = "0x5798CF0", VA = "0x18579A0F0")]
		[MethodImpl(256)]
		public static bool4 operator >(double4 lhs, double rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x579A130", Offset = "0x5798D30", VA = "0x18579A130")]
		[MethodImpl(256)]
		public static bool4 operator >(double lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00014CB8 File Offset: 0x00012EB8
		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x579A070", Offset = "0x5798C70", VA = "0x18579A070")]
		[MethodImpl(256)]
		public static bool4 operator >=(double4 lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00014CD0 File Offset: 0x00012ED0
		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x579A030", Offset = "0x5798C30", VA = "0x18579A030")]
		[MethodImpl(256)]
		public static bool4 operator >=(double4 lhs, double rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00014CE8 File Offset: 0x00012EE8
		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x579A000", Offset = "0x5798C00", VA = "0x18579A000")]
		[MethodImpl(256)]
		public static bool4 operator >=(double lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00014D00 File Offset: 0x00012F00
		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x579A680", Offset = "0x5799280", VA = "0x18579A680")]
		[MethodImpl(256)]
		public static double4 operator -(double4 val)
		{
			return default(double4);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00014D18 File Offset: 0x00012F18
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x5798E20", Offset = "0x5797A20", VA = "0x185798E20")]
		[MethodImpl(256)]
		public static double4 operator +(double4 val)
		{
			return default(double4);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00014D30 File Offset: 0x00012F30
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x5799F90", Offset = "0x5798B90", VA = "0x185799F90")]
		[MethodImpl(256)]
		public static bool4 operator ==(double4 lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00014D48 File Offset: 0x00012F48
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x5799F10", Offset = "0x5798B10", VA = "0x185799F10")]
		[MethodImpl(256)]
		public static bool4 operator ==(double4 lhs, double rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00014D60 File Offset: 0x00012F60
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x5799EB0", Offset = "0x5798AB0", VA = "0x185799EB0")]
		[MethodImpl(256)]
		public static bool4 operator ==(double lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00014D78 File Offset: 0x00012F78
		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x579A190", Offset = "0x5798D90", VA = "0x18579A190")]
		[MethodImpl(256)]
		public static bool4 operator !=(double4 lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00014D90 File Offset: 0x00012F90
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0x579A260", Offset = "0x5798E60", VA = "0x18579A260")]
		[MethodImpl(256)]
		public static bool4 operator !=(double4 lhs, double rhs)
		{
			return default(bool4);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00014DA8 File Offset: 0x00012FA8
		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0x579A200", Offset = "0x5798E00", VA = "0x18579A200")]
		[MethodImpl(256)]
		public static bool4 operator !=(double lhs, double4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00014DC0 File Offset: 0x00012FC0
		[Token(Token = "0x17000287")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxxx
		{
			[Token(Token = "0x6000DC5")]
			[Address(RVA = "0x5783750", Offset = "0x5782350", VA = "0x185783750")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00014DD8 File Offset: 0x00012FD8
		[Token(Token = "0x17000288")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxxy
		{
			[Token(Token = "0x6000DC6")]
			[Address(RVA = "0x5783770", Offset = "0x5782370", VA = "0x185783770")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00014DF0 File Offset: 0x00012FF0
		[Token(Token = "0x17000289")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxxz
		{
			[Token(Token = "0x6000DC7")]
			[Address(RVA = "0x5789F00", Offset = "0x5788B00", VA = "0x185789F00")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00014E08 File Offset: 0x00013008
		[Token(Token = "0x1700028A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxxw
		{
			[Token(Token = "0x6000DC8")]
			[Address(RVA = "0x5798CA0", Offset = "0x57978A0", VA = "0x185798CA0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00014E20 File Offset: 0x00013020
		[Token(Token = "0x1700028B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxyx
		{
			[Token(Token = "0x6000DC9")]
			[Address(RVA = "0x57837B0", Offset = "0x57823B0", VA = "0x1857837B0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00014E38 File Offset: 0x00013038
		[Token(Token = "0x1700028C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxyy
		{
			[Token(Token = "0x6000DCA")]
			[Address(RVA = "0x57837D0", Offset = "0x57823D0", VA = "0x1857837D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00014E50 File Offset: 0x00013050
		[Token(Token = "0x1700028D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxyz
		{
			[Token(Token = "0x6000DCB")]
			[Address(RVA = "0x5789F20", Offset = "0x5788B20", VA = "0x185789F20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00014E68 File Offset: 0x00013068
		[Token(Token = "0x1700028E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxyw
		{
			[Token(Token = "0x6000DCC")]
			[Address(RVA = "0x5798CC0", Offset = "0x57978C0", VA = "0x185798CC0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00014E80 File Offset: 0x00013080
		[Token(Token = "0x1700028F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxzx
		{
			[Token(Token = "0x6000DCD")]
			[Address(RVA = "0x5789F60", Offset = "0x5788B60", VA = "0x185789F60")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00014E98 File Offset: 0x00013098
		[Token(Token = "0x17000290")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxzy
		{
			[Token(Token = "0x6000DCE")]
			[Address(RVA = "0x5789F80", Offset = "0x5788B80", VA = "0x185789F80")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00014EB0 File Offset: 0x000130B0
		[Token(Token = "0x17000291")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxzz
		{
			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0x5789FA0", Offset = "0x5788BA0", VA = "0x185789FA0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00014EC8 File Offset: 0x000130C8
		[Token(Token = "0x17000292")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxzw
		{
			[Token(Token = "0x6000DD0")]
			[Address(RVA = "0x5798CE0", Offset = "0x57978E0", VA = "0x185798CE0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00014EE0 File Offset: 0x000130E0
		[Token(Token = "0x17000293")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxwx
		{
			[Token(Token = "0x6000DD1")]
			[Address(RVA = "0x5798C40", Offset = "0x5797840", VA = "0x185798C40")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00014EF8 File Offset: 0x000130F8
		[Token(Token = "0x17000294")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxwy
		{
			[Token(Token = "0x6000DD2")]
			[Address(RVA = "0x5798C60", Offset = "0x5797860", VA = "0x185798C60")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00014F10 File Offset: 0x00013110
		[Token(Token = "0x17000295")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxwz
		{
			[Token(Token = "0x6000DD3")]
			[Address(RVA = "0x5798C80", Offset = "0x5797880", VA = "0x185798C80")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00014F28 File Offset: 0x00013128
		[Token(Token = "0x17000296")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxww
		{
			[Token(Token = "0x6000DD4")]
			[Address(RVA = "0x5798C20", Offset = "0x5797820", VA = "0x185798C20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00014F40 File Offset: 0x00013140
		[Token(Token = "0x17000297")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyxx
		{
			[Token(Token = "0x6000DD5")]
			[Address(RVA = "0x5783810", Offset = "0x5782410", VA = "0x185783810")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00014F58 File Offset: 0x00013158
		[Token(Token = "0x17000298")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyxy
		{
			[Token(Token = "0x6000DD6")]
			[Address(RVA = "0x5783830", Offset = "0x5782430", VA = "0x185783830")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x00014F70 File Offset: 0x00013170
		[Token(Token = "0x17000299")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyxz
		{
			[Token(Token = "0x6000DD7")]
			[Address(RVA = "0x5789FC0", Offset = "0x5788BC0", VA = "0x185789FC0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x00014F88 File Offset: 0x00013188
		[Token(Token = "0x1700029A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyxw
		{
			[Token(Token = "0x6000DD8")]
			[Address(RVA = "0x5798DD0", Offset = "0x57979D0", VA = "0x185798DD0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00014FA0 File Offset: 0x000131A0
		[Token(Token = "0x1700029B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyyx
		{
			[Token(Token = "0x6000DD9")]
			[Address(RVA = "0x5783870", Offset = "0x5782470", VA = "0x185783870")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00014FB8 File Offset: 0x000131B8
		[Token(Token = "0x1700029C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyyy
		{
			[Token(Token = "0x6000DDA")]
			[Address(RVA = "0x5783890", Offset = "0x5782490", VA = "0x185783890")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00014FD0 File Offset: 0x000131D0
		[Token(Token = "0x1700029D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyyz
		{
			[Token(Token = "0x6000DDB")]
			[Address(RVA = "0x5789FF0", Offset = "0x5788BF0", VA = "0x185789FF0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x00014FE8 File Offset: 0x000131E8
		[Token(Token = "0x1700029E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyyw
		{
			[Token(Token = "0x6000DDC")]
			[Address(RVA = "0x5798E00", Offset = "0x5797A00", VA = "0x185798E00")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00015000 File Offset: 0x00013200
		[Token(Token = "0x1700029F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyzx
		{
			[Token(Token = "0x6000DDD")]
			[Address(RVA = "0x578A030", Offset = "0x5788C30", VA = "0x18578A030")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00015018 File Offset: 0x00013218
		[Token(Token = "0x170002A0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyzy
		{
			[Token(Token = "0x6000DDE")]
			[Address(RVA = "0x578A060", Offset = "0x5788C60", VA = "0x18578A060")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00015030 File Offset: 0x00013230
		[Token(Token = "0x170002A1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyzz
		{
			[Token(Token = "0x6000DDF")]
			[Address(RVA = "0x578A090", Offset = "0x5788C90", VA = "0x18578A090")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00015048 File Offset: 0x00013248
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyzw
		{
			[Token(Token = "0x6000DE0")]
			[Address(RVA = "0x5798E20", Offset = "0x5797A20", VA = "0x185798E20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000DE1")]
			[Address(RVA = "0x5797A00", Offset = "0x5796600", VA = "0x185797A00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00015060 File Offset: 0x00013260
		[Token(Token = "0x170002A3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xywx
		{
			[Token(Token = "0x6000DE2")]
			[Address(RVA = "0x5798D40", Offset = "0x5797940", VA = "0x185798D40")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x00015078 File Offset: 0x00013278
		[Token(Token = "0x170002A4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xywy
		{
			[Token(Token = "0x6000DE3")]
			[Address(RVA = "0x5798D70", Offset = "0x5797970", VA = "0x185798D70")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00015090 File Offset: 0x00013290
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xywz
		{
			[Token(Token = "0x6000DE4")]
			[Address(RVA = "0x5798DA0", Offset = "0x57979A0", VA = "0x185798DA0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000DE5")]
			[Address(RVA = "0x579A900", Offset = "0x5799500", VA = "0x18579A900")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x000150A8 File Offset: 0x000132A8
		[Token(Token = "0x170002A6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyww
		{
			[Token(Token = "0x6000DE6")]
			[Address(RVA = "0x5798D20", Offset = "0x5797920", VA = "0x185798D20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x000150C0 File Offset: 0x000132C0
		[Token(Token = "0x170002A7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzxx
		{
			[Token(Token = "0x6000DE7")]
			[Address(RVA = "0x578A0F0", Offset = "0x5788CF0", VA = "0x18578A0F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x000150D8 File Offset: 0x000132D8
		[Token(Token = "0x170002A8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzxy
		{
			[Token(Token = "0x6000DE8")]
			[Address(RVA = "0x578A110", Offset = "0x5788D10", VA = "0x18578A110")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x000150F0 File Offset: 0x000132F0
		[Token(Token = "0x170002A9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzxz
		{
			[Token(Token = "0x6000DE9")]
			[Address(RVA = "0x578A140", Offset = "0x5788D40", VA = "0x18578A140")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x00015108 File Offset: 0x00013308
		[Token(Token = "0x170002AA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzxw
		{
			[Token(Token = "0x6000DEA")]
			[Address(RVA = "0x5798F20", Offset = "0x5797B20", VA = "0x185798F20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x00015120 File Offset: 0x00013320
		[Token(Token = "0x170002AB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzyx
		{
			[Token(Token = "0x6000DEB")]
			[Address(RVA = "0x578A180", Offset = "0x5788D80", VA = "0x18578A180")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x00015138 File Offset: 0x00013338
		[Token(Token = "0x170002AC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzyy
		{
			[Token(Token = "0x6000DEC")]
			[Address(RVA = "0x578A1B0", Offset = "0x5788DB0", VA = "0x18578A1B0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x00015150 File Offset: 0x00013350
		[Token(Token = "0x170002AD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzyz
		{
			[Token(Token = "0x6000DED")]
			[Address(RVA = "0x578A1D0", Offset = "0x5788DD0", VA = "0x18578A1D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00015168 File Offset: 0x00013368
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzyw
		{
			[Token(Token = "0x6000DEE")]
			[Address(RVA = "0x5798F50", Offset = "0x5797B50", VA = "0x185798F50")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000DEF")]
			[Address(RVA = "0x579A960", Offset = "0x5799560", VA = "0x18579A960")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00015180 File Offset: 0x00013380
		[Token(Token = "0x170002AF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzzx
		{
			[Token(Token = "0x6000DF0")]
			[Address(RVA = "0x578A220", Offset = "0x5788E20", VA = "0x18578A220")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00015198 File Offset: 0x00013398
		[Token(Token = "0x170002B0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzzy
		{
			[Token(Token = "0x6000DF1")]
			[Address(RVA = "0x578A240", Offset = "0x5788E40", VA = "0x18578A240")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x000151B0 File Offset: 0x000133B0
		[Token(Token = "0x170002B1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzzz
		{
			[Token(Token = "0x6000DF2")]
			[Address(RVA = "0x578A260", Offset = "0x5788E60", VA = "0x18578A260")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x000151C8 File Offset: 0x000133C8
		[Token(Token = "0x170002B2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzzw
		{
			[Token(Token = "0x6000DF3")]
			[Address(RVA = "0x5798F80", Offset = "0x5797B80", VA = "0x185798F80")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x000151E0 File Offset: 0x000133E0
		[Token(Token = "0x170002B3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzwx
		{
			[Token(Token = "0x6000DF4")]
			[Address(RVA = "0x5798E90", Offset = "0x5797A90", VA = "0x185798E90")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x000151F8 File Offset: 0x000133F8
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzwy
		{
			[Token(Token = "0x6000DF5")]
			[Address(RVA = "0x5798EC0", Offset = "0x5797AC0", VA = "0x185798EC0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000DF6")]
			[Address(RVA = "0x579A940", Offset = "0x5799540", VA = "0x18579A940")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00015210 File Offset: 0x00013410
		[Token(Token = "0x170002B5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzwz
		{
			[Token(Token = "0x6000DF7")]
			[Address(RVA = "0x5798EF0", Offset = "0x5797AF0", VA = "0x185798EF0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x00015228 File Offset: 0x00013428
		[Token(Token = "0x170002B6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzww
		{
			[Token(Token = "0x6000DF8")]
			[Address(RVA = "0x5798E70", Offset = "0x5797A70", VA = "0x185798E70")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00015240 File Offset: 0x00013440
		[Token(Token = "0x170002B7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwxx
		{
			[Token(Token = "0x6000DF9")]
			[Address(RVA = "0x57989E0", Offset = "0x57975E0", VA = "0x1857989E0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x00015258 File Offset: 0x00013458
		[Token(Token = "0x170002B8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwxy
		{
			[Token(Token = "0x6000DFA")]
			[Address(RVA = "0x5798A00", Offset = "0x5797600", VA = "0x185798A00")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x00015270 File Offset: 0x00013470
		[Token(Token = "0x170002B9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwxz
		{
			[Token(Token = "0x6000DFB")]
			[Address(RVA = "0x5798A30", Offset = "0x5797630", VA = "0x185798A30")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00015288 File Offset: 0x00013488
		[Token(Token = "0x170002BA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwxw
		{
			[Token(Token = "0x6000DFC")]
			[Address(RVA = "0x57989C0", Offset = "0x57975C0", VA = "0x1857989C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x000152A0 File Offset: 0x000134A0
		[Token(Token = "0x170002BB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwyx
		{
			[Token(Token = "0x6000DFD")]
			[Address(RVA = "0x5798AB0", Offset = "0x57976B0", VA = "0x185798AB0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x000152B8 File Offset: 0x000134B8
		[Token(Token = "0x170002BC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwyy
		{
			[Token(Token = "0x6000DFE")]
			[Address(RVA = "0x5798AE0", Offset = "0x57976E0", VA = "0x185798AE0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x000152D0 File Offset: 0x000134D0
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwyz
		{
			[Token(Token = "0x6000DFF")]
			[Address(RVA = "0x5798B00", Offset = "0x5797700", VA = "0x185798B00")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E00")]
			[Address(RVA = "0x579A880", Offset = "0x5799480", VA = "0x18579A880")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x000152E8 File Offset: 0x000134E8
		[Token(Token = "0x170002BE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwyw
		{
			[Token(Token = "0x6000E01")]
			[Address(RVA = "0x5798A80", Offset = "0x5797680", VA = "0x185798A80")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x00015300 File Offset: 0x00013500
		[Token(Token = "0x170002BF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwzx
		{
			[Token(Token = "0x6000E02")]
			[Address(RVA = "0x5798B80", Offset = "0x5797780", VA = "0x185798B80")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00015318 File Offset: 0x00013518
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwzy
		{
			[Token(Token = "0x6000E03")]
			[Address(RVA = "0x5798BB0", Offset = "0x57977B0", VA = "0x185798BB0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E04")]
			[Address(RVA = "0x579A8C0", Offset = "0x57994C0", VA = "0x18579A8C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00015330 File Offset: 0x00013530
		[Token(Token = "0x170002C1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwzz
		{
			[Token(Token = "0x6000E05")]
			[Address(RVA = "0x5798BE0", Offset = "0x57977E0", VA = "0x185798BE0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x00015348 File Offset: 0x00013548
		[Token(Token = "0x170002C2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwzw
		{
			[Token(Token = "0x6000E06")]
			[Address(RVA = "0x5798B50", Offset = "0x5797750", VA = "0x185798B50")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00015360 File Offset: 0x00013560
		[Token(Token = "0x170002C3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwwx
		{
			[Token(Token = "0x6000E07")]
			[Address(RVA = "0x5798940", Offset = "0x5797540", VA = "0x185798940")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00015378 File Offset: 0x00013578
		[Token(Token = "0x170002C4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwwy
		{
			[Token(Token = "0x6000E08")]
			[Address(RVA = "0x5798960", Offset = "0x5797560", VA = "0x185798960")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00015390 File Offset: 0x00013590
		[Token(Token = "0x170002C5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwwz
		{
			[Token(Token = "0x6000E09")]
			[Address(RVA = "0x5798980", Offset = "0x5797580", VA = "0x185798980")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000153A8 File Offset: 0x000135A8
		[Token(Token = "0x170002C6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xwww
		{
			[Token(Token = "0x6000E0A")]
			[Address(RVA = "0x5798920", Offset = "0x5797520", VA = "0x185798920")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x000153C0 File Offset: 0x000135C0
		[Token(Token = "0x170002C7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxxx
		{
			[Token(Token = "0x6000E0B")]
			[Address(RVA = "0x57838F0", Offset = "0x57824F0", VA = "0x1857838F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x000153D8 File Offset: 0x000135D8
		[Token(Token = "0x170002C8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxxy
		{
			[Token(Token = "0x6000E0C")]
			[Address(RVA = "0x5783910", Offset = "0x5782510", VA = "0x185783910")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x000153F0 File Offset: 0x000135F0
		[Token(Token = "0x170002C9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxxz
		{
			[Token(Token = "0x6000E0D")]
			[Address(RVA = "0x578A280", Offset = "0x5788E80", VA = "0x18578A280")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x00015408 File Offset: 0x00013608
		[Token(Token = "0x170002CA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxxw
		{
			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0x57993A0", Offset = "0x5797FA0", VA = "0x1857993A0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00015420 File Offset: 0x00013620
		[Token(Token = "0x170002CB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxyx
		{
			[Token(Token = "0x6000E0F")]
			[Address(RVA = "0x5783950", Offset = "0x5782550", VA = "0x185783950")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x00015438 File Offset: 0x00013638
		[Token(Token = "0x170002CC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxyy
		{
			[Token(Token = "0x6000E10")]
			[Address(RVA = "0x5783970", Offset = "0x5782570", VA = "0x185783970")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00015450 File Offset: 0x00013650
		[Token(Token = "0x170002CD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxyz
		{
			[Token(Token = "0x6000E11")]
			[Address(RVA = "0x578A2A0", Offset = "0x5788EA0", VA = "0x18578A2A0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00015468 File Offset: 0x00013668
		[Token(Token = "0x170002CE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxyw
		{
			[Token(Token = "0x6000E12")]
			[Address(RVA = "0x57993C0", Offset = "0x5797FC0", VA = "0x1857993C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00015480 File Offset: 0x00013680
		[Token(Token = "0x170002CF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxzx
		{
			[Token(Token = "0x6000E13")]
			[Address(RVA = "0x578A2F0", Offset = "0x5788EF0", VA = "0x18578A2F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00015498 File Offset: 0x00013698
		[Token(Token = "0x170002D0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxzy
		{
			[Token(Token = "0x6000E14")]
			[Address(RVA = "0x578A320", Offset = "0x5788F20", VA = "0x18578A320")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x000154B0 File Offset: 0x000136B0
		[Token(Token = "0x170002D1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxzz
		{
			[Token(Token = "0x6000E15")]
			[Address(RVA = "0x578A350", Offset = "0x5788F50", VA = "0x18578A350")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x000154C8 File Offset: 0x000136C8
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxzw
		{
			[Token(Token = "0x6000E16")]
			[Address(RVA = "0x57993F0", Offset = "0x5797FF0", VA = "0x1857993F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E17")]
			[Address(RVA = "0x579AA50", Offset = "0x5799650", VA = "0x18579AA50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x000154E0 File Offset: 0x000136E0
		[Token(Token = "0x170002D3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxwx
		{
			[Token(Token = "0x6000E18")]
			[Address(RVA = "0x5799310", Offset = "0x5797F10", VA = "0x185799310")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x000154F8 File Offset: 0x000136F8
		[Token(Token = "0x170002D4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxwy
		{
			[Token(Token = "0x6000E19")]
			[Address(RVA = "0x5799340", Offset = "0x5797F40", VA = "0x185799340")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00015510 File Offset: 0x00013710
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxwz
		{
			[Token(Token = "0x6000E1A")]
			[Address(RVA = "0x5799370", Offset = "0x5797F70", VA = "0x185799370")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E1B")]
			[Address(RVA = "0x579AA30", Offset = "0x5799630", VA = "0x18579AA30")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00015528 File Offset: 0x00013728
		[Token(Token = "0x170002D6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxww
		{
			[Token(Token = "0x6000E1C")]
			[Address(RVA = "0x57992F0", Offset = "0x5797EF0", VA = "0x1857992F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x00015540 File Offset: 0x00013740
		[Token(Token = "0x170002D7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyxx
		{
			[Token(Token = "0x6000E1D")]
			[Address(RVA = "0x57839C0", Offset = "0x57825C0", VA = "0x1857839C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00015558 File Offset: 0x00013758
		[Token(Token = "0x170002D8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyxy
		{
			[Token(Token = "0x6000E1E")]
			[Address(RVA = "0x57839E0", Offset = "0x57825E0", VA = "0x1857839E0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00015570 File Offset: 0x00013770
		[Token(Token = "0x170002D9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyxz
		{
			[Token(Token = "0x6000E1F")]
			[Address(RVA = "0x578A370", Offset = "0x5788F70", VA = "0x18578A370")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00015588 File Offset: 0x00013788
		[Token(Token = "0x170002DA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyxw
		{
			[Token(Token = "0x6000E20")]
			[Address(RVA = "0x57994C0", Offset = "0x57980C0", VA = "0x1857994C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x000155A0 File Offset: 0x000137A0
		[Token(Token = "0x170002DB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyyx
		{
			[Token(Token = "0x6000E21")]
			[Address(RVA = "0x5783A20", Offset = "0x5782620", VA = "0x185783A20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x000155B8 File Offset: 0x000137B8
		[Token(Token = "0x170002DC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyyy
		{
			[Token(Token = "0x6000E22")]
			[Address(RVA = "0x5783A40", Offset = "0x5782640", VA = "0x185783A40")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x000155D0 File Offset: 0x000137D0
		[Token(Token = "0x170002DD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyyz
		{
			[Token(Token = "0x6000E23")]
			[Address(RVA = "0x578A390", Offset = "0x5788F90", VA = "0x18578A390")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x000155E8 File Offset: 0x000137E8
		[Token(Token = "0x170002DE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyyw
		{
			[Token(Token = "0x6000E24")]
			[Address(RVA = "0x57994E0", Offset = "0x57980E0", VA = "0x1857994E0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x00015600 File Offset: 0x00013800
		[Token(Token = "0x170002DF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyzx
		{
			[Token(Token = "0x6000E25")]
			[Address(RVA = "0x578A3D0", Offset = "0x5788FD0", VA = "0x18578A3D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00015618 File Offset: 0x00013818
		[Token(Token = "0x170002E0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyzy
		{
			[Token(Token = "0x6000E26")]
			[Address(RVA = "0x578A3F0", Offset = "0x5788FF0", VA = "0x18578A3F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00015630 File Offset: 0x00013830
		[Token(Token = "0x170002E1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyzz
		{
			[Token(Token = "0x6000E27")]
			[Address(RVA = "0x578A410", Offset = "0x5789010", VA = "0x18578A410")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00015648 File Offset: 0x00013848
		[Token(Token = "0x170002E2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyzw
		{
			[Token(Token = "0x6000E28")]
			[Address(RVA = "0x5799500", Offset = "0x5798100", VA = "0x185799500")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x00015660 File Offset: 0x00013860
		[Token(Token = "0x170002E3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yywx
		{
			[Token(Token = "0x6000E29")]
			[Address(RVA = "0x5799460", Offset = "0x5798060", VA = "0x185799460")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00015678 File Offset: 0x00013878
		[Token(Token = "0x170002E4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yywy
		{
			[Token(Token = "0x6000E2A")]
			[Address(RVA = "0x5799480", Offset = "0x5798080", VA = "0x185799480")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00015690 File Offset: 0x00013890
		[Token(Token = "0x170002E5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yywz
		{
			[Token(Token = "0x6000E2B")]
			[Address(RVA = "0x57994A0", Offset = "0x57980A0", VA = "0x1857994A0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x000156A8 File Offset: 0x000138A8
		[Token(Token = "0x170002E6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyww
		{
			[Token(Token = "0x6000E2C")]
			[Address(RVA = "0x5799440", Offset = "0x5798040", VA = "0x185799440")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x000156C0 File Offset: 0x000138C0
		[Token(Token = "0x170002E7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzxx
		{
			[Token(Token = "0x6000E2D")]
			[Address(RVA = "0x578A470", Offset = "0x5789070", VA = "0x18578A470")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x000156D8 File Offset: 0x000138D8
		[Token(Token = "0x170002E8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzxy
		{
			[Token(Token = "0x6000E2E")]
			[Address(RVA = "0x578A490", Offset = "0x5789090", VA = "0x18578A490")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x000156F0 File Offset: 0x000138F0
		[Token(Token = "0x170002E9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzxz
		{
			[Token(Token = "0x6000E2F")]
			[Address(RVA = "0x578A4C0", Offset = "0x57890C0", VA = "0x18578A4C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00015708 File Offset: 0x00013908
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzxw
		{
			[Token(Token = "0x6000E30")]
			[Address(RVA = "0x57995F0", Offset = "0x57981F0", VA = "0x1857995F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E31")]
			[Address(RVA = "0x579AAB0", Offset = "0x57996B0", VA = "0x18579AAB0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00015720 File Offset: 0x00013920
		[Token(Token = "0x170002EB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzyx
		{
			[Token(Token = "0x6000E32")]
			[Address(RVA = "0x578A510", Offset = "0x5789110", VA = "0x18578A510")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00015738 File Offset: 0x00013938
		[Token(Token = "0x170002EC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzyy
		{
			[Token(Token = "0x6000E33")]
			[Address(RVA = "0x578A540", Offset = "0x5789140", VA = "0x18578A540")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00015750 File Offset: 0x00013950
		[Token(Token = "0x170002ED")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzyz
		{
			[Token(Token = "0x6000E34")]
			[Address(RVA = "0x578A560", Offset = "0x5789160", VA = "0x18578A560")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x00015768 File Offset: 0x00013968
		[Token(Token = "0x170002EE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzyw
		{
			[Token(Token = "0x6000E35")]
			[Address(RVA = "0x5799620", Offset = "0x5798220", VA = "0x185799620")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00015780 File Offset: 0x00013980
		[Token(Token = "0x170002EF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzzx
		{
			[Token(Token = "0x6000E36")]
			[Address(RVA = "0x578A5B0", Offset = "0x57891B0", VA = "0x18578A5B0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00015798 File Offset: 0x00013998
		[Token(Token = "0x170002F0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzzy
		{
			[Token(Token = "0x6000E37")]
			[Address(RVA = "0x578A5D0", Offset = "0x57891D0", VA = "0x18578A5D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x000157B0 File Offset: 0x000139B0
		[Token(Token = "0x170002F1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzzz
		{
			[Token(Token = "0x6000E38")]
			[Address(RVA = "0x578A5F0", Offset = "0x57891F0", VA = "0x18578A5F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x000157C8 File Offset: 0x000139C8
		[Token(Token = "0x170002F2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzzw
		{
			[Token(Token = "0x6000E39")]
			[Address(RVA = "0x5799650", Offset = "0x5798250", VA = "0x185799650")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x000157E0 File Offset: 0x000139E0
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzwx
		{
			[Token(Token = "0x6000E3A")]
			[Address(RVA = "0x5799560", Offset = "0x5798160", VA = "0x185799560")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E3B")]
			[Address(RVA = "0x579AA90", Offset = "0x5799690", VA = "0x18579AA90")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x000157F8 File Offset: 0x000139F8
		[Token(Token = "0x170002F4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzwy
		{
			[Token(Token = "0x6000E3C")]
			[Address(RVA = "0x5799590", Offset = "0x5798190", VA = "0x185799590")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x00015810 File Offset: 0x00013A10
		[Token(Token = "0x170002F5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzwz
		{
			[Token(Token = "0x6000E3D")]
			[Address(RVA = "0x57995C0", Offset = "0x57981C0", VA = "0x1857995C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00015828 File Offset: 0x00013A28
		[Token(Token = "0x170002F6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzww
		{
			[Token(Token = "0x6000E3E")]
			[Address(RVA = "0x5799540", Offset = "0x5798140", VA = "0x185799540")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00015840 File Offset: 0x00013A40
		[Token(Token = "0x170002F7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywxx
		{
			[Token(Token = "0x6000E3F")]
			[Address(RVA = "0x57990B0", Offset = "0x5797CB0", VA = "0x1857990B0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00015858 File Offset: 0x00013A58
		[Token(Token = "0x170002F8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywxy
		{
			[Token(Token = "0x6000E40")]
			[Address(RVA = "0x57990D0", Offset = "0x5797CD0", VA = "0x1857990D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00015870 File Offset: 0x00013A70
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywxz
		{
			[Token(Token = "0x6000E41")]
			[Address(RVA = "0x5799100", Offset = "0x5797D00", VA = "0x185799100")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E42")]
			[Address(RVA = "0x579A9B0", Offset = "0x57995B0", VA = "0x18579A9B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00015888 File Offset: 0x00013A88
		[Token(Token = "0x170002FA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywxw
		{
			[Token(Token = "0x6000E43")]
			[Address(RVA = "0x5799080", Offset = "0x5797C80", VA = "0x185799080")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x000158A0 File Offset: 0x00013AA0
		[Token(Token = "0x170002FB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywyx
		{
			[Token(Token = "0x6000E44")]
			[Address(RVA = "0x5799180", Offset = "0x5797D80", VA = "0x185799180")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x000158B8 File Offset: 0x00013AB8
		[Token(Token = "0x170002FC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywyy
		{
			[Token(Token = "0x6000E45")]
			[Address(RVA = "0x57991B0", Offset = "0x5797DB0", VA = "0x1857991B0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x000158D0 File Offset: 0x00013AD0
		[Token(Token = "0x170002FD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywyz
		{
			[Token(Token = "0x6000E46")]
			[Address(RVA = "0x57991D0", Offset = "0x5797DD0", VA = "0x1857991D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x000158E8 File Offset: 0x00013AE8
		[Token(Token = "0x170002FE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywyw
		{
			[Token(Token = "0x6000E47")]
			[Address(RVA = "0x5799150", Offset = "0x5797D50", VA = "0x185799150")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00015900 File Offset: 0x00013B00
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywzx
		{
			[Token(Token = "0x6000E48")]
			[Address(RVA = "0x5799250", Offset = "0x5797E50", VA = "0x185799250")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E49")]
			[Address(RVA = "0x579A9F0", Offset = "0x57995F0", VA = "0x18579A9F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00015918 File Offset: 0x00013B18
		[Token(Token = "0x17000300")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywzy
		{
			[Token(Token = "0x6000E4A")]
			[Address(RVA = "0x5799280", Offset = "0x5797E80", VA = "0x185799280")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x00015930 File Offset: 0x00013B30
		[Token(Token = "0x17000301")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywzz
		{
			[Token(Token = "0x6000E4B")]
			[Address(RVA = "0x57992B0", Offset = "0x5797EB0", VA = "0x1857992B0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00015948 File Offset: 0x00013B48
		[Token(Token = "0x17000302")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywzw
		{
			[Token(Token = "0x6000E4C")]
			[Address(RVA = "0x5799220", Offset = "0x5797E20", VA = "0x185799220")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00015960 File Offset: 0x00013B60
		[Token(Token = "0x17000303")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywwx
		{
			[Token(Token = "0x6000E4D")]
			[Address(RVA = "0x5799000", Offset = "0x5797C00", VA = "0x185799000")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00015978 File Offset: 0x00013B78
		[Token(Token = "0x17000304")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywwy
		{
			[Token(Token = "0x6000E4E")]
			[Address(RVA = "0x5799020", Offset = "0x5797C20", VA = "0x185799020")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00015990 File Offset: 0x00013B90
		[Token(Token = "0x17000305")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywwz
		{
			[Token(Token = "0x6000E4F")]
			[Address(RVA = "0x5799040", Offset = "0x5797C40", VA = "0x185799040")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x000159A8 File Offset: 0x00013BA8
		[Token(Token = "0x17000306")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 ywww
		{
			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x5798FE0", Offset = "0x5797BE0", VA = "0x185798FE0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x000159C0 File Offset: 0x00013BC0
		[Token(Token = "0x17000307")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxxx
		{
			[Token(Token = "0x6000E51")]
			[Address(RVA = "0x578A650", Offset = "0x5789250", VA = "0x18578A650")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x000159D8 File Offset: 0x00013BD8
		[Token(Token = "0x17000308")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxxy
		{
			[Token(Token = "0x6000E52")]
			[Address(RVA = "0x578A670", Offset = "0x5789270", VA = "0x18578A670")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x000159F0 File Offset: 0x00013BF0
		[Token(Token = "0x17000309")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxxz
		{
			[Token(Token = "0x6000E53")]
			[Address(RVA = "0x578A690", Offset = "0x5789290", VA = "0x18578A690")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00015A08 File Offset: 0x00013C08
		[Token(Token = "0x1700030A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxxw
		{
			[Token(Token = "0x6000E54")]
			[Address(RVA = "0x5799A70", Offset = "0x5798670", VA = "0x185799A70")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00015A20 File Offset: 0x00013C20
		[Token(Token = "0x1700030B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxyx
		{
			[Token(Token = "0x6000E55")]
			[Address(RVA = "0x578A6D0", Offset = "0x57892D0", VA = "0x18578A6D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00015A38 File Offset: 0x00013C38
		[Token(Token = "0x1700030C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxyy
		{
			[Token(Token = "0x6000E56")]
			[Address(RVA = "0x578A700", Offset = "0x5789300", VA = "0x18578A700")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00015A50 File Offset: 0x00013C50
		[Token(Token = "0x1700030D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxyz
		{
			[Token(Token = "0x6000E57")]
			[Address(RVA = "0x578A720", Offset = "0x5789320", VA = "0x18578A720")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00015A68 File Offset: 0x00013C68
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxyw
		{
			[Token(Token = "0x6000E58")]
			[Address(RVA = "0x5799A90", Offset = "0x5798690", VA = "0x185799A90")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E59")]
			[Address(RVA = "0x579ABA0", Offset = "0x57997A0", VA = "0x18579ABA0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00015A80 File Offset: 0x00013C80
		[Token(Token = "0x1700030F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxzx
		{
			[Token(Token = "0x6000E5A")]
			[Address(RVA = "0x578A770", Offset = "0x5789370", VA = "0x18578A770")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x00015A98 File Offset: 0x00013C98
		[Token(Token = "0x17000310")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxzy
		{
			[Token(Token = "0x6000E5B")]
			[Address(RVA = "0x578A790", Offset = "0x5789390", VA = "0x18578A790")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00015AB0 File Offset: 0x00013CB0
		[Token(Token = "0x17000311")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxzz
		{
			[Token(Token = "0x6000E5C")]
			[Address(RVA = "0x578A7C0", Offset = "0x57893C0", VA = "0x18578A7C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00015AC8 File Offset: 0x00013CC8
		[Token(Token = "0x17000312")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxzw
		{
			[Token(Token = "0x6000E5D")]
			[Address(RVA = "0x5799AC0", Offset = "0x57986C0", VA = "0x185799AC0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00015AE0 File Offset: 0x00013CE0
		[Token(Token = "0x17000313")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxwx
		{
			[Token(Token = "0x6000E5E")]
			[Address(RVA = "0x57999E0", Offset = "0x57985E0", VA = "0x1857999E0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00015AF8 File Offset: 0x00013CF8
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000314")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxwy
		{
			[Token(Token = "0x6000E5F")]
			[Address(RVA = "0x5799A10", Offset = "0x5798610", VA = "0x185799A10")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E60")]
			[Address(RVA = "0x579AB80", Offset = "0x5799780", VA = "0x18579AB80")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00015B10 File Offset: 0x00013D10
		[Token(Token = "0x17000315")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxwz
		{
			[Token(Token = "0x6000E61")]
			[Address(RVA = "0x5799A40", Offset = "0x5798640", VA = "0x185799A40")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00015B28 File Offset: 0x00013D28
		[Token(Token = "0x17000316")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxww
		{
			[Token(Token = "0x6000E62")]
			[Address(RVA = "0x57999C0", Offset = "0x57985C0", VA = "0x1857999C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00015B40 File Offset: 0x00013D40
		[Token(Token = "0x17000317")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyxx
		{
			[Token(Token = "0x6000E63")]
			[Address(RVA = "0x578A820", Offset = "0x5789420", VA = "0x18578A820")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00015B58 File Offset: 0x00013D58
		[Token(Token = "0x17000318")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyxy
		{
			[Token(Token = "0x6000E64")]
			[Address(RVA = "0x578A840", Offset = "0x5789440", VA = "0x18578A840")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00015B70 File Offset: 0x00013D70
		[Token(Token = "0x17000319")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyxz
		{
			[Token(Token = "0x6000E65")]
			[Address(RVA = "0x578A870", Offset = "0x5789470", VA = "0x18578A870")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00015B88 File Offset: 0x00013D88
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyxw
		{
			[Token(Token = "0x6000E66")]
			[Address(RVA = "0x5799BC0", Offset = "0x57987C0", VA = "0x185799BC0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E67")]
			[Address(RVA = "0x579AC00", Offset = "0x5799800", VA = "0x18579AC00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00015BA0 File Offset: 0x00013DA0
		[Token(Token = "0x1700031B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyyx
		{
			[Token(Token = "0x6000E68")]
			[Address(RVA = "0x578A8C0", Offset = "0x57894C0", VA = "0x18578A8C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00015BB8 File Offset: 0x00013DB8
		[Token(Token = "0x1700031C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyyy
		{
			[Token(Token = "0x6000E69")]
			[Address(RVA = "0x578A8E0", Offset = "0x57894E0", VA = "0x18578A8E0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00015BD0 File Offset: 0x00013DD0
		[Token(Token = "0x1700031D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyyz
		{
			[Token(Token = "0x6000E6A")]
			[Address(RVA = "0x578A900", Offset = "0x5789500", VA = "0x18578A900")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00015BE8 File Offset: 0x00013DE8
		[Token(Token = "0x1700031E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyyw
		{
			[Token(Token = "0x6000E6B")]
			[Address(RVA = "0x5799BF0", Offset = "0x57987F0", VA = "0x185799BF0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00015C00 File Offset: 0x00013E00
		[Token(Token = "0x1700031F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyzx
		{
			[Token(Token = "0x6000E6C")]
			[Address(RVA = "0x578A940", Offset = "0x5789540", VA = "0x18578A940")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00015C18 File Offset: 0x00013E18
		[Token(Token = "0x17000320")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyzy
		{
			[Token(Token = "0x6000E6D")]
			[Address(RVA = "0x578A970", Offset = "0x5789570", VA = "0x18578A970")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00015C30 File Offset: 0x00013E30
		[Token(Token = "0x17000321")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyzz
		{
			[Token(Token = "0x6000E6E")]
			[Address(RVA = "0x578A9A0", Offset = "0x57895A0", VA = "0x18578A9A0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00015C48 File Offset: 0x00013E48
		[Token(Token = "0x17000322")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyzw
		{
			[Token(Token = "0x6000E6F")]
			[Address(RVA = "0x5799C10", Offset = "0x5798810", VA = "0x185799C10")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x00015C60 File Offset: 0x00013E60
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000323")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zywx
		{
			[Token(Token = "0x6000E70")]
			[Address(RVA = "0x5799B30", Offset = "0x5798730", VA = "0x185799B30")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E71")]
			[Address(RVA = "0x579ABE0", Offset = "0x57997E0", VA = "0x18579ABE0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x00015C78 File Offset: 0x00013E78
		[Token(Token = "0x17000324")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zywy
		{
			[Token(Token = "0x6000E72")]
			[Address(RVA = "0x5799B60", Offset = "0x5798760", VA = "0x185799B60")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x00015C90 File Offset: 0x00013E90
		[Token(Token = "0x17000325")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zywz
		{
			[Token(Token = "0x6000E73")]
			[Address(RVA = "0x5799B90", Offset = "0x5798790", VA = "0x185799B90")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00015CA8 File Offset: 0x00013EA8
		[Token(Token = "0x17000326")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyww
		{
			[Token(Token = "0x6000E74")]
			[Address(RVA = "0x5799B10", Offset = "0x5798710", VA = "0x185799B10")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00015CC0 File Offset: 0x00013EC0
		[Token(Token = "0x17000327")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzxx
		{
			[Token(Token = "0x6000E75")]
			[Address(RVA = "0x578A9F0", Offset = "0x57895F0", VA = "0x18578A9F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00015CD8 File Offset: 0x00013ED8
		[Token(Token = "0x17000328")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzxy
		{
			[Token(Token = "0x6000E76")]
			[Address(RVA = "0x578AA10", Offset = "0x5789610", VA = "0x18578AA10")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00015CF0 File Offset: 0x00013EF0
		[Token(Token = "0x17000329")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzxz
		{
			[Token(Token = "0x6000E77")]
			[Address(RVA = "0x578AA30", Offset = "0x5789630", VA = "0x18578AA30")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00015D08 File Offset: 0x00013F08
		[Token(Token = "0x1700032A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzxw
		{
			[Token(Token = "0x6000E78")]
			[Address(RVA = "0x5799CE0", Offset = "0x57988E0", VA = "0x185799CE0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00015D20 File Offset: 0x00013F20
		[Token(Token = "0x1700032B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzyx
		{
			[Token(Token = "0x6000E79")]
			[Address(RVA = "0x578AA70", Offset = "0x5789670", VA = "0x18578AA70")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00015D38 File Offset: 0x00013F38
		[Token(Token = "0x1700032C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzyy
		{
			[Token(Token = "0x6000E7A")]
			[Address(RVA = "0x578AA90", Offset = "0x5789690", VA = "0x18578AA90")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x00015D50 File Offset: 0x00013F50
		[Token(Token = "0x1700032D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzyz
		{
			[Token(Token = "0x6000E7B")]
			[Address(RVA = "0x578AAB0", Offset = "0x57896B0", VA = "0x18578AAB0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00015D68 File Offset: 0x00013F68
		[Token(Token = "0x1700032E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzyw
		{
			[Token(Token = "0x6000E7C")]
			[Address(RVA = "0x5799D00", Offset = "0x5798900", VA = "0x185799D00")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00015D80 File Offset: 0x00013F80
		[Token(Token = "0x1700032F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzzx
		{
			[Token(Token = "0x6000E7D")]
			[Address(RVA = "0x578AAF0", Offset = "0x57896F0", VA = "0x18578AAF0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00015D98 File Offset: 0x00013F98
		[Token(Token = "0x17000330")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzzy
		{
			[Token(Token = "0x6000E7E")]
			[Address(RVA = "0x578AB10", Offset = "0x5789710", VA = "0x18578AB10")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x00015DB0 File Offset: 0x00013FB0
		[Token(Token = "0x17000331")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzzz
		{
			[Token(Token = "0x6000E7F")]
			[Address(RVA = "0x578AB30", Offset = "0x5789730", VA = "0x18578AB30")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00015DC8 File Offset: 0x00013FC8
		[Token(Token = "0x17000332")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzzw
		{
			[Token(Token = "0x6000E80")]
			[Address(RVA = "0x5799D20", Offset = "0x5798920", VA = "0x185799D20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x00015DE0 File Offset: 0x00013FE0
		[Token(Token = "0x17000333")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzwx
		{
			[Token(Token = "0x6000E81")]
			[Address(RVA = "0x5799C80", Offset = "0x5798880", VA = "0x185799C80")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00015DF8 File Offset: 0x00013FF8
		[Token(Token = "0x17000334")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzwy
		{
			[Token(Token = "0x6000E82")]
			[Address(RVA = "0x5799CA0", Offset = "0x57988A0", VA = "0x185799CA0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x00015E10 File Offset: 0x00014010
		[Token(Token = "0x17000335")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzwz
		{
			[Token(Token = "0x6000E83")]
			[Address(RVA = "0x5799CC0", Offset = "0x57988C0", VA = "0x185799CC0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00015E28 File Offset: 0x00014028
		[Token(Token = "0x17000336")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzww
		{
			[Token(Token = "0x6000E84")]
			[Address(RVA = "0x5799C60", Offset = "0x5798860", VA = "0x185799C60")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x00015E40 File Offset: 0x00014040
		[Token(Token = "0x17000337")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwxx
		{
			[Token(Token = "0x6000E85")]
			[Address(RVA = "0x5799780", Offset = "0x5798380", VA = "0x185799780")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00015E58 File Offset: 0x00014058
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000338")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwxy
		{
			[Token(Token = "0x6000E86")]
			[Address(RVA = "0x57997A0", Offset = "0x57983A0", VA = "0x1857997A0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E87")]
			[Address(RVA = "0x579AB00", Offset = "0x5799700", VA = "0x18579AB00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00015E70 File Offset: 0x00014070
		[Token(Token = "0x17000339")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwxz
		{
			[Token(Token = "0x6000E88")]
			[Address(RVA = "0x57997D0", Offset = "0x57983D0", VA = "0x1857997D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x00015E88 File Offset: 0x00014088
		[Token(Token = "0x1700033A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwxw
		{
			[Token(Token = "0x6000E89")]
			[Address(RVA = "0x5799750", Offset = "0x5798350", VA = "0x185799750")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00015EA0 File Offset: 0x000140A0
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwyx
		{
			[Token(Token = "0x6000E8A")]
			[Address(RVA = "0x5799850", Offset = "0x5798450", VA = "0x185799850")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E8B")]
			[Address(RVA = "0x579AB40", Offset = "0x5799740", VA = "0x18579AB40")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00015EB8 File Offset: 0x000140B8
		[Token(Token = "0x1700033C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwyy
		{
			[Token(Token = "0x6000E8C")]
			[Address(RVA = "0x5799880", Offset = "0x5798480", VA = "0x185799880")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00015ED0 File Offset: 0x000140D0
		[Token(Token = "0x1700033D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwyz
		{
			[Token(Token = "0x6000E8D")]
			[Address(RVA = "0x57998A0", Offset = "0x57984A0", VA = "0x1857998A0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00015EE8 File Offset: 0x000140E8
		[Token(Token = "0x1700033E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwyw
		{
			[Token(Token = "0x6000E8E")]
			[Address(RVA = "0x5799820", Offset = "0x5798420", VA = "0x185799820")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00015F00 File Offset: 0x00014100
		[Token(Token = "0x1700033F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwzx
		{
			[Token(Token = "0x6000E8F")]
			[Address(RVA = "0x5799920", Offset = "0x5798520", VA = "0x185799920")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00015F18 File Offset: 0x00014118
		[Token(Token = "0x17000340")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwzy
		{
			[Token(Token = "0x6000E90")]
			[Address(RVA = "0x5799950", Offset = "0x5798550", VA = "0x185799950")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x00015F30 File Offset: 0x00014130
		[Token(Token = "0x17000341")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwzz
		{
			[Token(Token = "0x6000E91")]
			[Address(RVA = "0x5799980", Offset = "0x5798580", VA = "0x185799980")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00015F48 File Offset: 0x00014148
		[Token(Token = "0x17000342")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwzw
		{
			[Token(Token = "0x6000E92")]
			[Address(RVA = "0x57998F0", Offset = "0x57984F0", VA = "0x1857998F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00015F60 File Offset: 0x00014160
		[Token(Token = "0x17000343")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwwx
		{
			[Token(Token = "0x6000E93")]
			[Address(RVA = "0x57996D0", Offset = "0x57982D0", VA = "0x1857996D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00015F78 File Offset: 0x00014178
		[Token(Token = "0x17000344")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwwy
		{
			[Token(Token = "0x6000E94")]
			[Address(RVA = "0x57996F0", Offset = "0x57982F0", VA = "0x1857996F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x00015F90 File Offset: 0x00014190
		[Token(Token = "0x17000345")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwwz
		{
			[Token(Token = "0x6000E95")]
			[Address(RVA = "0x5799710", Offset = "0x5798310", VA = "0x185799710")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00015FA8 File Offset: 0x000141A8
		[Token(Token = "0x17000346")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zwww
		{
			[Token(Token = "0x6000E96")]
			[Address(RVA = "0x57996B0", Offset = "0x57982B0", VA = "0x1857996B0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x00015FC0 File Offset: 0x000141C0
		[Token(Token = "0x17000347")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxxx
		{
			[Token(Token = "0x6000E97")]
			[Address(RVA = "0x5798080", Offset = "0x5796C80", VA = "0x185798080")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00015FD8 File Offset: 0x000141D8
		[Token(Token = "0x17000348")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxxy
		{
			[Token(Token = "0x6000E98")]
			[Address(RVA = "0x57980A0", Offset = "0x5796CA0", VA = "0x1857980A0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00015FF0 File Offset: 0x000141F0
		[Token(Token = "0x17000349")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxxz
		{
			[Token(Token = "0x6000E99")]
			[Address(RVA = "0x57980C0", Offset = "0x5796CC0", VA = "0x1857980C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00016008 File Offset: 0x00014208
		[Token(Token = "0x1700034A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxxw
		{
			[Token(Token = "0x6000E9A")]
			[Address(RVA = "0x5798060", Offset = "0x5796C60", VA = "0x185798060")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x00016020 File Offset: 0x00014220
		[Token(Token = "0x1700034B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxyx
		{
			[Token(Token = "0x6000E9B")]
			[Address(RVA = "0x5798130", Offset = "0x5796D30", VA = "0x185798130")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x00016038 File Offset: 0x00014238
		[Token(Token = "0x1700034C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxyy
		{
			[Token(Token = "0x6000E9C")]
			[Address(RVA = "0x5798160", Offset = "0x5796D60", VA = "0x185798160")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00016050 File Offset: 0x00014250
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxyz
		{
			[Token(Token = "0x6000E9D")]
			[Address(RVA = "0x5798180", Offset = "0x5796D80", VA = "0x185798180")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000E9E")]
			[Address(RVA = "0x579A6D0", Offset = "0x57992D0", VA = "0x18579A6D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x00016068 File Offset: 0x00014268
		[Token(Token = "0x1700034E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxyw
		{
			[Token(Token = "0x6000E9F")]
			[Address(RVA = "0x5798100", Offset = "0x5796D00", VA = "0x185798100")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x00016080 File Offset: 0x00014280
		[Token(Token = "0x1700034F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxzx
		{
			[Token(Token = "0x6000EA0")]
			[Address(RVA = "0x5798200", Offset = "0x5796E00", VA = "0x185798200")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00016098 File Offset: 0x00014298
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000350")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxzy
		{
			[Token(Token = "0x6000EA1")]
			[Address(RVA = "0x5798230", Offset = "0x5796E30", VA = "0x185798230")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000EA2")]
			[Address(RVA = "0x579A710", Offset = "0x5799310", VA = "0x18579A710")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x000160B0 File Offset: 0x000142B0
		[Token(Token = "0x17000351")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxzz
		{
			[Token(Token = "0x6000EA3")]
			[Address(RVA = "0x5798260", Offset = "0x5796E60", VA = "0x185798260")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x000160C8 File Offset: 0x000142C8
		[Token(Token = "0x17000352")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxzw
		{
			[Token(Token = "0x6000EA4")]
			[Address(RVA = "0x57981D0", Offset = "0x5796DD0", VA = "0x1857981D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x000160E0 File Offset: 0x000142E0
		[Token(Token = "0x17000353")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxwx
		{
			[Token(Token = "0x6000EA5")]
			[Address(RVA = "0x5797FC0", Offset = "0x5796BC0", VA = "0x185797FC0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x000160F8 File Offset: 0x000142F8
		[Token(Token = "0x17000354")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxwy
		{
			[Token(Token = "0x6000EA6")]
			[Address(RVA = "0x5797FE0", Offset = "0x5796BE0", VA = "0x185797FE0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00016110 File Offset: 0x00014310
		[Token(Token = "0x17000355")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxwz
		{
			[Token(Token = "0x6000EA7")]
			[Address(RVA = "0x5798010", Offset = "0x5796C10", VA = "0x185798010")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00016128 File Offset: 0x00014328
		[Token(Token = "0x17000356")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wxww
		{
			[Token(Token = "0x6000EA8")]
			[Address(RVA = "0x5797FA0", Offset = "0x5796BA0", VA = "0x185797FA0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00016140 File Offset: 0x00014340
		[Token(Token = "0x17000357")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyxx
		{
			[Token(Token = "0x6000EA9")]
			[Address(RVA = "0x57983C0", Offset = "0x5796FC0", VA = "0x1857983C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x00016158 File Offset: 0x00014358
		[Token(Token = "0x17000358")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyxy
		{
			[Token(Token = "0x6000EAA")]
			[Address(RVA = "0x57983E0", Offset = "0x5796FE0", VA = "0x1857983E0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00016170 File Offset: 0x00014370
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000359")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyxz
		{
			[Token(Token = "0x6000EAB")]
			[Address(RVA = "0x5798410", Offset = "0x5797010", VA = "0x185798410")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000EAC")]
			[Address(RVA = "0x579A760", Offset = "0x5799360", VA = "0x18579A760")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00016188 File Offset: 0x00014388
		[Token(Token = "0x1700035A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyxw
		{
			[Token(Token = "0x6000EAD")]
			[Address(RVA = "0x5798390", Offset = "0x5796F90", VA = "0x185798390")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x000161A0 File Offset: 0x000143A0
		[Token(Token = "0x1700035B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyyx
		{
			[Token(Token = "0x6000EAE")]
			[Address(RVA = "0x5798480", Offset = "0x5797080", VA = "0x185798480")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x000161B8 File Offset: 0x000143B8
		[Token(Token = "0x1700035C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyyy
		{
			[Token(Token = "0x6000EAF")]
			[Address(RVA = "0x57984A0", Offset = "0x57970A0", VA = "0x1857984A0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x000161D0 File Offset: 0x000143D0
		[Token(Token = "0x1700035D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyyz
		{
			[Token(Token = "0x6000EB0")]
			[Address(RVA = "0x57984C0", Offset = "0x57970C0", VA = "0x1857984C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x000161E8 File Offset: 0x000143E8
		[Token(Token = "0x1700035E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyyw
		{
			[Token(Token = "0x6000EB1")]
			[Address(RVA = "0x5798460", Offset = "0x5797060", VA = "0x185798460")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x00016200 File Offset: 0x00014400
		// (set) Token: 0x06000EB3 RID: 3763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyzx
		{
			[Token(Token = "0x6000EB2")]
			[Address(RVA = "0x5798530", Offset = "0x5797130", VA = "0x185798530")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000EB3")]
			[Address(RVA = "0x579A7A0", Offset = "0x57993A0", VA = "0x18579A7A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x00016218 File Offset: 0x00014418
		[Token(Token = "0x17000360")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyzy
		{
			[Token(Token = "0x6000EB4")]
			[Address(RVA = "0x5798560", Offset = "0x5797160", VA = "0x185798560")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x00016230 File Offset: 0x00014430
		[Token(Token = "0x17000361")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyzz
		{
			[Token(Token = "0x6000EB5")]
			[Address(RVA = "0x5798590", Offset = "0x5797190", VA = "0x185798590")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x00016248 File Offset: 0x00014448
		[Token(Token = "0x17000362")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyzw
		{
			[Token(Token = "0x6000EB6")]
			[Address(RVA = "0x5798500", Offset = "0x5797100", VA = "0x185798500")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00016260 File Offset: 0x00014460
		[Token(Token = "0x17000363")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wywx
		{
			[Token(Token = "0x6000EB7")]
			[Address(RVA = "0x57982E0", Offset = "0x5796EE0", VA = "0x1857982E0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00016278 File Offset: 0x00014478
		[Token(Token = "0x17000364")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wywy
		{
			[Token(Token = "0x6000EB8")]
			[Address(RVA = "0x5798310", Offset = "0x5796F10", VA = "0x185798310")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00016290 File Offset: 0x00014490
		[Token(Token = "0x17000365")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wywz
		{
			[Token(Token = "0x6000EB9")]
			[Address(RVA = "0x5798340", Offset = "0x5796F40", VA = "0x185798340")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x000162A8 File Offset: 0x000144A8
		[Token(Token = "0x17000366")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wyww
		{
			[Token(Token = "0x6000EBA")]
			[Address(RVA = "0x57982C0", Offset = "0x5796EC0", VA = "0x1857982C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x000162C0 File Offset: 0x000144C0
		[Token(Token = "0x17000367")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzxx
		{
			[Token(Token = "0x6000EBB")]
			[Address(RVA = "0x57986F0", Offset = "0x57972F0", VA = "0x1857986F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x000162D8 File Offset: 0x000144D8
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000368")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzxy
		{
			[Token(Token = "0x6000EBC")]
			[Address(RVA = "0x5798710", Offset = "0x5797310", VA = "0x185798710")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000EBD")]
			[Address(RVA = "0x579A7F0", Offset = "0x57993F0", VA = "0x18579A7F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x000162F0 File Offset: 0x000144F0
		[Token(Token = "0x17000369")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzxz
		{
			[Token(Token = "0x6000EBE")]
			[Address(RVA = "0x5798740", Offset = "0x5797340", VA = "0x185798740")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x00016308 File Offset: 0x00014508
		[Token(Token = "0x1700036A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzxw
		{
			[Token(Token = "0x6000EBF")]
			[Address(RVA = "0x57986C0", Offset = "0x57972C0", VA = "0x1857986C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00016320 File Offset: 0x00014520
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzyx
		{
			[Token(Token = "0x6000EC0")]
			[Address(RVA = "0x57987C0", Offset = "0x57973C0", VA = "0x1857987C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
			[Token(Token = "0x6000EC1")]
			[Address(RVA = "0x579A830", Offset = "0x5799430", VA = "0x18579A830")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x00016338 File Offset: 0x00014538
		[Token(Token = "0x1700036C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzyy
		{
			[Token(Token = "0x6000EC2")]
			[Address(RVA = "0x57987F0", Offset = "0x57973F0", VA = "0x1857987F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00016350 File Offset: 0x00014550
		[Token(Token = "0x1700036D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzyz
		{
			[Token(Token = "0x6000EC3")]
			[Address(RVA = "0x5798810", Offset = "0x5797410", VA = "0x185798810")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00016368 File Offset: 0x00014568
		[Token(Token = "0x1700036E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzyw
		{
			[Token(Token = "0x6000EC4")]
			[Address(RVA = "0x5798790", Offset = "0x5797390", VA = "0x185798790")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00016380 File Offset: 0x00014580
		[Token(Token = "0x1700036F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzzx
		{
			[Token(Token = "0x6000EC5")]
			[Address(RVA = "0x5798880", Offset = "0x5797480", VA = "0x185798880")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00016398 File Offset: 0x00014598
		[Token(Token = "0x17000370")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzzy
		{
			[Token(Token = "0x6000EC6")]
			[Address(RVA = "0x57988A0", Offset = "0x57974A0", VA = "0x1857988A0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x000163B0 File Offset: 0x000145B0
		[Token(Token = "0x17000371")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzzz
		{
			[Token(Token = "0x6000EC7")]
			[Address(RVA = "0x57988C0", Offset = "0x57974C0", VA = "0x1857988C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x000163C8 File Offset: 0x000145C8
		[Token(Token = "0x17000372")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzzw
		{
			[Token(Token = "0x6000EC8")]
			[Address(RVA = "0x5798860", Offset = "0x5797460", VA = "0x185798860")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x000163E0 File Offset: 0x000145E0
		[Token(Token = "0x17000373")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzwx
		{
			[Token(Token = "0x6000EC9")]
			[Address(RVA = "0x5798610", Offset = "0x5797210", VA = "0x185798610")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x000163F8 File Offset: 0x000145F8
		[Token(Token = "0x17000374")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzwy
		{
			[Token(Token = "0x6000ECA")]
			[Address(RVA = "0x5798640", Offset = "0x5797240", VA = "0x185798640")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00016410 File Offset: 0x00014610
		[Token(Token = "0x17000375")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzwz
		{
			[Token(Token = "0x6000ECB")]
			[Address(RVA = "0x5798670", Offset = "0x5797270", VA = "0x185798670")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00016428 File Offset: 0x00014628
		[Token(Token = "0x17000376")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wzww
		{
			[Token(Token = "0x6000ECC")]
			[Address(RVA = "0x57985F0", Offset = "0x57971F0", VA = "0x1857985F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x00016440 File Offset: 0x00014640
		[Token(Token = "0x17000377")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwxx
		{
			[Token(Token = "0x6000ECD")]
			[Address(RVA = "0x5797DC0", Offset = "0x57969C0", VA = "0x185797DC0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x00016458 File Offset: 0x00014658
		[Token(Token = "0x17000378")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwxy
		{
			[Token(Token = "0x6000ECE")]
			[Address(RVA = "0x5797DE0", Offset = "0x57969E0", VA = "0x185797DE0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x00016470 File Offset: 0x00014670
		[Token(Token = "0x17000379")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwxz
		{
			[Token(Token = "0x6000ECF")]
			[Address(RVA = "0x5797E00", Offset = "0x5796A00", VA = "0x185797E00")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x00016488 File Offset: 0x00014688
		[Token(Token = "0x1700037A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwxw
		{
			[Token(Token = "0x6000ED0")]
			[Address(RVA = "0x5797DA0", Offset = "0x57969A0", VA = "0x185797DA0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x000164A0 File Offset: 0x000146A0
		[Token(Token = "0x1700037B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwyx
		{
			[Token(Token = "0x6000ED1")]
			[Address(RVA = "0x5797E60", Offset = "0x5796A60", VA = "0x185797E60")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x000164B8 File Offset: 0x000146B8
		[Token(Token = "0x1700037C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwyy
		{
			[Token(Token = "0x6000ED2")]
			[Address(RVA = "0x5797E80", Offset = "0x5796A80", VA = "0x185797E80")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x000164D0 File Offset: 0x000146D0
		[Token(Token = "0x1700037D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwyz
		{
			[Token(Token = "0x6000ED3")]
			[Address(RVA = "0x5797EA0", Offset = "0x5796AA0", VA = "0x185797EA0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x000164E8 File Offset: 0x000146E8
		[Token(Token = "0x1700037E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwyw
		{
			[Token(Token = "0x6000ED4")]
			[Address(RVA = "0x5797E40", Offset = "0x5796A40", VA = "0x185797E40")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x00016500 File Offset: 0x00014700
		[Token(Token = "0x1700037F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwzx
		{
			[Token(Token = "0x6000ED5")]
			[Address(RVA = "0x5797F00", Offset = "0x5796B00", VA = "0x185797F00")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x00016518 File Offset: 0x00014718
		[Token(Token = "0x17000380")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwzy
		{
			[Token(Token = "0x6000ED6")]
			[Address(RVA = "0x5797F20", Offset = "0x5796B20", VA = "0x185797F20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00016530 File Offset: 0x00014730
		[Token(Token = "0x17000381")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwzz
		{
			[Token(Token = "0x6000ED7")]
			[Address(RVA = "0x5797F40", Offset = "0x5796B40", VA = "0x185797F40")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x00016548 File Offset: 0x00014748
		[Token(Token = "0x17000382")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwzw
		{
			[Token(Token = "0x6000ED8")]
			[Address(RVA = "0x5797EE0", Offset = "0x5796AE0", VA = "0x185797EE0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00016560 File Offset: 0x00014760
		[Token(Token = "0x17000383")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwwx
		{
			[Token(Token = "0x6000ED9")]
			[Address(RVA = "0x5797D20", Offset = "0x5796920", VA = "0x185797D20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00016578 File Offset: 0x00014778
		[Token(Token = "0x17000384")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwwy
		{
			[Token(Token = "0x6000EDA")]
			[Address(RVA = "0x5797D40", Offset = "0x5796940", VA = "0x185797D40")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x00016590 File Offset: 0x00014790
		[Token(Token = "0x17000385")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwwz
		{
			[Token(Token = "0x6000EDB")]
			[Address(RVA = "0x5797D60", Offset = "0x5796960", VA = "0x185797D60")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x000165A8 File Offset: 0x000147A8
		[Token(Token = "0x17000386")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 wwww
		{
			[Token(Token = "0x6000EDC")]
			[Address(RVA = "0x5797D00", Offset = "0x5796900", VA = "0x185797D00")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x000165C0 File Offset: 0x000147C0
		[Token(Token = "0x17000387")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xxx
		{
			[Token(Token = "0x6000EDD")]
			[Address(RVA = "0x5783730", Offset = "0x5782330", VA = "0x185783730")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x000165D8 File Offset: 0x000147D8
		[Token(Token = "0x17000388")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xxy
		{
			[Token(Token = "0x6000EDE")]
			[Address(RVA = "0x5783790", Offset = "0x5782390", VA = "0x185783790")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x000165F0 File Offset: 0x000147F0
		[Token(Token = "0x17000389")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xxz
		{
			[Token(Token = "0x6000EDF")]
			[Address(RVA = "0x5789F40", Offset = "0x5788B40", VA = "0x185789F40")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00016608 File Offset: 0x00014808
		[Token(Token = "0x1700038A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xxw
		{
			[Token(Token = "0x6000EE0")]
			[Address(RVA = "0x5798C00", Offset = "0x5797800", VA = "0x185798C00")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00016620 File Offset: 0x00014820
		[Token(Token = "0x1700038B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyx
		{
			[Token(Token = "0x6000EE1")]
			[Address(RVA = "0x57837F0", Offset = "0x57823F0", VA = "0x1857837F0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x00016638 File Offset: 0x00014838
		[Token(Token = "0x1700038C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyy
		{
			[Token(Token = "0x6000EE2")]
			[Address(RVA = "0x5783850", Offset = "0x5782450", VA = "0x185783850")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00016650 File Offset: 0x00014850
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyz
		{
			[Token(Token = "0x6000EE3")]
			[Address(RVA = "0x578A010", Offset = "0x5788C10", VA = "0x18578A010")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000EE4")]
			[Address(RVA = "0x5789DE0", Offset = "0x57889E0", VA = "0x185789DE0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00016668 File Offset: 0x00014868
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyw
		{
			[Token(Token = "0x6000EE5")]
			[Address(RVA = "0x5798D00", Offset = "0x5797900", VA = "0x185798D00")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000EE6")]
			[Address(RVA = "0x579A8E0", Offset = "0x57994E0", VA = "0x18579A8E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00016680 File Offset: 0x00014880
		[Token(Token = "0x1700038F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xzx
		{
			[Token(Token = "0x6000EE7")]
			[Address(RVA = "0x578A0D0", Offset = "0x5788CD0", VA = "0x18578A0D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00016698 File Offset: 0x00014898
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000390")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xzy
		{
			[Token(Token = "0x6000EE8")]
			[Address(RVA = "0x578A160", Offset = "0x5788D60", VA = "0x18578A160")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000EE9")]
			[Address(RVA = "0x578B400", Offset = "0x578A000", VA = "0x18578B400")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x000166B0 File Offset: 0x000148B0
		[Token(Token = "0x17000391")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xzz
		{
			[Token(Token = "0x6000EEA")]
			[Address(RVA = "0x578A200", Offset = "0x5788E00", VA = "0x18578A200")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x000166C8 File Offset: 0x000148C8
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000392")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xzw
		{
			[Token(Token = "0x6000EEB")]
			[Address(RVA = "0x5798E50", Offset = "0x5797A50", VA = "0x185798E50")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000EEC")]
			[Address(RVA = "0x579A920", Offset = "0x5799520", VA = "0x18579A920")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x000166E0 File Offset: 0x000148E0
		[Token(Token = "0x17000393")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xwx
		{
			[Token(Token = "0x6000EED")]
			[Address(RVA = "0x57989A0", Offset = "0x57975A0", VA = "0x1857989A0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x000166F8 File Offset: 0x000148F8
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000394")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xwy
		{
			[Token(Token = "0x6000EEE")]
			[Address(RVA = "0x5798A60", Offset = "0x5797660", VA = "0x185798A60")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000EEF")]
			[Address(RVA = "0x579A860", Offset = "0x5799460", VA = "0x18579A860")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x00016710 File Offset: 0x00014910
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000395")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xwz
		{
			[Token(Token = "0x6000EF0")]
			[Address(RVA = "0x5798B30", Offset = "0x5797730", VA = "0x185798B30")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000EF1")]
			[Address(RVA = "0x579A8A0", Offset = "0x57994A0", VA = "0x18579A8A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x00016728 File Offset: 0x00014928
		[Token(Token = "0x17000396")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xww
		{
			[Token(Token = "0x6000EF2")]
			[Address(RVA = "0x5798900", Offset = "0x5797500", VA = "0x185798900")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x00016740 File Offset: 0x00014940
		[Token(Token = "0x17000397")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yxx
		{
			[Token(Token = "0x6000EF3")]
			[Address(RVA = "0x57838D0", Offset = "0x57824D0", VA = "0x1857838D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00016758 File Offset: 0x00014958
		[Token(Token = "0x17000398")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yxy
		{
			[Token(Token = "0x6000EF4")]
			[Address(RVA = "0x5783930", Offset = "0x5782530", VA = "0x185783930")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00016770 File Offset: 0x00014970
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000399")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yxz
		{
			[Token(Token = "0x6000EF5")]
			[Address(RVA = "0x578A2D0", Offset = "0x5788ED0", VA = "0x18578A2D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000EF6")]
			[Address(RVA = "0x578B420", Offset = "0x578A020", VA = "0x18578B420")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00016788 File Offset: 0x00014988
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yxw
		{
			[Token(Token = "0x6000EF7")]
			[Address(RVA = "0x57992D0", Offset = "0x5797ED0", VA = "0x1857992D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000EF8")]
			[Address(RVA = "0x579AA10", Offset = "0x5799610", VA = "0x18579AA10")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x000167A0 File Offset: 0x000149A0
		[Token(Token = "0x1700039B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yyx
		{
			[Token(Token = "0x6000EF9")]
			[Address(RVA = "0x57839A0", Offset = "0x57825A0", VA = "0x1857839A0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x000167B8 File Offset: 0x000149B8
		[Token(Token = "0x1700039C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yyy
		{
			[Token(Token = "0x6000EFA")]
			[Address(RVA = "0x5783A00", Offset = "0x5782600", VA = "0x185783A00")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x000167D0 File Offset: 0x000149D0
		[Token(Token = "0x1700039D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yyz
		{
			[Token(Token = "0x6000EFB")]
			[Address(RVA = "0x578A3B0", Offset = "0x5788FB0", VA = "0x18578A3B0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x000167E8 File Offset: 0x000149E8
		[Token(Token = "0x1700039E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yyw
		{
			[Token(Token = "0x6000EFC")]
			[Address(RVA = "0x5799420", Offset = "0x5798020", VA = "0x185799420")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00016800 File Offset: 0x00014A00
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yzx
		{
			[Token(Token = "0x6000EFD")]
			[Address(RVA = "0x578A450", Offset = "0x5789050", VA = "0x18578A450")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000EFE")]
			[Address(RVA = "0x578B450", Offset = "0x578A050", VA = "0x18578B450")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00016818 File Offset: 0x00014A18
		[Token(Token = "0x170003A0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yzy
		{
			[Token(Token = "0x6000EFF")]
			[Address(RVA = "0x578A4F0", Offset = "0x57890F0", VA = "0x18578A4F0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00016830 File Offset: 0x00014A30
		[Token(Token = "0x170003A1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yzz
		{
			[Token(Token = "0x6000F00")]
			[Address(RVA = "0x578A590", Offset = "0x5789190", VA = "0x18578A590")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00016848 File Offset: 0x00014A48
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yzw
		{
			[Token(Token = "0x6000F01")]
			[Address(RVA = "0x5799520", Offset = "0x5798120", VA = "0x185799520")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F02")]
			[Address(RVA = "0x579AA70", Offset = "0x5799670", VA = "0x18579AA70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00016860 File Offset: 0x00014A60
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 ywx
		{
			[Token(Token = "0x6000F03")]
			[Address(RVA = "0x5799060", Offset = "0x5797C60", VA = "0x185799060")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F04")]
			[Address(RVA = "0x579A990", Offset = "0x5799590", VA = "0x18579A990")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00016878 File Offset: 0x00014A78
		[Token(Token = "0x170003A4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 ywy
		{
			[Token(Token = "0x6000F05")]
			[Address(RVA = "0x5799130", Offset = "0x5797D30", VA = "0x185799130")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00016890 File Offset: 0x00014A90
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 ywz
		{
			[Token(Token = "0x6000F06")]
			[Address(RVA = "0x5799200", Offset = "0x5797E00", VA = "0x185799200")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F07")]
			[Address(RVA = "0x579A9D0", Offset = "0x57995D0", VA = "0x18579A9D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x000168A8 File Offset: 0x00014AA8
		[Token(Token = "0x170003A6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yww
		{
			[Token(Token = "0x6000F08")]
			[Address(RVA = "0x5798FC0", Offset = "0x5797BC0", VA = "0x185798FC0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x000168C0 File Offset: 0x00014AC0
		[Token(Token = "0x170003A7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zxx
		{
			[Token(Token = "0x6000F09")]
			[Address(RVA = "0x578A630", Offset = "0x5789230", VA = "0x18578A630")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000168D8 File Offset: 0x00014AD8
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zxy
		{
			[Token(Token = "0x6000F0A")]
			[Address(RVA = "0x578A6B0", Offset = "0x57892B0", VA = "0x18578A6B0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F0B")]
			[Address(RVA = "0x578B480", Offset = "0x578A080", VA = "0x18578B480")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x000168F0 File Offset: 0x00014AF0
		[Token(Token = "0x170003A9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zxz
		{
			[Token(Token = "0x6000F0C")]
			[Address(RVA = "0x578A750", Offset = "0x5789350", VA = "0x18578A750")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00016908 File Offset: 0x00014B08
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zxw
		{
			[Token(Token = "0x6000F0D")]
			[Address(RVA = "0x57999A0", Offset = "0x57985A0", VA = "0x1857999A0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F0E")]
			[Address(RVA = "0x579AB60", Offset = "0x5799760", VA = "0x18579AB60")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x00016920 File Offset: 0x00014B20
		// (set) Token: 0x06000F10 RID: 3856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zyx
		{
			[Token(Token = "0x6000F0F")]
			[Address(RVA = "0x578A800", Offset = "0x5789400", VA = "0x18578A800")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F10")]
			[Address(RVA = "0x578B4B0", Offset = "0x578A0B0", VA = "0x18578B4B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x00016938 File Offset: 0x00014B38
		[Token(Token = "0x170003AC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zyy
		{
			[Token(Token = "0x6000F11")]
			[Address(RVA = "0x578A8A0", Offset = "0x57894A0", VA = "0x18578A8A0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00016950 File Offset: 0x00014B50
		[Token(Token = "0x170003AD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zyz
		{
			[Token(Token = "0x6000F12")]
			[Address(RVA = "0x578A920", Offset = "0x5789520", VA = "0x18578A920")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x00016968 File Offset: 0x00014B68
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zyw
		{
			[Token(Token = "0x6000F13")]
			[Address(RVA = "0x5799AF0", Offset = "0x57986F0", VA = "0x185799AF0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F14")]
			[Address(RVA = "0x579ABC0", Offset = "0x57997C0", VA = "0x18579ABC0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00016980 File Offset: 0x00014B80
		[Token(Token = "0x170003AF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zzx
		{
			[Token(Token = "0x6000F15")]
			[Address(RVA = "0x578A9D0", Offset = "0x57895D0", VA = "0x18578A9D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00016998 File Offset: 0x00014B98
		[Token(Token = "0x170003B0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zzy
		{
			[Token(Token = "0x6000F16")]
			[Address(RVA = "0x578AA50", Offset = "0x5789650", VA = "0x18578AA50")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x000169B0 File Offset: 0x00014BB0
		[Token(Token = "0x170003B1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zzz
		{
			[Token(Token = "0x6000F17")]
			[Address(RVA = "0x578AAD0", Offset = "0x57896D0", VA = "0x18578AAD0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x000169C8 File Offset: 0x00014BC8
		[Token(Token = "0x170003B2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zzw
		{
			[Token(Token = "0x6000F18")]
			[Address(RVA = "0x5799C40", Offset = "0x5798840", VA = "0x185799C40")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x000169E0 File Offset: 0x00014BE0
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zwx
		{
			[Token(Token = "0x6000F19")]
			[Address(RVA = "0x5799730", Offset = "0x5798330", VA = "0x185799730")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F1A")]
			[Address(RVA = "0x579AAE0", Offset = "0x57996E0", VA = "0x18579AAE0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x000169F8 File Offset: 0x00014BF8
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zwy
		{
			[Token(Token = "0x6000F1B")]
			[Address(RVA = "0x5799800", Offset = "0x5798400", VA = "0x185799800")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F1C")]
			[Address(RVA = "0x579AB20", Offset = "0x5799720", VA = "0x18579AB20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x00016A10 File Offset: 0x00014C10
		[Token(Token = "0x170003B5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zwz
		{
			[Token(Token = "0x6000F1D")]
			[Address(RVA = "0x57998D0", Offset = "0x57984D0", VA = "0x1857998D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x00016A28 File Offset: 0x00014C28
		[Token(Token = "0x170003B6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zww
		{
			[Token(Token = "0x6000F1E")]
			[Address(RVA = "0x5799690", Offset = "0x5798290", VA = "0x185799690")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00016A40 File Offset: 0x00014C40
		[Token(Token = "0x170003B7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wxx
		{
			[Token(Token = "0x6000F1F")]
			[Address(RVA = "0x5798040", Offset = "0x5796C40", VA = "0x185798040")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00016A58 File Offset: 0x00014C58
		// (set) Token: 0x06000F21 RID: 3873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wxy
		{
			[Token(Token = "0x6000F20")]
			[Address(RVA = "0x57980E0", Offset = "0x5796CE0", VA = "0x1857980E0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F21")]
			[Address(RVA = "0x579A6B0", Offset = "0x57992B0", VA = "0x18579A6B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00016A70 File Offset: 0x00014C70
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wxz
		{
			[Token(Token = "0x6000F22")]
			[Address(RVA = "0x57981B0", Offset = "0x5796DB0", VA = "0x1857981B0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F23")]
			[Address(RVA = "0x579A6F0", Offset = "0x57992F0", VA = "0x18579A6F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00016A88 File Offset: 0x00014C88
		[Token(Token = "0x170003BA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wxw
		{
			[Token(Token = "0x6000F24")]
			[Address(RVA = "0x5797F80", Offset = "0x5796B80", VA = "0x185797F80")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00016AA0 File Offset: 0x00014CA0
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wyx
		{
			[Token(Token = "0x6000F25")]
			[Address(RVA = "0x5798370", Offset = "0x5796F70", VA = "0x185798370")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F26")]
			[Address(RVA = "0x579A740", Offset = "0x5799340", VA = "0x18579A740")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00016AB8 File Offset: 0x00014CB8
		[Token(Token = "0x170003BC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wyy
		{
			[Token(Token = "0x6000F27")]
			[Address(RVA = "0x5798440", Offset = "0x5797040", VA = "0x185798440")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00016AD0 File Offset: 0x00014CD0
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wyz
		{
			[Token(Token = "0x6000F28")]
			[Address(RVA = "0x57984E0", Offset = "0x57970E0", VA = "0x1857984E0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F29")]
			[Address(RVA = "0x579A780", Offset = "0x5799380", VA = "0x18579A780")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x00016AE8 File Offset: 0x00014CE8
		[Token(Token = "0x170003BE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wyw
		{
			[Token(Token = "0x6000F2A")]
			[Address(RVA = "0x57982A0", Offset = "0x5796EA0", VA = "0x1857982A0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x00016B00 File Offset: 0x00014D00
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wzx
		{
			[Token(Token = "0x6000F2B")]
			[Address(RVA = "0x57986A0", Offset = "0x57972A0", VA = "0x1857986A0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F2C")]
			[Address(RVA = "0x579A7D0", Offset = "0x57993D0", VA = "0x18579A7D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x00016B18 File Offset: 0x00014D18
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wzy
		{
			[Token(Token = "0x6000F2D")]
			[Address(RVA = "0x5798770", Offset = "0x5797370", VA = "0x185798770")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000F2E")]
			[Address(RVA = "0x579A810", Offset = "0x5799410", VA = "0x18579A810")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x00016B30 File Offset: 0x00014D30
		[Token(Token = "0x170003C1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wzz
		{
			[Token(Token = "0x6000F2F")]
			[Address(RVA = "0x5798840", Offset = "0x5797440", VA = "0x185798840")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00016B48 File Offset: 0x00014D48
		[Token(Token = "0x170003C2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wzw
		{
			[Token(Token = "0x6000F30")]
			[Address(RVA = "0x57985D0", Offset = "0x57971D0", VA = "0x1857985D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00016B60 File Offset: 0x00014D60
		[Token(Token = "0x170003C3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wwx
		{
			[Token(Token = "0x6000F31")]
			[Address(RVA = "0x5797D80", Offset = "0x5796980", VA = "0x185797D80")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00016B78 File Offset: 0x00014D78
		[Token(Token = "0x170003C4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wwy
		{
			[Token(Token = "0x6000F32")]
			[Address(RVA = "0x5797E20", Offset = "0x5796A20", VA = "0x185797E20")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00016B90 File Offset: 0x00014D90
		[Token(Token = "0x170003C5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 wwz
		{
			[Token(Token = "0x6000F33")]
			[Address(RVA = "0x5797EC0", Offset = "0x5796AC0", VA = "0x185797EC0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00016BA8 File Offset: 0x00014DA8
		[Token(Token = "0x170003C6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 www
		{
			[Token(Token = "0x6000F34")]
			[Address(RVA = "0x5797CE0", Offset = "0x57968E0", VA = "0x185797CE0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00016BC0 File Offset: 0x00014DC0
		[Token(Token = "0x170003C7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 xx
		{
			[Token(Token = "0x6000F35")]
			[Address(RVA = "0x5783720", Offset = "0x5782320", VA = "0x185783720")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x00016BD8 File Offset: 0x00014DD8
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 xy
		{
			[Token(Token = "0x6000F36")]
			[Address(RVA = "0x5510D10", Offset = "0x550F910", VA = "0x185510D10")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F37")]
			[Address(RVA = "0x57835D0", Offset = "0x57821D0", VA = "0x1857835D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x00016BF0 File Offset: 0x00014DF0
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 xz
		{
			[Token(Token = "0x6000F38")]
			[Address(RVA = "0x578A0B0", Offset = "0x5788CB0", VA = "0x18578A0B0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F39")]
			[Address(RVA = "0x578B3F0", Offset = "0x5789FF0", VA = "0x18578B3F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x00016C08 File Offset: 0x00014E08
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 xw
		{
			[Token(Token = "0x6000F3A")]
			[Address(RVA = "0x57988E0", Offset = "0x57974E0", VA = "0x1857988E0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F3B")]
			[Address(RVA = "0x579A850", Offset = "0x5799450", VA = "0x18579A850")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00016C20 File Offset: 0x00014E20
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 yx
		{
			[Token(Token = "0x6000F3C")]
			[Address(RVA = "0x57838B0", Offset = "0x57824B0", VA = "0x1857838B0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F3D")]
			[Address(RVA = "0x57840F0", Offset = "0x5782CF0", VA = "0x1857840F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x00016C38 File Offset: 0x00014E38
		[Token(Token = "0x170003CC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 yy
		{
			[Token(Token = "0x6000F3E")]
			[Address(RVA = "0x5783990", Offset = "0x5782590", VA = "0x185783990")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00016C50 File Offset: 0x00014E50
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 yz
		{
			[Token(Token = "0x6000F3F")]
			[Address(RVA = "0x578A430", Offset = "0x5789030", VA = "0x18578A430")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F40")]
			[Address(RVA = "0x578B440", Offset = "0x578A040", VA = "0x18578B440")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00016C68 File Offset: 0x00014E68
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 yw
		{
			[Token(Token = "0x6000F41")]
			[Address(RVA = "0x5798FA0", Offset = "0x5797BA0", VA = "0x185798FA0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F42")]
			[Address(RVA = "0x579A980", Offset = "0x5799580", VA = "0x18579A980")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00016C80 File Offset: 0x00014E80
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 zx
		{
			[Token(Token = "0x6000F43")]
			[Address(RVA = "0x578A610", Offset = "0x5789210", VA = "0x18578A610")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F44")]
			[Address(RVA = "0x578B470", Offset = "0x578A070", VA = "0x18578B470")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00016C98 File Offset: 0x00014E98
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 zy
		{
			[Token(Token = "0x6000F45")]
			[Address(RVA = "0x578A7E0", Offset = "0x57893E0", VA = "0x18578A7E0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F46")]
			[Address(RVA = "0x578B4A0", Offset = "0x578A0A0", VA = "0x18578B4A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00016CB0 File Offset: 0x00014EB0
		[Token(Token = "0x170003D1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 zz
		{
			[Token(Token = "0x6000F47")]
			[Address(RVA = "0x578A9C0", Offset = "0x57895C0", VA = "0x18578A9C0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00016CC8 File Offset: 0x00014EC8
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 zw
		{
			[Token(Token = "0x6000F48")]
			[Address(RVA = "0x5799670", Offset = "0x5798270", VA = "0x185799670")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F49")]
			[Address(RVA = "0x579AAD0", Offset = "0x57996D0", VA = "0x18579AAD0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00016CE0 File Offset: 0x00014EE0
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 wx
		{
			[Token(Token = "0x6000F4A")]
			[Address(RVA = "0x5797F60", Offset = "0x5796B60", VA = "0x185797F60")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F4B")]
			[Address(RVA = "0x579A6A0", Offset = "0x57992A0", VA = "0x18579A6A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00016CF8 File Offset: 0x00014EF8
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 wy
		{
			[Token(Token = "0x6000F4C")]
			[Address(RVA = "0x5798280", Offset = "0x5796E80", VA = "0x185798280")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F4D")]
			[Address(RVA = "0x579A730", Offset = "0x5799330", VA = "0x18579A730")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00016D10 File Offset: 0x00014F10
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 wz
		{
			[Token(Token = "0x6000F4E")]
			[Address(RVA = "0x57985B0", Offset = "0x57971B0", VA = "0x1857985B0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000F4F")]
			[Address(RVA = "0x579A7C0", Offset = "0x57993C0", VA = "0x18579A7C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00016D28 File Offset: 0x00014F28
		[Token(Token = "0x170003D6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 ww
		{
			[Token(Token = "0x6000F50")]
			[Address(RVA = "0x5797CD0", Offset = "0x57968D0", VA = "0x185797CD0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
		}

		// Token: 0x170003D7 RID: 983
		[Token(Token = "0x170003D7")]
		public double this[int index]
		{
			[Token(Token = "0x6000F51")]
			[Address(RVA = "0x5783710", Offset = "0x5782310", VA = "0x185783710")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000F52")]
			[Address(RVA = "0x57840E0", Offset = "0x5782CE0", VA = "0x1857840E0")]
			set
			{
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00016D58 File Offset: 0x00014F58
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x5797540", Offset = "0x5796140", VA = "0x185797540", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(double4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00016D70 File Offset: 0x00014F70
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x5797470", Offset = "0x5796070", VA = "0x185797470", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00016D88 File Offset: 0x00014F88
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x5797590", Offset = "0x5796190", VA = "0x185797590", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x57975C0", Offset = "0x57961C0", VA = "0x1857975C0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x57977D0", Offset = "0x57963D0", VA = "0x1857977D0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x0")]
		public double x;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x8")]
		public double y;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x10")]
		public double z;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x18")]
		public double w;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x0")]
		public static readonly double4 zero;

		// Token: 0x02000022 RID: 34
		[Token(Token = "0x2000022")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x06000F58 RID: 3928 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F58")]
			[Address(RVA = "0x57937C0", Offset = "0x57923C0", VA = "0x1857937C0")]
			public DebuggerProxy(double4 v)
			{
			}

			// Token: 0x04000084 RID: 132
			[Token(Token = "0x4000084")]
			[FieldOffset(Offset = "0x10")]
			public double x;

			// Token: 0x04000085 RID: 133
			[Token(Token = "0x4000085")]
			[FieldOffset(Offset = "0x18")]
			public double y;

			// Token: 0x04000086 RID: 134
			[Token(Token = "0x4000086")]
			[FieldOffset(Offset = "0x20")]
			public double z;

			// Token: 0x04000087 RID: 135
			[Token(Token = "0x4000087")]
			[FieldOffset(Offset = "0x28")]
			public double w;
		}
	}
}
