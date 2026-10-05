using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	[NativeHeader("Runtime/Camera/Flare.h")]
	public sealed class Flare : Object
	{
		// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x5928C50", Offset = "0x5927850", VA = "0x185928C50")]
		public Flare()
		{
		}

		// Token: 0x0600047E RID: 1150
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x5928C10", Offset = "0x5927810", VA = "0x185928C10")]
		[MethodImpl(4096)]
		private static extern void Internal_Create([Writable] Flare self);
	}
}
