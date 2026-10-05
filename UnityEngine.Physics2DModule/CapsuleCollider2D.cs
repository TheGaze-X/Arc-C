using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[NativeHeader("Modules/Physics2D/Public/CapsuleCollider2D.h")]
	public sealed class CapsuleCollider2D : Collider2D
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002534 File Offset: 0x00000734
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x1700001D")]
		public Vector2 size
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x59C2860", Offset = "0x59C1460", VA = "0x1859C2860")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x59C2940", Offset = "0x59C1540", VA = "0x1859C2940")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000078 RID: 120
		// (set) Token: 0x06000079 RID: 121
		[Token(Token = "0x1700001E")]
		public extern CapsuleDirection2D direction { [Token(Token = "0x6000078")] [Address(RVA = "0x59C27D0", Offset = "0x59C13D0", VA = "0x1859C27D0")] [MethodImpl(4096)] get; [Token(Token = "0x6000079")] [Address(RVA = "0x59C28B0", Offset = "0x59C14B0", VA = "0x1859C28B0")] [MethodImpl(4096)] set; }

		// Token: 0x0600007A RID: 122 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public CapsuleCollider2D()
		{
		}

		// Token: 0x0600007B RID: 123
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x59C2810", Offset = "0x59C1410", VA = "0x1859C2810")]
		[MethodImpl(4096)]
		private extern void get_size_Injected(out Vector2 ret);

		// Token: 0x0600007C RID: 124
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x59C28F0", Offset = "0x59C14F0", VA = "0x1859C28F0")]
		[MethodImpl(4096)]
		private extern void set_size_Injected(ref Vector2 value);
	}
}
