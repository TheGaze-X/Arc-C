using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200555E RID: 21854
	[Token(Token = "0x200555E")]
	public class RL03RewardItemExtraInfoPlugin : RoguelikeRewardItemExtraInfoPlugin
	{
		// Token: 0x060201FC RID: 131580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60201FC")]
		[Address(RVA = "0x1A31B20", Offset = "0x1A30720", VA = "0x181A31B20", Slot = "4")]
		public override RoguelikeRewardExtraInfoFactory GetExtraInfoFactory()
		{
			return null;
		}

		// Token: 0x060201FD RID: 131581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201FD")]
		[Address(RVA = "0x1A31C00", Offset = "0x1A30800", VA = "0x181A31C00")]
		public RL03RewardItemExtraInfoPlugin()
		{
		}

		// Token: 0x060201FE RID: 131582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60201FE")]
		[Address(RVA = "0x1A31BF0", Offset = "0x1A307F0", VA = "0x181A31BF0")]
		private RoguelikeRewardExtraInfoFactory <>xLuaBaseProxy_GetExtraInfoFactory()
		{
			return null;
		}

		// Token: 0x0402B65B RID: 177755
		[Token(Token = "0x402B65B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExtraInfoFactory;

		// Token: 0x0402B65C RID: 177756
		[Token(Token = "0x402B65C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
