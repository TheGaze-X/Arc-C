using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CF6 RID: 3318
	[Token(Token = "0x2000CF6")]
	public class ServerAct25SideData : Act25SideData
	{
		// Token: 0x060069D3 RID: 27091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D3")]
		[Address(RVA = "0x200CCB0", Offset = "0x200B8B0", VA = "0x18200CCB0")]
		public ServerAct25SideData()
		{
		}

		// Token: 0x04004415 RID: 17429
		[Token(Token = "0x4004415")]
		[FieldOffset(Offset = "0x68")]
		public ListDict<string, CommonFavorUpInfo> favorUpList;
	}
}
