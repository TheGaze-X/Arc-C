using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004762 RID: 18274
	[Token(Token = "0x2004762")]
	public class RecruitGachaView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170041C1 RID: 16833
		// (get) Token: 0x0601BAB1 RID: 113329 RVA: 0x000A5CA8 File Offset: 0x000A3EA8
		[Token(Token = "0x170041C1")]
		public bool isCurrentNormalPage
		{
			[Token(Token = "0x601BAB1")]
			[Address(RVA = "0x151AB20", Offset = "0x1519720", VA = "0x18151AB20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601BAB2 RID: 113330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAB2")]
		[Address(RVA = "0x1518F30", Offset = "0x1517B30", VA = "0x181518F30")]
		public void RefreshGachaTkState()
		{
		}

		// Token: 0x0601BAB3 RID: 113331 RVA: 0x000A5CC0 File Offset: 0x000A3EC0
		[Token(Token = "0x601BAB3")]
		[Address(RVA = "0x151A260", Offset = "0x1518E60", VA = "0x18151A260")]
		private int _JudgeNewBeeOpenState(int index)
		{
			return 0;
		}

		// Token: 0x0601BAB4 RID: 113332 RVA: 0x000A5CD8 File Offset: 0x000A3ED8
		[Token(Token = "0x601BAB4")]
		[Address(RVA = "0x15196F0", Offset = "0x15182F0", VA = "0x1815196F0")]
		private bool _CompareNewbeeClientAndNormalClient(NewbeeGachaPoolClientData newbeePoolData, GachaPoolClientData normalGachaPoolData)
		{
			return default(bool);
		}

		// Token: 0x0601BAB5 RID: 113333 RVA: 0x000A5CF0 File Offset: 0x000A3EF0
		[Token(Token = "0x601BAB5")]
		[Address(RVA = "0x151A370", Offset = "0x1518F70", VA = "0x18151A370")]
		private int _MergeSortAndRender(string initGachaPool)
		{
			return 0;
		}

		// Token: 0x0601BAB6 RID: 113334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAB6")]
		[Address(RVA = "0x1518A10", Offset = "0x1517610", VA = "0x181518A10")]
		public void InitData(bool isNormal, string initGachaPoolId)
		{
		}

		// Token: 0x0601BAB7 RID: 113335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAB7")]
		[Address(RVA = "0x151A750", Offset = "0x1519350", VA = "0x18151A750")]
		private void _PlayPoolInitEffect(int pageIndex)
		{
		}

		// Token: 0x0601BAB8 RID: 113336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAB8")]
		[Address(RVA = "0x1519290", Offset = "0x1517E90", VA = "0x181519290")]
		public void ToLeftPage()
		{
		}

		// Token: 0x0601BAB9 RID: 113337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAB9")]
		[Address(RVA = "0x1519330", Offset = "0x1517F30", VA = "0x181519330")]
		public void ToRightPage()
		{
		}

		// Token: 0x0601BABA RID: 113338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BABA")]
		[Address(RVA = "0x1519000", Offset = "0x1517C00", VA = "0x181519000")]
		public void SwitchPage(bool isNormal)
		{
		}

		// Token: 0x0601BABB RID: 113339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BABB")]
		[Address(RVA = "0x1519090", Offset = "0x1517C90", VA = "0x181519090")]
		public void SwitchToPage(bool isNormal, string gachaPoolId)
		{
		}

		// Token: 0x0601BABC RID: 113340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BABC")]
		[Address(RVA = "0x1518EA0", Offset = "0x1517AA0", VA = "0x181518EA0")]
		public void OnClear()
		{
		}

		// Token: 0x0601BABD RID: 113341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BABD")]
		[Address(RVA = "0x1519C00", Offset = "0x1518800", VA = "0x181519C00")]
		private void _InitPage(GachaPoolClientData data)
		{
		}

		// Token: 0x0601BABE RID: 113342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BABE")]
		[Address(RVA = "0x1519890", Offset = "0x1518490", VA = "0x181519890")]
		private void _InitClassicPage(GachaPoolClientData data)
		{
		}

		// Token: 0x0601BABF RID: 113343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BABF")]
		[Address(RVA = "0x151A0B0", Offset = "0x1518CB0", VA = "0x18151A0B0")]
		private void _InitSpecialPage(GachaPoolClientData data)
		{
		}

		// Token: 0x0601BAC0 RID: 113344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAC0")]
		[Address(RVA = "0x1519E40", Offset = "0x1518A40", VA = "0x181519E40")]
		private void _InitReturnPage(GachaPoolClientData data)
		{
		}

		// Token: 0x0601BAC1 RID: 113345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAC1")]
		[Address(RVA = "0x1519A40", Offset = "0x1518640", VA = "0x181519A40")]
		private void _InitNewbeePage(NewbeeGachaPoolClientData data)
		{
		}

		// Token: 0x0601BAC2 RID: 113346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAC2")]
		[Address(RVA = "0x151A830", Offset = "0x1519430", VA = "0x18151A830")]
		public void _RefreshHiringStateFade(int pageIndex)
		{
		}

		// Token: 0x0601BAC3 RID: 113347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAC3")]
		[Address(RVA = "0x151A8B0", Offset = "0x15194B0", VA = "0x18151A8B0")]
		private void _RefreshHiringState(int pageIndex, bool isFast)
		{
		}

		// Token: 0x0601BAC4 RID: 113348 RVA: 0x000A5D08 File Offset: 0x000A3F08
		[Token(Token = "0x601BAC4")]
		[Address(RVA = "0x1519570", Offset = "0x1518170", VA = "0x181519570")]
		private int _CalcGachaIndex(string gachaPoolId)
		{
			return 0;
		}

		// Token: 0x0601BAC5 RID: 113349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAC5")]
		[Address(RVA = "0x15193E0", Offset = "0x1517FE0", VA = "0x1815193E0")]
		private void Update()
		{
		}

		// Token: 0x0601BAC6 RID: 113350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAC6")]
		[Address(RVA = "0x151AA60", Offset = "0x1519660", VA = "0x18151AA60")]
		public RecruitGachaView()
		{
		}

		// Token: 0x04023EE5 RID: 147173
		[Token(Token = "0x4023EE5")]
		private const int NORMAL_PAGE_INDEX = 0;

		// Token: 0x04023EE6 RID: 147174
		[Token(Token = "0x4023EE6")]
		private const int ADVANCED_PAGE_OFFSET = 1;

		// Token: 0x04023EE7 RID: 147175
		[Token(Token = "0x4023EE7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _mask;

		// Token: 0x04023EE8 RID: 147176
		[Token(Token = "0x4023EE8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _deltaPos;

		// Token: 0x04023EE9 RID: 147177
		[Token(Token = "0x4023EE9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollViewPager _pageContainer;

		// Token: 0x04023EEA RID: 147178
		[Token(Token = "0x4023EEA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _hiringState;

		// Token: 0x04023EEB RID: 147179
		[Token(Token = "0x4023EEB")]
		[FieldOffset(Offset = "0x38")]
		private List<RecruitGachaItemViewBase> m_pageList;

		// Token: 0x04023EEC RID: 147180
		[Token(Token = "0x4023EEC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04023EED RID: 147181
		[Token(Token = "0x4023EED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIStringEvent _onGacha;

		// Token: 0x04023EEE RID: 147182
		[Token(Token = "0x4023EEE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIStringEvent _onTenGacha;

		// Token: 0x04023EEF RID: 147183
		[Token(Token = "0x4023EEF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIStringEvent _onRecruitFree;

		// Token: 0x04023EF0 RID: 147184
		[Token(Token = "0x4023EF0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIStringBoolEvent _onDetailGacha;

		// Token: 0x04023EF1 RID: 147185
		[Token(Token = "0x4023EF1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _leftBtn;

		// Token: 0x04023EF2 RID: 147186
		[Token(Token = "0x4023EF2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _rightBtn;

		// Token: 0x04023EF3 RID: 147187
		[Token(Token = "0x4023EF3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RecruitBuildConfigHiringBar _hiringBar;

		// Token: 0x04023EF4 RID: 147188
		[Token(Token = "0x4023EF4")]
		[FieldOffset(Offset = "0x80")]
		private RefCountReference m_buildingRef;

		// Token: 0x04023EF5 RID: 147189
		[Token(Token = "0x4023EF5")]
		[FieldOffset(Offset = "0x88")]
		private bool m_buildingContextInit;

		// Token: 0x04023EF6 RID: 147190
		[Token(Token = "0x4023EF6")]
		private const float FADETIME = 0.5f;

		// Token: 0x04023EF7 RID: 147191
		[Token(Token = "0x4023EF7")]
		[FieldOffset(Offset = "0x89")]
		private bool nextFrameRefresh;

		// Token: 0x04023EF8 RID: 147192
		[Token(Token = "0x4023EF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCurrentNormalPage;

		// Token: 0x04023EF9 RID: 147193
		[Token(Token = "0x4023EF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshGachaTkState;

		// Token: 0x04023EFA RID: 147194
		[Token(Token = "0x4023EFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__JudgeNewBeeOpenState;

		// Token: 0x04023EFB RID: 147195
		[Token(Token = "0x4023EFB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CompareNewbeeClientAndNormalClient;

		// Token: 0x04023EFC RID: 147196
		[Token(Token = "0x4023EFC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__MergeSortAndRender;

		// Token: 0x04023EFD RID: 147197
		[Token(Token = "0x4023EFD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04023EFE RID: 147198
		[Token(Token = "0x4023EFE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayPoolInitEffect;

		// Token: 0x04023EFF RID: 147199
		[Token(Token = "0x4023EFF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ToLeftPage;

		// Token: 0x04023F00 RID: 147200
		[Token(Token = "0x4023F00")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ToRightPage;

		// Token: 0x04023F01 RID: 147201
		[Token(Token = "0x4023F01")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SwitchPage;

		// Token: 0x04023F02 RID: 147202
		[Token(Token = "0x4023F02")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SwitchToPage;

		// Token: 0x04023F03 RID: 147203
		[Token(Token = "0x4023F03")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnClear;

		// Token: 0x04023F04 RID: 147204
		[Token(Token = "0x4023F04")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitPage;

		// Token: 0x04023F05 RID: 147205
		[Token(Token = "0x4023F05")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitClassicPage;

		// Token: 0x04023F06 RID: 147206
		[Token(Token = "0x4023F06")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitSpecialPage;

		// Token: 0x04023F07 RID: 147207
		[Token(Token = "0x4023F07")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitReturnPage;

		// Token: 0x04023F08 RID: 147208
		[Token(Token = "0x4023F08")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitNewbeePage;

		// Token: 0x04023F09 RID: 147209
		[Token(Token = "0x4023F09")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RefreshHiringStateFade;

		// Token: 0x04023F0A RID: 147210
		[Token(Token = "0x4023F0A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RefreshHiringState;

		// Token: 0x04023F0B RID: 147211
		[Token(Token = "0x4023F0B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CalcGachaIndex;

		// Token: 0x04023F0C RID: 147212
		[Token(Token = "0x4023F0C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04023F0D RID: 147213
		[Token(Token = "0x4023F0D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
