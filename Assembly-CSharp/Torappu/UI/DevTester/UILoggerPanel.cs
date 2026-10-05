using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x02005109 RID: 20745
	[Token(Token = "0x2005109")]
	public class UILoggerPanel : MonoBehaviour
	{
		// Token: 0x0601EA28 RID: 125480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA28")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UILoggerPanel()
		{
		}

		// Token: 0x04029145 RID: 168261
		[Token(Token = "0x4029145")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LoopVerticalScrollRect _loopScroll;

		// Token: 0x04029146 RID: 168262
		[Token(Token = "0x4029146")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stackTraceLogText;

		// Token: 0x04029147 RID: 168263
		[Token(Token = "0x4029147")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _filterButton;

		// Token: 0x04029148 RID: 168264
		[Token(Token = "0x4029148")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _filterImage;

		// Token: 0x04029149 RID: 168265
		[Token(Token = "0x4029149")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _filterButtonWarnning;

		// Token: 0x0402914A RID: 168266
		[Token(Token = "0x402914A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _filterImageWarnning;

		// Token: 0x0402914B RID: 168267
		[Token(Token = "0x402914B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _filterButtonError;

		// Token: 0x0402914C RID: 168268
		[Token(Token = "0x402914C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _filterImageError;

		// Token: 0x0402914D RID: 168269
		[Token(Token = "0x402914D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private InputField _inputFilter;
	}
}
