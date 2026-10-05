using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055A8 RID: 21928
	[Token(Token = "0x20055A8")]
	public class RL05CopperPackageItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020337 RID: 131895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020337")]
		[Address(RVA = "0x1A4C5B0", Offset = "0x1A4B1B0", VA = "0x181A4C5B0")]
		public void RenderShow(ILoadAsset assetLoader, RoguelikePlayerCopperItemViewModel model, string selectInstId)
		{
		}

		// Token: 0x06020338 RID: 131896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020338")]
		[Address(RVA = "0x1A4C3F0", Offset = "0x1A4AFF0", VA = "0x181A4C3F0")]
		public void ClearHide()
		{
		}

		// Token: 0x06020339 RID: 131897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020339")]
		[Address(RVA = "0x1A4C510", Offset = "0x1A4B110", VA = "0x181A4C510")]
		public void PlaySelectAnim(string selectInstId)
		{
		}

		// Token: 0x0602033A RID: 131898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602033A")]
		[Address(RVA = "0x1A4CB90", Offset = "0x1A4B790", VA = "0x181A4CB90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602033B RID: 131899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602033B")]
		[Address(RVA = "0x1A4CDF0", Offset = "0x1A4B9F0", VA = "0x181A4CDF0")]
		private void _SetSprite(IList<Image> images, Sprite sprite)
		{
		}

		// Token: 0x0602033C RID: 131900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602033C")]
		[Address(RVA = "0x1A4CC70", Offset = "0x1A4B870", VA = "0x181A4CC70")]
		private void _SetImgActive(IList<Image> images, bool active)
		{
		}

		// Token: 0x0602033D RID: 131901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602033D")]
		[Address(RVA = "0x1A4C480", Offset = "0x1A4B080", VA = "0x181A4C480")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602033E RID: 131902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602033E")]
		[Address(RVA = "0x1A4CFB0", Offset = "0x1A4BBB0", VA = "0x181A4CFB0")]
		public RL05CopperPackageItemView()
		{
		}

		// Token: 0x0402B8A7 RID: 178343
		[Token(Token = "0x402B8A7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image[] _iconImgs;

		// Token: 0x0402B8A8 RID: 178344
		[Token(Token = "0x402B8A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image[] _buffImgs;

		// Token: 0x0402B8A9 RID: 178345
		[Token(Token = "0x402B8A9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0402B8AA RID: 178346
		[Token(Token = "0x402B8AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _undrawnNameText;

		// Token: 0x0402B8AB RID: 178347
		[Token(Token = "0x402B8AB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _typeIcon;

		// Token: 0x0402B8AC RID: 178348
		[Token(Token = "0x402B8AC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _drawnToggle;

		// Token: 0x0402B8AD RID: 178349
		[Token(Token = "0x402B8AD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _textDrawnToggle;

		// Token: 0x0402B8AE RID: 178350
		[Token(Token = "0x402B8AE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _selSwtichAnim;

		// Token: 0x0402B8AF RID: 178351
		[Token(Token = "0x402B8AF")]
		[FieldOffset(Offset = "0x60")]
		private AnimationSwitchTween m_selSwitch;

		// Token: 0x0402B8B0 RID: 178352
		[Token(Token = "0x402B8B0")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedCopperInstId;

		// Token: 0x0402B8B1 RID: 178353
		[Token(Token = "0x402B8B1")]
		[FieldOffset(Offset = "0x70")]
		public Action<string> onClick;

		// Token: 0x0402B8B2 RID: 178354
		[Token(Token = "0x402B8B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderShow;

		// Token: 0x0402B8B3 RID: 178355
		[Token(Token = "0x402B8B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ClearHide;

		// Token: 0x0402B8B4 RID: 178356
		[Token(Token = "0x402B8B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlaySelectAnim;

		// Token: 0x0402B8B5 RID: 178357
		[Token(Token = "0x402B8B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B8B6 RID: 178358
		[Token(Token = "0x402B8B6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetSprite;

		// Token: 0x0402B8B7 RID: 178359
		[Token(Token = "0x402B8B7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetImgActive;

		// Token: 0x0402B8B8 RID: 178360
		[Token(Token = "0x402B8B8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0402B8B9 RID: 178361
		[Token(Token = "0x402B8B9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
