using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02001026 RID: 4134
	[Token(Token = "0x2001026")]
	public class MagazineLeafItemData
	{
		// Token: 0x06006D77 RID: 28023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D77")]
		[Address(RVA = "0x21070B0", Offset = "0x2105CB0", VA = "0x1821070B0")]
		public MagazineLeafItemData()
		{
		}

		// Token: 0x040057C4 RID: 22468
		[Token(Token = "0x40057C4")]
		[FieldOffset(Offset = "0x10")]
		public string leafId;

		// Token: 0x040057C5 RID: 22469
		[Token(Token = "0x40057C5")]
		[FieldOffset(Offset = "0x18")]
		public MagazineLeafType leafType;

		// Token: 0x040057C6 RID: 22470
		[Token(Token = "0x40057C6")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x040057C7 RID: 22471
		[Token(Token = "0x40057C7")]
		[FieldOffset(Offset = "0x20")]
		public long startTime;

		// Token: 0x040057C8 RID: 22472
		[Token(Token = "0x40057C8")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x040057C9 RID: 22473
		[Token(Token = "0x40057C9")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x040057CA RID: 22474
		[Token(Token = "0x40057CA")]
		[FieldOffset(Offset = "0x38")]
		public string usage;

		// Token: 0x040057CB RID: 22475
		[Token(Token = "0x40057CB")]
		[FieldOffset(Offset = "0x40")]
		public string approach;

		// Token: 0x040057CC RID: 22476
		[Token(Token = "0x40057CC")]
		[FieldOffset(Offset = "0x48")]
		public ItemRarity rarity;

		// Token: 0x040057CD RID: 22477
		[Token(Token = "0x40057CD")]
		[FieldOffset(Offset = "0x50")]
		public string templateId;

		// Token: 0x040057CE RID: 22478
		[Token(Token = "0x40057CE")]
		[FieldOffset(Offset = "0x58")]
		public long templateStartTime;

		// Token: 0x040057CF RID: 22479
		[Token(Token = "0x40057CF")]
		[FieldOffset(Offset = "0x60")]
		public string templateColor;

		// Token: 0x040057D0 RID: 22480
		[Token(Token = "0x40057D0")]
		[FieldOffset(Offset = "0x68")]
		public Vector2 skinDefaultPos;

		// Token: 0x040057D1 RID: 22481
		[Token(Token = "0x40057D1")]
		[FieldOffset(Offset = "0x70")]
		public float skinDefaultScale;

		// Token: 0x040057D2 RID: 22482
		[Token(Token = "0x40057D2")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, int> leafDecorMaxNumMap;
	}
}
