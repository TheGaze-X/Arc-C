using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066AA RID: 26282
	[Token(Token = "0x20066AA")]
	public class HandbookUnlockParamObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025C02 RID: 154626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C02")]
		[Address(RVA = "0x20B5100", Offset = "0x20B3D00", VA = "0x1820B5100")]
		public void Render(HandBookUnlockInfo param, bool isSingle = false)
		{
		}

		// Token: 0x06025C03 RID: 154627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C03")]
		[Address(RVA = "0x20B5500", Offset = "0x20B4100", VA = "0x1820B5500")]
		public HandbookUnlockParamObject()
		{
		}

		// Token: 0x040350F4 RID: 217332
		[Token(Token = "0x40350F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x040350F5 RID: 217333
		[Token(Token = "0x40350F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _tinyIcon;

		// Token: 0x040350F6 RID: 217334
		[Token(Token = "0x40350F6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _availIcon;

		// Token: 0x040350F7 RID: 217335
		[Token(Token = "0x40350F7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _notAvailIcon;

		// Token: 0x040350F8 RID: 217336
		[Token(Token = "0x40350F8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _evolveZero;

		// Token: 0x040350F9 RID: 217337
		[Token(Token = "0x40350F9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _evolveOne;

		// Token: 0x040350FA RID: 217338
		[Token(Token = "0x40350FA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite _evolveTwo;

		// Token: 0x040350FB RID: 217339
		[Token(Token = "0x40350FB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Sprite _favorIcon;

		// Token: 0x040350FC RID: 217340
		[Token(Token = "0x40350FC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Sprite _itemIcon;

		// Token: 0x040350FD RID: 217341
		[Token(Token = "0x40350FD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Sprite _defaultIcon;

		// Token: 0x040350FE RID: 217342
		[Token(Token = "0x40350FE")]
		[FieldOffset(Offset = "0x68")]
		private Color BLUE_COLOR;

		// Token: 0x040350FF RID: 217343
		[Token(Token = "0x40350FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035100 RID: 217344
		[Token(Token = "0x4035100")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
