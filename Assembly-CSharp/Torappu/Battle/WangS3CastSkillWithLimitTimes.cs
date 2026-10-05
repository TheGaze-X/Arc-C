using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002462 RID: 9314
	[Token(Token = "0x2002462")]
	public class WangS3CastSkillWithLimitTimes : CastSkillWithLimitTimes
	{
		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x0600EFBB RID: 61371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F18")]
		private Deck.TokenCard tokenCard
		{
			[Token(Token = "0x600EFBB")]
			[Address(RVA = "0x6810A0", Offset = "0x67FCA0", VA = "0x1806810A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EFBC RID: 61372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFBC")]
		[Address(RVA = "0x680C80", Offset = "0x67F880", VA = "0x180680C80", Slot = "61")]
		public override void OnOwnerFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600EFBD RID: 61373 RVA: 0x000584B8 File Offset: 0x000566B8
		[Token(Token = "0x600EFBD")]
		[Address(RVA = "0x680F60", Offset = "0x67FB60", VA = "0x180680F60", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EFBE RID: 61374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFBE")]
		[Address(RVA = "0x680DD0", Offset = "0x67F9D0", VA = "0x180680DD0", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EFBF RID: 61375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFBF")]
		[Address(RVA = "0x680B40", Offset = "0x67F740", VA = "0x180680B40", Slot = "82")]
		protected override void OnDiscard()
		{
		}

		// Token: 0x0600EFC0 RID: 61376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFC0")]
		[Address(RVA = "0x680D10", Offset = "0x67F910", VA = "0x180680D10", Slot = "50")]
		protected override void OnSkillEnd()
		{
		}

		// Token: 0x0600EFC1 RID: 61377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFC1")]
		[Address(RVA = "0x680AA0", Offset = "0x67F6A0", VA = "0x180680AA0", Slot = "72")]
		public override void GatherBuffs(List<BuffData> result)
		{
		}

		// Token: 0x0600EFC2 RID: 61378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFC2")]
		[Address(RVA = "0x680FE0", Offset = "0x67FBE0", VA = "0x180680FE0")]
		public WangS3CastSkillWithLimitTimes()
		{
		}

		// Token: 0x0600EFC3 RID: 61379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFC3")]
		[Address(RVA = "0x635EF0", Offset = "0x634AF0", VA = "0x180635EF0")]
		private void <>xLuaBaseProxy_OnOwnerFinish(Entity.FinishReason P0)
		{
		}

		// Token: 0x0600EFC4 RID: 61380 RVA: 0x000584D0 File Offset: 0x000566D0
		[Token(Token = "0x600EFC4")]
		[Address(RVA = "0x680F50", Offset = "0x67FB50", VA = "0x180680F50")]
		private bool <>xLuaBaseProxy_UseSkill(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EFC5 RID: 61381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFC5")]
		[Address(RVA = "0x680F40", Offset = "0x67FB40", VA = "0x180680F40")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600EFC6 RID: 61382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFC6")]
		[Address(RVA = "0x680F30", Offset = "0x67FB30", VA = "0x180680F30")]
		private void <>xLuaBaseProxy_OnDiscard()
		{
		}

		// Token: 0x0600EFC7 RID: 61383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFC7")]
		[Address(RVA = "0x67A300", Offset = "0x678F00", VA = "0x18067A300")]
		private void <>xLuaBaseProxy_OnSkillEnd()
		{
		}

		// Token: 0x0600EFC8 RID: 61384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFC8")]
		[Address(RVA = "0x640360", Offset = "0x63EF60", VA = "0x180640360")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0401091A RID: 67866
		[Token(Token = "0x401091A")]
		private const int DELAY_TO_STOP_SKILL = 1;

		// Token: 0x0401091B RID: 67867
		[Token(Token = "0x401091B")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private WangVisualStoneCtrlAbility _ctrlAbility;

		// Token: 0x0401091C RID: 67868
		[Token(Token = "0x401091C")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private BuffData[] _buffWhenDiscardWithBullet;

		// Token: 0x0401091D RID: 67869
		[Token(Token = "0x401091D")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private string _bulletDiscardCntKey;

		// Token: 0x0401091E RID: 67870
		[Token(Token = "0x401091E")]
		[FieldOffset(Offset = "0x1A0")]
		private Deck.TokenCard m_tokenCard;

		// Token: 0x0401091F RID: 67871
		[Token(Token = "0x401091F")]
		[FieldOffset(Offset = "0x1A8")]
		private int m_delayToCheckStopSkill;

		// Token: 0x04010920 RID: 67872
		[Token(Token = "0x4010920")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tokenCard;

		// Token: 0x04010921 RID: 67873
		[Token(Token = "0x4010921")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnOwnerFinish;

		// Token: 0x04010922 RID: 67874
		[Token(Token = "0x4010922")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x04010923 RID: 67875
		[Token(Token = "0x4010923")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010924 RID: 67876
		[Token(Token = "0x4010924")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDiscard;

		// Token: 0x04010925 RID: 67877
		[Token(Token = "0x4010925")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x04010926 RID: 67878
		[Token(Token = "0x4010926")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04010927 RID: 67879
		[Token(Token = "0x4010927")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
