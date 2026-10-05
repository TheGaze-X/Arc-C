using System;
using Il2CppDummyDll;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005151 RID: 20817
	[Token(Token = "0x2005151")]
	public class DeepSeaCompleteStoryRequest
	{
		// Token: 0x0601EC73 RID: 126067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC73")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeepSeaCompleteStoryRequest()
		{
		}

		// Token: 0x04029430 RID: 169008
		[Token(Token = "0x4029430")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04029431 RID: 169009
		[Token(Token = "0x4029431")]
		[FieldOffset(Offset = "0x18")]
		public string placeId;

		// Token: 0x04029432 RID: 169010
		[Token(Token = "0x4029432")]
		[FieldOffset(Offset = "0x20")]
		public string nodeId;

		// Token: 0x04029433 RID: 169011
		[Token(Token = "0x4029433")]
		[FieldOffset(Offset = "0x28")]
		public string storyKey;
	}
}
