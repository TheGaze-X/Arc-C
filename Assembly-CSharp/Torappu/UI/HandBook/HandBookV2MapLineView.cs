using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006709 RID: 26377
	[Token(Token = "0x2006709")]
	public class HandBookV2MapLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025DB1 RID: 155057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DB1")]
		[Address(RVA = "0x20E1D30", Offset = "0x20E0930", VA = "0x1820E1D30")]
		public void Render(RectTransform trans1, RectTransform trans2, HandBookV2GroupPosData.LineData lineData)
		{
		}

		// Token: 0x06025DB2 RID: 155058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DB2")]
		[Address(RVA = "0x20E1CB0", Offset = "0x20E08B0", VA = "0x1820E1CB0")]
		public void OnShow()
		{
		}

		// Token: 0x06025DB3 RID: 155059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DB3")]
		[Address(RVA = "0x20E2160", Offset = "0x20E0D60", VA = "0x1820E2160")]
		public HandBookV2MapLineView()
		{
		}

		// Token: 0x040353AD RID: 218029
		[Token(Token = "0x40353AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _lineSprite;

		// Token: 0x040353AE RID: 218030
		[Token(Token = "0x40353AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _commonLine;

		// Token: 0x040353AF RID: 218031
		[Token(Token = "0x40353AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _spLine;

		// Token: 0x040353B0 RID: 218032
		[Token(Token = "0x40353B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040353B1 RID: 218033
		[Token(Token = "0x40353B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x040353B2 RID: 218034
		[Token(Token = "0x40353B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
