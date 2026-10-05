using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024B1 RID: 9393
	[Token(Token = "0x20024B1")]
	public class LpeoplFearHudPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x0600F195 RID: 61845 RVA: 0x00058FF8 File Offset: 0x000571F8
		[Token(Token = "0x17001F6D")]
		public FP fearRatio
		{
			[Token(Token = "0x600F195")]
			[Address(RVA = "0x68EF60", Offset = "0x68DB60", VA = "0x18068EF60")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x0600F196 RID: 61846 RVA: 0x00059010 File Offset: 0x00057210
		[Token(Token = "0x17001F6E")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F196")]
			[Address(RVA = "0x68EFD0", Offset = "0x68DBD0", VA = "0x18068EFD0", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x0600F197 RID: 61847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F197")]
		[Address(RVA = "0x68EAE0", Offset = "0x68D6E0", VA = "0x18068EAE0", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F198 RID: 61848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F198")]
		[Address(RVA = "0x68EBE0", Offset = "0x68D7E0", VA = "0x18068EBE0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F199 RID: 61849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F199")]
		[Address(RVA = "0x68EE10", Offset = "0x68DA10", VA = "0x18068EE10")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F19A RID: 61850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F19A")]
		[Address(RVA = "0x68ED10", Offset = "0x68D910", VA = "0x18068ED10", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F19B RID: 61851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F19B")]
		[Address(RVA = "0x68EEC0", Offset = "0x68DAC0", VA = "0x18068EEC0")]
		public LpeoplFearHudPluginTalent()
		{
		}

		// Token: 0x0600F19C RID: 61852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F19C")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F19D RID: 61853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F19D")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010B4F RID: 68431
		[Token(Token = "0x4010B4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fearRatio;

		// Token: 0x04010B50 RID: 68432
		[Token(Token = "0x4010B50")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010B51 RID: 68433
		[Token(Token = "0x4010B51")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010B52 RID: 68434
		[Token(Token = "0x4010B52")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010B53 RID: 68435
		[Token(Token = "0x4010B53")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010B54 RID: 68436
		[Token(Token = "0x4010B54")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010B55 RID: 68437
		[Token(Token = "0x4010B55")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
