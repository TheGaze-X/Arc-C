using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012EE RID: 4846
	[Token(Token = "0x20012EE")]
	public class SandboxV2RacerTalentInfo
	{
		// Token: 0x06007267 RID: 29287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007267")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RacerTalentInfo()
		{
		}

		// Token: 0x04006B07 RID: 27399
		[Token(Token = "0x4006B07")]
		[FieldOffset(Offset = "0x10")]
		public string talentId;

		// Token: 0x04006B08 RID: 27400
		[Token(Token = "0x4006B08")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2RacerTalentType talentType;

		// Token: 0x04006B09 RID: 27401
		[Token(Token = "0x4006B09")]
		[FieldOffset(Offset = "0x20")]
		public string talentIconId;

		// Token: 0x04006B0A RID: 27402
		[Token(Token = "0x4006B0A")]
		[FieldOffset(Offset = "0x28")]
		public string desc;
	}
}
