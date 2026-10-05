using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006133 RID: 24883
	[Token(Token = "0x2006133")]
	public class StagePreviewCampaignSummaryInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023EDB RID: 147163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EDB")]
		[Address(RVA = "0x1E9BA70", Offset = "0x1E9A670", VA = "0x181E9BA70")]
		public void Render(CampaignStateViewModel campModel)
		{
		}

		// Token: 0x06023EDC RID: 147164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EDC")]
		[Address(RVA = "0x1E9BD70", Offset = "0x1E9A970", VA = "0x181E9BD70")]
		private void _RenderHighlightAndTrackPoint(bool hasUnconfirmed)
		{
		}

		// Token: 0x06023EDD RID: 147165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EDD")]
		[Address(RVA = "0x1E9BE00", Offset = "0x1E9AA00", VA = "0x181E9BE00")]
		public StagePreviewCampaignSummaryInfoView()
		{
		}

		// Token: 0x04031DF9 RID: 204281
		[Token(Token = "0x4031DF9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _campaignBreakProgText;

		// Token: 0x04031DFA RID: 204282
		[Token(Token = "0x4031DFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _highlight;

		// Token: 0x04031DFB RID: 204283
		[Token(Token = "0x4031DFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EasyInstancePool _breakRewardTogglePool;

		// Token: 0x04031DFC RID: 204284
		[Token(Token = "0x4031DFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031DFD RID: 204285
		[Token(Token = "0x4031DFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderHighlightAndTrackPoint;

		// Token: 0x04031DFE RID: 204286
		[Token(Token = "0x4031DFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
