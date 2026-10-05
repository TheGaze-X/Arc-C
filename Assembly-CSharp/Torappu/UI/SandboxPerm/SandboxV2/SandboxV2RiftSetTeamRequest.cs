using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043DC RID: 17372
	[Token(Token = "0x20043DC")]
	public class SandboxV2RiftSetTeamRequest
	{
		// Token: 0x0601A986 RID: 108934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A986")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RiftSetTeamRequest()
		{
		}

		// Token: 0x04021E7F RID: 138879
		[Token(Token = "0x4021E7F")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E80 RID: 138880
		[Token(Token = "0x4021E80")]
		[FieldOffset(Offset = "0x18")]
		public string team;
	}
}
