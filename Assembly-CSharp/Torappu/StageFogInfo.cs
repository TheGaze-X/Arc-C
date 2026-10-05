using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200134B RID: 4939
	[Token(Token = "0x200134B")]
	public class StageFogInfo
	{
		// Token: 0x06007308 RID: 29448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007308")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StageFogInfo()
		{
		}

		// Token: 0x04006D78 RID: 28024
		[Token(Token = "0x4006D78")]
		[FieldOffset(Offset = "0x10")]
		public string lockId;

		// Token: 0x04006D79 RID: 28025
		[Token(Token = "0x4006D79")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public FogType fogType;

		// Token: 0x04006D7A RID: 28026
		[Token(Token = "0x4006D7A")]
		[FieldOffset(Offset = "0x1C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public StageButtonInFogRenderType stageButtonInFogRenderType;

		// Token: 0x04006D7B RID: 28027
		[Token(Token = "0x4006D7B")]
		[FieldOffset(Offset = "0x20")]
		public string stageId;

		// Token: 0x04006D7C RID: 28028
		[Token(Token = "0x4006D7C")]
		[FieldOffset(Offset = "0x28")]
		public string lockName;

		// Token: 0x04006D7D RID: 28029
		[Token(Token = "0x4006D7D")]
		[FieldOffset(Offset = "0x30")]
		public string lockDesc;

		// Token: 0x04006D7E RID: 28030
		[Token(Token = "0x4006D7E")]
		[FieldOffset(Offset = "0x38")]
		public string unlockItemId;

		// Token: 0x04006D7F RID: 28031
		[Token(Token = "0x4006D7F")]
		[FieldOffset(Offset = "0x40")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType unlockItemType;

		// Token: 0x04006D80 RID: 28032
		[Token(Token = "0x4006D80")]
		[FieldOffset(Offset = "0x44")]
		public int unlockItemNum;

		// Token: 0x04006D81 RID: 28033
		[Token(Token = "0x4006D81")]
		[FieldOffset(Offset = "0x48")]
		public string preposedStageId;

		// Token: 0x04006D82 RID: 28034
		[Token(Token = "0x4006D82")]
		[FieldOffset(Offset = "0x50")]
		public string preposedLockId;
	}
}
