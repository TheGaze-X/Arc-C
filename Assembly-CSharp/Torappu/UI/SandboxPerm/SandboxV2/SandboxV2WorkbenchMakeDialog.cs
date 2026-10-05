using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040F4 RID: 16628
	[Token(Token = "0x20040F4")]
	public class SandboxV2WorkbenchMakeDialog : UICompDialog<SandboxV2WorkbenchMakeDialog.Options>
	{
		// Token: 0x06019B70 RID: 105328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B70")]
		[Address(RVA = "0x1299AC0", Offset = "0x12986C0", VA = "0x181299AC0")]
		public void OnBackEvent()
		{
		}

		// Token: 0x06019B71 RID: 105329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B71")]
		[Address(RVA = "0x129A290", Offset = "0x1298E90", VA = "0x18129A290")]
		public void OnMakeConfirmEvent()
		{
		}

		// Token: 0x06019B72 RID: 105330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B72")]
		[Address(RVA = "0x129A8E0", Offset = "0x12994E0", VA = "0x18129A8E0")]
		public void OnSelectLevel(int level)
		{
		}

		// Token: 0x06019B73 RID: 105331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B73")]
		[Address(RVA = "0x1299BA0", Offset = "0x12987A0", VA = "0x181299BA0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06019B74 RID: 105332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B74")]
		[Address(RVA = "0x129A810", Offset = "0x1299410", VA = "0x18129A810", Slot = "18")]
		protected override void OnRender(SandboxV2WorkbenchMakeDialog.Options input)
		{
		}

		// Token: 0x06019B75 RID: 105333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B75")]
		[Address(RVA = "0x1299A60", Offset = "0x1298660", VA = "0x181299A60", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06019B76 RID: 105334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B76")]
		[Address(RVA = "0x129C7B0", Offset = "0x129B3B0", VA = "0x18129C7B0")]
		private void _LoadData()
		{
		}

		// Token: 0x06019B77 RID: 105335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B77")]
		[Address(RVA = "0x129E680", Offset = "0x129D280", VA = "0x18129E680")]
		private void _UpdatePanel()
		{
		}

		// Token: 0x06019B78 RID: 105336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B78")]
		[Address(RVA = "0x129E070", Offset = "0x129CC70", VA = "0x18129E070")]
		private void _UpdateMakingItem()
		{
		}

		// Token: 0x06019B79 RID: 105337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B79")]
		[Address(RVA = "0x129DF40", Offset = "0x129CB40", VA = "0x18129DF40")]
		private void _UpdateMakingItemTag()
		{
		}

		// Token: 0x06019B7A RID: 105338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B7A")]
		[Address(RVA = "0x129C230", Offset = "0x129AE30", VA = "0x18129C230")]
		private void _LoadCraftItems(SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x06019B7B RID: 105339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B7B")]
		[Address(RVA = "0x129B8B0", Offset = "0x129A4B0", VA = "0x18129B8B0")]
		private void _LoadAlchemyItems(SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x06019B7C RID: 105340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B7C")]
		[Address(RVA = "0x129BD90", Offset = "0x129A990", VA = "0x18129BD90")]
		private void _LoadCraftItemSingle(SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x06019B7D RID: 105341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B7D")]
		[Address(RVA = "0x129B520", Offset = "0x129A120", VA = "0x18129B520")]
		private void _LoadAlchemyItemSingle(SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x06019B7E RID: 105342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B7E")]
		[Address(RVA = "0x129B130", Offset = "0x1299D30", VA = "0x18129B130")]
		private List<SandboxV2WorkbenchMakeDialog.MakeMaterialModel> _GenerateMaterials(PlayerSandboxV2 playerData, SandboxV2CraftItemData craftData, int makeLimit, out int makeMaximum)
		{
			return null;
		}

		// Token: 0x06019B7F RID: 105343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B7F")]
		[Address(RVA = "0x129ADD0", Offset = "0x12999D0", VA = "0x18129ADD0")]
		private List<SandboxV2WorkbenchMakeDialog.MakeMaterialModel> _GenerateMaterials(PlayerSandboxV2 playerData, SandboxV2AlchemyRecipeData recipeData, int makeLimit, out int makeMaximum)
		{
			return null;
		}

		// Token: 0x06019B80 RID: 105344 RVA: 0x0009F300 File Offset: 0x0009D500
		[Token(Token = "0x6019B80")]
		[Address(RVA = "0x129CAD0", Offset = "0x129B6D0", VA = "0x18129CAD0")]
		private int _MatComparison(SandboxV2WorkbenchMakeDialog.MakeMaterialModel x, SandboxV2WorkbenchMakeDialog.MakeMaterialModel y)
		{
			return 0;
		}

		// Token: 0x06019B81 RID: 105345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B81")]
		[Address(RVA = "0x129E540", Offset = "0x129D140", VA = "0x18129E540")]
		private void _UpdateMakingLevel(int makingLevel)
		{
		}

		// Token: 0x06019B82 RID: 105346 RVA: 0x0009F318 File Offset: 0x0009D518
		[Token(Token = "0x6019B82")]
		[Address(RVA = "0x129D970", Offset = "0x129C570", VA = "0x18129D970")]
		private bool _UpdateMakingCount(int makingCount)
		{
			return default(bool);
		}

		// Token: 0x06019B83 RID: 105347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B83")]
		[Address(RVA = "0x129CF50", Offset = "0x129BB50", VA = "0x18129CF50")]
		private void _OnCraftResponded(SandboxV2CraftResponse response)
		{
		}

		// Token: 0x06019B84 RID: 105348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B84")]
		[Address(RVA = "0x129CC80", Offset = "0x129B880", VA = "0x18129CC80")]
		private void _OnAlchemyResponded(SandboxV2AlchemyResponse response)
		{
		}

		// Token: 0x06019B85 RID: 105349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B85")]
		[Address(RVA = "0x129AAF0", Offset = "0x12996F0", VA = "0x18129AAF0")]
		private void _ConfirmWithMakeResult()
		{
		}

		// Token: 0x06019B86 RID: 105350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B86")]
		[Address(RVA = "0x129D520", Offset = "0x129C120", VA = "0x18129D520")]
		private void _OnMakeCountIncrease()
		{
		}

		// Token: 0x06019B87 RID: 105351 RVA: 0x0009F330 File Offset: 0x0009D530
		[Token(Token = "0x6019B87")]
		[Address(RVA = "0x129D410", Offset = "0x129C010", VA = "0x18129D410")]
		private bool _OnMakeCountIncreaseLongPress()
		{
			return default(bool);
		}

		// Token: 0x06019B88 RID: 105352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B88")]
		[Address(RVA = "0x129D3A0", Offset = "0x129BFA0", VA = "0x18129D3A0")]
		private void _OnMakeCountDecrease()
		{
		}

		// Token: 0x06019B89 RID: 105353 RVA: 0x0009F348 File Offset: 0x0009D548
		[Token(Token = "0x6019B89")]
		[Address(RVA = "0x129D2E0", Offset = "0x129BEE0", VA = "0x18129D2E0")]
		private bool _OnMakeCountDecreaseLongPress()
		{
			return default(bool);
		}

		// Token: 0x06019B8A RID: 105354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B8A")]
		[Address(RVA = "0x129D630", Offset = "0x129C230", VA = "0x18129D630")]
		private void _SendCraftRequest()
		{
		}

		// Token: 0x06019B8B RID: 105355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B8B")]
		[Address(RVA = "0x129ABA0", Offset = "0x12997A0", VA = "0x18129ABA0")]
		private SandboxV2WorkbenchMakeDialog.MakeMaterialModel _GenerateMaterial(PlayerSandboxV2 playerData, string id, int count)
		{
			return null;
		}

		// Token: 0x06019B8C RID: 105356 RVA: 0x0009F360 File Offset: 0x0009D560
		[Token(Token = "0x6019B8C")]
		[Address(RVA = "0x129AA60", Offset = "0x1299660", VA = "0x18129AA60")]
		private static int _AlchemyItemComparison(SandboxV2WorkbenchMakeDialog.MakeItemModel x, SandboxV2WorkbenchMakeDialog.MakeItemModel y)
		{
			return 0;
		}

		// Token: 0x06019B8D RID: 105357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B8D")]
		[Address(RVA = "0x129D8A0", Offset = "0x129C4A0", VA = "0x18129D8A0")]
		private void _TutorialOnly_RegisterButton()
		{
		}

		// Token: 0x06019B8E RID: 105358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B8E")]
		[Address(RVA = "0x129E6F0", Offset = "0x129D2F0", VA = "0x18129E6F0")]
		public SandboxV2WorkbenchMakeDialog()
		{
		}

		// Token: 0x06019B8F RID: 105359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B8F")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06019B90 RID: 105360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B90")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x040202C5 RID: 131781
		[Token(Token = "0x40202C5")]
		private const int MAKE_COUNT_LONG_PRESS_STEP = 1;

		// Token: 0x040202C6 RID: 131782
		[Token(Token = "0x40202C6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBackground;

		// Token: 0x040202C7 RID: 131783
		[Token(Token = "0x40202C7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x040202C8 RID: 131784
		[Token(Token = "0x40202C8")]
		[FieldOffset(Offset = "0x80")]
		[Space(12f)]
		[Header("Base")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x040202C9 RID: 131785
		[Token(Token = "0x40202C9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _itemCardHolder;

		// Token: 0x040202CA RID: 131786
		[Token(Token = "0x40202CA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x040202CB RID: 131787
		[Token(Token = "0x40202CB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x040202CC RID: 131788
		[Token(Token = "0x40202CC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _usageText;

		// Token: 0x040202CD RID: 131789
		[Token(Token = "0x40202CD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _descText;

		// Token: 0x040202CE RID: 131790
		[Token(Token = "0x40202CE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _tagPanel;

		// Token: 0x040202CF RID: 131791
		[Token(Token = "0x40202CF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image _tagPicImage;

		// Token: 0x040202D0 RID: 131792
		[Token(Token = "0x40202D0")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _tagNameText;

		// Token: 0x040202D1 RID: 131793
		[Token(Token = "0x40202D1")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _stockText;

		// Token: 0x040202D2 RID: 131794
		[Token(Token = "0x40202D2")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _deployStatusPanel;

		// Token: 0x040202D3 RID: 131795
		[Token(Token = "0x40202D3")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _deployStatusText;

		// Token: 0x040202D4 RID: 131796
		[Token(Token = "0x40202D4")]
		[FieldOffset(Offset = "0xE0")]
		[Space(12f)]
		[Header("Down Side")]
		[SerializeField]
		private SimpleLayoutContent _materialContent;

		// Token: 0x040202D5 RID: 131797
		[Token(Token = "0x40202D5")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _materialItemCardScale;

		// Token: 0x040202D6 RID: 131798
		[Token(Token = "0x40202D6")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Image _increaseMakeCountButtonImage;

		// Token: 0x040202D7 RID: 131799
		[Token(Token = "0x40202D7")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UILongPressButtonEx _decreaseMakeCountButton;

		// Token: 0x040202D8 RID: 131800
		[Token(Token = "0x40202D8")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UILongPressButtonEx _increaseMakeCountButton;

		// Token: 0x040202D9 RID: 131801
		[Token(Token = "0x40202D9")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Text _makeCountText;

		// Token: 0x040202DA RID: 131802
		[Token(Token = "0x40202DA")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Text _totalCountText;

		// Token: 0x040202DB RID: 131803
		[Token(Token = "0x40202DB")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Color _validColor;

		// Token: 0x040202DC RID: 131804
		[Token(Token = "0x40202DC")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Color _invalidColor;

		// Token: 0x040202DD RID: 131805
		[Token(Token = "0x40202DD")]
		[FieldOffset(Offset = "0x138")]
		[Header("Variants")]
		[SerializeField]
		[Space(12f)]
		private GameObject _levelPanel;

		// Token: 0x040202DE RID: 131806
		[Token(Token = "0x40202DE")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private GameObject[] _alchemyPanels;

		// Token: 0x040202DF RID: 131807
		[Token(Token = "0x40202DF")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject[] _craftPanels;

		// Token: 0x040202E0 RID: 131808
		[Token(Token = "0x40202E0")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private GameObject _makeValidPanel;

		// Token: 0x040202E1 RID: 131809
		[Token(Token = "0x40202E1")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private GameObject _makeInvalidPanel;

		// Token: 0x040202E2 RID: 131810
		[Token(Token = "0x40202E2")]
		[FieldOffset(Offset = "0x160")]
		[Space(12f)]
		[Header("Animations")]
		[SerializeField]
		private SandboxV2WorkbenchMakeDialog.MakeLevelGroup[] _levelGroups;

		// Token: 0x040202E3 RID: 131811
		[Token(Token = "0x40202E3")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private UIAnimationLocation _itemAnimation;

		// Token: 0x040202E4 RID: 131812
		[Token(Token = "0x40202E4")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private CanvasGroup _lowGroup;

		// Token: 0x040202E5 RID: 131813
		[Token(Token = "0x40202E5")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private CanvasGroup _highNearGroup;

		// Token: 0x040202E6 RID: 131814
		[Token(Token = "0x40202E6")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private CanvasGroup _highFarGroup;

		// Token: 0x040202E7 RID: 131815
		[Token(Token = "0x40202E7")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private CanvasGroup[] _switchGroups;

		// Token: 0x040202E8 RID: 131816
		[Token(Token = "0x40202E8")]
		[FieldOffset(Offset = "0x198")]
		private readonly List<SandboxV2WorkbenchMakeDialog.MakeItemModel> m_items;

		// Token: 0x040202E9 RID: 131817
		[Token(Token = "0x40202E9")]
		[FieldOffset(Offset = "0x1A0")]
		private SandboxV2ItemCard m_makeItemCard;

		// Token: 0x040202EA RID: 131818
		[Token(Token = "0x40202EA")]
		[FieldOffset(Offset = "0x1A8")]
		private SandboxV2WorkbenchMakeDialog.MatAdapter m_matAdapter;

		// Token: 0x040202EB RID: 131819
		[Token(Token = "0x40202EB")]
		[FieldOffset(Offset = "0x1B0")]
		private SandboxV2WorkbenchMakeDialog.LevelAnimator m_levelAnimator;

		// Token: 0x040202EC RID: 131820
		[Token(Token = "0x40202EC")]
		[FieldOffset(Offset = "0x1B8")]
		private SandboxV2WorkbenchMakeDialog.Options m_options;

		// Token: 0x040202ED RID: 131821
		[Token(Token = "0x40202ED")]
		[FieldOffset(Offset = "0x1C0")]
		private string m_waterId;

		// Token: 0x040202EE RID: 131822
		[Token(Token = "0x40202EE")]
		[FieldOffset(Offset = "0x1C8")]
		private string m_goldId;

		// Token: 0x040202EF RID: 131823
		[Token(Token = "0x40202EF")]
		[FieldOffset(Offset = "0x1D0")]
		private int m_goldCount;

		// Token: 0x040202F0 RID: 131824
		[Token(Token = "0x40202F0")]
		[FieldOffset(Offset = "0x1D4")]
		private int m_onceMakeLimit;

		// Token: 0x040202F1 RID: 131825
		[Token(Token = "0x40202F1")]
		[FieldOffset(Offset = "0x1D8")]
		private int m_makingLevel;

		// Token: 0x040202F2 RID: 131826
		[Token(Token = "0x40202F2")]
		[FieldOffset(Offset = "0x1E0")]
		private SandboxV2WorkbenchMakeDialog.MakeItemModel m_makingItem;

		// Token: 0x040202F3 RID: 131827
		[Token(Token = "0x40202F3")]
		[FieldOffset(Offset = "0x1E8")]
		private int m_makingCount;

		// Token: 0x040202F4 RID: 131828
		[Token(Token = "0x40202F4")]
		[FieldOffset(Offset = "0x1EC")]
		private bool m_makeValid;

		// Token: 0x040202F5 RID: 131829
		[Token(Token = "0x40202F5")]
		[FieldOffset(Offset = "0x1F0")]
		private SandboxV2WorkbenchMakeDialog.WorkBenchMakeResult m_cachedMakeResult;

		// Token: 0x040202F6 RID: 131830
		[Token(Token = "0x40202F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBackEvent;

		// Token: 0x040202F7 RID: 131831
		[Token(Token = "0x40202F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMakeConfirmEvent;

		// Token: 0x040202F8 RID: 131832
		[Token(Token = "0x40202F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSelectLevel;

		// Token: 0x040202F9 RID: 131833
		[Token(Token = "0x40202F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040202FA RID: 131834
		[Token(Token = "0x40202FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040202FB RID: 131835
		[Token(Token = "0x40202FB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040202FC RID: 131836
		[Token(Token = "0x40202FC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x040202FD RID: 131837
		[Token(Token = "0x40202FD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdatePanel;

		// Token: 0x040202FE RID: 131838
		[Token(Token = "0x40202FE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateMakingItem;

		// Token: 0x040202FF RID: 131839
		[Token(Token = "0x40202FF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateMakingItemTag;

		// Token: 0x04020300 RID: 131840
		[Token(Token = "0x4020300")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadCraftItems;

		// Token: 0x04020301 RID: 131841
		[Token(Token = "0x4020301")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadAlchemyItems;

		// Token: 0x04020302 RID: 131842
		[Token(Token = "0x4020302")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadCraftItemSingle;

		// Token: 0x04020303 RID: 131843
		[Token(Token = "0x4020303")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadAlchemyItemSingle;

		// Token: 0x04020304 RID: 131844
		[Token(Token = "0x4020304")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenerateMaterials;

		// Token: 0x04020305 RID: 131845
		[Token(Token = "0x4020305")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1__GenerateMaterials;

		// Token: 0x04020306 RID: 131846
		[Token(Token = "0x4020306")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__MatComparison;

		// Token: 0x04020307 RID: 131847
		[Token(Token = "0x4020307")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateMakingLevel;

		// Token: 0x04020308 RID: 131848
		[Token(Token = "0x4020308")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateMakingCount;

		// Token: 0x04020309 RID: 131849
		[Token(Token = "0x4020309")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnCraftResponded;

		// Token: 0x0402030A RID: 131850
		[Token(Token = "0x402030A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnAlchemyResponded;

		// Token: 0x0402030B RID: 131851
		[Token(Token = "0x402030B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ConfirmWithMakeResult;

		// Token: 0x0402030C RID: 131852
		[Token(Token = "0x402030C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnMakeCountIncrease;

		// Token: 0x0402030D RID: 131853
		[Token(Token = "0x402030D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnMakeCountIncreaseLongPress;

		// Token: 0x0402030E RID: 131854
		[Token(Token = "0x402030E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnMakeCountDecrease;

		// Token: 0x0402030F RID: 131855
		[Token(Token = "0x402030F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnMakeCountDecreaseLongPress;

		// Token: 0x04020310 RID: 131856
		[Token(Token = "0x4020310")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__SendCraftRequest;

		// Token: 0x04020311 RID: 131857
		[Token(Token = "0x4020311")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GenerateMaterial;

		// Token: 0x04020312 RID: 131858
		[Token(Token = "0x4020312")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__AlchemyItemComparison;

		// Token: 0x04020313 RID: 131859
		[Token(Token = "0x4020313")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RegisterButton;

		// Token: 0x04020314 RID: 131860
		[Token(Token = "0x4020314")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020040F5 RID: 16629
		[Token(Token = "0x20040F5")]
		public class WorkBenchMakeResult
		{
			// Token: 0x06019B91 RID: 105361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019B91")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public WorkBenchMakeResult()
			{
			}

			// Token: 0x04020315 RID: 131861
			[Token(Token = "0x4020315")]
			[FieldOffset(Offset = "0x10")]
			public bool hasMade;

			// Token: 0x04020316 RID: 131862
			[Token(Token = "0x4020316")]
			[FieldOffset(Offset = "0x18")]
			public string itemId;

			// Token: 0x04020317 RID: 131863
			[Token(Token = "0x4020317")]
			[FieldOffset(Offset = "0x20")]
			public int count;
		}

		// Token: 0x020040F6 RID: 16630
		[Token(Token = "0x20040F6")]
		public class Options
		{
			// Token: 0x06019B92 RID: 105362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019B92")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x04020318 RID: 131864
			[Token(Token = "0x4020318")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x04020319 RID: 131865
			[Token(Token = "0x4020319")]
			[FieldOffset(Offset = "0x18")]
			public bool isAlchemy;

			// Token: 0x0402031A RID: 131866
			[Token(Token = "0x402031A")]
			[FieldOffset(Offset = "0x20")]
			public string makeId;

			// Token: 0x0402031B RID: 131867
			[Token(Token = "0x402031B")]
			[FieldOffset(Offset = "0x28")]
			public bool autoSquad;

			// Token: 0x0402031C RID: 131868
			[Token(Token = "0x402031C")]
			[FieldOffset(Offset = "0x29")]
			public bool hideLevels;
		}

		// Token: 0x020040F7 RID: 16631
		[Token(Token = "0x20040F7")]
		private class MakeMaterialModel
		{
			// Token: 0x06019B93 RID: 105363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019B93")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MakeMaterialModel()
			{
			}

			// Token: 0x0402031D RID: 131869
			[Token(Token = "0x402031D")]
			[FieldOffset(Offset = "0x10")]
			public UIItemViewModel matItem;

			// Token: 0x0402031E RID: 131870
			[Token(Token = "0x402031E")]
			[FieldOffset(Offset = "0x18")]
			public int singleCount;
		}

		// Token: 0x020040F8 RID: 16632
		[Token(Token = "0x20040F8")]
		private class MakeItemModel
		{
			// Token: 0x06019B94 RID: 105364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019B94")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MakeItemModel()
			{
			}

			// Token: 0x0402031F RID: 131871
			[Token(Token = "0x402031F")]
			[FieldOffset(Offset = "0x10")]
			public bool locked;

			// Token: 0x04020320 RID: 131872
			[Token(Token = "0x4020320")]
			[FieldOffset(Offset = "0x18")]
			public string unlockDesc;

			// Token: 0x04020321 RID: 131873
			[Token(Token = "0x4020321")]
			[FieldOffset(Offset = "0x20")]
			public UIItemViewModel output;

			// Token: 0x04020322 RID: 131874
			[Token(Token = "0x4020322")]
			[FieldOffset(Offset = "0x28")]
			public int stock;

			// Token: 0x04020323 RID: 131875
			[Token(Token = "0x4020323")]
			[FieldOffset(Offset = "0x30")]
			public List<SandboxV2WorkbenchMakeDialog.MakeMaterialModel> materials;

			// Token: 0x04020324 RID: 131876
			[Token(Token = "0x4020324")]
			[FieldOffset(Offset = "0x38")]
			public int makeMaximum;

			// Token: 0x04020325 RID: 131877
			[Token(Token = "0x4020325")]
			[FieldOffset(Offset = "0x3C")]
			public bool isAlchemy;

			// Token: 0x04020326 RID: 131878
			[Token(Token = "0x4020326")]
			[FieldOffset(Offset = "0x40")]
			public string tagName;

			// Token: 0x04020327 RID: 131879
			[Token(Token = "0x4020327")]
			[FieldOffset(Offset = "0x48")]
			public string tagPic;

			// Token: 0x04020328 RID: 131880
			[Token(Token = "0x4020328")]
			[FieldOffset(Offset = "0x50")]
			public bool isLimited;

			// Token: 0x04020329 RID: 131881
			[Token(Token = "0x4020329")]
			[FieldOffset(Offset = "0x54")]
			public int deployedMaximum;

			// Token: 0x0402032A RID: 131882
			[Token(Token = "0x402032A")]
			[FieldOffset(Offset = "0x58")]
			public int deployedCount;

			// Token: 0x0402032B RID: 131883
			[Token(Token = "0x402032B")]
			[FieldOffset(Offset = "0x60")]
			public string recipeId;

			// Token: 0x0402032C RID: 131884
			[Token(Token = "0x402032C")]
			[FieldOffset(Offset = "0x68")]
			public int recipeLevel;
		}

		// Token: 0x020040F9 RID: 16633
		[Token(Token = "0x20040F9")]
		private class MatAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003D5A RID: 15706
			// (get) Token: 0x06019B95 RID: 105365 RVA: 0x0009F378 File Offset: 0x0009D578
			[Token(Token = "0x17003D5A")]
			public override int count
			{
				[Token(Token = "0x6019B95")]
				[Address(RVA = "0x128DB90", Offset = "0x128C790", VA = "0x18128DB90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019B96 RID: 105366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019B96")]
			[Address(RVA = "0x128DB10", Offset = "0x128C710", VA = "0x18128DB10")]
			public MatAdapter(SandboxV2WorkbenchMakeDialog closure)
			{
			}

			// Token: 0x06019B97 RID: 105367 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019B97")]
			[Address(RVA = "0x128D6D0", Offset = "0x128C2D0", VA = "0x18128D6D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06019B98 RID: 105368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019B98")]
			[Address(RVA = "0x128D9B0", Offset = "0x128C5B0", VA = "0x18128D9B0")]
			private void _ItemClickEvent(int position)
			{
			}

			// Token: 0x0402032D RID: 131885
			[Token(Token = "0x402032D")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2WorkbenchMakeDialog m_closure;

			// Token: 0x0402032E RID: 131886
			[Token(Token = "0x402032E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402032F RID: 131887
			[Token(Token = "0x402032F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020330 RID: 131888
			[Token(Token = "0x4020330")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04020331 RID: 131889
			[Token(Token = "0x4020331")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__ItemClickEvent;
		}

		// Token: 0x020040FA RID: 16634
		[Token(Token = "0x20040FA")]
		[Serializable]
		public struct MakeLevelGroup
		{
			// Token: 0x04020332 RID: 131890
			[Token(Token = "0x4020332")]
			[FieldOffset(Offset = "0x0")]
			public GameObject rootPanel;

			// Token: 0x04020333 RID: 131891
			[Token(Token = "0x4020333")]
			[FieldOffset(Offset = "0x8")]
			public GameObject lockedPanel;

			// Token: 0x04020334 RID: 131892
			[Token(Token = "0x4020334")]
			[FieldOffset(Offset = "0x10")]
			public GameObject normalPanel;

			// Token: 0x04020335 RID: 131893
			[Token(Token = "0x4020335")]
			[FieldOffset(Offset = "0x18")]
			public UIAnimationLocation selectAnimation;
		}

		// Token: 0x020040FB RID: 16635
		[Token(Token = "0x20040FB")]
		private class LevelAnimator : IHotfixable
		{
			// Token: 0x06019B99 RID: 105369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019B99")]
			[Address(RVA = "0x128CFF0", Offset = "0x128BBF0", VA = "0x18128CFF0")]
			public LevelAnimator(SandboxV2WorkbenchMakeDialog.LevelAnimator.LevelAnimatorArgs args)
			{
			}

			// Token: 0x06019B9A RID: 105370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019B9A")]
			[Address(RVA = "0x128BF60", Offset = "0x128AB60", VA = "0x18128BF60")]
			public void InitLevelStep(List<SandboxV2WorkbenchMakeDialog.MakeItemModel> makeItems, int resetLevel)
			{
			}

			// Token: 0x06019B9B RID: 105371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019B9B")]
			[Address(RVA = "0x128C310", Offset = "0x128AF10", VA = "0x18128C310")]
			public void SetLevel(int position)
			{
			}

			// Token: 0x06019B9C RID: 105372 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019B9C")]
			[Address(RVA = "0x128C730", Offset = "0x128B330", VA = "0x18128C730")]
			private Tweener _GenerateItemTweener()
			{
				return null;
			}

			// Token: 0x06019B9D RID: 105373 RVA: 0x0009F390 File Offset: 0x0009D590
			[Token(Token = "0x6019B9D")]
			[Address(RVA = "0x128CB90", Offset = "0x128B790", VA = "0x18128CB90")]
			private float _GetItemPosition()
			{
				return 0f;
			}

			// Token: 0x06019B9E RID: 105374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019B9E")]
			[Address(RVA = "0x128CC50", Offset = "0x128B850", VA = "0x18128CC50")]
			private void _SetItemPosition(float value)
			{
			}

			// Token: 0x06019B9F RID: 105375 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019B9F")]
			[Address(RVA = "0x128C8C0", Offset = "0x128B4C0", VA = "0x18128C8C0")]
			private Sequence _GenerateSequenceOfSwitch()
			{
				return null;
			}

			// Token: 0x06019BA0 RID: 105376 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019BA0")]
			[Address(RVA = "0x128CA20", Offset = "0x128B620", VA = "0x18128CA20")]
			private Tweener _GenerateSwitchTweener(float target, float duration)
			{
				return null;
			}

			// Token: 0x06019BA1 RID: 105377 RVA: 0x0009F3A8 File Offset: 0x0009D5A8
			[Token(Token = "0x6019BA1")]
			[Address(RVA = "0x128CBF0", Offset = "0x128B7F0", VA = "0x18128CBF0")]
			private float _GetSwitchAlpha()
			{
				return 0f;
			}

			// Token: 0x06019BA2 RID: 105378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019BA2")]
			[Address(RVA = "0x128CE90", Offset = "0x128BA90", VA = "0x18128CE90")]
			private void _SetSwitchAlpha(float value)
			{
			}

			// Token: 0x04020336 RID: 131894
			[Token(Token = "0x4020336")]
			private const float NEAR_HIDE_POSITION = 0.5f;

			// Token: 0x04020337 RID: 131895
			[Token(Token = "0x4020337")]
			private const float HIGH_NEAR_DYNAMIC_TIME = 0.5f;

			// Token: 0x04020338 RID: 131896
			[Token(Token = "0x4020338")]
			private const float HIGH_FAR_HIDE_INVERSED_POSITION = 0.5f;

			// Token: 0x04020339 RID: 131897
			[Token(Token = "0x4020339")]
			[FieldOffset(Offset = "0x10")]
			private SandboxV2WorkbenchMakeDialog.LevelAnimator.LevelAnimatorArgs m_args;

			// Token: 0x0402033A RID: 131898
			[Token(Token = "0x402033A")]
			[FieldOffset(Offset = "0x58")]
			private readonly GameObject m_levelPanel;

			// Token: 0x0402033B RID: 131899
			[Token(Token = "0x402033B")]
			[FieldOffset(Offset = "0x60")]
			private readonly List<SandboxV2WorkbenchMakeDialog.MakeLevelGroup> m_levelGroups;

			// Token: 0x0402033C RID: 131900
			[Token(Token = "0x402033C")]
			[FieldOffset(Offset = "0x68")]
			private readonly List<UISwitchTween> m_levelGroupSwitchTweens;

			// Token: 0x0402033D RID: 131901
			[Token(Token = "0x402033D")]
			[FieldOffset(Offset = "0x70")]
			private readonly UIAnimationLocation m_itemAnimationLocation;

			// Token: 0x0402033E RID: 131902
			[Token(Token = "0x402033E")]
			[FieldOffset(Offset = "0x80")]
			private readonly CanvasGroup m_downGroup;

			// Token: 0x0402033F RID: 131903
			[Token(Token = "0x402033F")]
			[FieldOffset(Offset = "0x88")]
			private readonly CanvasGroup m_highNearGroup;

			// Token: 0x04020340 RID: 131904
			[Token(Token = "0x4020340")]
			[FieldOffset(Offset = "0x90")]
			private readonly CanvasGroup m_highFarGroup;

			// Token: 0x04020341 RID: 131905
			[Token(Token = "0x4020341")]
			[FieldOffset(Offset = "0x98")]
			private readonly float m_fullTime;

			// Token: 0x04020342 RID: 131906
			[Token(Token = "0x4020342")]
			[FieldOffset(Offset = "0x9C")]
			private readonly float m_halfTime;

			// Token: 0x04020343 RID: 131907
			[Token(Token = "0x4020343")]
			[FieldOffset(Offset = "0xA0")]
			private readonly List<CanvasGroup> m_switchGroups;

			// Token: 0x04020344 RID: 131908
			[Token(Token = "0x4020344")]
			[FieldOffset(Offset = "0xA8")]
			private readonly Action m_updateAction;

			// Token: 0x04020345 RID: 131909
			[Token(Token = "0x4020345")]
			[FieldOffset(Offset = "0xB0")]
			private int m_maxPosition;

			// Token: 0x04020346 RID: 131910
			[Token(Token = "0x4020346")]
			[FieldOffset(Offset = "0xB4")]
			private int m_cachedPosition;

			// Token: 0x04020347 RID: 131911
			[Token(Token = "0x4020347")]
			[FieldOffset(Offset = "0xB8")]
			private float m_playingPosition;

			// Token: 0x04020348 RID: 131912
			[Token(Token = "0x4020348")]
			[FieldOffset(Offset = "0xC0")]
			private Tween m_itemTween;

			// Token: 0x04020349 RID: 131913
			[Token(Token = "0x4020349")]
			[FieldOffset(Offset = "0xC8")]
			private Tween m_switchTween;

			// Token: 0x0402034A RID: 131914
			[Token(Token = "0x402034A")]
			[FieldOffset(Offset = "0xD0")]
			private float m_switchAlpha;

			// Token: 0x0402034B RID: 131915
			[Token(Token = "0x402034B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402034C RID: 131916
			[Token(Token = "0x402034C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InitLevelStep;

			// Token: 0x0402034D RID: 131917
			[Token(Token = "0x402034D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetLevel;

			// Token: 0x0402034E RID: 131918
			[Token(Token = "0x402034E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GenerateItemTweener;

			// Token: 0x0402034F RID: 131919
			[Token(Token = "0x402034F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GetItemPosition;

			// Token: 0x04020350 RID: 131920
			[Token(Token = "0x4020350")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__SetItemPosition;

			// Token: 0x04020351 RID: 131921
			[Token(Token = "0x4020351")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__GenerateSequenceOfSwitch;

			// Token: 0x04020352 RID: 131922
			[Token(Token = "0x4020352")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__GenerateSwitchTweener;

			// Token: 0x04020353 RID: 131923
			[Token(Token = "0x4020353")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__GetSwitchAlpha;

			// Token: 0x04020354 RID: 131924
			[Token(Token = "0x4020354")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__SetSwitchAlpha;

			// Token: 0x020040FC RID: 16636
			[Token(Token = "0x20040FC")]
			public struct LevelAnimatorArgs
			{
				// Token: 0x04020355 RID: 131925
				[Token(Token = "0x4020355")]
				[FieldOffset(Offset = "0x0")]
				public GameObject levelPanel;

				// Token: 0x04020356 RID: 131926
				[Token(Token = "0x4020356")]
				[FieldOffset(Offset = "0x8")]
				public SandboxV2WorkbenchMakeDialog.MakeLevelGroup[] levelGroups;

				// Token: 0x04020357 RID: 131927
				[Token(Token = "0x4020357")]
				[FieldOffset(Offset = "0x10")]
				public UIAnimationLocation itemAnimation;

				// Token: 0x04020358 RID: 131928
				[Token(Token = "0x4020358")]
				[FieldOffset(Offset = "0x20")]
				public CanvasGroup lowGroup;

				// Token: 0x04020359 RID: 131929
				[Token(Token = "0x4020359")]
				[FieldOffset(Offset = "0x28")]
				public CanvasGroup highNearGroup;

				// Token: 0x0402035A RID: 131930
				[Token(Token = "0x402035A")]
				[FieldOffset(Offset = "0x30")]
				public CanvasGroup highFarGroup;

				// Token: 0x0402035B RID: 131931
				[Token(Token = "0x402035B")]
				[FieldOffset(Offset = "0x38")]
				public CanvasGroup[] switchGroups;

				// Token: 0x0402035C RID: 131932
				[Token(Token = "0x402035C")]
				[FieldOffset(Offset = "0x40")]
				public Action updateAction;
			}
		}
	}
}
