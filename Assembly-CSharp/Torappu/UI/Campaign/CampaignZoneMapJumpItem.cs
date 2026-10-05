using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006134 RID: 24884
	[Token(Token = "0x2006134")]
	public class CampaignZoneMapJumpItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023EDE RID: 147166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EDE")]
		[Address(RVA = "0x1E93580", Offset = "0x1E92180", VA = "0x181E93580")]
		public void Render(CampaignZoneJumpViewModel jumpViewModel)
		{
		}

		// Token: 0x06023EDF RID: 147167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EDF")]
		[Address(RVA = "0x1E934F0", Offset = "0x1E920F0", VA = "0x181E934F0")]
		public void OnClick()
		{
		}

		// Token: 0x06023EE0 RID: 147168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EE0")]
		[Address(RVA = "0x1E93800", Offset = "0x1E92400", VA = "0x181E93800")]
		private void _RenderTrackPoint(bool hasUnconfirmed)
		{
		}

		// Token: 0x06023EE1 RID: 147169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EE1")]
		[Address(RVA = "0x1E93A10", Offset = "0x1E92610", VA = "0x181E93A10")]
		public CampaignZoneMapJumpItem()
		{
		}

		// Token: 0x04031DFF RID: 204287
		[Token(Token = "0x4031DFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _zoneIcon;

		// Token: 0x04031E00 RID: 204288
		[Token(Token = "0x4031E00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageCode;

		// Token: 0x04031E01 RID: 204289
		[Token(Token = "0x4031E01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x04031E02 RID: 204290
		[Token(Token = "0x4031E02")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _stageType;

		// Token: 0x04031E03 RID: 204291
		[Token(Token = "0x4031E03")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _commonBack;

		// Token: 0x04031E04 RID: 204292
		[Token(Token = "0x4031E04")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _alreadyFinishBack;

		// Token: 0x04031E05 RID: 204293
		[Token(Token = "0x4031E05")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _newBack;

		// Token: 0x04031E06 RID: 204294
		[Token(Token = "0x4031E06")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _trackPoint;

		// Token: 0x04031E07 RID: 204295
		[Token(Token = "0x4031E07")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _trackPointHolder;

		// Token: 0x04031E08 RID: 204296
		[Token(Token = "0x4031E08")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public CampaignZoneJumpEvent onClick;

		// Token: 0x04031E09 RID: 204297
		[Token(Token = "0x4031E09")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_trackPoint;

		// Token: 0x04031E0A RID: 204298
		[Token(Token = "0x4031E0A")]
		[FieldOffset(Offset = "0x70")]
		private CampaignZoneJumpViewModel m_cacheJumpViewModel;

		// Token: 0x04031E0B RID: 204299
		[Token(Token = "0x4031E0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031E0C RID: 204300
		[Token(Token = "0x4031E0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04031E0D RID: 204301
		[Token(Token = "0x4031E0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderTrackPoint;

		// Token: 0x04031E0E RID: 204302
		[Token(Token = "0x4031E0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
