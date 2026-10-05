using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.Resource;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004C9E RID: 19614
	[Token(Token = "0x2004C9E")]
	public class HiddenStageDecodeView : DataBinder<HiddenStageDecodeProperty>
	{
		// Token: 0x170044F2 RID: 17650
		// (get) Token: 0x0601D640 RID: 120384 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D641 RID: 120385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044F2")]
		public Action<string> onJumpToStage
		{
			[Token(Token = "0x601D640")]
			[Address(RVA = "0x16E0F10", Offset = "0x16DFB10", VA = "0x1816E0F10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D641")]
			[Address(RVA = "0x16E12F0", Offset = "0x16DFEF0", VA = "0x1816E12F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044F3 RID: 17651
		// (get) Token: 0x0601D642 RID: 120386 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D643 RID: 120387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044F3")]
		public Action onAvgClick
		{
			[Token(Token = "0x601D642")]
			[Address(RVA = "0x16E0D90", Offset = "0x16DF990", VA = "0x1816E0D90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D643")]
			[Address(RVA = "0x16E10F0", Offset = "0x16DFCF0", VA = "0x1816E10F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044F4 RID: 17652
		// (get) Token: 0x0601D644 RID: 120388 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D645 RID: 120389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044F4")]
		public Action onStageDetailClick
		{
			[Token(Token = "0x601D644")]
			[Address(RVA = "0x16E0F70", Offset = "0x16DFB70", VA = "0x1816E0F70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D645")]
			[Address(RVA = "0x16E1370", Offset = "0x16DFF70", VA = "0x1816E1370")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044F5 RID: 17653
		// (get) Token: 0x0601D646 RID: 120390 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D647 RID: 120391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044F5")]
		public Action onStegeDecodeClick
		{
			[Token(Token = "0x601D646")]
			[Address(RVA = "0x16E1030", Offset = "0x16DFC30", VA = "0x1816E1030")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D647")]
			[Address(RVA = "0x16E1470", Offset = "0x16E0070", VA = "0x1816E1470")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044F6 RID: 17654
		// (get) Token: 0x0601D648 RID: 120392 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D649 RID: 120393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044F6")]
		public Action onStageRewardClick
		{
			[Token(Token = "0x601D648")]
			[Address(RVA = "0x16E0FD0", Offset = "0x16DFBD0", VA = "0x1816E0FD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D649")]
			[Address(RVA = "0x16E13F0", Offset = "0x16DFFF0", VA = "0x1816E13F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044F7 RID: 17655
		// (get) Token: 0x0601D64A RID: 120394 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D64B RID: 120395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044F7")]
		public Action onEnemyClick
		{
			[Token(Token = "0x601D64A")]
			[Address(RVA = "0x16E0E50", Offset = "0x16DFA50", VA = "0x1816E0E50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D64B")]
			[Address(RVA = "0x16E11F0", Offset = "0x16DFDF0", VA = "0x1816E11F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044F8 RID: 17656
		// (get) Token: 0x0601D64C RID: 120396 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D64D RID: 120397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044F8")]
		public Action onBattleStart
		{
			[Token(Token = "0x601D64C")]
			[Address(RVA = "0x16E0DF0", Offset = "0x16DF9F0", VA = "0x1816E0DF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D64D")]
			[Address(RVA = "0x16E1170", Offset = "0x16DFD70", VA = "0x1816E1170")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044F9 RID: 17657
		// (get) Token: 0x0601D64E RID: 120398 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D64F RID: 120399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044F9")]
		public Action onUnlockHidden
		{
			[Token(Token = "0x601D64E")]
			[Address(RVA = "0x16E1090", Offset = "0x16DFC90", VA = "0x1816E1090")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D64F")]
			[Address(RVA = "0x16E14F0", Offset = "0x16E00F0", VA = "0x1816E14F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044FA RID: 17658
		// (get) Token: 0x0601D650 RID: 120400 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D651 RID: 120401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044FA")]
		public Action onExit
		{
			[Token(Token = "0x601D650")]
			[Address(RVA = "0x16E0EB0", Offset = "0x16DFAB0", VA = "0x1816E0EB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D651")]
			[Address(RVA = "0x16E1270", Offset = "0x16DFE70", VA = "0x1816E1270")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601D652 RID: 120402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D652")]
		[Address(RVA = "0x16DF0D0", Offset = "0x16DDCD0", VA = "0x1816DF0D0", Slot = "7")]
		public override void OnValueChanged(HiddenStageDecodeProperty property)
		{
		}

		// Token: 0x0601D653 RID: 120403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D653")]
		[Address(RVA = "0x16DFB60", Offset = "0x16DE760", VA = "0x1816DFB60")]
		private void _OnDecodeAnimEnd()
		{
		}

		// Token: 0x0601D654 RID: 120404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D654")]
		[Address(RVA = "0x16E06E0", Offset = "0x16DF2E0", VA = "0x1816E06E0")]
		private void _RenderView(HiddenStageViewModel viewModel)
		{
		}

		// Token: 0x0601D655 RID: 120405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D655")]
		[Address(RVA = "0x16DF5D0", Offset = "0x16DE1D0", VA = "0x1816DF5D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D656 RID: 120406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D656")]
		[Address(RVA = "0x16DFC00", Offset = "0x16DE800", VA = "0x1816DFC00")]
		private void _RenderBaseInfo(HiddenStageViewModel viewModel)
		{
		}

		// Token: 0x0601D657 RID: 120407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D657")]
		[Address(RVA = "0x16E0160", Offset = "0x16DED60", VA = "0x1816E0160")]
		private void _RenderStagePreview()
		{
		}

		// Token: 0x0601D658 RID: 120408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D658")]
		[Address(RVA = "0x16DF850", Offset = "0x16DE450", VA = "0x1816DF850")]
		private void _LoadAvatar(string stageId)
		{
		}

		// Token: 0x0601D659 RID: 120409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D659")]
		[Address(RVA = "0x16DFCF0", Offset = "0x16DE8F0", VA = "0x1816DFCF0")]
		private void _RenderDecodePanel()
		{
		}

		// Token: 0x0601D65A RID: 120410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D65A")]
		[Address(RVA = "0x16E0910", Offset = "0x16DF510", VA = "0x1816E0910")]
		private void _SwitchPanel(bool isDecode)
		{
		}

		// Token: 0x0601D65B RID: 120411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D65B")]
		[Address(RVA = "0x16DF990", Offset = "0x16DE590", VA = "0x1816DF990")]
		private void _LoadMapPreview(string stageId)
		{
		}

		// Token: 0x0601D65C RID: 120412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D65C")]
		[Address(RVA = "0x16DFF40", Offset = "0x16DEB40", VA = "0x1816DFF40")]
		private void _RenderReward(StageViewModel viewModel)
		{
		}

		// Token: 0x0601D65D RID: 120413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D65D")]
		[Address(RVA = "0x16E0BC0", Offset = "0x16DF7C0", VA = "0x1816E0BC0")]
		private void _UnloadStagePreviewMap()
		{
		}

		// Token: 0x0601D65E RID: 120414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D65E")]
		[Address(RVA = "0x16E07B0", Offset = "0x16DF3B0", VA = "0x1816E07B0")]
		private void _ShotBlurredSprite()
		{
		}

		// Token: 0x0601D65F RID: 120415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D65F")]
		[Address(RVA = "0x16DF2A0", Offset = "0x16DDEA0", VA = "0x1816DF2A0")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x0601D660 RID: 120416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D660")]
		[Address(RVA = "0x16DF3B0", Offset = "0x16DDFB0", VA = "0x1816DF3B0")]
		private AnimationSwitchTween _EnsureDecodeAnim()
		{
			return null;
		}

		// Token: 0x0601D661 RID: 120417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D661")]
		[Address(RVA = "0x16DF4C0", Offset = "0x16DE0C0", VA = "0x1816DF4C0")]
		private AnimationSwitchTween _EnsurePreviewAnim()
		{
			return null;
		}

		// Token: 0x0601D662 RID: 120418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D662")]
		[Address(RVA = "0x16DE7A0", Offset = "0x16DD3A0", VA = "0x1816DE7A0")]
		public void EventOnDecodePanel()
		{
		}

		// Token: 0x0601D663 RID: 120419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D663")]
		[Address(RVA = "0x16DEEB0", Offset = "0x16DDAB0", VA = "0x1816DEEB0")]
		public void EventOnStageDetail()
		{
		}

		// Token: 0x0601D664 RID: 120420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D664")]
		[Address(RVA = "0x16DE8B0", Offset = "0x16DD4B0", VA = "0x1816DE8B0")]
		public void EventOnEnemyHandBook()
		{
		}

		// Token: 0x0601D665 RID: 120421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D665")]
		[Address(RVA = "0x16DEBB0", Offset = "0x16DD7B0", VA = "0x1816DEBB0")]
		public void EventOnMapPreview()
		{
		}

		// Token: 0x0601D666 RID: 120422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D666")]
		[Address(RVA = "0x16DEDA0", Offset = "0x16DD9A0", VA = "0x1816DEDA0")]
		public void EventOnReward()
		{
		}

		// Token: 0x0601D667 RID: 120423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D667")]
		[Address(RVA = "0x16DE690", Offset = "0x16DD290", VA = "0x1816DE690")]
		public void EventOnBattleStart()
		{
		}

		// Token: 0x0601D668 RID: 120424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D668")]
		[Address(RVA = "0x16DE580", Offset = "0x16DD180", VA = "0x1816DE580")]
		public void EventOnAvg()
		{
		}

		// Token: 0x0601D669 RID: 120425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D669")]
		[Address(RVA = "0x16DEA90", Offset = "0x16DD690", VA = "0x1816DEA90")]
		public void EventOnJumpStage(string stageId)
		{
		}

		// Token: 0x0601D66A RID: 120426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D66A")]
		[Address(RVA = "0x16DE9C0", Offset = "0x16DD5C0", VA = "0x1816DE9C0")]
		public void EventOnExit()
		{
		}

		// Token: 0x0601D66B RID: 120427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D66B")]
		[Address(RVA = "0x16DEFC0", Offset = "0x16DDBC0", VA = "0x1816DEFC0")]
		public void EventOnUnlockHidden()
		{
		}

		// Token: 0x0601D66C RID: 120428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D66C")]
		[Address(RVA = "0x16E0CD0", Offset = "0x16DF8D0", VA = "0x1816E0CD0")]
		public HiddenStageDecodeView()
		{
		}

		// Token: 0x04026B1E RID: 158494
		[Token(Token = "0x4026B1E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("DecodePanel")]
		private GameObject _panelDecode;

		// Token: 0x04026B1F RID: 158495
		[Token(Token = "0x4026B1F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("DecodePanel")]
		private GameObject _btnBack;

		// Token: 0x04026B20 RID: 158496
		[Token(Token = "0x4026B20")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("DecodePanel")]
		private GameObject _btnExit;

		// Token: 0x04026B21 RID: 158497
		[Token(Token = "0x4026B21")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("DecodePanel")]
		private GameObject _btnDecode;

		// Token: 0x04026B22 RID: 158498
		[Token(Token = "0x4026B22")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("DecodePanel")]
		private Text _stageName;

		// Token: 0x04026B23 RID: 158499
		[Token(Token = "0x4026B23")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("DecodePanel")]
		private SimpleLayoutContent _missionContainer;

		// Token: 0x04026B24 RID: 158500
		[Token(Token = "0x4026B24")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("StagePreview")]
		private GameObject _panelStagePreview;

		// Token: 0x04026B25 RID: 158501
		[Token(Token = "0x4026B25")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("StagePreview")]
		private Image _stageAvatar;

		// Token: 0x04026B26 RID: 158502
		[Token(Token = "0x4026B26")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("StagePreview")]
		private Text _stageInfoCode;

		// Token: 0x04026B27 RID: 158503
		[Token(Token = "0x4026B27")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("StagePreview")]
		private Text _stageInfoName;

		// Token: 0x04026B28 RID: 158504
		[Token(Token = "0x4026B28")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("StagePreview")]
		private Text _stageInfoDesc;

		// Token: 0x04026B29 RID: 158505
		[Token(Token = "0x4026B29")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("StagePreview")]
		private Image _stageInfoMap;

		// Token: 0x04026B2A RID: 158506
		[Token(Token = "0x4026B2A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("StagePreview")]
		private SimpleLayoutContent _rewardList;

		// Token: 0x04026B2B RID: 158507
		[Token(Token = "0x4026B2B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("StagePreview")]
		private Button _avgBtn;

		// Token: 0x04026B2C RID: 158508
		[Token(Token = "0x4026B2C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("StagePreview")]
		private Button _avgBtn2;

		// Token: 0x04026B2D RID: 158509
		[Token(Token = "0x4026B2D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _decodePanelAnim;

		// Token: 0x04026B2E RID: 158510
		[Token(Token = "0x4026B2E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _stagePreviewAnim;

		// Token: 0x04026B2F RID: 158511
		[Token(Token = "0x4026B2F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04026B30 RID: 158512
		[Token(Token = "0x4026B30")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private StageDecoAvatar[] _avatars;

		// Token: 0x04026B3A RID: 158522
		[Token(Token = "0x4026B3A")]
		[FieldOffset(Offset = "0x110")]
		[NonSerialized]
		public Image mapPreview;

		// Token: 0x04026B3B RID: 158523
		[Token(Token = "0x4026B3B")]
		[FieldOffset(Offset = "0x118")]
		[NonSerialized]
		public GameObject mapTipsPanel;

		// Token: 0x04026B3C RID: 158524
		[Token(Token = "0x4026B3C")]
		[FieldOffset(Offset = "0x120")]
		[NonSerialized]
		public Image bkImg;

		// Token: 0x04026B3D RID: 158525
		[Token(Token = "0x4026B3D")]
		private const string DECODE_ANIMATION_ANME = "hidden_decode";

		// Token: 0x04026B3E RID: 158526
		[Token(Token = "0x4026B3E")]
		[FieldOffset(Offset = "0x128")]
		private HiddenStageMissionAdapter m_adapter;

		// Token: 0x04026B3F RID: 158527
		[Token(Token = "0x4026B3F")]
		[FieldOffset(Offset = "0x130")]
		private HiddenStageRewardPreviewAdapter m_rewardAdapter;

		// Token: 0x04026B40 RID: 158528
		[Token(Token = "0x4026B40")]
		[FieldOffset(Offset = "0x138")]
		private bool m_inited;

		// Token: 0x04026B41 RID: 158529
		[Token(Token = "0x4026B41")]
		[FieldOffset(Offset = "0x140")]
		private Sprite m_stagePreviewMap;

		// Token: 0x04026B42 RID: 158530
		[Token(Token = "0x4026B42")]
		[FieldOffset(Offset = "0x148")]
		private DirectAssetLoader m_stagePreviewMapLoader;

		// Token: 0x04026B43 RID: 158531
		[Token(Token = "0x4026B43")]
		[FieldOffset(Offset = "0x150")]
		private HiddenStageViewModel m_cachedViewModel;

		// Token: 0x04026B44 RID: 158532
		[Token(Token = "0x4026B44")]
		[FieldOffset(Offset = "0x158")]
		private AnimationSwitchTween m_decodeSwitch;

		// Token: 0x04026B45 RID: 158533
		[Token(Token = "0x4026B45")]
		[FieldOffset(Offset = "0x160")]
		private AnimationSwitchTween m_previewSwitch;

		// Token: 0x04026B46 RID: 158534
		[Token(Token = "0x4026B46")]
		[FieldOffset(Offset = "0x168")]
		private StageViewModel m_cachedStageViewModel;

		// Token: 0x04026B47 RID: 158535
		[Token(Token = "0x4026B47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onJumpToStage;

		// Token: 0x04026B48 RID: 158536
		[Token(Token = "0x4026B48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onJumpToStage;

		// Token: 0x04026B49 RID: 158537
		[Token(Token = "0x4026B49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onAvgClick;

		// Token: 0x04026B4A RID: 158538
		[Token(Token = "0x4026B4A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onAvgClick;

		// Token: 0x04026B4B RID: 158539
		[Token(Token = "0x4026B4B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onStageDetailClick;

		// Token: 0x04026B4C RID: 158540
		[Token(Token = "0x4026B4C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onStageDetailClick;

		// Token: 0x04026B4D RID: 158541
		[Token(Token = "0x4026B4D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onStegeDecodeClick;

		// Token: 0x04026B4E RID: 158542
		[Token(Token = "0x4026B4E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onStegeDecodeClick;

		// Token: 0x04026B4F RID: 158543
		[Token(Token = "0x4026B4F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_onStageRewardClick;

		// Token: 0x04026B50 RID: 158544
		[Token(Token = "0x4026B50")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_onStageRewardClick;

		// Token: 0x04026B51 RID: 158545
		[Token(Token = "0x4026B51")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_onEnemyClick;

		// Token: 0x04026B52 RID: 158546
		[Token(Token = "0x4026B52")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_onEnemyClick;

		// Token: 0x04026B53 RID: 158547
		[Token(Token = "0x4026B53")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_onBattleStart;

		// Token: 0x04026B54 RID: 158548
		[Token(Token = "0x4026B54")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_onBattleStart;

		// Token: 0x04026B55 RID: 158549
		[Token(Token = "0x4026B55")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_onUnlockHidden;

		// Token: 0x04026B56 RID: 158550
		[Token(Token = "0x4026B56")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_onUnlockHidden;

		// Token: 0x04026B57 RID: 158551
		[Token(Token = "0x4026B57")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_onExit;

		// Token: 0x04026B58 RID: 158552
		[Token(Token = "0x4026B58")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_onExit;

		// Token: 0x04026B59 RID: 158553
		[Token(Token = "0x4026B59")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026B5A RID: 158554
		[Token(Token = "0x4026B5A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnDecodeAnimEnd;

		// Token: 0x04026B5B RID: 158555
		[Token(Token = "0x4026B5B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x04026B5C RID: 158556
		[Token(Token = "0x4026B5C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026B5D RID: 158557
		[Token(Token = "0x4026B5D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__RenderBaseInfo;

		// Token: 0x04026B5E RID: 158558
		[Token(Token = "0x4026B5E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RenderStagePreview;

		// Token: 0x04026B5F RID: 158559
		[Token(Token = "0x4026B5F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__LoadAvatar;

		// Token: 0x04026B60 RID: 158560
		[Token(Token = "0x4026B60")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RenderDecodePanel;

		// Token: 0x04026B61 RID: 158561
		[Token(Token = "0x4026B61")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__SwitchPanel;

		// Token: 0x04026B62 RID: 158562
		[Token(Token = "0x4026B62")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__LoadMapPreview;

		// Token: 0x04026B63 RID: 158563
		[Token(Token = "0x4026B63")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RenderReward;

		// Token: 0x04026B64 RID: 158564
		[Token(Token = "0x4026B64")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__UnloadStagePreviewMap;

		// Token: 0x04026B65 RID: 158565
		[Token(Token = "0x4026B65")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ShotBlurredSprite;

		// Token: 0x04026B66 RID: 158566
		[Token(Token = "0x4026B66")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x04026B67 RID: 158567
		[Token(Token = "0x4026B67")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__EnsureDecodeAnim;

		// Token: 0x04026B68 RID: 158568
		[Token(Token = "0x4026B68")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__EnsurePreviewAnim;

		// Token: 0x04026B69 RID: 158569
		[Token(Token = "0x4026B69")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_EventOnDecodePanel;

		// Token: 0x04026B6A RID: 158570
		[Token(Token = "0x4026B6A")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_EventOnStageDetail;

		// Token: 0x04026B6B RID: 158571
		[Token(Token = "0x4026B6B")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_EventOnEnemyHandBook;

		// Token: 0x04026B6C RID: 158572
		[Token(Token = "0x4026B6C")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_EventOnMapPreview;

		// Token: 0x04026B6D RID: 158573
		[Token(Token = "0x4026B6D")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_EventOnReward;

		// Token: 0x04026B6E RID: 158574
		[Token(Token = "0x4026B6E")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_EventOnBattleStart;

		// Token: 0x04026B6F RID: 158575
		[Token(Token = "0x4026B6F")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_EventOnAvg;

		// Token: 0x04026B70 RID: 158576
		[Token(Token = "0x4026B70")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_EventOnJumpStage;

		// Token: 0x04026B71 RID: 158577
		[Token(Token = "0x4026B71")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_EventOnExit;

		// Token: 0x04026B72 RID: 158578
		[Token(Token = "0x4026B72")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_EventOnUnlockHidden;

		// Token: 0x04026B73 RID: 158579
		[Token(Token = "0x4026B73")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
