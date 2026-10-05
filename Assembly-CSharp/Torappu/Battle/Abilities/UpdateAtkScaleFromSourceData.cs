using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C31 RID: 11313
	[Token(Token = "0x2002C31")]
	public class UpdateAtkScaleFromSourceData : AbilityStandard.Behaviour
	{
		// Token: 0x060131A6 RID: 78246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131A6")]
		[Address(RVA = "0xB29780", Offset = "0xB28380", VA = "0x180B29780", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x060131A7 RID: 78247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131A7")]
		[Address(RVA = "0xB29550", Offset = "0xB28150", VA = "0x180B29550", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x060131A8 RID: 78248 RVA: 0x00074970 File Offset: 0x00072B70
		[Token(Token = "0x60131A8")]
		[Address(RVA = "0xB29AD0", Offset = "0xB286D0", VA = "0x180B29AD0")]
		private FP _GetTraitOrTalentAtkScale()
		{
			return default(FP);
		}

		// Token: 0x060131A9 RID: 78249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131A9")]
		[Address(RVA = "0xB296F0", Offset = "0xB282F0", VA = "0x180B296F0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060131AA RID: 78250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131AA")]
		[Address(RVA = "0xB2A0C0", Offset = "0xB28CC0", VA = "0x180B2A0C0")]
		private void _UpdateAtkScaleBySpellCnt(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060131AB RID: 78251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131AB")]
		[Address(RVA = "0xB29D10", Offset = "0xB28910", VA = "0x180B29D10")]
		private void _SetTalent(Character character, UpdateAtkScaleFromSourceData.AtkScaleConfig config)
		{
		}

		// Token: 0x060131AC RID: 78252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131AC")]
		[Address(RVA = "0xB29F60", Offset = "0xB28B60", VA = "0x180B29F60")]
		private void _SetTrait(Character character, UpdateAtkScaleFromSourceData.AtkScaleConfig config)
		{
		}

		// Token: 0x060131AD RID: 78253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131AD")]
		[Address(RVA = "0xB2A370", Offset = "0xB28F70", VA = "0x180B2A370")]
		public UpdateAtkScaleFromSourceData()
		{
		}

		// Token: 0x060131AE RID: 78254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131AE")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x060131AF RID: 78255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131AF")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x060131B0 RID: 78256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131B0")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015928 RID: 88360
		[Token(Token = "0x4015928")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<UpdateAtkScaleFromSourceData.AtkScaleConfig> _atkScaleConfig;

		// Token: 0x04015929 RID: 88361
		[Token(Token = "0x4015929")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _overwrite;

		// Token: 0x0401592A RID: 88362
		[Token(Token = "0x401592A")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _createNewNodeEachTime;

		// Token: 0x0401592B RID: 88363
		[Token(Token = "0x401592B")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<UpdateAtkScaleFromSourceData.AtkScaleConfig, FP> m_atkScaleConfigDic;

		// Token: 0x0401592C RID: 88364
		[Token(Token = "0x401592C")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, UpdateAtkScaleFromSourceData.AtkScaleConfig> m_spellCntDic;

		// Token: 0x0401592D RID: 88365
		[Token(Token = "0x401592D")]
		[FieldOffset(Offset = "0x40")]
		private int m_spellCnt;

		// Token: 0x0401592E RID: 88366
		[Token(Token = "0x401592E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401592F RID: 88367
		[Token(Token = "0x401592F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015930 RID: 88368
		[Token(Token = "0x4015930")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetTraitOrTalentAtkScale;

		// Token: 0x04015931 RID: 88369
		[Token(Token = "0x4015931")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015932 RID: 88370
		[Token(Token = "0x4015932")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateAtkScaleBySpellCnt;

		// Token: 0x04015933 RID: 88371
		[Token(Token = "0x4015933")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetTalent;

		// Token: 0x04015934 RID: 88372
		[Token(Token = "0x4015934")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetTrait;

		// Token: 0x04015935 RID: 88373
		[Token(Token = "0x4015935")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002C32 RID: 11314
		[Token(Token = "0x2002C32")]
		public enum AtkScaleSource
		{
			// Token: 0x04015937 RID: 88375
			[Token(Token = "0x4015937")]
			TALENT,
			// Token: 0x04015938 RID: 88376
			[Token(Token = "0x4015938")]
			TRAIT,
			// Token: 0x04015939 RID: 88377
			[Token(Token = "0x4015939")]
			SPELL_CNT
		}

		// Token: 0x02002C33 RID: 11315
		[Token(Token = "0x2002C33")]
		[Serializable]
		public class AtkScaleConfig
		{
			// Token: 0x060131B1 RID: 78257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60131B1")]
			[Address(RVA = "0xB14320", Offset = "0xB12F20", VA = "0x180B14320")]
			public AtkScaleConfig()
			{
			}

			// Token: 0x0401593A RID: 88378
			[Token(Token = "0x401593A")]
			[FieldOffset(Offset = "0x10")]
			public UpdateAtkScaleFromSourceData.AtkScaleSource source;

			// Token: 0x0401593B RID: 88379
			[Token(Token = "0x401593B")]
			[FieldOffset(Offset = "0x18")]
			public string talentKey;

			// Token: 0x0401593C RID: 88380
			[Token(Token = "0x401593C")]
			[FieldOffset(Offset = "0x20")]
			public float defaultValue;

			// Token: 0x0401593D RID: 88381
			[Token(Token = "0x401593D")]
			[FieldOffset(Offset = "0x28")]
			public string atkScaleKey;

			// Token: 0x0401593E RID: 88382
			[Token(Token = "0x401593E")]
			[FieldOffset(Offset = "0x30")]
			public int spellCnt;

			// Token: 0x0401593F RID: 88383
			[Token(Token = "0x401593F")]
			[FieldOffset(Offset = "0x38")]
			public TargetValidator ownerValidator;
		}
	}
}
