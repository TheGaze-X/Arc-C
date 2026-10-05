using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004751 RID: 18257
	[Token(Token = "0x2004751")]
	public class RecruitClassicGachaItemView : RecruitGachaItemViewBase
	{
		// Token: 0x170041BC RID: 16828
		// (get) Token: 0x0601BA57 RID: 113239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170041BC")]
		public override string gachaPoolId
		{
			[Token(Token = "0x601BA57")]
			[Address(RVA = "0x14FE310", Offset = "0x14FCF10", VA = "0x1814FE310", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BA58 RID: 113240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA58")]
		[Address(RVA = "0x14FBB10", Offset = "0x14FA710", VA = "0x1814FBB10", Slot = "5")]
		protected override void OnRefreshData()
		{
		}

		// Token: 0x0601BA59 RID: 113241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA59")]
		[Address(RVA = "0x14FB910", Offset = "0x14FA510", VA = "0x1814FB910")]
		public void ApplyData(int index, GachaPoolClientData data)
		{
		}

		// Token: 0x0601BA5A RID: 113242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA5A")]
		[Address(RVA = "0x14FBA60", Offset = "0x14FA660", VA = "0x1814FBA60")]
		public void EventOnClassicSHDBtnClick()
		{
		}

		// Token: 0x0601BA5B RID: 113243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA5B")]
		[Address(RVA = "0x14FE200", Offset = "0x14FCE00", VA = "0x1814FE200")]
		private void _UpdateViewStateAndRender()
		{
		}

		// Token: 0x0601BA5C RID: 113244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA5C")]
		[Address(RVA = "0x14FDFD0", Offset = "0x14FCBD0", VA = "0x1814FDFD0")]
		private void _RenderViewWithState()
		{
		}

		// Token: 0x0601BA5D RID: 113245 RVA: 0x000A5B58 File Offset: 0x000A3D58
		[Token(Token = "0x601BA5D")]
		[Address(RVA = "0x14FC2C0", Offset = "0x14FAEC0", VA = "0x1814FC2C0")]
		private RecruitClassicGachaItemView.ClassicParam _GeneClassicParam(GachaPoolClientData data)
		{
			return default(RecruitClassicGachaItemView.ClassicParam);
		}

		// Token: 0x0601BA5E RID: 113246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA5E")]
		[Address(RVA = "0x14FD460", Offset = "0x14FC060", VA = "0x1814FD460")]
		private void _RenderNormGachaView(GachaPoolClientData data, RecruitClassicGachaItemView.ClassicParam classicParam)
		{
		}

		// Token: 0x0601BA5F RID: 113247 RVA: 0x000A5B70 File Offset: 0x000A3D70
		[Token(Token = "0x601BA5F")]
		[Address(RVA = "0x14FC790", Offset = "0x14FB390", VA = "0x1814FC790")]
		private RecruitClassicGachaItemView.ClassicParam _GeneNormClassicGachaParam(GachaPoolClientData data)
		{
			return default(RecruitClassicGachaItemView.ClassicParam);
		}

		// Token: 0x0601BA60 RID: 113248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA60")]
		[Address(RVA = "0x14FD060", Offset = "0x14FBC60", VA = "0x1814FD060")]
		private void _RenderInitGachaView(GachaPoolClientData data)
		{
		}

		// Token: 0x0601BA61 RID: 113249 RVA: 0x000A5B88 File Offset: 0x000A3D88
		[Token(Token = "0x601BA61")]
		[Address(RVA = "0x14FC430", Offset = "0x14FB030", VA = "0x1814FC430")]
		private RecruitClassicGachaItemView.ClassicParam _GeneFesClassicGachaParam()
		{
			return default(RecruitClassicGachaItemView.ClassicParam);
		}

		// Token: 0x0601BA62 RID: 113250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA62")]
		[Address(RVA = "0x14FC060", Offset = "0x14FAC60", VA = "0x1814FC060")]
		private void _EventOnInitViewStartBtnClick()
		{
		}

		// Token: 0x0601BA63 RID: 113251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA63")]
		[Address(RVA = "0x14FBFB0", Offset = "0x14FABB0", VA = "0x1814FBFB0")]
		private void _EventOnInitViewDetailBtnClick()
		{
		}

		// Token: 0x0601BA64 RID: 113252 RVA: 0x000A5BA0 File Offset: 0x000A3DA0
		[Token(Token = "0x601BA64")]
		[Address(RVA = "0x14FCBC0", Offset = "0x14FB7C0", VA = "0x1814FCBC0")]
		private CharUISkinStruct _GetSkinStruct(string charId, out CharacterData characterData)
		{
			return default(CharUISkinStruct);
		}

		// Token: 0x0601BA65 RID: 113253 RVA: 0x000A5BB8 File Offset: 0x000A3DB8
		[Token(Token = "0x601BA65")]
		[Address(RVA = "0x14FCDB0", Offset = "0x14FB9B0", VA = "0x1814FCDB0")]
		private bool _LoadAndSetIllusts(CharUISkinStruct skinStruct, CharUISkinStruct cachedSkinStruct, UICharacterIllust charIllust, RectTransform container)
		{
			return default(bool);
		}

		// Token: 0x0601BA66 RID: 113254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA66")]
		[Address(RVA = "0x14FBEF0", Offset = "0x14FAAF0", VA = "0x1814FBEF0")]
		private void _ClearIllusts(UICharacterIllust charIllust)
		{
		}

		// Token: 0x0601BA67 RID: 113255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA67")]
		[Address(RVA = "0x14FDD30", Offset = "0x14FC930", VA = "0x1814FDD30")]
		private void _RenderRare5Char(string charId, UIAtlasImage charPortrait, Image profession, Text nameText)
		{
		}

		// Token: 0x0601BA68 RID: 113256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA68")]
		[Address(RVA = "0x14FCA40", Offset = "0x14FB640", VA = "0x1814FCA40")]
		private void _GetRemainGuaranteeStatus(out bool hasRemainFlag, out int remainCnt)
		{
		}

		// Token: 0x0601BA69 RID: 113257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA69")]
		[Address(RVA = "0x14FE2B0", Offset = "0x14FCEB0", VA = "0x1814FE2B0")]
		public RecruitClassicGachaItemView()
		{
		}

		// Token: 0x04023DF6 RID: 146934
		[Token(Token = "0x4023DF6")]
		private const string CLASSIC_MAIN_6_CHAR_ID = "main6RarityCharId";

		// Token: 0x04023DF7 RID: 146935
		[Token(Token = "0x4023DF7")]
		private const string CLASSIC_SUB_6_CHAR_ID = "sub6RarityCharId";

		// Token: 0x04023DF8 RID: 146936
		[Token(Token = "0x4023DF8")]
		private const string CLASSIC_RARE_5_CHAR = "rare5CharList";

		// Token: 0x04023DF9 RID: 146937
		[Token(Token = "0x4023DF9")]
		private const int RARE_5_CHAR_COUNT = 3;

		// Token: 0x04023DFA RID: 146938
		[Token(Token = "0x4023DFA")]
		private const int INDEX_RARE_6_SHOP_CHAR = 0;

		// Token: 0x04023DFB RID: 146939
		[Token(Token = "0x4023DFB")]
		private const int INDEX_RARE_6_NORM_CHAR = 1;

		// Token: 0x04023DFC RID: 146940
		[Token(Token = "0x4023DFC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelFesInitView;

		// Token: 0x04023DFD RID: 146941
		[Token(Token = "0x4023DFD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelNormGachaView;

		// Token: 0x04023DFE RID: 146942
		[Token(Token = "0x4023DFE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _recruitName;

		// Token: 0x04023DFF RID: 146943
		[Token(Token = "0x4023DFF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _recruitSummary;

		// Token: 0x04023E00 RID: 146944
		[Token(Token = "0x4023E00")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelNormUpTitle;

		// Token: 0x04023E01 RID: 146945
		[Token(Token = "0x4023E01")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelFesUpTitle;

		// Token: 0x04023E02 RID: 146946
		[Token(Token = "0x4023E02")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Recruit")]
		private Text _singleCrystalPrice;

		// Token: 0x04023E03 RID: 146947
		[Token(Token = "0x4023E03")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Recruit")]
		private Text _multiCrystalPrice;

		// Token: 0x04023E04 RID: 146948
		[Token(Token = "0x4023E04")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _diamondShObj;

		// Token: 0x04023E05 RID: 146949
		[Token(Token = "0x4023E05")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _gachaObj;

		// Token: 0x04023E06 RID: 146950
		[Token(Token = "0x4023E06")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _diamondShTenObj;

		// Token: 0x04023E07 RID: 146951
		[Token(Token = "0x4023E07")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _gachaTenObj;

		// Token: 0x04023E08 RID: 146952
		[Token(Token = "0x4023E08")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _gachaBatchedTenObj;

		// Token: 0x04023E09 RID: 146953
		[Token(Token = "0x4023E09")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _classicGachaObj;

		// Token: 0x04023E0A RID: 146954
		[Token(Token = "0x4023E0A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _classicGachaTenObj;

		// Token: 0x04023E0B RID: 146955
		[Token(Token = "0x4023E0B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _classicGachaBatchedTenObj;

		// Token: 0x04023E0C RID: 146956
		[Token(Token = "0x4023E0C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _combineGachaTenObj;

		// Token: 0x04023E0D RID: 146957
		[Token(Token = "0x4023E0D")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Classic")]
		private RectTransform _rectTransformIllust1;

		// Token: 0x04023E0E RID: 146958
		[Token(Token = "0x4023E0E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Classic")]
		private RectTransform _rectTransformIllust2;

		// Token: 0x04023E0F RID: 146959
		[Token(Token = "0x4023E0F")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Classic")]
		private Image _imgIllust1Profession;

		// Token: 0x04023E10 RID: 146960
		[Token(Token = "0x4023E10")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Classic")]
		private Image _imgIllust2Profession;

		// Token: 0x04023E11 RID: 146961
		[Token(Token = "0x4023E11")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Classic")]
		private Text _txtIllust1Name;

		// Token: 0x04023E12 RID: 146962
		[Token(Token = "0x4023E12")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Classic")]
		private Text _txtIllust2Name;

		// Token: 0x04023E13 RID: 146963
		[Token(Token = "0x4023E13")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Classic")]
		private UIAtlasImage[] _imgCharPortraits;

		// Token: 0x04023E14 RID: 146964
		[Token(Token = "0x4023E14")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Classic")]
		private Image[] _imgCharProfessions;

		// Token: 0x04023E15 RID: 146965
		[Token(Token = "0x4023E15")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Classic")]
		private Text[] _txtCharNames;

		// Token: 0x04023E16 RID: 146966
		[Token(Token = "0x4023E16")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Classic")]
		private Text _txtTktName;

		// Token: 0x04023E17 RID: 146967
		[Token(Token = "0x4023E17")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Classic")]
		private RecruitGachaCharButton _illust1CharButton;

		// Token: 0x04023E18 RID: 146968
		[Token(Token = "0x4023E18")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Classic")]
		private RecruitGachaCharButton _illust2CharButton;

		// Token: 0x04023E19 RID: 146969
		[Token(Token = "0x4023E19")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		protected GameObject _protectPart;

		// Token: 0x04023E1A RID: 146970
		[Token(Token = "0x4023E1A")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Text _remainTimes;

		// Token: 0x04023E1B RID: 146971
		[Token(Token = "0x4023E1B")]
		[FieldOffset(Offset = "0x158")]
		private GachaPoolClientData m_data;

		// Token: 0x04023E1C RID: 146972
		[Token(Token = "0x4023E1C")]
		[FieldOffset(Offset = "0x160")]
		private UICharacterIllust m_illust1;

		// Token: 0x04023E1D RID: 146973
		[Token(Token = "0x4023E1D")]
		[FieldOffset(Offset = "0x168")]
		private CharUISkinStruct m_illust1SkinStruct;

		// Token: 0x04023E1E RID: 146974
		[Token(Token = "0x4023E1E")]
		[FieldOffset(Offset = "0x180")]
		private UICharacterIllust m_illust2;

		// Token: 0x04023E1F RID: 146975
		[Token(Token = "0x4023E1F")]
		[FieldOffset(Offset = "0x188")]
		private CharUISkinStruct m_illust2SkinStruct;

		// Token: 0x04023E20 RID: 146976
		[Token(Token = "0x4023E20")]
		[FieldOffset(Offset = "0x1A0")]
		private RecruitClassicGachaItemView.GachaViewState m_viewState;

		// Token: 0x04023E21 RID: 146977
		[Token(Token = "0x4023E21")]
		[FieldOffset(Offset = "0x1A8")]
		private RecruitClassicGachaInitView m_initView;

		// Token: 0x04023E22 RID: 146978
		[Token(Token = "0x4023E22")]
		[FieldOffset(Offset = "0x1B0")]
		private GameObject m_fesUpTitleView;

		// Token: 0x04023E23 RID: 146979
		[Token(Token = "0x4023E23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gachaPoolId;

		// Token: 0x04023E24 RID: 146980
		[Token(Token = "0x4023E24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x04023E25 RID: 146981
		[Token(Token = "0x4023E25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04023E26 RID: 146982
		[Token(Token = "0x4023E26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClassicSHDBtnClick;

		// Token: 0x04023E27 RID: 146983
		[Token(Token = "0x4023E27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateViewStateAndRender;

		// Token: 0x04023E28 RID: 146984
		[Token(Token = "0x4023E28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderViewWithState;

		// Token: 0x04023E29 RID: 146985
		[Token(Token = "0x4023E29")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GeneClassicParam;

		// Token: 0x04023E2A RID: 146986
		[Token(Token = "0x4023E2A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderNormGachaView;

		// Token: 0x04023E2B RID: 146987
		[Token(Token = "0x4023E2B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GeneNormClassicGachaParam;

		// Token: 0x04023E2C RID: 146988
		[Token(Token = "0x4023E2C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderInitGachaView;

		// Token: 0x04023E2D RID: 146989
		[Token(Token = "0x4023E2D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GeneFesClassicGachaParam;

		// Token: 0x04023E2E RID: 146990
		[Token(Token = "0x4023E2E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnInitViewStartBtnClick;

		// Token: 0x04023E2F RID: 146991
		[Token(Token = "0x4023E2F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnInitViewDetailBtnClick;

		// Token: 0x04023E30 RID: 146992
		[Token(Token = "0x4023E30")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetSkinStruct;

		// Token: 0x04023E31 RID: 146993
		[Token(Token = "0x4023E31")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadAndSetIllusts;

		// Token: 0x04023E32 RID: 146994
		[Token(Token = "0x4023E32")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ClearIllusts;

		// Token: 0x04023E33 RID: 146995
		[Token(Token = "0x4023E33")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderRare5Char;

		// Token: 0x04023E34 RID: 146996
		[Token(Token = "0x4023E34")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetRemainGuaranteeStatus;

		// Token: 0x04023E35 RID: 146997
		[Token(Token = "0x4023E35")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004752 RID: 18258
		[Token(Token = "0x2004752")]
		private enum GachaViewState
		{
			// Token: 0x04023E37 RID: 146999
			[Token(Token = "0x4023E37")]
			NORM_VIEW,
			// Token: 0x04023E38 RID: 147000
			[Token(Token = "0x4023E38")]
			INIT_VIEW
		}

		// Token: 0x02004753 RID: 18259
		[Token(Token = "0x2004753")]
		private struct ClassicParam : IHotfixable
		{
			// Token: 0x04023E39 RID: 147001
			[Token(Token = "0x4023E39")]
			[FieldOffset(Offset = "0x0")]
			public string main6CharId;

			// Token: 0x04023E3A RID: 147002
			[Token(Token = "0x4023E3A")]
			[FieldOffset(Offset = "0x8")]
			public string sub6CharId;

			// Token: 0x04023E3B RID: 147003
			[Token(Token = "0x4023E3B")]
			[FieldOffset(Offset = "0x10")]
			public List<string> rare5CharList;
		}
	}
}
