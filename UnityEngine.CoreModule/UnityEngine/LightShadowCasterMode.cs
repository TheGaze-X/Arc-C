using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	[NativeHeader("Runtime/Camera/SharedLightData.h")]
	public enum LightShadowCasterMode
	{
		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		Default,
		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		NonLightmappedOnly,
		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		Everything
	}
}
