using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012C2 RID: 4802
	[Token(Token = "0x20012C2")]
	public class SandboxV2EventData
	{
		// Token: 0x0600723B RID: 29243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2EventData()
		{
		}

		// Token: 0x04006A16 RID: 27158
		[Token(Token = "0x4006A16")]
		[FieldOffset(Offset = "0x10")]
		public string eventId;

		// Token: 0x04006A17 RID: 27159
		[Token(Token = "0x4006A17")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2EventType type;

		// Token: 0x04006A18 RID: 27160
		[Token(Token = "0x4006A18")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x04006A19 RID: 27161
		[Token(Token = "0x4006A19")]
		[FieldOffset(Offset = "0x28")]
		public string iconName;

		// Token: 0x04006A1A RID: 27162
		[Token(Token = "0x4006A1A")]
		[FieldOffset(Offset = "0x30")]
		public string enterSceneId;
	}
}
