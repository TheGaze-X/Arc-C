using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F72 RID: 16242
	[Token(Token = "0x2003F72")]
	public class SiracusaMapChatModel
	{
		// Token: 0x06019345 RID: 103237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019345")]
		[Address(RVA = "0x11E9D60", Offset = "0x11E8960", VA = "0x1811E9D60")]
		public SiracusaMapChatModel()
		{
		}

		// Token: 0x0401F403 RID: 128003
		[Token(Token = "0x401F403")]
		[FieldOffset(Offset = "0x10")]
		public string initAvgStoryId;

		// Token: 0x0401F404 RID: 128004
		[Token(Token = "0x401F404")]
		[FieldOffset(Offset = "0x18")]
		public bool isReplay;

		// Token: 0x0401F405 RID: 128005
		[Token(Token = "0x401F405")]
		[FieldOffset(Offset = "0x20")]
		public HashSet<string> selectedOptions;

		// Token: 0x0401F406 RID: 128006
		[Token(Token = "0x401F406")]
		[FieldOffset(Offset = "0x28")]
		public HashSet<string> obtainItems;

		// Token: 0x0401F407 RID: 128007
		[Token(Token = "0x401F407")]
		[FieldOffset(Offset = "0x30")]
		public bool isCharCommentLike;
	}
}
