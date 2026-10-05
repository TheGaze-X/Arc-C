using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066ED RID: 26349
	[Token(Token = "0x20066ED")]
	public class HandBookV2ForceDetailState : PopupFadeState
	{
		// Token: 0x06025D14 RID: 154900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D14")]
		[Address(RVA = "0x20BFB40", Offset = "0x20BE740", VA = "0x1820BFB40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025D15 RID: 154901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D15")]
		[Address(RVA = "0x20BFD10", Offset = "0x20BE910", VA = "0x1820BFD10")]
		public void OnDetail()
		{
		}

		// Token: 0x06025D16 RID: 154902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D16")]
		[Address(RVA = "0x20BFBA0", Offset = "0x20BE7A0", VA = "0x1820BFBA0")]
		public void OnClick(HandBookV2MapCardView cardView)
		{
		}

		// Token: 0x06025D17 RID: 154903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D17")]
		[Address(RVA = "0x20BFDA0", Offset = "0x20BE9A0", VA = "0x1820BFDA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025D18 RID: 154904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D18")]
		[Address(RVA = "0x20BFE80", Offset = "0x20BEA80", VA = "0x1820BFE80", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06025D19 RID: 154905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D19")]
		[Address(RVA = "0x20BFF30", Offset = "0x20BEB30", VA = "0x1820BFF30")]
		public HandBookV2ForceDetailState()
		{
		}

		// Token: 0x06025D1A RID: 154906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D1A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06025D1B RID: 154907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D1B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04035292 RID: 217746
		[Token(Token = "0x4035292")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HandBookV2ForceDetailStateBean _stateBean;

		// Token: 0x04035293 RID: 217747
		[Token(Token = "0x4035293")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HandBookV2GroupDetailView _view;

		// Token: 0x04035294 RID: 217748
		[Token(Token = "0x4035294")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04035295 RID: 217749
		[Token(Token = "0x4035295")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDetail;

		// Token: 0x04035296 RID: 217750
		[Token(Token = "0x4035296")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04035297 RID: 217751
		[Token(Token = "0x4035297")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04035298 RID: 217752
		[Token(Token = "0x4035298")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04035299 RID: 217753
		[Token(Token = "0x4035299")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
