using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024A7 RID: 9383
	[Token(Token = "0x20024A7")]
	public class Act6FunMainEnemyHudPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x0600F133 RID: 61747 RVA: 0x00058E90 File Offset: 0x00057090
		[Token(Token = "0x17001F5C")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F133")]
			[Address(RVA = "0x682000", Offset = "0x680C00", VA = "0x180682000", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x0600F134 RID: 61748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F134")]
		[Address(RVA = "0x681D90", Offset = "0x680990", VA = "0x180681D90", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F135 RID: 61749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F135")]
		[Address(RVA = "0x681B60", Offset = "0x680760", VA = "0x180681B60", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F136 RID: 61750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F136")]
		[Address(RVA = "0x681C60", Offset = "0x680860", VA = "0x180681C60", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F137 RID: 61751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F137")]
		[Address(RVA = "0x681EB0", Offset = "0x680AB0", VA = "0x180681EB0")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F138 RID: 61752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F138")]
		[Address(RVA = "0x681F60", Offset = "0x680B60", VA = "0x180681F60")]
		public Act6FunMainEnemyHudPluginTalent()
		{
		}

		// Token: 0x0600F139 RID: 61753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F139")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F13A RID: 61754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F13A")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010AED RID: 68333
		[Token(Token = "0x4010AED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010AEE RID: 68334
		[Token(Token = "0x4010AEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010AEF RID: 68335
		[Token(Token = "0x4010AEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010AF0 RID: 68336
		[Token(Token = "0x4010AF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010AF1 RID: 68337
		[Token(Token = "0x4010AF1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010AF2 RID: 68338
		[Token(Token = "0x4010AF2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
