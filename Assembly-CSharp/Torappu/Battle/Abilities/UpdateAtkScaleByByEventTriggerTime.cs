using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C2D RID: 11309
	[Token(Token = "0x2002C2D")]
	public class UpdateAtkScaleByByEventTriggerTime : AbilityStandard.Behaviour
	{
		// Token: 0x06013194 RID: 78228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013194")]
		[Address(RVA = "0xB28130", Offset = "0xB26D30", VA = "0x180B28130", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013195 RID: 78229 RVA: 0x00074940 File Offset: 0x00072B40
		[Token(Token = "0x6013195")]
		[Address(RVA = "0xB28380", Offset = "0xB26F80", VA = "0x180B28380")]
		private FP _GetAtkScale(int eventCnt)
		{
			return default(FP);
		}

		// Token: 0x06013196 RID: 78230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013196")]
		[Address(RVA = "0xB28480", Offset = "0xB27080", VA = "0x180B28480")]
		public UpdateAtkScaleByByEventTriggerTime()
		{
		}

		// Token: 0x06013197 RID: 78231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013197")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0401590B RID: 88331
		[Token(Token = "0x401590B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _atkScaleKeys;

		// Token: 0x0401590C RID: 88332
		[Token(Token = "0x401590C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AbilityStandard.Event _eventToCnt;

		// Token: 0x0401590D RID: 88333
		[Token(Token = "0x401590D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private AbilityStandard.Event _eventToApply;

		// Token: 0x0401590E RID: 88334
		[Token(Token = "0x401590E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AbilityStandard.Event[] _eventToReset;

		// Token: 0x0401590F RID: 88335
		[Token(Token = "0x401590F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _overwrite;

		// Token: 0x04015910 RID: 88336
		[Token(Token = "0x4015910")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _createNewNodeEachTime;

		// Token: 0x04015911 RID: 88337
		[Token(Token = "0x4015911")]
		[FieldOffset(Offset = "0x3C")]
		private int m_eventCnt;

		// Token: 0x04015912 RID: 88338
		[Token(Token = "0x4015912")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015913 RID: 88339
		[Token(Token = "0x4015913")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetAtkScale;

		// Token: 0x04015914 RID: 88340
		[Token(Token = "0x4015914")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
