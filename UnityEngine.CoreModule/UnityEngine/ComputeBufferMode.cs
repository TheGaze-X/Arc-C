using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	[NativeType("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum ComputeBufferMode
	{
		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		Immutable,
		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		Dynamic,
		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[Obsolete("ComputeBufferMode.Circular is deprecated (legacy mode)")]
		Circular,
		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[Obsolete("ComputeBufferMode.StreamOut is deprecated (internal use only)")]
		StreamOut,
		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		SubUpdates
	}
}
