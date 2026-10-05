using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060C7 RID: 24775
	[Token(Token = "0x20060C7")]
	public class CampaignBriefState : PopupFloatState
	{
		// Token: 0x06023D07 RID: 146695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D07")]
		[Address(RVA = "0x1E6D920", Offset = "0x1E6C520", VA = "0x181E6D920", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023D08 RID: 146696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D08")]
		[Address(RVA = "0x1E6D980", Offset = "0x1E6C580", VA = "0x181E6D980", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023D09 RID: 146697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D09")]
		[Address(RVA = "0x1E6DC10", Offset = "0x1E6C810", VA = "0x181E6DC10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023D0A RID: 146698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D0A")]
		[Address(RVA = "0x1E6DDC0", Offset = "0x1E6C9C0", VA = "0x181E6DDC0")]
		public CampaignBriefState()
		{
		}

		// Token: 0x06023D0C RID: 146700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D0C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04031AA9 RID: 203433
		[Token(Token = "0x4031AA9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CampaignBriefView _view;

		// Token: 0x04031AAA RID: 203434
		[Token(Token = "0x4031AAA")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x04031AAB RID: 203435
		[Token(Token = "0x4031AAB")]
		[FieldOffset(Offset = "0x80")]
		private CampaignBriefStateBean m_stateBean;

		// Token: 0x04031AAC RID: 203436
		[Token(Token = "0x4031AAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031AAD RID: 203437
		[Token(Token = "0x4031AAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04031AAE RID: 203438
		[Token(Token = "0x4031AAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031AAF RID: 203439
		[Token(Token = "0x4031AAF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
