using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056A8 RID: 22184
	[Token(Token = "0x20056A8")]
	public class RL04BGMModule : RoguelikeBGMModule, IHotfixable
	{
		// Token: 0x06020891 RID: 133265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020891")]
		[Address(RVA = "0x1AA4180", Offset = "0x1AA2D80", VA = "0x181AA4180", Slot = "8")]
		protected override void OnTriggerSignal()
		{
		}

		// Token: 0x06020892 RID: 133266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020892")]
		[Address(RVA = "0x1AA43E0", Offset = "0x1AA2FE0", VA = "0x181AA43E0")]
		public RL04BGMModule()
		{
		}

		// Token: 0x0402C155 RID: 180565
		[Token(Token = "0x402C155")]
		private const int DUNGEON_BGM_DEEP_FLOOR = 3;

		// Token: 0x0402C156 RID: 180566
		[Token(Token = "0x402C156")]
		private const int DUNGEON_BGM_BOSS_FLOOR = 6;

		// Token: 0x0402C157 RID: 180567
		[Token(Token = "0x402C157")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTriggerSignal;

		// Token: 0x0402C158 RID: 180568
		[Token(Token = "0x402C158")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
