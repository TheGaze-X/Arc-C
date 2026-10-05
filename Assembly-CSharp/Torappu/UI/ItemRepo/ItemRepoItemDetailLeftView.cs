using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E8F RID: 24207
	[Token(Token = "0x2005E8F")]
	public class ItemRepoItemDetailLeftView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023133 RID: 143667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023133")]
		[Address(RVA = "0x1D992C0", Offset = "0x1D97EC0", VA = "0x181D992C0")]
		public void Render(UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x06023134 RID: 143668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023134")]
		[Address(RVA = "0x1D99760", Offset = "0x1D98360", VA = "0x181D99760")]
		private void Update()
		{
		}

		// Token: 0x06023135 RID: 143669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023135")]
		[Address(RVA = "0x1D99960", Offset = "0x1D98560", VA = "0x181D99960")]
		public ItemRepoItemDetailLeftView()
		{
		}

		// Token: 0x040304E7 RID: 197863
		[Token(Token = "0x40304E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _title;

		// Token: 0x040304E8 RID: 197864
		[Token(Token = "0x40304E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x040304E9 RID: 197865
		[Token(Token = "0x40304E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x040304EA RID: 197866
		[Token(Token = "0x40304EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _itemCountFrame;

		// Token: 0x040304EB RID: 197867
		[Token(Token = "0x40304EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _onTimePart;

		// Token: 0x040304EC RID: 197868
		[Token(Token = "0x40304EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _onTimeText;

		// Token: 0x040304ED RID: 197869
		[Token(Token = "0x40304ED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _timePartBGMinWidth;

		// Token: 0x040304EE RID: 197870
		[Token(Token = "0x40304EE")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _timePartBGPaddingWidth;

		// Token: 0x040304EF RID: 197871
		[Token(Token = "0x40304EF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _timePartBGRectTrans;

		// Token: 0x040304F0 RID: 197872
		[Token(Token = "0x40304F0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _timePartSuffixRectTrans;

		// Token: 0x040304F1 RID: 197873
		[Token(Token = "0x40304F1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _timePartTimeContentRectTrans;

		// Token: 0x040304F2 RID: 197874
		[Token(Token = "0x40304F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040304F3 RID: 197875
		[Token(Token = "0x40304F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040304F4 RID: 197876
		[Token(Token = "0x40304F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
