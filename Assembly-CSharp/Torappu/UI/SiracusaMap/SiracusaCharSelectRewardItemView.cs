using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F22 RID: 16162
	[Token(Token = "0x2003F22")]
	public class SiracusaCharSelectRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019185 RID: 102789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019185")]
		[Address(RVA = "0x11C96E0", Offset = "0x11C82E0", VA = "0x1811C96E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019186 RID: 102790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019186")]
		[Address(RVA = "0x11C95B0", Offset = "0x11C81B0", VA = "0x1811C95B0")]
		public void Render(SiracusaCharSelectTaskRingRewardInfo info, bool clickable, bool needShowHasGetTag)
		{
		}

		// Token: 0x06019187 RID: 102791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019187")]
		[Address(RVA = "0x11C9940", Offset = "0x11C8540", VA = "0x1811C9940")]
		private void _OnItemClicked(int index)
		{
		}

		// Token: 0x06019188 RID: 102792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019188")]
		[Address(RVA = "0x11C9A30", Offset = "0x11C8630", VA = "0x1811C9A30")]
		public SiracusaCharSelectRewardItemView()
		{
		}

		// Token: 0x0401F0E6 RID: 127206
		[Token(Token = "0x401F0E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x0401F0E7 RID: 127207
		[Token(Token = "0x401F0E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _scalePercent;

		// Token: 0x0401F0E8 RID: 127208
		[Token(Token = "0x401F0E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _alreadyGetPart;

		// Token: 0x0401F0E9 RID: 127209
		[Token(Token = "0x401F0E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x0401F0EA RID: 127210
		[Token(Token = "0x401F0EA")]
		[FieldOffset(Offset = "0x38")]
		private UIItemCard m_itemCard;

		// Token: 0x0401F0EB RID: 127211
		[Token(Token = "0x401F0EB")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0401F0EC RID: 127212
		[Token(Token = "0x401F0EC")]
		private const float GOT_ALPHA = 0.4f;

		// Token: 0x0401F0ED RID: 127213
		[Token(Token = "0x401F0ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F0EE RID: 127214
		[Token(Token = "0x401F0EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F0EF RID: 127215
		[Token(Token = "0x401F0EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0401F0F0 RID: 127216
		[Token(Token = "0x401F0F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
