using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024A9 RID: 9385
	[Token(Token = "0x20024A9")]
	public class BounceEnemyPhysicalFeatureTalent : UIPluginTalent
	{
		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x0600F143 RID: 61763 RVA: 0x00058EC0 File Offset: 0x000570C0
		[Token(Token = "0x17001F5E")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F143")]
			[Address(RVA = "0x685230", Offset = "0x683E30", VA = "0x180685230", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x0600F144 RID: 61764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F144")]
		[Address(RVA = "0x684740", Offset = "0x683340", VA = "0x180684740", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F145 RID: 61765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F145")]
		[Address(RVA = "0x684A10", Offset = "0x683610", VA = "0x180684A10", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F146 RID: 61766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F146")]
		[Address(RVA = "0x684B10", Offset = "0x683710", VA = "0x180684B10", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F147 RID: 61767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F147")]
		[Address(RVA = "0x684FB0", Offset = "0x683BB0", VA = "0x180684FB0")]
		protected void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F148 RID: 61768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F148")]
		[Address(RVA = "0x684C40", Offset = "0x683840", VA = "0x180684C40", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F149 RID: 61769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F149")]
		[Address(RVA = "0x684DF0", Offset = "0x6839F0", VA = "0x180684DF0")]
		public void Reset(bool resetPlugin = true)
		{
		}

		// Token: 0x0600F14A RID: 61770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F14A")]
		[Address(RVA = "0x684ED0", Offset = "0x683AD0", VA = "0x180684ED0", Slot = "38")]
		public virtual void UpdateHUD(InteractableBounceEnemy.UIForceInfo m_cachedForceInfo)
		{
		}

		// Token: 0x0600F14B RID: 61771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F14B")]
		[Address(RVA = "0x684D40", Offset = "0x683940", VA = "0x180684D40")]
		public void OnAppliedFinalForce()
		{
		}

		// Token: 0x0600F14C RID: 61772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F14C")]
		[Address(RVA = "0x685190", Offset = "0x683D90", VA = "0x180685190")]
		public BounceEnemyPhysicalFeatureTalent()
		{
		}

		// Token: 0x0600F14D RID: 61773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F14D")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x0600F14E RID: 61774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F14E")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F14F RID: 61775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F14F")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010AF9 RID: 68345
		[Token(Token = "0x4010AF9")]
		[FieldOffset(Offset = "0x68")]
		protected BounceEnemyHudPlugin m_hudPlugin;

		// Token: 0x04010AFA RID: 68346
		[Token(Token = "0x4010AFA")]
		[FieldOffset(Offset = "0x70")]
		protected InteractableBounceEnemy m_host;

		// Token: 0x04010AFB RID: 68347
		[Token(Token = "0x4010AFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010AFC RID: 68348
		[Token(Token = "0x4010AFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010AFD RID: 68349
		[Token(Token = "0x4010AFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010AFE RID: 68350
		[Token(Token = "0x4010AFE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010AFF RID: 68351
		[Token(Token = "0x4010AFF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010B00 RID: 68352
		[Token(Token = "0x4010B00")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010B01 RID: 68353
		[Token(Token = "0x4010B01")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010B02 RID: 68354
		[Token(Token = "0x4010B02")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateHUD;

		// Token: 0x04010B03 RID: 68355
		[Token(Token = "0x4010B03")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnAppliedFinalForce;

		// Token: 0x04010B04 RID: 68356
		[Token(Token = "0x4010B04")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
