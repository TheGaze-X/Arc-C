using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E52 RID: 20050
	[Token(Token = "0x2004E52")]
	public class FireworkPuzzleGetInfoResponse : PlayerDeltaResponse
	{
		// Token: 0x0601DED1 RID: 122577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DED1")]
		[Address(RVA = "0x17A8510", Offset = "0x17A7110", VA = "0x1817A8510")]
		public FireworkPuzzleGetInfoResponse()
		{
		}

		// Token: 0x04027B93 RID: 162707
		[Token(Token = "0x4027B93")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, FireworkData.PlateContent> puzzleData;

		// Token: 0x04027B94 RID: 162708
		[Token(Token = "0x4027B94")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, Act38SideServerPuzzleInfo> puzzleInfoMap;
	}
}
