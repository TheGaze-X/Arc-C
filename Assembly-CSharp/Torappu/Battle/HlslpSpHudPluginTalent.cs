using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024AF RID: 9391
	[Token(Token = "0x20024AF")]
	public class HlslpSpHudPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x0600F17F RID: 61823 RVA: 0x00058F68 File Offset: 0x00057168
		[Token(Token = "0x17001F65")]
		public FP spRatio
		{
			[Token(Token = "0x600F17F")]
			[Address(RVA = "0x68DD60", Offset = "0x68C960", VA = "0x18068DD60")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x0600F180 RID: 61824 RVA: 0x00058F80 File Offset: 0x00057180
		[Token(Token = "0x17001F66")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F180")]
			[Address(RVA = "0x68DDD0", Offset = "0x68C9D0", VA = "0x18068DDD0", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x0600F181 RID: 61825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F181")]
		[Address(RVA = "0x68D8E0", Offset = "0x68C4E0", VA = "0x18068D8E0", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F182 RID: 61826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F182")]
		[Address(RVA = "0x68D9E0", Offset = "0x68C5E0", VA = "0x18068D9E0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F183 RID: 61827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F183")]
		[Address(RVA = "0x68DC10", Offset = "0x68C810", VA = "0x18068DC10")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F184 RID: 61828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F184")]
		[Address(RVA = "0x68DB10", Offset = "0x68C710", VA = "0x18068DB10", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F185 RID: 61829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F185")]
		[Address(RVA = "0x68DCC0", Offset = "0x68C8C0", VA = "0x18068DCC0")]
		public HlslpSpHudPluginTalent()
		{
		}

		// Token: 0x0600F186 RID: 61830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F186")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F187 RID: 61831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F187")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010B3B RID: 68411
		[Token(Token = "0x4010B3B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_spRatio;

		// Token: 0x04010B3C RID: 68412
		[Token(Token = "0x4010B3C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010B3D RID: 68413
		[Token(Token = "0x4010B3D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010B3E RID: 68414
		[Token(Token = "0x4010B3E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010B3F RID: 68415
		[Token(Token = "0x4010B3F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010B40 RID: 68416
		[Token(Token = "0x4010B40")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010B41 RID: 68417
		[Token(Token = "0x4010B41")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
