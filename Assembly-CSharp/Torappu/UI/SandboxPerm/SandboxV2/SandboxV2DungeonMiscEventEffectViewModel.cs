using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042A7 RID: 17063
	[Token(Token = "0x20042A7")]
	public class SandboxV2DungeonMiscEventEffectViewModel : IHotfixable
	{
		// Token: 0x0601A45A RID: 107610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A45A")]
		[Address(RVA = "0x132FCA0", Offset = "0x132E8A0", VA = "0x18132FCA0")]
		public void LoadData(SandboxV2Data topicDetailData, PlayerSandboxV2.Dungeon playerDungeonData)
		{
		}

		// Token: 0x0601A45B RID: 107611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A45B")]
		[Address(RVA = "0x132FEF0", Offset = "0x132EAF0", VA = "0x18132FEF0")]
		public SandboxV2DungeonMiscEventEffectViewModel()
		{
		}

		// Token: 0x0402146D RID: 136301
		[Token(Token = "0x402146D")]
		[FieldOffset(Offset = "0x10")]
		public List<SandboxV2DungeonMiscEventEffectItemViewModel> eventEffects;

		// Token: 0x0402146E RID: 136302
		[Token(Token = "0x402146E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402146F RID: 136303
		[Token(Token = "0x402146F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
