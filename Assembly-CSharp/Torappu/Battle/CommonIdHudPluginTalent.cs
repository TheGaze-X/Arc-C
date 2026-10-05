using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024AB RID: 9387
	[Token(Token = "0x20024AB")]
	public class CommonIdHudPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x0600F156 RID: 61782 RVA: 0x00058F08 File Offset: 0x00057108
		[Token(Token = "0x17001F60")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F156")]
			[Address(RVA = "0x6878F0", Offset = "0x6864F0", VA = "0x1806878F0", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x0600F157 RID: 61783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F157")]
		[Address(RVA = "0x6876A0", Offset = "0x6862A0", VA = "0x1806876A0", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F158 RID: 61784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F158")]
		[Address(RVA = "0x687470", Offset = "0x686070", VA = "0x180687470", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F159 RID: 61785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F159")]
		[Address(RVA = "0x687570", Offset = "0x686170", VA = "0x180687570", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F15A RID: 61786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F15A")]
		[Address(RVA = "0x6877A0", Offset = "0x6863A0", VA = "0x1806877A0")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F15B RID: 61787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F15B")]
		[Address(RVA = "0x687850", Offset = "0x686450", VA = "0x180687850")]
		public CommonIdHudPluginTalent()
		{
		}

		// Token: 0x0600F15C RID: 61788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F15C")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F15D RID: 61789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F15D")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010B12 RID: 68370
		[Token(Token = "0x4010B12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010B13 RID: 68371
		[Token(Token = "0x4010B13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010B14 RID: 68372
		[Token(Token = "0x4010B14")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010B15 RID: 68373
		[Token(Token = "0x4010B15")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010B16 RID: 68374
		[Token(Token = "0x4010B16")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010B17 RID: 68375
		[Token(Token = "0x4010B17")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
