using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F6F RID: 8047
	[Token(Token = "0x2001F6F")]
	public abstract class AVGShowItemSlot : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C7EB RID: 51179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7EB")]
		[Address(RVA = "0x3491160", Offset = "0x348FD60", VA = "0x183491160")]
		public void Clear()
		{
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x0600C7EC RID: 51180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017A7")]
		public Image currentImage
		{
			[Token(Token = "0x600C7EC")]
			[Address(RVA = "0x34914E0", Offset = "0x34900E0", VA = "0x1834914E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C7ED RID: 51181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7ED")]
		[Address(RVA = "0x3491360", Offset = "0x348FF60", VA = "0x183491360", Slot = "4")]
		public virtual void Show(Command command, Sprite sprite, Action onShowEnd)
		{
		}

		// Token: 0x0600C7EE RID: 51182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7EE")]
		[Address(RVA = "0x34911E0", Offset = "0x348FDE0", VA = "0x1834911E0", Slot = "5")]
		public virtual void Hide(Command command, Action onShowEnd)
		{
		}

		// Token: 0x0600C7EF RID: 51183
		[Token(Token = "0x600C7EF")]
		protected abstract void _InitSlot();

		// Token: 0x0600C7F0 RID: 51184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7F0")]
		[Address(RVA = "0x3491270", Offset = "0x348FE70", VA = "0x183491270")]
		protected void OnAnimEnd()
		{
		}

		// Token: 0x0600C7F1 RID: 51185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7F1")]
		[Address(RVA = "0x34912F0", Offset = "0x348FEF0", VA = "0x1834912F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C7F2 RID: 51186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7F2")]
		[Address(RVA = "0x3491040", Offset = "0x348FC40", VA = "0x183491040")]
		private void Awake()
		{
		}

		// Token: 0x0600C7F3 RID: 51187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7F3")]
		[Address(RVA = "0x3491470", Offset = "0x3490070", VA = "0x183491470")]
		protected AVGShowItemSlot()
		{
		}

		// Token: 0x0400CE30 RID: 52784
		[Token(Token = "0x400CE30")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Image _image;

		// Token: 0x0400CE31 RID: 52785
		[Token(Token = "0x400CE31")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Image _black;

		// Token: 0x0400CE32 RID: 52786
		[Token(Token = "0x400CE32")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected float _defaultBlackAlpha;

		// Token: 0x0400CE33 RID: 52787
		[Token(Token = "0x400CE33")]
		[FieldOffset(Offset = "0x30")]
		protected CanvasGroup _canvasGroup;

		// Token: 0x0400CE34 RID: 52788
		[Token(Token = "0x400CE34")]
		[FieldOffset(Offset = "0x38")]
		protected Action _onAnimEnd;

		// Token: 0x0400CE35 RID: 52789
		[Token(Token = "0x400CE35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0400CE36 RID: 52790
		[Token(Token = "0x400CE36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentImage;

		// Token: 0x0400CE37 RID: 52791
		[Token(Token = "0x400CE37")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0400CE38 RID: 52792
		[Token(Token = "0x400CE38")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0400CE39 RID: 52793
		[Token(Token = "0x400CE39")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAnimEnd;

		// Token: 0x0400CE3A RID: 52794
		[Token(Token = "0x400CE3A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400CE3B RID: 52795
		[Token(Token = "0x400CE3B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400CE3C RID: 52796
		[Token(Token = "0x400CE3C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
