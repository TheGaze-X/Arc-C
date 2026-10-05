using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024AE RID: 9390
	[Token(Token = "0x20024AE")]
	public class FootBallHudPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x0600F170 RID: 61808 RVA: 0x00058F50 File Offset: 0x00057150
		[Token(Token = "0x17001F64")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F170")]
			[Address(RVA = "0x68D880", Offset = "0x68C480", VA = "0x18068D880", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x0600F171 RID: 61809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F171")]
		[Address(RVA = "0x68C8B0", Offset = "0x68B4B0", VA = "0x18068C8B0", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F172 RID: 61810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F172")]
		[Address(RVA = "0x68CB40", Offset = "0x68B740", VA = "0x18068CB40", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F173 RID: 61811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F173")]
		[Address(RVA = "0x68CC40", Offset = "0x68B840", VA = "0x18068CC40", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F174 RID: 61812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F174")]
		[Address(RVA = "0x68D630", Offset = "0x68C230", VA = "0x18068D630")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F175 RID: 61813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F175")]
		[Address(RVA = "0x68CD70", Offset = "0x68B970", VA = "0x18068CD70", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F176 RID: 61814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F176")]
		[Address(RVA = "0x68D520", Offset = "0x68C120", VA = "0x18068D520")]
		public void Reset(bool resetPlugin = true)
		{
		}

		// Token: 0x0600F177 RID: 61815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F177")]
		[Address(RVA = "0x68D110", Offset = "0x68BD10", VA = "0x18068D110")]
		public void OnTakeDamage(Entity source, FP directionX, FP directionY, FP value)
		{
		}

		// Token: 0x0600F178 RID: 61816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F178")]
		[Address(RVA = "0x68D060", Offset = "0x68BC60", VA = "0x18068D060")]
		public void OnKnockBack()
		{
		}

		// Token: 0x0600F179 RID: 61817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F179")]
		[Address(RVA = "0x68CF60", Offset = "0x68BB60", VA = "0x18068CF60")]
		public void OnKickByEnemy(Vector2 direction, FP forceScale)
		{
		}

		// Token: 0x0600F17A RID: 61818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F17A")]
		[Address(RVA = "0x68CE70", Offset = "0x68BA70", VA = "0x18068CE70")]
		public void ModifyKickValue(FP value)
		{
		}

		// Token: 0x0600F17B RID: 61819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F17B")]
		[Address(RVA = "0x68D7E0", Offset = "0x68C3E0", VA = "0x18068D7E0")]
		public FootBallHudPluginTalent()
		{
		}

		// Token: 0x0600F17C RID: 61820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F17C")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x0600F17D RID: 61821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F17D")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F17E RID: 61822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F17E")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010B27 RID: 68391
		[Token(Token = "0x4010B27")]
		[FieldOffset(Offset = "0x68")]
		private FootBallHudPlugin m_hudPlugin;

		// Token: 0x04010B28 RID: 68392
		[Token(Token = "0x4010B28")]
		[FieldOffset(Offset = "0x70")]
		private FootballEnemy m_footballEnemy;

		// Token: 0x04010B29 RID: 68393
		[Token(Token = "0x4010B29")]
		[FieldOffset(Offset = "0x78")]
		private FP m_maxValue;

		// Token: 0x04010B2A RID: 68394
		[Token(Token = "0x4010B2A")]
		[FieldOffset(Offset = "0x80")]
		private FP m_currentValue;

		// Token: 0x04010B2B RID: 68395
		[Token(Token = "0x4010B2B")]
		[FieldOffset(Offset = "0x88")]
		private FP m_forceVectorX;

		// Token: 0x04010B2C RID: 68396
		[Token(Token = "0x4010B2C")]
		[FieldOffset(Offset = "0x90")]
		private FP m_forceVectorY;

		// Token: 0x04010B2D RID: 68397
		[Token(Token = "0x4010B2D")]
		[FieldOffset(Offset = "0x98")]
		private FP m_frictionFactor;

		// Token: 0x04010B2E RID: 68398
		[Token(Token = "0x4010B2E")]
		[FieldOffset(Offset = "0xA0")]
		private FP m_force;

		// Token: 0x04010B2F RID: 68399
		[Token(Token = "0x4010B2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010B30 RID: 68400
		[Token(Token = "0x4010B30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010B31 RID: 68401
		[Token(Token = "0x4010B31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010B32 RID: 68402
		[Token(Token = "0x4010B32")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010B33 RID: 68403
		[Token(Token = "0x4010B33")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010B34 RID: 68404
		[Token(Token = "0x4010B34")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010B35 RID: 68405
		[Token(Token = "0x4010B35")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010B36 RID: 68406
		[Token(Token = "0x4010B36")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTakeDamage;

		// Token: 0x04010B37 RID: 68407
		[Token(Token = "0x4010B37")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnKnockBack;

		// Token: 0x04010B38 RID: 68408
		[Token(Token = "0x4010B38")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnKickByEnemy;

		// Token: 0x04010B39 RID: 68409
		[Token(Token = "0x4010B39")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ModifyKickValue;

		// Token: 0x04010B3A RID: 68410
		[Token(Token = "0x4010B3A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
