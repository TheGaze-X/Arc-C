using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006972 RID: 26994
	[Token(Token = "0x2006972")]
	public abstract class StagePreviewInfoBasicPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B2E RID: 23342
		// (get) Token: 0x06026A0E RID: 158222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B2E")]
		public StagePreviewConfigController stagePreviewController
		{
			[Token(Token = "0x6026A0E")]
			[Address(RVA = "0x21B35C0", Offset = "0x21B21C0", VA = "0x1821B35C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B2F RID: 23343
		// (get) Token: 0x06026A0F RID: 158223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B2F")]
		protected UIPageListener pageListener
		{
			[Token(Token = "0x6026A0F")]
			[Address(RVA = "0x21B34E0", Offset = "0x21B20E0", VA = "0x1821B34E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B30 RID: 23344
		// (get) Token: 0x06026A10 RID: 158224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B30")]
		protected Sprite stagePreviewMap
		{
			[Token(Token = "0x6026A10")]
			[Address(RVA = "0x21B3620", Offset = "0x21B2220", VA = "0x1821B3620")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026A11 RID: 158225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A11")]
		[Address(RVA = "0x21B1E80", Offset = "0x21B0A80", VA = "0x1821B1E80")]
		protected void _InitIfNot(IStageSelectHandler zoneModel)
		{
		}

		// Token: 0x06026A12 RID: 158226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A12")]
		[Address(RVA = "0x21B2200", Offset = "0x21B0E00", VA = "0x1821B2200")]
		private void _InitRewardView()
		{
		}

		// Token: 0x06026A13 RID: 158227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A13")]
		[Address(RVA = "0x21B2350", Offset = "0x21B0F50", VA = "0x1821B2350")]
		private void _InitShowHideTween(IStageSelectHandler zoneModel)
		{
		}

		// Token: 0x06026A14 RID: 158228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A14")]
		[Address(RVA = "0x21B3240", Offset = "0x21B1E40", VA = "0x1821B3240")]
		private void _UpdateRewardView(StageViewModel selectedStage)
		{
		}

		// Token: 0x06026A15 RID: 158229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A15")]
		[Address(RVA = "0x21B2CA0", Offset = "0x21B18A0", VA = "0x1821B2CA0")]
		private void _ToggleRewardViewDisplay(bool isCustom)
		{
		}

		// Token: 0x06026A16 RID: 158230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A16")]
		[Address(RVA = "0x21B2EF0", Offset = "0x21B1AF0", VA = "0x1821B2EF0")]
		private void _UpdateCustomRewardView(StageViewModel selectedStage)
		{
		}

		// Token: 0x06026A17 RID: 158231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A17")]
		[Address(RVA = "0x21B2FD0", Offset = "0x21B1BD0", VA = "0x1821B2FD0")]
		private void _UpdateNormalRewardView(StageViewModel selectedStage)
		{
		}

		// Token: 0x06026A18 RID: 158232 RVA: 0x000CBE20 File Offset: 0x000CA020
		[Token(Token = "0x6026A18")]
		[Address(RVA = "0x21B1AE0", Offset = "0x21B06E0", VA = "0x1821B1AE0")]
		private bool _CheckDisplayRewardShowFlag(StageViewModel selectedStage, StageRewardViewModel reward, bool isOverride)
		{
			return default(bool);
		}

		// Token: 0x06026A19 RID: 158233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A19")]
		[Address(RVA = "0x21B0B90", Offset = "0x21AF790", VA = "0x1821B0B90")]
		private void OnDestroy()
		{
		}

		// Token: 0x06026A1A RID: 158234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A1A")]
		[Address(RVA = "0x21B19C0", Offset = "0x21B05C0", VA = "0x1821B19C0", Slot = "4")]
		public virtual void Render(IStageSelectHandler handler)
		{
		}

		// Token: 0x06026A1B RID: 158235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A1B")]
		[Address(RVA = "0x21B2B70", Offset = "0x21B1770", VA = "0x1821B2B70")]
		private void _ShowDefaultMapPreview()
		{
		}

		// Token: 0x06026A1C RID: 158236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A1C")]
		[Address(RVA = "0x21B2B00", Offset = "0x21B1700", VA = "0x1821B2B00")]
		private void _ShotBlurredSprite()
		{
		}

		// Token: 0x06026A1D RID: 158237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A1D")]
		[Address(RVA = "0x21B1350", Offset = "0x21AFF50", VA = "0x1821B1350")]
		public void OpenMapTips()
		{
		}

		// Token: 0x06026A1E RID: 158238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A1E")]
		[Address(RVA = "0x21B0FB0", Offset = "0x21AFBB0", VA = "0x1821B0FB0")]
		public void OnStartBattle()
		{
		}

		// Token: 0x06026A1F RID: 158239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A1F")]
		[Address(RVA = "0x21B0C30", Offset = "0x21AF830", VA = "0x1821B0C30")]
		public void OnEnemyClick()
		{
		}

		// Token: 0x06026A20 RID: 158240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A20")]
		[Address(RVA = "0x21B0A10", Offset = "0x21AF610", VA = "0x1821B0A10")]
		public void OnBeNormal()
		{
		}

		// Token: 0x06026A21 RID: 158241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A21")]
		[Address(RVA = "0x21B0A90", Offset = "0x21AF690", VA = "0x1821B0A90")]
		public void OnBeSpecial()
		{
		}

		// Token: 0x06026A22 RID: 158242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A22")]
		[Address(RVA = "0x21B0EB0", Offset = "0x21AFAB0", VA = "0x1821B0EB0")]
		public void OnRewardClick()
		{
		}

		// Token: 0x06026A23 RID: 158243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A23")]
		[Address(RVA = "0x21B0B10", Offset = "0x21AF710", VA = "0x1821B0B10")]
		public void OnCampaignRules()
		{
		}

		// Token: 0x06026A24 RID: 158244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A24")]
		[Address(RVA = "0x21B1030", Offset = "0x21AFC30", VA = "0x1821B1030")]
		public void OnToggleAutoBattle()
		{
		}

		// Token: 0x06026A25 RID: 158245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A25")]
		[Address(RVA = "0x21B0D30", Offset = "0x21AF930", VA = "0x1821B0D30")]
		public void OnMultipleBattleClick()
		{
		}

		// Token: 0x06026A26 RID: 158246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A26")]
		[Address(RVA = "0x21B0CB0", Offset = "0x21AF8B0", VA = "0x1821B0CB0")]
		public void OnHardLocked()
		{
		}

		// Token: 0x06026A27 RID: 158247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A27")]
		[Address(RVA = "0x21B0DB0", Offset = "0x21AF9B0", VA = "0x1821B0DB0")]
		public void OnPractise()
		{
		}

		// Token: 0x06026A28 RID: 158248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A28")]
		[Address(RVA = "0x21B0E30", Offset = "0x21AFA30", VA = "0x1821B0E30")]
		public void OnReplayStoryOpenClick()
		{
		}

		// Token: 0x06026A29 RID: 158249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A29")]
		[Address(RVA = "0x21B0F30", Offset = "0x21AFB30", VA = "0x1821B0F30")]
		public void OnRewardDetailOpenClick()
		{
		}

		// Token: 0x06026A2A RID: 158250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A2A")]
		[Address(RVA = "0x21B10B0", Offset = "0x21AFCB0", VA = "0x1821B10B0")]
		public void OnZoneRecordMissionBtnClick()
		{
		}

		// Token: 0x06026A2B RID: 158251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A2B")]
		[Address(RVA = "0x21B1BC0", Offset = "0x21B07C0", VA = "0x1821B1BC0")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x06026A2C RID: 158252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A2C")]
		[Address(RVA = "0x21B1590", Offset = "0x21B0190", VA = "0x1821B1590", Slot = "5")]
		protected virtual void RefreshView(IStageSelectHandler zoneModel, StageViewModel selectedStage)
		{
		}

		// Token: 0x06026A2D RID: 158253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026A2D")]
		[Address(RVA = "0x21B1D00", Offset = "0x21B0900", VA = "0x1821B1D00")]
		private string _GetPreviewMapStageId(IStageSelectHandler zoneModel, StageViewModel selectedStage)
		{
			return null;
		}

		// Token: 0x06026A2E RID: 158254 RVA: 0x000CBE38 File Offset: 0x000CA038
		[Token(Token = "0x6026A2E")]
		[Address(RVA = "0x21B11B0", Offset = "0x21AFDB0", VA = "0x1821B11B0", Slot = "6")]
		protected virtual bool OnZoneViewChanged(IStageSelectHandler zoneModel, StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x06026A2F RID: 158255
		[Token(Token = "0x6026A2F")]
		protected abstract bool SelectStageViewModel(IStageSelectHandler zoneModel, out StageViewModel stageModel);

		// Token: 0x06026A30 RID: 158256
		[Token(Token = "0x6026A30")]
		protected abstract bool CheckToShow(IStageSelectHandler zoneModel);

		// Token: 0x06026A31 RID: 158257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A31")]
		[Address(RVA = "0x21B2D80", Offset = "0x21B1980", VA = "0x1821B2D80")]
		private void _UnloadStagePreviewMap()
		{
		}

		// Token: 0x06026A32 RID: 158258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A32")]
		[Address(RVA = "0x21B2550", Offset = "0x21B1150", VA = "0x1821B2550")]
		private void _LoadStagePreviewMap(string zoneId, string stageId)
		{
		}

		// Token: 0x06026A33 RID: 158259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A33")]
		[Address(RVA = "0x21B3430", Offset = "0x21B2030", VA = "0x1821B3430")]
		protected StagePreviewInfoBasicPanel()
		{
		}

		// Token: 0x04036861 RID: 223329
		[Token(Token = "0x4036861")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _stageCodeText;

		// Token: 0x04036862 RID: 223330
		[Token(Token = "0x4036862")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageNameText;

		// Token: 0x04036863 RID: 223331
		[Token(Token = "0x4036863")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageDescText;

		// Token: 0x04036864 RID: 223332
		[Token(Token = "0x4036864")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _rewardGrid;

		// Token: 0x04036865 RID: 223333
		[Token(Token = "0x4036865")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _rewardPreviewGo;

		// Token: 0x04036866 RID: 223334
		[Token(Token = "0x4036866")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imageMapPreview;

		// Token: 0x04036867 RID: 223335
		[Token(Token = "0x4036867")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDangerDesc;

		// Token: 0x04036868 RID: 223336
		[Token(Token = "0x4036868")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _showAnimationLocation;

		// Token: 0x04036869 RID: 223337
		[Token(Token = "0x4036869")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _hideAnimationLocation;

		// Token: 0x0403686A RID: 223338
		[Token(Token = "0x403686A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _bossIcon;

		// Token: 0x0403686B RID: 223339
		[Token(Token = "0x403686B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _mainZoneRewardMissionBtn;

		// Token: 0x0403686C RID: 223340
		[Token(Token = "0x403686C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<StagePreviewHardTwoStateToggle> _twoStateToggleList;

		// Token: 0x0403686D RID: 223341
		[Token(Token = "0x403686D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private StagePreviewConfigController _stagePreviewController;

		// Token: 0x0403686E RID: 223342
		[Token(Token = "0x403686E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private StagePreviewActPluginHander _pluginHandler;

		// Token: 0x0403686F RID: 223343
		[Token(Token = "0x403686F")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public GameObject mapTips;

		// Token: 0x04036870 RID: 223344
		[Token(Token = "0x4036870")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public Image imageMapTips;

		// Token: 0x04036871 RID: 223345
		[Token(Token = "0x4036871")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public Image backTips;

		// Token: 0x04036872 RID: 223346
		[Token(Token = "0x4036872")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		public StagePreviewEventHolder eventHolder;

		// Token: 0x04036873 RID: 223347
		[Token(Token = "0x4036873")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		public RectTransform mapPreviewPluginContainer;

		// Token: 0x04036874 RID: 223348
		[Token(Token = "0x4036874")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		public Transform displayMetaContainer;

		// Token: 0x04036875 RID: 223349
		[Token(Token = "0x4036875")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		public RectTransform mapPreviewRect;

		// Token: 0x04036876 RID: 223350
		[Token(Token = "0x4036876")]
		[FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		public RectTransform mapPreviewNormalSize;

		// Token: 0x04036877 RID: 223351
		[Token(Token = "0x4036877")]
		[FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		public RectTransform mapPreviewSpecialBound;

		// Token: 0x04036878 RID: 223352
		[Token(Token = "0x4036878")]
		[FieldOffset(Offset = "0xE0")]
		private SpriteHub m_enemySpineImageHub;

		// Token: 0x04036879 RID: 223353
		[Token(Token = "0x4036879")]
		[FieldOffset(Offset = "0xE8")]
		private SpriteHub m_itemIconHub;

		// Token: 0x0403687A RID: 223354
		[Token(Token = "0x403687A")]
		[FieldOffset(Offset = "0xF0")]
		private StagePreviewInfoBasicPanel.RewardPreviewAdapter m_rewardAdapter;

		// Token: 0x0403687B RID: 223355
		[Token(Token = "0x403687B")]
		[FieldOffset(Offset = "0xF8")]
		private StageStartBattleETButton m_btnStartBattleEt;

		// Token: 0x0403687C RID: 223356
		[Token(Token = "0x403687C")]
		[FieldOffset(Offset = "0x100")]
		private StageStartBattleCustomButton m_btnStartBattleCustom;

		// Token: 0x0403687D RID: 223357
		[Token(Token = "0x403687D")]
		[FieldOffset(Offset = "0x108")]
		private GameObject m_displayMetaObj;

		// Token: 0x0403687E RID: 223358
		[Token(Token = "0x403687E")]
		[FieldOffset(Offset = "0x110")]
		private Sprite m_stagePreviewMap;

		// Token: 0x0403687F RID: 223359
		[Token(Token = "0x403687F")]
		[FieldOffset(Offset = "0x118")]
		private StageData m_previewMapStageData;

		// Token: 0x04036880 RID: 223360
		[Token(Token = "0x4036880")]
		[FieldOffset(Offset = "0x120")]
		private UIAssetLoader.LegacyDirectLoader m_stagePreviewMapLoader;

		// Token: 0x04036881 RID: 223361
		[Token(Token = "0x4036881")]
		[FieldOffset(Offset = "0x128")]
		private string m_zoneRecordMissionDesc;

		// Token: 0x04036882 RID: 223362
		[Token(Token = "0x4036882")]
		[FieldOffset(Offset = "0x130")]
		private bool m_isInited;

		// Token: 0x04036883 RID: 223363
		[Token(Token = "0x4036883")]
		[FieldOffset(Offset = "0x131")]
		private bool m_showZoneRecordMissionBtn;

		// Token: 0x04036884 RID: 223364
		[Token(Token = "0x4036884")]
		[FieldOffset(Offset = "0x138")]
		protected string m_selectedStageIdCache;

		// Token: 0x04036885 RID: 223365
		[Token(Token = "0x4036885")]
		[FieldOffset(Offset = "0x140")]
		protected bool m_cacheAnimator;

		// Token: 0x04036886 RID: 223366
		[Token(Token = "0x4036886")]
		[FieldOffset(Offset = "0x141")]
		protected bool m_hasMapPreview;

		// Token: 0x04036887 RID: 223367
		[Token(Token = "0x4036887")]
		[FieldOffset(Offset = "0x148")]
		private UIBiAnimClipSwitchTween m_showHideSwitchTween;

		// Token: 0x04036888 RID: 223368
		[Token(Token = "0x4036888")]
		[FieldOffset(Offset = "0x150")]
		private UIPageListener m_pageListener;

		// Token: 0x04036889 RID: 223369
		[Token(Token = "0x4036889")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stagePreviewController;

		// Token: 0x0403688A RID: 223370
		[Token(Token = "0x403688A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pageListener;

		// Token: 0x0403688B RID: 223371
		[Token(Token = "0x403688B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stagePreviewMap;

		// Token: 0x0403688C RID: 223372
		[Token(Token = "0x403688C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403688D RID: 223373
		[Token(Token = "0x403688D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitRewardView;

		// Token: 0x0403688E RID: 223374
		[Token(Token = "0x403688E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitShowHideTween;

		// Token: 0x0403688F RID: 223375
		[Token(Token = "0x403688F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateRewardView;

		// Token: 0x04036890 RID: 223376
		[Token(Token = "0x4036890")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ToggleRewardViewDisplay;

		// Token: 0x04036891 RID: 223377
		[Token(Token = "0x4036891")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateCustomRewardView;

		// Token: 0x04036892 RID: 223378
		[Token(Token = "0x4036892")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateNormalRewardView;

		// Token: 0x04036893 RID: 223379
		[Token(Token = "0x4036893")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckDisplayRewardShowFlag;

		// Token: 0x04036894 RID: 223380
		[Token(Token = "0x4036894")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04036895 RID: 223381
		[Token(Token = "0x4036895")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036896 RID: 223382
		[Token(Token = "0x4036896")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ShowDefaultMapPreview;

		// Token: 0x04036897 RID: 223383
		[Token(Token = "0x4036897")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ShotBlurredSprite;

		// Token: 0x04036898 RID: 223384
		[Token(Token = "0x4036898")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OpenMapTips;

		// Token: 0x04036899 RID: 223385
		[Token(Token = "0x4036899")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnStartBattle;

		// Token: 0x0403689A RID: 223386
		[Token(Token = "0x403689A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnEnemyClick;

		// Token: 0x0403689B RID: 223387
		[Token(Token = "0x403689B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnBeNormal;

		// Token: 0x0403689C RID: 223388
		[Token(Token = "0x403689C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnBeSpecial;

		// Token: 0x0403689D RID: 223389
		[Token(Token = "0x403689D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnRewardClick;

		// Token: 0x0403689E RID: 223390
		[Token(Token = "0x403689E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnCampaignRules;

		// Token: 0x0403689F RID: 223391
		[Token(Token = "0x403689F")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnToggleAutoBattle;

		// Token: 0x040368A0 RID: 223392
		[Token(Token = "0x40368A0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnMultipleBattleClick;

		// Token: 0x040368A1 RID: 223393
		[Token(Token = "0x40368A1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnHardLocked;

		// Token: 0x040368A2 RID: 223394
		[Token(Token = "0x40368A2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnPractise;

		// Token: 0x040368A3 RID: 223395
		[Token(Token = "0x40368A3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnReplayStoryOpenClick;

		// Token: 0x040368A4 RID: 223396
		[Token(Token = "0x40368A4")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnRewardDetailOpenClick;

		// Token: 0x040368A5 RID: 223397
		[Token(Token = "0x40368A5")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnZoneRecordMissionBtnClick;

		// Token: 0x040368A6 RID: 223398
		[Token(Token = "0x40368A6")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x040368A7 RID: 223399
		[Token(Token = "0x40368A7")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x040368A8 RID: 223400
		[Token(Token = "0x40368A8")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__GetPreviewMapStageId;

		// Token: 0x040368A9 RID: 223401
		[Token(Token = "0x40368A9")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnZoneViewChanged;

		// Token: 0x040368AA RID: 223402
		[Token(Token = "0x40368AA")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__UnloadStagePreviewMap;

		// Token: 0x040368AB RID: 223403
		[Token(Token = "0x40368AB")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__LoadStagePreviewMap;

		// Token: 0x040368AC RID: 223404
		[Token(Token = "0x40368AC")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006973 RID: 26995
		[Token(Token = "0x2006973")]
		private class EnemyPreviewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005B31 RID: 23345
			// (get) Token: 0x06026A34 RID: 158260 RVA: 0x000CBE50 File Offset: 0x000CA050
			[Token(Token = "0x17005B31")]
			public override int count
			{
				[Token(Token = "0x6026A34")]
				[Address(RVA = "0x21A6F30", Offset = "0x21A5B30", VA = "0x1821A6F30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026A35 RID: 158261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026A35")]
			[Address(RVA = "0x21A6D30", Offset = "0x21A5930", VA = "0x1821A6D30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06026A36 RID: 158262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026A36")]
			[Address(RVA = "0x21A6ED0", Offset = "0x21A5AD0", VA = "0x1821A6ED0")]
			public EnemyPreviewAdapter()
			{
			}

			// Token: 0x040368AD RID: 223405
			[Token(Token = "0x40368AD")]
			[FieldOffset(Offset = "0x20")]
			public Sprite[] enemySprites;

			// Token: 0x040368AE RID: 223406
			[Token(Token = "0x40368AE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040368AF RID: 223407
			[Token(Token = "0x40368AF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040368B0 RID: 223408
			[Token(Token = "0x40368B0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006974 RID: 26996
		[Token(Token = "0x2006974")]
		private class RewardPreviewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005B32 RID: 23346
			// (get) Token: 0x06026A37 RID: 158263 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06026A38 RID: 158264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005B32")]
			public List<StageRewardViewModel> cardModels
			{
				[Token(Token = "0x6026A37")]
				[Address(RVA = "0x21A7420", Offset = "0x21A6020", VA = "0x1821A7420")]
				get
				{
					return null;
				}
				[Token(Token = "0x6026A38")]
				[Address(RVA = "0x21A7590", Offset = "0x21A6190", VA = "0x1821A7590")]
				set
				{
				}
			}

			// Token: 0x17005B33 RID: 23347
			// (get) Token: 0x06026A39 RID: 158265 RVA: 0x000CBE68 File Offset: 0x000CA068
			[Token(Token = "0x17005B33")]
			public override int count
			{
				[Token(Token = "0x6026A39")]
				[Address(RVA = "0x21A7480", Offset = "0x21A6080", VA = "0x1821A7480", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026A3A RID: 158266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026A3A")]
			[Address(RVA = "0x21A7200", Offset = "0x21A5E00", VA = "0x1821A7200", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06026A3B RID: 158267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026A3B")]
			[Address(RVA = "0x21A73C0", Offset = "0x21A5FC0", VA = "0x1821A73C0")]
			public RewardPreviewAdapter()
			{
			}

			// Token: 0x040368B1 RID: 223409
			[Token(Token = "0x40368B1")]
			private const int MAX_ITEM_COUNT = 3;

			// Token: 0x040368B2 RID: 223410
			[Token(Token = "0x40368B2")]
			[FieldOffset(Offset = "0x20")]
			private List<StageRewardViewModel> m_cardModels;

			// Token: 0x040368B3 RID: 223411
			[Token(Token = "0x40368B3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_cardModels;

			// Token: 0x040368B4 RID: 223412
			[Token(Token = "0x40368B4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_cardModels;

			// Token: 0x040368B5 RID: 223413
			[Token(Token = "0x40368B5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040368B6 RID: 223414
			[Token(Token = "0x40368B6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040368B7 RID: 223415
			[Token(Token = "0x40368B7")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
