using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B9D RID: 11165
	[Token(Token = "0x2002B9D")]
	public class GameCityGetSpByScoreAbility : AbilityStandard
	{
		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x06012D24 RID: 77092 RVA: 0x00073560 File Offset: 0x00071760
		[Token(Token = "0x17002988")]
		public override FP cooldown
		{
			[Token(Token = "0x6012D24")]
			[Address(RVA = "0xABD350", Offset = "0xABBF50", VA = "0x180ABD350", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x06012D25 RID: 77093 RVA: 0x00073578 File Offset: 0x00071778
		[Token(Token = "0x17002989")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012D25")]
			[Address(RVA = "0xABD2F0", Offset = "0xABBEF0", VA = "0x180ABD2F0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x06012D26 RID: 77094 RVA: 0x00073590 File Offset: 0x00071790
		[Token(Token = "0x1700298A")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012D26")]
			[Address(RVA = "0xABD3D0", Offset = "0xABBFD0", VA = "0x180ABD3D0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x06012D27 RID: 77095 RVA: 0x000735A8 File Offset: 0x000717A8
		[Token(Token = "0x1700298B")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012D27")]
			[Address(RVA = "0xABD290", Offset = "0xABBE90", VA = "0x180ABD290", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012D28 RID: 77096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D28")]
		[Address(RVA = "0xABCCC0", Offset = "0xABB8C0", VA = "0x180ABCCC0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012D29 RID: 77097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D29")]
		[Address(RVA = "0xABCD90", Offset = "0xABB990", VA = "0x180ABCD90", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012D2A RID: 77098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D2A")]
		[Address(RVA = "0xABCD30", Offset = "0xABB930", VA = "0x180ABCD30", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012D2B RID: 77099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D2B")]
		[Address(RVA = "0xABCC60", Offset = "0xABB860", VA = "0x180ABCC60", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012D2C RID: 77100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D2C")]
		[Address(RVA = "0xABCEB0", Offset = "0xABBAB0", VA = "0x180ABCEB0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012D2D RID: 77101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D2D")]
		[Address(RVA = "0xABCE20", Offset = "0xABBA20", VA = "0x180ABCE20", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012D2E RID: 77102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D2E")]
		[Address(RVA = "0xABCA20", Offset = "0xABB620", VA = "0x180ABCA20", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012D2F RID: 77103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D2F")]
		[Address(RVA = "0xABC7F0", Offset = "0xABB3F0", VA = "0x180ABC7F0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012D30 RID: 77104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D30")]
		[Address(RVA = "0xABC910", Offset = "0xABB510", VA = "0x180ABC910", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012D31 RID: 77105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D31")]
		[Address(RVA = "0xABCF40", Offset = "0xABBB40", VA = "0x180ABCF40")]
		private void _GetSpWithScore(object obj)
		{
		}

		// Token: 0x06012D32 RID: 77106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D32")]
		[Address(RVA = "0xABD1E0", Offset = "0xABBDE0", VA = "0x180ABD1E0")]
		public GameCityGetSpByScoreAbility()
		{
		}

		// Token: 0x06012D33 RID: 77107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D33")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012D34 RID: 77108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D34")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012D35 RID: 77109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D35")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x040153DD RID: 87005
		[Token(Token = "0x40153DD")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool _ignoreReduce;

		// Token: 0x040153DE RID: 87006
		[Token(Token = "0x40153DE")]
		[FieldOffset(Offset = "0x111")]
		[SerializeField]
		private bool _forceFlag;

		// Token: 0x040153DF RID: 87007
		[Token(Token = "0x40153DF")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private float _scoreScale;

		// Token: 0x040153E0 RID: 87008
		[Token(Token = "0x40153E0")]
		[FieldOffset(Offset = "0x118")]
		private GameModeFactory.GameCityGameMode m_gameMode;

		// Token: 0x040153E1 RID: 87009
		[Token(Token = "0x40153E1")]
		[FieldOffset(Offset = "0x120")]
		private FP m_scoreScale;

		// Token: 0x040153E2 RID: 87010
		[Token(Token = "0x40153E2")]
		[FieldOffset(Offset = "0x128")]
		protected FP m_tempScore;

		// Token: 0x040153E3 RID: 87011
		[Token(Token = "0x40153E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x040153E4 RID: 87012
		[Token(Token = "0x40153E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x040153E5 RID: 87013
		[Token(Token = "0x40153E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x040153E6 RID: 87014
		[Token(Token = "0x40153E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x040153E7 RID: 87015
		[Token(Token = "0x40153E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x040153E8 RID: 87016
		[Token(Token = "0x40153E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x040153E9 RID: 87017
		[Token(Token = "0x40153E9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x040153EA RID: 87018
		[Token(Token = "0x40153EA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x040153EB RID: 87019
		[Token(Token = "0x40153EB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x040153EC RID: 87020
		[Token(Token = "0x40153EC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x040153ED RID: 87021
		[Token(Token = "0x40153ED")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040153EE RID: 87022
		[Token(Token = "0x40153EE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x040153EF RID: 87023
		[Token(Token = "0x40153EF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x040153F0 RID: 87024
		[Token(Token = "0x40153F0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetSpWithScore;

		// Token: 0x040153F1 RID: 87025
		[Token(Token = "0x40153F1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
