using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[NativeHeader("Runtime/Geometry/AABB.h")]
	[NativeHeader("Runtime/Geometry/Ray.h")]
	[NativeClass("AABB")]
	[NativeType(Header = "Runtime/Geometry/AABB.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/Geometry/Intersection.h")]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	public struct Bounds : IEquatable<Bounds>, IFormattable
	{
		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x5920C60", Offset = "0x591F860", VA = "0x185920C60")]
		public Bounds(Vector3 center, Vector3 size)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x5920550", Offset = "0x591F150", VA = "0x185920550", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x5920360", Offset = "0x591EF60", VA = "0x185920360", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x59202B0", Offset = "0x591EEB0", VA = "0x1859202B0", Slot = "4")]
		public bool Equals(Bounds other)
		{
			return default(bool);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000082")]
		public Vector3 center
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x5920CC0", Offset = "0x591F8C0", VA = "0x185920CC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x361F830", Offset = "0x361E430", VA = "0x18361F830")]
			set
			{
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00002928 File Offset: 0x00000B28
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		public Vector3 size
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x5920DC0", Offset = "0x591F9C0", VA = "0x185920DC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x5921120", Offset = "0x591FD20", VA = "0x185921120")]
			set
			{
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		public Vector3 extents
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x5920CE0", Offset = "0x591F8E0", VA = "0x185920CE0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x361F840", Offset = "0x361E440", VA = "0x18361F840")]
			set
			{
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00002958 File Offset: 0x00000B58
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		public Vector3 min
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x5920D60", Offset = "0x591F960", VA = "0x185920D60")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x5921050", Offset = "0x591FC50", VA = "0x185921050")]
			set
			{
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00002970 File Offset: 0x00000B70
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		public Vector3 max
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x5920D00", Offset = "0x591F900", VA = "0x185920D00")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x5920F90", Offset = "0x591FB90", VA = "0x185920F90")]
			set
			{
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x5920E10", Offset = "0x591FA10", VA = "0x185920E10")]
		public static bool operator ==(Bounds lhs, Bounds rhs)
		{
			return default(bool);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x5920ED0", Offset = "0x591FAD0", VA = "0x185920ED0")]
		public static bool operator !=(Bounds lhs, Bounds rhs)
		{
			return default(bool);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x5920920", Offset = "0x591F520", VA = "0x185920920")]
		public void SetMinMax(Vector3 min, Vector3 max)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x5920090", Offset = "0x591EC90", VA = "0x185920090")]
		public void Encapsulate(Vector3 point)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x59201C0", Offset = "0x591EDC0", VA = "0x1859201C0")]
		public void Encapsulate(Bounds bounds)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x5920500", Offset = "0x591F100", VA = "0x185920500")]
		public void Expand(float amount)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x5920490", Offset = "0x591F090", VA = "0x185920490")]
		public void Expand(Vector3 amount)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x59207C0", Offset = "0x591F3C0", VA = "0x1859207C0")]
		public bool Intersects(Bounds bounds)
		{
			return default(bool);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x59206E0", Offset = "0x591F2E0", VA = "0x1859206E0")]
		public bool IntersectRay(Ray ray)
		{
			return default(bool);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x5920750", Offset = "0x591F350", VA = "0x185920750")]
		public bool IntersectRay(Ray ray, out float distance)
		{
			return default(bool);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x5920C40", Offset = "0x591F840", VA = "0x185920C40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x5920C50", Offset = "0x591F850", VA = "0x185920C50")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x5920A70", Offset = "0x591F670", VA = "0x185920A70", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x5920040", Offset = "0x591EC40", VA = "0x185920040")]
		[NativeMethod("IsInside", IsThreadSafe = true)]
		public bool Contains(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x5920A20", Offset = "0x591F620", VA = "0x185920A20")]
		[FreeFunction("BoundsScripting::SqrDistance", HasExplicitThis = true, IsThreadSafe = true)]
		public float SqrDistance(Vector3 point)
		{
			return 0f;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x5920680", Offset = "0x591F280", VA = "0x185920680")]
		[FreeFunction("IntersectRayAABB", IsThreadSafe = true)]
		private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist)
		{
			return default(bool);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x591FF90", Offset = "0x591EB90", VA = "0x18591FF90")]
		[FreeFunction("BoundsScripting::ClosestPoint", HasExplicitThis = true, IsThreadSafe = true)]
		public Vector3 ClosestPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06000226 RID: 550
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x591FFF0", Offset = "0x591EBF0", VA = "0x18591FFF0")]
		[MethodImpl(4096)]
		private static extern bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point);

		// Token: 0x06000227 RID: 551
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x59209D0", Offset = "0x591F5D0", VA = "0x1859209D0")]
		[MethodImpl(4096)]
		private static extern float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point);

		// Token: 0x06000228 RID: 552
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x5920620", Offset = "0x591F220", VA = "0x185920620")]
		[MethodImpl(4096)]
		private static extern bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist);

		// Token: 0x06000229 RID: 553
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x591FF30", Offset = "0x591EB30", VA = "0x18591FF30")]
		[MethodImpl(4096)]
		private static extern void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret);

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x0")]
		private Vector3 m_Center;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0xC")]
		[NativeName("m_Extent")]
		private Vector3 m_Extents;
	}
}
