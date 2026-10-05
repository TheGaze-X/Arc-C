using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200611B RID: 24859
	[Token(Token = "0x200611B")]
	public class CampaignFastBattleCostTktItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023E83 RID: 147075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E83")]
		[Address(RVA = "0x1E86970", Offset = "0x1E85570", VA = "0x181E86970")]
		public void Render(CampaignFastBattleCostTktItem.RenderOptions options)
		{
		}

		// Token: 0x06023E84 RID: 147076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E84")]
		[Address(RVA = "0x1E86B90", Offset = "0x1E85790", VA = "0x181E86B90")]
		public CampaignFastBattleCostTktItem()
		{
		}

		// Token: 0x04031D5A RID: 204122
		[Token(Token = "0x4031D5A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelTo;

		// Token: 0x04031D5B RID: 204123
		[Token(Token = "0x4031D5B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textFrom;

		// Token: 0x04031D5C RID: 204124
		[Token(Token = "0x4031D5C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTo;

		// Token: 0x04031D5D RID: 204125
		[Token(Token = "0x4031D5D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIItemTimeCountDown _timeView;

		// Token: 0x04031D5E RID: 204126
		[Token(Token = "0x4031D5E")]
		[FieldOffset(Offset = "0x38")]
		private CampaignFastBattleCostTktItem.RenderOptions m_options;

		// Token: 0x04031D5F RID: 204127
		[Token(Token = "0x4031D5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031D60 RID: 204128
		[Token(Token = "0x4031D60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200611C RID: 24860
		[Token(Token = "0x200611C")]
		public struct RenderOptions : IHotfixable
		{
			// Token: 0x04031D61 RID: 204129
			[Token(Token = "0x4031D61")]
			[FieldOffset(Offset = "0x0")]
			public ItemUtil.ConsumableInfo itemInfo;

			// Token: 0x04031D62 RID: 204130
			[Token(Token = "0x4031D62")]
			[FieldOffset(Offset = "0x18")]
			public bool useThis;

			// Token: 0x04031D63 RID: 204131
			[Token(Token = "0x4031D63")]
			[FieldOffset(Offset = "0x20")]
			public long remainTs;
		}
	}
}
