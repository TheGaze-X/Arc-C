using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BBB RID: 11195
	[Token(Token = "0x2002BBB")]
	public class UpdateTraceTileAbility : BaseTraceTargetAbility
	{
		// Token: 0x06012E77 RID: 77431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E77")]
		[Address(RVA = "0xAD5C10", Offset = "0xAD4810", VA = "0x180AD5C10", Slot = "31")]
		public override void OnOwnerLocated()
		{
		}

		// Token: 0x06012E78 RID: 77432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E78")]
		[Address(RVA = "0xAD5AD0", Offset = "0xAD46D0", VA = "0x180AD5AD0", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012E79 RID: 77433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E79")]
		[Address(RVA = "0xAD5B70", Offset = "0xAD4770", VA = "0x180AD5B70", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012E7A RID: 77434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E7A")]
		[Address(RVA = "0xAD5ED0", Offset = "0xAD4AD0", VA = "0x180AD5ED0", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012E7B RID: 77435 RVA: 0x00073E30 File Offset: 0x00072030
		[Token(Token = "0x6012E7B")]
		[Address(RVA = "0xAD57A0", Offset = "0xAD43A0", VA = "0x180AD57A0", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012E7C RID: 77436 RVA: 0x00073E48 File Offset: 0x00072048
		[Token(Token = "0x6012E7C")]
		[Address(RVA = "0xAD5FB0", Offset = "0xAD4BB0", VA = "0x180AD5FB0")]
		public bool TryGetTraceTilesBySelector(Entity target, ref List<Tile> tiles)
		{
			return default(bool);
		}

		// Token: 0x06012E7D RID: 77437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E7D")]
		[Address(RVA = "0xAD5D80", Offset = "0xAD4980", VA = "0x180AD5D80", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012E7E RID: 77438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E7E")]
		[Address(RVA = "0xAD60F0", Offset = "0xAD4CF0", VA = "0x180AD60F0")]
		public UpdateTraceTileAbility()
		{
		}

		// Token: 0x06012E7F RID: 77439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E7F")]
		[Address(RVA = "0xA82F00", Offset = "0xA81B00", VA = "0x180A82F00")]
		private void <>xLuaBaseProxy_OnOwnerLocated()
		{
		}

		// Token: 0x06012E80 RID: 77440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E80")]
		[Address(RVA = "0xAAACF0", Offset = "0xAA98F0", VA = "0x180AAACF0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012E81 RID: 77441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E81")]
		[Address(RVA = "0xAAAD00", Offset = "0xAA9900", VA = "0x180AAAD00")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012E82 RID: 77442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E82")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012E83 RID: 77443 RVA: 0x00073E60 File Offset: 0x00072060
		[Token(Token = "0x6012E83")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06012E84 RID: 77444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E84")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401553F RID: 87359
		[Token(Token = "0x401553F")]
		private const float FIND_TRACE_TARGET_INTERVAL = 1f;

		// Token: 0x04015540 RID: 87360
		[Token(Token = "0x4015540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private TileSelector _traceTileSelector;

		// Token: 0x04015541 RID: 87361
		[Token(Token = "0x4015541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private List<Tile> s_candidateTiles;

		// Token: 0x04015542 RID: 87362
		[Token(Token = "0x4015542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private PeriodicTimer m_traceCooldownTimer;

		// Token: 0x04015543 RID: 87363
		[Token(Token = "0x4015543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnOwnerLocated;

		// Token: 0x04015544 RID: 87364
		[Token(Token = "0x4015544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x04015545 RID: 87365
		[Token(Token = "0x4015545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015546 RID: 87366
		[Token(Token = "0x4015546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04015547 RID: 87367
		[Token(Token = "0x4015547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x04015548 RID: 87368
		[Token(Token = "0x4015548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryGetTraceTilesBySelector;

		// Token: 0x04015549 RID: 87369
		[Token(Token = "0x4015549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401554A RID: 87370
		[Token(Token = "0x401554A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
