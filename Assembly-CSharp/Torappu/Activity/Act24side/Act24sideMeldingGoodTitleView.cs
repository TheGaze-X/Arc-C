using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075AB RID: 30123
	[Token(Token = "0x20075AB")]
	public class Act24sideMeldingGoodTitleView : Act24sideMeldingGoodTitleAbstractView
	{
		// Token: 0x0602A636 RID: 173622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A636")]
		[Address(RVA = "0x260D8A0", Offset = "0x260C4A0", VA = "0x18260D8A0", Slot = "4")]
		public override void Render(Act24sideMeldingGoodDisplayViewModel groupViewModel)
		{
		}

		// Token: 0x0602A637 RID: 173623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A637")]
		[Address(RVA = "0x260DBE0", Offset = "0x260C7E0", VA = "0x18260DBE0")]
		public Act24sideMeldingGoodTitleView()
		{
		}

		// Token: 0x0403CFDB RID: 249819
		[Token(Token = "0x403CFDB")]
		private const string TITLE_PREFIX = "img_content_rare_{0}";

		// Token: 0x0403CFDC RID: 249820
		[Token(Token = "0x403CFDC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Only for act24side")]
		private UIAtlasImage _imgTitle;

		// Token: 0x0403CFDD RID: 249821
		[Token(Token = "0x403CFDD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Only for act24side")]
		private UIAtlasImage _imgTitleLeft;

		// Token: 0x0403CFDE RID: 249822
		[Token(Token = "0x403CFDE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Only for act24side")]
		private UIAtlasImage _imgTitleRight;

		// Token: 0x0403CFDF RID: 249823
		[Token(Token = "0x403CFDF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Only for act24side")]
		private UIAtlasObject _atlas;

		// Token: 0x0403CFE0 RID: 249824
		[Token(Token = "0x403CFE0")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedColThemeStr;

		// Token: 0x0403CFE1 RID: 249825
		[Token(Token = "0x403CFE1")]
		[FieldOffset(Offset = "0x40")]
		private Act24SideData.MeldingGoodDisplayType m_cachedDisplayType;

		// Token: 0x0403CFE2 RID: 249826
		[Token(Token = "0x403CFE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CFE3 RID: 249827
		[Token(Token = "0x403CFE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
