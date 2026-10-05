using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045C9 RID: 17865
	[Token(Token = "0x20045C9")]
	public class Rl03OuterBuffController : RoguelikeTopicOuterBuffController
	{
		// Token: 0x0601B2DA RID: 111322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2DA")]
		[Address(RVA = "0x1456130", Offset = "0x1454D30", VA = "0x181456130", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0601B2DB RID: 111323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2DB")]
		[Address(RVA = "0x14561A0", Offset = "0x1454DA0", VA = "0x1814561A0", Slot = "5")]
		public override void OnEnter(string topicId)
		{
		}

		// Token: 0x0601B2DC RID: 111324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2DC")]
		[Address(RVA = "0x1456320", Offset = "0x1454F20", VA = "0x181456320", Slot = "6")]
		public override void OnResume(bool isResumedFromStack)
		{
		}

		// Token: 0x0601B2DD RID: 111325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2DD")]
		[Address(RVA = "0x1456460", Offset = "0x1455060", VA = "0x181456460")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B2DE RID: 111326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2DE")]
		[Address(RVA = "0x1456C70", Offset = "0x1455870", VA = "0x181456C70")]
		private void _OnSummaryShow()
		{
		}

		// Token: 0x0601B2DF RID: 111327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2DF")]
		[Address(RVA = "0x1456D80", Offset = "0x1455980", VA = "0x181456D80")]
		private void _OnSunmmaryHide()
		{
		}

		// Token: 0x0601B2E0 RID: 111328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2E0")]
		[Address(RVA = "0x1456750", Offset = "0x1455350", VA = "0x181456750")]
		private void _OnNodeClick(string buffId)
		{
		}

		// Token: 0x0601B2E1 RID: 111329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2E1")]
		[Address(RVA = "0x1456870", Offset = "0x1455470", VA = "0x181456870")]
		private void _OnNodeUpgrade(string buffId)
		{
		}

		// Token: 0x0601B2E2 RID: 111330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2E2")]
		[Address(RVA = "0x1456E80", Offset = "0x1455A80", VA = "0x181456E80")]
		public Rl03OuterBuffController()
		{
		}

		// Token: 0x0601B2E3 RID: 111331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2E3")]
		[Address(RVA = "0x1456430", Offset = "0x1455030", VA = "0x181456430")]
		private void <>xLuaBaseProxy_Init()
		{
		}

		// Token: 0x0601B2E4 RID: 111332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2E4")]
		[Address(RVA = "0x1456440", Offset = "0x1455040", VA = "0x181456440")]
		private void <>xLuaBaseProxy_OnEnter(string P0)
		{
		}

		// Token: 0x0601B2E5 RID: 111333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2E5")]
		[Address(RVA = "0x1456450", Offset = "0x1455050", VA = "0x181456450")]
		private void <>xLuaBaseProxy_OnResume(bool P0)
		{
		}

		// Token: 0x04023036 RID: 143414
		[Token(Token = "0x4023036")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rl03OuterBuffView _buffView;

		// Token: 0x04023037 RID: 143415
		[Token(Token = "0x4023037")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Rl03OuterBuffSummaryView _summaryView;

		// Token: 0x04023038 RID: 143416
		[Token(Token = "0x4023038")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04023039 RID: 143417
		[Token(Token = "0x4023039")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIFadeFloatPanel _panelSummary;

		// Token: 0x0402303A RID: 143418
		[Token(Token = "0x402303A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x0402303B RID: 143419
		[Token(Token = "0x402303B")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0402303C RID: 143420
		[Token(Token = "0x402303C")]
		[FieldOffset(Offset = "0x58")]
		private string m_topicId;

		// Token: 0x0402303D RID: 143421
		[Token(Token = "0x402303D")]
		[FieldOffset(Offset = "0x60")]
		private Rl03OuterBuffProperty m_buffProperty;

		// Token: 0x0402303E RID: 143422
		[Token(Token = "0x402303E")]
		[FieldOffset(Offset = "0x68")]
		private Rl03OuterBuffSummaryProperty m_summaryProperty;

		// Token: 0x0402303F RID: 143423
		[Token(Token = "0x402303F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04023040 RID: 143424
		[Token(Token = "0x4023040")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04023041 RID: 143425
		[Token(Token = "0x4023041")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04023042 RID: 143426
		[Token(Token = "0x4023042")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023043 RID: 143427
		[Token(Token = "0x4023043")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSummaryShow;

		// Token: 0x04023044 RID: 143428
		[Token(Token = "0x4023044")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSunmmaryHide;

		// Token: 0x04023045 RID: 143429
		[Token(Token = "0x4023045")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnNodeClick;

		// Token: 0x04023046 RID: 143430
		[Token(Token = "0x4023046")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnNodeUpgrade;

		// Token: 0x04023047 RID: 143431
		[Token(Token = "0x4023047")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
