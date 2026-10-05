using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006523 RID: 25891
	[Token(Token = "0x2006523")]
	public class ArtMagazineCoverLeafsView : DataBinder<ArtMagazineCoverViewModelProperty>
	{
		// Token: 0x0602535E RID: 152414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602535E")]
		[Address(RVA = "0x202E350", Offset = "0x202CF50", VA = "0x18202E350", Slot = "7")]
		public override void OnValueChanged(ArtMagazineCoverViewModelProperty property)
		{
		}

		// Token: 0x0602535F RID: 152415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602535F")]
		[Address(RVA = "0x202E940", Offset = "0x202D540", VA = "0x18202E940")]
		private void _InitIfNot(int leafsMaxCount)
		{
		}

		// Token: 0x06025360 RID: 152416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025360")]
		[Address(RVA = "0x202F030", Offset = "0x202DC30", VA = "0x18202F030")]
		private void _ResetEntryAnim()
		{
		}

		// Token: 0x06025361 RID: 152417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025361")]
		[Address(RVA = "0x202E6C0", Offset = "0x202D2C0", VA = "0x18202E6C0")]
		private void _EnsureLeafItems(int leafsMaxCount)
		{
		}

		// Token: 0x06025362 RID: 152418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025362")]
		[Address(RVA = "0x202EF00", Offset = "0x202DB00", VA = "0x18202EF00")]
		private void _RenderLeafs(ArtMagazineCoverViewModel coverViewModel)
		{
		}

		// Token: 0x06025363 RID: 152419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025363")]
		[Address(RVA = "0x202F1D0", Offset = "0x202DDD0", VA = "0x18202F1D0")]
		private void _TryShowLeafsEnterAnim()
		{
		}

		// Token: 0x06025364 RID: 152420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025364")]
		[Address(RVA = "0x202EB60", Offset = "0x202D760", VA = "0x18202EB60")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x06025365 RID: 152421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025365")]
		[Address(RVA = "0x202E210", Offset = "0x202CE10", VA = "0x18202E210")]
		public void EventOnClick()
		{
		}

		// Token: 0x06025366 RID: 152422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025366")]
		[Address(RVA = "0x202F240", Offset = "0x202DE40", VA = "0x18202F240")]
		public ArtMagazineCoverLeafsView()
		{
		}

		// Token: 0x04034311 RID: 213777
		[Token(Token = "0x4034311")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<RectTransform> _leafsHolder;

		// Token: 0x04034312 RID: 213778
		[Token(Token = "0x4034312")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtMagazineCoverLeafItemView _leafItemViewPrefab;

		// Token: 0x04034313 RID: 213779
		[Token(Token = "0x4034313")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIColorGraphic _hotspotGraphic;

		// Token: 0x04034314 RID: 213780
		[Token(Token = "0x4034314")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _leafEntryAnimDelay;

		// Token: 0x04034315 RID: 213781
		[Token(Token = "0x4034315")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _leafShowAnimDelay;

		// Token: 0x04034316 RID: 213782
		[Token(Token = "0x4034316")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _leafEntryAnimInterval;

		// Token: 0x04034317 RID: 213783
		[Token(Token = "0x4034317")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _leafShowAnimInterval;

		// Token: 0x04034318 RID: 213784
		[Token(Token = "0x4034318")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorLeafBoarder;

		// Token: 0x04034319 RID: 213785
		[Token(Token = "0x4034319")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403431A RID: 213786
		[Token(Token = "0x403431A")]
		[FieldOffset(Offset = "0x60")]
		private List<ArtMagazineCoverLeafItemView> m_leafItemViews;

		// Token: 0x0403431B RID: 213787
		[Token(Token = "0x403431B")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isAllLeafEmpty;

		// Token: 0x0403431C RID: 213788
		[Token(Token = "0x403431C")]
		[FieldOffset(Offset = "0x70")]
		private Sequence m_leafEnterAnimSeq;

		// Token: 0x0403431D RID: 213789
		[Token(Token = "0x403431D")]
		[FieldOffset(Offset = "0x78")]
		private int m_leafEnterSeqNum;

		// Token: 0x0403431E RID: 213790
		[Token(Token = "0x403431E")]
		[FieldOffset(Offset = "0x80")]
		private List<string> m_leafIdNotEmptyList;

		// Token: 0x0403431F RID: 213791
		[Token(Token = "0x403431F")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasEnterAnimPlayed;

		// Token: 0x04034320 RID: 213792
		[Token(Token = "0x4034320")]
		[FieldOffset(Offset = "0x90")]
		private List<ArtMagazineCoverLeafItemViewModel> m_leafItemViewModels;

		// Token: 0x04034321 RID: 213793
		[Token(Token = "0x4034321")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034322 RID: 213794
		[Token(Token = "0x4034322")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034323 RID: 213795
		[Token(Token = "0x4034323")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetEntryAnim;

		// Token: 0x04034324 RID: 213796
		[Token(Token = "0x4034324")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnsureLeafItems;

		// Token: 0x04034325 RID: 213797
		[Token(Token = "0x4034325")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderLeafs;

		// Token: 0x04034326 RID: 213798
		[Token(Token = "0x4034326")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryShowLeafsEnterAnim;

		// Token: 0x04034327 RID: 213799
		[Token(Token = "0x4034327")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04034328 RID: 213800
		[Token(Token = "0x4034328")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04034329 RID: 213801
		[Token(Token = "0x4034329")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
