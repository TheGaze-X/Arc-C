using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EEA RID: 28394
	[Token(Token = "0x2006EEA")]
	public class ActMultiV3CommitAlbumResponse : PlayerDeltaResponse
	{
		// Token: 0x06028570 RID: 165232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028570")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActMultiV3CommitAlbumResponse()
		{
		}

		// Token: 0x04039575 RID: 234869
		[Token(Token = "0x4039575")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> items;
	}
}
