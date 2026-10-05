using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C6A RID: 3178
	[Token(Token = "0x2000C6A")]
	public class ServerAct13SideData : Act13SideData
	{
		// Token: 0x06006948 RID: 26952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006948")]
		[Address(RVA = "0x200CC20", Offset = "0x200B820", VA = "0x18200CC20")]
		public ServerAct13SideData()
		{
		}

		// Token: 0x040040CC RID: 16588
		[Token(Token = "0x40040CC")]
		[FieldOffset(Offset = "0x58")]
		public ListDict<string, CommonFavorUpInfo> favorUpList;
	}
}
