using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AD7 RID: 15063
	[Token(Token = "0x2003AD7")]
	public class UIMedalNotifyView : UINotifyView<MedalNotifyViewParam>
	{
		// Token: 0x06017C04 RID: 97284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C04")]
		[Address(RVA = "0x100FAC0", Offset = "0x100E6C0", VA = "0x18100FAC0", Slot = "9")]
		protected override void Render(MedalNotifyViewParam medalParam)
		{
		}

		// Token: 0x06017C05 RID: 97285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C05")]
		[Address(RVA = "0x100FD10", Offset = "0x100E910", VA = "0x18100FD10")]
		private void _DisplayOneMedal(MedalPerData medalData)
		{
		}

		// Token: 0x06017C06 RID: 97286 RVA: 0x00097EA8 File Offset: 0x000960A8
		[Token(Token = "0x6017C06")]
		[Address(RVA = "0x100FF60", Offset = "0x100EB60", VA = "0x18100FF60")]
		private static int _GetMedalSizeLevel(MedalRarity rarity)
		{
			return 0;
		}

		// Token: 0x06017C07 RID: 97287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C07")]
		[Address(RVA = "0x100FFD0", Offset = "0x100EBD0", VA = "0x18100FFD0")]
		public UIMedalNotifyView()
		{
		}

		// Token: 0x0401CADE RID: 117470
		[Token(Token = "0x401CADE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDetail;

		// Token: 0x0401CADF RID: 117471
		[Token(Token = "0x401CADF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0401CAE0 RID: 117472
		[Token(Token = "0x401CAE0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x0401CAE1 RID: 117473
		[Token(Token = "0x401CAE1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0401CAE2 RID: 117474
		[Token(Token = "0x401CAE2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<UIMedalNotifyView.SizeConfig> _sizeConfigs;

		// Token: 0x0401CAE3 RID: 117475
		[Token(Token = "0x401CAE3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401CAE4 RID: 117476
		[Token(Token = "0x401CAE4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DisplayOneMedal;

		// Token: 0x0401CAE5 RID: 117477
		[Token(Token = "0x401CAE5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetMedalSizeLevel;

		// Token: 0x0401CAE6 RID: 117478
		[Token(Token = "0x401CAE6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003AD8 RID: 15064
		[Token(Token = "0x2003AD8")]
		[Serializable]
		private struct SizeConfig
		{
			// Token: 0x0401CAE7 RID: 117479
			[Token(Token = "0x401CAE7")]
			[FieldOffset(Offset = "0x0")]
			public int sizeLevel;

			// Token: 0x0401CAE8 RID: 117480
			[Token(Token = "0x401CAE8")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 imgSize;

			// Token: 0x0401CAE9 RID: 117481
			[Token(Token = "0x401CAE9")]
			[FieldOffset(Offset = "0x10")]
			public Sprite bkg;
		}
	}
}
