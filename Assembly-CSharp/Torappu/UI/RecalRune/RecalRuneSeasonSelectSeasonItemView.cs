using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047AF RID: 18351
	[Token(Token = "0x20047AF")]
	public class RecalRuneSeasonSelectSeasonItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700420F RID: 16911
		// (get) Token: 0x0601BC8B RID: 113803 RVA: 0x000A6398 File Offset: 0x000A4598
		[Token(Token = "0x1700420F")]
		public float showDuration
		{
			[Token(Token = "0x601BC8B")]
			[Address(RVA = "0x152FDF0", Offset = "0x152E9F0", VA = "0x18152FDF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0601BC8C RID: 113804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC8C")]
		[Address(RVA = "0x152E970", Offset = "0x152D570", VA = "0x18152E970")]
		public void OnClickEvent()
		{
		}

		// Token: 0x0601BC8D RID: 113805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC8D")]
		[Address(RVA = "0x152EA80", Offset = "0x152D680", VA = "0x18152EA80")]
		public void Render(RecalRuneSeasonItemViewModel model)
		{
		}

		// Token: 0x0601BC8E RID: 113806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC8E")]
		[Address(RVA = "0x152EFE0", Offset = "0x152DBE0", VA = "0x18152EFE0")]
		public void SyncShow(float position)
		{
		}

		// Token: 0x0601BC8F RID: 113807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC8F")]
		[Address(RVA = "0x152F450", Offset = "0x152E050", VA = "0x18152F450")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BC90 RID: 113808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC90")]
		[Address(RVA = "0x152F630", Offset = "0x152E230", VA = "0x18152F630")]
		private void _InitShowIfNot()
		{
		}

		// Token: 0x0601BC91 RID: 113809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC91")]
		[Address(RVA = "0x152F840", Offset = "0x152E440", VA = "0x18152F840")]
		private void _RenderPic(string picId)
		{
		}

		// Token: 0x0601BC92 RID: 113810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC92")]
		[Address(RVA = "0x152F750", Offset = "0x152E350", VA = "0x18152F750")]
		private void _RenderMedal(string medalId, bool medalAchieved)
		{
		}

		// Token: 0x0601BC93 RID: 113811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC93")]
		[Address(RVA = "0x152FA70", Offset = "0x152E670", VA = "0x18152FA70")]
		private void _RenderStageMedals(List<RecalRuneSeasonStageMedalState> medalStates)
		{
		}

		// Token: 0x0601BC94 RID: 113812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC94")]
		[Address(RVA = "0x152F8E0", Offset = "0x152E4E0", VA = "0x18152F8E0")]
		private void _RenderSeniorReward(UIItemViewModel seniorReward, string rewardHint, bool rewardClaimed)
		{
		}

		// Token: 0x0601BC95 RID: 113813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC95")]
		[Address(RVA = "0x152FB80", Offset = "0x152E780", VA = "0x18152FB80")]
		private void _RenderTracks(bool updateTrack, bool rewardTrack)
		{
		}

		// Token: 0x0601BC96 RID: 113814 RVA: 0x000A63B0 File Offset: 0x000A45B0
		[Token(Token = "0x601BC96")]
		[Address(RVA = "0x152F3F0", Offset = "0x152DFF0", VA = "0x18152F3F0")]
		private float _GetPosition()
		{
			return 0f;
		}

		// Token: 0x0601BC97 RID: 113815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC97")]
		[Address(RVA = "0x152FC60", Offset = "0x152E860", VA = "0x18152FC60")]
		private void _SetPosition(float position)
		{
		}

		// Token: 0x0601BC98 RID: 113816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC98")]
		[Address(RVA = "0x152FD00", Offset = "0x152E900", VA = "0x18152FD00")]
		public RecalRuneSeasonSelectSeasonItemView()
		{
		}

		// Token: 0x04024214 RID: 147988
		[Token(Token = "0x4024214")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyVariant;

		// Token: 0x04024215 RID: 147989
		[Token(Token = "0x4024215")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalVariant;

		// Token: 0x04024216 RID: 147990
		[Token(Token = "0x4024216")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIDynImage _seasonPicImage;

		// Token: 0x04024217 RID: 147991
		[Token(Token = "0x4024217")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _medalGroup;

		// Token: 0x04024218 RID: 147992
		[Token(Token = "0x4024218")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _medalImage;

		// Token: 0x04024219 RID: 147993
		[Token(Token = "0x4024219")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _stageMedalContent;

		// Token: 0x0402421A RID: 147994
		[Token(Token = "0x402421A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _rewardItemHolder;

		// Token: 0x0402421B RID: 147995
		[Token(Token = "0x402421B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _rewardItemScale;

		// Token: 0x0402421C RID: 147996
		[Token(Token = "0x402421C")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Color _rewardClaimedColor;

		// Token: 0x0402421D RID: 147997
		[Token(Token = "0x402421D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _rewardUnclaimedVariant;

		// Token: 0x0402421E RID: 147998
		[Token(Token = "0x402421E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _rewardNameText;

		// Token: 0x0402421F RID: 147999
		[Token(Token = "0x402421F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _rewardHintText;

		// Token: 0x04024220 RID: 148000
		[Token(Token = "0x4024220")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _rewardClaimedVariant;

		// Token: 0x04024221 RID: 148001
		[Token(Token = "0x4024221")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _trackGroup;

		// Token: 0x04024222 RID: 148002
		[Token(Token = "0x4024222")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _updateTrack;

		// Token: 0x04024223 RID: 148003
		[Token(Token = "0x4024223")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _rewardTrack;

		// Token: 0x04024224 RID: 148004
		[Token(Token = "0x4024224")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _showAnimation;

		// Token: 0x04024225 RID: 148005
		[Token(Token = "0x4024225")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AnimationClip _showAnimationClip;

		// Token: 0x04024226 RID: 148006
		[Token(Token = "0x4024226")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_finder;

		// Token: 0x04024227 RID: 148007
		[Token(Token = "0x4024227")]
		[FieldOffset(Offset = "0xC8")]
		private RecalRuneSeasonSelectSeasonItemView.Adapter m_adapter;

		// Token: 0x04024228 RID: 148008
		[Token(Token = "0x4024228")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_hasInited;

		// Token: 0x04024229 RID: 148009
		[Token(Token = "0x4024229")]
		[FieldOffset(Offset = "0xD8")]
		private ILoadAsset m_loadAsset;

		// Token: 0x0402422A RID: 148010
		[Token(Token = "0x402422A")]
		[FieldOffset(Offset = "0xE0")]
		private UIItemCard m_rewardItemCard;

		// Token: 0x0402422B RID: 148011
		[Token(Token = "0x402422B")]
		[FieldOffset(Offset = "0xE8")]
		private string m_seasonId;

		// Token: 0x0402422C RID: 148012
		[Token(Token = "0x402422C")]
		[FieldOffset(Offset = "0xF0")]
		private AnimationWrapper m_wrapper;

		// Token: 0x0402422D RID: 148013
		[Token(Token = "0x402422D")]
		[FieldOffset(Offset = "0xF8")]
		private string m_showAnimationName;

		// Token: 0x0402422E RID: 148014
		[Token(Token = "0x402422E")]
		[FieldOffset(Offset = "0x100")]
		private float m_animationLength;

		// Token: 0x0402422F RID: 148015
		[Token(Token = "0x402422F")]
		[FieldOffset(Offset = "0x108")]
		private Tween m_tween;

		// Token: 0x04024230 RID: 148016
		[Token(Token = "0x4024230")]
		[FieldOffset(Offset = "0x110")]
		private float m_position;

		// Token: 0x04024231 RID: 148017
		[Token(Token = "0x4024231")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showDuration;

		// Token: 0x04024232 RID: 148018
		[Token(Token = "0x4024232")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x04024233 RID: 148019
		[Token(Token = "0x4024233")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024234 RID: 148020
		[Token(Token = "0x4024234")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SyncShow;

		// Token: 0x04024235 RID: 148021
		[Token(Token = "0x4024235")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024236 RID: 148022
		[Token(Token = "0x4024236")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitShowIfNot;

		// Token: 0x04024237 RID: 148023
		[Token(Token = "0x4024237")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderPic;

		// Token: 0x04024238 RID: 148024
		[Token(Token = "0x4024238")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderMedal;

		// Token: 0x04024239 RID: 148025
		[Token(Token = "0x4024239")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderStageMedals;

		// Token: 0x0402423A RID: 148026
		[Token(Token = "0x402423A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderSeniorReward;

		// Token: 0x0402423B RID: 148027
		[Token(Token = "0x402423B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderTracks;

		// Token: 0x0402423C RID: 148028
		[Token(Token = "0x402423C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x0402423D RID: 148029
		[Token(Token = "0x402423D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetPosition;

		// Token: 0x0402423E RID: 148030
		[Token(Token = "0x402423E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047B0 RID: 18352
		[Token(Token = "0x20047B0")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004210 RID: 16912
			// (get) Token: 0x0601BC99 RID: 113817 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601BC9A RID: 113818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004210")]
			public List<RecalRuneSeasonStageMedalState> medalStates
			{
				[Token(Token = "0x601BC99")]
				[Address(RVA = "0x1520EF0", Offset = "0x151FAF0", VA = "0x181520EF0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601BC9A")]
				[Address(RVA = "0x15210C0", Offset = "0x151FCC0", VA = "0x1815210C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004211 RID: 16913
			// (get) Token: 0x0601BC9B RID: 113819 RVA: 0x000A63C8 File Offset: 0x000A45C8
			[Token(Token = "0x17004211")]
			public override int count
			{
				[Token(Token = "0x601BC9B")]
				[Address(RVA = "0x1520C50", Offset = "0x151F850", VA = "0x181520C50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601BC9C RID: 113820 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BC9C")]
			[Address(RVA = "0x1520730", Offset = "0x151F330", VA = "0x181520730", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601BC9D RID: 113821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BC9D")]
			[Address(RVA = "0x1520BF0", Offset = "0x151F7F0", VA = "0x181520BF0")]
			public Adapter()
			{
			}

			// Token: 0x04024240 RID: 148032
			[Token(Token = "0x4024240")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_medalStates;

			// Token: 0x04024241 RID: 148033
			[Token(Token = "0x4024241")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_medalStates;

			// Token: 0x04024242 RID: 148034
			[Token(Token = "0x4024242")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04024243 RID: 148035
			[Token(Token = "0x4024243")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04024244 RID: 148036
			[Token(Token = "0x4024244")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
