using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.BattleFinish;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2.BattleFinish
{
	// Token: 0x02004459 RID: 17497
	[Token(Token = "0x2004459")]
	public class SandboxV2BattleFinishView : DynBattleFinishView
	{
		// Token: 0x0601ABBF RID: 109503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABBF")]
		[Address(RVA = "0x13DD900", Offset = "0x13DC500", VA = "0x1813DD900", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601ABC0 RID: 109504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABC0")]
		[Address(RVA = "0x13DEEF0", Offset = "0x13DDAF0", VA = "0x1813DEEF0")]
		private void _RenderView()
		{
		}

		// Token: 0x0601ABC1 RID: 109505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABC1")]
		[Address(RVA = "0x13DDD20", Offset = "0x13DC920", VA = "0x1813DDD20")]
		private void _PlayAnimEnter()
		{
		}

		// Token: 0x0601ABC2 RID: 109506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABC2")]
		[Address(RVA = "0x13DE8F0", Offset = "0x13DD4F0", VA = "0x1813DE8F0")]
		private void _RenderRewardPart()
		{
		}

		// Token: 0x0601ABC3 RID: 109507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABC3")]
		[Address(RVA = "0x13DE560", Offset = "0x13DD160", VA = "0x1813DE560")]
		private void _RenderEnemeyRushPart()
		{
		}

		// Token: 0x0601ABC4 RID: 109508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABC4")]
		[Address(RVA = "0x13DE100", Offset = "0x13DCD00", VA = "0x1813DE100")]
		private void _RenderBasementHealthPart()
		{
		}

		// Token: 0x0601ABC5 RID: 109509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABC5")]
		[Address(RVA = "0x13DEB10", Offset = "0x13DD710", VA = "0x1813DEB10")]
		private void _RenderTargetPart()
		{
		}

		// Token: 0x0601ABC6 RID: 109510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABC6")]
		[Address(RVA = "0x13DF4B0", Offset = "0x13DE0B0", VA = "0x1813DF4B0")]
		private void _UpdateIconTarget(UIAtlasImage imgIcon, SandboxV2NodeType imgNodeType)
		{
		}

		// Token: 0x0601ABC7 RID: 109511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ABC7")]
		[Address(RVA = "0x13DDC30", Offset = "0x13DC830", VA = "0x1813DDC30")]
		private string _GetPercentRatio(float ratio)
		{
			return null;
		}

		// Token: 0x0601ABC8 RID: 109512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABC8")]
		[Address(RVA = "0x13DF430", Offset = "0x13DE030", VA = "0x1813DF430")]
		private void _RouteToHomeScene()
		{
		}

		// Token: 0x0601ABC9 RID: 109513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABC9")]
		[Address(RVA = "0x13DD8A0", Offset = "0x13DC4A0", VA = "0x1813DD8A0")]
		public void EventOnViewClick()
		{
		}

		// Token: 0x0601ABCA RID: 109514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABCA")]
		[Address(RVA = "0x13DF670", Offset = "0x13DE270", VA = "0x1813DF670")]
		public SandboxV2BattleFinishView()
		{
		}

		// Token: 0x04022275 RID: 139893
		[Token(Token = "0x4022275")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04022276 RID: 139894
		[Token(Token = "0x4022276")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIFullScreenImage _fullScreenImage;

		// Token: 0x04022277 RID: 139895
		[Token(Token = "0x4022277")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _illustContainer;

		// Token: 0x04022278 RID: 139896
		[Token(Token = "0x4022278")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textNodeType;

		// Token: 0x04022279 RID: 139897
		[Token(Token = "0x4022279")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x0402227A RID: 139898
		[Token(Token = "0x402227A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Target Info")]
		private GameObject _targetPartGo;

		// Token: 0x0402227B RID: 139899
		[Token(Token = "0x402227B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Target Info")]
		private Text _textTargetName;

		// Token: 0x0402227C RID: 139900
		[Token(Token = "0x402227C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Target Info")]
		private Text _textTargetHealthRatio;

		// Token: 0x0402227D RID: 139901
		[Token(Token = "0x402227D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Target Info")]
		private Slider _sliderTargetHealth;

		// Token: 0x0402227E RID: 139902
		[Token(Token = "0x402227E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Target Info")]
		private UIAtlasImage _iconTargetNestGo;

		// Token: 0x0402227F RID: 139903
		[Token(Token = "0x402227F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Target Info")]
		private UIAtlasImage _iconTargetMineGo;

		// Token: 0x04022280 RID: 139904
		[Token(Token = "0x4022280")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Target Info")]
		private UIAtlasImage _iconTargetGateGo;

		// Token: 0x04022281 RID: 139905
		[Token(Token = "0x4022281")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Target Info")]
		private UIAtlasImage _iconTargetCaveGo;

		// Token: 0x04022282 RID: 139906
		[Token(Token = "0x4022282")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Target Info")]
		private GameObject _targetAllDefeatedGo;

		// Token: 0x04022283 RID: 139907
		[Token(Token = "0x4022283")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Target Info")]
		private Color _colorIconTargetAllDefeated;

		// Token: 0x04022284 RID: 139908
		[Token(Token = "0x4022284")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Target Info")]
		private Color _colorIconTargetNormal;

		// Token: 0x04022285 RID: 139909
		[Token(Token = "0x4022285")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Target Info")]
		private UIAtlasImage _imgTargetHpSlider;

		// Token: 0x04022286 RID: 139910
		[Token(Token = "0x4022286")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Target Info")]
		private Color _colorSliderTargetNormal;

		// Token: 0x04022287 RID: 139911
		[Token(Token = "0x4022287")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Target Info")]
		private Color _colorSliderTargetCave;

		// Token: 0x04022288 RID: 139912
		[Token(Token = "0x4022288")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Basement Hp")]
		private GameObject _basementHpPartGo;

		// Token: 0x04022289 RID: 139913
		[Token(Token = "0x4022289")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Basement Hp")]
		private Text _textBasementName;

		// Token: 0x0402228A RID: 139914
		[Token(Token = "0x402228A")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Basement Hp")]
		private Text _textBasementHpRatio;

		// Token: 0x0402228B RID: 139915
		[Token(Token = "0x402228B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Basement Hp")]
		private Slider _sliderBasementHp;

		// Token: 0x0402228C RID: 139916
		[Token(Token = "0x402228C")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Basement Hp")]
		private UIAtlasImage _imgBasementHpGlow;

		// Token: 0x0402228D RID: 139917
		[Token(Token = "0x402228D")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Basement Hp")]
		private UIAtlasImage _imgBasementHpSlider;

		// Token: 0x0402228E RID: 139918
		[Token(Token = "0x402228E")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Basement Hp")]
		private UIAtlasImage _imgBasementHpRatio;

		// Token: 0x0402228F RID: 139919
		[Token(Token = "0x402228F")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Basement Hp")]
		private Color _colorBasementHpNormal;

		// Token: 0x04022290 RID: 139920
		[Token(Token = "0x4022290")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Basement Hp")]
		private Color _colorBasementHpEmpty;

		// Token: 0x04022291 RID: 139921
		[Token(Token = "0x4022291")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Enemy Rush")]
		private GameObject _enemyRushPartGo;

		// Token: 0x04022292 RID: 139922
		[Token(Token = "0x4022292")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Enemy Rush")]
		private GameObject _enemyRushAllDefeatedGo;

		// Token: 0x04022293 RID: 139923
		[Token(Token = "0x4022293")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Enemy Rush")]
		private Text _textEnemeyCnt;

		// Token: 0x04022294 RID: 139924
		[Token(Token = "0x4022294")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("Enemy Rush")]
		private UIAtlasImage _imgEnemyRushIcon;

		// Token: 0x04022295 RID: 139925
		[Token(Token = "0x4022295")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("Enemy Rush")]
		private Color _colorEnemyRushNormal;

		// Token: 0x04022296 RID: 139926
		[Token(Token = "0x4022296")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("Enemy Rush")]
		private Color _colorEnemyRushAllDefeat;

		// Token: 0x04022297 RID: 139927
		[Token(Token = "0x4022297")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("Anim Canvas Group")]
		private CanvasGroup _illustCanvasGroup;

		// Token: 0x04022298 RID: 139928
		[Token(Token = "0x4022298")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Anim Canvas Group")]
		private CanvasGroup _infoListCanvasGroup;

		// Token: 0x04022299 RID: 139929
		[Token(Token = "0x4022299")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("Anim Canvas Group")]
		private CanvasGroup _basementHpCanvasGroup;

		// Token: 0x0402229A RID: 139930
		[Token(Token = "0x402229A")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("Anim Canvas Group")]
		private CanvasGroup _targetHpCanvasGroup;

		// Token: 0x0402229B RID: 139931
		[Token(Token = "0x402229B")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Group("Anim Canvas Group")]
		private CanvasGroup _enemyRushCanvasGroup;

		// Token: 0x0402229C RID: 139932
		[Token(Token = "0x402229C")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("Anim Canvas Group")]
		private CanvasGroup _rewardCanvasGroup;

		// Token: 0x0402229D RID: 139933
		[Token(Token = "0x402229D")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private SimpleLayoutContent _normalRewardList;

		// Token: 0x0402229E RID: 139934
		[Token(Token = "0x402229E")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private SimpleLayoutContent _randomRewardList;

		// Token: 0x0402229F RID: 139935
		[Token(Token = "0x402229F")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private GameObject _rewardPartGo;

		// Token: 0x040222A0 RID: 139936
		[Token(Token = "0x40222A0")]
		private const float TWEEN_MOVE_DURATION = 0.6f;

		// Token: 0x040222A1 RID: 139937
		[Token(Token = "0x40222A1")]
		private const string PERCENTAGE_STR = "{0}%";

		// Token: 0x040222A2 RID: 139938
		[Token(Token = "0x40222A2")]
		[FieldOffset(Offset = "0x1B8")]
		private SandboxV2BattleFinishViewModel m_viewModel;

		// Token: 0x040222A3 RID: 139939
		[Token(Token = "0x40222A3")]
		[FieldOffset(Offset = "0x1C0")]
		private Sequence m_sequence;

		// Token: 0x040222A4 RID: 139940
		[Token(Token = "0x40222A4")]
		[FieldOffset(Offset = "0x1C8")]
		private SandboxV2BattleFinishView.RewardListAdapter m_normalRewardListAdapter;

		// Token: 0x040222A5 RID: 139941
		[Token(Token = "0x40222A5")]
		[FieldOffset(Offset = "0x1D0")]
		private SandboxV2BattleFinishView.RewardListAdapter m_randomRewardListAdapter;

		// Token: 0x040222A6 RID: 139942
		[Token(Token = "0x40222A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040222A7 RID: 139943
		[Token(Token = "0x40222A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x040222A8 RID: 139944
		[Token(Token = "0x40222A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayAnimEnter;

		// Token: 0x040222A9 RID: 139945
		[Token(Token = "0x40222A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderRewardPart;

		// Token: 0x040222AA RID: 139946
		[Token(Token = "0x40222AA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderEnemeyRushPart;

		// Token: 0x040222AB RID: 139947
		[Token(Token = "0x40222AB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderBasementHealthPart;

		// Token: 0x040222AC RID: 139948
		[Token(Token = "0x40222AC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderTargetPart;

		// Token: 0x040222AD RID: 139949
		[Token(Token = "0x40222AD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateIconTarget;

		// Token: 0x040222AE RID: 139950
		[Token(Token = "0x40222AE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetPercentRatio;

		// Token: 0x040222AF RID: 139951
		[Token(Token = "0x40222AF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RouteToHomeScene;

		// Token: 0x040222B0 RID: 139952
		[Token(Token = "0x40222B0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnViewClick;

		// Token: 0x040222B1 RID: 139953
		[Token(Token = "0x40222B1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200445A RID: 17498
		[Token(Token = "0x200445A")]
		private class RewardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601ABCB RID: 109515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ABCB")]
			[Address(RVA = "0x13D5AD0", Offset = "0x13D46D0", VA = "0x1813D5AD0")]
			public void SetData(List<UIItemViewModel> rewardList)
			{
			}

			// Token: 0x17003F77 RID: 16247
			// (get) Token: 0x0601ABCC RID: 109516 RVA: 0x000A31A0 File Offset: 0x000A13A0
			[Token(Token = "0x17003F77")]
			public override int count
			{
				[Token(Token = "0x601ABCC")]
				[Address(RVA = "0x13D5D00", Offset = "0x13D4900", VA = "0x1813D5D00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601ABCD RID: 109517 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601ABCD")]
			[Address(RVA = "0x13D5790", Offset = "0x13D4390", VA = "0x1813D5790", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601ABCE RID: 109518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ABCE")]
			[Address(RVA = "0x13D5BD0", Offset = "0x13D47D0", VA = "0x1813D5BD0")]
			public RewardListAdapter()
			{
			}

			// Token: 0x040222B2 RID: 139954
			[Token(Token = "0x40222B2")]
			[FieldOffset(Offset = "0x20")]
			private List<UIItemViewModel> m_rewardList;

			// Token: 0x040222B3 RID: 139955
			[Token(Token = "0x40222B3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x040222B4 RID: 139956
			[Token(Token = "0x40222B4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040222B5 RID: 139957
			[Token(Token = "0x40222B5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040222B6 RID: 139958
			[Token(Token = "0x40222B6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
