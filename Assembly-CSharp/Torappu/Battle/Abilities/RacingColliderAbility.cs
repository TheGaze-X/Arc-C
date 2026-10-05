using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B3E RID: 11070
	[Token(Token = "0x2002B3E")]
	[RequireComponent(typeof(Collider2D))]
	public class RacingColliderAbility : EmptyAbility
	{
		// Token: 0x06012911 RID: 76049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012911")]
		[Address(RVA = "0xA8F7E0", Offset = "0xA8E3E0", VA = "0x180A8F7E0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012912 RID: 76050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012912")]
		[Address(RVA = "0xA8F650", Offset = "0xA8E250", VA = "0x180A8F650", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012913 RID: 76051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012913")]
		[Address(RVA = "0xA8F720", Offset = "0xA8E320", VA = "0x180A8F720", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012914 RID: 76052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012914")]
		[Address(RVA = "0xA8FC90", Offset = "0xA8E890", VA = "0x180A8FC90", Slot = "58")]
		public override void PreloadSpecialAudioSignals(string characterId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x06012915 RID: 76053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012915")]
		[Address(RVA = "0xA8FE60", Offset = "0xA8EA60", VA = "0x180A8FE60")]
		private void _DealCollisionWithRacingEnemy(Collider2D collision)
		{
		}

		// Token: 0x06012916 RID: 76054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012916")]
		[Address(RVA = "0xA90030", Offset = "0xA8EC30", VA = "0x180A90030")]
		private void _DealCollisionWithWall(Collider2D collision)
		{
		}

		// Token: 0x06012917 RID: 76055 RVA: 0x00071C58 File Offset: 0x0006FE58
		[Token(Token = "0x6012917")]
		[Address(RVA = "0xA8FD70", Offset = "0xA8E970", VA = "0x180A8FD70")]
		private bool _CheckCollisionCondition(RacingEnemy self, RacingEnemy another)
		{
			return default(bool);
		}

		// Token: 0x06012918 RID: 76056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012918")]
		[Address(RVA = "0xA8F970", Offset = "0xA8E570", VA = "0x180A8F970", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012919 RID: 76057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012919")]
		[Address(RVA = "0xA90100", Offset = "0xA8ED00", VA = "0x180A90100")]
		private void _PlayEffect()
		{
		}

		// Token: 0x0601291A RID: 76058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601291A")]
		[Address(RVA = "0xA8FA30", Offset = "0xA8E630", VA = "0x180A8FA30")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		// Token: 0x0601291B RID: 76059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601291B")]
		[Address(RVA = "0xA90330", Offset = "0xA8EF30", VA = "0x180A90330")]
		public RacingColliderAbility()
		{
		}

		// Token: 0x0601291C RID: 76060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601291C")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0601291D RID: 76061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601291D")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x0601291E RID: 76062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601291E")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0601291F RID: 76063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601291F")]
		[Address(RVA = "0xA66040", Offset = "0xA64C40", VA = "0x180A66040")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x06012920 RID: 76064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012920")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x04014F98 RID: 85912
		[Token(Token = "0x4014F98")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private string _collisionEffect;

		// Token: 0x04014F99 RID: 85913
		[Token(Token = "0x4014F99")]
		[FieldOffset(Offset = "0x118")]
		private ObjectPtr<RacingEnemy> m_racingEnemy;

		// Token: 0x04014F9A RID: 85914
		[Token(Token = "0x4014F9A")]
		[FieldOffset(Offset = "0x128")]
		private Collider2D m_collider;

		// Token: 0x04014F9B RID: 85915
		[Token(Token = "0x4014F9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014F9C RID: 85916
		[Token(Token = "0x4014F9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014F9D RID: 85917
		[Token(Token = "0x4014F9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014F9E RID: 85918
		[Token(Token = "0x4014F9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04014F9F RID: 85919
		[Token(Token = "0x4014F9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DealCollisionWithRacingEnemy;

		// Token: 0x04014FA0 RID: 85920
		[Token(Token = "0x4014FA0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DealCollisionWithWall;

		// Token: 0x04014FA1 RID: 85921
		[Token(Token = "0x4014FA1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckCollisionCondition;

		// Token: 0x04014FA2 RID: 85922
		[Token(Token = "0x4014FA2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014FA3 RID: 85923
		[Token(Token = "0x4014FA3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayEffect;

		// Token: 0x04014FA4 RID: 85924
		[Token(Token = "0x4014FA4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTriggerEnter2D;

		// Token: 0x04014FA5 RID: 85925
		[Token(Token = "0x4014FA5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
