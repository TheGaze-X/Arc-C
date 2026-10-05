using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004839 RID: 18489
	[Token(Token = "0x2004839")]
	public class MonopolySettleResourceItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BEEC RID: 114412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEEC")]
		[Address(RVA = "0x155C520", Offset = "0x155B120", VA = "0x18155C520")]
		public void Render(string resourceId, int resourceCnt, bool isLast)
		{
		}

		// Token: 0x0601BEED RID: 114413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEED")]
		[Address(RVA = "0x155C720", Offset = "0x155B320", VA = "0x18155C720")]
		public MonopolySettleResourceItemView()
		{
		}

		// Token: 0x040246BA RID: 149178
		[Token(Token = "0x40246BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _resourceIcon;

		// Token: 0x040246BB RID: 149179
		[Token(Token = "0x40246BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _resourceCount;

		// Token: 0x040246BC RID: 149180
		[Token(Token = "0x40246BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lineObj;

		// Token: 0x040246BD RID: 149181
		[Token(Token = "0x40246BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Font _kjeragDigitFont;

		// Token: 0x040246BE RID: 149182
		[Token(Token = "0x40246BE")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder _stateFinder;

		// Token: 0x040246BF RID: 149183
		[Token(Token = "0x40246BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040246C0 RID: 149184
		[Token(Token = "0x40246C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
