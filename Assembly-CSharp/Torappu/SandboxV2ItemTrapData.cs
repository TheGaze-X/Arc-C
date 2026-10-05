using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001299 RID: 4761
	[Token(Token = "0x2001299")]
	public class SandboxV2ItemTrapData
	{
		// Token: 0x06007211 RID: 29201 RVA: 0x00032C28 File Offset: 0x00030E28
		[Token(Token = "0x6007211")]
		[Address(RVA = "0x1FF9C40", Offset = "0x1FF8840", VA = "0x181FF9C40")]
		public bool ShouldSerializebuffId()
		{
			return default(bool);
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007212")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ItemTrapData()
		{
		}

		// Token: 0x040068EC RID: 26860
		[Token(Token = "0x40068EC")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x040068ED RID: 26861
		[Token(Token = "0x40068ED")]
		[FieldOffset(Offset = "0x18")]
		public string trapId;

		// Token: 0x040068EE RID: 26862
		[Token(Token = "0x40068EE")]
		[FieldOffset(Offset = "0x20")]
		public int trapPhase;

		// Token: 0x040068EF RID: 26863
		[Token(Token = "0x40068EF")]
		[FieldOffset(Offset = "0x24")]
		public int trapLevel;

		// Token: 0x040068F0 RID: 26864
		[Token(Token = "0x40068F0")]
		[FieldOffset(Offset = "0x28")]
		public int skillIndex;

		// Token: 0x040068F1 RID: 26865
		[Token(Token = "0x40068F1")]
		[FieldOffset(Offset = "0x2C")]
		public int skillLevel;

		// Token: 0x040068F2 RID: 26866
		[Token(Token = "0x40068F2")]
		[FieldOffset(Offset = "0x30")]
		public int buildingLevel;

		// Token: 0x040068F3 RID: 26867
		[Token(Token = "0x40068F3")]
		[FieldOffset(Offset = "0x38")]
		public string updatedItemId;

		// Token: 0x040068F4 RID: 26868
		[Token(Token = "0x40068F4")]
		[FieldOffset(Offset = "0x40")]
		public string minLevelItemId;

		// Token: 0x040068F5 RID: 26869
		[Token(Token = "0x40068F5")]
		[FieldOffset(Offset = "0x48")]
		public string baseItemName;

		// Token: 0x040068F6 RID: 26870
		[Token(Token = "0x40068F6")]
		[FieldOffset(Offset = "0x50")]
		public SandboxV2TrapItemType itemType;

		// Token: 0x040068F7 RID: 26871
		[Token(Token = "0x40068F7")]
		[FieldOffset(Offset = "0x54")]
		public SandboxV2ItemTrapTag itemTag;

		// Token: 0x040068F8 RID: 26872
		[Token(Token = "0x40068F8")]
		[FieldOffset(Offset = "0x58")]
		public string buffId;
	}
}
