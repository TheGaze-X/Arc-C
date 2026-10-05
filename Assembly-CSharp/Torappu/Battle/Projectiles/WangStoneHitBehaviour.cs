using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029C5 RID: 10693
	[Token(Token = "0x20029C5")]
	public class WangStoneHitBehaviour : SelectorHitBehaviour
	{
		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x06011B59 RID: 72537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002703")]
		private WangStoneTriggerManager stoneManager
		{
			[Token(Token = "0x6011B59")]
			[Address(RVA = "0x991F20", Offset = "0x990B20", VA = "0x180991F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x06011B5A RID: 72538 RVA: 0x0006C708 File Offset: 0x0006A908
		[Token(Token = "0x17002704")]
		protected override bool checkHitWhenTick
		{
			[Token(Token = "0x6011B5A")]
			[Address(RVA = "0x991DB0", Offset = "0x9909B0", VA = "0x180991DB0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x06011B5B RID: 72539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002705")]
		private TargetSelector explodeSelector
		{
			[Token(Token = "0x6011B5B")]
			[Address(RVA = "0x991E20", Offset = "0x990A20", VA = "0x180991E20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011B5C RID: 72540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B5C")]
		[Address(RVA = "0x991200", Offset = "0x98FE00", VA = "0x180991200", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011B5D RID: 72541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B5D")]
		[Address(RVA = "0x991BD0", Offset = "0x9907D0", VA = "0x180991BD0")]
		public void RefreshExplodeSelector(bool isRow, bool isCol)
		{
		}

		// Token: 0x06011B5E RID: 72542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B5E")]
		[Address(RVA = "0x991CC0", Offset = "0x9908C0", VA = "0x180991CC0")]
		public void SetStoneTriggered()
		{
		}

		// Token: 0x06011B5F RID: 72543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B5F")]
		[Address(RVA = "0x991A50", Offset = "0x990650", VA = "0x180991A50")]
		public void PlayStoneTriggeredEffect()
		{
		}

		// Token: 0x06011B60 RID: 72544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B60")]
		[Address(RVA = "0x990690", Offset = "0x98F290", VA = "0x180990690", Slot = "17")]
		protected override void DoOnTimerUpdated()
		{
		}

		// Token: 0x06011B61 RID: 72545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B61")]
		[Address(RVA = "0x990C50", Offset = "0x98F850", VA = "0x180990C50", Slot = "19")]
		protected override void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x06011B62 RID: 72546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B62")]
		[Address(RVA = "0x991690", Offset = "0x990290", VA = "0x180991690", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011B63 RID: 72547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B63")]
		[Address(RVA = "0x9918D0", Offset = "0x9904D0", VA = "0x1809918D0", Slot = "8")]
		public override void OnProjectileTrigger()
		{
		}

		// Token: 0x06011B64 RID: 72548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B64")]
		[Address(RVA = "0x991150", Offset = "0x98FD50", VA = "0x180991150")]
		public new void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011B65 RID: 72549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B65")]
		[Address(RVA = "0x991D40", Offset = "0x990940", VA = "0x180991D40")]
		public WangStoneHitBehaviour()
		{
		}

		// Token: 0x06011B66 RID: 72550 RVA: 0x0006C720 File Offset: 0x0006A920
		[Token(Token = "0x6011B66")]
		[Address(RVA = "0x9863E0", Offset = "0x984FE0", VA = "0x1809863E0")]
		private bool <>xLuaBaseProxy_get_checkHitWhenTick()
		{
			return default(bool);
		}

		// Token: 0x06011B67 RID: 72551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B67")]
		[Address(RVA = "0x9693E0", Offset = "0x967FE0", VA = "0x1809693E0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011B68 RID: 72552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B68")]
		[Address(RVA = "0x984F50", Offset = "0x983B50", VA = "0x180984F50")]
		private void <>xLuaBaseProxy_DoOnTimerUpdated()
		{
		}

		// Token: 0x06011B69 RID: 72553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B69")]
		[Address(RVA = "0x9682B0", Offset = "0x966EB0", VA = "0x1809682B0")]
		private void <>xLuaBaseProxy_DoSelectTargetToHit(Vector2 P0)
		{
		}

		// Token: 0x06011B6A RID: 72554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B6A")]
		[Address(RVA = "0x991D30", Offset = "0x990930", VA = "0x180991D30")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011B6B RID: 72555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B6B")]
		[Address(RVA = "0x970C00", Offset = "0x96F800", VA = "0x180970C00")]
		private void <>xLuaBaseProxy_OnProjectileTrigger()
		{
		}

		// Token: 0x04013DAB RID: 81323
		[Token(Token = "0x4013DAB")]
		private const string IS_ROW_BB = "is_row";

		// Token: 0x04013DAC RID: 81324
		[Token(Token = "0x4013DAC")]
		private const string IS_COL_BB = "is_col";

		// Token: 0x04013DAD RID: 81325
		[Token(Token = "0x4013DAD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TargetSelector _explodeSelector;

		// Token: 0x04013DAE RID: 81326
		[Token(Token = "0x4013DAE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private TargetSelector _extraExplodeSelector;

		// Token: 0x04013DAF RID: 81327
		[Token(Token = "0x4013DAF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private TargetSelector _combineExplodeSelector;

		// Token: 0x04013DB0 RID: 81328
		[Token(Token = "0x4013DB0")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string _triggeredEffect;

		// Token: 0x04013DB1 RID: 81329
		[Token(Token = "0x4013DB1")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool _checkTargetRootTile;

		// Token: 0x04013DB2 RID: 81330
		[Token(Token = "0x4013DB2")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_isTriggered;

		// Token: 0x04013DB3 RID: 81331
		[Token(Token = "0x4013DB3")]
		[FieldOffset(Offset = "0xD0")]
		private ObjectPtr<Effect> m_triggeredEffectPtr;

		// Token: 0x04013DB4 RID: 81332
		[Token(Token = "0x4013DB4")]
		[FieldOffset(Offset = "0xE0")]
		private WangStoneTriggerManager m_stoneManager;

		// Token: 0x04013DB5 RID: 81333
		[Token(Token = "0x4013DB5")]
		[FieldOffset(Offset = "0xE8")]
		private WangStoneTriggerManager.StoneType m_stoneType;

		// Token: 0x04013DB6 RID: 81334
		[Token(Token = "0x4013DB6")]
		[FieldOffset(Offset = "0xF0")]
		private string m_triggeredEffectKey;

		// Token: 0x04013DB7 RID: 81335
		[Token(Token = "0x4013DB7")]
		[FieldOffset(Offset = "0xF8")]
		private TargetSelector m_selectorToUse;

		// Token: 0x04013DB8 RID: 81336
		[Token(Token = "0x4013DB8")]
		[FieldOffset(Offset = "0x100")]
		private ObjectPtr<Entity> m_triggerTargetPtr;

		// Token: 0x04013DB9 RID: 81337
		[Token(Token = "0x4013DB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stoneManager;

		// Token: 0x04013DBA RID: 81338
		[Token(Token = "0x4013DBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_checkHitWhenTick;

		// Token: 0x04013DBB RID: 81339
		[Token(Token = "0x4013DBB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_explodeSelector;

		// Token: 0x04013DBC RID: 81340
		[Token(Token = "0x4013DBC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013DBD RID: 81341
		[Token(Token = "0x4013DBD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshExplodeSelector;

		// Token: 0x04013DBE RID: 81342
		[Token(Token = "0x4013DBE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetStoneTriggered;

		// Token: 0x04013DBF RID: 81343
		[Token(Token = "0x4013DBF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlayStoneTriggeredEffect;

		// Token: 0x04013DC0 RID: 81344
		[Token(Token = "0x4013DC0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoOnTimerUpdated;

		// Token: 0x04013DC1 RID: 81345
		[Token(Token = "0x4013DC1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013DC2 RID: 81346
		[Token(Token = "0x4013DC2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013DC3 RID: 81347
		[Token(Token = "0x4013DC3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnProjectileTrigger;

		// Token: 0x04013DC4 RID: 81348
		[Token(Token = "0x4013DC4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013DC5 RID: 81349
		[Token(Token = "0x4013DC5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
