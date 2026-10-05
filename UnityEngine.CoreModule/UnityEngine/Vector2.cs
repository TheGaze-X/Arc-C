using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	[NativeClass("Vector2f")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[Il2CppEagerStaticClassConstruction]
	public struct Vector2 : IEquatable<Vector2>, IFormattable
	{
		// Token: 0x170001C4 RID: 452
		[Token(Token = "0x170001C4")]
		public float this[int index]
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0xDDB390", Offset = "0xDD9F90", VA = "0x180DDB390")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0xDF3840", Offset = "0xDF2440", VA = "0x180DF3840")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x4F1E50", Offset = "0x4F0A50", VA = "0x1804F1E50")]
		[MethodImpl(256)]
		public Vector2(float x, float y)
		{
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x4F1E50", Offset = "0x4F0A50", VA = "0x1804F1E50")]
		[MethodImpl(256)]
		public void Set(float newX, float newY)
		{
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x5B46C0", Offset = "0x5B32C0", VA = "0x1805B46C0")]
		[MethodImpl(256)]
		public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
		{
			return default(Vector2);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x5953EF0", Offset = "0x5952AF0", VA = "0x185953EF0")]
		[MethodImpl(256)]
		public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t)
		{
			return default(Vector2);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00004F98 File Offset: 0x00003198
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x5953FC0", Offset = "0x5952BC0", VA = "0x185953FC0")]
		[MethodImpl(256)]
		public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta)
		{
			return default(Vector2);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x57AA510", Offset = "0x57A9110", VA = "0x1857AA510")]
		[MethodImpl(256)]
		public static Vector2 Scale(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x5954190", Offset = "0x5952D90", VA = "0x185954190")]
		[MethodImpl(256)]
		public void Scale(Vector2 scale)
		{
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x4F6F00", Offset = "0x4F5B00", VA = "0x1804F6F00")]
		[MethodImpl(256)]
		public void Normalize()
		{
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x170001C5")]
		public Vector2 normalized
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x4F7020", Offset = "0x4F5C20", VA = "0x1804F7020")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x59545A0", Offset = "0x59531A0", VA = "0x1859545A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x5954590", Offset = "0x5953190", VA = "0x185954590")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x59545B0", Offset = "0x59531B0", VA = "0x1859545B0", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x6000808")]
		[Address(RVA = "0xFC67C0", Offset = "0xFC53C0", VA = "0x180FC67C0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00004FF8 File Offset: 0x000031F8
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x5953E50", Offset = "0x5952A50", VA = "0x185953E50", Slot = "0")]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x57A9790", Offset = "0x57A8390", VA = "0x1857A9790", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x5954130", Offset = "0x5952D30", VA = "0x185954130")]
		[MethodImpl(256)]
		public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal)
		{
			return default(Vector2);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x5954100", Offset = "0x5952D00", VA = "0x185954100")]
		[MethodImpl(256)]
		public static Vector2 Perpendicular(Vector2 inDirection)
		{
			return default(Vector2);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x5953E20", Offset = "0x5952A20", VA = "0x185953E20")]
		[MethodImpl(256)]
		public static float Dot(Vector2 lhs, Vector2 rhs)
		{
			return 0f;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x170001C6")]
		public float magnitude
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x5954910", Offset = "0x5953510", VA = "0x185954910")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x170001C7")]
		public float sqrMagnitude
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x5954570", Offset = "0x5953170", VA = "0x185954570")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x5953B10", Offset = "0x5952710", VA = "0x185953B10")]
		[MethodImpl(256)]
		public static float Angle(Vector2 from, Vector2 to)
		{
			return 0f;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x69A420", Offset = "0x699020", VA = "0x18069A420")]
		[MethodImpl(256)]
		public static float SignedAngle(Vector2 from, Vector2 to)
		{
			return 0f;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x5953D70", Offset = "0x5952970", VA = "0x185953D70")]
		[MethodImpl(256)]
		public static float Distance(Vector2 a, Vector2 b)
		{
			return 0f;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x5953C70", Offset = "0x5952870", VA = "0x185953C70")]
		[MethodImpl(256)]
		public static Vector2 ClampMagnitude(Vector2 vector, float maxLength)
		{
			return default(Vector2);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x572FA60", Offset = "0x572E660", VA = "0x18572FA60")]
		[MethodImpl(256)]
		public static float SqrMagnitude(Vector2 a)
		{
			return 0f;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x5954570", Offset = "0x5953170", VA = "0x185954570")]
		[MethodImpl(256)]
		public float SqrMagnitude()
		{
			return 0f;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x5953F80", Offset = "0x5952B80", VA = "0x185953F80")]
		[MethodImpl(256)]
		public static Vector2 Min(Vector2 lhs, Vector2 rhs)
		{
			return default(Vector2);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x5953F40", Offset = "0x5952B40", VA = "0x185953F40")]
		[MethodImpl(256)]
		public static Vector2 Max(Vector2 lhs, Vector2 rhs)
		{
			return default(Vector2);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x59541C0", Offset = "0x5952DC0", VA = "0x1859541C0")]
		[ExcludeFromDocs]
		[MethodImpl(256)]
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed)
		{
			return default(Vector2);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x5954240", Offset = "0x5952E40", VA = "0x185954240")]
		[ExcludeFromDocs]
		[MethodImpl(256)]
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime)
		{
			return default(Vector2);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x59542C0", Offset = "0x5952EC0", VA = "0x1859542C0")]
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			return default(Vector2);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x57A9ED0", Offset = "0x57A8AD0", VA = "0x1857A9ED0")]
		[MethodImpl(256)]
		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x57AA550", Offset = "0x57A9150", VA = "0x1857AA550")]
		[MethodImpl(256)]
		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x57AA510", Offset = "0x57A9110", VA = "0x1857AA510")]
		[MethodImpl(256)]
		public static Vector2 operator *(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000051F0 File Offset: 0x000033F0
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1579520", Offset = "0x1578120", VA = "0x181579520")]
		[MethodImpl(256)]
		public static Vector2 operator /(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00005208 File Offset: 0x00003408
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x57AA5E0", Offset = "0x57A91E0", VA = "0x1857AA5E0")]
		[MethodImpl(256)]
		public static Vector2 operator -(Vector2 a)
		{
			return default(Vector2);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x57AA4B0", Offset = "0x57A90B0", VA = "0x1857AA4B0")]
		[MethodImpl(256)]
		public static Vector2 operator *(Vector2 a, float d)
		{
			return default(Vector2);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x57AA4E0", Offset = "0x57A90E0", VA = "0x1857AA4E0")]
		[MethodImpl(256)]
		public static Vector2 operator *(float d, Vector2 a)
		{
			return default(Vector2);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00005250 File Offset: 0x00003450
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x57A9F70", Offset = "0x57A8B70", VA = "0x1857A9F70")]
		[MethodImpl(256)]
		public static Vector2 operator /(Vector2 a, float d)
		{
			return default(Vector2);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x5954B90", Offset = "0x5953790", VA = "0x185954B90")]
		[MethodImpl(256)]
		public static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x5954BE0", Offset = "0x59537E0", VA = "0x185954BE0")]
		[MethodImpl(256)]
		public static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x5938990", Offset = "0x5937590", VA = "0x185938990")]
		[MethodImpl(256)]
		public static implicit operator Vector2(Vector3 v)
		{
			return default(Vector2);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x4F7100", Offset = "0x4F5D00", VA = "0x1804F7100")]
		[MethodImpl(256)]
		public static implicit operator Vector3(Vector2 v)
		{
			return default(Vector3);
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x170001C8")]
		public static Vector2 zero
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x5954B40", Offset = "0x5953740", VA = "0x185954B40")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x000052E0 File Offset: 0x000034E0
		[Token(Token = "0x170001C9")]
		public static Vector2 one
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x5954A00", Offset = "0x5953600", VA = "0x185954A00")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x170001CA")]
		public static Vector2 up
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x5954AF0", Offset = "0x59536F0", VA = "0x185954AF0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x170001CB")]
		public static Vector2 down
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x5954870", Offset = "0x5953470", VA = "0x185954870")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x170001CC")]
		public static Vector2 left
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x59548C0", Offset = "0x59534C0", VA = "0x1859548C0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x170001CD")]
		public static Vector2 right
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0x5954AA0", Offset = "0x59536A0", VA = "0x185954AA0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00005358 File Offset: 0x00003558
		[Token(Token = "0x170001CE")]
		public static Vector2 positiveInfinity
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x5954A50", Offset = "0x5953650", VA = "0x185954A50")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00005370 File Offset: 0x00003570
		[Token(Token = "0x170001CF")]
		public static Vector2 negativeInfinity
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x59549B0", Offset = "0x59535B0", VA = "0x1859549B0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 zeroVector;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 oneVector;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2 upVector;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Vector2 downVector;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Vector2 leftVector;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x28")]
		private static readonly Vector2 rightVector;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Vector2 positiveInfinityVector;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Vector2 negativeInfinityVector;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		public const float kEpsilon = 1E-05f;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		public const float kEpsilonNormalSqrt = 1E-15f;
	}
}
