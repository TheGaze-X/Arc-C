using System;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024AD RID: 9389
	[Token(Token = "0x20024AD")]
	public class EnergyHudPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x0600F167 RID: 61799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F62")]
		public EnergyBuffAbility energyBuffAbility
		{
			[Token(Token = "0x600F167")]
			[Address(RVA = "0x68C7F0", Offset = "0x68B3F0", VA = "0x18068C7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x0600F168 RID: 61800 RVA: 0x00058F38 File Offset: 0x00057138
		[Token(Token = "0x17001F63")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F168")]
			[Address(RVA = "0x68C850", Offset = "0x68B450", VA = "0x18068C850", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x0600F169 RID: 61801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F169")]
		[Address(RVA = "0x68C270", Offset = "0x68AE70", VA = "0x18068C270", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F16A RID: 61802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F16A")]
		[Address(RVA = "0x68C460", Offset = "0x68B060", VA = "0x18068C460", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F16B RID: 61803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F16B")]
		[Address(RVA = "0x68C6A0", Offset = "0x68B2A0", VA = "0x18068C6A0")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F16C RID: 61804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F16C")]
		[Address(RVA = "0x68C5A0", Offset = "0x68B1A0", VA = "0x18068C5A0", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F16D RID: 61805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F16D")]
		[Address(RVA = "0x68C750", Offset = "0x68B350", VA = "0x18068C750")]
		public EnergyHudPluginTalent()
		{
		}

		// Token: 0x0600F16E RID: 61806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F16E")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F16F RID: 61807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F16F")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010B1F RID: 68383
		[Token(Token = "0x4010B1F")]
		[FieldOffset(Offset = "0x68")]
		private EnergyBuffAbility _energyBuffAbility;

		// Token: 0x04010B20 RID: 68384
		[Token(Token = "0x4010B20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_energyBuffAbility;

		// Token: 0x04010B21 RID: 68385
		[Token(Token = "0x4010B21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010B22 RID: 68386
		[Token(Token = "0x4010B22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010B23 RID: 68387
		[Token(Token = "0x4010B23")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010B24 RID: 68388
		[Token(Token = "0x4010B24")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010B25 RID: 68389
		[Token(Token = "0x4010B25")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010B26 RID: 68390
		[Token(Token = "0x4010B26")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
