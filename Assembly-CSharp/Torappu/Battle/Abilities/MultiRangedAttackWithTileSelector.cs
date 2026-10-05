using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002ABB RID: 10939
	[Token(Token = "0x2002ABB")]
	public class MultiRangedAttackWithTileSelector : MultiRangedAttack
	{
		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x0601235B RID: 74587 RVA: 0x0006F978 File Offset: 0x0006DB78
		[Token(Token = "0x170027F1")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x601235B")]
			[Address(RVA = "0xA43780", Offset = "0xA42380", VA = "0x180A43780", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601235C RID: 74588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601235C")]
		[Address(RVA = "0xA430E0", Offset = "0xA41CE0", VA = "0x180A430E0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601235D RID: 74589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601235D")]
		[Address(RVA = "0xA43210", Offset = "0xA41E10", VA = "0x180A43210", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x0601235E RID: 74590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601235E")]
		[Address(RVA = "0xA43350", Offset = "0xA41F50", VA = "0x180A43350", Slot = "28")]
		public override void UpdateSelector()
		{
		}

		// Token: 0x0601235F RID: 74591 RVA: 0x0006F990 File Offset: 0x0006DB90
		[Token(Token = "0x601235F")]
		[Address(RVA = "0xA43440", Offset = "0xA42040", VA = "0x180A43440", Slot = "86")]
		protected override bool UpdateTargets(bool updateInputPos = false)
		{
			return default(bool);
		}

		// Token: 0x06012360 RID: 74592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012360")]
		[Address(RVA = "0xA434F0", Offset = "0xA420F0", VA = "0x180A434F0")]
		private void _UpdateTargetWithTileSelector()
		{
		}

		// Token: 0x06012361 RID: 74593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012361")]
		[Address(RVA = "0xA43720", Offset = "0xA42320", VA = "0x180A43720")]
		public MultiRangedAttackWithTileSelector()
		{
		}

		// Token: 0x06012362 RID: 74594 RVA: 0x0006F9A8 File Offset: 0x0006DBA8
		[Token(Token = "0x6012362")]
		[Address(RVA = "0xA3CEF0", Offset = "0xA3BAF0", VA = "0x180A3CEF0")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x06012363 RID: 74595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012363")]
		[Address(RVA = "0xA3E9A0", Offset = "0xA3D5A0", VA = "0x180A3E9A0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012364 RID: 74596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012364")]
		[Address(RVA = "0xA43330", Offset = "0xA41F30", VA = "0x180A43330")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012365 RID: 74597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012365")]
		[Address(RVA = "0xA43340", Offset = "0xA41F40", VA = "0x180A43340")]
		private void <>xLuaBaseProxy_UpdateSelector()
		{
		}

		// Token: 0x06012366 RID: 74598 RVA: 0x0006F9C0 File Offset: 0x0006DBC0
		[Token(Token = "0x6012366")]
		[Address(RVA = "0xA3E9E0", Offset = "0xA3D5E0", VA = "0x180A3E9E0")]
		private bool <>xLuaBaseProxy_UpdateTargets(bool P0)
		{
			return default(bool);
		}

		// Token: 0x04014982 RID: 84354
		[Token(Token = "0x4014982")]
		[FieldOffset(Offset = "0x2D8")]
		[SerializeField]
		private TileSelector _tileSelector;

		// Token: 0x04014983 RID: 84355
		[Token(Token = "0x4014983")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x04014984 RID: 84356
		[Token(Token = "0x4014984")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014985 RID: 84357
		[Token(Token = "0x4014985")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014986 RID: 84358
		[Token(Token = "0x4014986")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateSelector;

		// Token: 0x04014987 RID: 84359
		[Token(Token = "0x4014987")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateTargets;

		// Token: 0x04014988 RID: 84360
		[Token(Token = "0x4014988")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateTargetWithTileSelector;

		// Token: 0x04014989 RID: 84361
		[Token(Token = "0x4014989")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
