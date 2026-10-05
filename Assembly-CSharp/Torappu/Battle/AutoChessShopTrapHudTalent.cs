using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024A8 RID: 9384
	[Token(Token = "0x20024A8")]
	public class AutoChessShopTrapHudTalent : UIPluginTalent
	{
		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x0600F13B RID: 61755 RVA: 0x00058EA8 File Offset: 0x000570A8
		[Token(Token = "0x17001F5D")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F13B")]
			[Address(RVA = "0x683860", Offset = "0x682460", VA = "0x180683860", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x0600F13C RID: 61756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F13C")]
		[Address(RVA = "0x6836A0", Offset = "0x6822A0", VA = "0x1806836A0", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F13D RID: 61757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F13D")]
		[Address(RVA = "0x683470", Offset = "0x682070", VA = "0x180683470", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F13E RID: 61758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F13E")]
		[Address(RVA = "0x683570", Offset = "0x682170", VA = "0x180683570", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F13F RID: 61759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F13F")]
		[Address(RVA = "0x683710", Offset = "0x682310", VA = "0x180683710")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F140 RID: 61760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F140")]
		[Address(RVA = "0x6837C0", Offset = "0x6823C0", VA = "0x1806837C0")]
		public AutoChessShopTrapHudTalent()
		{
		}

		// Token: 0x0600F141 RID: 61761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F141")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F142 RID: 61762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F142")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010AF3 RID: 68339
		[Token(Token = "0x4010AF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010AF4 RID: 68340
		[Token(Token = "0x4010AF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010AF5 RID: 68341
		[Token(Token = "0x4010AF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010AF6 RID: 68342
		[Token(Token = "0x4010AF6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010AF7 RID: 68343
		[Token(Token = "0x4010AF7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010AF8 RID: 68344
		[Token(Token = "0x4010AF8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
