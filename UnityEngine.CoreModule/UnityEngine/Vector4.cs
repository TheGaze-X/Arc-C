using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	[NativeClass("Vector4f")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[Il2CppEagerStaticClassConstruction]
	[NativeHeader("Runtime/Math/Vector4.h")]
	public struct Vector4 : IEquatable<Vector4>, IFormattable
	{
		// Token: 0x170001DD RID: 477
		[Token(Token = "0x170001DD")]
		public float this[int index]
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x4F7460", Offset = "0x4F6060", VA = "0x1804F7460")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600085D")]
			[Address(RVA = "0xDDB410", Offset = "0xDDA010", VA = "0x180DDB410")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x57C0300", Offset = "0x57BEF00", VA = "0x1857C0300")]
		[MethodImpl(256)]
		public Vector4(float x, float y, float z, float w)
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x59582A0", Offset = "0x5956EA0", VA = "0x1859582A0")]
		[MethodImpl(256)]
		public Vector4(float x, float y, float z)
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x5958290", Offset = "0x5956E90", VA = "0x185958290")]
		[MethodImpl(256)]
		public Vector4(float x, float y)
		{
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x57C0300", Offset = "0x57BEF00", VA = "0x1857C0300")]
		[MethodImpl(256)]
		public void Set(float newX, float newY, float newZ, float newW)
		{
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00005670 File Offset: 0x00003870
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x59490F0", Offset = "0x5947CF0", VA = "0x1859490F0")]
		[MethodImpl(256)]
		public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
		{
			return default(Vector4);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00005688 File Offset: 0x00003888
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x5949060", Offset = "0x5947C60", VA = "0x185949060")]
		[MethodImpl(256)]
		public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t)
		{
			return default(Vector4);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000056A0 File Offset: 0x000038A0
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x5957A90", Offset = "0x5956690", VA = "0x185957A90")]
		[MethodImpl(256)]
		public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta)
		{
			return default(Vector4);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x5949B40", Offset = "0x5948740", VA = "0x185949B40")]
		[MethodImpl(256)]
		public static Vector4 Scale(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x5957EC0", Offset = "0x5956AC0", VA = "0x185957EC0")]
		[MethodImpl(256)]
		public void Scale(Vector4 scale)
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000056D0 File Offset: 0x000038D0
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x114B970", Offset = "0x114A570", VA = "0x18114B970", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x5957840", Offset = "0x5956440", VA = "0x185957840", Slot = "0")]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x4E32FB0", Offset = "0x4E31BB0", VA = "0x184E32FB0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00005718 File Offset: 0x00003918
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x5957C40", Offset = "0x5956840", VA = "0x185957C40")]
		[MethodImpl(256)]
		public static Vector4 Normalize(Vector4 a)
		{
			return default(Vector4);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x5957D10", Offset = "0x5956910", VA = "0x185957D10")]
		[MethodImpl(256)]
		public void Normalize()
		{
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00005730 File Offset: 0x00003930
		[Token(Token = "0x170001DE")]
		public Vector4 normalized
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x59583E0", Offset = "0x5956FE0", VA = "0x1859583E0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00005748 File Offset: 0x00003948
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x5950780", Offset = "0x594F380", VA = "0x185950780")]
		[MethodImpl(256)]
		public static float Dot(Vector4 a, Vector4 b)
		{
			return 0f;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x5957DC0", Offset = "0x59569C0", VA = "0x185957DC0")]
		[MethodImpl(256)]
		public static Vector4 Project(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x59577C0", Offset = "0x59563C0", VA = "0x1859577C0")]
		[MethodImpl(256)]
		public static float Distance(Vector4 a, Vector4 b)
		{
			return 0f;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x5957900", Offset = "0x5956500", VA = "0x185957900")]
		[MethodImpl(256)]
		public static float Magnitude(Vector4 a)
		{
			return 0f;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x170001DF")]
		public float magnitude
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x59582C0", Offset = "0x5956EC0", VA = "0x1859582C0")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x170001E0")]
		public float sqrMagnitude
		{
			[Token(Token = "0x6000872")]
			[Address(RVA = "0x5957F00", Offset = "0x5956B00", VA = "0x185957F00")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x5957A30", Offset = "0x5956630", VA = "0x185957A30")]
		[MethodImpl(256)]
		public static Vector4 Min(Vector4 lhs, Vector4 rhs)
		{
			return default(Vector4);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x59579D0", Offset = "0x59565D0", VA = "0x1859579D0")]
		[MethodImpl(256)]
		public static Vector4 Max(Vector4 lhs, Vector4 rhs)
		{
			return default(Vector4);
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00005808 File Offset: 0x00003A08
		[Token(Token = "0x170001E1")]
		public static Vector4 zero
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0x5958540", Offset = "0x5957140", VA = "0x185958540")]
			[MethodImpl(256)]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x170001E2")]
		public static Vector4 one
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x59584A0", Offset = "0x59570A0", VA = "0x1859584A0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00005838 File Offset: 0x00003A38
		[Token(Token = "0x170001E3")]
		public static Vector4 positiveInfinity
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x59584F0", Offset = "0x59570F0", VA = "0x1859584F0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x00005850 File Offset: 0x00003A50
		[Token(Token = "0x170001E4")]
		public static Vector4 negativeInfinity
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x5958390", Offset = "0x5956F90", VA = "0x185958390")]
			[MethodImpl(256)]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x5949920", Offset = "0x5948520", VA = "0x185949920")]
		[MethodImpl(256)]
		public static Vector4 operator +(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x5949BA0", Offset = "0x59487A0", VA = "0x185949BA0")]
		[MethodImpl(256)]
		public static Vector4 operator -(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x59586E0", Offset = "0x59572E0", VA = "0x1859586E0")]
		[MethodImpl(256)]
		public static Vector4 operator -(Vector4 a)
		{
			return default(Vector4);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x5949AA0", Offset = "0x59486A0", VA = "0x185949AA0")]
		[MethodImpl(256)]
		public static Vector4 operator *(Vector4 a, float d)
		{
			return default(Vector4);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x5949AF0", Offset = "0x59486F0", VA = "0x185949AF0")]
		[MethodImpl(256)]
		public static Vector4 operator *(float d, Vector4 a)
		{
			return default(Vector4);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x5949980", Offset = "0x5948580", VA = "0x185949980")]
		[MethodImpl(256)]
		public static Vector4 operator /(Vector4 a, float d)
		{
			return default(Vector4);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x5958590", Offset = "0x5957190", VA = "0x185958590")]
		[MethodImpl(256)]
		public static bool operator ==(Vector4 lhs, Vector4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x5958670", Offset = "0x5957270", VA = "0x185958670")]
		[MethodImpl(256)]
		public static bool operator !=(Vector4 lhs, Vector4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x59585F0", Offset = "0x59571F0", VA = "0x1859585F0")]
		[MethodImpl(256)]
		public static implicit operator Vector4(Vector3 v)
		{
			return default(Vector4);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x577C650", Offset = "0x577B250", VA = "0x18577C650")]
		[MethodImpl(256)]
		public static implicit operator Vector3(Vector4 v)
		{
			return default(Vector3);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x5958630", Offset = "0x5957230", VA = "0x185958630")]
		[MethodImpl(256)]
		public static implicit operator Vector4(Vector2 v)
		{
			return default(Vector4);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x5938990", Offset = "0x5937590", VA = "0x185938990")]
		[MethodImpl(256)]
		public static implicit operator Vector2(Vector4 v)
		{
			return default(Vector2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x59581F0", Offset = "0x5956DF0", VA = "0x1859581F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x59581E0", Offset = "0x5956DE0", VA = "0x1859581E0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x5957F50", Offset = "0x5956B50", VA = "0x185957F50", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x5957F00", Offset = "0x5956B00", VA = "0x185957F00")]
		[MethodImpl(256)]
		public static float SqrMagnitude(Vector4 a)
		{
			return 0f;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x5957F00", Offset = "0x5956B00", VA = "0x185957F00")]
		[MethodImpl(256)]
		public float SqrMagnitude()
		{
			return 0f;
		}

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		public const float kEpsilon = 1E-05f;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0xC")]
		public float w;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector4 zeroVector;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector4 oneVector;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Vector4 positiveInfinityVector;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Vector4 negativeInfinityVector;
	}
}
