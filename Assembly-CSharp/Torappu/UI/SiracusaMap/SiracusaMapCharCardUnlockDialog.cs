using System;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F31 RID: 16177
	[Token(Token = "0x2003F31")]
	public class SiracusaMapCharCardUnlockDialog : UICustomDialog<SiracusaMapCharCardUnlockDialog.Options>
	{
		// Token: 0x0601920C RID: 102924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601920C")]
		[Address(RVA = "0x11D2C00", Offset = "0x11D1800", VA = "0x1811D2C00", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601920D RID: 102925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601920D")]
		[Address(RVA = "0x11D2D20", Offset = "0x11D1920", VA = "0x1811D2D20", Slot = "7")]
		protected override void OnRender(SiracusaMapCharCardUnlockDialog.Options options)
		{
		}

		// Token: 0x0601920E RID: 102926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601920E")]
		[Address(RVA = "0x11D33B0", Offset = "0x11D1FB0", VA = "0x1811D33B0")]
		private Sprite _GetItalyNameSprite(string spriteId)
		{
			return null;
		}

		// Token: 0x0601920F RID: 102927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601920F")]
		[Address(RVA = "0x11D2BA0", Offset = "0x11D17A0", VA = "0x1811D2BA0", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06019210 RID: 102928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019210")]
		[Address(RVA = "0x11D2B30", Offset = "0x11D1730", VA = "0x1811D2B30")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x06019211 RID: 102929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019211")]
		[Address(RVA = "0x11D3550", Offset = "0x11D2150", VA = "0x1811D3550")]
		public SiracusaMapCharCardUnlockDialog()
		{
		}

		// Token: 0x0401F1D3 RID: 127443
		[Token(Token = "0x401F1D3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textCharName;

		// Token: 0x0401F1D4 RID: 127444
		[Token(Token = "0x401F1D4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textCharDesc;

		// Token: 0x0401F1D5 RID: 127445
		[Token(Token = "0x401F1D5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _viewStateToggle;

		// Token: 0x0401F1D6 RID: 127446
		[Token(Token = "0x401F1D6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Graphic[] _themeGraphics;

		// Token: 0x0401F1D7 RID: 127447
		[Token(Token = "0x401F1D7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0401F1D8 RID: 127448
		[Token(Token = "0x401F1D8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0401F1D9 RID: 127449
		[Token(Token = "0x401F1D9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textCloseTip;

		// Token: 0x0401F1DA RID: 127450
		[Token(Token = "0x401F1DA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textCaption1;

		// Token: 0x0401F1DB RID: 127451
		[Token(Token = "0x401F1DB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textCaption2;

		// Token: 0x0401F1DC RID: 127452
		[Token(Token = "0x401F1DC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAVGCharacter _avgChar;

		// Token: 0x0401F1DD RID: 127453
		[Token(Token = "0x401F1DD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _imgItalyName;

		// Token: 0x0401F1DE RID: 127454
		[Token(Token = "0x401F1DE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0401F1DF RID: 127455
		[Token(Token = "0x401F1DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401F1E0 RID: 127456
		[Token(Token = "0x401F1E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401F1E1 RID: 127457
		[Token(Token = "0x401F1E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetItalyNameSprite;

		// Token: 0x0401F1E2 RID: 127458
		[Token(Token = "0x401F1E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401F1E3 RID: 127459
		[Token(Token = "0x401F1E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0401F1E4 RID: 127460
		[Token(Token = "0x401F1E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F32 RID: 16178
		[Token(Token = "0x2003F32")]
		public struct Options
		{
			// Token: 0x0401F1E5 RID: 127461
			[Token(Token = "0x401F1E5")]
			[FieldOffset(Offset = "0x0")]
			public string charCardId;

			// Token: 0x0401F1E6 RID: 127462
			[Token(Token = "0x401F1E6")]
			[FieldOffset(Offset = "0x8")]
			public bool isUnlock;
		}
	}
}
