using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C35 RID: 11317
	[Token(Token = "0x2002C35")]
	public class UpdateHealScaleByTraitData : AbilityStandard.Behaviour
	{
		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x060131B9 RID: 78265 RVA: 0x000749A0 File Offset: 0x00072BA0
		[Token(Token = "0x170029FD")]
		protected bool usedToEPHeal
		{
			[Token(Token = "0x60131B9")]
			[Address(RVA = "0xB2AE60", Offset = "0xB29A60", VA = "0x180B2AE60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060131BA RID: 78266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131BA")]
		[Address(RVA = "0xB2AC10", Offset = "0xB29810", VA = "0x180B2AC10", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x060131BB RID: 78267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131BB")]
		[Address(RVA = "0xB2AA10", Offset = "0xB29610", VA = "0x180B2AA10", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x060131BC RID: 78268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131BC")]
		[Address(RVA = "0xB2ADF0", Offset = "0xB299F0", VA = "0x180B2ADF0")]
		public UpdateHealScaleByTraitData()
		{
		}

		// Token: 0x060131BD RID: 78269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131BD")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x060131BE RID: 78270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131BE")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x04015946 RID: 88390
		[Token(Token = "0x4015946")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _usedToEPHeal;

		// Token: 0x04015947 RID: 88391
		[Token(Token = "0x4015947")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		[Inspect("usedToEPHeal", Condition = true)]
		private bool _applyEPScaleForEPHealNode;

		// Token: 0x04015948 RID: 88392
		[Token(Token = "0x4015948")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _defaultValue;

		// Token: 0x04015949 RID: 88393
		[Token(Token = "0x4015949")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _defaultEPHealRatioValue;

		// Token: 0x0401594A RID: 88394
		[Token(Token = "0x401594A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _overwrite;

		// Token: 0x0401594B RID: 88395
		[Token(Token = "0x401594B")]
		[FieldOffset(Offset = "0x30")]
		private float m_healScale;

		// Token: 0x0401594C RID: 88396
		[Token(Token = "0x401594C")]
		[FieldOffset(Offset = "0x34")]
		private float m_epHealScale;

		// Token: 0x0401594D RID: 88397
		[Token(Token = "0x401594D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_usedToEPHeal;

		// Token: 0x0401594E RID: 88398
		[Token(Token = "0x401594E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401594F RID: 88399
		[Token(Token = "0x401594F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015950 RID: 88400
		[Token(Token = "0x4015950")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
