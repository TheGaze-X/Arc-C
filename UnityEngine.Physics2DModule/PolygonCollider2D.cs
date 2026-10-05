using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
	public sealed class PolygonCollider2D : Collider2D
	{
		// Token: 0x06000097 RID: 151 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x59C6460", Offset = "0x59C5060", VA = "0x1859C6460")]
		public void SetPath(int index, Vector2[] points)
		{
		}

		// Token: 0x06000098 RID: 152
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x59C6410", Offset = "0x59C5010", VA = "0x1859C6410")]
		[NativeMethod("SetPath_Binding")]
		[MethodImpl(4096)]
		private extern void SetPath_Internal(int index, [NotNull("ArgumentNullException")] Vector2[] points);
	}
}
