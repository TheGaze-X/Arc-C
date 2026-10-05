using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200107D RID: 4221
	[Token(Token = "0x200107D")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GachaRuleType
	{
		// Token: 0x040059B4 RID: 22964
		[Token(Token = "0x40059B4")]
		NORMAL,
		// Token: 0x040059B5 RID: 22965
		[Token(Token = "0x40059B5")]
		LIMITED,
		// Token: 0x040059B6 RID: 22966
		[Token(Token = "0x40059B6")]
		LINKAGE,
		// Token: 0x040059B7 RID: 22967
		[Token(Token = "0x40059B7")]
		ATTAIN,
		// Token: 0x040059B8 RID: 22968
		[Token(Token = "0x40059B8")]
		CLASSIC,
		// Token: 0x040059B9 RID: 22969
		[Token(Token = "0x40059B9")]
		SINGLE,
		// Token: 0x040059BA RID: 22970
		[Token(Token = "0x40059BA")]
		FESCLASSIC,
		// Token: 0x040059BB RID: 22971
		[Token(Token = "0x40059BB")]
		CLASSIC_ATTAIN,
		// Token: 0x040059BC RID: 22972
		[Token(Token = "0x40059BC")]
		SPECIAL,
		// Token: 0x040059BD RID: 22973
		[Token(Token = "0x40059BD")]
		DOUBLE,
		// Token: 0x040059BE RID: 22974
		[Token(Token = "0x40059BE")]
		CLASSIC_DOUBLE,
		// Token: 0x040059BF RID: 22975
		[Token(Token = "0x40059BF")]
		BACKFLOW
	}
}
