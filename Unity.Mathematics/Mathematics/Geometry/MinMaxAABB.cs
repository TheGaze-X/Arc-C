using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics.Geometry
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	internal struct MinMaxAABB : IEquatable<MinMaxAABB>
	{
		// Token: 0x06002455 RID: 9301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x3746830", Offset = "0x3745430", VA = "0x183746830")]
		[MethodImpl(256)]
		public MinMaxAABB(float3 min, float3 max)
		{
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00030AB0 File Offset: 0x0002ECB0
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x577B7E0", Offset = "0x577A3E0", VA = "0x18577B7E0")]
		[MethodImpl(256)]
		public static MinMaxAABB CreateFromCenterAndExtents(float3 center, float3 extents)
		{
			return default(MinMaxAABB);
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x00030AC8 File Offset: 0x0002ECC8
		[Token(Token = "0x6002457")]
		[Address(RVA = "0x577B8B0", Offset = "0x577A4B0", VA = "0x18577B8B0")]
		[MethodImpl(256)]
		public static MinMaxAABB CreateFromCenterAndHalfExtents(float3 center, float3 halfExtents)
		{
			return default(MinMaxAABB);
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x00030AE0 File Offset: 0x0002ECE0
		[Token(Token = "0x17000B8A")]
		public float3 Extents
		{
			[Token(Token = "0x6002458")]
			[Address(RVA = "0x577BE60", Offset = "0x577AA60", VA = "0x18577BE60")]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x00030AF8 File Offset: 0x0002ECF8
		[Token(Token = "0x17000B8B")]
		public float3 HalfExtents
		{
			[Token(Token = "0x6002459")]
			[Address(RVA = "0x577BEC0", Offset = "0x577AAC0", VA = "0x18577BEC0")]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x00030B10 File Offset: 0x0002ED10
		[Token(Token = "0x17000B8C")]
		public float3 Center
		{
			[Token(Token = "0x600245A")]
			[Address(RVA = "0x577BDF0", Offset = "0x577A9F0", VA = "0x18577BDF0")]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x00030B28 File Offset: 0x0002ED28
		[Token(Token = "0x17000B8D")]
		public bool IsValid
		{
			[Token(Token = "0x600245B")]
			[Address(RVA = "0x577BF30", Offset = "0x577AB30", VA = "0x18577BF30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x00030B40 File Offset: 0x0002ED40
		[Token(Token = "0x17000B8E")]
		public float SurfaceArea
		{
			[Token(Token = "0x600245C")]
			[Address(RVA = "0x577BF90", Offset = "0x577AB90", VA = "0x18577BF90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00030B58 File Offset: 0x0002ED58
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x577B6A0", Offset = "0x577A2A0", VA = "0x18577B6A0")]
		[MethodImpl(256)]
		public bool Contains(float3 point)
		{
			return default(bool);
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00030B70 File Offset: 0x0002ED70
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x577B740", Offset = "0x577A340", VA = "0x18577B740")]
		[MethodImpl(256)]
		public bool Contains(MinMaxAABB aabb)
		{
			return default(bool);
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00030B88 File Offset: 0x0002ED88
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x577BCB0", Offset = "0x577A8B0", VA = "0x18577BCB0")]
		[MethodImpl(256)]
		public bool Overlaps(MinMaxAABB aabb)
		{
			return default(bool);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002460")]
		[Address(RVA = "0x577BC30", Offset = "0x577A830", VA = "0x18577BC30")]
		[MethodImpl(256)]
		public void Expand(float signedDistance)
		{
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002461")]
		[Address(RVA = "0x577B970", Offset = "0x577A570", VA = "0x18577B970")]
		[MethodImpl(256)]
		public void Encapsulate(MinMaxAABB aabb)
		{
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002462")]
		[Address(RVA = "0x577BA90", Offset = "0x577A690", VA = "0x18577BA90")]
		[MethodImpl(256)]
		public void Encapsulate(float3 point)
		{
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x00030BA0 File Offset: 0x0002EDA0
		[Token(Token = "0x6002463")]
		[Address(RVA = "0x577BBB0", Offset = "0x577A7B0", VA = "0x18577BBB0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(MinMaxAABB other)
		{
			return default(bool);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6002464")]
		[Address(RVA = "0x577BD50", Offset = "0x577A950", VA = "0x18577BD50", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x0")]
		public float3 Min;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0xC")]
		public float3 Max;
	}
}
