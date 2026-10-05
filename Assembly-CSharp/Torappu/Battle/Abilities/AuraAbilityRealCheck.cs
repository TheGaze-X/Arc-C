using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B1F RID: 11039
	[Token(Token = "0x2002B1F")]
	public class AuraAbilityRealCheck : AuraAbility
	{
		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x060127E4 RID: 75748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170028BB")]
		protected override AuraAbility.ITargetEnterExitHandler eeHandler
		{
			[Token(Token = "0x60127E4")]
			[Address(RVA = "0xA7B210", Offset = "0xA79E10", VA = "0x180A7B210", Slot = "97")]
			get
			{
				return null;
			}
		}

		// Token: 0x060127E5 RID: 75749 RVA: 0x000716A0 File Offset: 0x0006F8A0
		[Token(Token = "0x60127E5")]
		[Address(RVA = "0xA7AE50", Offset = "0xA79A50", VA = "0x180A7AE50")]
		private bool _DoTargetCheck(Entity target)
		{
			return default(bool);
		}

		// Token: 0x060127E6 RID: 75750 RVA: 0x000716B8 File Offset: 0x0006F8B8
		[Token(Token = "0x60127E6")]
		[Address(RVA = "0xA7AFD0", Offset = "0xA79BD0", VA = "0x180A7AFD0")]
		private bool _DoTargetEnter(Entity target)
		{
			return default(bool);
		}

		// Token: 0x060127E7 RID: 75751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127E7")]
		[Address(RVA = "0xA7B1B0", Offset = "0xA79DB0", VA = "0x180A7B1B0")]
		public AuraAbilityRealCheck()
		{
		}

		// Token: 0x060127E8 RID: 75752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60127E8")]
		[Address(RVA = "0xA7AE40", Offset = "0xA79A40", VA = "0x180A7AE40")]
		private AuraAbility.ITargetEnterExitHandler <>xLuaBaseProxy_get_eeHandler()
		{
			return null;
		}

		// Token: 0x04014E64 RID: 85604
		[Token(Token = "0x4014E64")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eeHandler;

		// Token: 0x04014E65 RID: 85605
		[Token(Token = "0x4014E65")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DoTargetCheck;

		// Token: 0x04014E66 RID: 85606
		[Token(Token = "0x4014E66")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoTargetEnter;

		// Token: 0x04014E67 RID: 85607
		[Token(Token = "0x4014E67")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B20 RID: 11040
		[Token(Token = "0x2002B20")]
		public class TargetEnterExitRealCheckHandler : MultiEnterExitHandler<Entity>, AuraAbility.ITargetEnterExitHandler
		{
			// Token: 0x060127E9 RID: 75753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127E9")]
			[Address(RVA = "0xA91E60", Offset = "0xA90A60", VA = "0x180A91E60")]
			public TargetEnterExitRealCheckHandler(AuraAbilityRealCheck.TargetEnterExitRealCheckHandler.Options options)
			{
			}

			// Token: 0x060127EA RID: 75754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127EA")]
			[Address(RVA = "0xA916A0", Offset = "0xA902A0", VA = "0x180A916A0", Slot = "4")]
			public override void Clear()
			{
			}

			// Token: 0x060127EB RID: 75755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127EB")]
			[Address(RVA = "0xA91960", Offset = "0xA90560", VA = "0x180A91960", Slot = "9")]
			public void OnTargetEnter(Entity target, uint abilityUniqueId)
			{
			}

			// Token: 0x060127EC RID: 75756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127EC")]
			[Address(RVA = "0xA91A60", Offset = "0xA90660", VA = "0x180A91A60", Slot = "10")]
			public void OnTargetExit(Entity target, uint abilityUniqueId)
			{
			}

			// Token: 0x060127ED RID: 75757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127ED")]
			[Address(RVA = "0xA91B60", Offset = "0xA90760", VA = "0x180A91B60", Slot = "8")]
			public void OnTick()
			{
			}

			// Token: 0x060127EE RID: 75758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127EE")]
			[Address(RVA = "0xA91740", Offset = "0xA90340", VA = "0x180A91740", Slot = "5")]
			protected override void OnRealEnter(Entity target)
			{
			}

			// Token: 0x060127EF RID: 75759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127EF")]
			[Address(RVA = "0xA91860", Offset = "0xA90460", VA = "0x180A91860", Slot = "6")]
			protected override void OnRealExit(Entity target)
			{
			}

			// Token: 0x060127F0 RID: 75760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60127F0")]
			[Address(RVA = "0xA91BB0", Offset = "0xA907B0", VA = "0x180A91BB0")]
			private void _UpdateCheckTarget()
			{
			}

			// Token: 0x04014E68 RID: 85608
			[Token(Token = "0x4014E68")]
			[FieldOffset(Offset = "0x18")]
			private AuraAbilityRealCheck.TargetEnterExitRealCheckHandler.Options m_options;

			// Token: 0x04014E69 RID: 85609
			[Token(Token = "0x4014E69")]
			[FieldOffset(Offset = "0x38")]
			private ListSet<ObjectPtr<Entity>> m_enterTargets;

			// Token: 0x04014E6A RID: 85610
			[Token(Token = "0x4014E6A")]
			[FieldOffset(Offset = "0x40")]
			private HashSet<ObjectPtr<Entity>> m_effectTargets;

			// Token: 0x04014E6B RID: 85611
			[Token(Token = "0x4014E6B")]
			[FieldOffset(Offset = "0x48")]
			private PeriodicTicker m_triggerTicker;

			// Token: 0x02002B21 RID: 11041
			[Token(Token = "0x2002B21")]
			public struct Options
			{
				// Token: 0x04014E6C RID: 85612
				[Token(Token = "0x4014E6C")]
				[FieldOffset(Offset = "0x0")]
				public int periodTick;

				// Token: 0x04014E6D RID: 85613
				[Token(Token = "0x4014E6D")]
				[FieldOffset(Offset = "0x8")]
				public Func<Entity, bool> checkFunc;

				// Token: 0x04014E6E RID: 85614
				[Token(Token = "0x4014E6E")]
				[FieldOffset(Offset = "0x10")]
				public Func<Entity, bool> enterFunc;

				// Token: 0x04014E6F RID: 85615
				[Token(Token = "0x4014E6F")]
				[FieldOffset(Offset = "0x18")]
				public Action<Entity> exitFunc;
			}
		}
	}
}
