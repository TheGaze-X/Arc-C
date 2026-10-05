using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics.Geometry
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[DebuggerDisplay("{Normal}, {Distance}")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	internal struct Plane
	{
		// Token: 0x06002468 RID: 9320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002468")]
		[Address(RVA = "0x577C550", Offset = "0x577B150", VA = "0x18577C550")]
		[MethodImpl(256)]
		public Plane(float coefficientA, float coefficientB, float coefficientC, float coefficientD)
		{
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x577AE90", Offset = "0x5779A90", VA = "0x18577AE90")]
		[MethodImpl(256)]
		public Plane(float3 normal, float distance)
		{
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246A")]
		[Address(RVA = "0x577C3E0", Offset = "0x577AFE0", VA = "0x18577C3E0")]
		[MethodImpl(256)]
		public Plane(float3 normal, float3 pointInPlane)
		{
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246B")]
		[Address(RVA = "0x577C450", Offset = "0x577B050", VA = "0x18577C450")]
		[MethodImpl(256)]
		public Plane(float3 vector1InPlane, float3 vector2InPlane, float3 pointInPlane)
		{
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00030C00 File Offset: 0x0002EE00
		[Token(Token = "0x600246C")]
		[Address(RVA = "0x577C090", Offset = "0x577AC90", VA = "0x18577C090")]
		[MethodImpl(256)]
		public static Plane CreateFromUnitNormalAndDistance(float3 unitNormal, float distance)
		{
			return default(Plane);
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x00030C18 File Offset: 0x0002EE18
		[Token(Token = "0x600246D")]
		[Address(RVA = "0x577C0E0", Offset = "0x577ACE0", VA = "0x18577C0E0")]
		[MethodImpl(256)]
		public static Plane CreateFromUnitNormalAndPointInPlane(float3 unitNormal, float3 pointInPlane)
		{
			return default(Plane);
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x00030C30 File Offset: 0x0002EE30
		// (set) Token: 0x0600246F RID: 9327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B8F")]
		public float3 Normal
		{
			[Token(Token = "0x600246E")]
			[Address(RVA = "0x577C650", Offset = "0x577B250", VA = "0x18577C650")]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x600246F")]
			[Address(RVA = "0x577C680", Offset = "0x577B280", VA = "0x18577C680")]
			set
			{
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x00030C48 File Offset: 0x0002EE48
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B90")]
		public float Distance
		{
			[Token(Token = "0x6002470")]
			[Address(RVA = "0x877270", Offset = "0x875E70", VA = "0x180877270")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002471")]
			[Address(RVA = "0x8772A0", Offset = "0x875EA0", VA = "0x1808772A0")]
			set
			{
			}
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x00030C60 File Offset: 0x0002EE60
		[Token(Token = "0x6002472")]
		[Address(RVA = "0x577C180", Offset = "0x577AD80", VA = "0x18577C180")]
		[MethodImpl(256)]
		public static Plane Normalize(Plane plane)
		{
			return default(Plane);
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00030C78 File Offset: 0x0002EE78
		[Token(Token = "0x6002473")]
		[Address(RVA = "0x577C240", Offset = "0x577AE40", VA = "0x18577C240")]
		[MethodImpl(256)]
		public static float4 Normalize(float4 planeCoefficients)
		{
			return default(float4);
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00030C90 File Offset: 0x0002EE90
		[Token(Token = "0x6002474")]
		[Address(RVA = "0x577C390", Offset = "0x577AF90", VA = "0x18577C390")]
		[MethodImpl(256)]
		public float SignedDistanceToPoint(float3 point)
		{
			return 0f;
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x00030CA8 File Offset: 0x0002EEA8
		[Token(Token = "0x6002475")]
		[Address(RVA = "0x577C2E0", Offset = "0x577AEE0", VA = "0x18577C2E0")]
		[MethodImpl(256)]
		public float3 Projection(float3 point)
		{
			return default(float3);
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x00030CC0 File Offset: 0x0002EEC0
		[Token(Token = "0x17000B91")]
		public Plane Flipped
		{
			[Token(Token = "0x6002476")]
			[Address(RVA = "0x577C5F0", Offset = "0x577B1F0", VA = "0x18577C5F0")]
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00030CD8 File Offset: 0x0002EED8
		[Token(Token = "0x6002477")]
		[Address(RVA = "0x253ECA0", Offset = "0x253D8A0", VA = "0x18253ECA0")]
		[MethodImpl(256)]
		public static implicit operator float4(Plane plane)
		{
			return default(float4);
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002478")]
		[Address(RVA = "0x577BFF0", Offset = "0x577ABF0", VA = "0x18577BFF0")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckPlaneIsNormalized()
		{
		}

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x0")]
		public float4 NormalAndDistance;
	}
}
