using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YoStar.SDK.View
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	public class HyperlinkText : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060006CF RID: 1743 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x060006D0 RID: 1744 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000013")]
		public event HyperlinkText.LinkClickHandler OnLinkClicked
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x5C2B730", Offset = "0x5C2A330", VA = "0x185C2B730")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x5C2B7D0", Offset = "0x5C2A3D0", VA = "0x185C2B7D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x5C2A6E0", Offset = "0x5C292E0", VA = "0x185C2A6E0")]
		private void Awake()
		{
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x5C2B530", Offset = "0x5C2A130", VA = "0x185C2B530")]
		public void SetText(string text)
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x5C2B4B0", Offset = "0x5C2A0B0", VA = "0x185C2B4B0")]
		public void SetLinkColor(Color newColor)
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x5C2B610", Offset = "0x5C2A210", VA = "0x185C2B610")]
		private void UpdateText()
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x5C2AD30", Offset = "0x5C29930", VA = "0x185C2AD30")]
		private string PreprocessText(string input)
		{
			return null;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x5C2A9B0", Offset = "0x5C295B0", VA = "0x185C2A9B0", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000032FC File Offset: 0x000014FC
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x5C2A780", Offset = "0x5C29380", VA = "0x185C2A780")]
		private int FindCharacterIndex(Vector2 localPoint)
		{
			return 0;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x5C2B670", Offset = "0x5C2A270", VA = "0x185C2B670")]
		public HyperlinkText()
		{
		}

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x18")]
		private Text textComponent;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x20")]
		private Color linkColor;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x30")]
		private List<HyperlinkText.LinkInfo> links;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x38")]
		private string currentText;

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x060006DA RID: 1754
		[Token(Token = "0x20000FD")]
		public delegate void LinkClickHandler(string url);

		// Token: 0x020000FE RID: 254
		[Token(Token = "0x20000FE")]
		private class LinkInfo
		{
			// Token: 0x060006DD RID: 1757 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x5C2C390", Offset = "0x5C2AF90", VA = "0x185C2C390")]
			public LinkInfo(string url, string text, int startIndex, int endIndex)
			{
			}

			// Token: 0x040003C8 RID: 968
			[Token(Token = "0x40003C8")]
			[FieldOffset(Offset = "0x10")]
			public string url;

			// Token: 0x040003C9 RID: 969
			[Token(Token = "0x40003C9")]
			[FieldOffset(Offset = "0x18")]
			public string text;

			// Token: 0x040003CA RID: 970
			[Token(Token = "0x40003CA")]
			[FieldOffset(Offset = "0x20")]
			public int startIndex;

			// Token: 0x040003CB RID: 971
			[Token(Token = "0x40003CB")]
			[FieldOffset(Offset = "0x24")]
			public int endIndex;
		}
	}
}
