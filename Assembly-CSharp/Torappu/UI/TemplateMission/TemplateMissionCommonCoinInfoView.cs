using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D95 RID: 15765
	[Token(Token = "0x2003D95")]
	public class TemplateMissionCommonCoinInfoView : TemplateMissionCoinInfoView
	{
		// Token: 0x06018859 RID: 100441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018859")]
		[Address(RVA = "0x110BF90", Offset = "0x110AB90", VA = "0x18110BF90", Slot = "8")]
		public override void Init(AbstractTemplateMissionViewController ctrl_, TemplateMissionCustomResHolder customResHolder_)
		{
		}

		// Token: 0x0601885A RID: 100442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601885A")]
		[Address(RVA = "0x110C040", Offset = "0x110AC40", VA = "0x18110C040", Slot = "9")]
		protected override void RenderView()
		{
		}

		// Token: 0x0601885B RID: 100443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601885B")]
		[Address(RVA = "0x110C3D0", Offset = "0x110AFD0", VA = "0x18110C3D0")]
		private void _RenderCoinImg(TemplateMissionViewModel model)
		{
		}

		// Token: 0x0601885C RID: 100444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601885C")]
		[Address(RVA = "0x110C2B0", Offset = "0x110AEB0", VA = "0x18110C2B0")]
		private void _RenderCoinCount(TemplateMissionCoinViewModel coinModel)
		{
		}

		// Token: 0x0601885D RID: 100445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601885D")]
		[Address(RVA = "0x110C610", Offset = "0x110B210", VA = "0x18110C610")]
		public TemplateMissionCommonCoinInfoView()
		{
		}

		// Token: 0x0601885E RID: 100446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601885E")]
		[Address(RVA = "0x1109AC0", Offset = "0x11086C0", VA = "0x181109AC0")]
		private void <>xLuaBaseProxy_Init(AbstractTemplateMissionViewController P0, TemplateMissionCustomResHolder P1)
		{
		}

		// Token: 0x0401E100 RID: 123136
		[Token(Token = "0x401E100")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgCoin;

		// Token: 0x0401E101 RID: 123137
		[Token(Token = "0x401E101")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtCoin;

		// Token: 0x0401E102 RID: 123138
		[Token(Token = "0x401E102")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgBgLeft;

		// Token: 0x0401E103 RID: 123139
		[Token(Token = "0x401E103")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TemplateMissionCommonEntryFadeTween _entryFadeTween;

		// Token: 0x0401E104 RID: 123140
		[Token(Token = "0x401E104")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isImgRendered;

		// Token: 0x0401E105 RID: 123141
		[Token(Token = "0x401E105")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E106 RID: 123142
		[Token(Token = "0x401E106")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401E107 RID: 123143
		[Token(Token = "0x401E107")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCoinImg;

		// Token: 0x0401E108 RID: 123144
		[Token(Token = "0x401E108")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCoinCount;

		// Token: 0x0401E109 RID: 123145
		[Token(Token = "0x401E109")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
