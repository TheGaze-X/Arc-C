using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006609 RID: 26121
	[Token(Token = "0x2006609")]
	public class ArtGalleryDisplayTabItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025866 RID: 153702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025866")]
		[Address(RVA = "0x20809F0", Offset = "0x207F5F0", VA = "0x1820809F0")]
		public void SetToggle(ArtGalleryDisplayTabItemView.Input input)
		{
		}

		// Token: 0x06025867 RID: 153703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025867")]
		[Address(RVA = "0x20808E0", Offset = "0x207F4E0", VA = "0x1820808E0")]
		public void OnTabItemClicked()
		{
		}

		// Token: 0x06025868 RID: 153704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025868")]
		[Address(RVA = "0x2080BA0", Offset = "0x207F7A0", VA = "0x182080BA0")]
		public ArtGalleryDisplayTabItemView()
		{
		}

		// Token: 0x04034B51 RID: 215889
		[Token(Token = "0x4034B51")]
		private const float SLIDER_FILL_DURATION = 0.6f;

		// Token: 0x04034B52 RID: 215890
		[Token(Token = "0x4034B52")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtGalleryTabType _type;

		// Token: 0x04034B53 RID: 215891
		[Token(Token = "0x4034B53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04034B54 RID: 215892
		[Token(Token = "0x4034B54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _count;

		// Token: 0x04034B55 RID: 215893
		[Token(Token = "0x4034B55")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _progressImg;

		// Token: 0x04034B56 RID: 215894
		[Token(Token = "0x4034B56")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034B57 RID: 215895
		[Token(Token = "0x4034B57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetToggle;

		// Token: 0x04034B58 RID: 215896
		[Token(Token = "0x4034B58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTabItemClicked;

		// Token: 0x04034B59 RID: 215897
		[Token(Token = "0x4034B59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200660A RID: 26122
		[Token(Token = "0x200660A")]
		public struct Input
		{
			// Token: 0x04034B5A RID: 215898
			[Token(Token = "0x4034B5A")]
			[FieldOffset(Offset = "0x0")]
			public ArtGalleryTabType currSelectedType;
		}
	}
}
