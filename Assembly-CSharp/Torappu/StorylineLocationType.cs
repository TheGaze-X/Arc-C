using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200137A RID: 4986
	[Token(Token = "0x200137A")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StorylineLocationType
	{
		// Token: 0x04006EA4 RID: 28324
		[Token(Token = "0x4006EA4")]
		STORY_SET,
		// Token: 0x04006EA5 RID: 28325
		[Token(Token = "0x4006EA5")]
		BEFORE,
		// Token: 0x04006EA6 RID: 28326
		[Token(Token = "0x4006EA6")]
		AFTER,
		// Token: 0x04006EA7 RID: 28327
		[Token(Token = "0x4006EA7")]
		MAINLINE_SPLIT
	}
}
