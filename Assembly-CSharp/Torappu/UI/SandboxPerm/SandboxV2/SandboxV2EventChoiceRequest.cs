using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043D2 RID: 17362
	[Token(Token = "0x20043D2")]
	public class SandboxV2EventChoiceRequest
	{
		// Token: 0x0601A97D RID: 108925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A97D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2EventChoiceRequest()
		{
		}

		// Token: 0x04021E60 RID: 138848
		[Token(Token = "0x4021E60")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E61 RID: 138849
		[Token(Token = "0x4021E61")]
		[FieldOffset(Offset = "0x18")]
		public string nodeId;

		// Token: 0x04021E62 RID: 138850
		[Token(Token = "0x4021E62")]
		[FieldOffset(Offset = "0x20")]
		public string eventId;

		// Token: 0x04021E63 RID: 138851
		[Token(Token = "0x4021E63")]
		[FieldOffset(Offset = "0x28")]
		public string choiceId;
	}
}
