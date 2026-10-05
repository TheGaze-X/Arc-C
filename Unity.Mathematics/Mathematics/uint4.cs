using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[DebuggerTypeProxy(typeof(uint4.DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct uint4 : IEquatable<uint4>, IFormattable
	{
		// Token: 0x06002194 RID: 8596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002194")]
		[Address(RVA = "0x1CA1750", Offset = "0x1CA0350", VA = "0x181CA1750")]
		[MethodImpl(256)]
		public uint4(uint x, uint y, uint z, uint w)
		{
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002195")]
		[Address(RVA = "0x576A1D0", Offset = "0x5768DD0", VA = "0x18576A1D0")]
		[MethodImpl(256)]
		public uint4(uint x, uint y, uint2 zw)
		{
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002196")]
		[Address(RVA = "0x576A190", Offset = "0x5768D90", VA = "0x18576A190")]
		[MethodImpl(256)]
		public uint4(uint x, uint2 yz, uint w)
		{
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002197")]
		[Address(RVA = "0x576A120", Offset = "0x5768D20", VA = "0x18576A120")]
		[MethodImpl(256)]
		public uint4(uint x, uint3 yzw)
		{
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002198")]
		[Address(RVA = "0x576A100", Offset = "0x5768D00", VA = "0x18576A100")]
		[MethodImpl(256)]
		public uint4(uint2 xy, uint z, uint w)
		{
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002199")]
		[Address(RVA = "0x576A2D0", Offset = "0x5768ED0", VA = "0x18576A2D0")]
		[MethodImpl(256)]
		public uint4(uint2 xy, uint2 zw)
		{
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219A")]
		[Address(RVA = "0x576A090", Offset = "0x5768C90", VA = "0x18576A090")]
		[MethodImpl(256)]
		public uint4(uint3 xyz, uint w)
		{
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219B")]
		[Address(RVA = "0x576A1B0", Offset = "0x5768DB0", VA = "0x18576A1B0")]
		[MethodImpl(256)]
		public uint4(uint4 xyzw)
		{
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219C")]
		[Address(RVA = "0x576A010", Offset = "0x5768C10", VA = "0x18576A010")]
		[MethodImpl(256)]
		public uint4(uint v)
		{
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219D")]
		[Address(RVA = "0x576A1F0", Offset = "0x5768DF0", VA = "0x18576A1F0")]
		[MethodImpl(256)]
		public uint4(bool v)
		{
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219E")]
		[Address(RVA = "0x576A140", Offset = "0x5768D40", VA = "0x18576A140")]
		[MethodImpl(256)]
		public uint4(bool4 v)
		{
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219F")]
		[Address(RVA = "0x576A010", Offset = "0x5768C10", VA = "0x18576A010")]
		[MethodImpl(256)]
		public uint4(int v)
		{
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A0")]
		[Address(RVA = "0x576A1B0", Offset = "0x5768DB0", VA = "0x18576A1B0")]
		[MethodImpl(256)]
		public uint4(int4 v)
		{
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A1")]
		[Address(RVA = "0x576A210", Offset = "0x5768E10", VA = "0x18576A210")]
		[MethodImpl(256)]
		public uint4(float v)
		{
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A2")]
		[Address(RVA = "0x576A020", Offset = "0x5768C20", VA = "0x18576A020")]
		[MethodImpl(256)]
		public uint4(float4 v)
		{
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A3")]
		[Address(RVA = "0x576A0B0", Offset = "0x5768CB0", VA = "0x18576A0B0")]
		[MethodImpl(256)]
		public uint4(double v)
		{
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A4")]
		[Address(RVA = "0x576A260", Offset = "0x5768E60", VA = "0x18576A260")]
		[MethodImpl(256)]
		public uint4(double4 v)
		{
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0002D438 File Offset: 0x0002B638
		[Token(Token = "0x60021A5")]
		[Address(RVA = "0x572A4C0", Offset = "0x57290C0", VA = "0x18572A4C0")]
		[MethodImpl(256)]
		public static implicit operator uint4(uint v)
		{
			return default(uint4);
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x0002D450 File Offset: 0x0002B650
		[Token(Token = "0x60021A6")]
		[Address(RVA = "0x572A4D0", Offset = "0x57290D0", VA = "0x18572A4D0")]
		[MethodImpl(256)]
		public static explicit operator uint4(bool v)
		{
			return default(uint4);
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x0002D468 File Offset: 0x0002B668
		[Token(Token = "0x60021A7")]
		[Address(RVA = "0x572A530", Offset = "0x5729130", VA = "0x18572A530")]
		[MethodImpl(256)]
		public static explicit operator uint4(bool4 v)
		{
			return default(uint4);
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x0002D480 File Offset: 0x0002B680
		[Token(Token = "0x60021A8")]
		[Address(RVA = "0x572A4C0", Offset = "0x57290C0", VA = "0x18572A4C0")]
		[MethodImpl(256)]
		public static explicit operator uint4(int v)
		{
			return default(uint4);
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x0002D498 File Offset: 0x0002B698
		[Token(Token = "0x60021A9")]
		[Address(RVA = "0x572A480", Offset = "0x5729080", VA = "0x18572A480")]
		[MethodImpl(256)]
		public static explicit operator uint4(int4 v)
		{
			return default(uint4);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0002D4B0 File Offset: 0x0002B6B0
		[Token(Token = "0x60021AA")]
		[Address(RVA = "0x5754990", Offset = "0x5753590", VA = "0x185754990")]
		[MethodImpl(256)]
		public static explicit operator uint4(float v)
		{
			return default(uint4);
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0002D4C8 File Offset: 0x0002B6C8
		[Token(Token = "0x60021AB")]
		[Address(RVA = "0x5754A30", Offset = "0x5753630", VA = "0x185754A30")]
		[MethodImpl(256)]
		public static explicit operator uint4(float4 v)
		{
			return default(uint4);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0002D4E0 File Offset: 0x0002B6E0
		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x57549E0", Offset = "0x57535E0", VA = "0x1857549E0")]
		[MethodImpl(256)]
		public static explicit operator uint4(double v)
		{
			return default(uint4);
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
		[Token(Token = "0x60021AD")]
		[Address(RVA = "0x5754900", Offset = "0x5753500", VA = "0x185754900")]
		[MethodImpl(256)]
		public static explicit operator uint4(double4 v)
		{
			return default(uint4);
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x0002D510 File Offset: 0x0002B710
		[Token(Token = "0x60021AE")]
		[Address(RVA = "0x576D460", Offset = "0x576C060", VA = "0x18576D460")]
		[MethodImpl(256)]
		public static uint4 operator *(uint4 lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x0002D528 File Offset: 0x0002B728
		[Token(Token = "0x60021AF")]
		[Address(RVA = "0x576D430", Offset = "0x576C030", VA = "0x18576D430")]
		[MethodImpl(256)]
		public static uint4 operator *(uint4 lhs, uint rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x0002D540 File Offset: 0x0002B740
		[Token(Token = "0x60021B0")]
		[Address(RVA = "0x576D490", Offset = "0x576C090", VA = "0x18576D490")]
		[MethodImpl(256)]
		public static uint4 operator *(uint lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x0002D558 File Offset: 0x0002B758
		[Token(Token = "0x60021B1")]
		[Address(RVA = "0x576CC80", Offset = "0x576B880", VA = "0x18576CC80")]
		[MethodImpl(256)]
		public static uint4 operator +(uint4 lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x0002D570 File Offset: 0x0002B770
		[Token(Token = "0x60021B2")]
		[Address(RVA = "0x576CCB0", Offset = "0x576B8B0", VA = "0x18576CCB0")]
		[MethodImpl(256)]
		public static uint4 operator +(uint4 lhs, uint rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x0002D588 File Offset: 0x0002B788
		[Token(Token = "0x60021B3")]
		[Address(RVA = "0x576CCE0", Offset = "0x576B8E0", VA = "0x18576CCE0")]
		[MethodImpl(256)]
		public static uint4 operator +(uint lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x0002D5A0 File Offset: 0x0002B7A0
		[Token(Token = "0x60021B4")]
		[Address(RVA = "0x576D580", Offset = "0x576C180", VA = "0x18576D580")]
		[MethodImpl(256)]
		public static uint4 operator -(uint4 lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x0002D5B8 File Offset: 0x0002B7B8
		[Token(Token = "0x60021B5")]
		[Address(RVA = "0x576D550", Offset = "0x576C150", VA = "0x18576D550")]
		[MethodImpl(256)]
		public static uint4 operator -(uint4 lhs, uint rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0002D5D0 File Offset: 0x0002B7D0
		[Token(Token = "0x60021B6")]
		[Address(RVA = "0x576D520", Offset = "0x576C120", VA = "0x18576D520")]
		[MethodImpl(256)]
		public static uint4 operator -(uint lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
		[Token(Token = "0x60021B7")]
		[Address(RVA = "0x576CE60", Offset = "0x576BA60", VA = "0x18576CE60")]
		[MethodImpl(256)]
		public static uint4 operator /(uint4 lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x0002D600 File Offset: 0x0002B800
		[Token(Token = "0x60021B8")]
		[Address(RVA = "0x576CEA0", Offset = "0x576BAA0", VA = "0x18576CEA0")]
		[MethodImpl(256)]
		public static uint4 operator /(uint4 lhs, uint rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0002D618 File Offset: 0x0002B818
		[Token(Token = "0x60021B9")]
		[Address(RVA = "0x576CEE0", Offset = "0x576BAE0", VA = "0x18576CEE0")]
		[MethodImpl(256)]
		public static uint4 operator /(uint lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x0002D630 File Offset: 0x0002B830
		[Token(Token = "0x60021BA")]
		[Address(RVA = "0x576D3B0", Offset = "0x576BFB0", VA = "0x18576D3B0")]
		[MethodImpl(256)]
		public static uint4 operator %(uint4 lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x0002D648 File Offset: 0x0002B848
		[Token(Token = "0x60021BB")]
		[Address(RVA = "0x576D3F0", Offset = "0x576BFF0", VA = "0x18576D3F0")]
		[MethodImpl(256)]
		public static uint4 operator %(uint4 lhs, uint rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0002D660 File Offset: 0x0002B860
		[Token(Token = "0x60021BC")]
		[Address(RVA = "0x576D370", Offset = "0x576BF70", VA = "0x18576D370")]
		[MethodImpl(256)]
		public static uint4 operator %(uint lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0002D678 File Offset: 0x0002B878
		[Token(Token = "0x60021BD")]
		[Address(RVA = "0x576D160", Offset = "0x576BD60", VA = "0x18576D160")]
		[MethodImpl(256)]
		public static uint4 operator ++(uint4 val)
		{
			return default(uint4);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0002D690 File Offset: 0x0002B890
		[Token(Token = "0x60021BE")]
		[Address(RVA = "0x576CE30", Offset = "0x576BA30", VA = "0x18576CE30")]
		[MethodImpl(256)]
		public static uint4 operator --(uint4 val)
		{
			return default(uint4);
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
		[Token(Token = "0x60021BF")]
		[Address(RVA = "0x576D2E0", Offset = "0x576BEE0", VA = "0x18576D2E0")]
		[MethodImpl(256)]
		public static bool4 operator <(uint4 lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0002D6C0 File Offset: 0x0002B8C0
		[Token(Token = "0x60021C0")]
		[Address(RVA = "0x576D310", Offset = "0x576BF10", VA = "0x18576D310")]
		[MethodImpl(256)]
		public static bool4 operator <(uint4 lhs, uint rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0002D6D8 File Offset: 0x0002B8D8
		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x576D340", Offset = "0x576BF40", VA = "0x18576D340")]
		[MethodImpl(256)]
		public static bool4 operator <(uint lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0002D6F0 File Offset: 0x0002B8F0
		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x576D280", Offset = "0x576BE80", VA = "0x18576D280")]
		[MethodImpl(256)]
		public static bool4 operator <=(uint4 lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0002D708 File Offset: 0x0002B908
		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x576D2B0", Offset = "0x576BEB0", VA = "0x18576D2B0")]
		[MethodImpl(256)]
		public static bool4 operator <=(uint4 lhs, uint rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0002D720 File Offset: 0x0002B920
		[Token(Token = "0x60021C4")]
		[Address(RVA = "0x576D250", Offset = "0x576BE50", VA = "0x18576D250")]
		[MethodImpl(256)]
		public static bool4 operator <=(uint lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0002D738 File Offset: 0x0002B938
		[Token(Token = "0x60021C5")]
		[Address(RVA = "0x576D0D0", Offset = "0x576BCD0", VA = "0x18576D0D0")]
		[MethodImpl(256)]
		public static bool4 operator >(uint4 lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x0002D750 File Offset: 0x0002B950
		[Token(Token = "0x60021C6")]
		[Address(RVA = "0x576D130", Offset = "0x576BD30", VA = "0x18576D130")]
		[MethodImpl(256)]
		public static bool4 operator >(uint4 lhs, uint rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x0002D768 File Offset: 0x0002B968
		[Token(Token = "0x60021C7")]
		[Address(RVA = "0x576D100", Offset = "0x576BD00", VA = "0x18576D100")]
		[MethodImpl(256)]
		public static bool4 operator >(uint lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x0002D780 File Offset: 0x0002B980
		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x576D070", Offset = "0x576BC70", VA = "0x18576D070")]
		[MethodImpl(256)]
		public static bool4 operator >=(uint4 lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x0002D798 File Offset: 0x0002B998
		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x576D040", Offset = "0x576BC40", VA = "0x18576D040")]
		[MethodImpl(256)]
		public static bool4 operator >=(uint4 lhs, uint rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		[Token(Token = "0x60021CA")]
		[Address(RVA = "0x576D0A0", Offset = "0x576BCA0", VA = "0x18576D0A0")]
		[MethodImpl(256)]
		public static bool4 operator >=(uint lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0002D7C8 File Offset: 0x0002B9C8
		[Token(Token = "0x60021CB")]
		[Address(RVA = "0x576D5B0", Offset = "0x576C1B0", VA = "0x18576D5B0")]
		[MethodImpl(256)]
		public static uint4 operator -(uint4 val)
		{
			return default(uint4);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x576B4A0", Offset = "0x576A0A0", VA = "0x18576B4A0")]
		[MethodImpl(256)]
		public static uint4 operator +(uint4 val)
		{
			return default(uint4);
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x0002D7F8 File Offset: 0x0002B9F8
		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x576D220", Offset = "0x576BE20", VA = "0x18576D220")]
		[MethodImpl(256)]
		public static uint4 operator <<(uint4 x, int n)
		{
			return default(uint4);
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0002D810 File Offset: 0x0002BA10
		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x576D4F0", Offset = "0x576C0F0", VA = "0x18576D4F0")]
		[MethodImpl(256)]
		public static uint4 operator >>(uint4 x, int n)
		{
			return default(uint4);
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0002D828 File Offset: 0x0002BA28
		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x576CF20", Offset = "0x576BB20", VA = "0x18576CF20")]
		[MethodImpl(256)]
		public static bool4 operator ==(uint4 lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x0002D840 File Offset: 0x0002BA40
		[Token(Token = "0x60021D0")]
		[Address(RVA = "0x576CF80", Offset = "0x576BB80", VA = "0x18576CF80")]
		[MethodImpl(256)]
		public static bool4 operator ==(uint4 lhs, uint rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x0002D858 File Offset: 0x0002BA58
		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x576CF50", Offset = "0x576BB50", VA = "0x18576CF50")]
		[MethodImpl(256)]
		public static bool4 operator ==(uint lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x0002D870 File Offset: 0x0002BA70
		[Token(Token = "0x60021D2")]
		[Address(RVA = "0x576D190", Offset = "0x576BD90", VA = "0x18576D190")]
		[MethodImpl(256)]
		public static bool4 operator !=(uint4 lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x0002D888 File Offset: 0x0002BA88
		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x576D1F0", Offset = "0x576BDF0", VA = "0x18576D1F0")]
		[MethodImpl(256)]
		public static bool4 operator !=(uint4 lhs, uint rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x0002D8A0 File Offset: 0x0002BAA0
		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x576D1C0", Offset = "0x576BDC0", VA = "0x18576D1C0")]
		[MethodImpl(256)]
		public static bool4 operator !=(uint lhs, uint4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
		[Token(Token = "0x60021D5")]
		[Address(RVA = "0x576D4C0", Offset = "0x576C0C0", VA = "0x18576D4C0")]
		[MethodImpl(256)]
		public static uint4 operator ~(uint4 val)
		{
			return default(uint4);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x0002D8D0 File Offset: 0x0002BAD0
		[Token(Token = "0x60021D6")]
		[Address(RVA = "0x576CD10", Offset = "0x576B910", VA = "0x18576CD10")]
		[MethodImpl(256)]
		public static uint4 operator &(uint4 lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0002D8E8 File Offset: 0x0002BAE8
		[Token(Token = "0x60021D7")]
		[Address(RVA = "0x576CD70", Offset = "0x576B970", VA = "0x18576CD70")]
		[MethodImpl(256)]
		public static uint4 operator &(uint4 lhs, uint rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x0002D900 File Offset: 0x0002BB00
		[Token(Token = "0x60021D8")]
		[Address(RVA = "0x576CD40", Offset = "0x576B940", VA = "0x18576CD40")]
		[MethodImpl(256)]
		public static uint4 operator &(uint lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0002D918 File Offset: 0x0002BB18
		[Token(Token = "0x60021D9")]
		[Address(RVA = "0x576CE00", Offset = "0x576BA00", VA = "0x18576CE00")]
		[MethodImpl(256)]
		public static uint4 operator |(uint4 lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x0002D930 File Offset: 0x0002BB30
		[Token(Token = "0x60021DA")]
		[Address(RVA = "0x576CDD0", Offset = "0x576B9D0", VA = "0x18576CDD0")]
		[MethodImpl(256)]
		public static uint4 operator |(uint4 lhs, uint rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0002D948 File Offset: 0x0002BB48
		[Token(Token = "0x60021DB")]
		[Address(RVA = "0x576CDA0", Offset = "0x576B9A0", VA = "0x18576CDA0")]
		[MethodImpl(256)]
		public static uint4 operator |(uint lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0002D960 File Offset: 0x0002BB60
		[Token(Token = "0x60021DC")]
		[Address(RVA = "0x576D010", Offset = "0x576BC10", VA = "0x18576D010")]
		[MethodImpl(256)]
		public static uint4 operator ^(uint4 lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0002D978 File Offset: 0x0002BB78
		[Token(Token = "0x60021DD")]
		[Address(RVA = "0x576CFE0", Offset = "0x576BBE0", VA = "0x18576CFE0")]
		[MethodImpl(256)]
		public static uint4 operator ^(uint4 lhs, uint rhs)
		{
			return default(uint4);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x0002D990 File Offset: 0x0002BB90
		[Token(Token = "0x60021DE")]
		[Address(RVA = "0x576CFB0", Offset = "0x576BBB0", VA = "0x18576CFB0")]
		[MethodImpl(256)]
		public static uint4 operator ^(uint lhs, uint4 rhs)
		{
			return default(uint4);
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x0002D9A8 File Offset: 0x0002BBA8
		[Token(Token = "0x17000A36")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxx
		{
			[Token(Token = "0x60021DF")]
			[Address(RVA = "0x576B0E0", Offset = "0x5769CE0", VA = "0x18576B0E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x0002D9C0 File Offset: 0x0002BBC0
		[Token(Token = "0x17000A37")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxy
		{
			[Token(Token = "0x60021E0")]
			[Address(RVA = "0x576B100", Offset = "0x5769D00", VA = "0x18576B100")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x0002D9D8 File Offset: 0x0002BBD8
		[Token(Token = "0x17000A38")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxz
		{
			[Token(Token = "0x60021E1")]
			[Address(RVA = "0x576B120", Offset = "0x5769D20", VA = "0x18576B120")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
		[Token(Token = "0x17000A39")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxw
		{
			[Token(Token = "0x60021E2")]
			[Address(RVA = "0x576B0C0", Offset = "0x5769CC0", VA = "0x18576B0C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x0002DA08 File Offset: 0x0002BC08
		[Token(Token = "0x17000A3A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyx
		{
			[Token(Token = "0x60021E3")]
			[Address(RVA = "0x576B180", Offset = "0x5769D80", VA = "0x18576B180")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x0002DA20 File Offset: 0x0002BC20
		[Token(Token = "0x17000A3B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyy
		{
			[Token(Token = "0x60021E4")]
			[Address(RVA = "0x576B1A0", Offset = "0x5769DA0", VA = "0x18576B1A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x0002DA38 File Offset: 0x0002BC38
		[Token(Token = "0x17000A3C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyz
		{
			[Token(Token = "0x60021E5")]
			[Address(RVA = "0x576B1C0", Offset = "0x5769DC0", VA = "0x18576B1C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x0002DA50 File Offset: 0x0002BC50
		[Token(Token = "0x17000A3D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyw
		{
			[Token(Token = "0x60021E6")]
			[Address(RVA = "0x576B160", Offset = "0x5769D60", VA = "0x18576B160")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x060021E7 RID: 8679 RVA: 0x0002DA68 File Offset: 0x0002BC68
		[Token(Token = "0x17000A3E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxzx
		{
			[Token(Token = "0x60021E7")]
			[Address(RVA = "0x576B220", Offset = "0x5769E20", VA = "0x18576B220")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0002DA80 File Offset: 0x0002BC80
		[Token(Token = "0x17000A3F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxzy
		{
			[Token(Token = "0x60021E8")]
			[Address(RVA = "0x576B240", Offset = "0x5769E40", VA = "0x18576B240")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x0002DA98 File Offset: 0x0002BC98
		[Token(Token = "0x17000A40")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxzz
		{
			[Token(Token = "0x60021E9")]
			[Address(RVA = "0x576B260", Offset = "0x5769E60", VA = "0x18576B260")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x0002DAB0 File Offset: 0x0002BCB0
		[Token(Token = "0x17000A41")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxzw
		{
			[Token(Token = "0x60021EA")]
			[Address(RVA = "0x576B200", Offset = "0x5769E00", VA = "0x18576B200")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x0002DAC8 File Offset: 0x0002BCC8
		[Token(Token = "0x17000A42")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxwx
		{
			[Token(Token = "0x60021EB")]
			[Address(RVA = "0x576B050", Offset = "0x5769C50", VA = "0x18576B050")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x0002DAE0 File Offset: 0x0002BCE0
		[Token(Token = "0x17000A43")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxwy
		{
			[Token(Token = "0x60021EC")]
			[Address(RVA = "0x576B070", Offset = "0x5769C70", VA = "0x18576B070")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x0002DAF8 File Offset: 0x0002BCF8
		[Token(Token = "0x17000A44")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxwz
		{
			[Token(Token = "0x60021ED")]
			[Address(RVA = "0x576B090", Offset = "0x5769C90", VA = "0x18576B090")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x0002DB10 File Offset: 0x0002BD10
		[Token(Token = "0x17000A45")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxww
		{
			[Token(Token = "0x60021EE")]
			[Address(RVA = "0x576B030", Offset = "0x5769C30", VA = "0x18576B030")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x0002DB28 File Offset: 0x0002BD28
		[Token(Token = "0x17000A46")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxx
		{
			[Token(Token = "0x60021EF")]
			[Address(RVA = "0x576B380", Offset = "0x5769F80", VA = "0x18576B380")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x0002DB40 File Offset: 0x0002BD40
		[Token(Token = "0x17000A47")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxy
		{
			[Token(Token = "0x60021F0")]
			[Address(RVA = "0x576B3A0", Offset = "0x5769FA0", VA = "0x18576B3A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x0002DB58 File Offset: 0x0002BD58
		[Token(Token = "0x17000A48")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxz
		{
			[Token(Token = "0x60021F1")]
			[Address(RVA = "0x576B3C0", Offset = "0x5769FC0", VA = "0x18576B3C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x0002DB70 File Offset: 0x0002BD70
		[Token(Token = "0x17000A49")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxw
		{
			[Token(Token = "0x60021F2")]
			[Address(RVA = "0x576B360", Offset = "0x5769F60", VA = "0x18576B360")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x0002DB88 File Offset: 0x0002BD88
		[Token(Token = "0x17000A4A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyx
		{
			[Token(Token = "0x60021F3")]
			[Address(RVA = "0x576B420", Offset = "0x576A020", VA = "0x18576B420")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x0002DBA0 File Offset: 0x0002BDA0
		[Token(Token = "0x17000A4B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyy
		{
			[Token(Token = "0x60021F4")]
			[Address(RVA = "0x576B440", Offset = "0x576A040", VA = "0x18576B440")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x0002DBB8 File Offset: 0x0002BDB8
		[Token(Token = "0x17000A4C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyz
		{
			[Token(Token = "0x60021F5")]
			[Address(RVA = "0x576B460", Offset = "0x576A060", VA = "0x18576B460")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x0002DBD0 File Offset: 0x0002BDD0
		[Token(Token = "0x17000A4D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyw
		{
			[Token(Token = "0x60021F6")]
			[Address(RVA = "0x576B400", Offset = "0x576A000", VA = "0x18576B400")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
		[Token(Token = "0x17000A4E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzx
		{
			[Token(Token = "0x60021F7")]
			[Address(RVA = "0x576B4C0", Offset = "0x576A0C0", VA = "0x18576B4C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x0002DC00 File Offset: 0x0002BE00
		[Token(Token = "0x17000A4F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzy
		{
			[Token(Token = "0x60021F8")]
			[Address(RVA = "0x576B4E0", Offset = "0x576A0E0", VA = "0x18576B4E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x0002DC18 File Offset: 0x0002BE18
		[Token(Token = "0x17000A50")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzz
		{
			[Token(Token = "0x60021F9")]
			[Address(RVA = "0x576B500", Offset = "0x576A100", VA = "0x18576B500")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x0002DC30 File Offset: 0x0002BE30
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A51")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzw
		{
			[Token(Token = "0x60021FA")]
			[Address(RVA = "0x576B4A0", Offset = "0x576A0A0", VA = "0x18576B4A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x60021FB")]
			[Address(RVA = "0x576A1B0", Offset = "0x5768DB0", VA = "0x18576A1B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x0002DC48 File Offset: 0x0002BE48
		[Token(Token = "0x17000A52")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xywx
		{
			[Token(Token = "0x60021FC")]
			[Address(RVA = "0x576B2E0", Offset = "0x5769EE0", VA = "0x18576B2E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x0002DC60 File Offset: 0x0002BE60
		[Token(Token = "0x17000A53")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xywy
		{
			[Token(Token = "0x60021FD")]
			[Address(RVA = "0x576B300", Offset = "0x5769F00", VA = "0x18576B300")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x0002DC78 File Offset: 0x0002BE78
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A54")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xywz
		{
			[Token(Token = "0x60021FE")]
			[Address(RVA = "0x576B320", Offset = "0x5769F20", VA = "0x18576B320")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x60021FF")]
			[Address(RVA = "0x576D850", Offset = "0x576C450", VA = "0x18576D850")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x0002DC90 File Offset: 0x0002BE90
		[Token(Token = "0x17000A55")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyww
		{
			[Token(Token = "0x6002200")]
			[Address(RVA = "0x576B2C0", Offset = "0x5769EC0", VA = "0x18576B2C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x0002DCA8 File Offset: 0x0002BEA8
		[Token(Token = "0x17000A56")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzxx
		{
			[Token(Token = "0x6002201")]
			[Address(RVA = "0x576B620", Offset = "0x576A220", VA = "0x18576B620")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x0002DCC0 File Offset: 0x0002BEC0
		[Token(Token = "0x17000A57")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzxy
		{
			[Token(Token = "0x6002202")]
			[Address(RVA = "0x576B640", Offset = "0x576A240", VA = "0x18576B640")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x0002DCD8 File Offset: 0x0002BED8
		[Token(Token = "0x17000A58")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzxz
		{
			[Token(Token = "0x6002203")]
			[Address(RVA = "0x576B660", Offset = "0x576A260", VA = "0x18576B660")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x0002DCF0 File Offset: 0x0002BEF0
		[Token(Token = "0x17000A59")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzxw
		{
			[Token(Token = "0x6002204")]
			[Address(RVA = "0x576B600", Offset = "0x576A200", VA = "0x18576B600")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x0002DD08 File Offset: 0x0002BF08
		[Token(Token = "0x17000A5A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzyx
		{
			[Token(Token = "0x6002205")]
			[Address(RVA = "0x576B6C0", Offset = "0x576A2C0", VA = "0x18576B6C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x0002DD20 File Offset: 0x0002BF20
		[Token(Token = "0x17000A5B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzyy
		{
			[Token(Token = "0x6002206")]
			[Address(RVA = "0x576B6E0", Offset = "0x576A2E0", VA = "0x18576B6E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x0002DD38 File Offset: 0x0002BF38
		[Token(Token = "0x17000A5C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzyz
		{
			[Token(Token = "0x6002207")]
			[Address(RVA = "0x576B700", Offset = "0x576A300", VA = "0x18576B700")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002208 RID: 8712 RVA: 0x0002DD50 File Offset: 0x0002BF50
		// (set) Token: 0x06002209 RID: 8713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzyw
		{
			[Token(Token = "0x6002208")]
			[Address(RVA = "0x576B6A0", Offset = "0x576A2A0", VA = "0x18576B6A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x6002209")]
			[Address(RVA = "0x576D8E0", Offset = "0x576C4E0", VA = "0x18576D8E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x0002DD68 File Offset: 0x0002BF68
		[Token(Token = "0x17000A5E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzzx
		{
			[Token(Token = "0x600220A")]
			[Address(RVA = "0x576B760", Offset = "0x576A360", VA = "0x18576B760")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x0002DD80 File Offset: 0x0002BF80
		[Token(Token = "0x17000A5F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzzy
		{
			[Token(Token = "0x600220B")]
			[Address(RVA = "0x576B780", Offset = "0x576A380", VA = "0x18576B780")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x0002DD98 File Offset: 0x0002BF98
		[Token(Token = "0x17000A60")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzzz
		{
			[Token(Token = "0x600220C")]
			[Address(RVA = "0x576B7A0", Offset = "0x576A3A0", VA = "0x18576B7A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
		[Token(Token = "0x17000A61")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzzw
		{
			[Token(Token = "0x600220D")]
			[Address(RVA = "0x576B740", Offset = "0x576A340", VA = "0x18576B740")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x0002DDC8 File Offset: 0x0002BFC8
		[Token(Token = "0x17000A62")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzwx
		{
			[Token(Token = "0x600220E")]
			[Address(RVA = "0x576B580", Offset = "0x576A180", VA = "0x18576B580")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A63")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzwy
		{
			[Token(Token = "0x600220F")]
			[Address(RVA = "0x576B5A0", Offset = "0x576A1A0", VA = "0x18576B5A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x6002210")]
			[Address(RVA = "0x576D8A0", Offset = "0x576C4A0", VA = "0x18576D8A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x0002DDF8 File Offset: 0x0002BFF8
		[Token(Token = "0x17000A64")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzwz
		{
			[Token(Token = "0x6002211")]
			[Address(RVA = "0x576B5C0", Offset = "0x576A1C0", VA = "0x18576B5C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x0002DE10 File Offset: 0x0002C010
		[Token(Token = "0x17000A65")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzww
		{
			[Token(Token = "0x6002212")]
			[Address(RVA = "0x576B560", Offset = "0x576A160", VA = "0x18576B560")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x0002DE28 File Offset: 0x0002C028
		[Token(Token = "0x17000A66")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwxx
		{
			[Token(Token = "0x6002213")]
			[Address(RVA = "0x576AE60", Offset = "0x5769A60", VA = "0x18576AE60")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x0002DE40 File Offset: 0x0002C040
		[Token(Token = "0x17000A67")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwxy
		{
			[Token(Token = "0x6002214")]
			[Address(RVA = "0x576AE80", Offset = "0x5769A80", VA = "0x18576AE80")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x0002DE58 File Offset: 0x0002C058
		[Token(Token = "0x17000A68")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwxz
		{
			[Token(Token = "0x6002215")]
			[Address(RVA = "0x576AEA0", Offset = "0x5769AA0", VA = "0x18576AEA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x0002DE70 File Offset: 0x0002C070
		[Token(Token = "0x17000A69")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwxw
		{
			[Token(Token = "0x6002216")]
			[Address(RVA = "0x576AE40", Offset = "0x5769A40", VA = "0x18576AE40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x0002DE88 File Offset: 0x0002C088
		[Token(Token = "0x17000A6A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwyx
		{
			[Token(Token = "0x6002217")]
			[Address(RVA = "0x576AF00", Offset = "0x5769B00", VA = "0x18576AF00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x0002DEA0 File Offset: 0x0002C0A0
		[Token(Token = "0x17000A6B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwyy
		{
			[Token(Token = "0x6002218")]
			[Address(RVA = "0x576AF20", Offset = "0x5769B20", VA = "0x18576AF20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x0002DEB8 File Offset: 0x0002C0B8
		// (set) Token: 0x0600221A RID: 8730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A6C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwyz
		{
			[Token(Token = "0x6002219")]
			[Address(RVA = "0x576AF40", Offset = "0x5769B40", VA = "0x18576AF40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x600221A")]
			[Address(RVA = "0x576D7C0", Offset = "0x576C3C0", VA = "0x18576D7C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x0002DED0 File Offset: 0x0002C0D0
		[Token(Token = "0x17000A6D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwyw
		{
			[Token(Token = "0x600221B")]
			[Address(RVA = "0x576AEE0", Offset = "0x5769AE0", VA = "0x18576AEE0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x0002DEE8 File Offset: 0x0002C0E8
		[Token(Token = "0x17000A6E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwzx
		{
			[Token(Token = "0x600221C")]
			[Address(RVA = "0x576AFA0", Offset = "0x5769BA0", VA = "0x18576AFA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x0002DF00 File Offset: 0x0002C100
		// (set) Token: 0x0600221E RID: 8734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A6F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwzy
		{
			[Token(Token = "0x600221D")]
			[Address(RVA = "0x576AFC0", Offset = "0x5769BC0", VA = "0x18576AFC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x600221E")]
			[Address(RVA = "0x576D800", Offset = "0x576C400", VA = "0x18576D800")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x0002DF18 File Offset: 0x0002C118
		[Token(Token = "0x17000A70")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwzz
		{
			[Token(Token = "0x600221F")]
			[Address(RVA = "0x576AFE0", Offset = "0x5769BE0", VA = "0x18576AFE0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x0002DF30 File Offset: 0x0002C130
		[Token(Token = "0x17000A71")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwzw
		{
			[Token(Token = "0x6002220")]
			[Address(RVA = "0x576AF80", Offset = "0x5769B80", VA = "0x18576AF80")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x0002DF48 File Offset: 0x0002C148
		[Token(Token = "0x17000A72")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwwx
		{
			[Token(Token = "0x6002221")]
			[Address(RVA = "0x576ADC0", Offset = "0x57699C0", VA = "0x18576ADC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x0002DF60 File Offset: 0x0002C160
		[Token(Token = "0x17000A73")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwwy
		{
			[Token(Token = "0x6002222")]
			[Address(RVA = "0x576ADE0", Offset = "0x57699E0", VA = "0x18576ADE0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x0002DF78 File Offset: 0x0002C178
		[Token(Token = "0x17000A74")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwwz
		{
			[Token(Token = "0x6002223")]
			[Address(RVA = "0x576AE00", Offset = "0x5769A00", VA = "0x18576AE00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x0002DF90 File Offset: 0x0002C190
		[Token(Token = "0x17000A75")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xwww
		{
			[Token(Token = "0x6002224")]
			[Address(RVA = "0x576ADA0", Offset = "0x57699A0", VA = "0x18576ADA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x0002DFA8 File Offset: 0x0002C1A8
		[Token(Token = "0x17000A76")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxx
		{
			[Token(Token = "0x6002225")]
			[Address(RVA = "0x576BB60", Offset = "0x576A760", VA = "0x18576BB60")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x0002DFC0 File Offset: 0x0002C1C0
		[Token(Token = "0x17000A77")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxy
		{
			[Token(Token = "0x6002226")]
			[Address(RVA = "0x576BB80", Offset = "0x576A780", VA = "0x18576BB80")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
		[Token(Token = "0x17000A78")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxz
		{
			[Token(Token = "0x6002227")]
			[Address(RVA = "0x576BBA0", Offset = "0x576A7A0", VA = "0x18576BBA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x0002DFF0 File Offset: 0x0002C1F0
		[Token(Token = "0x17000A79")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxw
		{
			[Token(Token = "0x6002228")]
			[Address(RVA = "0x576BB40", Offset = "0x576A740", VA = "0x18576BB40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x0002E008 File Offset: 0x0002C208
		[Token(Token = "0x17000A7A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyx
		{
			[Token(Token = "0x6002229")]
			[Address(RVA = "0x576BC00", Offset = "0x576A800", VA = "0x18576BC00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x0002E020 File Offset: 0x0002C220
		[Token(Token = "0x17000A7B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyy
		{
			[Token(Token = "0x600222A")]
			[Address(RVA = "0x576BC20", Offset = "0x576A820", VA = "0x18576BC20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x0002E038 File Offset: 0x0002C238
		[Token(Token = "0x17000A7C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyz
		{
			[Token(Token = "0x600222B")]
			[Address(RVA = "0x576BC40", Offset = "0x576A840", VA = "0x18576BC40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x0002E050 File Offset: 0x0002C250
		[Token(Token = "0x17000A7D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyw
		{
			[Token(Token = "0x600222C")]
			[Address(RVA = "0x576BBE0", Offset = "0x576A7E0", VA = "0x18576BBE0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x0002E068 File Offset: 0x0002C268
		[Token(Token = "0x17000A7E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxzx
		{
			[Token(Token = "0x600222D")]
			[Address(RVA = "0x576BCA0", Offset = "0x576A8A0", VA = "0x18576BCA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x0002E080 File Offset: 0x0002C280
		[Token(Token = "0x17000A7F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxzy
		{
			[Token(Token = "0x600222E")]
			[Address(RVA = "0x576BCC0", Offset = "0x576A8C0", VA = "0x18576BCC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x0002E098 File Offset: 0x0002C298
		[Token(Token = "0x17000A80")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxzz
		{
			[Token(Token = "0x600222F")]
			[Address(RVA = "0x576BCE0", Offset = "0x576A8E0", VA = "0x18576BCE0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x0002E0B0 File Offset: 0x0002C2B0
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A81")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxzw
		{
			[Token(Token = "0x6002230")]
			[Address(RVA = "0x576BC80", Offset = "0x576A880", VA = "0x18576BC80")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x6002231")]
			[Address(RVA = "0x576DA00", Offset = "0x576C600", VA = "0x18576DA00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x0002E0C8 File Offset: 0x0002C2C8
		[Token(Token = "0x17000A82")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxwx
		{
			[Token(Token = "0x6002232")]
			[Address(RVA = "0x576BAC0", Offset = "0x576A6C0", VA = "0x18576BAC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x0002E0E0 File Offset: 0x0002C2E0
		[Token(Token = "0x17000A83")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxwy
		{
			[Token(Token = "0x6002233")]
			[Address(RVA = "0x576BAE0", Offset = "0x576A6E0", VA = "0x18576BAE0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x0002E0F8 File Offset: 0x0002C2F8
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A84")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxwz
		{
			[Token(Token = "0x6002234")]
			[Address(RVA = "0x576BB00", Offset = "0x576A700", VA = "0x18576BB00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x6002235")]
			[Address(RVA = "0x576D9C0", Offset = "0x576C5C0", VA = "0x18576D9C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x0002E110 File Offset: 0x0002C310
		[Token(Token = "0x17000A85")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxww
		{
			[Token(Token = "0x6002236")]
			[Address(RVA = "0x576BAA0", Offset = "0x576A6A0", VA = "0x18576BAA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x0002E128 File Offset: 0x0002C328
		[Token(Token = "0x17000A86")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxx
		{
			[Token(Token = "0x6002237")]
			[Address(RVA = "0x576BE00", Offset = "0x576AA00", VA = "0x18576BE00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x0002E140 File Offset: 0x0002C340
		[Token(Token = "0x17000A87")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxy
		{
			[Token(Token = "0x6002238")]
			[Address(RVA = "0x576BE20", Offset = "0x576AA20", VA = "0x18576BE20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x0002E158 File Offset: 0x0002C358
		[Token(Token = "0x17000A88")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxz
		{
			[Token(Token = "0x6002239")]
			[Address(RVA = "0x576BE40", Offset = "0x576AA40", VA = "0x18576BE40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x0002E170 File Offset: 0x0002C370
		[Token(Token = "0x17000A89")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxw
		{
			[Token(Token = "0x600223A")]
			[Address(RVA = "0x576BDE0", Offset = "0x576A9E0", VA = "0x18576BDE0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x0002E188 File Offset: 0x0002C388
		[Token(Token = "0x17000A8A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyx
		{
			[Token(Token = "0x600223B")]
			[Address(RVA = "0x576BE90", Offset = "0x576AA90", VA = "0x18576BE90")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x0002E1A0 File Offset: 0x0002C3A0
		[Token(Token = "0x17000A8B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyy
		{
			[Token(Token = "0x600223C")]
			[Address(RVA = "0x576BEB0", Offset = "0x576AAB0", VA = "0x18576BEB0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x0600223D RID: 8765 RVA: 0x0002E1B8 File Offset: 0x0002C3B8
		[Token(Token = "0x17000A8C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyz
		{
			[Token(Token = "0x600223D")]
			[Address(RVA = "0x576BED0", Offset = "0x576AAD0", VA = "0x18576BED0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		[Token(Token = "0x17000A8D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyw
		{
			[Token(Token = "0x600223E")]
			[Address(RVA = "0x576BE70", Offset = "0x576AA70", VA = "0x18576BE70")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x0002E1E8 File Offset: 0x0002C3E8
		[Token(Token = "0x17000A8E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyzx
		{
			[Token(Token = "0x600223F")]
			[Address(RVA = "0x576BF30", Offset = "0x576AB30", VA = "0x18576BF30")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x0002E200 File Offset: 0x0002C400
		[Token(Token = "0x17000A8F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyzy
		{
			[Token(Token = "0x6002240")]
			[Address(RVA = "0x576BF50", Offset = "0x576AB50", VA = "0x18576BF50")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x0002E218 File Offset: 0x0002C418
		[Token(Token = "0x17000A90")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyzz
		{
			[Token(Token = "0x6002241")]
			[Address(RVA = "0x576BF70", Offset = "0x576AB70", VA = "0x18576BF70")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x0002E230 File Offset: 0x0002C430
		[Token(Token = "0x17000A91")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyzw
		{
			[Token(Token = "0x6002242")]
			[Address(RVA = "0x576BF10", Offset = "0x576AB10", VA = "0x18576BF10")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x0002E248 File Offset: 0x0002C448
		[Token(Token = "0x17000A92")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yywx
		{
			[Token(Token = "0x6002243")]
			[Address(RVA = "0x576BD60", Offset = "0x576A960", VA = "0x18576BD60")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x0002E260 File Offset: 0x0002C460
		[Token(Token = "0x17000A93")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yywy
		{
			[Token(Token = "0x6002244")]
			[Address(RVA = "0x576BD80", Offset = "0x576A980", VA = "0x18576BD80")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x0002E278 File Offset: 0x0002C478
		[Token(Token = "0x17000A94")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yywz
		{
			[Token(Token = "0x6002245")]
			[Address(RVA = "0x576BDA0", Offset = "0x576A9A0", VA = "0x18576BDA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x0002E290 File Offset: 0x0002C490
		[Token(Token = "0x17000A95")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyww
		{
			[Token(Token = "0x6002246")]
			[Address(RVA = "0x576BD40", Offset = "0x576A940", VA = "0x18576BD40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x0002E2A8 File Offset: 0x0002C4A8
		[Token(Token = "0x17000A96")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzxx
		{
			[Token(Token = "0x6002247")]
			[Address(RVA = "0x576C090", Offset = "0x576AC90", VA = "0x18576C090")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x0002E2C0 File Offset: 0x0002C4C0
		[Token(Token = "0x17000A97")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzxy
		{
			[Token(Token = "0x6002248")]
			[Address(RVA = "0x576C0B0", Offset = "0x576ACB0", VA = "0x18576C0B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x0002E2D8 File Offset: 0x0002C4D8
		[Token(Token = "0x17000A98")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzxz
		{
			[Token(Token = "0x6002249")]
			[Address(RVA = "0x576C0D0", Offset = "0x576ACD0", VA = "0x18576C0D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x0002E2F0 File Offset: 0x0002C4F0
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A99")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzxw
		{
			[Token(Token = "0x600224A")]
			[Address(RVA = "0x576C070", Offset = "0x576AC70", VA = "0x18576C070")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x600224B")]
			[Address(RVA = "0x576DA90", Offset = "0x576C690", VA = "0x18576DA90")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x0002E308 File Offset: 0x0002C508
		[Token(Token = "0x17000A9A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzyx
		{
			[Token(Token = "0x600224C")]
			[Address(RVA = "0x576C130", Offset = "0x576AD30", VA = "0x18576C130")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x0002E320 File Offset: 0x0002C520
		[Token(Token = "0x17000A9B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzyy
		{
			[Token(Token = "0x600224D")]
			[Address(RVA = "0x576C150", Offset = "0x576AD50", VA = "0x18576C150")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x0002E338 File Offset: 0x0002C538
		[Token(Token = "0x17000A9C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzyz
		{
			[Token(Token = "0x600224E")]
			[Address(RVA = "0x576C170", Offset = "0x576AD70", VA = "0x18576C170")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x0002E350 File Offset: 0x0002C550
		[Token(Token = "0x17000A9D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzyw
		{
			[Token(Token = "0x600224F")]
			[Address(RVA = "0x576C110", Offset = "0x576AD10", VA = "0x18576C110")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x0002E368 File Offset: 0x0002C568
		[Token(Token = "0x17000A9E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzzx
		{
			[Token(Token = "0x6002250")]
			[Address(RVA = "0x576C1D0", Offset = "0x576ADD0", VA = "0x18576C1D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x0002E380 File Offset: 0x0002C580
		[Token(Token = "0x17000A9F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzzy
		{
			[Token(Token = "0x6002251")]
			[Address(RVA = "0x576C1F0", Offset = "0x576ADF0", VA = "0x18576C1F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x0002E398 File Offset: 0x0002C598
		[Token(Token = "0x17000AA0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzzz
		{
			[Token(Token = "0x6002252")]
			[Address(RVA = "0x576C210", Offset = "0x576AE10", VA = "0x18576C210")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x0002E3B0 File Offset: 0x0002C5B0
		[Token(Token = "0x17000AA1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzzw
		{
			[Token(Token = "0x6002253")]
			[Address(RVA = "0x576C1B0", Offset = "0x576ADB0", VA = "0x18576C1B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AA2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzwx
		{
			[Token(Token = "0x6002254")]
			[Address(RVA = "0x576BFF0", Offset = "0x576ABF0", VA = "0x18576BFF0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x6002255")]
			[Address(RVA = "0x576DA50", Offset = "0x576C650", VA = "0x18576DA50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x0002E3E0 File Offset: 0x0002C5E0
		[Token(Token = "0x17000AA3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzwy
		{
			[Token(Token = "0x6002256")]
			[Address(RVA = "0x576C010", Offset = "0x576AC10", VA = "0x18576C010")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
		[Token(Token = "0x17000AA4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzwz
		{
			[Token(Token = "0x6002257")]
			[Address(RVA = "0x576C030", Offset = "0x576AC30", VA = "0x18576C030")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x0002E410 File Offset: 0x0002C610
		[Token(Token = "0x17000AA5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzww
		{
			[Token(Token = "0x6002258")]
			[Address(RVA = "0x576BFD0", Offset = "0x576ABD0", VA = "0x18576BFD0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x0002E428 File Offset: 0x0002C628
		[Token(Token = "0x17000AA6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywxx
		{
			[Token(Token = "0x6002259")]
			[Address(RVA = "0x576B8C0", Offset = "0x576A4C0", VA = "0x18576B8C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x0002E440 File Offset: 0x0002C640
		[Token(Token = "0x17000AA7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywxy
		{
			[Token(Token = "0x600225A")]
			[Address(RVA = "0x576B8E0", Offset = "0x576A4E0", VA = "0x18576B8E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x0002E458 File Offset: 0x0002C658
		// (set) Token: 0x0600225C RID: 8796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AA8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywxz
		{
			[Token(Token = "0x600225B")]
			[Address(RVA = "0x576B900", Offset = "0x576A500", VA = "0x18576B900")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x600225C")]
			[Address(RVA = "0x576D930", Offset = "0x576C530", VA = "0x18576D930")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x0002E470 File Offset: 0x0002C670
		[Token(Token = "0x17000AA9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywxw
		{
			[Token(Token = "0x600225D")]
			[Address(RVA = "0x576B8A0", Offset = "0x576A4A0", VA = "0x18576B8A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x0002E488 File Offset: 0x0002C688
		[Token(Token = "0x17000AAA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywyx
		{
			[Token(Token = "0x600225E")]
			[Address(RVA = "0x576B960", Offset = "0x576A560", VA = "0x18576B960")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x0002E4A0 File Offset: 0x0002C6A0
		[Token(Token = "0x17000AAB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywyy
		{
			[Token(Token = "0x600225F")]
			[Address(RVA = "0x576B980", Offset = "0x576A580", VA = "0x18576B980")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x0002E4B8 File Offset: 0x0002C6B8
		[Token(Token = "0x17000AAC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywyz
		{
			[Token(Token = "0x6002260")]
			[Address(RVA = "0x576B9A0", Offset = "0x576A5A0", VA = "0x18576B9A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x0002E4D0 File Offset: 0x0002C6D0
		[Token(Token = "0x17000AAD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywyw
		{
			[Token(Token = "0x6002261")]
			[Address(RVA = "0x576B940", Offset = "0x576A540", VA = "0x18576B940")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AAE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywzx
		{
			[Token(Token = "0x6002262")]
			[Address(RVA = "0x576BA00", Offset = "0x576A600", VA = "0x18576BA00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x6002263")]
			[Address(RVA = "0x576D970", Offset = "0x576C570", VA = "0x18576D970")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x0002E500 File Offset: 0x0002C700
		[Token(Token = "0x17000AAF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywzy
		{
			[Token(Token = "0x6002264")]
			[Address(RVA = "0x576BA20", Offset = "0x576A620", VA = "0x18576BA20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x0002E518 File Offset: 0x0002C718
		[Token(Token = "0x17000AB0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywzz
		{
			[Token(Token = "0x6002265")]
			[Address(RVA = "0x576BA40", Offset = "0x576A640", VA = "0x18576BA40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x0002E530 File Offset: 0x0002C730
		[Token(Token = "0x17000AB1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywzw
		{
			[Token(Token = "0x6002266")]
			[Address(RVA = "0x576B9E0", Offset = "0x576A5E0", VA = "0x18576B9E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x0002E548 File Offset: 0x0002C748
		[Token(Token = "0x17000AB2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywwx
		{
			[Token(Token = "0x6002267")]
			[Address(RVA = "0x576B820", Offset = "0x576A420", VA = "0x18576B820")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x0002E560 File Offset: 0x0002C760
		[Token(Token = "0x17000AB3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywwy
		{
			[Token(Token = "0x6002268")]
			[Address(RVA = "0x576B840", Offset = "0x576A440", VA = "0x18576B840")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x0002E578 File Offset: 0x0002C778
		[Token(Token = "0x17000AB4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywwz
		{
			[Token(Token = "0x6002269")]
			[Address(RVA = "0x576B860", Offset = "0x576A460", VA = "0x18576B860")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x0002E590 File Offset: 0x0002C790
		[Token(Token = "0x17000AB5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 ywww
		{
			[Token(Token = "0x600226A")]
			[Address(RVA = "0x576B800", Offset = "0x576A400", VA = "0x18576B800")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x0002E5A8 File Offset: 0x0002C7A8
		[Token(Token = "0x17000AB6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxxx
		{
			[Token(Token = "0x600226B")]
			[Address(RVA = "0x576C5B0", Offset = "0x576B1B0", VA = "0x18576C5B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x0002E5C0 File Offset: 0x0002C7C0
		[Token(Token = "0x17000AB7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxxy
		{
			[Token(Token = "0x600226C")]
			[Address(RVA = "0x576C5D0", Offset = "0x576B1D0", VA = "0x18576C5D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x0002E5D8 File Offset: 0x0002C7D8
		[Token(Token = "0x17000AB8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxxz
		{
			[Token(Token = "0x600226D")]
			[Address(RVA = "0x576C5F0", Offset = "0x576B1F0", VA = "0x18576C5F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x0002E5F0 File Offset: 0x0002C7F0
		[Token(Token = "0x17000AB9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxxw
		{
			[Token(Token = "0x600226E")]
			[Address(RVA = "0x576C590", Offset = "0x576B190", VA = "0x18576C590")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x0002E608 File Offset: 0x0002C808
		[Token(Token = "0x17000ABA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxyx
		{
			[Token(Token = "0x600226F")]
			[Address(RVA = "0x576C650", Offset = "0x576B250", VA = "0x18576C650")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x0002E620 File Offset: 0x0002C820
		[Token(Token = "0x17000ABB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxyy
		{
			[Token(Token = "0x6002270")]
			[Address(RVA = "0x576C670", Offset = "0x576B270", VA = "0x18576C670")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x0002E638 File Offset: 0x0002C838
		[Token(Token = "0x17000ABC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxyz
		{
			[Token(Token = "0x6002271")]
			[Address(RVA = "0x576C690", Offset = "0x576B290", VA = "0x18576C690")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x0002E650 File Offset: 0x0002C850
		// (set) Token: 0x06002273 RID: 8819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ABD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxyw
		{
			[Token(Token = "0x6002272")]
			[Address(RVA = "0x576C630", Offset = "0x576B230", VA = "0x18576C630")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x6002273")]
			[Address(RVA = "0x576DBB0", Offset = "0x576C7B0", VA = "0x18576DBB0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x0002E668 File Offset: 0x0002C868
		[Token(Token = "0x17000ABE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxzx
		{
			[Token(Token = "0x6002274")]
			[Address(RVA = "0x576C6F0", Offset = "0x576B2F0", VA = "0x18576C6F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x0002E680 File Offset: 0x0002C880
		[Token(Token = "0x17000ABF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxzy
		{
			[Token(Token = "0x6002275")]
			[Address(RVA = "0x576C710", Offset = "0x576B310", VA = "0x18576C710")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x0002E698 File Offset: 0x0002C898
		[Token(Token = "0x17000AC0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxzz
		{
			[Token(Token = "0x6002276")]
			[Address(RVA = "0x576C730", Offset = "0x576B330", VA = "0x18576C730")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x0002E6B0 File Offset: 0x0002C8B0
		[Token(Token = "0x17000AC1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxzw
		{
			[Token(Token = "0x6002277")]
			[Address(RVA = "0x576C6D0", Offset = "0x576B2D0", VA = "0x18576C6D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x0002E6C8 File Offset: 0x0002C8C8
		[Token(Token = "0x17000AC2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxwx
		{
			[Token(Token = "0x6002278")]
			[Address(RVA = "0x576C510", Offset = "0x576B110", VA = "0x18576C510")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxwy
		{
			[Token(Token = "0x6002279")]
			[Address(RVA = "0x576C530", Offset = "0x576B130", VA = "0x18576C530")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x600227A")]
			[Address(RVA = "0x576DB70", Offset = "0x576C770", VA = "0x18576DB70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x0002E6F8 File Offset: 0x0002C8F8
		[Token(Token = "0x17000AC4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxwz
		{
			[Token(Token = "0x600227B")]
			[Address(RVA = "0x576C550", Offset = "0x576B150", VA = "0x18576C550")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x0002E710 File Offset: 0x0002C910
		[Token(Token = "0x17000AC5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxww
		{
			[Token(Token = "0x600227C")]
			[Address(RVA = "0x576C4F0", Offset = "0x576B0F0", VA = "0x18576C4F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x0002E728 File Offset: 0x0002C928
		[Token(Token = "0x17000AC6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyxx
		{
			[Token(Token = "0x600227D")]
			[Address(RVA = "0x576C850", Offset = "0x576B450", VA = "0x18576C850")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x0002E740 File Offset: 0x0002C940
		[Token(Token = "0x17000AC7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyxy
		{
			[Token(Token = "0x600227E")]
			[Address(RVA = "0x576C870", Offset = "0x576B470", VA = "0x18576C870")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x0002E758 File Offset: 0x0002C958
		[Token(Token = "0x17000AC8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyxz
		{
			[Token(Token = "0x600227F")]
			[Address(RVA = "0x576C890", Offset = "0x576B490", VA = "0x18576C890")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x0002E770 File Offset: 0x0002C970
		// (set) Token: 0x06002281 RID: 8833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyxw
		{
			[Token(Token = "0x6002280")]
			[Address(RVA = "0x576C830", Offset = "0x576B430", VA = "0x18576C830")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x6002281")]
			[Address(RVA = "0x576DC40", Offset = "0x576C840", VA = "0x18576DC40")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x0002E788 File Offset: 0x0002C988
		[Token(Token = "0x17000ACA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyyx
		{
			[Token(Token = "0x6002282")]
			[Address(RVA = "0x576C8F0", Offset = "0x576B4F0", VA = "0x18576C8F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x0002E7A0 File Offset: 0x0002C9A0
		[Token(Token = "0x17000ACB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyyy
		{
			[Token(Token = "0x6002283")]
			[Address(RVA = "0x576C910", Offset = "0x576B510", VA = "0x18576C910")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x0002E7B8 File Offset: 0x0002C9B8
		[Token(Token = "0x17000ACC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyyz
		{
			[Token(Token = "0x6002284")]
			[Address(RVA = "0x576C930", Offset = "0x576B530", VA = "0x18576C930")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x0002E7D0 File Offset: 0x0002C9D0
		[Token(Token = "0x17000ACD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyyw
		{
			[Token(Token = "0x6002285")]
			[Address(RVA = "0x576C8D0", Offset = "0x576B4D0", VA = "0x18576C8D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x0002E7E8 File Offset: 0x0002C9E8
		[Token(Token = "0x17000ACE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyzx
		{
			[Token(Token = "0x6002286")]
			[Address(RVA = "0x576C990", Offset = "0x576B590", VA = "0x18576C990")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x0002E800 File Offset: 0x0002CA00
		[Token(Token = "0x17000ACF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyzy
		{
			[Token(Token = "0x6002287")]
			[Address(RVA = "0x576C9B0", Offset = "0x576B5B0", VA = "0x18576C9B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x0002E818 File Offset: 0x0002CA18
		[Token(Token = "0x17000AD0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyzz
		{
			[Token(Token = "0x6002288")]
			[Address(RVA = "0x576C9D0", Offset = "0x576B5D0", VA = "0x18576C9D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x0002E830 File Offset: 0x0002CA30
		[Token(Token = "0x17000AD1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyzw
		{
			[Token(Token = "0x6002289")]
			[Address(RVA = "0x576C970", Offset = "0x576B570", VA = "0x18576C970")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x0002E848 File Offset: 0x0002CA48
		// (set) Token: 0x0600228B RID: 8843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zywx
		{
			[Token(Token = "0x600228A")]
			[Address(RVA = "0x576C7B0", Offset = "0x576B3B0", VA = "0x18576C7B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x600228B")]
			[Address(RVA = "0x576DC00", Offset = "0x576C800", VA = "0x18576DC00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x0002E860 File Offset: 0x0002CA60
		[Token(Token = "0x17000AD3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zywy
		{
			[Token(Token = "0x600228C")]
			[Address(RVA = "0x576C7D0", Offset = "0x576B3D0", VA = "0x18576C7D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x0002E878 File Offset: 0x0002CA78
		[Token(Token = "0x17000AD4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zywz
		{
			[Token(Token = "0x600228D")]
			[Address(RVA = "0x576C7F0", Offset = "0x576B3F0", VA = "0x18576C7F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x0002E890 File Offset: 0x0002CA90
		[Token(Token = "0x17000AD5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyww
		{
			[Token(Token = "0x600228E")]
			[Address(RVA = "0x576C790", Offset = "0x576B390", VA = "0x18576C790")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x0002E8A8 File Offset: 0x0002CAA8
		[Token(Token = "0x17000AD6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzxx
		{
			[Token(Token = "0x600228F")]
			[Address(RVA = "0x576CAF0", Offset = "0x576B6F0", VA = "0x18576CAF0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x0002E8C0 File Offset: 0x0002CAC0
		[Token(Token = "0x17000AD7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzxy
		{
			[Token(Token = "0x6002290")]
			[Address(RVA = "0x576CB10", Offset = "0x576B710", VA = "0x18576CB10")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002291 RID: 8849 RVA: 0x0002E8D8 File Offset: 0x0002CAD8
		[Token(Token = "0x17000AD8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzxz
		{
			[Token(Token = "0x6002291")]
			[Address(RVA = "0x576CB30", Offset = "0x576B730", VA = "0x18576CB30")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x0002E8F0 File Offset: 0x0002CAF0
		[Token(Token = "0x17000AD9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzxw
		{
			[Token(Token = "0x6002292")]
			[Address(RVA = "0x576CAD0", Offset = "0x576B6D0", VA = "0x18576CAD0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x0002E908 File Offset: 0x0002CB08
		[Token(Token = "0x17000ADA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzyx
		{
			[Token(Token = "0x6002293")]
			[Address(RVA = "0x576CB90", Offset = "0x576B790", VA = "0x18576CB90")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x0002E920 File Offset: 0x0002CB20
		[Token(Token = "0x17000ADB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzyy
		{
			[Token(Token = "0x6002294")]
			[Address(RVA = "0x576CBB0", Offset = "0x576B7B0", VA = "0x18576CBB0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x0002E938 File Offset: 0x0002CB38
		[Token(Token = "0x17000ADC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzyz
		{
			[Token(Token = "0x6002295")]
			[Address(RVA = "0x576CBD0", Offset = "0x576B7D0", VA = "0x18576CBD0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x0002E950 File Offset: 0x0002CB50
		[Token(Token = "0x17000ADD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzyw
		{
			[Token(Token = "0x6002296")]
			[Address(RVA = "0x576CB70", Offset = "0x576B770", VA = "0x18576CB70")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x0002E968 File Offset: 0x0002CB68
		[Token(Token = "0x17000ADE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzzx
		{
			[Token(Token = "0x6002297")]
			[Address(RVA = "0x576CC20", Offset = "0x576B820", VA = "0x18576CC20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x0002E980 File Offset: 0x0002CB80
		[Token(Token = "0x17000ADF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzzy
		{
			[Token(Token = "0x6002298")]
			[Address(RVA = "0x576CC40", Offset = "0x576B840", VA = "0x18576CC40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x0002E998 File Offset: 0x0002CB98
		[Token(Token = "0x17000AE0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzzz
		{
			[Token(Token = "0x6002299")]
			[Address(RVA = "0x576CC60", Offset = "0x576B860", VA = "0x18576CC60")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x0002E9B0 File Offset: 0x0002CBB0
		[Token(Token = "0x17000AE1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzzw
		{
			[Token(Token = "0x600229A")]
			[Address(RVA = "0x576CC00", Offset = "0x576B800", VA = "0x18576CC00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x0002E9C8 File Offset: 0x0002CBC8
		[Token(Token = "0x17000AE2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzwx
		{
			[Token(Token = "0x600229B")]
			[Address(RVA = "0x576CA50", Offset = "0x576B650", VA = "0x18576CA50")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
		[Token(Token = "0x17000AE3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzwy
		{
			[Token(Token = "0x600229C")]
			[Address(RVA = "0x576CA70", Offset = "0x576B670", VA = "0x18576CA70")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x0002E9F8 File Offset: 0x0002CBF8
		[Token(Token = "0x17000AE4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzwz
		{
			[Token(Token = "0x600229D")]
			[Address(RVA = "0x576CA90", Offset = "0x576B690", VA = "0x18576CA90")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x0002EA10 File Offset: 0x0002CC10
		[Token(Token = "0x17000AE5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzww
		{
			[Token(Token = "0x600229E")]
			[Address(RVA = "0x576CA30", Offset = "0x576B630", VA = "0x18576CA30")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x0002EA28 File Offset: 0x0002CC28
		[Token(Token = "0x17000AE6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwxx
		{
			[Token(Token = "0x600229F")]
			[Address(RVA = "0x576C310", Offset = "0x576AF10", VA = "0x18576C310")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x0002EA40 File Offset: 0x0002CC40
		// (set) Token: 0x060022A1 RID: 8865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwxy
		{
			[Token(Token = "0x60022A0")]
			[Address(RVA = "0x576C330", Offset = "0x576AF30", VA = "0x18576C330")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x60022A1")]
			[Address(RVA = "0x576DAE0", Offset = "0x576C6E0", VA = "0x18576DAE0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x0002EA58 File Offset: 0x0002CC58
		[Token(Token = "0x17000AE8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwxz
		{
			[Token(Token = "0x60022A2")]
			[Address(RVA = "0x576C350", Offset = "0x576AF50", VA = "0x18576C350")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x0002EA70 File Offset: 0x0002CC70
		[Token(Token = "0x17000AE9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwxw
		{
			[Token(Token = "0x60022A3")]
			[Address(RVA = "0x576C2F0", Offset = "0x576AEF0", VA = "0x18576C2F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x0002EA88 File Offset: 0x0002CC88
		// (set) Token: 0x060022A5 RID: 8869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwyx
		{
			[Token(Token = "0x60022A4")]
			[Address(RVA = "0x576C3B0", Offset = "0x576AFB0", VA = "0x18576C3B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x60022A5")]
			[Address(RVA = "0x576DB20", Offset = "0x576C720", VA = "0x18576DB20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x0002EAA0 File Offset: 0x0002CCA0
		[Token(Token = "0x17000AEB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwyy
		{
			[Token(Token = "0x60022A6")]
			[Address(RVA = "0x576C3D0", Offset = "0x576AFD0", VA = "0x18576C3D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x0002EAB8 File Offset: 0x0002CCB8
		[Token(Token = "0x17000AEC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwyz
		{
			[Token(Token = "0x60022A7")]
			[Address(RVA = "0x576C3F0", Offset = "0x576AFF0", VA = "0x18576C3F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x0002EAD0 File Offset: 0x0002CCD0
		[Token(Token = "0x17000AED")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwyw
		{
			[Token(Token = "0x60022A8")]
			[Address(RVA = "0x576C390", Offset = "0x576AF90", VA = "0x18576C390")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x0002EAE8 File Offset: 0x0002CCE8
		[Token(Token = "0x17000AEE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwzx
		{
			[Token(Token = "0x60022A9")]
			[Address(RVA = "0x576C450", Offset = "0x576B050", VA = "0x18576C450")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x0002EB00 File Offset: 0x0002CD00
		[Token(Token = "0x17000AEF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwzy
		{
			[Token(Token = "0x60022AA")]
			[Address(RVA = "0x576C470", Offset = "0x576B070", VA = "0x18576C470")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x0002EB18 File Offset: 0x0002CD18
		[Token(Token = "0x17000AF0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwzz
		{
			[Token(Token = "0x60022AB")]
			[Address(RVA = "0x576C490", Offset = "0x576B090", VA = "0x18576C490")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x0002EB30 File Offset: 0x0002CD30
		[Token(Token = "0x17000AF1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwzw
		{
			[Token(Token = "0x60022AC")]
			[Address(RVA = "0x576C430", Offset = "0x576B030", VA = "0x18576C430")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x0002EB48 File Offset: 0x0002CD48
		[Token(Token = "0x17000AF2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwwx
		{
			[Token(Token = "0x60022AD")]
			[Address(RVA = "0x576C270", Offset = "0x576AE70", VA = "0x18576C270")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x0002EB60 File Offset: 0x0002CD60
		[Token(Token = "0x17000AF3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwwy
		{
			[Token(Token = "0x60022AE")]
			[Address(RVA = "0x576C290", Offset = "0x576AE90", VA = "0x18576C290")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x0002EB78 File Offset: 0x0002CD78
		[Token(Token = "0x17000AF4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwwz
		{
			[Token(Token = "0x60022AF")]
			[Address(RVA = "0x576C2B0", Offset = "0x576AEB0", VA = "0x18576C2B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x0002EB90 File Offset: 0x0002CD90
		[Token(Token = "0x17000AF5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zwww
		{
			[Token(Token = "0x60022B0")]
			[Address(RVA = "0x576C250", Offset = "0x576AE50", VA = "0x18576C250")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x0002EBA8 File Offset: 0x0002CDA8
		[Token(Token = "0x17000AF6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxxx
		{
			[Token(Token = "0x60022B1")]
			[Address(RVA = "0x576A680", Offset = "0x5769280", VA = "0x18576A680")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x0002EBC0 File Offset: 0x0002CDC0
		[Token(Token = "0x17000AF7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxxy
		{
			[Token(Token = "0x60022B2")]
			[Address(RVA = "0x576A6A0", Offset = "0x57692A0", VA = "0x18576A6A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x0002EBD8 File Offset: 0x0002CDD8
		[Token(Token = "0x17000AF8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxxz
		{
			[Token(Token = "0x60022B3")]
			[Address(RVA = "0x576A6C0", Offset = "0x57692C0", VA = "0x18576A6C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x0002EBF0 File Offset: 0x0002CDF0
		[Token(Token = "0x17000AF9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxxw
		{
			[Token(Token = "0x60022B4")]
			[Address(RVA = "0x576A660", Offset = "0x5769260", VA = "0x18576A660")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x0002EC08 File Offset: 0x0002CE08
		[Token(Token = "0x17000AFA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxyx
		{
			[Token(Token = "0x60022B5")]
			[Address(RVA = "0x576A720", Offset = "0x5769320", VA = "0x18576A720")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x0002EC20 File Offset: 0x0002CE20
		[Token(Token = "0x17000AFB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxyy
		{
			[Token(Token = "0x60022B6")]
			[Address(RVA = "0x576A740", Offset = "0x5769340", VA = "0x18576A740")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x0002EC38 File Offset: 0x0002CE38
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxyz
		{
			[Token(Token = "0x60022B7")]
			[Address(RVA = "0x576A760", Offset = "0x5769360", VA = "0x18576A760")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x60022B8")]
			[Address(RVA = "0x576D610", Offset = "0x576C210", VA = "0x18576D610")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x0002EC50 File Offset: 0x0002CE50
		[Token(Token = "0x17000AFD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxyw
		{
			[Token(Token = "0x60022B9")]
			[Address(RVA = "0x576A700", Offset = "0x5769300", VA = "0x18576A700")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x0002EC68 File Offset: 0x0002CE68
		[Token(Token = "0x17000AFE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxzx
		{
			[Token(Token = "0x60022BA")]
			[Address(RVA = "0x576A7C0", Offset = "0x57693C0", VA = "0x18576A7C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x0002EC80 File Offset: 0x0002CE80
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxzy
		{
			[Token(Token = "0x60022BB")]
			[Address(RVA = "0x576A7E0", Offset = "0x57693E0", VA = "0x18576A7E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x60022BC")]
			[Address(RVA = "0x576D650", Offset = "0x576C250", VA = "0x18576D650")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x0002EC98 File Offset: 0x0002CE98
		[Token(Token = "0x17000B00")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxzz
		{
			[Token(Token = "0x60022BD")]
			[Address(RVA = "0x576A800", Offset = "0x5769400", VA = "0x18576A800")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x0002ECB0 File Offset: 0x0002CEB0
		[Token(Token = "0x17000B01")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxzw
		{
			[Token(Token = "0x60022BE")]
			[Address(RVA = "0x576A7A0", Offset = "0x57693A0", VA = "0x18576A7A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x0002ECC8 File Offset: 0x0002CEC8
		[Token(Token = "0x17000B02")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxwx
		{
			[Token(Token = "0x60022BF")]
			[Address(RVA = "0x576A5E0", Offset = "0x57691E0", VA = "0x18576A5E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x0002ECE0 File Offset: 0x0002CEE0
		[Token(Token = "0x17000B03")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxwy
		{
			[Token(Token = "0x60022C0")]
			[Address(RVA = "0x576A600", Offset = "0x5769200", VA = "0x18576A600")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x0002ECF8 File Offset: 0x0002CEF8
		[Token(Token = "0x17000B04")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxwz
		{
			[Token(Token = "0x60022C1")]
			[Address(RVA = "0x576A620", Offset = "0x5769220", VA = "0x18576A620")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x0002ED10 File Offset: 0x0002CF10
		[Token(Token = "0x17000B05")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wxww
		{
			[Token(Token = "0x60022C2")]
			[Address(RVA = "0x576A5C0", Offset = "0x57691C0", VA = "0x18576A5C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x0002ED28 File Offset: 0x0002CF28
		[Token(Token = "0x17000B06")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyxx
		{
			[Token(Token = "0x60022C3")]
			[Address(RVA = "0x576A920", Offset = "0x5769520", VA = "0x18576A920")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x0002ED40 File Offset: 0x0002CF40
		[Token(Token = "0x17000B07")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyxy
		{
			[Token(Token = "0x60022C4")]
			[Address(RVA = "0x576A940", Offset = "0x5769540", VA = "0x18576A940")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x0002ED58 File Offset: 0x0002CF58
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B08")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyxz
		{
			[Token(Token = "0x60022C5")]
			[Address(RVA = "0x576A960", Offset = "0x5769560", VA = "0x18576A960")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x60022C6")]
			[Address(RVA = "0x576D6A0", Offset = "0x576C2A0", VA = "0x18576D6A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x0002ED70 File Offset: 0x0002CF70
		[Token(Token = "0x17000B09")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyxw
		{
			[Token(Token = "0x60022C7")]
			[Address(RVA = "0x576A900", Offset = "0x5769500", VA = "0x18576A900")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x0002ED88 File Offset: 0x0002CF88
		[Token(Token = "0x17000B0A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyyx
		{
			[Token(Token = "0x60022C8")]
			[Address(RVA = "0x576A9C0", Offset = "0x57695C0", VA = "0x18576A9C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x0002EDA0 File Offset: 0x0002CFA0
		[Token(Token = "0x17000B0B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyyy
		{
			[Token(Token = "0x60022C9")]
			[Address(RVA = "0x576A9E0", Offset = "0x57695E0", VA = "0x18576A9E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		[Token(Token = "0x17000B0C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyyz
		{
			[Token(Token = "0x60022CA")]
			[Address(RVA = "0x576AA00", Offset = "0x5769600", VA = "0x18576AA00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x0002EDD0 File Offset: 0x0002CFD0
		[Token(Token = "0x17000B0D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyyw
		{
			[Token(Token = "0x60022CB")]
			[Address(RVA = "0x576A9A0", Offset = "0x57695A0", VA = "0x18576A9A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x0002EDE8 File Offset: 0x0002CFE8
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B0E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyzx
		{
			[Token(Token = "0x60022CC")]
			[Address(RVA = "0x576AA60", Offset = "0x5769660", VA = "0x18576AA60")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x60022CD")]
			[Address(RVA = "0x576D6E0", Offset = "0x576C2E0", VA = "0x18576D6E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x0002EE00 File Offset: 0x0002D000
		[Token(Token = "0x17000B0F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyzy
		{
			[Token(Token = "0x60022CE")]
			[Address(RVA = "0x576AA80", Offset = "0x5769680", VA = "0x18576AA80")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x0002EE18 File Offset: 0x0002D018
		[Token(Token = "0x17000B10")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyzz
		{
			[Token(Token = "0x60022CF")]
			[Address(RVA = "0x576AAA0", Offset = "0x57696A0", VA = "0x18576AAA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x0002EE30 File Offset: 0x0002D030
		[Token(Token = "0x17000B11")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyzw
		{
			[Token(Token = "0x60022D0")]
			[Address(RVA = "0x576AA40", Offset = "0x5769640", VA = "0x18576AA40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x0002EE48 File Offset: 0x0002D048
		[Token(Token = "0x17000B12")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wywx
		{
			[Token(Token = "0x60022D1")]
			[Address(RVA = "0x576A880", Offset = "0x5769480", VA = "0x18576A880")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x0002EE60 File Offset: 0x0002D060
		[Token(Token = "0x17000B13")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wywy
		{
			[Token(Token = "0x60022D2")]
			[Address(RVA = "0x576A8A0", Offset = "0x57694A0", VA = "0x18576A8A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x0002EE78 File Offset: 0x0002D078
		[Token(Token = "0x17000B14")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wywz
		{
			[Token(Token = "0x60022D3")]
			[Address(RVA = "0x576A8C0", Offset = "0x57694C0", VA = "0x18576A8C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x0002EE90 File Offset: 0x0002D090
		[Token(Token = "0x17000B15")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wyww
		{
			[Token(Token = "0x60022D4")]
			[Address(RVA = "0x576A860", Offset = "0x5769460", VA = "0x18576A860")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x0002EEA8 File Offset: 0x0002D0A8
		[Token(Token = "0x17000B16")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzxx
		{
			[Token(Token = "0x60022D5")]
			[Address(RVA = "0x576ABC0", Offset = "0x57697C0", VA = "0x18576ABC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x0002EEC0 File Offset: 0x0002D0C0
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B17")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzxy
		{
			[Token(Token = "0x60022D6")]
			[Address(RVA = "0x576ABE0", Offset = "0x57697E0", VA = "0x18576ABE0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x60022D7")]
			[Address(RVA = "0x576D730", Offset = "0x576C330", VA = "0x18576D730")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x0002EED8 File Offset: 0x0002D0D8
		[Token(Token = "0x17000B18")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzxz
		{
			[Token(Token = "0x60022D8")]
			[Address(RVA = "0x576AC00", Offset = "0x5769800", VA = "0x18576AC00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x0002EEF0 File Offset: 0x0002D0F0
		[Token(Token = "0x17000B19")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzxw
		{
			[Token(Token = "0x60022D9")]
			[Address(RVA = "0x576ABA0", Offset = "0x57697A0", VA = "0x18576ABA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x0002EF08 File Offset: 0x0002D108
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzyx
		{
			[Token(Token = "0x60022DA")]
			[Address(RVA = "0x576AC60", Offset = "0x5769860", VA = "0x18576AC60")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
			[Token(Token = "0x60022DB")]
			[Address(RVA = "0x576D770", Offset = "0x576C370", VA = "0x18576D770")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x0002EF20 File Offset: 0x0002D120
		[Token(Token = "0x17000B1B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzyy
		{
			[Token(Token = "0x60022DC")]
			[Address(RVA = "0x576AC80", Offset = "0x5769880", VA = "0x18576AC80")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x0002EF38 File Offset: 0x0002D138
		[Token(Token = "0x17000B1C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzyz
		{
			[Token(Token = "0x60022DD")]
			[Address(RVA = "0x576ACA0", Offset = "0x57698A0", VA = "0x18576ACA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x0002EF50 File Offset: 0x0002D150
		[Token(Token = "0x17000B1D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzyw
		{
			[Token(Token = "0x60022DE")]
			[Address(RVA = "0x576AC40", Offset = "0x5769840", VA = "0x18576AC40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x0002EF68 File Offset: 0x0002D168
		[Token(Token = "0x17000B1E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzzx
		{
			[Token(Token = "0x60022DF")]
			[Address(RVA = "0x576AD00", Offset = "0x5769900", VA = "0x18576AD00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x0002EF80 File Offset: 0x0002D180
		[Token(Token = "0x17000B1F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzzy
		{
			[Token(Token = "0x60022E0")]
			[Address(RVA = "0x576AD20", Offset = "0x5769920", VA = "0x18576AD20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x0002EF98 File Offset: 0x0002D198
		[Token(Token = "0x17000B20")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzzz
		{
			[Token(Token = "0x60022E1")]
			[Address(RVA = "0x576AD40", Offset = "0x5769940", VA = "0x18576AD40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x0002EFB0 File Offset: 0x0002D1B0
		[Token(Token = "0x17000B21")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzzw
		{
			[Token(Token = "0x60022E2")]
			[Address(RVA = "0x576ACE0", Offset = "0x57698E0", VA = "0x18576ACE0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x0002EFC8 File Offset: 0x0002D1C8
		[Token(Token = "0x17000B22")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzwx
		{
			[Token(Token = "0x60022E3")]
			[Address(RVA = "0x576AB20", Offset = "0x5769720", VA = "0x18576AB20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x0002EFE0 File Offset: 0x0002D1E0
		[Token(Token = "0x17000B23")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzwy
		{
			[Token(Token = "0x60022E4")]
			[Address(RVA = "0x576AB40", Offset = "0x5769740", VA = "0x18576AB40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x0002EFF8 File Offset: 0x0002D1F8
		[Token(Token = "0x17000B24")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzwz
		{
			[Token(Token = "0x60022E5")]
			[Address(RVA = "0x576AB60", Offset = "0x5769760", VA = "0x18576AB60")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x0002F010 File Offset: 0x0002D210
		[Token(Token = "0x17000B25")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wzww
		{
			[Token(Token = "0x60022E6")]
			[Address(RVA = "0x576AB00", Offset = "0x5769700", VA = "0x18576AB00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x0002F028 File Offset: 0x0002D228
		[Token(Token = "0x17000B26")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwxx
		{
			[Token(Token = "0x60022E7")]
			[Address(RVA = "0x576A3E0", Offset = "0x5768FE0", VA = "0x18576A3E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x0002F040 File Offset: 0x0002D240
		[Token(Token = "0x17000B27")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwxy
		{
			[Token(Token = "0x60022E8")]
			[Address(RVA = "0x576A400", Offset = "0x5769000", VA = "0x18576A400")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x0002F058 File Offset: 0x0002D258
		[Token(Token = "0x17000B28")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwxz
		{
			[Token(Token = "0x60022E9")]
			[Address(RVA = "0x576A420", Offset = "0x5769020", VA = "0x18576A420")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x0002F070 File Offset: 0x0002D270
		[Token(Token = "0x17000B29")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwxw
		{
			[Token(Token = "0x60022EA")]
			[Address(RVA = "0x576A3C0", Offset = "0x5768FC0", VA = "0x18576A3C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x0002F088 File Offset: 0x0002D288
		[Token(Token = "0x17000B2A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwyx
		{
			[Token(Token = "0x60022EB")]
			[Address(RVA = "0x576A480", Offset = "0x5769080", VA = "0x18576A480")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x0002F0A0 File Offset: 0x0002D2A0
		[Token(Token = "0x17000B2B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwyy
		{
			[Token(Token = "0x60022EC")]
			[Address(RVA = "0x576A4A0", Offset = "0x57690A0", VA = "0x18576A4A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x0002F0B8 File Offset: 0x0002D2B8
		[Token(Token = "0x17000B2C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwyz
		{
			[Token(Token = "0x60022ED")]
			[Address(RVA = "0x576A4C0", Offset = "0x57690C0", VA = "0x18576A4C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x0002F0D0 File Offset: 0x0002D2D0
		[Token(Token = "0x17000B2D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwyw
		{
			[Token(Token = "0x60022EE")]
			[Address(RVA = "0x576A460", Offset = "0x5769060", VA = "0x18576A460")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x0002F0E8 File Offset: 0x0002D2E8
		[Token(Token = "0x17000B2E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwzx
		{
			[Token(Token = "0x60022EF")]
			[Address(RVA = "0x576A520", Offset = "0x5769120", VA = "0x18576A520")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x0002F100 File Offset: 0x0002D300
		[Token(Token = "0x17000B2F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwzy
		{
			[Token(Token = "0x60022F0")]
			[Address(RVA = "0x576A540", Offset = "0x5769140", VA = "0x18576A540")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x0002F118 File Offset: 0x0002D318
		[Token(Token = "0x17000B30")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwzz
		{
			[Token(Token = "0x60022F1")]
			[Address(RVA = "0x576A560", Offset = "0x5769160", VA = "0x18576A560")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x0002F130 File Offset: 0x0002D330
		[Token(Token = "0x17000B31")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwzw
		{
			[Token(Token = "0x60022F2")]
			[Address(RVA = "0x576A500", Offset = "0x5769100", VA = "0x18576A500")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x0002F148 File Offset: 0x0002D348
		[Token(Token = "0x17000B32")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwwx
		{
			[Token(Token = "0x60022F3")]
			[Address(RVA = "0x576A340", Offset = "0x5768F40", VA = "0x18576A340")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x0002F160 File Offset: 0x0002D360
		[Token(Token = "0x17000B33")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwwy
		{
			[Token(Token = "0x60022F4")]
			[Address(RVA = "0x576A360", Offset = "0x5768F60", VA = "0x18576A360")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0002F178 File Offset: 0x0002D378
		[Token(Token = "0x17000B34")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwwz
		{
			[Token(Token = "0x60022F5")]
			[Address(RVA = "0x576A380", Offset = "0x5768F80", VA = "0x18576A380")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x0002F190 File Offset: 0x0002D390
		[Token(Token = "0x17000B35")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 wwww
		{
			[Token(Token = "0x60022F6")]
			[Address(RVA = "0x576A320", Offset = "0x5768F20", VA = "0x18576A320")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x0002F1A8 File Offset: 0x0002D3A8
		[Token(Token = "0x17000B36")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxx
		{
			[Token(Token = "0x60022F7")]
			[Address(RVA = "0x576B0B0", Offset = "0x5769CB0", VA = "0x18576B0B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x0002F1C0 File Offset: 0x0002D3C0
		[Token(Token = "0x17000B37")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxy
		{
			[Token(Token = "0x60022F8")]
			[Address(RVA = "0x576B140", Offset = "0x5769D40", VA = "0x18576B140")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x0002F1D8 File Offset: 0x0002D3D8
		[Token(Token = "0x17000B38")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxz
		{
			[Token(Token = "0x60022F9")]
			[Address(RVA = "0x576B1E0", Offset = "0x5769DE0", VA = "0x18576B1E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		[Token(Token = "0x17000B39")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxw
		{
			[Token(Token = "0x60022FA")]
			[Address(RVA = "0x576B010", Offset = "0x5769C10", VA = "0x18576B010")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x0002F208 File Offset: 0x0002D408
		[Token(Token = "0x17000B3A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyx
		{
			[Token(Token = "0x60022FB")]
			[Address(RVA = "0x576B340", Offset = "0x5769F40", VA = "0x18576B340")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x0002F220 File Offset: 0x0002D420
		[Token(Token = "0x17000B3B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyy
		{
			[Token(Token = "0x60022FC")]
			[Address(RVA = "0x576B3E0", Offset = "0x5769FE0", VA = "0x18576B3E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x0002F238 File Offset: 0x0002D438
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyz
		{
			[Token(Token = "0x60022FD")]
			[Address(RVA = "0x576B480", Offset = "0x576A080", VA = "0x18576B480")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x60022FE")]
			[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x0002F250 File Offset: 0x0002D450
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyw
		{
			[Token(Token = "0x60022FF")]
			[Address(RVA = "0x576B2A0", Offset = "0x5769EA0", VA = "0x18576B2A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002300")]
			[Address(RVA = "0x576D830", Offset = "0x576C430", VA = "0x18576D830")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x0002F268 File Offset: 0x0002D468
		[Token(Token = "0x17000B3E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xzx
		{
			[Token(Token = "0x6002301")]
			[Address(RVA = "0x576B5E0", Offset = "0x576A1E0", VA = "0x18576B5E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x0002F280 File Offset: 0x0002D480
		// (set) Token: 0x06002303 RID: 8963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xzy
		{
			[Token(Token = "0x6002302")]
			[Address(RVA = "0x576B680", Offset = "0x576A280", VA = "0x18576B680")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002303")]
			[Address(RVA = "0x576D8C0", Offset = "0x576C4C0", VA = "0x18576D8C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x0002F298 File Offset: 0x0002D498
		[Token(Token = "0x17000B40")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xzz
		{
			[Token(Token = "0x6002304")]
			[Address(RVA = "0x576B720", Offset = "0x576A320", VA = "0x18576B720")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x0002F2B0 File Offset: 0x0002D4B0
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B41")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xzw
		{
			[Token(Token = "0x6002305")]
			[Address(RVA = "0x576B540", Offset = "0x576A140", VA = "0x18576B540")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002306")]
			[Address(RVA = "0x576D880", Offset = "0x576C480", VA = "0x18576D880")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x0002F2C8 File Offset: 0x0002D4C8
		[Token(Token = "0x17000B42")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xwx
		{
			[Token(Token = "0x6002307")]
			[Address(RVA = "0x576AE20", Offset = "0x5769A20", VA = "0x18576AE20")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x0002F2E0 File Offset: 0x0002D4E0
		// (set) Token: 0x06002309 RID: 8969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B43")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xwy
		{
			[Token(Token = "0x6002308")]
			[Address(RVA = "0x576AEC0", Offset = "0x5769AC0", VA = "0x18576AEC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002309")]
			[Address(RVA = "0x576D7A0", Offset = "0x576C3A0", VA = "0x18576D7A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x0002F2F8 File Offset: 0x0002D4F8
		// (set) Token: 0x0600230B RID: 8971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B44")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xwz
		{
			[Token(Token = "0x600230A")]
			[Address(RVA = "0x576AF60", Offset = "0x5769B60", VA = "0x18576AF60")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x600230B")]
			[Address(RVA = "0x576D7E0", Offset = "0x576C3E0", VA = "0x18576D7E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x0002F310 File Offset: 0x0002D510
		[Token(Token = "0x17000B45")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xww
		{
			[Token(Token = "0x600230C")]
			[Address(RVA = "0x576AD80", Offset = "0x5769980", VA = "0x18576AD80")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x0002F328 File Offset: 0x0002D528
		[Token(Token = "0x17000B46")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxx
		{
			[Token(Token = "0x600230D")]
			[Address(RVA = "0x576BB20", Offset = "0x576A720", VA = "0x18576BB20")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x0002F340 File Offset: 0x0002D540
		[Token(Token = "0x17000B47")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxy
		{
			[Token(Token = "0x600230E")]
			[Address(RVA = "0x576BBC0", Offset = "0x576A7C0", VA = "0x18576BBC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x0002F358 File Offset: 0x0002D558
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B48")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxz
		{
			[Token(Token = "0x600230F")]
			[Address(RVA = "0x576BC60", Offset = "0x576A860", VA = "0x18576BC60")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002310")]
			[Address(RVA = "0x576D9E0", Offset = "0x576C5E0", VA = "0x18576D9E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x0002F370 File Offset: 0x0002D570
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B49")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxw
		{
			[Token(Token = "0x6002311")]
			[Address(RVA = "0x576BA80", Offset = "0x576A680", VA = "0x18576BA80")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002312")]
			[Address(RVA = "0x576D9A0", Offset = "0x576C5A0", VA = "0x18576D9A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x0002F388 File Offset: 0x0002D588
		[Token(Token = "0x17000B4A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyx
		{
			[Token(Token = "0x6002313")]
			[Address(RVA = "0x576BDC0", Offset = "0x576A9C0", VA = "0x18576BDC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x0002F3A0 File Offset: 0x0002D5A0
		[Token(Token = "0x17000B4B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyy
		{
			[Token(Token = "0x6002314")]
			[Address(RVA = "0x576BE60", Offset = "0x576AA60", VA = "0x18576BE60")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x0002F3B8 File Offset: 0x0002D5B8
		[Token(Token = "0x17000B4C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyz
		{
			[Token(Token = "0x6002315")]
			[Address(RVA = "0x576BEF0", Offset = "0x576AAF0", VA = "0x18576BEF0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x0002F3D0 File Offset: 0x0002D5D0
		[Token(Token = "0x17000B4D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyw
		{
			[Token(Token = "0x6002316")]
			[Address(RVA = "0x576BD20", Offset = "0x576A920", VA = "0x18576BD20")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x0002F3E8 File Offset: 0x0002D5E8
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yzx
		{
			[Token(Token = "0x6002317")]
			[Address(RVA = "0x576C050", Offset = "0x576AC50", VA = "0x18576C050")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002318")]
			[Address(RVA = "0x576DA70", Offset = "0x576C670", VA = "0x18576DA70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x0002F400 File Offset: 0x0002D600
		[Token(Token = "0x17000B4F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yzy
		{
			[Token(Token = "0x6002319")]
			[Address(RVA = "0x576C0F0", Offset = "0x576ACF0", VA = "0x18576C0F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x0002F418 File Offset: 0x0002D618
		[Token(Token = "0x17000B50")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yzz
		{
			[Token(Token = "0x600231A")]
			[Address(RVA = "0x576C190", Offset = "0x576AD90", VA = "0x18576C190")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x0002F430 File Offset: 0x0002D630
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B51")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yzw
		{
			[Token(Token = "0x600231B")]
			[Address(RVA = "0x576BFB0", Offset = "0x576ABB0", VA = "0x18576BFB0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x600231C")]
			[Address(RVA = "0x576DA30", Offset = "0x576C630", VA = "0x18576DA30")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x0002F448 File Offset: 0x0002D648
		// (set) Token: 0x0600231E RID: 8990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B52")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 ywx
		{
			[Token(Token = "0x600231D")]
			[Address(RVA = "0x576B880", Offset = "0x576A480", VA = "0x18576B880")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x600231E")]
			[Address(RVA = "0x576D910", Offset = "0x576C510", VA = "0x18576D910")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x0002F460 File Offset: 0x0002D660
		[Token(Token = "0x17000B53")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 ywy
		{
			[Token(Token = "0x600231F")]
			[Address(RVA = "0x576B920", Offset = "0x576A520", VA = "0x18576B920")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x0002F478 File Offset: 0x0002D678
		// (set) Token: 0x06002321 RID: 8993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B54")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 ywz
		{
			[Token(Token = "0x6002320")]
			[Address(RVA = "0x576B9C0", Offset = "0x576A5C0", VA = "0x18576B9C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002321")]
			[Address(RVA = "0x576D950", Offset = "0x576C550", VA = "0x18576D950")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x0002F490 File Offset: 0x0002D690
		[Token(Token = "0x17000B55")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yww
		{
			[Token(Token = "0x6002322")]
			[Address(RVA = "0x576B7E0", Offset = "0x576A3E0", VA = "0x18576B7E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x0002F4A8 File Offset: 0x0002D6A8
		[Token(Token = "0x17000B56")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zxx
		{
			[Token(Token = "0x6002323")]
			[Address(RVA = "0x576C570", Offset = "0x576B170", VA = "0x18576C570")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x0002F4C0 File Offset: 0x0002D6C0
		// (set) Token: 0x06002325 RID: 8997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B57")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zxy
		{
			[Token(Token = "0x6002324")]
			[Address(RVA = "0x576C610", Offset = "0x576B210", VA = "0x18576C610")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002325")]
			[Address(RVA = "0x576DB90", Offset = "0x576C790", VA = "0x18576DB90")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x0002F4D8 File Offset: 0x0002D6D8
		[Token(Token = "0x17000B58")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zxz
		{
			[Token(Token = "0x6002326")]
			[Address(RVA = "0x576C6B0", Offset = "0x576B2B0", VA = "0x18576C6B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x0002F4F0 File Offset: 0x0002D6F0
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B59")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zxw
		{
			[Token(Token = "0x6002327")]
			[Address(RVA = "0x576C4D0", Offset = "0x576B0D0", VA = "0x18576C4D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002328")]
			[Address(RVA = "0x576DB50", Offset = "0x576C750", VA = "0x18576DB50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x0002F508 File Offset: 0x0002D708
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zyx
		{
			[Token(Token = "0x6002329")]
			[Address(RVA = "0x576C810", Offset = "0x576B410", VA = "0x18576C810")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x600232A")]
			[Address(RVA = "0x576DC20", Offset = "0x576C820", VA = "0x18576DC20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x0002F520 File Offset: 0x0002D720
		[Token(Token = "0x17000B5B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zyy
		{
			[Token(Token = "0x600232B")]
			[Address(RVA = "0x576C8B0", Offset = "0x576B4B0", VA = "0x18576C8B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x0002F538 File Offset: 0x0002D738
		[Token(Token = "0x17000B5C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zyz
		{
			[Token(Token = "0x600232C")]
			[Address(RVA = "0x576C950", Offset = "0x576B550", VA = "0x18576C950")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x0002F550 File Offset: 0x0002D750
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zyw
		{
			[Token(Token = "0x600232D")]
			[Address(RVA = "0x576C770", Offset = "0x576B370", VA = "0x18576C770")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x600232E")]
			[Address(RVA = "0x576DBE0", Offset = "0x576C7E0", VA = "0x18576DBE0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x0002F568 File Offset: 0x0002D768
		[Token(Token = "0x17000B5E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zzx
		{
			[Token(Token = "0x600232F")]
			[Address(RVA = "0x576CAB0", Offset = "0x576B6B0", VA = "0x18576CAB0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x0002F580 File Offset: 0x0002D780
		[Token(Token = "0x17000B5F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zzy
		{
			[Token(Token = "0x6002330")]
			[Address(RVA = "0x576CB50", Offset = "0x576B750", VA = "0x18576CB50")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x0002F598 File Offset: 0x0002D798
		[Token(Token = "0x17000B60")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zzz
		{
			[Token(Token = "0x6002331")]
			[Address(RVA = "0x576CBF0", Offset = "0x576B7F0", VA = "0x18576CBF0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x0002F5B0 File Offset: 0x0002D7B0
		[Token(Token = "0x17000B61")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zzw
		{
			[Token(Token = "0x6002332")]
			[Address(RVA = "0x576CA10", Offset = "0x576B610", VA = "0x18576CA10")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x0002F5C8 File Offset: 0x0002D7C8
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B62")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zwx
		{
			[Token(Token = "0x6002333")]
			[Address(RVA = "0x576C2D0", Offset = "0x576AED0", VA = "0x18576C2D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002334")]
			[Address(RVA = "0x576DAC0", Offset = "0x576C6C0", VA = "0x18576DAC0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x0002F5E0 File Offset: 0x0002D7E0
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B63")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zwy
		{
			[Token(Token = "0x6002335")]
			[Address(RVA = "0x576C370", Offset = "0x576AF70", VA = "0x18576C370")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002336")]
			[Address(RVA = "0x576DB00", Offset = "0x576C700", VA = "0x18576DB00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x0002F5F8 File Offset: 0x0002D7F8
		[Token(Token = "0x17000B64")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zwz
		{
			[Token(Token = "0x6002337")]
			[Address(RVA = "0x576C410", Offset = "0x576B010", VA = "0x18576C410")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x0002F610 File Offset: 0x0002D810
		[Token(Token = "0x17000B65")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zww
		{
			[Token(Token = "0x6002338")]
			[Address(RVA = "0x576C230", Offset = "0x576AE30", VA = "0x18576C230")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x0002F628 File Offset: 0x0002D828
		[Token(Token = "0x17000B66")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wxx
		{
			[Token(Token = "0x6002339")]
			[Address(RVA = "0x576A640", Offset = "0x5769240", VA = "0x18576A640")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x0002F640 File Offset: 0x0002D840
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B67")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wxy
		{
			[Token(Token = "0x600233A")]
			[Address(RVA = "0x576A6E0", Offset = "0x57692E0", VA = "0x18576A6E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x600233B")]
			[Address(RVA = "0x576D5F0", Offset = "0x576C1F0", VA = "0x18576D5F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x0002F658 File Offset: 0x0002D858
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B68")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wxz
		{
			[Token(Token = "0x600233C")]
			[Address(RVA = "0x576A780", Offset = "0x5769380", VA = "0x18576A780")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x600233D")]
			[Address(RVA = "0x576D630", Offset = "0x576C230", VA = "0x18576D630")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x0002F670 File Offset: 0x0002D870
		[Token(Token = "0x17000B69")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wxw
		{
			[Token(Token = "0x600233E")]
			[Address(RVA = "0x576A5A0", Offset = "0x57691A0", VA = "0x18576A5A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x0002F688 File Offset: 0x0002D888
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wyx
		{
			[Token(Token = "0x600233F")]
			[Address(RVA = "0x576A8E0", Offset = "0x57694E0", VA = "0x18576A8E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002340")]
			[Address(RVA = "0x576D680", Offset = "0x576C280", VA = "0x18576D680")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x0002F6A0 File Offset: 0x0002D8A0
		[Token(Token = "0x17000B6B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wyy
		{
			[Token(Token = "0x6002341")]
			[Address(RVA = "0x576A980", Offset = "0x5769580", VA = "0x18576A980")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x0002F6B8 File Offset: 0x0002D8B8
		// (set) Token: 0x06002343 RID: 9027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wyz
		{
			[Token(Token = "0x6002342")]
			[Address(RVA = "0x576AA20", Offset = "0x5769620", VA = "0x18576AA20")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002343")]
			[Address(RVA = "0x576D6C0", Offset = "0x576C2C0", VA = "0x18576D6C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x0002F6D0 File Offset: 0x0002D8D0
		[Token(Token = "0x17000B6D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wyw
		{
			[Token(Token = "0x6002344")]
			[Address(RVA = "0x576A840", Offset = "0x5769440", VA = "0x18576A840")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x0002F6E8 File Offset: 0x0002D8E8
		// (set) Token: 0x06002346 RID: 9030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wzx
		{
			[Token(Token = "0x6002345")]
			[Address(RVA = "0x576AB80", Offset = "0x5769780", VA = "0x18576AB80")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002346")]
			[Address(RVA = "0x576D710", Offset = "0x576C310", VA = "0x18576D710")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x0002F700 File Offset: 0x0002D900
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wzy
		{
			[Token(Token = "0x6002347")]
			[Address(RVA = "0x576AC20", Offset = "0x5769820", VA = "0x18576AC20")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002348")]
			[Address(RVA = "0x576D750", Offset = "0x576C350", VA = "0x18576D750")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x0002F718 File Offset: 0x0002D918
		[Token(Token = "0x17000B70")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wzz
		{
			[Token(Token = "0x6002349")]
			[Address(RVA = "0x576ACC0", Offset = "0x57698C0", VA = "0x18576ACC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x0002F730 File Offset: 0x0002D930
		[Token(Token = "0x17000B71")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wzw
		{
			[Token(Token = "0x600234A")]
			[Address(RVA = "0x576AAE0", Offset = "0x57696E0", VA = "0x18576AAE0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x0002F748 File Offset: 0x0002D948
		[Token(Token = "0x17000B72")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wwx
		{
			[Token(Token = "0x600234B")]
			[Address(RVA = "0x576A3A0", Offset = "0x5768FA0", VA = "0x18576A3A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x0002F760 File Offset: 0x0002D960
		[Token(Token = "0x17000B73")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wwy
		{
			[Token(Token = "0x600234C")]
			[Address(RVA = "0x576A440", Offset = "0x5769040", VA = "0x18576A440")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x0002F778 File Offset: 0x0002D978
		[Token(Token = "0x17000B74")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 wwz
		{
			[Token(Token = "0x600234D")]
			[Address(RVA = "0x576A4E0", Offset = "0x57690E0", VA = "0x18576A4E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x0002F790 File Offset: 0x0002D990
		[Token(Token = "0x17000B75")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 www
		{
			[Token(Token = "0x600234E")]
			[Address(RVA = "0x576A310", Offset = "0x5768F10", VA = "0x18576A310")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x0002F7A8 File Offset: 0x0002D9A8
		[Token(Token = "0x17000B76")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xx
		{
			[Token(Token = "0x600234F")]
			[Address(RVA = "0x576B000", Offset = "0x5769C00", VA = "0x18576B000")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x0002F7C0 File Offset: 0x0002D9C0
		// (set) Token: 0x06002351 RID: 9041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B77")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xy
		{
			[Token(Token = "0x6002350")]
			[Address(RVA = "0x576B280", Offset = "0x5769E80", VA = "0x18576B280")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x6002351")]
			[Address(RVA = "0x576D820", Offset = "0x576C420", VA = "0x18576D820")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x0002F7D8 File Offset: 0x0002D9D8
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B78")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xz
		{
			[Token(Token = "0x6002352")]
			[Address(RVA = "0x576B520", Offset = "0x576A120", VA = "0x18576B520")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x6002353")]
			[Address(RVA = "0x576D870", Offset = "0x576C470", VA = "0x18576D870")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x0002F7F0 File Offset: 0x0002D9F0
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B79")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xw
		{
			[Token(Token = "0x6002354")]
			[Address(RVA = "0x576AD60", Offset = "0x5769960", VA = "0x18576AD60")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x6002355")]
			[Address(RVA = "0x576D790", Offset = "0x576C390", VA = "0x18576D790")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x0002F808 File Offset: 0x0002DA08
		// (set) Token: 0x06002357 RID: 9047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yx
		{
			[Token(Token = "0x6002356")]
			[Address(RVA = "0x576BA60", Offset = "0x576A660", VA = "0x18576BA60")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x6002357")]
			[Address(RVA = "0x576D990", Offset = "0x576C590", VA = "0x18576D990")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x0002F820 File Offset: 0x0002DA20
		[Token(Token = "0x17000B7B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yy
		{
			[Token(Token = "0x6002358")]
			[Address(RVA = "0x576BD00", Offset = "0x576A900", VA = "0x18576BD00")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x0002F838 File Offset: 0x0002DA38
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yz
		{
			[Token(Token = "0x6002359")]
			[Address(RVA = "0x576BF90", Offset = "0x576AB90", VA = "0x18576BF90")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x600235A")]
			[Address(RVA = "0x576DA20", Offset = "0x576C620", VA = "0x18576DA20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x0002F850 File Offset: 0x0002DA50
		// (set) Token: 0x0600235C RID: 9052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yw
		{
			[Token(Token = "0x600235B")]
			[Address(RVA = "0x576B7C0", Offset = "0x576A3C0", VA = "0x18576B7C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x600235C")]
			[Address(RVA = "0x576D900", Offset = "0x576C500", VA = "0x18576D900")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x0002F868 File Offset: 0x0002DA68
		// (set) Token: 0x0600235E RID: 9054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 zx
		{
			[Token(Token = "0x600235D")]
			[Address(RVA = "0x576C4B0", Offset = "0x576B0B0", VA = "0x18576C4B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x600235E")]
			[Address(RVA = "0x576DB40", Offset = "0x576C740", VA = "0x18576DB40")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x0002F880 File Offset: 0x0002DA80
		// (set) Token: 0x06002360 RID: 9056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 zy
		{
			[Token(Token = "0x600235F")]
			[Address(RVA = "0x576C750", Offset = "0x576B350", VA = "0x18576C750")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x6002360")]
			[Address(RVA = "0x576DBD0", Offset = "0x576C7D0", VA = "0x18576DBD0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x0002F898 File Offset: 0x0002DA98
		[Token(Token = "0x17000B80")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 zz
		{
			[Token(Token = "0x6002361")]
			[Address(RVA = "0x576C9F0", Offset = "0x576B5F0", VA = "0x18576C9F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x0002F8B0 File Offset: 0x0002DAB0
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B81")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 zw
		{
			[Token(Token = "0x6002362")]
			[Address(RVA = "0x569DF00", Offset = "0x569CB00", VA = "0x18569DF00")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x6002363")]
			[Address(RVA = "0x576DAB0", Offset = "0x576C6B0", VA = "0x18576DAB0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x0002F8C8 File Offset: 0x0002DAC8
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B82")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 wx
		{
			[Token(Token = "0x6002364")]
			[Address(RVA = "0x576A580", Offset = "0x5769180", VA = "0x18576A580")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x6002365")]
			[Address(RVA = "0x576D5E0", Offset = "0x576C1E0", VA = "0x18576D5E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x0002F8E0 File Offset: 0x0002DAE0
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B83")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 wy
		{
			[Token(Token = "0x6002366")]
			[Address(RVA = "0x576A820", Offset = "0x5769420", VA = "0x18576A820")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x6002367")]
			[Address(RVA = "0x576D670", Offset = "0x576C270", VA = "0x18576D670")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x0002F8F8 File Offset: 0x0002DAF8
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B84")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 wz
		{
			[Token(Token = "0x6002368")]
			[Address(RVA = "0x576AAC0", Offset = "0x57696C0", VA = "0x18576AAC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x6002369")]
			[Address(RVA = "0x576D700", Offset = "0x576C300", VA = "0x18576D700")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x0002F910 File Offset: 0x0002DB10
		[Token(Token = "0x17000B85")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 ww
		{
			[Token(Token = "0x600236A")]
			[Address(RVA = "0x576A2F0", Offset = "0x5768EF0", VA = "0x18576A2F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		// Token: 0x17000B86 RID: 2950
		[Token(Token = "0x17000B86")]
		public uint this[int index]
		{
			[Token(Token = "0x600236B")]
			[Address(RVA = "0x3D284D0", Offset = "0x3D270D0", VA = "0x183D284D0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600236C")]
			[Address(RVA = "0x3D288C0", Offset = "0x3D274C0", VA = "0x183D288C0")]
			set
			{
			}
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x0002F940 File Offset: 0x0002DB40
		[Token(Token = "0x600236D")]
		[Address(RVA = "0x4CD5190", Offset = "0x4CD3D90", VA = "0x184CD5190", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(uint4 rhs)
		{
			return default(bool);
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x0002F958 File Offset: 0x0002DB58
		[Token(Token = "0x600236E")]
		[Address(RVA = "0x5769B40", Offset = "0x5768740", VA = "0x185769B40", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x0002F970 File Offset: 0x0002DB70
		[Token(Token = "0x600236F")]
		[Address(RVA = "0x571BFB0", Offset = "0x571ABB0", VA = "0x18571BFB0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x5769E10", Offset = "0x5768A10", VA = "0x185769E10", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6002371")]
		[Address(RVA = "0x5769C00", Offset = "0x5768800", VA = "0x185769C00", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x0")]
		public uint x;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x4")]
		public uint y;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x8")]
		public uint z;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0xC")]
		public uint w;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x0")]
		public static readonly uint4 zero;

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x06002372 RID: 9074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002372")]
			[Address(RVA = "0x5764CD0", Offset = "0x57638D0", VA = "0x185764CD0")]
			public DebuggerProxy(uint4 v)
			{
			}

			// Token: 0x04000155 RID: 341
			[Token(Token = "0x4000155")]
			[FieldOffset(Offset = "0x10")]
			public uint x;

			// Token: 0x04000156 RID: 342
			[Token(Token = "0x4000156")]
			[FieldOffset(Offset = "0x14")]
			public uint y;

			// Token: 0x04000157 RID: 343
			[Token(Token = "0x4000157")]
			[FieldOffset(Offset = "0x18")]
			public uint z;

			// Token: 0x04000158 RID: 344
			[Token(Token = "0x4000158")]
			[FieldOffset(Offset = "0x1C")]
			public uint w;
		}
	}
}
