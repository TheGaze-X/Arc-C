using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006142 RID: 24898
	[Token(Token = "0x2006142")]
	public class CampaignZoneMapStageNodeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023F0D RID: 147213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F0D")]
		[Address(RVA = "0x1E96140", Offset = "0x1E94D40", VA = "0x181E96140")]
		public void Render(CampaignZoneMapStageViewModel viewModel, string selectedStage, int seqNum)
		{
		}

		// Token: 0x06023F0E RID: 147214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F0E")]
		[Address(RVA = "0x1E96490", Offset = "0x1E95090", VA = "0x181E96490")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023F0F RID: 147215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F0F")]
		[Address(RVA = "0x1E965C0", Offset = "0x1E951C0", VA = "0x181E965C0")]
		public CampaignZoneMapStageNodeView()
		{
		}

		// Token: 0x04031E6D RID: 204397
		[Token(Token = "0x4031E6D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x04031E6E RID: 204398
		[Token(Token = "0x4031E6E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelRotate;

		// Token: 0x04031E6F RID: 204399
		[Token(Token = "0x4031E6F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelPerm;

		// Token: 0x04031E70 RID: 204400
		[Token(Token = "0x4031E70")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelTraining;

		// Token: 0x04031E71 RID: 204401
		[Token(Token = "0x4031E71")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04031E72 RID: 204402
		[Token(Token = "0x4031E72")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _panelUncompleted;

		// Token: 0x04031E73 RID: 204403
		[Token(Token = "0x4031E73")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _selectedAnim;

		// Token: 0x04031E74 RID: 204404
		[Token(Token = "0x4031E74")]
		[FieldOffset(Offset = "0x58")]
		private UISwitchTween m_switchTween;

		// Token: 0x04031E75 RID: 204405
		[Token(Token = "0x4031E75")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04031E76 RID: 204406
		[Token(Token = "0x4031E76")]
		[FieldOffset(Offset = "0x64")]
		private int m_sequenceNum;

		// Token: 0x04031E77 RID: 204407
		[Token(Token = "0x4031E77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031E78 RID: 204408
		[Token(Token = "0x4031E78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031E79 RID: 204409
		[Token(Token = "0x4031E79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
