using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[NativeHeader("Modules/Physics2D/Public/BoxCollider2D.h")]
	public sealed class BoxCollider2D : Collider2D
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000257C File Offset: 0x0000077C
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x17000027")]
		public Vector2 size
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x59C26F0", Offset = "0x59C12F0", VA = "0x1859C26F0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x59C2790", Offset = "0x59C1390", VA = "0x1859C2790")]
			set
			{
			}
		}

		// Token: 0x06000095 RID: 149
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x59C26A0", Offset = "0x59C12A0", VA = "0x1859C26A0")]
		[MethodImpl(4096)]
		private extern void get_size_Injected(out Vector2 ret);

		// Token: 0x06000096 RID: 150
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x59C2740", Offset = "0x59C1340", VA = "0x1859C2740")]
		[MethodImpl(4096)]
		private extern void set_size_Injected(ref Vector2 value);
	}
}
