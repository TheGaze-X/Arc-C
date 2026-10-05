using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004911 RID: 18705
	[Token(Token = "0x2004911")]
	public class StoryReviewLockedInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C346 RID: 115526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C346")]
		[Address(RVA = "0x15B3DF0", Offset = "0x15B29F0", VA = "0x1815B3DF0")]
		public void ApplyUnlockCount(int count)
		{
		}

		// Token: 0x0601C347 RID: 115527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C347")]
		[Address(RVA = "0x15B3F30", Offset = "0x15B2B30", VA = "0x1815B3F30")]
		public UIItemCard EnsureItemCard(UIItemViewModel cacheItemViewModel)
		{
			return null;
		}

		// Token: 0x0601C348 RID: 115528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C348")]
		[Address(RVA = "0x15B41D0", Offset = "0x15B2DD0", VA = "0x1815B41D0")]
		public StoryReviewLockedInfoView()
		{
		}

		// Token: 0x04024E02 RID: 151042
		[Token(Token = "0x4024E02")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _unlockCoinCount;

		// Token: 0x04024E03 RID: 151043
		[Token(Token = "0x4024E03")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04024E04 RID: 151044
		[Token(Token = "0x4024E04")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04024E05 RID: 151045
		[Token(Token = "0x4024E05")]
		[FieldOffset(Offset = "0x30")]
		private UIItemCard m_itemCard;

		// Token: 0x04024E06 RID: 151046
		[Token(Token = "0x4024E06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyUnlockCount;

		// Token: 0x04024E07 RID: 151047
		[Token(Token = "0x4024E07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EnsureItemCard;

		// Token: 0x04024E08 RID: 151048
		[Token(Token = "0x4024E08")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
