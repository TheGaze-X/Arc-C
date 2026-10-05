using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C28 RID: 3112
	[Token(Token = "0x2000C28")]
	[Serializable]
	public class ActArchiveChatData
	{
		// Token: 0x06006907 RID: 26887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006907")]
		[Address(RVA = "0x1FF8550", Offset = "0x1FF7150", VA = "0x181FF8550")]
		public ActArchiveChatData()
		{
		}

		// Token: 0x04003FB1 RID: 16305
		[Token(Token = "0x4003FB1")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveChatGroupData> chat;
	}
}
