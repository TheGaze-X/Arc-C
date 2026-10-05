using System;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	internal struct RuntimeRemoteClassHandle
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x17000006")]
		internal RuntimeClassHandle ProxyClass
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x4AB1620", Offset = "0x4AB0220", VA = "0x184AB1620")]
			get
			{
				return default(RuntimeClassHandle);
			}
		}

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x0")]
		private unsafe RuntimeStructs.RemoteClass* value;
	}
}
