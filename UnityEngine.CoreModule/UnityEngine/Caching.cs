using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[StaticAccessor("GetCachingManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Misc/CachingManager.h")]
	public sealed class Caching
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x17000030")]
		[StaticAccessor("CachingManagerWrapper", StaticAccessorType.DoubleColon)]
		public static Cache currentCacheForWriting
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x59212D0", Offset = "0x591FED0", VA = "0x1859212D0")]
			[NativeName("Caching_GetCurrentCacheHandle")]
			get
			{
				return default(Cache);
			}
		}

		// Token: 0x060000F1 RID: 241
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x5921290", Offset = "0x591FE90", VA = "0x185921290")]
		[MethodImpl(4096)]
		private static extern void get_currentCacheForWriting_Injected(out Cache ret);
	}
}
