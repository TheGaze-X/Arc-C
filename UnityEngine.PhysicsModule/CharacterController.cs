using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[NativeHeader("Modules/Physics/CharacterController.h")]
	public class CharacterController : Collider
	{
		// Token: 0x06000057 RID: 87 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x59C7030", Offset = "0x59C5C30", VA = "0x1859C7030")]
		public CollisionFlags Move(Vector3 motion)
		{
			return CollisionFlags.None;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000058 RID: 88
		[Token(Token = "0x17000012")]
		public extern bool isGrounded { [Token(Token = "0x6000058")] [Address(RVA = "0x59C7080", Offset = "0x59C5C80", VA = "0x1859C7080")] [NativeName("IsGrounded")] [MethodImpl(4096)] get; }

		// Token: 0x06000059 RID: 89
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x59C6FE0", Offset = "0x59C5BE0", VA = "0x1859C6FE0")]
		[MethodImpl(4096)]
		private extern CollisionFlags Move_Injected(ref Vector3 motion);
	}
}
