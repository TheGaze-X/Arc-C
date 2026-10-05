using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056F0 RID: 22256
	[Token(Token = "0x20056F0")]
	public class RL04NodeUpgradeConfig : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020A4C RID: 133708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A4C")]
		[Address(RVA = "0x1AC81E0", Offset = "0x1AC6DE0", VA = "0x181AC81E0")]
		public Sprite GetImgTitle()
		{
			return null;
		}

		// Token: 0x06020A4D RID: 133709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A4D")]
		[Address(RVA = "0x1AC7E60", Offset = "0x1AC6A60", VA = "0x181AC7E60")]
		public Sprite GetBgThemeColor()
		{
			return null;
		}

		// Token: 0x06020A4E RID: 133710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A4E")]
		[Address(RVA = "0x1AC7E00", Offset = "0x1AC6A00", VA = "0x181AC7E00")]
		public Sprite GetBgMural()
		{
			return null;
		}

		// Token: 0x06020A4F RID: 133711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A4F")]
		[Address(RVA = "0x1AC8240", Offset = "0x1AC6E40", VA = "0x181AC8240")]
		public Sprite GetMuralByLevel(int level)
		{
			return null;
		}

		// Token: 0x06020A50 RID: 133712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A50")]
		[Address(RVA = "0x1AC8180", Offset = "0x1AC6D80", VA = "0x181AC8180")]
		public Sprite GetIconCenterEye()
		{
			return null;
		}

		// Token: 0x06020A51 RID: 133713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A51")]
		[Address(RVA = "0x1AC7D40", Offset = "0x1AC6940", VA = "0x181AC7D40")]
		public Sprite GetBgBtnConfirmCommon()
		{
			return null;
		}

		// Token: 0x06020A52 RID: 133714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A52")]
		[Address(RVA = "0x1AC7DA0", Offset = "0x1AC69A0", VA = "0x181AC7DA0")]
		public Sprite GetBgBtnConfirmPlus()
		{
			return null;
		}

		// Token: 0x06020A53 RID: 133715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A53")]
		[Address(RVA = "0x1AC7EC0", Offset = "0x1AC6AC0", VA = "0x181AC7EC0")]
		public Sprite GetBtnTypeSelect()
		{
			return null;
		}

		// Token: 0x06020A54 RID: 133716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A54")]
		[Address(RVA = "0x1AC7F20", Offset = "0x1AC6B20", VA = "0x181AC7F20")]
		public Sprite GetBtnTypeUnselect()
		{
			return null;
		}

		// Token: 0x06020A55 RID: 133717 RVA: 0x000B6A78 File Offset: 0x000B4C78
		[Token(Token = "0x6020A55")]
		[Address(RVA = "0x1AC8100", Offset = "0x1AC6D00", VA = "0x181AC8100")]
		public Color GetColorTheme()
		{
			return default(Color);
		}

		// Token: 0x06020A56 RID: 133718 RVA: 0x000B6A90 File Offset: 0x000B4C90
		[Token(Token = "0x6020A56")]
		[Address(RVA = "0x1AC7F80", Offset = "0x1AC6B80", VA = "0x181AC7F80")]
		public Color GetColorCaption1()
		{
			return default(Color);
		}

		// Token: 0x06020A57 RID: 133719 RVA: 0x000B6AA8 File Offset: 0x000B4CA8
		[Token(Token = "0x6020A57")]
		[Address(RVA = "0x1AC8000", Offset = "0x1AC6C00", VA = "0x181AC8000")]
		public Color GetColorCaption2()
		{
			return default(Color);
		}

		// Token: 0x06020A58 RID: 133720 RVA: 0x000B6AC0 File Offset: 0x000B4CC0
		[Token(Token = "0x6020A58")]
		[Address(RVA = "0x1AC8080", Offset = "0x1AC6C80", VA = "0x181AC8080")]
		public Color GetColorLineLock()
		{
			return default(Color);
		}

		// Token: 0x06020A59 RID: 133721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A59")]
		[Address(RVA = "0x1AC82D0", Offset = "0x1AC6ED0", VA = "0x181AC82D0")]
		public RL04NodeUpgradeConfig()
		{
		}

		// Token: 0x0402C470 RID: 181360
		[Token(Token = "0x402C470")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _imgTitle;

		// Token: 0x0402C471 RID: 181361
		[Token(Token = "0x402C471")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _imgThemeColor;

		// Token: 0x0402C472 RID: 181362
		[Token(Token = "0x402C472")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _imgMuralBg;

		// Token: 0x0402C473 RID: 181363
		[Token(Token = "0x402C473")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite[] _imgMuralList;

		// Token: 0x0402C474 RID: 181364
		[Token(Token = "0x402C474")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _iconCenterEye;

		// Token: 0x0402C475 RID: 181365
		[Token(Token = "0x402C475")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _bgBtnConfirmCommon;

		// Token: 0x0402C476 RID: 181366
		[Token(Token = "0x402C476")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite _bgBtnConfirmPlus;

		// Token: 0x0402C477 RID: 181367
		[Token(Token = "0x402C477")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Sprite _btnTypeSelect;

		// Token: 0x0402C478 RID: 181368
		[Token(Token = "0x402C478")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Sprite _btnTypeUnselect;

		// Token: 0x0402C479 RID: 181369
		[Token(Token = "0x402C479")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorTheme;

		// Token: 0x0402C47A RID: 181370
		[Token(Token = "0x402C47A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorCaption1;

		// Token: 0x0402C47B RID: 181371
		[Token(Token = "0x402C47B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _colorCaption2;

		// Token: 0x0402C47C RID: 181372
		[Token(Token = "0x402C47C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _colorLineLock;

		// Token: 0x0402C47D RID: 181373
		[Token(Token = "0x402C47D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetImgTitle;

		// Token: 0x0402C47E RID: 181374
		[Token(Token = "0x402C47E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBgThemeColor;

		// Token: 0x0402C47F RID: 181375
		[Token(Token = "0x402C47F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBgMural;

		// Token: 0x0402C480 RID: 181376
		[Token(Token = "0x402C480")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetMuralByLevel;

		// Token: 0x0402C481 RID: 181377
		[Token(Token = "0x402C481")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetIconCenterEye;

		// Token: 0x0402C482 RID: 181378
		[Token(Token = "0x402C482")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetBgBtnConfirmCommon;

		// Token: 0x0402C483 RID: 181379
		[Token(Token = "0x402C483")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetBgBtnConfirmPlus;

		// Token: 0x0402C484 RID: 181380
		[Token(Token = "0x402C484")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetBtnTypeSelect;

		// Token: 0x0402C485 RID: 181381
		[Token(Token = "0x402C485")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetBtnTypeUnselect;

		// Token: 0x0402C486 RID: 181382
		[Token(Token = "0x402C486")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetColorTheme;

		// Token: 0x0402C487 RID: 181383
		[Token(Token = "0x402C487")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetColorCaption1;

		// Token: 0x0402C488 RID: 181384
		[Token(Token = "0x402C488")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetColorCaption2;

		// Token: 0x0402C489 RID: 181385
		[Token(Token = "0x402C489")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetColorLineLock;

		// Token: 0x0402C48A RID: 181386
		[Token(Token = "0x402C48A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
