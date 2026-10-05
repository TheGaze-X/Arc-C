using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct quaternion : IEquatable<quaternion>, IFormattable
	{
		// Token: 0x06001DEC RID: 7660 RVA: 0x00028B00 File Offset: 0x00026D00
		[Token(Token = "0x6001DEC")]
		[Address(RVA = "0x576B4A0", Offset = "0x576A0A0", VA = "0x18576B4A0")]
		public static implicit operator Quaternion(quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00028B18 File Offset: 0x00026D18
		[Token(Token = "0x6001DED")]
		[Address(RVA = "0x576B4A0", Offset = "0x576A0A0", VA = "0x18576B4A0")]
		public static implicit operator quaternion(Quaternion q)
		{
			return default(quaternion);
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DEE")]
		[Address(RVA = "0x57C0300", Offset = "0x57BEF00", VA = "0x1857C0300")]
		[MethodImpl(256)]
		public quaternion(float x, float y, float z, float w)
		{
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DEF")]
		[Address(RVA = "0x453ADB0", Offset = "0x45399B0", VA = "0x18453ADB0")]
		[MethodImpl(256)]
		public quaternion(float4 value)
		{
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00028B30 File Offset: 0x00026D30
		[Token(Token = "0x6001DF0")]
		[Address(RVA = "0x253ECA0", Offset = "0x253D8A0", VA = "0x18253ECA0")]
		[MethodImpl(256)]
		public static implicit operator quaternion(float4 v)
		{
			return default(quaternion);
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DF1")]
		[Address(RVA = "0x58093A0", Offset = "0x5807FA0", VA = "0x1858093A0")]
		public quaternion(float3x3 m)
		{
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DF2")]
		[Address(RVA = "0x5809A80", Offset = "0x5808680", VA = "0x185809A80")]
		public quaternion(float4x4 m)
		{
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00028B48 File Offset: 0x00026D48
		[Token(Token = "0x6001DF3")]
		[Address(RVA = "0x5808050", Offset = "0x5806C50", VA = "0x185808050")]
		[MethodImpl(256)]
		public static quaternion AxisAngle(float3 axis, float angle)
		{
			return default(quaternion);
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00028B60 File Offset: 0x00026D60
		[Token(Token = "0x6001DF4")]
		[Address(RVA = "0x57EBDE0", Offset = "0x57EA9E0", VA = "0x1857EBDE0")]
		[MethodImpl(256)]
		public static quaternion EulerXYZ(float3 xyz)
		{
			return default(quaternion);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00028B78 File Offset: 0x00026D78
		[Token(Token = "0x6001DF5")]
		[Address(RVA = "0x57EBF90", Offset = "0x57EAB90", VA = "0x1857EBF90")]
		[MethodImpl(256)]
		public static quaternion EulerXZY(float3 xyz)
		{
			return default(quaternion);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00028B90 File Offset: 0x00026D90
		[Token(Token = "0x6001DF6")]
		[Address(RVA = "0x57EC130", Offset = "0x57EAD30", VA = "0x1857EC130")]
		[MethodImpl(256)]
		public static quaternion EulerYXZ(float3 xyz)
		{
			return default(quaternion);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00028BA8 File Offset: 0x00026DA8
		[Token(Token = "0x6001DF7")]
		[Address(RVA = "0x57EC2E0", Offset = "0x57EAEE0", VA = "0x1857EC2E0")]
		[MethodImpl(256)]
		public static quaternion EulerYZX(float3 xyz)
		{
			return default(quaternion);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00028BC0 File Offset: 0x00026DC0
		[Token(Token = "0x6001DF8")]
		[Address(RVA = "0x57EC490", Offset = "0x57EB090", VA = "0x1857EC490")]
		[MethodImpl(256)]
		public static quaternion EulerZXY(float3 xyz)
		{
			return default(quaternion);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00028BD8 File Offset: 0x00026DD8
		[Token(Token = "0x6001DF9")]
		[Address(RVA = "0x57EC630", Offset = "0x57EB230", VA = "0x1857EC630")]
		[MethodImpl(256)]
		public static quaternion EulerZYX(float3 xyz)
		{
			return default(quaternion);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00028BF0 File Offset: 0x00026DF0
		[Token(Token = "0x6001DFA")]
		[Address(RVA = "0x5808220", Offset = "0x5806E20", VA = "0x185808220")]
		[MethodImpl(256)]
		public static quaternion EulerXYZ(float x, float y, float z)
		{
			return default(quaternion);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00028C08 File Offset: 0x00026E08
		[Token(Token = "0x6001DFB")]
		[Address(RVA = "0x5808270", Offset = "0x5806E70", VA = "0x185808270")]
		[MethodImpl(256)]
		public static quaternion EulerXZY(float x, float y, float z)
		{
			return default(quaternion);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00028C20 File Offset: 0x00026E20
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x58082C0", Offset = "0x5806EC0", VA = "0x1858082C0")]
		[MethodImpl(256)]
		public static quaternion EulerYXZ(float x, float y, float z)
		{
			return default(quaternion);
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00028C38 File Offset: 0x00026E38
		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0x5808310", Offset = "0x5806F10", VA = "0x185808310")]
		[MethodImpl(256)]
		public static quaternion EulerYZX(float x, float y, float z)
		{
			return default(quaternion);
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00028C50 File Offset: 0x00026E50
		[Token(Token = "0x6001DFE")]
		[Address(RVA = "0x5808360", Offset = "0x5806F60", VA = "0x185808360")]
		[MethodImpl(256)]
		public static quaternion EulerZXY(float x, float y, float z)
		{
			return default(quaternion);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00028C68 File Offset: 0x00026E68
		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x58083B0", Offset = "0x5806FB0", VA = "0x1858083B0")]
		[MethodImpl(256)]
		public static quaternion EulerZYX(float x, float y, float z)
		{
			return default(quaternion);
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00028C80 File Offset: 0x00026E80
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x5808590", Offset = "0x5807190", VA = "0x185808590")]
		[MethodImpl(256)]
		public static quaternion Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default(quaternion);
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00028C98 File Offset: 0x00026E98
		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x5808400", Offset = "0x5807000", VA = "0x185808400")]
		[MethodImpl(256)]
		public static quaternion Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default(quaternion);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00028CB0 File Offset: 0x00026EB0
		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x5808C90", Offset = "0x5807890", VA = "0x185808C90")]
		[MethodImpl(256)]
		public static quaternion RotateX(float angle)
		{
			return default(quaternion);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00028CC8 File Offset: 0x00026EC8
		[Token(Token = "0x6001E03")]
		[Address(RVA = "0x5808D70", Offset = "0x5807970", VA = "0x185808D70")]
		[MethodImpl(256)]
		public static quaternion RotateY(float angle)
		{
			return default(quaternion);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00028CE0 File Offset: 0x00026EE0
		[Token(Token = "0x6001E04")]
		[Address(RVA = "0x5808E60", Offset = "0x5807A60", VA = "0x185808E60")]
		[MethodImpl(256)]
		public static quaternion RotateZ(float angle)
		{
			return default(quaternion);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00028CF8 File Offset: 0x00026EF8
		[Token(Token = "0x6001E05")]
		[Address(RVA = "0x5808AB0", Offset = "0x58076B0", VA = "0x185808AB0")]
		[MethodImpl(256)]
		public static quaternion LookRotation(float3 forward, float3 up)
		{
			return default(quaternion);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00028D10 File Offset: 0x00026F10
		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x5808710", Offset = "0x5807310", VA = "0x185808710")]
		public static quaternion LookRotationSafe(float3 forward, float3 up)
		{
			return default(quaternion);
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00028D28 File Offset: 0x00026F28
		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x4E32FB0", Offset = "0x4E31BB0", VA = "0x184E32FB0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(quaternion x)
		{
			return default(bool);
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00028D40 File Offset: 0x00026F40
		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x5808160", Offset = "0x5806D60", VA = "0x185808160", Slot = "0")]
		[MethodImpl(256)]
		public override bool Equals(object x)
		{
			return default(bool);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00028D58 File Offset: 0x00026F58
		[Token(Token = "0x6001E09")]
		[Address(RVA = "0x571D580", Offset = "0x571C180", VA = "0x18571D580", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0x5808F40", Offset = "0x5807B40", VA = "0x185808F40", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001E0B")]
		[Address(RVA = "0x5809150", Offset = "0x5807D50", VA = "0x185809150", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x0")]
		public float4 value;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x0")]
		public static readonly quaternion identity;
	}
}
