using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BB7 RID: 11191
	[Token(Token = "0x2002BB7")]
	public class TraceTargetAbility : BaseTraceTargetAbility
	{
		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x06012E28 RID: 77352 RVA: 0x00073B18 File Offset: 0x00071D18
		[Token(Token = "0x170029AB")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012E28")]
			[Address(RVA = "0xAD30E0", Offset = "0xAD1CE0", VA = "0x180AD30E0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x06012E29 RID: 77353 RVA: 0x00073B30 File Offset: 0x00071D30
		[Token(Token = "0x170029AC")]
		public override FP cooldown
		{
			[Token(Token = "0x6012E29")]
			[Address(RVA = "0xAD3140", Offset = "0xAD1D40", VA = "0x180AD3140", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x06012E2A RID: 77354 RVA: 0x00073B48 File Offset: 0x00071D48
		[Token(Token = "0x170029AD")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012E2A")]
			[Address(RVA = "0xAD3410", Offset = "0xAD2010", VA = "0x180AD3410", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x06012E2B RID: 77355 RVA: 0x00073B60 File Offset: 0x00071D60
		[Token(Token = "0x170029AE")]
		public override AbilityStandard.SelectTargetTiming selectTargetTiming
		{
			[Token(Token = "0x6012E2B")]
			[Address(RVA = "0xAD3470", Offset = "0xAD2070", VA = "0x180AD3470", Slot = "66")]
			get
			{
				return AbilityStandard.SelectTargetTiming.AT_BEGINING;
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x06012E2C RID: 77356 RVA: 0x00073B78 File Offset: 0x00071D78
		[Token(Token = "0x170029AF")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012E2C")]
			[Address(RVA = "0xAD3080", Offset = "0xAD1C80", VA = "0x180AD3080", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x06012E2D RID: 77357 RVA: 0x00073B90 File Offset: 0x00071D90
		[Token(Token = "0x170029B0")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x6012E2D")]
			[Address(RVA = "0xAD3020", Offset = "0xAD1C20", VA = "0x180AD3020", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012E2E RID: 77358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E2E")]
		[Address(RVA = "0xAD0E50", Offset = "0xACFA50", VA = "0x180AD0E50", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012E2F RID: 77359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E2F")]
		[Address(RVA = "0xAD0D80", Offset = "0xACF980", VA = "0x180AD0D80", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012E30 RID: 77360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E30")]
		[Address(RVA = "0xAD0DE0", Offset = "0xACF9E0", VA = "0x180AD0DE0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012E31 RID: 77361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E31")]
		[Address(RVA = "0xAD0EB0", Offset = "0xACFAB0", VA = "0x180AD0EB0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012E32 RID: 77362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E32")]
		[Address(RVA = "0xAD16D0", Offset = "0xAD02D0", VA = "0x180AD16D0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012E33 RID: 77363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E33")]
		[Address(RVA = "0xAD1640", Offset = "0xAD0240", VA = "0x180AD1640", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x06012E34 RID: 77364 RVA: 0x00073BA8 File Offset: 0x00071DA8
		[Token(Token = "0x170029B1")]
		public override bool enableTraceTarget
		{
			[Token(Token = "0x6012E34")]
			[Address(RVA = "0xAD31D0", Offset = "0xAD1DD0", VA = "0x180AD31D0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x06012E35 RID: 77365 RVA: 0x00073BC0 File Offset: 0x00071DC0
		[Token(Token = "0x170029B2")]
		private ObjectPtr<Character> host
		{
			[Token(Token = "0x6012E35")]
			[Address(RVA = "0xAD32B0", Offset = "0xAD1EB0", VA = "0x180AD32B0")]
			get
			{
				return default(ObjectPtr<Character>);
			}
		}

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x06012E36 RID: 77366 RVA: 0x00073BD8 File Offset: 0x00071DD8
		[Token(Token = "0x170029B3")]
		public override bool usingTraceCursor
		{
			[Token(Token = "0x6012E36")]
			[Address(RVA = "0xAD34D0", Offset = "0xAD20D0", VA = "0x180AD34D0", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012E37 RID: 77367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E37")]
		[Address(RVA = "0xAD1130", Offset = "0xACFD30", VA = "0x180AD1130", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012E38 RID: 77368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E38")]
		[Address(RVA = "0xAD1340", Offset = "0xACFF40", VA = "0x180AD1340", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012E39 RID: 77369 RVA: 0x00073BF0 File Offset: 0x00071DF0
		[Token(Token = "0x6012E39")]
		[Address(RVA = "0xAD0360", Offset = "0xACEF60", VA = "0x180AD0360", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012E3A RID: 77370 RVA: 0x00073C08 File Offset: 0x00071E08
		[Token(Token = "0x6012E3A")]
		[Address(RVA = "0xAD0640", Offset = "0xACF240", VA = "0x180AD0640", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012E3B RID: 77371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E3B")]
		[Address(RVA = "0xAD2B50", Offset = "0xAD1750", VA = "0x180AD2B50")]
		private void _OnCharacterLocate(object arg)
		{
		}

		// Token: 0x06012E3C RID: 77372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E3C")]
		[Address(RVA = "0xAD29E0", Offset = "0xAD15E0", VA = "0x180AD29E0")]
		private void _OnCharacterFinish(object arg)
		{
		}

		// Token: 0x06012E3D RID: 77373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E3D")]
		[Address(RVA = "0xAD2800", Offset = "0xAD1400", VA = "0x180AD2800")]
		private void _OnCharacterChanged(object arg)
		{
		}

		// Token: 0x06012E3E RID: 77374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E3E")]
		[Address(RVA = "0xAD0A20", Offset = "0xACF620", VA = "0x180AD0A20", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012E3F RID: 77375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E3F")]
		[Address(RVA = "0xAD1900", Offset = "0xAD0500", VA = "0x180AD1900", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012E40 RID: 77376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E40")]
		[Address(RVA = "0xAD1550", Offset = "0xAD0150", VA = "0x180AD1550", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012E41 RID: 77377 RVA: 0x00073C20 File Offset: 0x00071E20
		[Token(Token = "0x6012E41")]
		[Address(RVA = "0xAD0000", Offset = "0xACEC00", VA = "0x180AD0000")]
		public bool CanTargetBeTraced(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012E42 RID: 77378 RVA: 0x00073C38 File Offset: 0x00071E38
		[Token(Token = "0x6012E42")]
		[Address(RVA = "0xAD0F40", Offset = "0xACFB40", VA = "0x180AD0F40")]
		public bool IsTraceTileReachable()
		{
			return default(bool);
		}

		// Token: 0x06012E43 RID: 77379 RVA: 0x00073C50 File Offset: 0x00071E50
		[Token(Token = "0x6012E43")]
		[Address(RVA = "0xAD2420", Offset = "0xAD1020", VA = "0x180AD2420")]
		public bool UpdateTraceTarget()
		{
			return default(bool);
		}

		// Token: 0x06012E44 RID: 77380 RVA: 0x00073C68 File Offset: 0x00071E68
		[Token(Token = "0x6012E44")]
		[Address(RVA = "0xAD0780", Offset = "0xACF380", VA = "0x180AD0780")]
		public bool CheckCurrentTraceTarget()
		{
			return default(bool);
		}

		// Token: 0x06012E45 RID: 77381 RVA: 0x00073C80 File Offset: 0x00071E80
		[Token(Token = "0x6012E45")]
		[Address(RVA = "0xAD2100", Offset = "0xAD0D00", VA = "0x180AD2100")]
		public bool UpdateTraceTargetRoute(Entity candidate)
		{
			return default(bool);
		}

		// Token: 0x06012E46 RID: 77382 RVA: 0x00073C98 File Offset: 0x00071E98
		[Token(Token = "0x6012E46")]
		[Address(RVA = "0xAD25F0", Offset = "0xAD11F0", VA = "0x180AD25F0")]
		private bool _CanUseAttack(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012E47 RID: 77383 RVA: 0x00073CB0 File Offset: 0x00071EB0
		[Token(Token = "0x6012E47")]
		[Address(RVA = "0xAD2DC0", Offset = "0xAD19C0", VA = "0x180AD2DC0")]
		private bool _SelectorVerifyTarget(TargetSelector selector, Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012E48 RID: 77384 RVA: 0x00073CC8 File Offset: 0x00071EC8
		[Token(Token = "0x6012E48")]
		[Address(RVA = "0xAD1F30", Offset = "0xAD0B30", VA = "0x180AD1F30")]
		public bool TryGetTraceTilesBySelector(Entity target, ref List<Tile> tiles)
		{
			return default(bool);
		}

		// Token: 0x06012E49 RID: 77385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E49")]
		[Address(RVA = "0xAD1A80", Offset = "0xAD0680", VA = "0x180AD1A80", Slot = "106")]
		public override Entity SearchTraceTarget()
		{
			return null;
		}

		// Token: 0x06012E4A RID: 77386 RVA: 0x00073CE0 File Offset: 0x00071EE0
		[Token(Token = "0x6012E4A")]
		[Address(RVA = "0xAD1760", Offset = "0xAD0360", VA = "0x180AD1760")]
		public bool RegisterTraceTarget(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012E4B RID: 77387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E4B")]
		[Address(RVA = "0xAD2EF0", Offset = "0xAD1AF0", VA = "0x180AD2EF0")]
		public TraceTargetAbility()
		{
		}

		// Token: 0x06012E4C RID: 77388 RVA: 0x00073CF8 File Offset: 0x00071EF8
		[Token(Token = "0x6012E4C")]
		[Address(RVA = "0xACC2E0", Offset = "0xACAEE0", VA = "0x180ACC2E0")]
		private Ability.Category <>xLuaBaseProxy_get_category()
		{
			return Ability.Category.NONE;
		}

		// Token: 0x06012E4D RID: 77389 RVA: 0x00073D10 File Offset: 0x00071F10
		[Token(Token = "0x6012E4D")]
		[Address(RVA = "0xAB8060", Offset = "0xAB6C60", VA = "0x180AB8060")]
		private FP <>xLuaBaseProxy_get_cooldown()
		{
			return default(FP);
		}

		// Token: 0x06012E4E RID: 77390 RVA: 0x00073D28 File Offset: 0x00071F28
		[Token(Token = "0x6012E4E")]
		[Address(RVA = "0xAD20D0", Offset = "0xAD0CD0", VA = "0x180AD20D0")]
		private AbilityStandard.SelectTargetSource <>xLuaBaseProxy_get_selectTargetSource()
		{
			return AbilityStandard.SelectTargetSource.NONE;
		}

		// Token: 0x06012E4F RID: 77391 RVA: 0x00073D40 File Offset: 0x00071F40
		[Token(Token = "0x6012E4F")]
		[Address(RVA = "0xAD20E0", Offset = "0xAD0CE0", VA = "0x180AD20E0")]
		private AbilityStandard.SelectTargetTiming <>xLuaBaseProxy_get_selectTargetTiming()
		{
			return AbilityStandard.SelectTargetTiming.AT_BEGINING;
		}

		// Token: 0x06012E50 RID: 77392 RVA: 0x00073D58 File Offset: 0x00071F58
		[Token(Token = "0x6012E50")]
		[Address(RVA = "0xAD20C0", Offset = "0xAD0CC0", VA = "0x180AD20C0")]
		private bool <>xLuaBaseProxy_get_alwaysIncludeTarget()
		{
			return default(bool);
		}

		// Token: 0x06012E51 RID: 77393 RVA: 0x00073D70 File Offset: 0x00071F70
		[Token(Token = "0x6012E51")]
		[Address(RVA = "0xAD20B0", Offset = "0xAD0CB0", VA = "0x180AD20B0")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x06012E52 RID: 77394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E52")]
		[Address(RVA = "0xAD2090", Offset = "0xAD0C90", VA = "0x180AD2090")]
		private IList<BuffData> <>xLuaBaseProxy_GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012E53 RID: 77395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E53")]
		[Address(RVA = "0xAD2070", Offset = "0xAD0C70", VA = "0x180AD2070")]
		private IList<BuffData> <>xLuaBaseProxy_GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012E54 RID: 77396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E54")]
		[Address(RVA = "0xAD2080", Offset = "0xAD0C80", VA = "0x180AD2080")]
		private IList<ActionNode> <>xLuaBaseProxy_GetEventActions(AbilityStandard.Event P0)
		{
			return null;
		}

		// Token: 0x06012E55 RID: 77397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E55")]
		[Address(RVA = "0xAB8030", Offset = "0xAB6C30", VA = "0x180AB8030")]
		private IList<ActionNode> <>xLuaBaseProxy_GetProjectileActions(Projectile.Event P0, Projectile P1)
		{
			return null;
		}

		// Token: 0x06012E56 RID: 77398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E56")]
		[Address(RVA = "0xAB8050", Offset = "0xAB6C50", VA = "0x180AB8050")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012E57 RID: 77399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E57")]
		[Address(RVA = "0xAB8040", Offset = "0xAB6C40", VA = "0x180AB8040")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012E58 RID: 77400 RVA: 0x00073D88 File Offset: 0x00071F88
		[Token(Token = "0x6012E58")]
		[Address(RVA = "0xACC2F0", Offset = "0xACAEF0", VA = "0x180ACC2F0")]
		private bool <>xLuaBaseProxy_get_enableTraceTarget()
		{
			return default(bool);
		}

		// Token: 0x06012E59 RID: 77401 RVA: 0x00073DA0 File Offset: 0x00071FA0
		[Token(Token = "0x6012E59")]
		[Address(RVA = "0xAD20F0", Offset = "0xAD0CF0", VA = "0x180AD20F0")]
		private bool <>xLuaBaseProxy_get_usingTraceCursor()
		{
			return default(bool);
		}

		// Token: 0x06012E5A RID: 77402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E5A")]
		[Address(RVA = "0xAAACF0", Offset = "0xAA98F0", VA = "0x180AAACF0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012E5B RID: 77403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E5B")]
		[Address(RVA = "0xAAAD00", Offset = "0xAA9900", VA = "0x180AAAD00")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012E5C RID: 77404 RVA: 0x00073DB8 File Offset: 0x00071FB8
		[Token(Token = "0x6012E5C")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06012E5D RID: 77405 RVA: 0x00073DD0 File Offset: 0x00071FD0
		[Token(Token = "0x6012E5D")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x06012E5E RID: 77406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E5E")]
		[Address(RVA = "0xAB8000", Offset = "0xAB6C00", VA = "0x180AB8000")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012E5F RID: 77407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E5F")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012E60 RID: 77408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E60")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012E61 RID: 77409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E61")]
		[Address(RVA = "0xAD20A0", Offset = "0xAD0CA0", VA = "0x180AD20A0")]
		private Entity <>xLuaBaseProxy_SearchTraceTarget()
		{
			return null;
		}

		// Token: 0x04015501 RID: 87297
		[Token(Token = "0x4015501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private TileData.HeightType _priorTraceHeightType;

		// Token: 0x04015502 RID: 87298
		[Token(Token = "0x4015502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private TileSelector _traceTileSelector;

		// Token: 0x04015503 RID: 87299
		[Token(Token = "0x4015503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private bool _useHostTarget;

		// Token: 0x04015504 RID: 87300
		[Token(Token = "0x4015504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[SerializeField]
		private float _minTargetSeletorRange;

		// Token: 0x04015505 RID: 87301
		[Token(Token = "0x4015505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private float _minTileSeletorRange;

		// Token: 0x04015506 RID: 87302
		[Token(Token = "0x4015506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[SerializeField]
		private bool _traceEnemy;

		// Token: 0x04015507 RID: 87303
		[Token(Token = "0x4015507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x165")]
		[SerializeField]
		private bool _updateTwiceIfTraceTargetIsNull;

		// Token: 0x04015508 RID: 87304
		[Token(Token = "0x4015508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<Tile> s_candidateTiles;

		// Token: 0x04015509 RID: 87305
		[Token(Token = "0x4015509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<Entity> s_candidateEntities;

		// Token: 0x0401550A RID: 87306
		[Token(Token = "0x401550A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float m_tileSelectorRange;

		// Token: 0x0401550B RID: 87307
		[Token(Token = "0x401550B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float m_targetSelectorRange;

		// Token: 0x0401550C RID: 87308
		[Token(Token = "0x401550C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private ObjectPtr<Character> m_host;

		// Token: 0x0401550D RID: 87309
		[Token(Token = "0x401550D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x0401550E RID: 87310
		[Token(Token = "0x401550E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x0401550F RID: 87311
		[Token(Token = "0x401550F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04015510 RID: 87312
		[Token(Token = "0x4015510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetTiming;

		// Token: 0x04015511 RID: 87313
		[Token(Token = "0x4015511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04015512 RID: 87314
		[Token(Token = "0x4015512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x04015513 RID: 87315
		[Token(Token = "0x4015513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04015514 RID: 87316
		[Token(Token = "0x4015514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04015515 RID: 87317
		[Token(Token = "0x4015515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015516 RID: 87318
		[Token(Token = "0x4015516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015517 RID: 87319
		[Token(Token = "0x4015517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04015518 RID: 87320
		[Token(Token = "0x4015518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04015519 RID: 87321
		[Token(Token = "0x4015519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_enableTraceTarget;

		// Token: 0x0401551A RID: 87322
		[Token(Token = "0x401551A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_host;

		// Token: 0x0401551B RID: 87323
		[Token(Token = "0x401551B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_usingTraceCursor;

		// Token: 0x0401551C RID: 87324
		[Token(Token = "0x401551C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x0401551D RID: 87325
		[Token(Token = "0x401551D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x0401551E RID: 87326
		[Token(Token = "0x401551E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x0401551F RID: 87327
		[Token(Token = "0x401551F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x04015520 RID: 87328
		[Token(Token = "0x4015520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnCharacterLocate;

		// Token: 0x04015521 RID: 87329
		[Token(Token = "0x4015521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnCharacterFinish;

		// Token: 0x04015522 RID: 87330
		[Token(Token = "0x4015522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnCharacterChanged;

		// Token: 0x04015523 RID: 87331
		[Token(Token = "0x4015523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015524 RID: 87332
		[Token(Token = "0x4015524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04015525 RID: 87333
		[Token(Token = "0x4015525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015526 RID: 87334
		[Token(Token = "0x4015526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CanTargetBeTraced;

		// Token: 0x04015527 RID: 87335
		[Token(Token = "0x4015527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_IsTraceTileReachable;

		// Token: 0x04015528 RID: 87336
		[Token(Token = "0x4015528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_UpdateTraceTarget;

		// Token: 0x04015529 RID: 87337
		[Token(Token = "0x4015529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_CheckCurrentTraceTarget;

		// Token: 0x0401552A RID: 87338
		[Token(Token = "0x401552A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_UpdateTraceTargetRoute;

		// Token: 0x0401552B RID: 87339
		[Token(Token = "0x401552B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CanUseAttack;

		// Token: 0x0401552C RID: 87340
		[Token(Token = "0x401552C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__SelectorVerifyTarget;

		// Token: 0x0401552D RID: 87341
		[Token(Token = "0x401552D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_TryGetTraceTilesBySelector;

		// Token: 0x0401552E RID: 87342
		[Token(Token = "0x401552E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_SearchTraceTarget;

		// Token: 0x0401552F RID: 87343
		[Token(Token = "0x401552F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_RegisterTraceTarget;

		// Token: 0x04015530 RID: 87344
		[Token(Token = "0x4015530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
