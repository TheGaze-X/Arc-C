using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[RequireComponent(typeof(Transform), typeof(Rigidbody2D))]
	[NativeHeader("Modules/Physics2D/Joint2D.h")]
	public class Joint2D : Behaviour
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000099 RID: 153
		[Token(Token = "0x17000028")]
		public extern Rigidbody2D connectedBody { [Token(Token = "0x6000099")] [Address(RVA = "0x59C3950", Offset = "0x59C2550", VA = "0x1859C3950")] [MethodImpl(4096)] get; }
	}
}
