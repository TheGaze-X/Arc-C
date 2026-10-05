using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.BattleFinish;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2.BattleFinish
{
	// Token: 0x0200445D RID: 17501
	[Token(Token = "0x200445D")]
	public class SandboxV2RacingBattleFinishView : DynBattleFinishView
	{
		// Token: 0x0601AC00 RID: 109568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC00")]
		[Address(RVA = "0x13E5B40", Offset = "0x13E4740", VA = "0x1813E5B40", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601AC01 RID: 109569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC01")]
		[Address(RVA = "0x13E69C0", Offset = "0x13E55C0", VA = "0x1813E69C0")]
		private void _ScrollToMyPosIfNeed()
		{
		}

		// Token: 0x0601AC02 RID: 109570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC02")]
		[Address(RVA = "0x13E5E50", Offset = "0x13E4A50", VA = "0x1813E5E50")]
		private void _RenderView()
		{
		}

		// Token: 0x0601AC03 RID: 109571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC03")]
		[Address(RVA = "0x13E5AE0", Offset = "0x13E46E0", VA = "0x1813E5AE0")]
		public void EventOnViewClick()
		{
		}

		// Token: 0x0601AC04 RID: 109572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC04")]
		[Address(RVA = "0x13E6940", Offset = "0x13E5540", VA = "0x1813E6940")]
		private void _RouteToHomeScene()
		{
		}

		// Token: 0x0601AC05 RID: 109573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC05")]
		[Address(RVA = "0x13E6D70", Offset = "0x13E5970", VA = "0x1813E6D70")]
		public SandboxV2RacingBattleFinishView()
		{
		}

		// Token: 0x04022300 RID: 140032
		[Token(Token = "0x4022300")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04022301 RID: 140033
		[Token(Token = "0x4022301")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04022302 RID: 140034
		[Token(Token = "0x4022302")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x04022303 RID: 140035
		[Token(Token = "0x4022303")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textMyPos;

		// Token: 0x04022304 RID: 140036
		[Token(Token = "0x4022304")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _unfinishedPosGo;

		// Token: 0x04022305 RID: 140037
		[Token(Token = "0x4022305")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textCompleteTime;

		// Token: 0x04022306 RID: 140038
		[Token(Token = "0x4022306")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _newBestTimeGo;

		// Token: 0x04022307 RID: 140039
		[Token(Token = "0x4022307")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textBestTime;

		// Token: 0x04022308 RID: 140040
		[Token(Token = "0x4022308")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorBestTimeNormal;

		// Token: 0x04022309 RID: 140041
		[Token(Token = "0x4022309")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorBestTimeNew;

		// Token: 0x0402230A RID: 140042
		[Token(Token = "0x402230A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SandboxV2BattleFinishRacerItem[] _racerItemList;

		// Token: 0x0402230B RID: 140043
		[Token(Token = "0x402230B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SimpleLayoutContent _rankItemList;

		// Token: 0x0402230C RID: 140044
		[Token(Token = "0x402230C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _winnerMedelGo;

		// Token: 0x0402230D RID: 140045
		[Token(Token = "0x402230D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _winnerMedalIcon;

		// Token: 0x0402230E RID: 140046
		[Token(Token = "0x402230E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SimpleLayoutContent _normalRewardList;

		// Token: 0x0402230F RID: 140047
		[Token(Token = "0x402230F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _rewardPartGo;

		// Token: 0x04022310 RID: 140048
		[Token(Token = "0x4022310")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ScrollRect _racerScrollRect;

		// Token: 0x04022311 RID: 140049
		[Token(Token = "0x4022311")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private VerticalLayoutGroup _racerListGroup;

		// Token: 0x04022312 RID: 140050
		[Token(Token = "0x4022312")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _itemHeight;

		// Token: 0x04022313 RID: 140051
		[Token(Token = "0x4022313")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UILayoutDimensionListener _dimListener;

		// Token: 0x04022314 RID: 140052
		[Token(Token = "0x4022314")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_enterTween;

		// Token: 0x04022315 RID: 140053
		[Token(Token = "0x4022315")]
		[FieldOffset(Offset = "0xE0")]
		private SandboxV2RacingBattleFinishView.RankListAdapter m_rankListAdapter;

		// Token: 0x04022316 RID: 140054
		[Token(Token = "0x4022316")]
		[FieldOffset(Offset = "0xE8")]
		private SandboxV2RacingBattleFinishView.RewardListAdapter m_rewardListAdapter;

		// Token: 0x04022317 RID: 140055
		[Token(Token = "0x4022317")]
		[FieldOffset(Offset = "0xF0")]
		private SandboxV2RacingBattleFinishViewModel m_viewModel;

		// Token: 0x04022318 RID: 140056
		[Token(Token = "0x4022318")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04022319 RID: 140057
		[Token(Token = "0x4022319")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ScrollToMyPosIfNeed;

		// Token: 0x0402231A RID: 140058
		[Token(Token = "0x402231A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0402231B RID: 140059
		[Token(Token = "0x402231B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnViewClick;

		// Token: 0x0402231C RID: 140060
		[Token(Token = "0x402231C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RouteToHomeScene;

		// Token: 0x0402231D RID: 140061
		[Token(Token = "0x402231D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200445E RID: 17502
		[Token(Token = "0x200445E")]
		private class RankListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601AC06 RID: 109574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AC06")]
			[Address(RVA = "0x13D5620", Offset = "0x13D4220", VA = "0x1813D5620")]
			public RankListAdapter(SandboxV2RacingBattleFinishView closure)
			{
			}

			// Token: 0x17003F8F RID: 16271
			// (get) Token: 0x0601AC07 RID: 109575 RVA: 0x000A3368 File Offset: 0x000A1568
			[Token(Token = "0x17003F8F")]
			public override int count
			{
				[Token(Token = "0x601AC07")]
				[Address(RVA = "0x13D56A0", Offset = "0x13D42A0", VA = "0x1813D56A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AC08 RID: 109576 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AC08")]
			[Address(RVA = "0x13D53F0", Offset = "0x13D3FF0", VA = "0x1813D53F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402231E RID: 140062
			[Token(Token = "0x402231E")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RacingBattleFinishView m_closure;

			// Token: 0x0402231F RID: 140063
			[Token(Token = "0x402231F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022320 RID: 140064
			[Token(Token = "0x4022320")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022321 RID: 140065
			[Token(Token = "0x4022321")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200445F RID: 17503
		[Token(Token = "0x200445F")]
		private class RewardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601AC09 RID: 109577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AC09")]
			[Address(RVA = "0x13D5B50", Offset = "0x13D4750", VA = "0x1813D5B50")]
			public void SetData(List<UIItemViewModel> rewardList)
			{
			}

			// Token: 0x17003F90 RID: 16272
			// (get) Token: 0x0601AC0A RID: 109578 RVA: 0x000A3380 File Offset: 0x000A1580
			[Token(Token = "0x17003F90")]
			public override int count
			{
				[Token(Token = "0x601AC0A")]
				[Address(RVA = "0x13D5C90", Offset = "0x13D4890", VA = "0x1813D5C90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AC0B RID: 109579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AC0B")]
			[Address(RVA = "0x13D5930", Offset = "0x13D4530", VA = "0x1813D5930", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AC0C RID: 109580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AC0C")]
			[Address(RVA = "0x13D5C30", Offset = "0x13D4830", VA = "0x1813D5C30")]
			public RewardListAdapter()
			{
			}

			// Token: 0x04022322 RID: 140066
			[Token(Token = "0x4022322")]
			[FieldOffset(Offset = "0x20")]
			private List<UIItemViewModel> m_rewardList;

			// Token: 0x04022323 RID: 140067
			[Token(Token = "0x4022323")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x04022324 RID: 140068
			[Token(Token = "0x4022324")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022325 RID: 140069
			[Token(Token = "0x4022325")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04022326 RID: 140070
			[Token(Token = "0x4022326")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
