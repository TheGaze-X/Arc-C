using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024B7 RID: 9399
	[Token(Token = "0x20024B7")]
	public class SandboxHudPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x0600F1D9 RID: 61913 RVA: 0x00059208 File Offset: 0x00057408
		[Token(Token = "0x17001F7E")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F1D9")]
			[Address(RVA = "0x695D40", Offset = "0x694940", VA = "0x180695D40", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x0600F1DA RID: 61914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F1DA")]
		[Address(RVA = "0x695B10", Offset = "0x694710", VA = "0x180695B10", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F1DB RID: 61915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1DB")]
		[Address(RVA = "0x6958E0", Offset = "0x6944E0", VA = "0x1806958E0", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F1DC RID: 61916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1DC")]
		[Address(RVA = "0x6959E0", Offset = "0x6945E0", VA = "0x1806959E0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F1DD RID: 61917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1DD")]
		[Address(RVA = "0x695BF0", Offset = "0x6947F0", VA = "0x180695BF0")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F1DE RID: 61918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1DE")]
		[Address(RVA = "0x695CA0", Offset = "0x6948A0", VA = "0x180695CA0")]
		public SandboxHudPluginTalent()
		{
		}

		// Token: 0x0600F1DF RID: 61919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1DF")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F1E0 RID: 61920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1E0")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010BA6 RID: 68518
		[Token(Token = "0x4010BA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010BA7 RID: 68519
		[Token(Token = "0x4010BA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010BA8 RID: 68520
		[Token(Token = "0x4010BA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010BA9 RID: 68521
		[Token(Token = "0x4010BA9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010BAA RID: 68522
		[Token(Token = "0x4010BAA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010BAB RID: 68523
		[Token(Token = "0x4010BAB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
