using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Physics/CapsuleCollider.h")]
	public class CapsuleCollider : Collider
	{
		// Token: 0x17000019 RID: 25
		// (set) Token: 0x06000067 RID: 103
		[Token(Token = "0x17000019")]
		public extern float height { [Token(Token = "0x6000067")] [Address(RVA = "0x59C6F90", Offset = "0x59C5B90", VA = "0x1859C6F90")] [MethodImpl(4096)] set; }
	}
}
