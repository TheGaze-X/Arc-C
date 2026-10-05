using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E51 RID: 28241
	[Token(Token = "0x2006E51")]
	public class ActVecBreakV2OffenseStageDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028314 RID: 164628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028314")]
		[Address(RVA = "0x2377E40", Offset = "0x2376A40", VA = "0x182377E40")]
		public void Render(VecBreakV2OffenseStageModelBase stageModelBase, ActVecBreakV2OffenseStageDetailView.Param param)
		{
		}

		// Token: 0x06028315 RID: 164629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028315")]
		[Address(RVA = "0x2377CC0", Offset = "0x23768C0", VA = "0x182377CC0")]
		public void OnClickEnemyDetail()
		{
		}

		// Token: 0x06028316 RID: 164630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028316")]
		[Address(RVA = "0x2377D40", Offset = "0x2376940", VA = "0x182377D40")]
		public void OnClickMapPreview()
		{
		}

		// Token: 0x06028317 RID: 164631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028317")]
		[Address(RVA = "0x2377DC0", Offset = "0x23769C0", VA = "0x182377DC0")]
		public void OnOpenSquad()
		{
		}

		// Token: 0x06028318 RID: 164632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028318")]
		[Address(RVA = "0x2378190", Offset = "0x2376D90", VA = "0x182378190")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028319 RID: 164633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028319")]
		[Address(RVA = "0x2378270", Offset = "0x2376E70", VA = "0x182378270")]
		private void _RenderBossInfo(string actId, VecBreakV2OffenseBossModel bossModel)
		{
		}

		// Token: 0x0602831A RID: 164634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602831A")]
		[Address(RVA = "0x2378980", Offset = "0x2377580", VA = "0x182378980")]
		private void _RenderMapEnemyBtn()
		{
		}

		// Token: 0x0602831B RID: 164635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602831B")]
		[Address(RVA = "0x2378760", Offset = "0x2377360", VA = "0x182378760")]
		private void _RenderDescList(VecBreakV2OffenseStageModelBase stageModelBase)
		{
		}

		// Token: 0x0602831C RID: 164636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602831C")]
		[Address(RVA = "0x2378C00", Offset = "0x2377800", VA = "0x182378C00")]
		private void _SetColorConfig()
		{
		}

		// Token: 0x0602831D RID: 164637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602831D")]
		[Address(RVA = "0x2378CF0", Offset = "0x23778F0", VA = "0x182378CF0")]
		public ActVecBreakV2OffenseStageDetailView()
		{
		}

		// Token: 0x0403914A RID: 233802
		[Token(Token = "0x403914A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Color Config")]
		private StageViewColorConfig[] _colorConfigs;

		// Token: 0x0403914B RID: 233803
		[Token(Token = "0x403914B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Color Config")]
		private StageViewColorConfig[] _sliderColorConfigs;

		// Token: 0x0403914C RID: 233804
		[Token(Token = "0x403914C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Color Config")]
		private Graphic[] _bgGraphics;

		// Token: 0x0403914D RID: 233805
		[Token(Token = "0x403914D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Color Config")]
		private Graphic[] _contentGraphics;

		// Token: 0x0403914E RID: 233806
		[Token(Token = "0x403914E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Color Config")]
		private Graphic[] _lineGraphics;

		// Token: 0x0403914F RID: 233807
		[Token(Token = "0x403914F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Color Config")]
		private Graphic[] _sliderBgGraphics;

		// Token: 0x04039150 RID: 233808
		[Token(Token = "0x4039150")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Color Config")]
		private Graphic[] _sliderContentGraphics;

		// Token: 0x04039151 RID: 233809
		[Token(Token = "0x4039151")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Color Config")]
		private float _stageDescAlpha;

		// Token: 0x04039152 RID: 233810
		[Token(Token = "0x4039152")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Group("Color Config")]
		private float _storyDescAlpha;

		// Token: 0x04039153 RID: 233811
		[Token(Token = "0x4039153")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Boss Info")]
		private GameObject _emptyPart;

		// Token: 0x04039154 RID: 233812
		[Token(Token = "0x4039154")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Boss Info")]
		private GameObject _bossPart;

		// Token: 0x04039155 RID: 233813
		[Token(Token = "0x4039155")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Boss Info")]
		private Image _imgSeason;

		// Token: 0x04039156 RID: 233814
		[Token(Token = "0x4039156")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Boss Info")]
		private Image _imgBoss;

		// Token: 0x04039157 RID: 233815
		[Token(Token = "0x4039157")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Boss Info")]
		private Text _bossNameText;

		// Token: 0x04039158 RID: 233816
		[Token(Token = "0x4039158")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Boss Info")]
		private GameObject[] _difficultyItems;

		// Token: 0x04039159 RID: 233817
		[Token(Token = "0x4039159")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Boss Info")]
		private GameObject[] _difficultyMasks;

		// Token: 0x0403915A RID: 233818
		[Token(Token = "0x403915A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Boss Info")]
		private LayoutElement _bossDescScrollElement;

		// Token: 0x0403915B RID: 233819
		[Token(Token = "0x403915B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Boss Info")]
		private float _bossDescScrollMaxHeight;

		// Token: 0x0403915C RID: 233820
		[Token(Token = "0x403915C")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Group("Boss Info")]
		private float _bossDescScrollMinHeight;

		// Token: 0x0403915D RID: 233821
		[Token(Token = "0x403915D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Boss Info")]
		private float _bossDescTweenDuration;

		// Token: 0x0403915E RID: 233822
		[Token(Token = "0x403915E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Map Enemy Button")]
		private RectTransform _mapEnemyBtnRoot;

		// Token: 0x0403915F RID: 233823
		[Token(Token = "0x403915F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Map Enemy Button")]
		private ActVecBreakV2MapEnemyBtnView _mapEnemyBtnPrefab;

		// Token: 0x04039160 RID: 233824
		[Token(Token = "0x4039160")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Desc List")]
		private GameObject _bossDescPart;

		// Token: 0x04039161 RID: 233825
		[Token(Token = "0x4039161")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Desc List")]
		private Text _bossDescText;

		// Token: 0x04039162 RID: 233826
		[Token(Token = "0x4039162")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Desc List")]
		private GameObject _stageDescPart;

		// Token: 0x04039163 RID: 233827
		[Token(Token = "0x4039163")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Desc List")]
		private Text _stageDescText;

		// Token: 0x04039164 RID: 233828
		[Token(Token = "0x4039164")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Desc List")]
		private Text _storyDescText;

		// Token: 0x04039165 RID: 233829
		[Token(Token = "0x4039165")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Open Squad")]
		private ActVecBreakV2OffenseStageSelectOpenSquadView _openSquadView;

		// Token: 0x04039166 RID: 233830
		[Token(Token = "0x4039166")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Open Squad")]
		private CanvasGroup _openSquadCanvasGroup;

		// Token: 0x04039167 RID: 233831
		[Token(Token = "0x4039167")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Open Squad")]
		private float _btnFadeDuration;

		// Token: 0x04039168 RID: 233832
		[Token(Token = "0x4039168")]
		[FieldOffset(Offset = "0xF4")]
		private bool m_inited;

		// Token: 0x04039169 RID: 233833
		[Token(Token = "0x4039169")]
		[FieldOffset(Offset = "0xF8")]
		private string m_actId;

		// Token: 0x0403916A RID: 233834
		[Token(Token = "0x403916A")]
		[FieldOffset(Offset = "0x100")]
		private string m_bossIconId;

		// Token: 0x0403916B RID: 233835
		[Token(Token = "0x403916B")]
		[FieldOffset(Offset = "0x108")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403916C RID: 233836
		[Token(Token = "0x403916C")]
		[FieldOffset(Offset = "0x118")]
		private ActVecBreakV2MapEnemyBtnView m_btnView;

		// Token: 0x0403916D RID: 233837
		[Token(Token = "0x403916D")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_bossDescTween;

		// Token: 0x0403916E RID: 233838
		[Token(Token = "0x403916E")]
		[FieldOffset(Offset = "0x128")]
		private Tween m_openSquadBtnTween;

		// Token: 0x0403916F RID: 233839
		[Token(Token = "0x403916F")]
		[FieldOffset(Offset = "0x130")]
		private ActVecBreakV2OffenseStageDetailView.Param m_cachedParam;

		// Token: 0x04039170 RID: 233840
		[Token(Token = "0x4039170")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039171 RID: 233841
		[Token(Token = "0x4039171")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickEnemyDetail;

		// Token: 0x04039172 RID: 233842
		[Token(Token = "0x4039172")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickMapPreview;

		// Token: 0x04039173 RID: 233843
		[Token(Token = "0x4039173")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnOpenSquad;

		// Token: 0x04039174 RID: 233844
		[Token(Token = "0x4039174")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039175 RID: 233845
		[Token(Token = "0x4039175")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderBossInfo;

		// Token: 0x04039176 RID: 233846
		[Token(Token = "0x4039176")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderMapEnemyBtn;

		// Token: 0x04039177 RID: 233847
		[Token(Token = "0x4039177")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderDescList;

		// Token: 0x04039178 RID: 233848
		[Token(Token = "0x4039178")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetColorConfig;

		// Token: 0x04039179 RID: 233849
		[Token(Token = "0x4039179")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E52 RID: 28242
		[Token(Token = "0x2006E52")]
		public class Param
		{
			// Token: 0x06028320 RID: 164640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028320")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403917A RID: 233850
			[Token(Token = "0x403917A")]
			[FieldOffset(Offset = "0x10")]
			public StageViewType viewType;

			// Token: 0x0403917B RID: 233851
			[Token(Token = "0x403917B")]
			[FieldOffset(Offset = "0x18")]
			public Action onClickEnemyDetail;

			// Token: 0x0403917C RID: 233852
			[Token(Token = "0x403917C")]
			[FieldOffset(Offset = "0x20")]
			public Action onClickMapPreview;

			// Token: 0x0403917D RID: 233853
			[Token(Token = "0x403917D")]
			[FieldOffset(Offset = "0x28")]
			public Action onOpenSquad;

			// Token: 0x0403917E RID: 233854
			[Token(Token = "0x403917E")]
			[FieldOffset(Offset = "0x30")]
			public bool isFirstRender;

			// Token: 0x0403917F RID: 233855
			[Token(Token = "0x403917F")]
			[FieldOffset(Offset = "0x31")]
			public bool needNavNext;

			// Token: 0x04039180 RID: 233856
			[Token(Token = "0x4039180")]
			[FieldOffset(Offset = "0x32")]
			public bool showBtn;
		}
	}
}
