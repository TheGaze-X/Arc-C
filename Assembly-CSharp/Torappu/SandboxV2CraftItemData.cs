using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200129E RID: 4766
	[Token(Token = "0x200129E")]
	public class SandboxV2CraftItemData
	{
		// Token: 0x06007215 RID: 29205 RVA: 0x00032C40 File Offset: 0x00030E40
		[Token(Token = "0x6007215")]
		[Address(RVA = "0x220E7B0", Offset = "0x220D3B0", VA = "0x18220E7B0")]
		public bool ShouldSerializeisHidden()
		{
			return default(bool);
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007216")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2CraftItemData()
		{
		}

		// Token: 0x04006908 RID: 26888
		[Token(Token = "0x4006908")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04006909 RID: 26889
		[Token(Token = "0x4006909")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2CraftItemType type;

		// Token: 0x0400690A RID: 26890
		[Token(Token = "0x400690A")]
		[FieldOffset(Offset = "0x20")]
		public string buildingUnlockDesc;

		// Token: 0x0400690B RID: 26891
		[Token(Token = "0x400690B")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, int> materialItems;

		// Token: 0x0400690C RID: 26892
		[Token(Token = "0x400690C")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, int> upgradeItems;

		// Token: 0x0400690D RID: 26893
		[Token(Token = "0x400690D")]
		[FieldOffset(Offset = "0x38")]
		public int outputRatio;

		// Token: 0x0400690E RID: 26894
		[Token(Token = "0x400690E")]
		[FieldOffset(Offset = "0x3C")]
		public int withdrawRatio;

		// Token: 0x0400690F RID: 26895
		[Token(Token = "0x400690F")]
		[FieldOffset(Offset = "0x40")]
		public int repairCost;

		// Token: 0x04006910 RID: 26896
		[Token(Token = "0x4006910")]
		[FieldOffset(Offset = "0x44")]
		public bool isHidden;

		// Token: 0x04006911 RID: 26897
		[Token(Token = "0x4006911")]
		[FieldOffset(Offset = "0x48")]
		public string craftGroupId;

		// Token: 0x04006912 RID: 26898
		[Token(Token = "0x4006912")]
		[FieldOffset(Offset = "0x50")]
		public int recipeLevel;
	}
}
