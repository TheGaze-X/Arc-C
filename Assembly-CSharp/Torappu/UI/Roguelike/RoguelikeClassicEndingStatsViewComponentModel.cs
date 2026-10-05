using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052BA RID: 21178
	[Token(Token = "0x20052BA")]
	public abstract class RoguelikeClassicEndingStatsViewComponentModel : IHotfixable
	{
		// Token: 0x0601F3C5 RID: 127941
		[Token(Token = "0x601F3C5")]
		public abstract void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result);

		// Token: 0x0601F3C6 RID: 127942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3C6")]
		[Address(RVA = "0x18F6940", Offset = "0x18F5540", VA = "0x1818F6940")]
		protected RoguelikeClassicEndingStatsViewComponentModel()
		{
		}

		// Token: 0x04029F35 RID: 171829
		[Token(Token = "0x4029F35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
