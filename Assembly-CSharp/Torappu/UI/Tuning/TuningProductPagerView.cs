using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CDC RID: 15580
	[Token(Token = "0x2003CDC")]
	public class TuningProductPagerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601849F RID: 99487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601849F")]
		[Address(RVA = "0x10CBB90", Offset = "0x10CA790", VA = "0x1810CBB90")]
		public void Render(ListDict<string, TuningOrcheModel> orcheModelListDict)
		{
		}

		// Token: 0x060184A0 RID: 99488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184A0")]
		[Address(RVA = "0x10CBDB0", Offset = "0x10CA9B0", VA = "0x1810CBDB0")]
		public void ResetPagerPosToDefault()
		{
		}

		// Token: 0x060184A1 RID: 99489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184A1")]
		[Address(RVA = "0x10CC030", Offset = "0x10CAC30", VA = "0x1810CC030")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060184A2 RID: 99490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184A2")]
		[Address(RVA = "0x10CC5D0", Offset = "0x10CB1D0", VA = "0x1810CC5D0")]
		private void _SetArrowActive(float zoneIndex)
		{
		}

		// Token: 0x060184A3 RID: 99491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60184A3")]
		[Address(RVA = "0x10CBE70", Offset = "0x10CAA70", VA = "0x1810CBE70")]
		private TuningProductOrcheItemView _GetItemView(int position)
		{
			return null;
		}

		// Token: 0x060184A4 RID: 99492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184A4")]
		[Address(RVA = "0x10CC400", Offset = "0x10CB000", VA = "0x1810CC400")]
		private void _SampleMovingAnim(float pagerVal)
		{
		}

		// Token: 0x060184A5 RID: 99493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60184A5")]
		[Address(RVA = "0x10CBF00", Offset = "0x10CAB00", VA = "0x1810CBF00")]
		private string _GetSelectItemId(int index)
		{
			return null;
		}

		// Token: 0x060184A6 RID: 99494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184A6")]
		[Address(RVA = "0x10CC380", Offset = "0x10CAF80", VA = "0x1810CC380")]
		private void _OnInstPagerUpdating(float pagerVal)
		{
		}

		// Token: 0x060184A7 RID: 99495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184A7")]
		[Address(RVA = "0x10CC1E0", Offset = "0x10CADE0", VA = "0x1810CC1E0")]
		private void _OnInstPageChangeEnd(int zoneIndex)
		{
		}

		// Token: 0x060184A8 RID: 99496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184A8")]
		[Address(RVA = "0x10CBA60", Offset = "0x10CA660", VA = "0x1810CBA60")]
		public void OnClickLeftArrow()
		{
		}

		// Token: 0x060184A9 RID: 99497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184A9")]
		[Address(RVA = "0x10CBAF0", Offset = "0x10CA6F0", VA = "0x1810CBAF0")]
		public void OnClickRightArrow()
		{
		}

		// Token: 0x060184AA RID: 99498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184AA")]
		[Address(RVA = "0x10CC690", Offset = "0x10CB290", VA = "0x1810CC690")]
		public TuningProductPagerView()
		{
		}

		// Token: 0x0401DA88 RID: 121480
		[Token(Token = "0x401DA88")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollViewPager _scrollViewPager;

		// Token: 0x0401DA89 RID: 121481
		[Token(Token = "0x401DA89")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<TuningProductOrcheItemView> _orcheViewList;

		// Token: 0x0401DA8A RID: 121482
		[Token(Token = "0x401DA8A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _spaceStep;

		// Token: 0x0401DA8B RID: 121483
		[Token(Token = "0x401DA8B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _leftArrow;

		// Token: 0x0401DA8C RID: 121484
		[Token(Token = "0x401DA8C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _rightArrow;

		// Token: 0x0401DA8D RID: 121485
		[Token(Token = "0x401DA8D")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0401DA8E RID: 121486
		[Token(Token = "0x401DA8E")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<string, TuningOrcheModel> m_cachedOrcheModelListDict;

		// Token: 0x0401DA8F RID: 121487
		[Token(Token = "0x401DA8F")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401DA90 RID: 121488
		[Token(Token = "0x401DA90")]
		[FieldOffset(Offset = "0x60")]
		private int m_orcheIdViewPairCnt;

		// Token: 0x0401DA91 RID: 121489
		[Token(Token = "0x401DA91")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<string> onSelectOrche;

		// Token: 0x0401DA92 RID: 121490
		[Token(Token = "0x401DA92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DA93 RID: 121491
		[Token(Token = "0x401DA93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetPagerPosToDefault;

		// Token: 0x0401DA94 RID: 121492
		[Token(Token = "0x401DA94")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DA95 RID: 121493
		[Token(Token = "0x401DA95")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetArrowActive;

		// Token: 0x0401DA96 RID: 121494
		[Token(Token = "0x401DA96")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetItemView;

		// Token: 0x0401DA97 RID: 121495
		[Token(Token = "0x401DA97")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SampleMovingAnim;

		// Token: 0x0401DA98 RID: 121496
		[Token(Token = "0x401DA98")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetSelectItemId;

		// Token: 0x0401DA99 RID: 121497
		[Token(Token = "0x401DA99")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnInstPagerUpdating;

		// Token: 0x0401DA9A RID: 121498
		[Token(Token = "0x401DA9A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnInstPageChangeEnd;

		// Token: 0x0401DA9B RID: 121499
		[Token(Token = "0x401DA9B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnClickLeftArrow;

		// Token: 0x0401DA9C RID: 121500
		[Token(Token = "0x401DA9C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClickRightArrow;

		// Token: 0x0401DA9D RID: 121501
		[Token(Token = "0x401DA9D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
