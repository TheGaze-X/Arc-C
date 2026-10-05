using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	[StaticAccessor("ScalableBufferManager::GetInstance()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/GfxDevice/ScalableBufferManager.h")]
	public static class ScalableBufferManager
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000326 RID: 806
		[Token(Token = "0x170000BA")]
		public static extern float widthScaleFactor { [Token(Token = "0x6000326")] [Address(RVA = "0x593FFB0", Offset = "0x593EBB0", VA = "0x18593FFB0")] [MethodImpl(4096)] get; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000327 RID: 807
		[Token(Token = "0x170000BB")]
		public static extern float heightScaleFactor { [Token(Token = "0x6000327")] [Address(RVA = "0x593FF80", Offset = "0x593EB80", VA = "0x18593FF80")] [MethodImpl(4096)] get; }
	}
}
