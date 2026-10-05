using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct float4x3 : IEquatable<float4x3>, IFormattable
	{
		// Token: 0x060014F8 RID: 5368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x5771920", Offset = "0x5770520", VA = "0x185771920")]
		[MethodImpl(256)]
		public float4x3(float4 c0, float4 c1, float4 c2)
		{
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x57C5CA0", Offset = "0x57C48A0", VA = "0x1857C5CA0")]
		[MethodImpl(256)]
		public float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32)
		{
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x57C5BC0", Offset = "0x57C47C0", VA = "0x1857C5BC0")]
		[MethodImpl(256)]
		public float4x3(float v)
		{
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x57C5BF0", Offset = "0x57C47F0", VA = "0x1857C5BF0")]
		[MethodImpl(256)]
		public float4x3(bool v)
		{
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x56FE410", Offset = "0x56FD010", VA = "0x1856FE410")]
		[MethodImpl(256)]
		public float4x3(bool4x3 v)
		{
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x57C5C30", Offset = "0x57C4830", VA = "0x1857C5C30")]
		[MethodImpl(256)]
		public float4x3(int v)
		{
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x56FE550", Offset = "0x56FD150", VA = "0x1856FE550")]
		[MethodImpl(256)]
		public float4x3(int4x3 v)
		{
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x57C5C60", Offset = "0x57C4860", VA = "0x1857C5C60")]
		[MethodImpl(256)]
		public float4x3(uint v)
		{
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x56FE680", Offset = "0x56FD280", VA = "0x1856FE680")]
		[MethodImpl(256)]
		public float4x3(uint4x3 v)
		{
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x57C5B60", Offset = "0x57C4760", VA = "0x1857C5B60")]
		[MethodImpl(256)]
		public float4x3(double v)
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x56FE800", Offset = "0x56FD400", VA = "0x1856FE800")]
		[MethodImpl(256)]
		public float4x3(double4x3 v)
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0001DA78 File Offset: 0x0001BC78
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x5719600", Offset = "0x5718200", VA = "0x185719600")]
		[MethodImpl(256)]
		public static implicit operator float4x3(float v)
		{
			return default(float4x3);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0001DA90 File Offset: 0x0001BC90
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x5719630", Offset = "0x5718230", VA = "0x185719630")]
		[MethodImpl(256)]
		public static explicit operator float4x3(bool v)
		{
			return default(float4x3);
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x0001DAA8 File Offset: 0x0001BCA8
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x57C6BC0", Offset = "0x57C57C0", VA = "0x1857C6BC0")]
		[MethodImpl(256)]
		public static explicit operator float4x3(bool4x3 v)
		{
			return default(float4x3);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x0001DAC0 File Offset: 0x0001BCC0
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x5719670", Offset = "0x5718270", VA = "0x185719670")]
		[MethodImpl(256)]
		public static implicit operator float4x3(int v)
		{
			return default(float4x3);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x57C7100", Offset = "0x57C5D00", VA = "0x1857C7100")]
		[MethodImpl(256)]
		public static implicit operator float4x3(int4x3 v)
		{
			return default(float4x3);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
		[Token(Token = "0x6001508")]
		[Address(RVA = "0x5719240", Offset = "0x5717E40", VA = "0x185719240")]
		[MethodImpl(256)]
		public static implicit operator float4x3(uint v)
		{
			return default(float4x3);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0001DB08 File Offset: 0x0001BD08
		[Token(Token = "0x6001509")]
		[Address(RVA = "0x57C7150", Offset = "0x57C5D50", VA = "0x1857C7150")]
		[MethodImpl(256)]
		public static implicit operator float4x3(uint4x3 v)
		{
			return default(float4x3);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0001DB20 File Offset: 0x0001BD20
		[Token(Token = "0x600150A")]
		[Address(RVA = "0x57191E0", Offset = "0x5717DE0", VA = "0x1857191E0")]
		[MethodImpl(256)]
		public static explicit operator float4x3(double v)
		{
			return default(float4x3);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0001DB38 File Offset: 0x0001BD38
		[Token(Token = "0x600150B")]
		[Address(RVA = "0x57190E0", Offset = "0x5717CE0", VA = "0x1857190E0")]
		[MethodImpl(256)]
		public static explicit operator float4x3(double4x3 v)
		{
			return default(float4x3);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0001DB50 File Offset: 0x0001BD50
		[Token(Token = "0x600150C")]
		[Address(RVA = "0x57C8370", Offset = "0x57C6F70", VA = "0x1857C8370")]
		[MethodImpl(256)]
		public static float4x3 operator *(float4x3 lhs, float4x3 rhs)
		{
			return default(float4x3);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0001DB68 File Offset: 0x0001BD68
		[Token(Token = "0x600150D")]
		[Address(RVA = "0x57C8520", Offset = "0x57C7120", VA = "0x1857C8520")]
		[MethodImpl(256)]
		public static float4x3 operator *(float4x3 lhs, float rhs)
		{
			return default(float4x3);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0001DB80 File Offset: 0x0001BD80
		[Token(Token = "0x600150E")]
		[Address(RVA = "0x57C8200", Offset = "0x57C6E00", VA = "0x1857C8200")]
		[MethodImpl(256)]
		public static float4x3 operator *(float lhs, float4x3 rhs)
		{
			return default(float4x3);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0001DB98 File Offset: 0x0001BD98
		[Token(Token = "0x600150F")]
		[Address(RVA = "0x57C5ED0", Offset = "0x57C4AD0", VA = "0x1857C5ED0")]
		[MethodImpl(256)]
		public static float4x3 operator +(float4x3 lhs, float4x3 rhs)
		{
			return default(float4x3);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0001DBB0 File Offset: 0x0001BDB0
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x57C6080", Offset = "0x57C4C80", VA = "0x1857C6080")]
		[MethodImpl(256)]
		public static float4x3 operator +(float4x3 lhs, float rhs)
		{
			return default(float4x3);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0001DBC8 File Offset: 0x0001BDC8
		[Token(Token = "0x6001511")]
		[Address(RVA = "0x57C5D60", Offset = "0x57C4960", VA = "0x1857C5D60")]
		[MethodImpl(256)]
		public static float4x3 operator +(float lhs, float4x3 rhs)
		{
			return default(float4x3);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0001DBE0 File Offset: 0x0001BDE0
		[Token(Token = "0x6001512")]
		[Address(RVA = "0x57C8690", Offset = "0x57C7290", VA = "0x1857C8690")]
		[MethodImpl(256)]
		public static float4x3 operator -(float4x3 lhs, float4x3 rhs)
		{
			return default(float4x3);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0001DBF8 File Offset: 0x0001BDF8
		[Token(Token = "0x6001513")]
		[Address(RVA = "0x57C8840", Offset = "0x57C7440", VA = "0x1857C8840")]
		[MethodImpl(256)]
		public static float4x3 operator -(float4x3 lhs, float rhs)
		{
			return default(float4x3);
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0001DC10 File Offset: 0x0001BE10
		[Token(Token = "0x6001514")]
		[Address(RVA = "0x57C89B0", Offset = "0x57C75B0", VA = "0x1857C89B0")]
		[MethodImpl(256)]
		public static float4x3 operator -(float lhs, float4x3 rhs)
		{
			return default(float4x3);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0001DC28 File Offset: 0x0001BE28
		[Token(Token = "0x6001515")]
		[Address(RVA = "0x57C62F0", Offset = "0x57C4EF0", VA = "0x1857C62F0")]
		[MethodImpl(256)]
		public static float4x3 operator /(float4x3 lhs, float4x3 rhs)
		{
			return default(float4x3);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0001DC40 File Offset: 0x0001BE40
		[Token(Token = "0x6001516")]
		[Address(RVA = "0x57C64A0", Offset = "0x57C50A0", VA = "0x1857C64A0")]
		[MethodImpl(256)]
		public static float4x3 operator /(float4x3 lhs, float rhs)
		{
			return default(float4x3);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0001DC58 File Offset: 0x0001BE58
		[Token(Token = "0x6001517")]
		[Address(RVA = "0x57C6610", Offset = "0x57C5210", VA = "0x1857C6610")]
		[MethodImpl(256)]
		public static float4x3 operator /(float lhs, float4x3 rhs)
		{
			return default(float4x3);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0001DC70 File Offset: 0x0001BE70
		[Token(Token = "0x6001518")]
		[Address(RVA = "0x57C7FC0", Offset = "0x57C6BC0", VA = "0x1857C7FC0")]
		[MethodImpl(256)]
		public static float4x3 operator %(float4x3 lhs, float4x3 rhs)
		{
			return default(float4x3);
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0001DC88 File Offset: 0x0001BE88
		[Token(Token = "0x6001519")]
		[Address(RVA = "0x57C7DC0", Offset = "0x57C69C0", VA = "0x1857C7DC0")]
		[MethodImpl(256)]
		public static float4x3 operator %(float4x3 lhs, float rhs)
		{
			return default(float4x3);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
		[Token(Token = "0x600151A")]
		[Address(RVA = "0x57C7BC0", Offset = "0x57C67C0", VA = "0x1857C7BC0")]
		[MethodImpl(256)]
		public static float4x3 operator %(float lhs, float4x3 rhs)
		{
			return default(float4x3);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0001DCB8 File Offset: 0x0001BEB8
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x57C71A0", Offset = "0x57C5DA0", VA = "0x1857C71A0")]
		[MethodImpl(256)]
		public static float4x3 operator ++(float4x3 val)
		{
			return default(float4x3);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x57C61F0", Offset = "0x57C4DF0", VA = "0x1857C61F0")]
		[MethodImpl(256)]
		public static float4x3 operator --(float4x3 val)
		{
			return default(float4x3);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x57C7940", Offset = "0x57C6540", VA = "0x1857C7940")]
		[MethodImpl(256)]
		public static bool4x3 operator <(float4x3 lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0001DD00 File Offset: 0x0001BF00
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x57C7B00", Offset = "0x57C6700", VA = "0x1857C7B00")]
		[MethodImpl(256)]
		public static bool4x3 operator <(float4x3 lhs, float rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0001DD18 File Offset: 0x0001BF18
		[Token(Token = "0x600151F")]
		[Address(RVA = "0x57C7A40", Offset = "0x57C6640", VA = "0x1857C7A40")]
		[MethodImpl(256)]
		public static bool4x3 operator <(float lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0001DD30 File Offset: 0x0001BF30
		[Token(Token = "0x6001520")]
		[Address(RVA = "0x57C76C0", Offset = "0x57C62C0", VA = "0x1857C76C0")]
		[MethodImpl(256)]
		public static bool4x3 operator <=(float4x3 lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0001DD48 File Offset: 0x0001BF48
		[Token(Token = "0x6001521")]
		[Address(RVA = "0x57C77C0", Offset = "0x57C63C0", VA = "0x1857C77C0")]
		[MethodImpl(256)]
		public static bool4x3 operator <=(float4x3 lhs, float rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0001DD60 File Offset: 0x0001BF60
		[Token(Token = "0x6001522")]
		[Address(RVA = "0x57C7880", Offset = "0x57C6480", VA = "0x1857C7880")]
		[MethodImpl(256)]
		public static bool4x3 operator <=(float lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0001DD78 File Offset: 0x0001BF78
		[Token(Token = "0x6001523")]
		[Address(RVA = "0x57C6F40", Offset = "0x57C5B40", VA = "0x1857C6F40")]
		[MethodImpl(256)]
		public static bool4x3 operator >(float4x3 lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0001DD90 File Offset: 0x0001BF90
		[Token(Token = "0x6001524")]
		[Address(RVA = "0x57C6E80", Offset = "0x57C5A80", VA = "0x1857C6E80")]
		[MethodImpl(256)]
		public static bool4x3 operator >(float4x3 lhs, float rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0001DDA8 File Offset: 0x0001BFA8
		[Token(Token = "0x6001525")]
		[Address(RVA = "0x57C7040", Offset = "0x57C5C40", VA = "0x1857C7040")]
		[MethodImpl(256)]
		public static bool4x3 operator >(float lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0001DDC0 File Offset: 0x0001BFC0
		[Token(Token = "0x6001526")]
		[Address(RVA = "0x57C6C00", Offset = "0x57C5800", VA = "0x1857C6C00")]
		[MethodImpl(256)]
		public static bool4x3 operator >=(float4x3 lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		[Token(Token = "0x6001527")]
		[Address(RVA = "0x57C6DC0", Offset = "0x57C59C0", VA = "0x1857C6DC0")]
		[MethodImpl(256)]
		public static bool4x3 operator >=(float4x3 lhs, float rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0001DDF0 File Offset: 0x0001BFF0
		[Token(Token = "0x6001528")]
		[Address(RVA = "0x57C6D00", Offset = "0x57C5900", VA = "0x1857C6D00")]
		[MethodImpl(256)]
		public static bool4x3 operator >=(float lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0001DE08 File Offset: 0x0001C008
		[Token(Token = "0x6001529")]
		[Address(RVA = "0x57C8B40", Offset = "0x57C7740", VA = "0x1857C8B40")]
		[MethodImpl(256)]
		public static float4x3 operator -(float4x3 val)
		{
			return default(float4x3);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0001DE20 File Offset: 0x0001C020
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x57C8CA0", Offset = "0x57C78A0", VA = "0x1857C8CA0")]
		[MethodImpl(256)]
		public static float4x3 operator +(float4x3 val)
		{
			return default(float4x3);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0001DE38 File Offset: 0x0001C038
		[Token(Token = "0x600152B")]
		[Address(RVA = "0x57C68E0", Offset = "0x57C54E0", VA = "0x1857C68E0")]
		[MethodImpl(256)]
		public static bool4x3 operator ==(float4x3 lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0001DE50 File Offset: 0x0001C050
		[Token(Token = "0x600152C")]
		[Address(RVA = "0x57C6A60", Offset = "0x57C5660", VA = "0x1857C6A60")]
		[MethodImpl(256)]
		public static bool4x3 operator ==(float4x3 lhs, float rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0001DE68 File Offset: 0x0001C068
		[Token(Token = "0x600152D")]
		[Address(RVA = "0x57C67A0", Offset = "0x57C53A0", VA = "0x1857C67A0")]
		[MethodImpl(256)]
		public static bool4x3 operator ==(float lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0001DE80 File Offset: 0x0001C080
		[Token(Token = "0x600152E")]
		[Address(RVA = "0x57C7400", Offset = "0x57C6000", VA = "0x1857C7400")]
		[MethodImpl(256)]
		public static bool4x3 operator !=(float4x3 lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0001DE98 File Offset: 0x0001C098
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x57C72A0", Offset = "0x57C5EA0", VA = "0x1857C72A0")]
		[MethodImpl(256)]
		public static bool4x3 operator !=(float4x3 lhs, float rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0001DEB0 File Offset: 0x0001C0B0
		[Token(Token = "0x6001530")]
		[Address(RVA = "0x57C7580", Offset = "0x57C6180", VA = "0x1857C7580")]
		[MethodImpl(256)]
		public static bool4x3 operator !=(float lhs, float4x3 rhs)
		{
			return default(bool4x3);
		}

		// Token: 0x170005C6 RID: 1478
		[Token(Token = "0x170005C6")]
		public float4 this[int index]
		{
			[Token(Token = "0x6001531")]
			[Address(RVA = "0x3D28160", Offset = "0x3D26D60", VA = "0x183D28160")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0001DEC8 File Offset: 0x0001C0C8
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x57BD680", Offset = "0x57BC280", VA = "0x1857BD680", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(float4x3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x57C5050", Offset = "0x57C3C50", VA = "0x1857C5050", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0001DEF8 File Offset: 0x0001C0F8
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x57C5100", Offset = "0x57C3D00", VA = "0x1857C5100", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x57C5620", Offset = "0x57C4220", VA = "0x1857C5620", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001536")]
		[Address(RVA = "0x57C5130", Offset = "0x57C3D30", VA = "0x1857C5130", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x0")]
		public float4 c0;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x10")]
		public float4 c1;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x20")]
		public float4 c2;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float4x3 zero;
	}
}
