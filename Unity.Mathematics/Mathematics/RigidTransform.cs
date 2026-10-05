using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct RigidTransform
	{
		// Token: 0x06001E79 RID: 7801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E79")]
		[Address(RVA = "0x5810D80", Offset = "0x580F980", VA = "0x185810D80")]
		[MethodImpl(256)]
		public RigidTransform(quaternion rotation, float3 translation)
		{
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7A")]
		[Address(RVA = "0x5810DA0", Offset = "0x580F9A0", VA = "0x185810DA0")]
		[MethodImpl(256)]
		public RigidTransform(float3x3 rotation, float3 translation)
		{
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x5810E10", Offset = "0x580FA10", VA = "0x185810E10")]
		[MethodImpl(256)]
		public RigidTransform(float4x4 transform)
		{
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x000296A0 File Offset: 0x000278A0
		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0x580F5E0", Offset = "0x580E1E0", VA = "0x18580F5E0")]
		[MethodImpl(256)]
		public static RigidTransform AxisAngle(float3 axis, float angle)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x000296B8 File Offset: 0x000278B8
		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0x580F8C0", Offset = "0x580E4C0", VA = "0x18580F8C0")]
		[MethodImpl(256)]
		public static RigidTransform EulerXYZ(float3 xyz)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x000296D0 File Offset: 0x000278D0
		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0x580FA80", Offset = "0x580E680", VA = "0x18580FA80")]
		[MethodImpl(256)]
		public static RigidTransform EulerXZY(float3 xyz)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x000296E8 File Offset: 0x000278E8
		[Token(Token = "0x6001E7F")]
		[Address(RVA = "0x580FB00", Offset = "0x580E700", VA = "0x18580FB00")]
		[MethodImpl(256)]
		public static RigidTransform EulerYXZ(float3 xyz)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00029700 File Offset: 0x00027900
		[Token(Token = "0x6001E80")]
		[Address(RVA = "0x580FCC0", Offset = "0x580E8C0", VA = "0x18580FCC0")]
		[MethodImpl(256)]
		public static RigidTransform EulerYZX(float3 xyz)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00029718 File Offset: 0x00027918
		[Token(Token = "0x6001E81")]
		[Address(RVA = "0x580FD40", Offset = "0x580E940", VA = "0x18580FD40")]
		[MethodImpl(256)]
		public static RigidTransform EulerZXY(float3 xyz)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00029730 File Offset: 0x00027930
		[Token(Token = "0x6001E82")]
		[Address(RVA = "0x580FF00", Offset = "0x580EB00", VA = "0x18580FF00")]
		[MethodImpl(256)]
		public static RigidTransform EulerZYX(float3 xyz)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00029748 File Offset: 0x00027948
		[Token(Token = "0x6001E83")]
		[Address(RVA = "0x580F940", Offset = "0x580E540", VA = "0x18580F940")]
		[MethodImpl(256)]
		public static RigidTransform EulerXYZ(float x, float y, float z)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00029760 File Offset: 0x00027960
		[Token(Token = "0x6001E84")]
		[Address(RVA = "0x580F9E0", Offset = "0x580E5E0", VA = "0x18580F9E0")]
		[MethodImpl(256)]
		public static RigidTransform EulerXZY(float x, float y, float z)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00029778 File Offset: 0x00027978
		[Token(Token = "0x6001E85")]
		[Address(RVA = "0x580FB80", Offset = "0x580E780", VA = "0x18580FB80")]
		[MethodImpl(256)]
		public static RigidTransform EulerYXZ(float x, float y, float z)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00029790 File Offset: 0x00027990
		[Token(Token = "0x6001E86")]
		[Address(RVA = "0x580FC20", Offset = "0x580E820", VA = "0x18580FC20")]
		[MethodImpl(256)]
		public static RigidTransform EulerYZX(float x, float y, float z)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x000297A8 File Offset: 0x000279A8
		[Token(Token = "0x6001E87")]
		[Address(RVA = "0x580FDC0", Offset = "0x580E9C0", VA = "0x18580FDC0")]
		[MethodImpl(256)]
		public static RigidTransform EulerZXY(float x, float y, float z)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000297C0 File Offset: 0x000279C0
		[Token(Token = "0x6001E88")]
		[Address(RVA = "0x580FE60", Offset = "0x580EA60", VA = "0x18580FE60")]
		[MethodImpl(256)]
		public static RigidTransform EulerZYX(float x, float y, float z)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x000297D8 File Offset: 0x000279D8
		[Token(Token = "0x6001E89")]
		[Address(RVA = "0x580FF80", Offset = "0x580EB80", VA = "0x18580FF80")]
		[MethodImpl(256)]
		public static RigidTransform Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x000297F0 File Offset: 0x000279F0
		[Token(Token = "0x6001E8A")]
		[Address(RVA = "0x5810260", Offset = "0x580EE60", VA = "0x185810260")]
		[MethodImpl(256)]
		public static RigidTransform Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00029808 File Offset: 0x00027A08
		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0x58102F0", Offset = "0x580EEF0", VA = "0x1858102F0")]
		[MethodImpl(256)]
		public static RigidTransform RotateX(float angle)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00029820 File Offset: 0x00027A20
		[Token(Token = "0x6001E8C")]
		[Address(RVA = "0x5810410", Offset = "0x580F010", VA = "0x185810410")]
		[MethodImpl(256)]
		public static RigidTransform RotateY(float angle)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00029838 File Offset: 0x00027A38
		[Token(Token = "0x6001E8D")]
		[Address(RVA = "0x5810530", Offset = "0x580F130", VA = "0x185810530")]
		[MethodImpl(256)]
		public static RigidTransform RotateZ(float angle)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00029850 File Offset: 0x00027A50
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0x5810CC0", Offset = "0x580F8C0", VA = "0x185810CC0")]
		[MethodImpl(256)]
		public static RigidTransform Translate(float3 vector)
		{
			return default(RigidTransform);
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00029868 File Offset: 0x00027A68
		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0x580F830", Offset = "0x580E430", VA = "0x18580F830")]
		[MethodImpl(256)]
		public bool Equals(RigidTransform x)
		{
			return default(bool);
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00029880 File Offset: 0x00027A80
		[Token(Token = "0x6001E90")]
		[Address(RVA = "0x580F720", Offset = "0x580E320", VA = "0x18580F720", Slot = "0")]
		[MethodImpl(256)]
		public override bool Equals(object x)
		{
			return default(bool);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00029898 File Offset: 0x00027A98
		[Token(Token = "0x6001E91")]
		[Address(RVA = "0x58102C0", Offset = "0x580EEC0", VA = "0x1858102C0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001E92")]
		[Address(RVA = "0x5810970", Offset = "0x580F570", VA = "0x185810970", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001E93")]
		[Address(RVA = "0x5810650", Offset = "0x580F250", VA = "0x185810650")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x0")]
		public quaternion rot;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x10")]
		public float3 pos;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RigidTransform identity;
	}
}
