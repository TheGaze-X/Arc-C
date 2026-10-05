using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000AB4 RID: 2740
	[Token(Token = "0x2000AB4")]
	public class PlayerRoguelikeNode
	{
		// Token: 0x06006771 RID: 26481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006771")]
		[Address(RVA = "0x1EFCBD0", Offset = "0x1EFB7D0", VA = "0x181EFCBD0")]
		public PlayerRoguelikeNode()
		{
		}

		// Token: 0x040039BE RID: 14782
		[Token(Token = "0x40039BE")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeNodePosition pos;

		// Token: 0x040039BF RID: 14783
		[Token(Token = "0x40039BF")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeNodeLine> next;

		// Token: 0x040039C0 RID: 14784
		[Token(Token = "0x40039C0")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeEventType type;

		// Token: 0x040039C1 RID: 14785
		[Token(Token = "0x40039C1")]
		[FieldOffset(Offset = "0x24")]
		[JsonProperty("style")]
		public int nodeDisplaySubType;

		// Token: 0x040039C2 RID: 14786
		[Token(Token = "0x40039C2")]
		[FieldOffset(Offset = "0x28")]
		public long fts;

		// Token: 0x040039C3 RID: 14787
		[Token(Token = "0x40039C3")]
		[FieldOffset(Offset = "0x30")]
		public PlayerNodeDetailContent realContent;

		// Token: 0x040039C4 RID: 14788
		[Token(Token = "0x40039C4")]
		[FieldOffset(Offset = "0x38")]
		public List<string> attach;

		// Token: 0x040039C5 RID: 14789
		[Token(Token = "0x40039C5")]
		[FieldOffset(Offset = "0x40")]
		public RoguelikeShop shop;

		// Token: 0x040039C6 RID: 14790
		[Token(Token = "0x40039C6")]
		[FieldOffset(Offset = "0x48")]
		public List<PlayerRoguelikePendingEvent.SceneContent> scenes;

		// Token: 0x040039C7 RID: 14791
		[Token(Token = "0x40039C7")]
		[FieldOffset(Offset = "0x50")]
		public string stage;

		// Token: 0x040039C8 RID: 14792
		[Token(Token = "0x40039C8")]
		[FieldOffset(Offset = "0x58")]
		public PlayerNodeForesightType visibility;

		// Token: 0x040039C9 RID: 14793
		[Token(Token = "0x40039C9")]
		[FieldOffset(Offset = "0x60")]
		public PlayerNodeRollInfo refresh;
	}
}
