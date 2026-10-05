using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200137D RID: 4989
	[Token(Token = "0x200137D")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StorylineStorySetType
	{
		// Token: 0x04006EB3 RID: 28339
		[Token(Token = "0x4006EB3")]
		MAINLINE,
		// Token: 0x04006EB4 RID: 28340
		[Token(Token = "0x4006EB4")]
		SS,
		// Token: 0x04006EB5 RID: 28341
		[Token(Token = "0x4006EB5")]
		COLLECT
	}
}
