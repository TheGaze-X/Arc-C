using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[RequiredByNativeCode(Optional = true)]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
	public class Collider2D : Behaviour
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000066 RID: 102
		// (set) Token: 0x06000067 RID: 103
		[Token(Token = "0x17000017")]
		public extern bool isTrigger { [Token(Token = "0x6000066")] [Address(RVA = "0x59C2B90", Offset = "0x59C1790", VA = "0x1859C2B90")] [MethodImpl(4096)] get; [Token(Token = "0x6000067")] [Address(RVA = "0x59C2CB0", Offset = "0x59C18B0", VA = "0x1859C2CB0")] [MethodImpl(4096)] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x17000018")]
		public Vector2 offset
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x59C2C20", Offset = "0x59C1820", VA = "0x1859C2C20")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x59C2D50", Offset = "0x59C1950", VA = "0x1859C2D50")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006A RID: 106
		[Token(Token = "0x17000019")]
		public extern Rigidbody2D attachedRigidbody { [Token(Token = "0x600006A")] [Address(RVA = "0x59C2AA0", Offset = "0x59C16A0", VA = "0x1859C2AA0")] [NativeMethod("GetAttachedRigidbody_Binding")] [MethodImpl(4096)] get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x1700001A")]
		public Bounds bounds
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x59C2B30", Offset = "0x59C1730", VA = "0x1859C2B30")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006C RID: 108
		// (set) Token: 0x0600006D RID: 109
		[Token(Token = "0x1700001B")]
		public extern PhysicsMaterial2D sharedMaterial { [Token(Token = "0x600006C")] [Address(RVA = "0x59C2C70", Offset = "0x59C1870", VA = "0x1859C2C70")] [NativeMethod("GetMaterial")] [MethodImpl(4096)] get; [Token(Token = "0x600006D")] [Address(RVA = "0x59C2D90", Offset = "0x59C1990", VA = "0x1859C2D90")] [NativeMethod("SetMaterial")] [MethodImpl(4096)] set; }

		// Token: 0x0600006E RID: 110 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x59C2A60", Offset = "0x59C1660", VA = "0x1859C2A60")]
		public bool OverlapPoint(Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public Collider2D()
		{
		}

		// Token: 0x06000070 RID: 112
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x59C2BD0", Offset = "0x59C17D0", VA = "0x1859C2BD0")]
		[MethodImpl(4096)]
		private extern void get_offset_Injected(out Vector2 ret);

		// Token: 0x06000071 RID: 113
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x59C2D00", Offset = "0x59C1900", VA = "0x1859C2D00")]
		[MethodImpl(4096)]
		private extern void set_offset_Injected(ref Vector2 value);

		// Token: 0x06000072 RID: 114
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x59C2AE0", Offset = "0x59C16E0", VA = "0x1859C2AE0")]
		[MethodImpl(4096)]
		private extern void get_bounds_Injected(out Bounds ret);

		// Token: 0x06000073 RID: 115
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x59C2A10", Offset = "0x59C1610", VA = "0x1859C2A10")]
		[MethodImpl(4096)]
		private extern bool OverlapPoint_Injected(ref Vector2 point);
	}
}
