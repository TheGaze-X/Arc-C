using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[UsedByNativeCode]
	public class Behaviour : Component
	{
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600091A RID: 2330
		// (set) Token: 0x0600091B RID: 2331
		[Token(Token = "0x170001F0")]
		[NativeProperty]
		[RequiredByNativeCode]
		public extern bool enabled { [Token(Token = "0x600091A")] [Address(RVA = "0x5947F20", Offset = "0x5946B20", VA = "0x185947F20")] [MethodImpl(4096)] get; [Token(Token = "0x600091B")] [Address(RVA = "0x5947FA0", Offset = "0x5946BA0", VA = "0x185947FA0")] [MethodImpl(4096)] set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600091C RID: 2332
		[Token(Token = "0x170001F1")]
		[NativeProperty]
		public extern bool isActiveAndEnabled { [Token(Token = "0x600091C")] [Address(RVA = "0x5947F60", Offset = "0x5946B60", VA = "0x185947F60")] [NativeMethod("IsAddedToManager")] [MethodImpl(4096)] get; }

		// Token: 0x0600091D RID: 2333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x5947ED0", Offset = "0x5946AD0", VA = "0x185947ED0")]
		public Behaviour()
		{
		}
	}
}
