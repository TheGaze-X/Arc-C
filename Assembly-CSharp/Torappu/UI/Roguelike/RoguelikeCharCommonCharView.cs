using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005492 RID: 21650
	[Token(Token = "0x2005492")]
	public class RoguelikeCharCommonCharView : MonoBehaviour, IHotfixable, IAsyncShowEffect, IAsyncDataView<RoguelikeCharCommonCharView.AsyncParam>
	{
		// Token: 0x17004AB5 RID: 19125
		// (get) Token: 0x0601FDBF RID: 130495 RVA: 0x000B38F8 File Offset: 0x000B1AF8
		[Token(Token = "0x17004AB5")]
		public SpriteRenderData defaultSelectOutlineSpriteData
		{
			[Token(Token = "0x601FDBF")]
			[Address(RVA = "0x19EF0F0", Offset = "0x19EDCF0", VA = "0x1819EF0F0")]
			get
			{
				return default(SpriteRenderData);
			}
		}

		// Token: 0x0601FDC0 RID: 130496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDC0")]
		[Address(RVA = "0x19ED780", Offset = "0x19EC380", VA = "0x1819ED780")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FDC1 RID: 130497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDC1")]
		[Address(RVA = "0x19EB630", Offset = "0x19EA230", VA = "0x1819EB630")]
		public void OnClick()
		{
		}

		// Token: 0x0601FDC2 RID: 130498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDC2")]
		[Address(RVA = "0x19EB580", Offset = "0x19EA180", VA = "0x1819EB580")]
		public void OnClickSkill(string skillId)
		{
		}

		// Token: 0x0601FDC3 RID: 130499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDC3")]
		[Address(RVA = "0x19EB260", Offset = "0x19E9E60", VA = "0x1819EB260", Slot = "5")]
		public void AsyncSetData(RoguelikeCharCommonCharView.AsyncParam param)
		{
		}

		// Token: 0x0601FDC4 RID: 130500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDC4")]
		[Address(RVA = "0x19EEDA0", Offset = "0x19ED9A0", VA = "0x1819EEDA0")]
		private void _ResetDecoRootDict()
		{
		}

		// Token: 0x0601FDC5 RID: 130501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDC5")]
		[Address(RVA = "0x19EB3C0", Offset = "0x19E9FC0", VA = "0x1819EB3C0", Slot = "4")]
		public void AsyncShow()
		{
		}

		// Token: 0x0601FDC6 RID: 130502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDC6")]
		[Address(RVA = "0x19EB6C0", Offset = "0x19EA2C0", VA = "0x1819EB6C0")]
		public void Render(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect = false, int selectIndex = -1)
		{
		}

		// Token: 0x0601FDC7 RID: 130503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FDC7")]
		[Address(RVA = "0x19EB470", Offset = "0x19EA070", VA = "0x1819EB470")]
		public static string GetUpTypeText(RoguelikeCharCardViewModel viewModel)
		{
			return null;
		}

		// Token: 0x0601FDC8 RID: 130504 RVA: 0x000B3910 File Offset: 0x000B1B10
		[Token(Token = "0x601FDC8")]
		[Address(RVA = "0x19EDDE0", Offset = "0x19EC9E0", VA = "0x1819EDDE0")]
		private bool _OverrideRaritySprite(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out Sprite overrideSprite)
		{
			return default(bool);
		}

		// Token: 0x0601FDC9 RID: 130505 RVA: 0x000B3928 File Offset: 0x000B1B28
		[Token(Token = "0x601FDC9")]
		[Address(RVA = "0x19EE040", Offset = "0x19ECC40", VA = "0x1819EE040")]
		private bool _OverrideSelectSprite(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out SpriteRenderData overrideSprite)
		{
			return default(bool);
		}

		// Token: 0x0601FDCA RID: 130506 RVA: 0x000B3940 File Offset: 0x000B1B40
		[Token(Token = "0x601FDCA")]
		[Address(RVA = "0x19ED8F0", Offset = "0x19EC4F0", VA = "0x1819ED8F0")]
		private bool _OverrideCharNameColor(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out Color overrideColor)
		{
			return default(bool);
		}

		// Token: 0x0601FDCB RID: 130507 RVA: 0x000B3958 File Offset: 0x000B1B58
		[Token(Token = "0x601FDCB")]
		[Address(RVA = "0x19EDB30", Offset = "0x19EC730", VA = "0x1819EDB30")]
		private bool _OverrideConflictPanel(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out RoguelikeSelectCharConflictPanel overridePrefab, out IRoguelikeCharCardPlugin plugin)
		{
			return default(bool);
		}

		// Token: 0x0601FDCC RID: 130508 RVA: 0x000B3970 File Offset: 0x000B1B70
		[Token(Token = "0x601FDCC")]
		[Address(RVA = "0x19EE4E0", Offset = "0x19ED0E0", VA = "0x1819EE4E0")]
		private bool _OverrideValid(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out bool overrideValid)
		{
			return default(bool);
		}

		// Token: 0x0601FDCD RID: 130509 RVA: 0x000B3988 File Offset: 0x000B1B88
		[Token(Token = "0x601FDCD")]
		[Address(RVA = "0x19ECC00", Offset = "0x19EB800", VA = "0x1819ECC00")]
		private bool _CheckIfHideUpText(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex)
		{
			return default(bool);
		}

		// Token: 0x0601FDCE RID: 130510 RVA: 0x000B39A0 File Offset: 0x000B1BA0
		[Token(Token = "0x601FDCE")]
		[Address(RVA = "0x19EE2E0", Offset = "0x19ECEE0", VA = "0x1819EE2E0")]
		private bool _OverrideShowUpgradeFlag(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, out bool isShow)
		{
			return default(bool);
		}

		// Token: 0x0601FDCF RID: 130511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDCF")]
		[Address(RVA = "0x19ED5F0", Offset = "0x19EC1F0", VA = "0x1819ED5F0")]
		private void _DealWithNPC(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig)
		{
		}

		// Token: 0x0601FDD0 RID: 130512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDD0")]
		[Address(RVA = "0x19ED300", Offset = "0x19EBF00", VA = "0x1819ED300")]
		private void _DealWithFriend(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig)
		{
		}

		// Token: 0x0601FDD1 RID: 130513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDD1")]
		[Address(RVA = "0x19ED6A0", Offset = "0x19EC2A0", VA = "0x1819ED6A0")]
		private void _DealWithUpgradeFlag(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig)
		{
		}

		// Token: 0x0601FDD2 RID: 130514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDD2")]
		[Address(RVA = "0x19ED460", Offset = "0x19EC060", VA = "0x1819ED460")]
		private void _DealWithMonthlyTeamFlag(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig)
		{
		}

		// Token: 0x0601FDD3 RID: 130515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDD3")]
		[Address(RVA = "0x19ED3B0", Offset = "0x19EBFB0", VA = "0x1819ED3B0")]
		private void _DealWithIsFreeFlag(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig)
		{
		}

		// Token: 0x0601FDD4 RID: 130516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDD4")]
		[Address(RVA = "0x19ED030", Offset = "0x19EBC30", VA = "0x1819ED030")]
		private void _DealWithCustomDecoPanel(RoguelikeCharCardDecoPanelPluginBase.RoguelikeCharCardDecoInput decoInput)
		{
		}

		// Token: 0x0601FDD5 RID: 130517 RVA: 0x000B39B8 File Offset: 0x000B1BB8
		[Token(Token = "0x601FDD5")]
		[Address(RVA = "0x19ECD60", Offset = "0x19EB960", VA = "0x1819ECD60")]
		private bool _CheckIfNeedRebuildDecos()
		{
			return default(bool);
		}

		// Token: 0x0601FDD6 RID: 130518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDD6")]
		[Address(RVA = "0x19EE730", Offset = "0x19ED330", VA = "0x1819EE730")]
		private void _RebuildDecos(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FDD7 RID: 130519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDD7")]
		[Address(RVA = "0x19ECED0", Offset = "0x19EBAD0", VA = "0x1819ECED0")]
		private void _CollectDecoAssets(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FDD8 RID: 130520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDD8")]
		[Address(RVA = "0x19EEC60", Offset = "0x19ED860", VA = "0x1819EEC60")]
		private void _RefreshAllDecos(RoguelikeCharCardDecoPanelPluginBase.RoguelikeCharCardDecoInput decoInput)
		{
		}

		// Token: 0x0601FDD9 RID: 130521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDD9")]
		[Address(RVA = "0x19EEF70", Offset = "0x19EDB70", VA = "0x1819EEF70")]
		public RoguelikeCharCommonCharView()
		{
		}

		// Token: 0x0402AEB3 RID: 175795
		[Token(Token = "0x402AEB3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _charHeadIcon2;

		// Token: 0x0402AEB4 RID: 175796
		[Token(Token = "0x402AEB4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _professionIcon;

		// Token: 0x0402AEB5 RID: 175797
		[Token(Token = "0x402AEB5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _evolveImg;

		// Token: 0x0402AEB6 RID: 175798
		[Token(Token = "0x402AEB6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _potentialImg;

		// Token: 0x0402AEB7 RID: 175799
		[Token(Token = "0x402AEB7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _levelTxt;

		// Token: 0x0402AEB8 RID: 175800
		[Token(Token = "0x402AEB8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _charName;

		// Token: 0x0402AEB9 RID: 175801
		[Token(Token = "0x402AEB9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _charNameDeco;

		// Token: 0x0402AEBA RID: 175802
		[Token(Token = "0x402AEBA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402AEBB RID: 175803
		[Token(Token = "0x402AEBB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _selectOutLine;

		// Token: 0x0402AEBC RID: 175804
		[Token(Token = "0x402AEBC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _selectImage;

		// Token: 0x0402AEBD RID: 175805
		[Token(Token = "0x402AEBD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _selectIndex;

		// Token: 0x0402AEBE RID: 175806
		[Token(Token = "0x402AEBE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeCharUpgradeViewBase _defaultUpgradeView;

		// Token: 0x0402AEBF RID: 175807
		[Token(Token = "0x402AEBF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _charPart;

		// Token: 0x0402AEC0 RID: 175808
		[Token(Token = "0x402AEC0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _buyPart;

		// Token: 0x0402AEC1 RID: 175809
		[Token(Token = "0x402AEC1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _isFree;

		// Token: 0x0402AEC2 RID: 175810
		[Token(Token = "0x402AEC2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _isNPC;

		// Token: 0x0402AEC3 RID: 175811
		[Token(Token = "0x402AEC3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _isFriendAssist;

		// Token: 0x0402AEC4 RID: 175812
		[Token(Token = "0x402AEC4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _isMonthlyTeam;

		// Token: 0x0402AEC5 RID: 175813
		[Token(Token = "0x402AEC5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAtlasImage _monthlyImg;

		// Token: 0x0402AEC6 RID: 175814
		[Token(Token = "0x402AEC6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _monthlyCharCardTagName;

		// Token: 0x0402AEC7 RID: 175815
		[Token(Token = "0x402AEC7")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _isUpgradeFlag;

		// Token: 0x0402AEC8 RID: 175816
		[Token(Token = "0x402AEC8")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform _conflictPanelHolder;

		// Token: 0x0402AEC9 RID: 175817
		[Token(Token = "0x402AEC9")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _popText;

		// Token: 0x0402AECA RID: 175818
		[Token(Token = "0x402AECA")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x0402AECB RID: 175819
		[Token(Token = "0x402AECB")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _upType;

		// Token: 0x0402AECC RID: 175820
		[Token(Token = "0x402AECC")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Image _branchIcon;

		// Token: 0x0402AECD RID: 175821
		[Token(Token = "0x402AECD")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402AECE RID: 175822
		[Token(Token = "0x402AECE")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402AECF RID: 175823
		[Token(Token = "0x402AECF")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("AsyncLoad")]
		private float _fadeInDur;

		// Token: 0x0402AED0 RID: 175824
		[Token(Token = "0x402AED0")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Custom Card Deco")]
		private RoguelikeCharCardDecoRoot[] _decoRoots;

		// Token: 0x0402AED1 RID: 175825
		[Token(Token = "0x402AED1")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Char Select Outline")]
		private UIAtlasObject _defaultSelectOutlineSpriteObject;

		// Token: 0x0402AED2 RID: 175826
		[Token(Token = "0x402AED2")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Char Select Outline")]
		private string _defaultSelectOutlineSpriteName;

		// Token: 0x0402AED3 RID: 175827
		[Token(Token = "0x402AED3")]
		[FieldOffset(Offset = "0x118")]
		[NonSerialized]
		public UIIntEvent charClick;

		// Token: 0x0402AED4 RID: 175828
		[Token(Token = "0x402AED4")]
		[FieldOffset(Offset = "0x120")]
		[NonSerialized]
		public UIIntStringEvent charSkillClick;

		// Token: 0x0402AED5 RID: 175829
		[Token(Token = "0x402AED5")]
		[FieldOffset(Offset = "0x128")]
		[NonSerialized]
		public List<IRoguelikeCharCardPlugin> plugins;

		// Token: 0x0402AED6 RID: 175830
		[Token(Token = "0x402AED6")]
		[FieldOffset(Offset = "0x130")]
		[NonSerialized]
		public string topicId;

		// Token: 0x0402AED7 RID: 175831
		[Token(Token = "0x402AED7")]
		[FieldOffset(Offset = "0x138")]
		private int m_cacheInstId;

		// Token: 0x0402AED8 RID: 175832
		[Token(Token = "0x402AED8")]
		[FieldOffset(Offset = "0x140")]
		private RoguelikeSelectCharConflictPanel m_conflictPanel;

		// Token: 0x0402AED9 RID: 175833
		[Token(Token = "0x402AED9")]
		[FieldOffset(Offset = "0x148")]
		private RoguelikeCharCommonCharView.SkillAdapter m_adapter;

		// Token: 0x0402AEDA RID: 175834
		[Token(Token = "0x402AEDA")]
		[FieldOffset(Offset = "0x150")]
		private List<RoguelikeCharCardDecoPanelPluginBase> m_decos;

		// Token: 0x0402AEDB RID: 175835
		[Token(Token = "0x402AEDB")]
		[FieldOffset(Offset = "0x158")]
		private EnumIntDictionary<RoguelikeCharCardDecoPanelPluginBase.DecoLayer, RoguelikeCharCardDecoRoot> m_decoRootDict;

		// Token: 0x0402AEDC RID: 175836
		[Token(Token = "0x402AEDC")]
		[FieldOffset(Offset = "0x160")]
		private SpriteRenderData m_selectOutlineSpriteData;

		// Token: 0x0402AEDD RID: 175837
		[Token(Token = "0x402AEDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_defaultSelectOutlineSpriteData;

		// Token: 0x0402AEDE RID: 175838
		[Token(Token = "0x402AEDE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AEDF RID: 175839
		[Token(Token = "0x402AEDF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402AEE0 RID: 175840
		[Token(Token = "0x402AEE0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickSkill;

		// Token: 0x0402AEE1 RID: 175841
		[Token(Token = "0x402AEE1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x0402AEE2 RID: 175842
		[Token(Token = "0x402AEE2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetDecoRootDict;

		// Token: 0x0402AEE3 RID: 175843
		[Token(Token = "0x402AEE3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AsyncShow;

		// Token: 0x0402AEE4 RID: 175844
		[Token(Token = "0x402AEE4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AEE5 RID: 175845
		[Token(Token = "0x402AEE5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetUpTypeText;

		// Token: 0x0402AEE6 RID: 175846
		[Token(Token = "0x402AEE6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OverrideRaritySprite;

		// Token: 0x0402AEE7 RID: 175847
		[Token(Token = "0x402AEE7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OverrideSelectSprite;

		// Token: 0x0402AEE8 RID: 175848
		[Token(Token = "0x402AEE8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OverrideCharNameColor;

		// Token: 0x0402AEE9 RID: 175849
		[Token(Token = "0x402AEE9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OverrideConflictPanel;

		// Token: 0x0402AEEA RID: 175850
		[Token(Token = "0x402AEEA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OverrideValid;

		// Token: 0x0402AEEB RID: 175851
		[Token(Token = "0x402AEEB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckIfHideUpText;

		// Token: 0x0402AEEC RID: 175852
		[Token(Token = "0x402AEEC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OverrideShowUpgradeFlag;

		// Token: 0x0402AEED RID: 175853
		[Token(Token = "0x402AEED")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DealWithNPC;

		// Token: 0x0402AEEE RID: 175854
		[Token(Token = "0x402AEEE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__DealWithFriend;

		// Token: 0x0402AEEF RID: 175855
		[Token(Token = "0x402AEEF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__DealWithUpgradeFlag;

		// Token: 0x0402AEF0 RID: 175856
		[Token(Token = "0x402AEF0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DealWithMonthlyTeamFlag;

		// Token: 0x0402AEF1 RID: 175857
		[Token(Token = "0x402AEF1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__DealWithIsFreeFlag;

		// Token: 0x0402AEF2 RID: 175858
		[Token(Token = "0x402AEF2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__DealWithCustomDecoPanel;

		// Token: 0x0402AEF3 RID: 175859
		[Token(Token = "0x402AEF3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CheckIfNeedRebuildDecos;

		// Token: 0x0402AEF4 RID: 175860
		[Token(Token = "0x402AEF4")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RebuildDecos;

		// Token: 0x0402AEF5 RID: 175861
		[Token(Token = "0x402AEF5")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CollectDecoAssets;

		// Token: 0x0402AEF6 RID: 175862
		[Token(Token = "0x402AEF6")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RefreshAllDecos;

		// Token: 0x0402AEF7 RID: 175863
		[Token(Token = "0x402AEF7")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005493 RID: 21651
		[Token(Token = "0x2005493")]
		public struct AsyncParam
		{
			// Token: 0x0402AEF8 RID: 175864
			[Token(Token = "0x402AEF8")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0402AEF9 RID: 175865
			[Token(Token = "0x402AEF9")]
			[FieldOffset(Offset = "0x8")]
			public RoguelikeCharCardViewModel cardModel;

			// Token: 0x0402AEFA RID: 175866
			[Token(Token = "0x402AEFA")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeCharSelectStateBean.ShowConfig showConfig;

			// Token: 0x0402AEFB RID: 175867
			[Token(Token = "0x402AEFB")]
			[FieldOffset(Offset = "0x12")]
			public bool isSelect;

			// Token: 0x0402AEFC RID: 175868
			[Token(Token = "0x402AEFC")]
			[FieldOffset(Offset = "0x14")]
			public int selectIndex;

			// Token: 0x0402AEFD RID: 175869
			[Token(Token = "0x402AEFD")]
			[FieldOffset(Offset = "0x18")]
			public UIIntEvent charClick;

			// Token: 0x0402AEFE RID: 175870
			[Token(Token = "0x402AEFE")]
			[FieldOffset(Offset = "0x20")]
			public UIIntStringEvent charSkillClick;

			// Token: 0x0402AEFF RID: 175871
			[Token(Token = "0x402AEFF")]
			[FieldOffset(Offset = "0x28")]
			public List<IRoguelikeCharCardPlugin> plugins;
		}

		// Token: 0x02005494 RID: 21652
		[Token(Token = "0x2005494")]
		private class SkillAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004AB6 RID: 19126
			// (get) Token: 0x0601FDDA RID: 130522 RVA: 0x000B39D0 File Offset: 0x000B1BD0
			[Token(Token = "0x17004AB6")]
			public override int count
			{
				[Token(Token = "0x601FDDA")]
				[Address(RVA = "0x19FE010", Offset = "0x19FCC10", VA = "0x1819FE010", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601FDDB RID: 130523 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FDDB")]
			[Address(RVA = "0x19FD770", Offset = "0x19FC370", VA = "0x1819FD770", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601FDDC RID: 130524 RVA: 0x000B39E8 File Offset: 0x000B1BE8
			[Token(Token = "0x601FDDC")]
			[Address(RVA = "0x19FDDD0", Offset = "0x19FC9D0", VA = "0x1819FDDD0")]
			private bool _CheckSkillUnselectGlow(int position)
			{
				return default(bool);
			}

			// Token: 0x0601FDDD RID: 130525 RVA: 0x000B3A00 File Offset: 0x000B1C00
			[Token(Token = "0x601FDDD")]
			[Address(RVA = "0x19FDD10", Offset = "0x19FC910", VA = "0x1819FDD10")]
			private bool _CheckSkillUnlockGlow(int position)
			{
				return default(bool);
			}

			// Token: 0x0601FDDE RID: 130526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FDDE")]
			[Address(RVA = "0x19FDE90", Offset = "0x19FCA90", VA = "0x1819FDE90")]
			public SkillAdapter()
			{
			}

			// Token: 0x0402AF00 RID: 175872
			[Token(Token = "0x402AF00")]
			[FieldOffset(Offset = "0x20")]
			public List<RoguelikeCharSelectSkillItemViewModel> skillList;

			// Token: 0x0402AF01 RID: 175873
			[Token(Token = "0x402AF01")]
			[FieldOffset(Offset = "0x28")]
			public int selectSkillIndex;

			// Token: 0x0402AF02 RID: 175874
			[Token(Token = "0x402AF02")]
			[FieldOffset(Offset = "0x30")]
			public Action<string> onClickSkill;

			// Token: 0x0402AF03 RID: 175875
			[Token(Token = "0x402AF03")]
			[FieldOffset(Offset = "0x38")]
			public RoguelikeCharCardViewModel.ShowType showType;

			// Token: 0x0402AF04 RID: 175876
			[Token(Token = "0x402AF04")]
			[FieldOffset(Offset = "0x3C")]
			public int skillCachedCount;

			// Token: 0x0402AF05 RID: 175877
			[Token(Token = "0x402AF05")]
			[FieldOffset(Offset = "0x40")]
			public int unlockedSkillCount;

			// Token: 0x0402AF06 RID: 175878
			[Token(Token = "0x402AF06")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402AF07 RID: 175879
			[Token(Token = "0x402AF07")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402AF08 RID: 175880
			[Token(Token = "0x402AF08")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__CheckSkillUnselectGlow;

			// Token: 0x0402AF09 RID: 175881
			[Token(Token = "0x402AF09")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__CheckSkillUnlockGlow;

			// Token: 0x0402AF0A RID: 175882
			[Token(Token = "0x402AF0A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
