using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011D4 RID: 4564
	[Token(Token = "0x20011D4")]
	public struct RoguelikeTopicConfig
	{
		// Token: 0x06006FB8 RID: 28600 RVA: 0x000327F0 File Offset: 0x000309F0
		[Token(Token = "0x6006FB8")]
		[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
		public bool ShouldSerializeloadCharCardPlugin()
		{
			return default(bool);
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x00032808 File Offset: 0x00030A08
		[Token(Token = "0x6006FB9")]
		[Address(RVA = "0x2112CD0", Offset = "0x21118D0", VA = "0x182112CD0")]
		public bool ShouldSerializewebBusType()
		{
			return default(bool);
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x00032820 File Offset: 0x00030A20
		[Token(Token = "0x6006FBA")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
		public RoguelikeMonthChatTrigType GetMonthChatTrigType()
		{
			return RoguelikeMonthChatTrigType.NONE;
		}

		// Token: 0x040061C1 RID: 25025
		[Token(Token = "0x40061C1")]
		[FieldOffset(Offset = "0x0")]
		public bool loadCharCardPlugin;

		// Token: 0x040061C2 RID: 25026
		[Token(Token = "0x40061C2")]
		[FieldOffset(Offset = "0x8")]
		public string webBusType;

		// Token: 0x040061C3 RID: 25027
		[Token(Token = "0x40061C3")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeMonthChatTrigType monthChatTrigType;

		// Token: 0x040061C4 RID: 25028
		[Token(Token = "0x40061C4")]
		[FieldOffset(Offset = "0x14")]
		public bool loadRewardHpDecoPlugin;

		// Token: 0x040061C5 RID: 25029
		[Token(Token = "0x40061C5")]
		[FieldOffset(Offset = "0x15")]
		public bool loadRewardExtraInfoPlugin;
	}
}
