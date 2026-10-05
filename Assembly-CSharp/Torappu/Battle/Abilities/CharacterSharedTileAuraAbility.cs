using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B24 RID: 11044
	[Token(Token = "0x2002B24")]
	public class CharacterSharedTileAuraAbility : AuraAbility
	{
		// Token: 0x060127FF RID: 75775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60127FF")]
		[Address(RVA = "0xA7CCD0", Offset = "0xA7B8D0", VA = "0x180A7CCD0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012800 RID: 75776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012800")]
		[Address(RVA = "0xA7D0E0", Offset = "0xA7BCE0", VA = "0x180A7D0E0", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012801 RID: 75777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012801")]
		[Address(RVA = "0xA7D020", Offset = "0xA7BC20", VA = "0x180A7D020", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012802 RID: 75778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012802")]
		[Address(RVA = "0xA7D1E0", Offset = "0xA7BDE0", VA = "0x180A7D1E0", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012803 RID: 75779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012803")]
		[Address(RVA = "0xA7D460", Offset = "0xA7C060", VA = "0x180A7D460")]
		private void _SetColliderOffset()
		{
		}

		// Token: 0x06012804 RID: 75780 RVA: 0x00071730 File Offset: 0x0006F930
		[Token(Token = "0x6012804")]
		[Address(RVA = "0xA7D660", Offset = "0xA7C260", VA = "0x180A7D660")]
		private int _SetTilesCollider()
		{
			return 0;
		}

		// Token: 0x06012805 RID: 75781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012805")]
		[Address(RVA = "0xA7DC50", Offset = "0xA7C850", VA = "0x180A7DC50")]
		public CharacterSharedTileAuraAbility()
		{
		}

		// Token: 0x06012806 RID: 75782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012806")]
		[Address(RVA = "0xA7B950", Offset = "0xA7A550", VA = "0x180A7B950")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012807 RID: 75783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012807")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012808 RID: 75784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012808")]
		[Address(RVA = "0xA7D440", Offset = "0xA7C040", VA = "0x180A7D440")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x06012809 RID: 75785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012809")]
		[Address(RVA = "0xA7D450", Offset = "0xA7C050", VA = "0x180A7D450")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04014E7D RID: 85629
		[Token(Token = "0x4014E7D")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private bool _showEffectWhenAttach;

		// Token: 0x04014E7E RID: 85630
		[Token(Token = "0x4014E7E")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private string _tileEffectKey;

		// Token: 0x04014E7F RID: 85631
		[Token(Token = "0x4014E7F")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private float _effectInterval;

		// Token: 0x04014E80 RID: 85632
		[Token(Token = "0x4014E80")]
		[FieldOffset(Offset = "0x198")]
		private List<Tile> m_showEffectTile;

		// Token: 0x04014E81 RID: 85633
		[Token(Token = "0x4014E81")]
		[FieldOffset(Offset = "0x1A0")]
		private List<BoxCollider2D> m_cachedcolliders;

		// Token: 0x04014E82 RID: 85634
		[Token(Token = "0x4014E82")]
		[FieldOffset(Offset = "0x1A8")]
		private int m_curTile;

		// Token: 0x04014E83 RID: 85635
		[Token(Token = "0x4014E83")]
		[FieldOffset(Offset = "0x1AC")]
		private int m_cntTileRow;

		// Token: 0x04014E84 RID: 85636
		[Token(Token = "0x4014E84")]
		[FieldOffset(Offset = "0x1B0")]
		private Vector2 m_offset;

		// Token: 0x04014E85 RID: 85637
		[Token(Token = "0x4014E85")]
		[FieldOffset(Offset = "0x1B8")]
		private ObjectPtr<Character> m_character;

		// Token: 0x04014E86 RID: 85638
		[Token(Token = "0x4014E86")]
		[FieldOffset(Offset = "0x1C8")]
		private PeriodicTimer m_effectTimer;

		// Token: 0x04014E87 RID: 85639
		[Token(Token = "0x4014E87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014E88 RID: 85640
		[Token(Token = "0x4014E88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014E89 RID: 85641
		[Token(Token = "0x4014E89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014E8A RID: 85642
		[Token(Token = "0x4014E8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014E8B RID: 85643
		[Token(Token = "0x4014E8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetColliderOffset;

		// Token: 0x04014E8C RID: 85644
		[Token(Token = "0x4014E8C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetTilesCollider;

		// Token: 0x04014E8D RID: 85645
		[Token(Token = "0x4014E8D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B25 RID: 11045
		[Token(Token = "0x2002B25")]
		public class ChoseTileDatas
		{
			// Token: 0x0601280A RID: 75786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601280A")]
			[Address(RVA = "0xA7DDA0", Offset = "0xA7C9A0", VA = "0x180A7DDA0")]
			public ChoseTileDatas()
			{
			}

			// Token: 0x04014E8E RID: 85646
			[Token(Token = "0x4014E8E")]
			[FieldOffset(Offset = "0x10")]
			public List<Tile> tilesRow;

			// Token: 0x04014E8F RID: 85647
			[Token(Token = "0x4014E8F")]
			[FieldOffset(Offset = "0x18")]
			public List<Tile> tilesCol;

			// Token: 0x04014E90 RID: 85648
			[Token(Token = "0x4014E90")]
			[FieldOffset(Offset = "0x20")]
			public List<KeyValuePair<Vector2, Vector2>> colliders;
		}
	}
}
