using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class Rigidbody2D : Component
	{
		// Token: 0x1700000F RID: 15
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x1700000F")]
		public Vector2 position
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x59C6CF0", Offset = "0x59C58F0", VA = "0x1859C6CF0")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (set) Token: 0x0600004F RID: 79
		[Token(Token = "0x17000010")]
		public extern float rotation { [Token(Token = "0x600004F")] [Address(RVA = "0x59C6D30", Offset = "0x59C5930", VA = "0x1859C6D30")] [MethodImpl(4096)] set; }

		// Token: 0x06000050 RID: 80 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x59C69A0", Offset = "0x59C55A0", VA = "0x1859C69A0")]
		public void MovePosition(Vector2 position)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000024A4 File Offset: 0x000006A4
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x17000011")]
		public Vector2 velocity
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x59C6B70", Offset = "0x59C5770", VA = "0x1859C6B70")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x59C6E10", Offset = "0x59C5A10", VA = "0x1859C6E10")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000053 RID: 83
		[Token(Token = "0x17000012")]
		public extern float mass { [Token(Token = "0x6000053")] [Address(RVA = "0x59C6AE0", Offset = "0x59C56E0", VA = "0x1859C6AE0")] [MethodImpl(4096)] get; }

		// Token: 0x17000013 RID: 19
		// (set) Token: 0x06000054 RID: 84
		[Token(Token = "0x17000013")]
		public extern float gravityScale { [Token(Token = "0x6000054")] [Address(RVA = "0x59C6C00", Offset = "0x59C5800", VA = "0x1859C6C00")] [MethodImpl(4096)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000055 RID: 85
		// (set) Token: 0x06000056 RID: 86
		[Token(Token = "0x17000014")]
		public extern RigidbodyType2D bodyType { [Token(Token = "0x6000055")] [Address(RVA = "0x59C6A60", Offset = "0x59C5660", VA = "0x1859C6A60")] [MethodImpl(4096)] get; [Token(Token = "0x6000056")] [Address(RVA = "0x59C6BC0", Offset = "0x59C57C0", VA = "0x1859C6BC0")] [NativeMethod("SetBodyType_Binding")] [MethodImpl(4096)] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000024BC File Offset: 0x000006BC
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x17000015")]
		public bool isKinematic
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x59C6AA0", Offset = "0x59C56A0", VA = "0x1859C6AA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x59C6C50", Offset = "0x59C5850", VA = "0x1859C6C50")]
			set
			{
			}
		}

		// Token: 0x06000059 RID: 89
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x59C6910", Offset = "0x59C5510", VA = "0x1859C6910")]
		[MethodImpl(4096)]
		public extern bool IsSleeping();

		// Token: 0x0600005A RID: 90
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x59C69E0", Offset = "0x59C55E0", VA = "0x1859C69E0")]
		[MethodImpl(4096)]
		public extern void Sleep();

		// Token: 0x0600005B RID: 91
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x59C6A20", Offset = "0x59C5620", VA = "0x1859C6A20")]
		[NativeMethod("Wake")]
		[MethodImpl(4096)]
		public extern void WakeUp();

		// Token: 0x17000016 RID: 22
		// (set) Token: 0x0600005C RID: 92
		[Token(Token = "0x17000016")]
		public extern RigidbodySleepMode2D sleepMode { [Token(Token = "0x600005C")] [Address(RVA = "0x59C6D80", Offset = "0x59C5980", VA = "0x1859C6D80")] [MethodImpl(4096)] set; }

		// Token: 0x0600005D RID: 93 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x59C6870", Offset = "0x59C5470", VA = "0x1859C6870")]
		public void AddForce(Vector2 force, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x59C68C0", Offset = "0x59C54C0", VA = "0x1859C68C0")]
		public int GetAttachedColliders([Out] Collider2D[] results)
		{
			return 0;
		}

		// Token: 0x0600005F RID: 95
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x59C68C0", Offset = "0x59C54C0", VA = "0x1859C68C0")]
		[NativeMethod("GetAttachedCollidersArray_Binding")]
		[MethodImpl(4096)]
		private extern int GetAttachedCollidersArray_Internal([Unmarshalled] [NotNull("ArgumentNullException")] Collider2D[] results);

		// Token: 0x06000060 RID: 96 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public Rigidbody2D()
		{
		}

		// Token: 0x06000061 RID: 97
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x59C6CA0", Offset = "0x59C58A0", VA = "0x1859C6CA0")]
		[MethodImpl(4096)]
		private extern void set_position_Injected(ref Vector2 value);

		// Token: 0x06000062 RID: 98
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x59C6950", Offset = "0x59C5550", VA = "0x1859C6950")]
		[MethodImpl(4096)]
		private extern void MovePosition_Injected(ref Vector2 position);

		// Token: 0x06000063 RID: 99
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x59C6B20", Offset = "0x59C5720", VA = "0x1859C6B20")]
		[MethodImpl(4096)]
		private extern void get_velocity_Injected(out Vector2 ret);

		// Token: 0x06000064 RID: 100
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x59C6DC0", Offset = "0x59C59C0", VA = "0x1859C6DC0")]
		[MethodImpl(4096)]
		private extern void set_velocity_Injected(ref Vector2 value);

		// Token: 0x06000065 RID: 101
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x59C6810", Offset = "0x59C5410", VA = "0x1859C6810")]
		[MethodImpl(4096)]
		private extern void AddForce_Injected(ref Vector2 force, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode);
	}
}
