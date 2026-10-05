using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044FB RID: 17659
	[Token(Token = "0x20044FB")]
	public class RoguelikeCommonOuterBuffController : RoguelikeTopicOuterBuffController
	{
		// Token: 0x0601AF31 RID: 110385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF31")]
		[Address(RVA = "0x141A7A0", Offset = "0x14193A0", VA = "0x18141A7A0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0601AF32 RID: 110386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF32")]
		[Address(RVA = "0x141A840", Offset = "0x1419440", VA = "0x18141A840", Slot = "5")]
		public override void OnEnter(string topicId)
		{
		}

		// Token: 0x0601AF33 RID: 110387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF33")]
		[Address(RVA = "0x141AB60", Offset = "0x1419760", VA = "0x18141AB60", Slot = "6")]
		public override void OnResume(bool isResumedFromStack)
		{
		}

		// Token: 0x0601AF34 RID: 110388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF34")]
		[Address(RVA = "0x141ADE0", Offset = "0x14199E0", VA = "0x18141ADE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AF35 RID: 110389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AF35")]
		[Address(RVA = "0x141B210", Offset = "0x1419E10", VA = "0x18141B210")]
		private RoguelikeCommonDevelopmentData _LoadDevelopmentData()
		{
			return null;
		}

		// Token: 0x0601AF36 RID: 110390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF36")]
		[Address(RVA = "0x141B880", Offset = "0x141A480", VA = "0x18141B880")]
		private void _OnSummaryShow()
		{
		}

		// Token: 0x0601AF37 RID: 110391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF37")]
		[Address(RVA = "0x141BA60", Offset = "0x141A660", VA = "0x18141BA60")]
		private void _OnSunmmaryHide()
		{
		}

		// Token: 0x0601AF38 RID: 110392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF38")]
		[Address(RVA = "0x141B320", Offset = "0x1419F20", VA = "0x18141B320")]
		private void _OnNodeClick(string buffId)
		{
		}

		// Token: 0x0601AF39 RID: 110393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF39")]
		[Address(RVA = "0x141B440", Offset = "0x141A040", VA = "0x18141B440")]
		private void _OnNodeUpgrade(string buffId)
		{
		}

		// Token: 0x0601AF3A RID: 110394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF3A")]
		[Address(RVA = "0x141BB60", Offset = "0x141A760", VA = "0x18141BB60")]
		public RoguelikeCommonOuterBuffController()
		{
		}

		// Token: 0x0601AF3B RID: 110395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF3B")]
		[Address(RVA = "0x141ACC0", Offset = "0x14198C0", VA = "0x18141ACC0")]
		private void <>xLuaBaseProxy_Init()
		{
		}

		// Token: 0x0601AF3C RID: 110396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF3C")]
		[Address(RVA = "0x141AD20", Offset = "0x1419920", VA = "0x18141AD20")]
		private void <>xLuaBaseProxy_OnEnter(string P0)
		{
		}

		// Token: 0x0601AF3D RID: 110397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF3D")]
		[Address(RVA = "0x141AD80", Offset = "0x1419980", VA = "0x18141AD80")]
		private void <>xLuaBaseProxy_OnResume(bool P0)
		{
		}

		// Token: 0x04022946 RID: 141638
		[Token(Token = "0x4022946")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeCommonOuterBuffDataRouter _dataRouter;

		// Token: 0x04022947 RID: 141639
		[Token(Token = "0x4022947")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeCommonOuterBuffView _buffView;

		// Token: 0x04022948 RID: 141640
		[Token(Token = "0x4022948")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeCommonOuterBuffSummaryView _summaryView;

		// Token: 0x04022949 RID: 141641
		[Token(Token = "0x4022949")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0402294A RID: 141642
		[Token(Token = "0x402294A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIFadeFloatPanel _panelSummary;

		// Token: 0x0402294B RID: 141643
		[Token(Token = "0x402294B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x0402294C RID: 141644
		[Token(Token = "0x402294C")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0402294D RID: 141645
		[Token(Token = "0x402294D")]
		[FieldOffset(Offset = "0x60")]
		private string m_topicId;

		// Token: 0x0402294E RID: 141646
		[Token(Token = "0x402294E")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeCommonOuterBuffProperty m_buffProperty;

		// Token: 0x0402294F RID: 141647
		[Token(Token = "0x402294F")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeCommonOuterBuffSummaryProperty m_summaryProperty;

		// Token: 0x04022950 RID: 141648
		[Token(Token = "0x4022950")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022951 RID: 141649
		[Token(Token = "0x4022951")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04022952 RID: 141650
		[Token(Token = "0x4022952")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04022953 RID: 141651
		[Token(Token = "0x4022953")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022954 RID: 141652
		[Token(Token = "0x4022954")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadDevelopmentData;

		// Token: 0x04022955 RID: 141653
		[Token(Token = "0x4022955")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSummaryShow;

		// Token: 0x04022956 RID: 141654
		[Token(Token = "0x4022956")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSunmmaryHide;

		// Token: 0x04022957 RID: 141655
		[Token(Token = "0x4022957")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnNodeClick;

		// Token: 0x04022958 RID: 141656
		[Token(Token = "0x4022958")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnNodeUpgrade;

		// Token: 0x04022959 RID: 141657
		[Token(Token = "0x4022959")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
