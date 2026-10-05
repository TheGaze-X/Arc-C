using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AFD RID: 11005
	[Token(Token = "0x2002AFD")]
	public class AbilityExChargeGroup : AbilityStandard, IExChargeableSource, IChargeableSource
	{
		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x06012642 RID: 75330 RVA: 0x000709B0 File Offset: 0x0006EBB0
		[Token(Token = "0x17002856")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012642")]
			[Address(RVA = "0xA64E00", Offset = "0xA63A00", VA = "0x180A64E00", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x06012643 RID: 75331 RVA: 0x000709C8 File Offset: 0x0006EBC8
		[Token(Token = "0x17002857")]
		public override FP cooldown
		{
			[Token(Token = "0x6012643")]
			[Address(RVA = "0xA64E60", Offset = "0xA63A60", VA = "0x180A64E60", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x06012644 RID: 75332 RVA: 0x000709E0 File Offset: 0x0006EBE0
		[Token(Token = "0x17002858")]
		public override bool isReady
		{
			[Token(Token = "0x6012644")]
			[Address(RVA = "0xA64EE0", Offset = "0xA63AE0", VA = "0x180A64EE0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x06012645 RID: 75333 RVA: 0x000709F8 File Offset: 0x0006EBF8
		[Token(Token = "0x17002859")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012645")]
			[Address(RVA = "0xA64F40", Offset = "0xA63B40", VA = "0x180A64F40", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x06012646 RID: 75334 RVA: 0x00070A10 File Offset: 0x0006EC10
		[Token(Token = "0x1700285A")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012646")]
			[Address(RVA = "0xA64DA0", Offset = "0xA639A0", VA = "0x180A64DA0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012647 RID: 75335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012647")]
		[Address(RVA = "0xA64540", Offset = "0xA63140", VA = "0x180A64540", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012648 RID: 75336 RVA: 0x00070A28 File Offset: 0x0006EC28
		[Token(Token = "0x6012648")]
		[Address(RVA = "0xA64790", Offset = "0xA63390", VA = "0x180A64790", Slot = "97")]
		public int GetChargeTimes()
		{
			return 0;
		}

		// Token: 0x06012649 RID: 75337 RVA: 0x00070A40 File Offset: 0x0006EC40
		[Token(Token = "0x6012649")]
		[Address(RVA = "0xA64920", Offset = "0xA63520", VA = "0x180A64920", Slot = "96")]
		public int GetExChargeTimes()
		{
			return 0;
		}

		// Token: 0x0601264A RID: 75338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601264A")]
		[Address(RVA = "0xA64CB0", Offset = "0xA638B0", VA = "0x180A64CB0")]
		public void SyncChargeTimes(int chargeTimes, int exChargeTimes)
		{
		}

		// Token: 0x0601264B RID: 75339 RVA: 0x00070A58 File Offset: 0x0006EC58
		[Token(Token = "0x601264B")]
		[Address(RVA = "0xA64B30", Offset = "0xA63730", VA = "0x180A64B30")]
		public int GetTotalChargeTimes()
		{
			return 0;
		}

		// Token: 0x0601264C RID: 75340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601264C")]
		[Address(RVA = "0xA646F0", Offset = "0xA632F0", VA = "0x180A646F0")]
		public void GetBothChargeTimes(out int chargeTimes, out int exChargeTimes)
		{
		}

		// Token: 0x0601264D RID: 75341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601264D")]
		[Address(RVA = "0xA648B0", Offset = "0xA634B0", VA = "0x180A648B0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x0601264E RID: 75342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601264E")]
		[Address(RVA = "0xA64AA0", Offset = "0xA636A0", VA = "0x180A64AA0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x0601264F RID: 75343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601264F")]
		[Address(RVA = "0xA64A40", Offset = "0xA63640", VA = "0x180A64A40", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012650 RID: 75344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012650")]
		[Address(RVA = "0xA64690", Offset = "0xA63290", VA = "0x180A64690", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012651 RID: 75345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012651")]
		[Address(RVA = "0xA64C20", Offset = "0xA63820", VA = "0x180A64C20", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012652 RID: 75346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012652")]
		[Address(RVA = "0xA64B90", Offset = "0xA63790", VA = "0x180A64B90", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012653 RID: 75347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012653")]
		[Address(RVA = "0xA64D40", Offset = "0xA63940", VA = "0x180A64D40")]
		public AbilityExChargeGroup()
		{
		}

		// Token: 0x06012654 RID: 75348 RVA: 0x00070A70 File Offset: 0x0006EC70
		[Token(Token = "0x6012654")]
		[Address(RVA = "0xA38720", Offset = "0xA37320", VA = "0x180A38720")]
		private bool <>xLuaBaseProxy_get_isReady()
		{
			return default(bool);
		}

		// Token: 0x06012655 RID: 75349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012655")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x04014CBB RID: 85179
		[Token(Token = "0x4014CBB")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private ExChargeRangedAttack[] _abilities;

		// Token: 0x04014CBC RID: 85180
		[Token(Token = "0x4014CBC")]
		[FieldOffset(Offset = "0x118")]
		private int m_chargeTimes;

		// Token: 0x04014CBD RID: 85181
		[Token(Token = "0x4014CBD")]
		[FieldOffset(Offset = "0x11C")]
		private int m_exChargeTimes;

		// Token: 0x04014CBE RID: 85182
		[Token(Token = "0x4014CBE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014CBF RID: 85183
		[Token(Token = "0x4014CBF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014CC0 RID: 85184
		[Token(Token = "0x4014CC0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isReady;

		// Token: 0x04014CC1 RID: 85185
		[Token(Token = "0x4014CC1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014CC2 RID: 85186
		[Token(Token = "0x4014CC2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014CC3 RID: 85187
		[Token(Token = "0x4014CC3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014CC4 RID: 85188
		[Token(Token = "0x4014CC4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetChargeTimes;

		// Token: 0x04014CC5 RID: 85189
		[Token(Token = "0x4014CC5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetExChargeTimes;

		// Token: 0x04014CC6 RID: 85190
		[Token(Token = "0x4014CC6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SyncChargeTimes;

		// Token: 0x04014CC7 RID: 85191
		[Token(Token = "0x4014CC7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetTotalChargeTimes;

		// Token: 0x04014CC8 RID: 85192
		[Token(Token = "0x4014CC8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetBothChargeTimes;

		// Token: 0x04014CC9 RID: 85193
		[Token(Token = "0x4014CC9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014CCA RID: 85194
		[Token(Token = "0x4014CCA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014CCB RID: 85195
		[Token(Token = "0x4014CCB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014CCC RID: 85196
		[Token(Token = "0x4014CCC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014CCD RID: 85197
		[Token(Token = "0x4014CCD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014CCE RID: 85198
		[Token(Token = "0x4014CCE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014CCF RID: 85199
		[Token(Token = "0x4014CCF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
