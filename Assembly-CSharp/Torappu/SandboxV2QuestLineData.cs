using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012BA RID: 4794
	[Token(Token = "0x20012BA")]
	public class SandboxV2QuestLineData
	{
		// Token: 0x06007236 RID: 29238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007236")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2QuestLineData()
		{
		}

		// Token: 0x040069EA RID: 27114
		[Token(Token = "0x40069EA")]
		[FieldOffset(Offset = "0x10")]
		public string questLineId;

		// Token: 0x040069EB RID: 27115
		[Token(Token = "0x40069EB")]
		[FieldOffset(Offset = "0x18")]
		public string questLineTitle;

		// Token: 0x040069EC RID: 27116
		[Token(Token = "0x40069EC")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2QuestLineType questLineType;

		// Token: 0x040069ED RID: 27117
		[Token(Token = "0x40069ED")]
		[FieldOffset(Offset = "0x24")]
		public SandboxV2QuestLineBadgeType questLineBadgeType;

		// Token: 0x040069EE RID: 27118
		[Token(Token = "0x40069EE")]
		[FieldOffset(Offset = "0x28")]
		public SandboxV2QuestLineScopeType questLineScopeType;

		// Token: 0x040069EF RID: 27119
		[Token(Token = "0x40069EF")]
		[FieldOffset(Offset = "0x30")]
		public string questLineDesc;

		// Token: 0x040069F0 RID: 27120
		[Token(Token = "0x40069F0")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;
	}
}
