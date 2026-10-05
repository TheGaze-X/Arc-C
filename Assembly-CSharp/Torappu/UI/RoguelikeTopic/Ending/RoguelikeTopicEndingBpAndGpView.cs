using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x02004686 RID: 18054
	[Token(Token = "0x2004686")]
	public class RoguelikeTopicEndingBpAndGpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B689 RID: 112265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B689")]
		[Address(RVA = "0x14B2CB0", Offset = "0x14B18B0", VA = "0x1814B2CB0")]
		public void Flush(RoguelikeTopicEndingBpAndGpView.Model model)
		{
		}

		// Token: 0x0601B68A RID: 112266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B68A")]
		[Address(RVA = "0x14B2F30", Offset = "0x14B1B30", VA = "0x1814B2F30")]
		private IEnumerator _TweenBp(RoguelikeTopicEndingBpAndGpView.Model model)
		{
			return null;
		}

		// Token: 0x0601B68B RID: 112267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B68B")]
		[Address(RVA = "0x14B3020", Offset = "0x14B1C20", VA = "0x1814B3020")]
		public RoguelikeTopicEndingBpAndGpView()
		{
		}

		// Token: 0x04023716 RID: 145174
		[Token(Token = "0x4023716")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _bpRoot;

		// Token: 0x04023717 RID: 145175
		[Token(Token = "0x4023717")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeTopicEndingBPStatusView _bpStatusPrefab;

		// Token: 0x04023718 RID: 145176
		[Token(Token = "0x4023718")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeTopicEndingGpView _gpView;

		// Token: 0x04023719 RID: 145177
		[Token(Token = "0x4023719")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeTopicEndingBPStatusView m_bpStatus;

		// Token: 0x0402371A RID: 145178
		[Token(Token = "0x402371A")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine m_bpCoroutine;

		// Token: 0x0402371B RID: 145179
		[Token(Token = "0x402371B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Flush;

		// Token: 0x0402371C RID: 145180
		[Token(Token = "0x402371C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TweenBp;

		// Token: 0x0402371D RID: 145181
		[Token(Token = "0x402371D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004687 RID: 18055
		[Token(Token = "0x2004687")]
		public struct Model
		{
			// Token: 0x0402371E RID: 145182
			[Token(Token = "0x402371E")]
			[FieldOffset(Offset = "0x0")]
			public string currTopicId;

			// Token: 0x0402371F RID: 145183
			[Token(Token = "0x402371F")]
			[FieldOffset(Offset = "0x8")]
			public int preBpPoint;

			// Token: 0x04023720 RID: 145184
			[Token(Token = "0x4023720")]
			[FieldOffset(Offset = "0xC")]
			public int currBpPoint;

			// Token: 0x04023721 RID: 145185
			[Token(Token = "0x4023721")]
			[FieldOffset(Offset = "0x10")]
			public int gp;
		}
	}
}
