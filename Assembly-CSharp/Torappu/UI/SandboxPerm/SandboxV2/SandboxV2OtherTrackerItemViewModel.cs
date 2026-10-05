using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200422E RID: 16942
	[Token(Token = "0x200422E")]
	public class SandboxV2OtherTrackerItemViewModel
	{
		// Token: 0x0601A20C RID: 107020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A20C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2OtherTrackerItemViewModel()
		{
		}

		// Token: 0x04020FC0 RID: 135104
		[Token(Token = "0x4020FC0")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04020FC1 RID: 135105
		[Token(Token = "0x4020FC1")]
		[FieldOffset(Offset = "0x18")]
		public string uniqueId;

		// Token: 0x04020FC2 RID: 135106
		[Token(Token = "0x4020FC2")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x04020FC3 RID: 135107
		[Token(Token = "0x4020FC3")]
		[FieldOffset(Offset = "0x28")]
		public string iconName;

		// Token: 0x04020FC4 RID: 135108
		[Token(Token = "0x4020FC4")]
		[FieldOffset(Offset = "0x30")]
		public SandboxV2FloatAppearanceType appearanceType;

		// Token: 0x04020FC5 RID: 135109
		[Token(Token = "0x4020FC5")]
		[FieldOffset(Offset = "0x34")]
		public SandboxV2QuestLineBadgeType badgeType;
	}
}
