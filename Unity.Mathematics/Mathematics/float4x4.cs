using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct float4x4 : IEquatable<float4x4>, IFormattable
	{
		// Token: 0x06001537 RID: 5431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001537")]
		[Address(RVA = "0x5776110", Offset = "0x5774D10", VA = "0x185776110")]
		[MethodImpl(256)]
		public float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x57CBC60", Offset = "0x57CA860", VA = "0x1857CBC60")]
		[MethodImpl(256)]
		public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
		{
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x57CBE30", Offset = "0x57CAA30", VA = "0x1857CBE30")]
		[MethodImpl(256)]
		public float4x4(float v)
		{
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x57CBDA0", Offset = "0x57CA9A0", VA = "0x1857CBDA0")]
		[MethodImpl(256)]
		public float4x4(bool v)
		{
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x56FE8F0", Offset = "0x56FD4F0", VA = "0x1856FE8F0")]
		[MethodImpl(256)]
		public float4x4(bool4x4 v)
		{
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x57CBD60", Offset = "0x57CA960", VA = "0x1857CBD60")]
		[MethodImpl(256)]
		public float4x4(int v)
		{
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x56FEE50", Offset = "0x56FDA50", VA = "0x1856FEE50")]
		[MethodImpl(256)]
		public float4x4(int4x4 v)
		{
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153E")]
		[Address(RVA = "0x57CBDF0", Offset = "0x57CA9F0", VA = "0x1857CBDF0")]
		[MethodImpl(256)]
		public float4x4(uint v)
		{
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153F")]
		[Address(RVA = "0x56FEC50", Offset = "0x56FD850", VA = "0x1856FEC50")]
		[MethodImpl(256)]
		public float4x4(uint4x4 v)
		{
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001540")]
		[Address(RVA = "0x56FEA90", Offset = "0x56FD690", VA = "0x1856FEA90")]
		[MethodImpl(256)]
		public float4x4(double v)
		{
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001541")]
		[Address(RVA = "0x56FEB10", Offset = "0x56FD710", VA = "0x1856FEB10")]
		[MethodImpl(256)]
		public float4x4(double4x4 v)
		{
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0001DF10 File Offset: 0x0001C110
		[Token(Token = "0x6001542")]
		[Address(RVA = "0x5719B10", Offset = "0x5718710", VA = "0x185719B10")]
		[MethodImpl(256)]
		public static implicit operator float4x4(float v)
		{
			return default(float4x4);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0001DF28 File Offset: 0x0001C128
		[Token(Token = "0x6001543")]
		[Address(RVA = "0x5719DF0", Offset = "0x57189F0", VA = "0x185719DF0")]
		[MethodImpl(256)]
		public static explicit operator float4x4(bool v)
		{
			return default(float4x4);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0001DF40 File Offset: 0x0001C140
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x5719EE0", Offset = "0x5718AE0", VA = "0x185719EE0")]
		[MethodImpl(256)]
		public static explicit operator float4x4(bool4x4 v)
		{
			return default(float4x4);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0001DF58 File Offset: 0x0001C158
		[Token(Token = "0x6001545")]
		[Address(RVA = "0x5719E40", Offset = "0x5718A40", VA = "0x185719E40")]
		[MethodImpl(256)]
		public static implicit operator float4x4(int v)
		{
			return default(float4x4);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0001DF70 File Offset: 0x0001C170
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x57CD950", Offset = "0x57CC550", VA = "0x1857CD950")]
		[MethodImpl(256)]
		public static implicit operator float4x4(int4x4 v)
		{
			return default(float4x4);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0001DF88 File Offset: 0x0001C188
		[Token(Token = "0x6001547")]
		[Address(RVA = "0x57198E0", Offset = "0x57184E0", VA = "0x1857198E0")]
		[MethodImpl(256)]
		public static implicit operator float4x4(uint v)
		{
			return default(float4x4);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		[Token(Token = "0x6001548")]
		[Address(RVA = "0x5719D20", Offset = "0x5718920", VA = "0x185719D20")]
		[MethodImpl(256)]
		public static implicit operator float4x4(uint4x4 v)
		{
			return default(float4x4);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0001DFB8 File Offset: 0x0001C1B8
		[Token(Token = "0x6001549")]
		[Address(RVA = "0x57CD240", Offset = "0x57CBE40", VA = "0x1857CD240")]
		[MethodImpl(256)]
		public static explicit operator float4x4(double v)
		{
			return default(float4x4);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0001DFD0 File Offset: 0x0001C1D0
		[Token(Token = "0x600154A")]
		[Address(RVA = "0x57CD1C0", Offset = "0x57CBDC0", VA = "0x1857CD1C0")]
		[MethodImpl(256)]
		public static explicit operator float4x4(double4x4 v)
		{
			return default(float4x4);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0001DFE8 File Offset: 0x0001C1E8
		[Token(Token = "0x600154B")]
		[Address(RVA = "0x57CF740", Offset = "0x57CE340", VA = "0x1857CF740")]
		[MethodImpl(256)]
		public static float4x4 operator *(float4x4 lhs, float4x4 rhs)
		{
			return default(float4x4);
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0001E000 File Offset: 0x0001C200
		[Token(Token = "0x600154C")]
		[Address(RVA = "0x57CF540", Offset = "0x57CE140", VA = "0x1857CF540")]
		[MethodImpl(256)]
		public static float4x4 operator *(float4x4 lhs, float rhs)
		{
			return default(float4x4);
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x0001E018 File Offset: 0x0001C218
		[Token(Token = "0x600154D")]
		[Address(RVA = "0x57CF340", Offset = "0x57CDF40", VA = "0x1857CF340")]
		[MethodImpl(256)]
		public static float4x4 operator *(float lhs, float4x4 rhs)
		{
			return default(float4x4);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0001E030 File Offset: 0x0001C230
		[Token(Token = "0x600154E")]
		[Address(RVA = "0x57CC260", Offset = "0x57CAE60", VA = "0x1857CC260")]
		[MethodImpl(256)]
		public static float4x4 operator +(float4x4 lhs, float4x4 rhs)
		{
			return default(float4x4);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0001E048 File Offset: 0x0001C248
		[Token(Token = "0x600154F")]
		[Address(RVA = "0x57CC060", Offset = "0x57CAC60", VA = "0x1857CC060")]
		[MethodImpl(256)]
		public static float4x4 operator +(float4x4 lhs, float rhs)
		{
			return default(float4x4);
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0001E060 File Offset: 0x0001C260
		[Token(Token = "0x6001550")]
		[Address(RVA = "0x57CBE60", Offset = "0x57CAA60", VA = "0x1857CBE60")]
		[MethodImpl(256)]
		public static float4x4 operator +(float lhs, float4x4 rhs)
		{
			return default(float4x4);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0001E078 File Offset: 0x0001C278
		[Token(Token = "0x6001551")]
		[Address(RVA = "0x57CFDA0", Offset = "0x57CE9A0", VA = "0x1857CFDA0")]
		[MethodImpl(256)]
		public static float4x4 operator -(float4x4 lhs, float4x4 rhs)
		{
			return default(float4x4);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0001E090 File Offset: 0x0001C290
		[Token(Token = "0x6001552")]
		[Address(RVA = "0x57CFBA0", Offset = "0x57CE7A0", VA = "0x1857CFBA0")]
		[MethodImpl(256)]
		public static float4x4 operator -(float4x4 lhs, float rhs)
		{
			return default(float4x4);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0001E0A8 File Offset: 0x0001C2A8
		[Token(Token = "0x6001553")]
		[Address(RVA = "0x57CF980", Offset = "0x57CE580", VA = "0x1857CF980")]
		[MethodImpl(256)]
		public static float4x4 operator -(float lhs, float4x4 rhs)
		{
			return default(float4x4);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0001E0C0 File Offset: 0x0001C2C0
		[Token(Token = "0x6001554")]
		[Address(RVA = "0x57CCA20", Offset = "0x57CB620", VA = "0x1857CCA20")]
		[MethodImpl(256)]
		public static float4x4 operator /(float4x4 lhs, float4x4 rhs)
		{
			return default(float4x4);
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0001E0D8 File Offset: 0x0001C2D8
		[Token(Token = "0x6001555")]
		[Address(RVA = "0x57CC820", Offset = "0x57CB420", VA = "0x1857CC820")]
		[MethodImpl(256)]
		public static float4x4 operator /(float4x4 lhs, float rhs)
		{
			return default(float4x4);
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0001E0F0 File Offset: 0x0001C2F0
		[Token(Token = "0x6001556")]
		[Address(RVA = "0x57CC600", Offset = "0x57CB200", VA = "0x1857CC600")]
		[MethodImpl(256)]
		public static float4x4 operator /(float lhs, float4x4 rhs)
		{
			return default(float4x4);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0001E108 File Offset: 0x0001C308
		[Token(Token = "0x6001557")]
		[Address(RVA = "0x57CEDD0", Offset = "0x57CD9D0", VA = "0x1857CEDD0")]
		[MethodImpl(256)]
		public static float4x4 operator %(float4x4 lhs, float4x4 rhs)
		{
			return default(float4x4);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0001E120 File Offset: 0x0001C320
		[Token(Token = "0x6001558")]
		[Address(RVA = "0x57CF0B0", Offset = "0x57CDCB0", VA = "0x1857CF0B0")]
		[MethodImpl(256)]
		public static float4x4 operator %(float4x4 lhs, float rhs)
		{
			return default(float4x4);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0001E138 File Offset: 0x0001C338
		[Token(Token = "0x6001559")]
		[Address(RVA = "0x57CEB30", Offset = "0x57CD730", VA = "0x1857CEB30")]
		[MethodImpl(256)]
		public static float4x4 operator %(float lhs, float4x4 rhs)
		{
			return default(float4x4);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0001E150 File Offset: 0x0001C350
		[Token(Token = "0x600155A")]
		[Address(RVA = "0x57CDD90", Offset = "0x57CC990", VA = "0x1857CDD90")]
		[MethodImpl(256)]
		public static float4x4 operator ++(float4x4 val)
		{
			return default(float4x4);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0001E168 File Offset: 0x0001C368
		[Token(Token = "0x600155B")]
		[Address(RVA = "0x57CC4A0", Offset = "0x57CB0A0", VA = "0x1857CC4A0")]
		[MethodImpl(256)]
		public static float4x4 operator --(float4x4 val)
		{
			return default(float4x4);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0001E180 File Offset: 0x0001C380
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x57CE9D0", Offset = "0x57CD5D0", VA = "0x1857CE9D0")]
		[MethodImpl(256)]
		public static bool4x4 operator <(float4x4 lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0001E198 File Offset: 0x0001C398
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x57CE8D0", Offset = "0x57CD4D0", VA = "0x1857CE8D0")]
		[MethodImpl(256)]
		public static bool4x4 operator <(float4x4 lhs, float rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0001E1B0 File Offset: 0x0001C3B0
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x57CE7C0", Offset = "0x57CD3C0", VA = "0x1857CE7C0")]
		[MethodImpl(256)]
		public static bool4x4 operator <(float lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x57CE660", Offset = "0x57CD260", VA = "0x1857CE660")]
		[MethodImpl(256)]
		public static bool4x4 operator <=(float4x4 lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0001E1E0 File Offset: 0x0001C3E0
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x57CE560", Offset = "0x57CD160", VA = "0x1857CE560")]
		[MethodImpl(256)]
		public static bool4x4 operator <=(float4x4 lhs, float rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
		[Token(Token = "0x6001561")]
		[Address(RVA = "0x57CE450", Offset = "0x57CD050", VA = "0x1857CE450")]
		[MethodImpl(256)]
		public static bool4x4 operator <=(float lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x0001E210 File Offset: 0x0001C410
		[Token(Token = "0x6001562")]
		[Address(RVA = "0x57CD5E0", Offset = "0x57CC1E0", VA = "0x1857CD5E0")]
		[MethodImpl(256)]
		public static bool4x4 operator >(float4x4 lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0001E228 File Offset: 0x0001C428
		[Token(Token = "0x6001563")]
		[Address(RVA = "0x57CD850", Offset = "0x57CC450", VA = "0x1857CD850")]
		[MethodImpl(256)]
		public static bool4x4 operator >(float4x4 lhs, float rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0001E240 File Offset: 0x0001C440
		[Token(Token = "0x6001564")]
		[Address(RVA = "0x57CD740", Offset = "0x57CC340", VA = "0x1857CD740")]
		[MethodImpl(256)]
		public static bool4x4 operator >(float lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x0001E258 File Offset: 0x0001C458
		[Token(Token = "0x6001565")]
		[Address(RVA = "0x57CD370", Offset = "0x57CBF70", VA = "0x1857CD370")]
		[MethodImpl(256)]
		public static bool4x4 operator >=(float4x4 lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0001E270 File Offset: 0x0001C470
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x57CD270", Offset = "0x57CBE70", VA = "0x1857CD270")]
		[MethodImpl(256)]
		public static bool4x4 operator >=(float4x4 lhs, float rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0001E288 File Offset: 0x0001C488
		[Token(Token = "0x6001567")]
		[Address(RVA = "0x57CD4D0", Offset = "0x57CC0D0", VA = "0x1857CD4D0")]
		[MethodImpl(256)]
		public static bool4x4 operator >=(float lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0001E2A0 File Offset: 0x0001C4A0
		[Token(Token = "0x6001568")]
		[Address(RVA = "0x57CFFE0", Offset = "0x57CEBE0", VA = "0x1857CFFE0")]
		[MethodImpl(256)]
		public static float4x4 operator -(float4x4 val)
		{
			return default(float4x4);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
		[Token(Token = "0x6001569")]
		[Address(RVA = "0x57D01C0", Offset = "0x57CEDC0", VA = "0x1857D01C0")]
		[MethodImpl(256)]
		public static float4x4 operator +(float4x4 val)
		{
			return default(float4x4);
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x57CCE30", Offset = "0x57CBA30", VA = "0x1857CCE30")]
		[MethodImpl(256)]
		public static bool4x4 operator ==(float4x4 lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0001E2E8 File Offset: 0x0001C4E8
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x57CCC60", Offset = "0x57CB860", VA = "0x1857CCC60")]
		[MethodImpl(256)]
		public static bool4x4 operator ==(float4x4 lhs, float rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0001E300 File Offset: 0x0001C500
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x57CD020", Offset = "0x57CBC20", VA = "0x1857CD020")]
		[MethodImpl(256)]
		public static bool4x4 operator ==(float lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0001E318 File Offset: 0x0001C518
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x57CE090", Offset = "0x57CCC90", VA = "0x1857CE090")]
		[MethodImpl(256)]
		public static bool4x4 operator !=(float4x4 lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0001E330 File Offset: 0x0001C530
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x57CE280", Offset = "0x57CCE80", VA = "0x1857CE280")]
		[MethodImpl(256)]
		public static bool4x4 operator !=(float4x4 lhs, float rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0001E348 File Offset: 0x0001C548
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x57CDEF0", Offset = "0x57CCAF0", VA = "0x1857CDEF0")]
		[MethodImpl(256)]
		public static bool4x4 operator !=(float lhs, float4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x170005C7 RID: 1479
		[Token(Token = "0x170005C7")]
		public float4 this[int index]
		{
			[Token(Token = "0x6001570")]
			[Address(RVA = "0x3D28160", Offset = "0x3D26D60", VA = "0x183D28160")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0001E360 File Offset: 0x0001C560
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x57BE1A0", Offset = "0x57BCDA0", VA = "0x1857BE1A0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(float4x4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0001E378 File Offset: 0x0001C578
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x57C93A0", Offset = "0x57C7FA0", VA = "0x1857C93A0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0001E390 File Offset: 0x0001C590
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x57C9AB0", Offset = "0x57C86B0", VA = "0x1857C9AB0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x57CAAA0", Offset = "0x57C96A0", VA = "0x1857CAAA0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x57CB170", Offset = "0x57C9D70", VA = "0x1857CB170", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0001E3A8 File Offset: 0x0001C5A8
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x57CDBA0", Offset = "0x57CC7A0", VA = "0x1857CDBA0")]
		public static implicit operator float4x4(Matrix4x4 m)
		{
			return default(float4x4);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x57CD9B0", Offset = "0x57CC5B0", VA = "0x1857CD9B0")]
		public static implicit operator Matrix4x4(float4x4 m)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x57CB8A0", Offset = "0x57CA4A0", VA = "0x1857CB8A0")]
		public float4x4(float3x3 rotation, float3 translation)
		{
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001579")]
		[Address(RVA = "0x57CB9D0", Offset = "0x57CA5D0", VA = "0x1857CB9D0")]
		public float4x4(quaternion rotation, float3 translation)
		{
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x57CBB10", Offset = "0x57CA710", VA = "0x1857CBB10")]
		public float4x4(RigidTransform transform)
		{
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x0001E3D8 File Offset: 0x0001C5D8
		[Token(Token = "0x600157B")]
		[Address(RVA = "0x57C8DD0", Offset = "0x57C79D0", VA = "0x1857C8DD0")]
		[MethodImpl(256)]
		public static float4x4 AxisAngle(float3 axis, float angle)
		{
			return default(float4x4);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x57BE300", Offset = "0x57BCF00", VA = "0x1857BE300")]
		[MethodImpl(256)]
		public static float4x4 EulerXYZ(float3 xyz)
		{
			return default(float4x4);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x0001E408 File Offset: 0x0001C608
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x57BE520", Offset = "0x57BD120", VA = "0x1857BE520")]
		[MethodImpl(256)]
		public static float4x4 EulerXZY(float3 xyz)
		{
			return default(float4x4);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0001E420 File Offset: 0x0001C620
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x57BE730", Offset = "0x57BD330", VA = "0x1857BE730")]
		[MethodImpl(256)]
		public static float4x4 EulerYXZ(float3 xyz)
		{
			return default(float4x4);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x0001E438 File Offset: 0x0001C638
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x57BE930", Offset = "0x57BD530", VA = "0x1857BE930")]
		[MethodImpl(256)]
		public static float4x4 EulerYZX(float3 xyz)
		{
			return default(float4x4);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0001E450 File Offset: 0x0001C650
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x57BEB20", Offset = "0x57BD720", VA = "0x1857BEB20")]
		[MethodImpl(256)]
		public static float4x4 EulerZXY(float3 xyz)
		{
			return default(float4x4);
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x0001E468 File Offset: 0x0001C668
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x57BED00", Offset = "0x57BD900", VA = "0x1857BED00")]
		[MethodImpl(256)]
		public static float4x4 EulerZYX(float3 xyz)
		{
			return default(float4x4);
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0001E480 File Offset: 0x0001C680
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x57C9450", Offset = "0x57C8050", VA = "0x1857C9450")]
		[MethodImpl(256)]
		public static float4x4 EulerXYZ(float x, float y, float z)
		{
			return default(float4x4);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0001E498 File Offset: 0x0001C698
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x57C94C0", Offset = "0x57C80C0", VA = "0x1857C94C0")]
		[MethodImpl(256)]
		public static float4x4 EulerXZY(float x, float y, float z)
		{
			return default(float4x4);
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0001E4B0 File Offset: 0x0001C6B0
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x57C9530", Offset = "0x57C8130", VA = "0x1857C9530")]
		[MethodImpl(256)]
		public static float4x4 EulerYXZ(float x, float y, float z)
		{
			return default(float4x4);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
		[Token(Token = "0x6001585")]
		[Address(RVA = "0x57C95A0", Offset = "0x57C81A0", VA = "0x1857C95A0")]
		[MethodImpl(256)]
		public static float4x4 EulerYZX(float x, float y, float z)
		{
			return default(float4x4);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x57C9610", Offset = "0x57C8210", VA = "0x1857C9610")]
		[MethodImpl(256)]
		public static float4x4 EulerZXY(float x, float y, float z)
		{
			return default(float4x4);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0001E4F8 File Offset: 0x0001C6F8
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x57C9680", Offset = "0x57C8280", VA = "0x1857C9680")]
		[MethodImpl(256)]
		public static float4x4 EulerZYX(float x, float y, float z)
		{
			return default(float4x4);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0001E510 File Offset: 0x0001C710
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x57C9910", Offset = "0x57C8510", VA = "0x1857C9910")]
		[MethodImpl(256)]
		public static float4x4 Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default(float4x4);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0001E528 File Offset: 0x0001C728
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x57C96F0", Offset = "0x57C82F0", VA = "0x1857C96F0")]
		[MethodImpl(256)]
		public static float4x4 Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default(float4x4);
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0001E540 File Offset: 0x0001C740
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x57CA320", Offset = "0x57C8F20", VA = "0x1857CA320")]
		[MethodImpl(256)]
		public static float4x4 RotateX(float angle)
		{
			return default(float4x4);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0001E558 File Offset: 0x0001C758
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x57CA460", Offset = "0x57C9060", VA = "0x1857CA460")]
		[MethodImpl(256)]
		public static float4x4 RotateY(float angle)
		{
			return default(float4x4);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0001E570 File Offset: 0x0001C770
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x57CA5B0", Offset = "0x57C91B0", VA = "0x1857CA5B0")]
		[MethodImpl(256)]
		public static float4x4 RotateZ(float angle)
		{
			return default(float4x4);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0001E588 File Offset: 0x0001C788
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x57CA770", Offset = "0x57C9370", VA = "0x1857CA770")]
		[MethodImpl(256)]
		public static float4x4 Scale(float s)
		{
			return default(float4x4);
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x57CA6F0", Offset = "0x57C92F0", VA = "0x1857CA6F0")]
		[MethodImpl(256)]
		public static float4x4 Scale(float x, float y, float z)
		{
			return default(float4x4);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0001E5B8 File Offset: 0x0001C7B8
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x57CA7F0", Offset = "0x57C93F0", VA = "0x1857CA7F0")]
		[MethodImpl(256)]
		public static float4x4 Scale(float3 scales)
		{
			return default(float4x4);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0001E5D0 File Offset: 0x0001C7D0
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x57CB7D0", Offset = "0x57CA3D0", VA = "0x1857CB7D0")]
		[MethodImpl(256)]
		public static float4x4 Translate(float3 vector)
		{
			return default(float4x4);
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0001E5E8 File Offset: 0x0001C7E8
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x57C9AF0", Offset = "0x57C86F0", VA = "0x1857C9AF0")]
		[MethodImpl(256)]
		public static float4x4 LookAt(float3 eye, float3 target, float3 up)
		{
			return default(float4x4);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x0001E600 File Offset: 0x0001C800
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x57C9F50", Offset = "0x57C8B50", VA = "0x1857C9F50")]
		[MethodImpl(256)]
		public static float4x4 Ortho(float width, float height, float near, float far)
		{
			return default(float4x4);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x0001E618 File Offset: 0x0001C818
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x57C9DB0", Offset = "0x57C89B0", VA = "0x1857C9DB0")]
		[MethodImpl(256)]
		public static float4x4 OrthoOffCenter(float left, float right, float bottom, float top, float near, float far)
		{
			return default(float4x4);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x0001E630 File Offset: 0x0001C830
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x57CA040", Offset = "0x57C8C40", VA = "0x1857CA040")]
		[MethodImpl(256)]
		public static float4x4 PerspectiveFov(float verticalFov, float aspect, float near, float far)
		{
			return default(float4x4);
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x0001E648 File Offset: 0x0001C848
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x57CA1A0", Offset = "0x57C8DA0", VA = "0x1857CA1A0")]
		[MethodImpl(256)]
		public static float4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far)
		{
			return default(float4x4);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0001E660 File Offset: 0x0001C860
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x57CA890", Offset = "0x57C9490", VA = "0x1857CA890")]
		[MethodImpl(256)]
		public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale)
		{
			return default(float4x4);
		}

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x0")]
		public float4 c0;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x10")]
		public float4 c1;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x20")]
		public float4 c2;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x30")]
		public float4 c3;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float4x4 identity;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x40")]
		public static readonly float4x4 zero;
	}
}
