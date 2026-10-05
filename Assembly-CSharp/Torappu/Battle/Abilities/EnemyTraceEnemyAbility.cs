using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B97 RID: 11159
	[Token(Token = "0x2002B97")]
	public class EnemyTraceEnemyAbility : BaseTraceTargetAbility
	{
		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x06012C99 RID: 76953 RVA: 0x00073020 File Offset: 0x00071220
		[Token(Token = "0x1700296D")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012C99")]
			[Address(RVA = "0xAB9480", Offset = "0xAB8080", VA = "0x180AB9480", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x06012C9A RID: 76954 RVA: 0x00073038 File Offset: 0x00071238
		[Token(Token = "0x1700296E")]
		public override FP cooldown
		{
			[Token(Token = "0x6012C9A")]
			[Address(RVA = "0xAB94E0", Offset = "0xAB80E0", VA = "0x180AB94E0", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x06012C9B RID: 76955 RVA: 0x00073050 File Offset: 0x00071250
		[Token(Token = "0x1700296F")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012C9B")]
			[Address(RVA = "0xAB97A0", Offset = "0xAB83A0", VA = "0x180AB97A0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x06012C9C RID: 76956 RVA: 0x00073068 File Offset: 0x00071268
		[Token(Token = "0x17002970")]
		public override AbilityStandard.SelectTargetTiming selectTargetTiming
		{
			[Token(Token = "0x6012C9C")]
			[Address(RVA = "0xAB9800", Offset = "0xAB8400", VA = "0x180AB9800", Slot = "66")]
			get
			{
				return AbilityStandard.SelectTargetTiming.AT_BEGINING;
			}
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x06012C9D RID: 76957 RVA: 0x00073080 File Offset: 0x00071280
		[Token(Token = "0x17002971")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012C9D")]
			[Address(RVA = "0xAB9420", Offset = "0xAB8020", VA = "0x180AB9420", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x06012C9E RID: 76958 RVA: 0x00073098 File Offset: 0x00071298
		[Token(Token = "0x17002972")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x6012C9E")]
			[Address(RVA = "0xAB93C0", Offset = "0xAB7FC0", VA = "0x180AB93C0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012C9F RID: 76959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C9F")]
		[Address(RVA = "0xAB7880", Offset = "0xAB6480", VA = "0x180AB7880", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012CA0 RID: 76960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CA0")]
		[Address(RVA = "0xAB77B0", Offset = "0xAB63B0", VA = "0x180AB77B0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012CA1 RID: 76961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CA1")]
		[Address(RVA = "0xAB7810", Offset = "0xAB6410", VA = "0x180AB7810", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012CA2 RID: 76962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CA2")]
		[Address(RVA = "0xAB78E0", Offset = "0xAB64E0", VA = "0x180AB78E0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012CA3 RID: 76963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CA3")]
		[Address(RVA = "0xAB7EA0", Offset = "0xAB6AA0", VA = "0x180AB7EA0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012CA4 RID: 76964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CA4")]
		[Address(RVA = "0xAB7E10", Offset = "0xAB6A10", VA = "0x180AB7E10", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x06012CA5 RID: 76965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002973")]
		private IUseEnemyTrace ownerTrace
		{
			[Token(Token = "0x6012CA5")]
			[Address(RVA = "0xAB9720", Offset = "0xAB8320", VA = "0x180AB9720")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x06012CA6 RID: 76966 RVA: 0x000730B0 File Offset: 0x000712B0
		[Token(Token = "0x17002974")]
		public override bool usingTraceCursor
		{
			[Token(Token = "0x6012CA6")]
			[Address(RVA = "0xAB9AE0", Offset = "0xAB86E0", VA = "0x180AB9AE0", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x06012CA7 RID: 76967 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06012CA8 RID: 76968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002975")]
		public override Entity traceTarget
		{
			[Token(Token = "0x6012CA7")]
			[Address(RVA = "0xAB9A00", Offset = "0xAB8600", VA = "0x180AB9A00", Slot = "98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6012CA8")]
			[Address(RVA = "0xAB9BD0", Offset = "0xAB87D0", VA = "0x180AB9BD0", Slot = "99")]
			set
			{
			}
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x06012CA9 RID: 76969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002976")]
		protected override TracePositionCursor tracePositionCursor
		{
			[Token(Token = "0x6012CA9")]
			[Address(RVA = "0xAB9860", Offset = "0xAB8460", VA = "0x180AB9860", Slot = "100")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x06012CAA RID: 76970 RVA: 0x000730C8 File Offset: 0x000712C8
		[Token(Token = "0x17002977")]
		public override bool hasTraceTarget
		{
			[Token(Token = "0x6012CAA")]
			[Address(RVA = "0xAB9610", Offset = "0xAB8210", VA = "0x180AB9610", Slot = "101")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x06012CAB RID: 76971 RVA: 0x000730E0 File Offset: 0x000712E0
		[Token(Token = "0x17002978")]
		public override bool enableTraceTarget
		{
			[Token(Token = "0x6012CAB")]
			[Address(RVA = "0xAB9570", Offset = "0xAB8170", VA = "0x180AB9570", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012CAC RID: 76972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CAC")]
		[Address(RVA = "0xAB7970", Offset = "0xAB6570", VA = "0x180AB7970", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012CAD RID: 76973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CAD")]
		[Address(RVA = "0xAB7AC0", Offset = "0xAB66C0", VA = "0x180AB7AC0", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012CAE RID: 76974 RVA: 0x000730F8 File Offset: 0x000712F8
		[Token(Token = "0x6012CAE")]
		[Address(RVA = "0xAB7450", Offset = "0xAB6050", VA = "0x180AB7450", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool isFirstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012CAF RID: 76975 RVA: 0x00073110 File Offset: 0x00071310
		[Token(Token = "0x6012CAF")]
		[Address(RVA = "0xAB75A0", Offset = "0xAB61A0", VA = "0x180AB75A0", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool isFirstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012CB0 RID: 76976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CB0")]
		[Address(RVA = "0xAB8950", Offset = "0xAB7550", VA = "0x180AB8950")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x06012CB1 RID: 76977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CB1")]
		[Address(RVA = "0xAB76F0", Offset = "0xAB62F0", VA = "0x180AB76F0", Slot = "26")]
		protected override void DoSetData(Entity entity, Ability.Options option)
		{
		}

		// Token: 0x06012CB2 RID: 76978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CB2")]
		[Address(RVA = "0xAB7F30", Offset = "0xAB6B30", VA = "0x180AB7F30", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012CB3 RID: 76979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CB3")]
		[Address(RVA = "0xAB7C10", Offset = "0xAB6810", VA = "0x180AB7C10", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012CB4 RID: 76980 RVA: 0x00073128 File Offset: 0x00071328
		[Token(Token = "0x6012CB4")]
		[Address(RVA = "0xAB81A0", Offset = "0xAB6DA0", VA = "0x180AB81A0")]
		private bool _CanTargetBeTraced(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012CB5 RID: 76981 RVA: 0x00073140 File Offset: 0x00071340
		[Token(Token = "0x6012CB5")]
		[Address(RVA = "0xAB87B0", Offset = "0xAB73B0", VA = "0x180AB87B0")]
		private bool _IsTraceTileReachable()
		{
			return default(bool);
		}

		// Token: 0x06012CB6 RID: 76982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CB6")]
		[Address(RVA = "0xAB90C0", Offset = "0xAB7CC0", VA = "0x180AB90C0")]
		private void _UpdateTraceTarget()
		{
		}

		// Token: 0x06012CB7 RID: 76983 RVA: 0x00073158 File Offset: 0x00071358
		[Token(Token = "0x6012CB7")]
		[Address(RVA = "0xAB85B0", Offset = "0xAB71B0", VA = "0x180AB85B0")]
		private bool _CheckCurrentTraceTarget()
		{
			return default(bool);
		}

		// Token: 0x06012CB8 RID: 76984 RVA: 0x00073170 File Offset: 0x00071370
		[Token(Token = "0x6012CB8")]
		[Address(RVA = "0xAB8F50", Offset = "0xAB7B50", VA = "0x180AB8F50")]
		private bool _UpdateTraceTargetRoute(Entity candidate)
		{
			return default(bool);
		}

		// Token: 0x06012CB9 RID: 76985 RVA: 0x00073188 File Offset: 0x00071388
		[Token(Token = "0x6012CB9")]
		[Address(RVA = "0xAB82A0", Offset = "0xAB6EA0", VA = "0x180AB82A0")]
		private bool _CanUseAttack(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012CBA RID: 76986 RVA: 0x000731A0 File Offset: 0x000713A0
		[Token(Token = "0x6012CBA")]
		[Address(RVA = "0xAB8E20", Offset = "0xAB7A20", VA = "0x180AB8E20")]
		private bool _SelectorVerifyTarget(TargetSelector targetSelector, Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012CBB RID: 76987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CBB")]
		[Address(RVA = "0xAB8D00", Offset = "0xAB7900", VA = "0x180AB8D00")]
		private Enemy _SearchTraceTarget()
		{
			return null;
		}

		// Token: 0x06012CBC RID: 76988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CBC")]
		[Address(RVA = "0xAB8AE0", Offset = "0xAB76E0", VA = "0x180AB8AE0")]
		private void _RegisterTraceTarget(Enemy entity)
		{
		}

		// Token: 0x06012CBD RID: 76989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CBD")]
		[Address(RVA = "0xAB9300", Offset = "0xAB7F00", VA = "0x180AB9300")]
		public EnemyTraceEnemyAbility()
		{
		}

		// Token: 0x06012CBE RID: 76990 RVA: 0x000731B8 File Offset: 0x000713B8
		[Token(Token = "0x6012CBE")]
		[Address(RVA = "0xAAAD80", Offset = "0xAA9980", VA = "0x180AAAD80")]
		private Ability.Category <>xLuaBaseProxy_get_category()
		{
			return Ability.Category.NONE;
		}

		// Token: 0x06012CBF RID: 76991 RVA: 0x000731D0 File Offset: 0x000713D0
		[Token(Token = "0x6012CBF")]
		[Address(RVA = "0xAB8060", Offset = "0xAB6C60", VA = "0x180AB8060")]
		private FP <>xLuaBaseProxy_get_cooldown()
		{
			return default(FP);
		}

		// Token: 0x06012CC0 RID: 76992 RVA: 0x000731E8 File Offset: 0x000713E8
		[Token(Token = "0x6012CC0")]
		[Address(RVA = "0xAAEEF0", Offset = "0xAADAF0", VA = "0x180AAEEF0")]
		private AbilityStandard.SelectTargetSource <>xLuaBaseProxy_get_selectTargetSource()
		{
			return AbilityStandard.SelectTargetSource.NONE;
		}

		// Token: 0x06012CC1 RID: 76993 RVA: 0x00073200 File Offset: 0x00071400
		[Token(Token = "0x6012CC1")]
		[Address(RVA = "0xAAEF50", Offset = "0xAADB50", VA = "0x180AAEF50")]
		private AbilityStandard.SelectTargetTiming <>xLuaBaseProxy_get_selectTargetTiming()
		{
			return AbilityStandard.SelectTargetTiming.AT_BEGINING;
		}

		// Token: 0x06012CC2 RID: 76994 RVA: 0x00073218 File Offset: 0x00071418
		[Token(Token = "0x6012CC2")]
		[Address(RVA = "0xAAEAD0", Offset = "0xAAD6D0", VA = "0x180AAEAD0")]
		private bool <>xLuaBaseProxy_get_alwaysIncludeTarget()
		{
			return default(bool);
		}

		// Token: 0x06012CC3 RID: 76995 RVA: 0x00073230 File Offset: 0x00071430
		[Token(Token = "0x6012CC3")]
		[Address(RVA = "0xAAEA70", Offset = "0xAAD670", VA = "0x180AAEA70")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x06012CC4 RID: 76996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CC4")]
		[Address(RVA = "0xAAE130", Offset = "0xAACD30", VA = "0x180AAE130")]
		private IList<BuffData> <>xLuaBaseProxy_GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012CC5 RID: 76997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CC5")]
		[Address(RVA = "0xAAE060", Offset = "0xAACC60", VA = "0x180AAE060")]
		private IList<BuffData> <>xLuaBaseProxy_GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012CC6 RID: 76998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CC6")]
		[Address(RVA = "0xAAE0C0", Offset = "0xAACCC0", VA = "0x180AAE0C0")]
		private IList<ActionNode> <>xLuaBaseProxy_GetEventActions(AbilityStandard.Event P0)
		{
			return null;
		}

		// Token: 0x06012CC7 RID: 76999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CC7")]
		[Address(RVA = "0xAB8030", Offset = "0xAB6C30", VA = "0x180AB8030")]
		private IList<ActionNode> <>xLuaBaseProxy_GetProjectileActions(Projectile.Event P0, Projectile P1)
		{
			return null;
		}

		// Token: 0x06012CC8 RID: 77000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CC8")]
		[Address(RVA = "0xAB8050", Offset = "0xAB6C50", VA = "0x180AB8050")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012CC9 RID: 77001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CC9")]
		[Address(RVA = "0xAB8040", Offset = "0xAB6C40", VA = "0x180AB8040")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012CCA RID: 77002 RVA: 0x00073248 File Offset: 0x00071448
		[Token(Token = "0x6012CCA")]
		[Address(RVA = "0xAAF1D0", Offset = "0xAADDD0", VA = "0x180AAF1D0")]
		private bool <>xLuaBaseProxy_get_usingTraceCursor()
		{
			return default(bool);
		}

		// Token: 0x06012CCB RID: 77003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CCB")]
		[Address(RVA = "0xAAF110", Offset = "0xAADD10", VA = "0x180AAF110")]
		private Entity <>xLuaBaseProxy_get_traceTarget()
		{
			return null;
		}

		// Token: 0x06012CCC RID: 77004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CCC")]
		[Address(RVA = "0xAAF290", Offset = "0xAADE90", VA = "0x180AAF290")]
		private void <>xLuaBaseProxy_set_traceTarget(Entity P0)
		{
		}

		// Token: 0x06012CCD RID: 77005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CCD")]
		[Address(RVA = "0xAB8190", Offset = "0xAB6D90", VA = "0x180AB8190")]
		private TracePositionCursor <>xLuaBaseProxy_get_tracePositionCursor()
		{
			return null;
		}

		// Token: 0x06012CCE RID: 77006 RVA: 0x00073260 File Offset: 0x00071460
		[Token(Token = "0x6012CCE")]
		[Address(RVA = "0xAB8070", Offset = "0xAB6C70", VA = "0x180AB8070")]
		private bool <>xLuaBaseProxy_get_hasTraceTarget()
		{
			return default(bool);
		}

		// Token: 0x06012CCF RID: 77007 RVA: 0x00073278 File Offset: 0x00071478
		[Token(Token = "0x6012CCF")]
		[Address(RVA = "0xAAEC30", Offset = "0xAAD830", VA = "0x180AAEC30")]
		private bool <>xLuaBaseProxy_get_enableTraceTarget()
		{
			return default(bool);
		}

		// Token: 0x06012CD0 RID: 77008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CD0")]
		[Address(RVA = "0xAAACF0", Offset = "0xAA98F0", VA = "0x180AAACF0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012CD1 RID: 77009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CD1")]
		[Address(RVA = "0xAAAD00", Offset = "0xAA9900", VA = "0x180AAAD00")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012CD2 RID: 77010 RVA: 0x00073290 File Offset: 0x00071490
		[Token(Token = "0x6012CD2")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06012CD3 RID: 77011 RVA: 0x000732A8 File Offset: 0x000714A8
		[Token(Token = "0x6012CD3")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x06012CD4 RID: 77012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CD4")]
		[Address(RVA = "0xAB8000", Offset = "0xAB6C00", VA = "0x180AB8000")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012CD5 RID: 77013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CD5")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012CD6 RID: 77014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CD6")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04015385 RID: 86917
		[Token(Token = "0x4015385")]
		private const float DEFAULT_SEARCH_COOL_DOWN = 1f;

		// Token: 0x04015386 RID: 86918
		[Token(Token = "0x4015386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly List<Entity> m_candidateEntities;

		// Token: 0x04015387 RID: 86919
		[Token(Token = "0x4015387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04015388 RID: 86920
		[Token(Token = "0x4015388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04015389 RID: 86921
		[Token(Token = "0x4015389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x0401538A RID: 86922
		[Token(Token = "0x401538A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetTiming;

		// Token: 0x0401538B RID: 86923
		[Token(Token = "0x401538B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x0401538C RID: 86924
		[Token(Token = "0x401538C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x0401538D RID: 86925
		[Token(Token = "0x401538D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x0401538E RID: 86926
		[Token(Token = "0x401538E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x0401538F RID: 86927
		[Token(Token = "0x401538F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015390 RID: 86928
		[Token(Token = "0x4015390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015391 RID: 86929
		[Token(Token = "0x4015391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04015392 RID: 86930
		[Token(Token = "0x4015392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04015393 RID: 86931
		[Token(Token = "0x4015393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_ownerTrace;

		// Token: 0x04015394 RID: 86932
		[Token(Token = "0x4015394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_usingTraceCursor;

		// Token: 0x04015395 RID: 86933
		[Token(Token = "0x4015395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_traceTarget;

		// Token: 0x04015396 RID: 86934
		[Token(Token = "0x4015396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_traceTarget;

		// Token: 0x04015397 RID: 86935
		[Token(Token = "0x4015397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_tracePositionCursor;

		// Token: 0x04015398 RID: 86936
		[Token(Token = "0x4015398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_hasTraceTarget;

		// Token: 0x04015399 RID: 86937
		[Token(Token = "0x4015399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_enableTraceTarget;

		// Token: 0x0401539A RID: 86938
		[Token(Token = "0x401539A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x0401539B RID: 86939
		[Token(Token = "0x401539B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x0401539C RID: 86940
		[Token(Token = "0x401539C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x0401539D RID: 86941
		[Token(Token = "0x401539D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x0401539E RID: 86942
		[Token(Token = "0x401539E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0401539F RID: 86943
		[Token(Token = "0x401539F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040153A0 RID: 86944
		[Token(Token = "0x40153A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040153A1 RID: 86945
		[Token(Token = "0x40153A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040153A2 RID: 86946
		[Token(Token = "0x40153A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__CanTargetBeTraced;

		// Token: 0x040153A3 RID: 86947
		[Token(Token = "0x40153A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__IsTraceTileReachable;

		// Token: 0x040153A4 RID: 86948
		[Token(Token = "0x40153A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__UpdateTraceTarget;

		// Token: 0x040153A5 RID: 86949
		[Token(Token = "0x40153A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CheckCurrentTraceTarget;

		// Token: 0x040153A6 RID: 86950
		[Token(Token = "0x40153A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__UpdateTraceTargetRoute;

		// Token: 0x040153A7 RID: 86951
		[Token(Token = "0x40153A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__CanUseAttack;

		// Token: 0x040153A8 RID: 86952
		[Token(Token = "0x40153A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__SelectorVerifyTarget;

		// Token: 0x040153A9 RID: 86953
		[Token(Token = "0x40153A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__SearchTraceTarget;

		// Token: 0x040153AA RID: 86954
		[Token(Token = "0x40153AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__RegisterTraceTarget;

		// Token: 0x040153AB RID: 86955
		[Token(Token = "0x40153AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
