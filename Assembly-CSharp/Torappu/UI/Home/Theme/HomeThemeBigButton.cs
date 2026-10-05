using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C54 RID: 19540
	[Token(Token = "0x2004C54")]
	public class HomeThemeBigButton : HomeThemeUIElem<HomeThemeBigButtonData>
	{
		// Token: 0x0601D525 RID: 120101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D525")]
		[Address(RVA = "0x16E5750", Offset = "0x16E4350", VA = "0x1816E5750", Slot = "16")]
		protected override void OnUIApply(HomeThemeBigButtonData data, HomeTheme theme)
		{
		}

		// Token: 0x0601D526 RID: 120102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D526")]
		[Address(RVA = "0x16E56C0", Offset = "0x16E42C0", VA = "0x1816E56C0", Slot = "11")]
		public override void OnGenData()
		{
		}

		// Token: 0x0601D527 RID: 120103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D527")]
		[Address(RVA = "0x16E5BB0", Offset = "0x16E47B0", VA = "0x1816E5BB0")]
		private void _ApplyImage(HomeThemeBigButtonData.ImageData data, Image image, HomeTheme theme)
		{
		}

		// Token: 0x0601D528 RID: 120104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D528")]
		[Address(RVA = "0x16E5400", Offset = "0x16E4000", VA = "0x1816E5400", Slot = "17")]
		protected override void OnFillUIData(HomeThemeBigButtonData data, AssetPathConvertor pathConvertor)
		{
		}

		// Token: 0x0601D529 RID: 120105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D529")]
		[Address(RVA = "0x16E5290", Offset = "0x16E3E90", VA = "0x1816E5290", Slot = "15")]
		protected override void OnClearRef()
		{
		}

		// Token: 0x0601D52A RID: 120106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D52A")]
		[Address(RVA = "0x16E51B0", Offset = "0x16E3DB0", VA = "0x1816E51B0")]
		public void HideOrShowMainImg()
		{
		}

		// Token: 0x0601D52B RID: 120107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D52B")]
		[Address(RVA = "0x16E5E20", Offset = "0x16E4A20", VA = "0x1816E5E20")]
		public HomeThemeBigButton()
		{
		}

		// Token: 0x0402694A RID: 158026
		[Token(Token = "0x402694A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIColorGraphic _btnGraphic;

		// Token: 0x0402694B RID: 158027
		[Token(Token = "0x402694B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _mainImg;

		// Token: 0x0402694C RID: 158028
		[Token(Token = "0x402694C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _bgImg;

		// Token: 0x0402694D RID: 158029
		[Token(Token = "0x402694D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PrefabDisplay _bgPrefab;

		// Token: 0x0402694E RID: 158030
		[Token(Token = "0x402694E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUIApply;

		// Token: 0x0402694F RID: 158031
		[Token(Token = "0x402694F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGenData;

		// Token: 0x04026950 RID: 158032
		[Token(Token = "0x4026950")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyImage;

		// Token: 0x04026951 RID: 158033
		[Token(Token = "0x4026951")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFillUIData;

		// Token: 0x04026952 RID: 158034
		[Token(Token = "0x4026952")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClearRef;

		// Token: 0x04026953 RID: 158035
		[Token(Token = "0x4026953")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideOrShowMainImg;

		// Token: 0x04026954 RID: 158036
		[Token(Token = "0x4026954")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
