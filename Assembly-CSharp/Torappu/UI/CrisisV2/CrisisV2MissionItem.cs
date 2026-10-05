using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005996 RID: 22934
	[Token(Token = "0x2005996")]
	public class CrisisV2MissionItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060216E0 RID: 136928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216E0")]
		[Address(RVA = "0x1BC9170", Offset = "0x1BC7D70", VA = "0x181BC9170")]
		public void Render(CrisisV2MissionItemModel viewModel)
		{
		}

		// Token: 0x060216E1 RID: 136929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216E1")]
		[Address(RVA = "0x1BC9530", Offset = "0x1BC8130", VA = "0x181BC9530")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060216E2 RID: 136930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216E2")]
		[Address(RVA = "0x1BC9670", Offset = "0x1BC8270", VA = "0x181BC9670")]
		private void _PlayBreathLightTween(bool isPlay)
		{
		}

		// Token: 0x060216E3 RID: 136931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216E3")]
		[Address(RVA = "0x1BC9070", Offset = "0x1BC7C70", VA = "0x181BC9070")]
		public void OnJumpToSlotClicked()
		{
		}

		// Token: 0x060216E4 RID: 136932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216E4")]
		[Address(RVA = "0x1BC8F70", Offset = "0x1BC7B70", VA = "0x181BC8F70")]
		public void OnClaimSingleMissionClicked()
		{
		}

		// Token: 0x060216E5 RID: 136933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216E5")]
		[Address(RVA = "0x1BC9870", Offset = "0x1BC8470", VA = "0x181BC9870")]
		public CrisisV2MissionItem()
		{
		}

		// Token: 0x0402D9DB RID: 186843
		[Token(Token = "0x402D9DB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _colorTitleComplete;

		// Token: 0x0402D9DC RID: 186844
		[Token(Token = "0x402D9DC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _colorTitleUncomplete;

		// Token: 0x0402D9DD RID: 186845
		[Token(Token = "0x402D9DD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorDescComplete;

		// Token: 0x0402D9DE RID: 186846
		[Token(Token = "0x402D9DE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorDescUncomplete;

		// Token: 0x0402D9DF RID: 186847
		[Token(Token = "0x402D9DF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _notClaimedAlpha;

		// Token: 0x0402D9E0 RID: 186848
		[Token(Token = "0x402D9E0")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _claimedAlpha;

		// Token: 0x0402D9E1 RID: 186849
		[Token(Token = "0x402D9E1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _unlockPart;

		// Token: 0x0402D9E2 RID: 186850
		[Token(Token = "0x402D9E2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TwoStateToggle _jumpToSlotToggle;

		// Token: 0x0402D9E3 RID: 186851
		[Token(Token = "0x402D9E3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _completePart;

		// Token: 0x0402D9E4 RID: 186852
		[Token(Token = "0x402D9E4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _completeOutLight;

		// Token: 0x0402D9E5 RID: 186853
		[Token(Token = "0x402D9E5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _claimedMask;

		// Token: 0x0402D9E6 RID: 186854
		[Token(Token = "0x402D9E6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0402D9E7 RID: 186855
		[Token(Token = "0x402D9E7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0402D9E8 RID: 186856
		[Token(Token = "0x402D9E8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SimpleLayoutContent _rewardContent;

		// Token: 0x0402D9E9 RID: 186857
		[Token(Token = "0x402D9E9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x0402D9EA RID: 186858
		[Token(Token = "0x402D9EA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CanvasGroup _breathLightCanvasGroup;

		// Token: 0x0402D9EB RID: 186859
		[Token(Token = "0x402D9EB")]
		[FieldOffset(Offset = "0xB0")]
		private CrisisV2MissionItemModel m_viewModel;

		// Token: 0x0402D9EC RID: 186860
		[Token(Token = "0x402D9EC")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_hasInited;

		// Token: 0x0402D9ED RID: 186861
		[Token(Token = "0x402D9ED")]
		[FieldOffset(Offset = "0xC0")]
		private CrisisV2MissionItem.RewardAdapter m_adapter;

		// Token: 0x0402D9EE RID: 186862
		[Token(Token = "0x402D9EE")]
		[FieldOffset(Offset = "0xC8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402D9EF RID: 186863
		[Token(Token = "0x402D9EF")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_breathLightTween;

		// Token: 0x0402D9F0 RID: 186864
		[Token(Token = "0x402D9F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D9F1 RID: 186865
		[Token(Token = "0x402D9F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D9F2 RID: 186866
		[Token(Token = "0x402D9F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayBreathLightTween;

		// Token: 0x0402D9F3 RID: 186867
		[Token(Token = "0x402D9F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnJumpToSlotClicked;

		// Token: 0x0402D9F4 RID: 186868
		[Token(Token = "0x402D9F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClaimSingleMissionClicked;

		// Token: 0x0402D9F5 RID: 186869
		[Token(Token = "0x402D9F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005997 RID: 22935
		[Token(Token = "0x2005997")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060216E6 RID: 136934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60216E6")]
			[Address(RVA = "0x1BD02E0", Offset = "0x1BCEEE0", VA = "0x181BD02E0")]
			public RewardAdapter(CrisisV2MissionItem closure)
			{
			}

			// Token: 0x17004EA1 RID: 20129
			// (get) Token: 0x060216E7 RID: 136935 RVA: 0x000BA408 File Offset: 0x000B8608
			[Token(Token = "0x17004EA1")]
			public override int count
			{
				[Token(Token = "0x60216E7")]
				[Address(RVA = "0x1BD0360", Offset = "0x1BCEF60", VA = "0x181BD0360", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060216E8 RID: 136936 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60216E8")]
			[Address(RVA = "0x1BD0120", Offset = "0x1BCED20", VA = "0x181BD0120", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402D9F6 RID: 186870
			[Token(Token = "0x402D9F6")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2MissionItem m_closure;

			// Token: 0x0402D9F7 RID: 186871
			[Token(Token = "0x402D9F7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402D9F8 RID: 186872
			[Token(Token = "0x402D9F8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402D9F9 RID: 186873
			[Token(Token = "0x402D9F9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
