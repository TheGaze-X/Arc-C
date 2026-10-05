using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065FB RID: 26107
	[Token(Token = "0x20065FB")]
	public class ArtGalleryDisplayTypeFilterItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602583D RID: 153661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602583D")]
		[Address(RVA = "0x2080D90", Offset = "0x207F990", VA = "0x182080D90")]
		public void Render(ArtGalleryCollectDisplayFilterItemViewModel filterItemViewModel, bool isFastMode)
		{
		}

		// Token: 0x0602583E RID: 153662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602583E")]
		[Address(RVA = "0x20812F0", Offset = "0x207FEF0", VA = "0x1820812F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602583F RID: 153663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602583F")]
		[Address(RVA = "0x2080C00", Offset = "0x207F800", VA = "0x182080C00")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x06025840 RID: 153664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025840")]
		[Address(RVA = "0x2081430", Offset = "0x2080030", VA = "0x182081430")]
		public ArtGalleryDisplayTypeFilterItemView()
		{
		}

		// Token: 0x04034AE0 RID: 215776
		[Token(Token = "0x4034AE0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateAnimationSwitcher _stateSwitcher;

		// Token: 0x04034AE1 RID: 215777
		[Token(Token = "0x4034AE1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgTypeSelectIcon;

		// Token: 0x04034AE2 RID: 215778
		[Token(Token = "0x4034AE2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgTypeEngName;

		// Token: 0x04034AE3 RID: 215779
		[Token(Token = "0x4034AE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtSetNameSelect;

		// Token: 0x04034AE4 RID: 215780
		[Token(Token = "0x4034AE4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgTypeUnselectIcon;

		// Token: 0x04034AE5 RID: 215781
		[Token(Token = "0x4034AE5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtSetNameUnselect;

		// Token: 0x04034AE6 RID: 215782
		[Token(Token = "0x4034AE6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objNew;

		// Token: 0x04034AE7 RID: 215783
		[Token(Token = "0x4034AE7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _trackPointHasRewardsHolder;

		// Token: 0x04034AE8 RID: 215784
		[Token(Token = "0x4034AE8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _trackPointHasRewardsPrefab;

		// Token: 0x04034AE9 RID: 215785
		[Token(Token = "0x4034AE9")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04034AEA RID: 215786
		[Token(Token = "0x4034AEA")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedSetType;

		// Token: 0x04034AEB RID: 215787
		[Token(Token = "0x4034AEB")]
		[FieldOffset(Offset = "0x70")]
		private List<string> m_cachedSetIdList;

		// Token: 0x04034AEC RID: 215788
		[Token(Token = "0x4034AEC")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034AED RID: 215789
		[Token(Token = "0x4034AED")]
		[FieldOffset(Offset = "0x88")]
		private ILoadAsset m_assetLoader;

		// Token: 0x04034AEE RID: 215790
		[Token(Token = "0x4034AEE")]
		[FieldOffset(Offset = "0x90")]
		private GameObject m_trackPointHasRewards;

		// Token: 0x04034AEF RID: 215791
		[Token(Token = "0x4034AEF")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isSelect;

		// Token: 0x04034AF0 RID: 215792
		[Token(Token = "0x4034AF0")]
		[FieldOffset(Offset = "0x99")]
		private bool m_isAll;

		// Token: 0x04034AF1 RID: 215793
		[Token(Token = "0x4034AF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034AF2 RID: 215794
		[Token(Token = "0x4034AF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034AF3 RID: 215795
		[Token(Token = "0x4034AF3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x04034AF4 RID: 215796
		[Token(Token = "0x4034AF4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
