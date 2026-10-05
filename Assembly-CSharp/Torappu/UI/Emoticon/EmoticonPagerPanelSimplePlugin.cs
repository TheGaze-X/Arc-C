using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050E0 RID: 20704
	[Token(Token = "0x20050E0")]
	public class EmoticonPagerPanelSimplePlugin : EmoticonPagerPanelPlugin
	{
		// Token: 0x0601E9C5 RID: 125381 RVA: 0x000AF110 File Offset: 0x000AD310
		[Token(Token = "0x601E9C5")]
		[Address(RVA = "0x183A9B0", Offset = "0x18395B0", VA = "0x18183A9B0", Slot = "4")]
		public override float AdjustPagerRectHeight(EmoticonPagerPanelModel model)
		{
			return 0f;
		}

		// Token: 0x0601E9C6 RID: 125382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9C6")]
		[Address(RVA = "0x183AC40", Offset = "0x1839840", VA = "0x18183AC40")]
		public EmoticonPagerPanelSimplePlugin()
		{
		}

		// Token: 0x04029051 RID: 168017
		[Token(Token = "0x4029051")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HorizontalLayoutGroup _themeGroupLayoutGroup;

		// Token: 0x04029052 RID: 168018
		[Token(Token = "0x4029052")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GridLayoutGroup _themeEmojiGridLayoutGroup;

		// Token: 0x04029053 RID: 168019
		[Token(Token = "0x4029053")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _pagerPlusPadding;

		// Token: 0x04029054 RID: 168020
		[Token(Token = "0x4029054")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AdjustPagerRectHeight;

		// Token: 0x04029055 RID: 168021
		[Token(Token = "0x4029055")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
