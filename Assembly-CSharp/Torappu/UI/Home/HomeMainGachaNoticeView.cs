using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C0E RID: 19470
	[Token(Token = "0x2004C0E")]
	public class HomeMainGachaNoticeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D40F RID: 119823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D40F")]
		[Address(RVA = "0x16D4470", Offset = "0x16D3070", VA = "0x1816D4470")]
		public void RefreshState()
		{
		}

		// Token: 0x0601D410 RID: 119824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D410")]
		[Address(RVA = "0x16D4BA0", Offset = "0x16D37A0", VA = "0x1816D4BA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D411 RID: 119825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D411")]
		[Address(RVA = "0x16D4B00", Offset = "0x16D3700", VA = "0x1816D4B00")]
		private void _InactivateNoticeViews()
		{
		}

		// Token: 0x0601D412 RID: 119826 RVA: 0x000AB090 File Offset: 0x000A9290
		[Token(Token = "0x601D412")]
		[Address(RVA = "0x16D4950", Offset = "0x16D3550", VA = "0x1816D4950")]
		private bool _CheckAndRenderFreeRecruit(List<GachaPoolClientData> clientPool, PlayerGacha playerGacha)
		{
			return default(bool);
		}

		// Token: 0x0601D413 RID: 119827 RVA: 0x000AB0A8 File Offset: 0x000A92A8
		[Token(Token = "0x601D413")]
		[Address(RVA = "0x16D46C0", Offset = "0x16D32C0", VA = "0x1816D46C0")]
		private bool _CheckAndRenderFreeOnce(List<GachaPoolClientData> clientPool, PlayerGacha playerGacha)
		{
			return default(bool);
		}

		// Token: 0x0601D414 RID: 119828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D414")]
		[Address(RVA = "0x16D4CB0", Offset = "0x16D38B0", VA = "0x1816D4CB0")]
		public HomeMainGachaNoticeView()
		{
		}

		// Token: 0x0402673A RID: 157498
		[Token(Token = "0x402673A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _noticeContainer;

		// Token: 0x0402673B RID: 157499
		[Token(Token = "0x402673B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GachaFreeOnceNoticeView _gachaFreeOnceNoticeView;

		// Token: 0x0402673C RID: 157500
		[Token(Token = "0x402673C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GachaFreeRecruitNoticeView _gachaFreeRecruitNoticeView;

		// Token: 0x0402673D RID: 157501
		[Token(Token = "0x402673D")]
		[FieldOffset(Offset = "0x30")]
		private GachaFreeOnceNoticeView m_gachaFreeOnceNoticeView;

		// Token: 0x0402673E RID: 157502
		[Token(Token = "0x402673E")]
		[FieldOffset(Offset = "0x38")]
		private GachaFreeRecruitNoticeView m_gachaFreeRecruitNoticeView;

		// Token: 0x0402673F RID: 157503
		[Token(Token = "0x402673F")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x04026740 RID: 157504
		[Token(Token = "0x4026740")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshState;

		// Token: 0x04026741 RID: 157505
		[Token(Token = "0x4026741")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026742 RID: 157506
		[Token(Token = "0x4026742")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InactivateNoticeViews;

		// Token: 0x04026743 RID: 157507
		[Token(Token = "0x4026743")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckAndRenderFreeRecruit;

		// Token: 0x04026744 RID: 157508
		[Token(Token = "0x4026744")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckAndRenderFreeOnce;

		// Token: 0x04026745 RID: 157509
		[Token(Token = "0x4026745")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
