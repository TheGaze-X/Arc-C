using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F2F RID: 16175
	[Token(Token = "0x2003F2F")]
	public class SiracusaMapAreaUnlockDialog : UICustomDialog<SiracusaMapAreaUnlockDialog.Options>
	{
		// Token: 0x06019206 RID: 102918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019206")]
		[Address(RVA = "0x11D0880", Offset = "0x11CF480", VA = "0x1811D0880", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x06019207 RID: 102919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019207")]
		[Address(RVA = "0x11D09A0", Offset = "0x11CF5A0", VA = "0x1811D09A0", Slot = "7")]
		protected override void OnRender(SiracusaMapAreaUnlockDialog.Options options)
		{
		}

		// Token: 0x06019208 RID: 102920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019208")]
		[Address(RVA = "0x11D0CE0", Offset = "0x11CF8E0", VA = "0x1811D0CE0")]
		private Sprite _GetAreaIconSprite(string spriteId)
		{
			return null;
		}

		// Token: 0x06019209 RID: 102921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019209")]
		[Address(RVA = "0x11D0820", Offset = "0x11CF420", VA = "0x1811D0820", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601920A RID: 102922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601920A")]
		[Address(RVA = "0x11D07B0", Offset = "0x11CF3B0", VA = "0x1811D07B0")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x0601920B RID: 102923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601920B")]
		[Address(RVA = "0x11D0E80", Offset = "0x11CFA80", VA = "0x1811D0E80")]
		public SiracusaMapAreaUnlockDialog()
		{
		}

		// Token: 0x0401F1C5 RID: 127429
		[Token(Token = "0x401F1C5")]
		private const string ANIM_ENTER = "siracusa_map_area_unlock";

		// Token: 0x0401F1C6 RID: 127430
		[Token(Token = "0x401F1C6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgAreaIcon;

		// Token: 0x0401F1C7 RID: 127431
		[Token(Token = "0x401F1C7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtAreaName;

		// Token: 0x0401F1C8 RID: 127432
		[Token(Token = "0x401F1C8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtAreaItalyName;

		// Token: 0x0401F1C9 RID: 127433
		[Token(Token = "0x401F1C9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0401F1CA RID: 127434
		[Token(Token = "0x401F1CA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0401F1CB RID: 127435
		[Token(Token = "0x401F1CB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0401F1CC RID: 127436
		[Token(Token = "0x401F1CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401F1CD RID: 127437
		[Token(Token = "0x401F1CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401F1CE RID: 127438
		[Token(Token = "0x401F1CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetAreaIconSprite;

		// Token: 0x0401F1CF RID: 127439
		[Token(Token = "0x401F1CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401F1D0 RID: 127440
		[Token(Token = "0x401F1D0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0401F1D1 RID: 127441
		[Token(Token = "0x401F1D1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F30 RID: 16176
		[Token(Token = "0x2003F30")]
		public struct Options
		{
			// Token: 0x0401F1D2 RID: 127442
			[Token(Token = "0x401F1D2")]
			[FieldOffset(Offset = "0x0")]
			public string areaId;
		}
	}
}
