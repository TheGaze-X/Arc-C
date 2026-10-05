using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C6B RID: 19563
	[Token(Token = "0x2004C6B")]
	public abstract class HomeThemeUIElem<DT> : HomeThemeElemBase<DT> where DT : HomeThemeUIElemData, new()
	{
		// Token: 0x0601D57E RID: 120190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D57E")]
		protected sealed override void OnApply(DT data, HomeTheme theme)
		{
		}

		// Token: 0x0601D57F RID: 120191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D57F")]
		protected sealed override void OnFillData(DT data, AssetPathConvertor pathConvertor)
		{
		}

		// Token: 0x0601D580 RID: 120192
		[Token(Token = "0x601D580")]
		protected abstract void OnUIApply(DT data, HomeTheme theme);

		// Token: 0x0601D581 RID: 120193
		[Token(Token = "0x601D581")]
		protected abstract void OnFillUIData(DT data, AssetPathConvertor pathConvertor);

		// Token: 0x0601D582 RID: 120194 RVA: 0x000AB318 File Offset: 0x000A9518
		[Token(Token = "0x601D582")]
		protected bool _ValidVector2(Vector2 v)
		{
			return default(bool);
		}

		// Token: 0x0601D583 RID: 120195 RVA: 0x000AB330 File Offset: 0x000A9530
		[Token(Token = "0x601D583")]
		protected bool _ValidColor(Color clr)
		{
			return default(bool);
		}

		// Token: 0x0601D584 RID: 120196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D584")]
		protected HomeThemeUIElem()
		{
		}

		// Token: 0x040269AD RID: 158125
		[Token(Token = "0x40269AD")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _rt;

		// Token: 0x040269AE RID: 158126
		[Token(Token = "0x40269AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnApply;

		// Token: 0x040269AF RID: 158127
		[Token(Token = "0x40269AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFillData;

		// Token: 0x040269B0 RID: 158128
		[Token(Token = "0x40269B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ValidVector2;

		// Token: 0x040269B1 RID: 158129
		[Token(Token = "0x40269B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ValidColor;

		// Token: 0x040269B2 RID: 158130
		[Token(Token = "0x40269B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
