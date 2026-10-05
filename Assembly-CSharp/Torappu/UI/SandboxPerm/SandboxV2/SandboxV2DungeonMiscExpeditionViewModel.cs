using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042A2 RID: 17058
	[Token(Token = "0x20042A2")]
	public class SandboxV2DungeonMiscExpeditionViewModel : IHotfixable
	{
		// Token: 0x0601A44E RID: 107598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A44E")]
		[Address(RVA = "0x13300B0", Offset = "0x132ECB0", VA = "0x1813300B0")]
		public void LoadData(SandboxV2Data topicDetailData, PlayerSandboxV2 playerTopicData)
		{
		}

		// Token: 0x0601A44F RID: 107599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A44F")]
		[Address(RVA = "0x13304B0", Offset = "0x132F0B0", VA = "0x1813304B0")]
		public SandboxV2DungeonMiscExpeditionViewModel()
		{
		}

		// Token: 0x04021450 RID: 136272
		[Token(Token = "0x4021450")]
		[FieldOffset(Offset = "0x10")]
		public List<SandboxV2DungeonMiscExpeditionItemViewModel> expeditions;

		// Token: 0x04021451 RID: 136273
		[Token(Token = "0x4021451")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021452 RID: 136274
		[Token(Token = "0x4021452")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
