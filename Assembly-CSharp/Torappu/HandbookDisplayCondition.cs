using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200109D RID: 4253
	[Token(Token = "0x200109D")]
	[Serializable]
	public class HandbookDisplayCondition
	{
		// Token: 0x06006E29 RID: 28201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E29")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandbookDisplayCondition()
		{
		}

		// Token: 0x04005ABC RID: 23228
		[Token(Token = "0x4005ABC")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04005ABD RID: 23229
		[Token(Token = "0x4005ABD")]
		[FieldOffset(Offset = "0x18")]
		public string conditionCharId;

		// Token: 0x04005ABE RID: 23230
		[Token(Token = "0x4005ABE")]
		[FieldOffset(Offset = "0x20")]
		public HandbookDisplayCondition.DisplayType type;

		// Token: 0x0200109E RID: 4254
		[Token(Token = "0x200109E")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DisplayType
		{
			// Token: 0x04005AC0 RID: 23232
			[Token(Token = "0x4005AC0")]
			DISPLAY_IF_CHAREXIST,
			// Token: 0x04005AC1 RID: 23233
			[Token(Token = "0x4005AC1")]
			INVISIBLE_IF_CHAREXIST
		}
	}
}
