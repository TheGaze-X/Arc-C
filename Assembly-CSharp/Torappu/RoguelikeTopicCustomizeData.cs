using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020011DA RID: 4570
	[Token(Token = "0x20011DA")]
	public class RoguelikeTopicCustomizeData
	{
		// Token: 0x06006FC2 RID: 28610 RVA: 0x00032898 File Offset: 0x00030A98
		[Token(Token = "0x6006FC2")]
		[Address(RVA = "0x1028420", Offset = "0x1027020", VA = "0x181028420")]
		public bool ShouldSerializerl01()
		{
			return default(bool);
		}

		// Token: 0x06006FC3 RID: 28611 RVA: 0x000328B0 File Offset: 0x00030AB0
		[Token(Token = "0x6006FC3")]
		[Address(RVA = "0x142F770", Offset = "0x142E370", VA = "0x18142F770")]
		public bool ShouldSerializerl02()
		{
			return default(bool);
		}

		// Token: 0x06006FC4 RID: 28612 RVA: 0x000328C8 File Offset: 0x00030AC8
		[Token(Token = "0x6006FC4")]
		[Address(RVA = "0x926F60", Offset = "0x925B60", VA = "0x180926F60")]
		public bool ShouldSerializerl03()
		{
			return default(bool);
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x000328E0 File Offset: 0x00030AE0
		[Token(Token = "0x6006FC5")]
		[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0")]
		public bool ShouldSerializerl04()
		{
			return default(bool);
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x000328F8 File Offset: 0x00030AF8
		[Token(Token = "0x6006FC6")]
		[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0")]
		public bool ShouldSerializerl05()
		{
			return default(bool);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicCustomizeData()
		{
		}

		// Token: 0x04006218 RID: 25112
		[Token(Token = "0x4006218")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "rogue_1")]
		public RL01CustomizeData rl01;

		// Token: 0x04006219 RID: 25113
		[Token(Token = "0x4006219")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "rogue_2")]
		public RL02CustomizeData rl02;

		// Token: 0x0400621A RID: 25114
		[Token(Token = "0x400621A")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty(PropertyName = "rogue_3")]
		public RL03CustomizeData rl03;

		// Token: 0x0400621B RID: 25115
		[Token(Token = "0x400621B")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty(PropertyName = "rogue_4")]
		public RL04CustomizeData rl04;

		// Token: 0x0400621C RID: 25116
		[Token(Token = "0x400621C")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty(PropertyName = "rogue_5")]
		public RL05CustomizeData rl05;
	}
}
