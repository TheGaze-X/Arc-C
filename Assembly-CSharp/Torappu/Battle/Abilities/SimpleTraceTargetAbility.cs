using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BB3 RID: 11187
	[Token(Token = "0x2002BB3")]
	public class SimpleTraceTargetAbility : BaseTraceTargetAbility
	{
		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x06012DF3 RID: 77299 RVA: 0x00073980 File Offset: 0x00071B80
		[Token(Token = "0x170029A3")]
		public override bool enableTraceTarget
		{
			[Token(Token = "0x6012DF3")]
			[Address(RVA = "0xACD2F0", Offset = "0xACBEF0", VA = "0x180ACD2F0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x06012DF4 RID: 77300 RVA: 0x00073998 File Offset: 0x00071B98
		[Token(Token = "0x170029A4")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012DF4")]
			[Address(RVA = "0xACD290", Offset = "0xACBE90", VA = "0x180ACD290", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x06012DF5 RID: 77301 RVA: 0x000739B0 File Offset: 0x00071BB0
		[Token(Token = "0x170029A5")]
		public override bool isAffecting
		{
			[Token(Token = "0x6012DF5")]
			[Address(RVA = "0xACD360", Offset = "0xACBF60", VA = "0x180ACD360", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x06012DF6 RID: 77302 RVA: 0x000739C8 File Offset: 0x00071BC8
		[Token(Token = "0x170029A6")]
		public override bool isReady
		{
			[Token(Token = "0x6012DF6")]
			[Address(RVA = "0xACD410", Offset = "0xACC010", VA = "0x180ACD410", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012DF7 RID: 77303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DF7")]
		[Address(RVA = "0xACBEC0", Offset = "0xACAAC0", VA = "0x180ACBEC0", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012DF8 RID: 77304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DF8")]
		[Address(RVA = "0xACC030", Offset = "0xACAC30", VA = "0x180ACC030", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012DF9 RID: 77305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DF9")]
		[Address(RVA = "0xACC1C0", Offset = "0xACADC0", VA = "0x180ACC1C0", Slot = "39")]
		public override void StopAffect()
		{
		}

		// Token: 0x06012DFA RID: 77306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DFA")]
		[Address(RVA = "0xACBF70", Offset = "0xACAB70", VA = "0x180ACBF70", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012DFB RID: 77307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DFB")]
		[Address(RVA = "0xACC0B0", Offset = "0xACACB0", VA = "0x180ACC0B0", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012DFC RID: 77308 RVA: 0x000739E0 File Offset: 0x00071BE0
		[Token(Token = "0x6012DFC")]
		[Address(RVA = "0xACC5F0", Offset = "0xACB1F0", VA = "0x180ACC5F0")]
		private bool _CheckTarget(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012DFD RID: 77309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DFD")]
		[Address(RVA = "0xACCDB0", Offset = "0xACB9B0", VA = "0x180ACCDB0")]
		private void _UpdateTraceTarget()
		{
		}

		// Token: 0x06012DFE RID: 77310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DFE")]
		[Address(RVA = "0xACC6D0", Offset = "0xACB2D0", VA = "0x180ACC6D0")]
		private void _CleanTraceTarget()
		{
		}

		// Token: 0x06012DFF RID: 77311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DFF")]
		[Address(RVA = "0xACC300", Offset = "0xACAF00", VA = "0x180ACC300")]
		private void _CheckReached()
		{
		}

		// Token: 0x06012E00 RID: 77312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E00")]
		[Address(RVA = "0xACC790", Offset = "0xACB390", VA = "0x180ACC790")]
		private void _CreateReachedBuff()
		{
		}

		// Token: 0x06012E01 RID: 77313 RVA: 0x000739F8 File Offset: 0x00071BF8
		[Token(Token = "0x6012E01")]
		[Address(RVA = "0xACC8F0", Offset = "0xACB4F0", VA = "0x180ACC8F0")]
		private bool _TryUpdateTraceTargetRoute(Entity validTarget)
		{
			return default(bool);
		}

		// Token: 0x06012E02 RID: 77314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E02")]
		[Address(RVA = "0xACBE10", Offset = "0xACAA10", VA = "0x180ACBE10", Slot = "49")]
		public override void GatherBuffs(List<BuffData> buffs)
		{
		}

		// Token: 0x06012E03 RID: 77315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E03")]
		[Address(RVA = "0xACD1E0", Offset = "0xACBDE0", VA = "0x180ACD1E0")]
		public SimpleTraceTargetAbility()
		{
		}

		// Token: 0x06012E04 RID: 77316 RVA: 0x00073A10 File Offset: 0x00071C10
		[Token(Token = "0x6012E04")]
		[Address(RVA = "0xACC2F0", Offset = "0xACAEF0", VA = "0x180ACC2F0")]
		private bool <>xLuaBaseProxy_get_enableTraceTarget()
		{
			return default(bool);
		}

		// Token: 0x06012E05 RID: 77317 RVA: 0x00073A28 File Offset: 0x00071C28
		[Token(Token = "0x6012E05")]
		[Address(RVA = "0xACC2E0", Offset = "0xACAEE0", VA = "0x180ACC2E0")]
		private Ability.Category <>xLuaBaseProxy_get_category()
		{
			return Ability.Category.NONE;
		}

		// Token: 0x06012E06 RID: 77318 RVA: 0x00073A40 File Offset: 0x00071C40
		[Token(Token = "0x6012E06")]
		[Address(RVA = "0xA4D200", Offset = "0xA4BE00", VA = "0x180A4D200")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x06012E07 RID: 77319 RVA: 0x00073A58 File Offset: 0x00071C58
		[Token(Token = "0x6012E07")]
		[Address(RVA = "0xA38720", Offset = "0xA37320", VA = "0x180A38720")]
		private bool <>xLuaBaseProxy_get_isReady()
		{
			return default(bool);
		}

		// Token: 0x06012E08 RID: 77320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E08")]
		[Address(RVA = "0xAAACF0", Offset = "0xAA98F0", VA = "0x180AAACF0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012E09 RID: 77321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E09")]
		[Address(RVA = "0xAAAD00", Offset = "0xAA9900", VA = "0x180AAAD00")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012E0A RID: 77322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E0A")]
		[Address(RVA = "0xA4D1E0", Offset = "0xA4BDE0", VA = "0x180A4D1E0")]
		private void <>xLuaBaseProxy_StopAffect()
		{
		}

		// Token: 0x06012E0B RID: 77323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E0B")]
		[Address(RVA = "0xA25740", Offset = "0xA24340", VA = "0x180A25740")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x06012E0C RID: 77324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E0C")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012E0D RID: 77325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E0D")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x040154BD RID: 87229
		[Token(Token = "0x40154BD")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private float _updateDistSqrEps;

		// Token: 0x040154BE RID: 87230
		[Token(Token = "0x40154BE")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private bool _stopAffectIfInSqrEps;

		// Token: 0x040154BF RID: 87231
		[Token(Token = "0x40154BF")]
		[FieldOffset(Offset = "0x14D")]
		[SerializeField]
		private bool _findNearbyReachableTile;

		// Token: 0x040154C0 RID: 87232
		[Token(Token = "0x40154C0")]
		[FieldOffset(Offset = "0x14E")]
		[SerializeField]
		private bool _disableWhenReached;

		// Token: 0x040154C1 RID: 87233
		[Token(Token = "0x40154C1")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private float _reachedThreshold;

		// Token: 0x040154C2 RID: 87234
		[Token(Token = "0x40154C2")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private BuffData[] _buffsWhenReachedTarget;

		// Token: 0x040154C3 RID: 87235
		[Token(Token = "0x40154C3")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private bool _dontUpdateTargetOnTick;

		// Token: 0x040154C4 RID: 87236
		[Token(Token = "0x40154C4")]
		[FieldOffset(Offset = "0x164")]
		private Vector2 m_lastMapPosition;

		// Token: 0x040154C5 RID: 87237
		[Token(Token = "0x40154C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enableTraceTarget;

		// Token: 0x040154C6 RID: 87238
		[Token(Token = "0x40154C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x040154C7 RID: 87239
		[Token(Token = "0x40154C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x040154C8 RID: 87240
		[Token(Token = "0x40154C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isReady;

		// Token: 0x040154C9 RID: 87241
		[Token(Token = "0x40154C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040154CA RID: 87242
		[Token(Token = "0x40154CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040154CB RID: 87243
		[Token(Token = "0x40154CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StopAffect;

		// Token: 0x040154CC RID: 87244
		[Token(Token = "0x40154CC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x040154CD RID: 87245
		[Token(Token = "0x40154CD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040154CE RID: 87246
		[Token(Token = "0x40154CE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckTarget;

		// Token: 0x040154CF RID: 87247
		[Token(Token = "0x40154CF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateTraceTarget;

		// Token: 0x040154D0 RID: 87248
		[Token(Token = "0x40154D0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CleanTraceTarget;

		// Token: 0x040154D1 RID: 87249
		[Token(Token = "0x40154D1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CheckReached;

		// Token: 0x040154D2 RID: 87250
		[Token(Token = "0x40154D2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateReachedBuff;

		// Token: 0x040154D3 RID: 87251
		[Token(Token = "0x40154D3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryUpdateTraceTargetRoute;

		// Token: 0x040154D4 RID: 87252
		[Token(Token = "0x40154D4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x040154D5 RID: 87253
		[Token(Token = "0x40154D5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
