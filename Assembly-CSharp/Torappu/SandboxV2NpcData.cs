using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012B5 RID: 4789
	[Token(Token = "0x20012B5")]
	public class SandboxV2NpcData
	{
		// Token: 0x06007234 RID: 29236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007234")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2NpcData()
		{
		}

		// Token: 0x040069CE RID: 27086
		[Token(Token = "0x40069CE")]
		[FieldOffset(Offset = "0x10")]
		public string npcId;

		// Token: 0x040069CF RID: 27087
		[Token(Token = "0x40069CF")]
		[FieldOffset(Offset = "0x18")]
		public string trapId;

		// Token: 0x040069D0 RID: 27088
		[Token(Token = "0x40069D0")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2NpcType npcType;

		// Token: 0x040069D1 RID: 27089
		[Token(Token = "0x40069D1")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<BattleDialogType, string> dialogIds;

		// Token: 0x040069D2 RID: 27090
		[Token(Token = "0x40069D2")]
		[FieldOffset(Offset = "0x30")]
		public List<int> npcLocation;

		// Token: 0x040069D3 RID: 27091
		[Token(Token = "0x40069D3")]
		[FieldOffset(Offset = "0x38")]
		public SharedConsts.Direction npcOrientation;

		// Token: 0x040069D4 RID: 27092
		[Token(Token = "0x40069D4")]
		[FieldOffset(Offset = "0x40")]
		public string picId;

		// Token: 0x040069D5 RID: 27093
		[Token(Token = "0x40069D5")]
		[FieldOffset(Offset = "0x48")]
		public string picName;

		// Token: 0x040069D6 RID: 27094
		[Token(Token = "0x40069D6")]
		[FieldOffset(Offset = "0x50")]
		public bool showPic;

		// Token: 0x040069D7 RID: 27095
		[Token(Token = "0x40069D7")]
		[FieldOffset(Offset = "0x54")]
		public int reactSkillIndex;
	}
}
