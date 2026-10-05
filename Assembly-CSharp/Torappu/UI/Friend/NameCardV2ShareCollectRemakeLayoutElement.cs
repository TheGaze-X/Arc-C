using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DCE RID: 19918
	[Token(Token = "0x2004DCE")]
	public class NameCardV2ShareCollectRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DC77 RID: 121975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC77")]
		[Address(RVA = "0x1762E10", Offset = "0x1761A10", VA = "0x181762E10", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DC78 RID: 121976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC78")]
		[Address(RVA = "0x1763370", Offset = "0x1761F70", VA = "0x181763370")]
		public NameCardV2ShareCollectRemakeLayoutElement()
		{
		}

		// Token: 0x040276A0 RID: 161440
		[Token(Token = "0x40276A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hiredTimePart;

		// Token: 0x040276A1 RID: 161441
		[Token(Token = "0x40276A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _birthTimePart;

		// Token: 0x040276A2 RID: 161442
		[Token(Token = "0x40276A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _hiredTime;

		// Token: 0x040276A3 RID: 161443
		[Token(Token = "0x40276A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _birthTime;

		// Token: 0x040276A4 RID: 161444
		[Token(Token = "0x40276A4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _assistThemeConstText;

		// Token: 0x040276A5 RID: 161445
		[Token(Token = "0x40276A5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _assistThemeName;

		// Token: 0x040276A6 RID: 161446
		[Token(Token = "0x40276A6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _assistThemeEnName;

		// Token: 0x040276A7 RID: 161447
		[Token(Token = "0x40276A7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _skinCount;

		// Token: 0x040276A8 RID: 161448
		[Token(Token = "0x40276A8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _characterCount;

		// Token: 0x040276A9 RID: 161449
		[Token(Token = "0x40276A9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _themeColoredText1;

		// Token: 0x040276AA RID: 161450
		[Token(Token = "0x40276AA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _themeColoredText2;

		// Token: 0x040276AB RID: 161451
		[Token(Token = "0x40276AB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _teamIconContent;

		// Token: 0x040276AC RID: 161452
		[Token(Token = "0x40276AC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _operatorCollectPercent;

		// Token: 0x040276AD RID: 161453
		[Token(Token = "0x40276AD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _themeColor1;

		// Token: 0x040276AE RID: 161454
		[Token(Token = "0x40276AE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _themeColor2;

		// Token: 0x040276AF RID: 161455
		[Token(Token = "0x40276AF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _themeColor3;

		// Token: 0x040276B0 RID: 161456
		[Token(Token = "0x40276B0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _operatorCollectUnselect;

		// Token: 0x040276B1 RID: 161457
		[Token(Token = "0x40276B1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _operatorCollectSelect;

		// Token: 0x040276B2 RID: 161458
		[Token(Token = "0x40276B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x040276B3 RID: 161459
		[Token(Token = "0x40276B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
