using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054F0 RID: 21744
	[Token(Token = "0x20054F0")]
	public abstract class RoguelikeGoodsObjIconView : RoguelikeGoodsObjPlugin
	{
		// Token: 0x17004AFB RID: 19195
		// (get) Token: 0x0601FFC0 RID: 131008 RVA: 0x000B41C8 File Offset: 0x000B23C8
		[Token(Token = "0x17004AFB")]
		public override RoguelikeShopGoodPluginType pluginType
		{
			[Token(Token = "0x601FFC0")]
			[Address(RVA = "0x1A1BD50", Offset = "0x1A1A950", VA = "0x181A1BD50", Slot = "4")]
			get
			{
				return RoguelikeShopGoodPluginType.NONE;
			}
		}

		// Token: 0x0601FFC1 RID: 131009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFC1")]
		[Address(RVA = "0x1A1BCB0", Offset = "0x1A1A8B0", VA = "0x181A1BCB0")]
		protected RoguelikeGoodsObjIconView()
		{
		}

		// Token: 0x0402B27F RID: 176767
		[Token(Token = "0x402B27F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pluginType;

		// Token: 0x0402B280 RID: 176768
		[Token(Token = "0x402B280")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
