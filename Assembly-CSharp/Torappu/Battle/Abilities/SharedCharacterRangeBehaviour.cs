using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C2A RID: 11306
	[Token(Token = "0x2002C2A")]
	public class SharedCharacterRangeBehaviour : AbilityStandard.Behaviour, BattleAttackRangeController.IRangeListener
	{
		// Token: 0x06013178 RID: 78200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013178")]
		[Address(RVA = "0xB24A80", Offset = "0xB23680", VA = "0x180B24A80", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x06013179 RID: 78201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013179")]
		[Address(RVA = "0xB24ED0", Offset = "0xB23AD0", VA = "0x180B24ED0", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0601317A RID: 78202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601317A")]
		[Address(RVA = "0xB24CF0", Offset = "0xB238F0", VA = "0x180B24CF0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x0601317B RID: 78203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601317B")]
		[Address(RVA = "0xB251C0", Offset = "0xB23DC0", VA = "0x180B251C0")]
		private void _CollectCollider(ref List<Collider2D> collider, RangeData data)
		{
		}

		// Token: 0x0601317C RID: 78204 RVA: 0x000748E0 File Offset: 0x00072AE0
		[Token(Token = "0x601317C")]
		[Address(RVA = "0xB24FF0", Offset = "0xB23BF0", VA = "0x180B24FF0")]
		private bool _CheckCharacter(TargetValidator validator, Character character)
		{
			return default(bool);
		}

		// Token: 0x0601317D RID: 78205 RVA: 0x000748F8 File Offset: 0x00072AF8
		[Token(Token = "0x601317D")]
		[Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
		private bool _NeedUpdateByCharacter(Character character)
		{
			return default(bool);
		}

		// Token: 0x0601317E RID: 78206 RVA: 0x00074910 File Offset: 0x00072B10
		[Token(Token = "0x601317E")]
		[Address(RVA = "0xB25630", Offset = "0xB24230", VA = "0x180B25630")]
		private bool _NeedContainsCharacterAttackRange(Character character)
		{
			return default(bool);
		}

		// Token: 0x0601317F RID: 78207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601317F")]
		[Address(RVA = "0xB259D0", Offset = "0xB245D0", VA = "0x180B259D0")]
		private void _UpdateRangeCollider()
		{
		}

		// Token: 0x06013180 RID: 78208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6013180")]
		[Address(RVA = "0xB25580", Offset = "0xB24180", VA = "0x180B25580")]
		private IEnumerator _DoRemoveCachedColliders()
		{
			return null;
		}

		// Token: 0x06013181 RID: 78209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013181")]
		[Address(RVA = "0xB257B0", Offset = "0xB243B0", VA = "0x180B257B0")]
		private void _RemoveCachedColliders()
		{
		}

		// Token: 0x06013182 RID: 78210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013182")]
		[Address(RVA = "0xB25E10", Offset = "0xB24A10", VA = "0x180B25E10")]
		private void _UpdateRangeData(Dictionary<Character, List<Tile>> allRangeTiles)
		{
		}

		// Token: 0x06013183 RID: 78211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013183")]
		[Address(RVA = "0xB25730", Offset = "0xB24330", VA = "0x180B25730")]
		private void _Refresh(Dictionary<Character, List<Tile>> allRangeTiles)
		{
		}

		// Token: 0x06013184 RID: 78212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013184")]
		[Address(RVA = "0xB253E0", Offset = "0xB23FE0", VA = "0x180B253E0")]
		private void _DoBind()
		{
		}

		// Token: 0x06013185 RID: 78213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013185")]
		[Address(RVA = "0xB25130", Offset = "0xB23D30", VA = "0x180B25130")]
		private void _ClearCollidersOnDetach()
		{
		}

		// Token: 0x06013186 RID: 78214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013186")]
		[Address(RVA = "0xB24B90", Offset = "0xB23790", VA = "0x180B24B90", Slot = "16")]
		public void OnCharacterAttackRangeUpdate(Character character, Dictionary<Character, List<Tile>> allRangeTiles)
		{
		}

		// Token: 0x06013187 RID: 78215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013187")]
		[Address(RVA = "0xB26490", Offset = "0xB25090", VA = "0x180B26490")]
		public SharedCharacterRangeBehaviour()
		{
		}

		// Token: 0x06013188 RID: 78216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013188")]
		[Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x06013189 RID: 78217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013189")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0601318A RID: 78218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601318A")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x040158EA RID: 88298
		[Token(Token = "0x40158EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TargetValidator _validator;

		// Token: 0x040158EB RID: 88299
		[Token(Token = "0x40158EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TargetValidator _containsCharacterValidator;

		// Token: 0x040158EC RID: 88300
		[Token(Token = "0x40158EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PhysicsRange _targetRange;

		// Token: 0x040158ED RID: 88301
		[Token(Token = "0x40158ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _includeSelf;

		// Token: 0x040158EE RID: 88302
		[Token(Token = "0x40158EE")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _updateOriginTile;

		// Token: 0x040158EF RID: 88303
		[Token(Token = "0x40158EF")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool _bindOnAttach;

		// Token: 0x040158F0 RID: 88304
		[Token(Token = "0x40158F0")]
		[FieldOffset(Offset = "0x3B")]
		[SerializeField]
		private bool _clearCollidersOnDetach;

		// Token: 0x040158F1 RID: 88305
		[Token(Token = "0x40158F1")]
		[FieldOffset(Offset = "0x40")]
		private RangeData m_rangeData;

		// Token: 0x040158F2 RID: 88306
		[Token(Token = "0x40158F2")]
		[FieldOffset(Offset = "0x48")]
		private List<Tile> m_tmpTiles;

		// Token: 0x040158F3 RID: 88307
		[Token(Token = "0x40158F3")]
		[FieldOffset(Offset = "0x50")]
		private List<Collider2D> m_colliders;

		// Token: 0x040158F4 RID: 88308
		[Token(Token = "0x40158F4")]
		[FieldOffset(Offset = "0x58")]
		private List<Collider2D> m_collidersCache;

		// Token: 0x040158F5 RID: 88309
		[Token(Token = "0x40158F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040158F6 RID: 88310
		[Token(Token = "0x40158F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040158F7 RID: 88311
		[Token(Token = "0x40158F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040158F8 RID: 88312
		[Token(Token = "0x40158F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CollectCollider;

		// Token: 0x040158F9 RID: 88313
		[Token(Token = "0x40158F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckCharacter;

		// Token: 0x040158FA RID: 88314
		[Token(Token = "0x40158FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__NeedUpdateByCharacter;

		// Token: 0x040158FB RID: 88315
		[Token(Token = "0x40158FB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__NeedContainsCharacterAttackRange;

		// Token: 0x040158FC RID: 88316
		[Token(Token = "0x40158FC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateRangeCollider;

		// Token: 0x040158FD RID: 88317
		[Token(Token = "0x40158FD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoRemoveCachedColliders;

		// Token: 0x040158FE RID: 88318
		[Token(Token = "0x40158FE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RemoveCachedColliders;

		// Token: 0x040158FF RID: 88319
		[Token(Token = "0x40158FF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateRangeData;

		// Token: 0x04015900 RID: 88320
		[Token(Token = "0x4015900")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x04015901 RID: 88321
		[Token(Token = "0x4015901")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DoBind;

		// Token: 0x04015902 RID: 88322
		[Token(Token = "0x4015902")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ClearCollidersOnDetach;

		// Token: 0x04015903 RID: 88323
		[Token(Token = "0x4015903")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnCharacterAttackRangeUpdate;

		// Token: 0x04015904 RID: 88324
		[Token(Token = "0x4015904")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
