using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006809 RID: 26633
	[Token(Token = "0x2006809")]
	public class RetroTrailRuleState : PopupFloatState
	{
		// Token: 0x06026293 RID: 156307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026293")]
		[Address(RVA = "0x21339A0", Offset = "0x21325A0", VA = "0x1821339A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06026294 RID: 156308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026294")]
		[Address(RVA = "0x2133A00", Offset = "0x2132600", VA = "0x182133A00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026295 RID: 156309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026295")]
		[Address(RVA = "0x2133C40", Offset = "0x2132840", VA = "0x182133C40")]
		public RetroTrailRuleState()
		{
		}

		// Token: 0x06026296 RID: 156310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026296")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04035C13 RID: 220179
		[Token(Token = "0x4035C13")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Text> _titleList;

		// Token: 0x04035C14 RID: 220180
		[Token(Token = "0x4035C14")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<Text> _descList;

		// Token: 0x04035C15 RID: 220181
		[Token(Token = "0x4035C15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04035C16 RID: 220182
		[Token(Token = "0x4035C16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04035C17 RID: 220183
		[Token(Token = "0x4035C17")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
