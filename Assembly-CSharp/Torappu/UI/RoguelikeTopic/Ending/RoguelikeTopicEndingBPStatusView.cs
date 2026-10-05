using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x02004689 RID: 18057
	[Token(Token = "0x2004689")]
	public class RoguelikeTopicEndingBPStatusView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B692 RID: 112274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B692")]
		[Address(RVA = "0x14B28F0", Offset = "0x14B14F0", VA = "0x1814B28F0")]
		public void Flush(string topicId, int bpFrom, int bpTo)
		{
		}

		// Token: 0x0601B693 RID: 112275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B693")]
		[Address(RVA = "0x14B29A0", Offset = "0x14B15A0", VA = "0x1814B29A0")]
		public IEnumerator TweenToTarget(string topicId, int srcBp, int destBp)
		{
			return null;
		}

		// Token: 0x0601B694 RID: 112276 RVA: 0x000A5228 File Offset: 0x000A3428
		[Token(Token = "0x601B694")]
		[Address(RVA = "0x14B2A90", Offset = "0x14B1690", VA = "0x1814B2A90")]
		private int _GetBp()
		{
			return 0;
		}

		// Token: 0x0601B695 RID: 112277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B695")]
		[Address(RVA = "0x14B2AF0", Offset = "0x14B16F0", VA = "0x1814B2AF0")]
		private void _SetBp(int v)
		{
		}

		// Token: 0x0601B696 RID: 112278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B696")]
		[Address(RVA = "0x14B2C40", Offset = "0x14B1840", VA = "0x1814B2C40")]
		public RoguelikeTopicEndingBPStatusView()
		{
		}

		// Token: 0x04023727 RID: 145191
		[Token(Token = "0x4023727")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _bpLevel;

		// Token: 0x04023728 RID: 145192
		[Token(Token = "0x4023728")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Scrollbar _bpPrg;

		// Token: 0x04023729 RID: 145193
		[Token(Token = "0x4023729")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _bpPrgCount;

		// Token: 0x0402372A RID: 145194
		[Token(Token = "0x402372A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _maxTag;

		// Token: 0x0402372B RID: 145195
		[Token(Token = "0x402372B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _prgAnimDur;

		// Token: 0x0402372C RID: 145196
		[Token(Token = "0x402372C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _waitForNext;

		// Token: 0x0402372D RID: 145197
		[Token(Token = "0x402372D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _textColor;

		// Token: 0x0402372E RID: 145198
		[Token(Token = "0x402372E")]
		[FieldOffset(Offset = "0x50")]
		private string m_textColor;

		// Token: 0x0402372F RID: 145199
		[Token(Token = "0x402372F")]
		[FieldOffset(Offset = "0x58")]
		private int m_tweenBp;

		// Token: 0x04023730 RID: 145200
		[Token(Token = "0x4023730")]
		[FieldOffset(Offset = "0x5C")]
		private int m_tweenMaxBp;

		// Token: 0x04023731 RID: 145201
		[Token(Token = "0x4023731")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Flush;

		// Token: 0x04023732 RID: 145202
		[Token(Token = "0x4023732")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TweenToTarget;

		// Token: 0x04023733 RID: 145203
		[Token(Token = "0x4023733")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetBp;

		// Token: 0x04023734 RID: 145204
		[Token(Token = "0x4023734")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetBp;

		// Token: 0x04023735 RID: 145205
		[Token(Token = "0x4023735")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
