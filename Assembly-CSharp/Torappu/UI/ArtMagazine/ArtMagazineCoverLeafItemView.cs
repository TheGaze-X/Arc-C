using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006521 RID: 25889
	[Token(Token = "0x2006521")]
	public class ArtMagazineCoverLeafItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170057CF RID: 22479
		// (get) Token: 0x06025357 RID: 152407 RVA: 0x000C7038 File Offset: 0x000C5238
		[Token(Token = "0x170057CF")]
		public UIAnimationLocation animEntry
		{
			[Token(Token = "0x6025357")]
			[Address(RVA = "0x202DEE0", Offset = "0x202CAE0", VA = "0x18202DEE0")]
			get
			{
				return default(UIAnimationLocation);
			}
		}

		// Token: 0x170057D0 RID: 22480
		// (get) Token: 0x06025358 RID: 152408 RVA: 0x000C7050 File Offset: 0x000C5250
		[Token(Token = "0x170057D0")]
		public UIAnimationLocation animShow
		{
			[Token(Token = "0x6025358")]
			[Address(RVA = "0x202DF60", Offset = "0x202CB60", VA = "0x18202DF60")]
			get
			{
				return default(UIAnimationLocation);
			}
		}

		// Token: 0x170057D1 RID: 22481
		// (get) Token: 0x06025359 RID: 152409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170057D1")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x6025359")]
			[Address(RVA = "0x202DFE0", Offset = "0x202CBE0", VA = "0x18202DFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602535A RID: 152410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602535A")]
		[Address(RVA = "0x202DD70", Offset = "0x202C970", VA = "0x18202DD70")]
		public void Render(ArtMagazineCoverLeafItemViewModel itemViewModel)
		{
		}

		// Token: 0x0602535B RID: 152411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602535B")]
		[Address(RVA = "0x202DE80", Offset = "0x202CA80", VA = "0x18202DE80")]
		public ArtMagazineCoverLeafItemView()
		{
		}

		// Token: 0x04034301 RID: 213761
		[Token(Token = "0x4034301")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objEmptyPart;

		// Token: 0x04034302 RID: 213762
		[Token(Token = "0x4034302")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objCoverPart;

		// Token: 0x04034303 RID: 213763
		[Token(Token = "0x4034303")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtMagazineLeafViewHolder _leafViewHolder;

		// Token: 0x04034304 RID: 213764
		[Token(Token = "0x4034304")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x04034305 RID: 213765
		[Token(Token = "0x4034305")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _animEntry;

		// Token: 0x04034306 RID: 213766
		[Token(Token = "0x4034306")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x04034307 RID: 213767
		[Token(Token = "0x4034307")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animEntry;

		// Token: 0x04034308 RID: 213768
		[Token(Token = "0x4034308")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_animShow;

		// Token: 0x04034309 RID: 213769
		[Token(Token = "0x4034309")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x0403430A RID: 213770
		[Token(Token = "0x403430A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403430B RID: 213771
		[Token(Token = "0x403430B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
