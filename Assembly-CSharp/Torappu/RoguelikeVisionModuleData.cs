using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200119D RID: 4509
	[Token(Token = "0x200119D")]
	public class RoguelikeVisionModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06006F8B RID: 28555 RVA: 0x00032700 File Offset: 0x00030900
		[Token(Token = "0x17000D3F")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006F8B")]
			[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F8C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeVisionModuleData()
		{
		}

		// Token: 0x04006094 RID: 24724
		[Token(Token = "0x4006094")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, RoguelikeVisionData> visionDatas;

		// Token: 0x04006095 RID: 24725
		[Token(Token = "0x4006095")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeVisionModuleData.VisionChoiceConfig> visionChoices;

		// Token: 0x04006096 RID: 24726
		[Token(Token = "0x4006096")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeVisionModuleConsts moduleConsts;

		// Token: 0x0200119E RID: 4510
		[Token(Token = "0x200119E")]
		public enum VisionChoiceCheckType
		{
			// Token: 0x04006098 RID: 24728
			[Token(Token = "0x4006098")]
			LOWER,
			// Token: 0x04006099 RID: 24729
			[Token(Token = "0x4006099")]
			UPPER
		}

		// Token: 0x0200119F RID: 4511
		[Token(Token = "0x200119F")]
		public class VisionChoiceConfig
		{
			// Token: 0x06006F8D RID: 28557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F8D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VisionChoiceConfig()
			{
			}

			// Token: 0x0400609A RID: 24730
			[Token(Token = "0x400609A")]
			[FieldOffset(Offset = "0x10")]
			public int value;

			// Token: 0x0400609B RID: 24731
			[Token(Token = "0x400609B")]
			[FieldOffset(Offset = "0x14")]
			public RoguelikeVisionModuleData.VisionChoiceCheckType type;
		}
	}
}
