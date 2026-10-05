using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x020001CC RID: 460
	[Token(Token = "0x20001CC")]
	public class LimitedLinesText : MonoBehaviour
	{
		// Token: 0x06000B0C RID: 2828 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
		public void SetMaxLines(int maxLines)
		{
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x5C89D30", Offset = "0x5C88930", VA = "0x185C89D30")]
		public void SetText(string newText)
		{
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000036EC File Offset: 0x000018EC
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x5C89B40", Offset = "0x5C88740", VA = "0x185C89B40")]
		private int CalculateLineCount(string text)
		{
			return 0;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x5C89BE0", Offset = "0x5C887E0", VA = "0x185C89BE0")]
		private string GetTruncatedText(string originalText)
		{
			return null;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x5C89F50", Offset = "0x5C88B50", VA = "0x185C89F50")]
		public LimitedLinesText()
		{
		}

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x18")]
		public Text adaptableText;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x20")]
		public int maxLines;
	}
}
