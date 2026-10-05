using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A3E RID: 31294
	[Token(Token = "0x2007A3E")]
	public class Act13sideOrgPanelView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170066CE RID: 26318
		// (get) Token: 0x0602BD8C RID: 179596 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BD8D RID: 179597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066CE")]
		public Action<Act13SideData.OrgData, Act13SideData.PrestigeRank> onRewardClick
		{
			[Token(Token = "0x602BD8C")]
			[Address(RVA = "0x27CEDD0", Offset = "0x27CD9D0", VA = "0x1827CEDD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BD8D")]
			[Address(RVA = "0x27CEE30", Offset = "0x27CDA30", VA = "0x1827CEE30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BD8E RID: 179598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD8E")]
		[Address(RVA = "0x27CE480", Offset = "0x27CD080", VA = "0x1827CE480")]
		public void Render(string actId, bool needSliderAnim)
		{
		}

		// Token: 0x0602BD8F RID: 179599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BD8F")]
		[Address(RVA = "0x27CE330", Offset = "0x27CCF30", VA = "0x1827CE330")]
		public Tweener PlaySliderAnim()
		{
			return null;
		}

		// Token: 0x0602BD90 RID: 179600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD90")]
		[Address(RVA = "0x27CE210", Offset = "0x27CCE10", VA = "0x1827CE210")]
		public void OnBtnRewardClick()
		{
		}

		// Token: 0x0602BD91 RID: 179601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD91")]
		[Address(RVA = "0x27CED70", Offset = "0x27CD970", VA = "0x1827CED70")]
		public Act13sideOrgPanelView()
		{
		}

		// Token: 0x0403F7B0 RID: 260016
		[Token(Token = "0x403F7B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _orgId;

		// Token: 0x0403F7B1 RID: 260017
		[Token(Token = "0x403F7B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgOrgLogo;

		// Token: 0x0403F7B2 RID: 260018
		[Token(Token = "0x403F7B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgOrgTitle;

		// Token: 0x0403F7B3 RID: 260019
		[Token(Token = "0x403F7B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgEmoji;

		// Token: 0x0403F7B4 RID: 260020
		[Token(Token = "0x403F7B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textPrestige;

		// Token: 0x0403F7B5 RID: 260021
		[Token(Token = "0x403F7B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textArchiveCount;

		// Token: 0x0403F7B6 RID: 260022
		[Token(Token = "0x403F7B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textNewsCount;

		// Token: 0x0403F7B7 RID: 260023
		[Token(Token = "0x403F7B7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textAvgCount;

		// Token: 0x0403F7B8 RID: 260024
		[Token(Token = "0x403F7B8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _prestigeProgressContaniner;

		// Token: 0x0403F7B9 RID: 260025
		[Token(Token = "0x403F7B9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Act13sidePrestigeProgressView _progressViewTemplate;

		// Token: 0x0403F7BA RID: 260026
		[Token(Token = "0x403F7BA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _activePartGo;

		// Token: 0x0403F7BB RID: 260027
		[Token(Token = "0x403F7BB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0403F7BC RID: 260028
		[Token(Token = "0x403F7BC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textUnlockTime;

		// Token: 0x0403F7BD RID: 260029
		[Token(Token = "0x403F7BD")]
		[FieldOffset(Offset = "0x80")]
		private string m_actId;

		// Token: 0x0403F7BE RID: 260030
		[Token(Token = "0x403F7BE")]
		[FieldOffset(Offset = "0x88")]
		private Act13SideData.OrgData m_orgData;

		// Token: 0x0403F7BF RID: 260031
		[Token(Token = "0x403F7BF")]
		[FieldOffset(Offset = "0x90")]
		private Act13sidePrestigeProgressView m_progressView;

		// Token: 0x0403F7C0 RID: 260032
		[Token(Token = "0x403F7C0")]
		[FieldOffset(Offset = "0x98")]
		private float m_progressVal;

		// Token: 0x0403F7C1 RID: 260033
		[Token(Token = "0x403F7C1")]
		[FieldOffset(Offset = "0x9C")]
		private Act13SideData.PrestigeRank m_currentRank;

		// Token: 0x0403F7C3 RID: 260035
		[Token(Token = "0x403F7C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onRewardClick;

		// Token: 0x0403F7C4 RID: 260036
		[Token(Token = "0x403F7C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onRewardClick;

		// Token: 0x0403F7C5 RID: 260037
		[Token(Token = "0x403F7C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F7C6 RID: 260038
		[Token(Token = "0x403F7C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlaySliderAnim;

		// Token: 0x0403F7C7 RID: 260039
		[Token(Token = "0x403F7C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnRewardClick;

		// Token: 0x0403F7C8 RID: 260040
		[Token(Token = "0x403F7C8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
