using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002453 RID: 9299
	[Token(Token = "0x2002453")]
	public class CastSkillWithSuspendable : CastSkill
	{
		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x0600EEF4 RID: 61172 RVA: 0x00057DF8 File Offset: 0x00055FF8
		[Token(Token = "0x17001F03")]
		public override bool isOverloadSkill
		{
			[Token(Token = "0x600EEF4")]
			[Address(RVA = "0x66D900", Offset = "0x66C500", VA = "0x18066D900", Slot = "47")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EEF5 RID: 61173 RVA: 0x00057E10 File Offset: 0x00056010
		[Token(Token = "0x600EEF5")]
		[Address(RVA = "0x66D380", Offset = "0x66BF80", VA = "0x18066D380", Slot = "24")]
		public override bool IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x0600EEF6 RID: 61174 RVA: 0x00057E28 File Offset: 0x00056028
		[Token(Token = "0x600EEF6")]
		[Address(RVA = "0x66D5E0", Offset = "0x66C1E0", VA = "0x18066D5E0", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EEF7 RID: 61175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEF7")]
		[Address(RVA = "0x66D490", Offset = "0x66C090", VA = "0x18066D490")]
		protected void TriggerSpecialAudioSignal()
		{
		}

		// Token: 0x0600EEF8 RID: 61176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEF8")]
		[Address(RVA = "0x66D2E0", Offset = "0x66BEE0", VA = "0x18066D2E0", Slot = "72")]
		public override void GatherBuffs(List<BuffData> buffs)
		{
		}

		// Token: 0x0600EEF9 RID: 61177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEF9")]
		[Address(RVA = "0x66D840", Offset = "0x66C440", VA = "0x18066D840")]
		public CastSkillWithSuspendable()
		{
		}

		// Token: 0x0600EEFA RID: 61178 RVA: 0x00057E40 File Offset: 0x00056040
		[Token(Token = "0x600EEFA")]
		[Address(RVA = "0x66D5D0", Offset = "0x66C1D0", VA = "0x18066D5D0")]
		private bool <>xLuaBaseProxy_get_isOverloadSkill()
		{
			return default(bool);
		}

		// Token: 0x0600EEFB RID: 61179 RVA: 0x00057E58 File Offset: 0x00056058
		[Token(Token = "0x600EEFB")]
		[Address(RVA = "0x66D5C0", Offset = "0x66C1C0", VA = "0x18066D5C0")]
		private bool <>xLuaBaseProxy_IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x0600EEFC RID: 61180 RVA: 0x00057E70 File Offset: 0x00056070
		[Token(Token = "0x600EEFC")]
		[Address(RVA = "0x641630", Offset = "0x640230", VA = "0x180641630")]
		private bool <>xLuaBaseProxy_UseSkill(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EEFD RID: 61181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEFD")]
		[Address(RVA = "0x640360", Offset = "0x63EF60", VA = "0x180640360")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x04010844 RID: 67652
		[Token(Token = "0x4010844")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private bool _isOverloadSkill;

		// Token: 0x04010845 RID: 67653
		[Token(Token = "0x4010845")]
		[FieldOffset(Offset = "0x141")]
		[SerializeField]
		private bool _checkFinishedBuffWhenStopAffect;

		// Token: 0x04010846 RID: 67654
		[Token(Token = "0x4010846")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private int _suspendableLimitedTimes;

		// Token: 0x04010847 RID: 67655
		[Token(Token = "0x4010847")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private BuffData[] _buffsWhenDiscard;

		// Token: 0x04010848 RID: 67656
		[Token(Token = "0x4010848")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private bool _discardableInDoze;

		// Token: 0x04010849 RID: 67657
		[Token(Token = "0x4010849")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isOverloadSkill;

		// Token: 0x0401084A RID: 67658
		[Token(Token = "0x401084A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsDiscardable;

		// Token: 0x0401084B RID: 67659
		[Token(Token = "0x401084B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x0401084C RID: 67660
		[Token(Token = "0x401084C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TriggerSpecialAudioSignal;

		// Token: 0x0401084D RID: 67661
		[Token(Token = "0x401084D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0401084E RID: 67662
		[Token(Token = "0x401084E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
