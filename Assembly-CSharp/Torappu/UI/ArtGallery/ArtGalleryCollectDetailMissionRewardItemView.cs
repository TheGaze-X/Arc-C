using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065DF RID: 26079
	[Token(Token = "0x20065DF")]
	public class ArtGalleryCollectDetailMissionRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060257CA RID: 153546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257CA")]
		[Address(RVA = "0x20725C0", Offset = "0x20711C0", VA = "0x1820725C0")]
		public void Render(ItemBundle itemBundle, ArtGalleryCollectDetailMissionItemViewModel.ClaimState missionClaimState)
		{
		}

		// Token: 0x060257CB RID: 153547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257CB")]
		[Address(RVA = "0x20727F0", Offset = "0x20713F0", VA = "0x1820727F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060257CC RID: 153548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257CC")]
		[Address(RVA = "0x2072960", Offset = "0x2071560", VA = "0x182072960")]
		private void _RenderItemCard(ItemBundle itemBundle)
		{
		}

		// Token: 0x060257CD RID: 153549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257CD")]
		[Address(RVA = "0x20724E0", Offset = "0x20710E0", VA = "0x1820724E0")]
		public void EventOnMagazineLeafPreviewClick()
		{
		}

		// Token: 0x060257CE RID: 153550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257CE")]
		[Address(RVA = "0x2072BC0", Offset = "0x20717C0", VA = "0x182072BC0")]
		public ArtGalleryCollectDetailMissionRewardItemView()
		{
		}

		// Token: 0x040349E6 RID: 215526
		[Token(Token = "0x40349E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objPreviewBtn;

		// Token: 0x040349E7 RID: 215527
		[Token(Token = "0x40349E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x040349E8 RID: 215528
		[Token(Token = "0x40349E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemScaleFactor;

		// Token: 0x040349E9 RID: 215529
		[Token(Token = "0x40349E9")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_isInited;

		// Token: 0x040349EA RID: 215530
		[Token(Token = "0x40349EA")]
		[FieldOffset(Offset = "0x2D")]
		private bool m_hasMagazineLeafPreview;

		// Token: 0x040349EB RID: 215531
		[Token(Token = "0x40349EB")]
		[FieldOffset(Offset = "0x30")]
		private string m_itemId;

		// Token: 0x040349EC RID: 215532
		[Token(Token = "0x40349EC")]
		[FieldOffset(Offset = "0x38")]
		private UIItemCard m_itemCard;

		// Token: 0x040349ED RID: 215533
		[Token(Token = "0x40349ED")]
		[FieldOffset(Offset = "0x40")]
		private UIScaler m_scaler;

		// Token: 0x040349EE RID: 215534
		[Token(Token = "0x40349EE")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040349EF RID: 215535
		[Token(Token = "0x40349EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040349F0 RID: 215536
		[Token(Token = "0x40349F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040349F1 RID: 215537
		[Token(Token = "0x40349F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderItemCard;

		// Token: 0x040349F2 RID: 215538
		[Token(Token = "0x40349F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnMagazineLeafPreviewClick;

		// Token: 0x040349F3 RID: 215539
		[Token(Token = "0x40349F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
