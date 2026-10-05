using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006512 RID: 25874
	[Token(Token = "0x2006512")]
	public class ArtMagazineChangeSquadRequest
	{
		// Token: 0x060252F2 RID: 152306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252F2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArtMagazineChangeSquadRequest()
		{
		}

		// Token: 0x04034277 RID: 213623
		[Token(Token = "0x4034277")]
		[FieldOffset(Offset = "0x10")]
		public List<string> squad;
	}
}
