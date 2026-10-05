using System;
using Il2CppDummyDll;
using Torappu.UI.Stage.Campaign;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200687D RID: 26749
	[Token(Token = "0x200687D")]
	public class StageCampaignRuleState : PopupFloatState
	{
		// Token: 0x060264FD RID: 156925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60264FD")]
		[Address(RVA = "0x2161B20", Offset = "0x2160720", VA = "0x182161B20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060264FE RID: 156926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264FE")]
		[Address(RVA = "0x2161B80", Offset = "0x2160780", VA = "0x182161B80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060264FF RID: 156927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264FF")]
		[Address(RVA = "0x2161C50", Offset = "0x2160850", VA = "0x182161C50", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06026500 RID: 156928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026500")]
		[Address(RVA = "0x2161CB0", Offset = "0x21608B0", VA = "0x182161CB0")]
		public StageCampaignRuleState()
		{
		}

		// Token: 0x06026501 RID: 156929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026501")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026502 RID: 156930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026502")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04035F7C RID: 221052
		[Token(Token = "0x4035F7C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CampaignRuleView _campaignRuleView;

		// Token: 0x04035F7D RID: 221053
		[Token(Token = "0x4035F7D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private StageCampaignRuleStateBean _stateBean;

		// Token: 0x04035F7E RID: 221054
		[Token(Token = "0x4035F7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04035F7F RID: 221055
		[Token(Token = "0x4035F7F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04035F80 RID: 221056
		[Token(Token = "0x4035F80")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04035F81 RID: 221057
		[Token(Token = "0x4035F81")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
