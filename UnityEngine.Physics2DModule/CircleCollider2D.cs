using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[NativeHeader("Modules/Physics2D/Public/CircleCollider2D.h")]
	public sealed class CircleCollider2D : Collider2D
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000074 RID: 116
		// (set) Token: 0x06000075 RID: 117
		[Token(Token = "0x1700001C")]
		public extern float radius { [Token(Token = "0x6000074")] [Address(RVA = "0x59C2980", Offset = "0x59C1580", VA = "0x1859C2980")] [MethodImpl(4096)] get; [Token(Token = "0x6000075")] [Address(RVA = "0x59C29C0", Offset = "0x59C15C0", VA = "0x1859C29C0")] [MethodImpl(4096)] set; }
	}
}
