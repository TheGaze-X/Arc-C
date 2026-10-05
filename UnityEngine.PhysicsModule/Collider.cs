using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[RequireComponent(typeof(Transform))]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Physics/Collider.h")]
	public class Collider : Component
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004D RID: 77
		[Token(Token = "0x1700000F")]
		public extern bool enabled { [Token(Token = "0x600004D")] [Address(RVA = "0x59C7430", Offset = "0x59C6030", VA = "0x1859C7430")] [MethodImpl(4096)] get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004E RID: 78
		[Token(Token = "0x17000010")]
		public extern Rigidbody attachedRigidbody { [Token(Token = "0x600004E")] [Address(RVA = "0x59C7340", Offset = "0x59C5F40", VA = "0x1859C7340")] [NativeMethod("GetRigidbody")] [MethodImpl(4096)] get; }

		// Token: 0x0600004F RID: 79 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x59C7120", Offset = "0x59C5D20", VA = "0x1859C7120")]
		public Vector3 ClosestPoint(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x17000011")]
		public Bounds bounds
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x59C73D0", Offset = "0x59C5FD0", VA = "0x1859C73D0")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x59C71F0", Offset = "0x59C5DF0", VA = "0x1859C71F0")]
		private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit)
		{
			return default(RaycastHit);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x59C7270", Offset = "0x59C5E70", VA = "0x1859C7270")]
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public Collider()
		{
		}

		// Token: 0x06000054 RID: 84
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x59C70C0", Offset = "0x59C5CC0", VA = "0x1859C70C0")]
		[MethodImpl(4096)]
		private extern void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret);

		// Token: 0x06000055 RID: 85
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x59C7380", Offset = "0x59C5F80", VA = "0x1859C7380")]
		[MethodImpl(4096)]
		private extern void get_bounds_Injected(out Bounds ret);

		// Token: 0x06000056 RID: 86
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x59C7180", Offset = "0x59C5D80", VA = "0x1859C7180")]
		[MethodImpl(4096)]
		private extern void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret);
	}
}
