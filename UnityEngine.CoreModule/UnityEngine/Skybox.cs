using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	[NativeHeader("Runtime/Camera/Skybox.h")]
	public sealed class Skybox : Behaviour
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004DF RID: 1247
		// (set) Token: 0x060004E0 RID: 1248
		[Token(Token = "0x17000133")]
		public extern Material material { [Token(Token = "0x60004DF")] [Address(RVA = "0x5941A10", Offset = "0x5940610", VA = "0x185941A10")] [MethodImpl(4096)] get; [Token(Token = "0x60004E0")] [Address(RVA = "0x5941A50", Offset = "0x5940650", VA = "0x185941A50")] [MethodImpl(4096)] set; }
	}
}
