using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005377 RID: 21367
	[Token(Token = "0x2005377")]
	public class RoguelikeReportPage : UIPage
	{
		// Token: 0x0601F7E2 RID: 128994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7E2")]
		[Address(RVA = "0x192F210", Offset = "0x192DE10", VA = "0x18192F210", Slot = "12")]
		public override IEnumerator ShowCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0601F7E3 RID: 128995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7E3")]
		[Address(RVA = "0x192F120", Offset = "0x192DD20", VA = "0x18192F120", Slot = "14")]
		protected override void OnStop()
		{
		}

		// Token: 0x0601F7E4 RID: 128996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7E4")]
		[Address(RVA = "0x192F2D0", Offset = "0x192DED0", VA = "0x18192F2D0")]
		private void _LoadControllerIfNot()
		{
		}

		// Token: 0x0601F7E5 RID: 128997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7E5")]
		[Address(RVA = "0x192F4C0", Offset = "0x192E0C0", VA = "0x18192F4C0")]
		public RoguelikeReportPage()
		{
		}

		// Token: 0x0601F7E6 RID: 128998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7E6")]
		[Address(RVA = "0xE987B0", Offset = "0xE973B0", VA = "0x180E987B0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(bool P0)
		{
			return null;
		}

		// Token: 0x0601F7E7 RID: 128999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7E7")]
		[Address(RVA = "0xE98790", Offset = "0xE97390", VA = "0x180E98790")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x0402A600 RID: 173568
		[Token(Token = "0x402A600")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402A601 RID: 173569
		[Token(Token = "0x402A601")]
		[FieldOffset(Offset = "0xE0")]
		private RoguelikeReportControllerBase m_controller;

		// Token: 0x0402A602 RID: 173570
		[Token(Token = "0x402A602")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0402A603 RID: 173571
		[Token(Token = "0x402A603")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0402A604 RID: 173572
		[Token(Token = "0x402A604")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadControllerIfNot;

		// Token: 0x0402A605 RID: 173573
		[Token(Token = "0x402A605")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005378 RID: 21368
		[Token(Token = "0x2005378")]
		public struct Param
		{
			// Token: 0x0402A606 RID: 173574
			[Token(Token = "0x402A606")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0402A607 RID: 173575
			[Token(Token = "0x402A607")]
			[FieldOffset(Offset = "0x8")]
			public RoguelikeTopicDetail topicDetail;

			// Token: 0x0402A608 RID: 173576
			[Token(Token = "0x402A608")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeTopicCustomizeData topicCustomize;

			// Token: 0x0402A609 RID: 173577
			[Token(Token = "0x402A609")]
			[FieldOffset(Offset = "0x18")]
			public string endingFrameDetail;
		}
	}
}
