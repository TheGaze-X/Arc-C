using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065DC RID: 26076
	[Token(Token = "0x20065DC")]
	public class ArtGalleryCollectDetailMissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060257C2 RID: 153538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257C2")]
		[Address(RVA = "0x2057300", Offset = "0x2055F00", VA = "0x182057300")]
		public void Render(ArtGalleryCollectDetailMissionItemViewModel itemViewModel)
		{
		}

		// Token: 0x060257C3 RID: 153539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257C3")]
		[Address(RVA = "0x2057700", Offset = "0x2056300", VA = "0x182057700")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060257C4 RID: 153540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257C4")]
		[Address(RVA = "0x20571B0", Offset = "0x2055DB0", VA = "0x1820571B0")]
		public void EventOnClaimMissionRewardsClick()
		{
		}

		// Token: 0x060257C5 RID: 153541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257C5")]
		[Address(RVA = "0x2057850", Offset = "0x2056450", VA = "0x182057850")]
		public ArtGalleryCollectDetailMissionItemView()
		{
		}

		// Token: 0x040349C8 RID: 215496
		[Token(Token = "0x40349C8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasBasePart;

		// Token: 0x040349C9 RID: 215497
		[Token(Token = "0x40349C9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _claimedAlpha;

		// Token: 0x040349CA RID: 215498
		[Token(Token = "0x40349CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objClaimedPart;

		// Token: 0x040349CB RID: 215499
		[Token(Token = "0x40349CB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objCanClaimBg;

		// Token: 0x040349CC RID: 215500
		[Token(Token = "0x40349CC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objCanClaimPart;

		// Token: 0x040349CD RID: 215501
		[Token(Token = "0x40349CD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objNumMaskCanClaim;

		// Token: 0x040349CE RID: 215502
		[Token(Token = "0x40349CE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objNumMask;

		// Token: 0x040349CF RID: 215503
		[Token(Token = "0x40349CF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Font _numFont;

		// Token: 0x040349D0 RID: 215504
		[Token(Token = "0x40349D0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _txtRequireCnt;

		// Token: 0x040349D1 RID: 215505
		[Token(Token = "0x40349D1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colNumNotAvailable;

		// Token: 0x040349D2 RID: 215506
		[Token(Token = "0x40349D2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colNumAvailable;

		// Token: 0x040349D3 RID: 215507
		[Token(Token = "0x40349D3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x040349D4 RID: 215508
		[Token(Token = "0x40349D4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _rewardItemList;

		// Token: 0x040349D5 RID: 215509
		[Token(Token = "0x40349D5")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x040349D6 RID: 215510
		[Token(Token = "0x40349D6")]
		[FieldOffset(Offset = "0x98")]
		private string m_setId;

		// Token: 0x040349D7 RID: 215511
		[Token(Token = "0x40349D7")]
		[FieldOffset(Offset = "0xA0")]
		private string m_missionId;

		// Token: 0x040349D8 RID: 215512
		[Token(Token = "0x40349D8")]
		[FieldOffset(Offset = "0xA8")]
		private List<ItemBundle> m_rewardItems;

		// Token: 0x040349D9 RID: 215513
		[Token(Token = "0x40349D9")]
		[FieldOffset(Offset = "0xB0")]
		private ArtGalleryCollectDetailMissionItemView.Adapter m_rewardListAdapter;

		// Token: 0x040349DA RID: 215514
		[Token(Token = "0x40349DA")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040349DB RID: 215515
		[Token(Token = "0x40349DB")]
		[FieldOffset(Offset = "0xC8")]
		private ArtGalleryCollectDetailMissionItemViewModel.ClaimState m_claimState;

		// Token: 0x040349DC RID: 215516
		[Token(Token = "0x40349DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040349DD RID: 215517
		[Token(Token = "0x40349DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040349DE RID: 215518
		[Token(Token = "0x40349DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClaimMissionRewardsClick;

		// Token: 0x040349DF RID: 215519
		[Token(Token = "0x40349DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065DD RID: 26077
		[Token(Token = "0x20065DD")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060257C6 RID: 153542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60257C6")]
			[Address(RVA = "0x20570A0", Offset = "0x2055CA0", VA = "0x1820570A0")]
			public Adapter(ArtGalleryCollectDetailMissionItemView closure)
			{
			}

			// Token: 0x17005899 RID: 22681
			// (get) Token: 0x060257C7 RID: 153543 RVA: 0x000C80A0 File Offset: 0x000C62A0
			[Token(Token = "0x17005899")]
			public override int count
			{
				[Token(Token = "0x60257C7")]
				[Address(RVA = "0x2057120", Offset = "0x2055D20", VA = "0x182057120", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060257C8 RID: 153544 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60257C8")]
			[Address(RVA = "0x2056EE0", Offset = "0x2055AE0", VA = "0x182056EE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040349E0 RID: 215520
			[Token(Token = "0x40349E0")]
			[FieldOffset(Offset = "0x20")]
			private ArtGalleryCollectDetailMissionItemView m_closure;

			// Token: 0x040349E1 RID: 215521
			[Token(Token = "0x40349E1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040349E2 RID: 215522
			[Token(Token = "0x40349E2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040349E3 RID: 215523
			[Token(Token = "0x40349E3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
