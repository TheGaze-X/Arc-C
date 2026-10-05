using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006892 RID: 26770
	[Token(Token = "0x2006892")]
	public class StageRetroCoinRuleState : PopupFloatState
	{
		// Token: 0x060265C7 RID: 157127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60265C7")]
		[Address(RVA = "0x216E4D0", Offset = "0x216D0D0", VA = "0x18216E4D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060265C8 RID: 157128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265C8")]
		[Address(RVA = "0x216E980", Offset = "0x216D580", VA = "0x18216E980")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060265C9 RID: 157129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265C9")]
		[Address(RVA = "0x216E530", Offset = "0x216D130", VA = "0x18216E530", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060265CA RID: 157130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265CA")]
		[Address(RVA = "0x216EAA0", Offset = "0x216D6A0", VA = "0x18216EAA0")]
		public StageRetroCoinRuleState()
		{
		}

		// Token: 0x060265CB RID: 157131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265CB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04036062 RID: 221282
		[Token(Token = "0x4036062")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _ruleText;

		// Token: 0x04036063 RID: 221283
		[Token(Token = "0x4036063")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x04036064 RID: 221284
		[Token(Token = "0x4036064")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04036065 RID: 221285
		[Token(Token = "0x4036065")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036066 RID: 221286
		[Token(Token = "0x4036066")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036067 RID: 221287
		[Token(Token = "0x4036067")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
