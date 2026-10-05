using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity
{
	// Token: 0x02004697 RID: 18071
	[Token(Token = "0x2004697")]
	public abstract class RoguelikeTopicActivityPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B6C0 RID: 112320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6C0")]
		[Address(RVA = "0x14B16E0", Offset = "0x14B02E0", VA = "0x1814B16E0")]
		public void InitPanel(string topicId, string rlActId, RoguelikeTopicActivityState dialogCallBack)
		{
		}

		// Token: 0x0601B6C1 RID: 112321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6C1")]
		[Address(RVA = "0x14B1840", Offset = "0x14B0440", VA = "0x1814B1840")]
		public void UpdatePanel()
		{
		}

		// Token: 0x0601B6C2 RID: 112322
		[Token(Token = "0x601B6C2")]
		protected abstract void _InitPanel(string topicId, string rlActId);

		// Token: 0x0601B6C3 RID: 112323
		[Token(Token = "0x601B6C3")]
		protected abstract void _UpdatePanel();

		// Token: 0x0601B6C4 RID: 112324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6C4")]
		[Address(RVA = "0x14B17D0", Offset = "0x14B03D0", VA = "0x1814B17D0")]
		public void OnClickClosePanel()
		{
		}

		// Token: 0x0601B6C5 RID: 112325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6C5")]
		[Address(RVA = "0x14B18C0", Offset = "0x14B04C0", VA = "0x1814B18C0")]
		protected RoguelikeTopicActivityPanel()
		{
		}

		// Token: 0x0402378D RID: 145293
		[Token(Token = "0x402378D")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Action onClickClosePanel;

		// Token: 0x0402378E RID: 145294
		[Token(Token = "0x402378E")]
		[FieldOffset(Offset = "0x20")]
		protected RoguelikeTopicActivityState m_dialogCallBackHandler;

		// Token: 0x0402378F RID: 145295
		[Token(Token = "0x402378F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitPanel;

		// Token: 0x04023790 RID: 145296
		[Token(Token = "0x4023790")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x04023791 RID: 145297
		[Token(Token = "0x4023791")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickClosePanel;

		// Token: 0x04023792 RID: 145298
		[Token(Token = "0x4023792")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
