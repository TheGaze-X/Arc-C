using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065F3 RID: 26099
	[Token(Token = "0x20065F3")]
	public class ArtGalleryCollectSetSingleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602581F RID: 153631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602581F")]
		[Address(RVA = "0x207DA30", Offset = "0x207C630", VA = "0x18207DA30")]
		public void Render(ArtGalleryCollectSetViewModel model)
		{
		}

		// Token: 0x06025820 RID: 153632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025820")]
		[Address(RVA = "0x207D900", Offset = "0x207C500", VA = "0x18207D900")]
		public void OnSetClicked()
		{
		}

		// Token: 0x06025821 RID: 153633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025821")]
		[Address(RVA = "0x207E010", Offset = "0x207CC10", VA = "0x18207E010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025822 RID: 153634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025822")]
		[Address(RVA = "0x207E140", Offset = "0x207CD40", VA = "0x18207E140")]
		public ArtGalleryCollectSetSingleView()
		{
		}

		// Token: 0x04034AA7 RID: 215719
		[Token(Token = "0x4034AA7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _typeName;

		// Token: 0x04034AA8 RID: 215720
		[Token(Token = "0x4034AA8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _typeEngNamePic;

		// Token: 0x04034AA9 RID: 215721
		[Token(Token = "0x4034AA9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _setName;

		// Token: 0x04034AAA RID: 215722
		[Token(Token = "0x4034AAA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _progress;

		// Token: 0x04034AAB RID: 215723
		[Token(Token = "0x4034AAB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _pic;

		// Token: 0x04034AAC RID: 215724
		[Token(Token = "0x4034AAC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _expanding;

		// Token: 0x04034AAD RID: 215725
		[Token(Token = "0x4034AAD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _new;

		// Token: 0x04034AAE RID: 215726
		[Token(Token = "0x4034AAE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _trackPointHasRewardsHolder;

		// Token: 0x04034AAF RID: 215727
		[Token(Token = "0x4034AAF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _trackPointHasRewardsPrefab;

		// Token: 0x04034AB0 RID: 215728
		[Token(Token = "0x4034AB0")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedSetId;

		// Token: 0x04034AB1 RID: 215729
		[Token(Token = "0x4034AB1")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034AB2 RID: 215730
		[Token(Token = "0x4034AB2")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034AB3 RID: 215731
		[Token(Token = "0x4034AB3")]
		[FieldOffset(Offset = "0x88")]
		private ILoadAsset m_assetLoader;

		// Token: 0x04034AB4 RID: 215732
		[Token(Token = "0x4034AB4")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04034AB5 RID: 215733
		[Token(Token = "0x4034AB5")]
		[FieldOffset(Offset = "0x98")]
		private GameObject m_trackPointHasRewards;

		// Token: 0x04034AB6 RID: 215734
		[Token(Token = "0x4034AB6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034AB7 RID: 215735
		[Token(Token = "0x4034AB7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSetClicked;

		// Token: 0x04034AB8 RID: 215736
		[Token(Token = "0x4034AB8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034AB9 RID: 215737
		[Token(Token = "0x4034AB9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
