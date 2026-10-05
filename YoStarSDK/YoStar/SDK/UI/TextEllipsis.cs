using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x020001CE RID: 462
	[Token(Token = "0x20001CE")]
	[RequireComponent(typeof(Text))]
	public class TextEllipsis : MonoBehaviour
	{
		// Token: 0x06000B18 RID: 2840 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x5C8FA90", Offset = "0x5C8E690", VA = "0x185C8FA90")]
		private void Start()
		{
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x5C8FB40", Offset = "0x5C8E740", VA = "0x185C8FB40")]
		private void Update()
		{
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x5C8FA80", Offset = "0x5C8E680", VA = "0x185C8FA80")]
		private void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x5C8F6D0", Offset = "0x5C8E2D0", VA = "0x185C8F6D0")]
		public void ApplyEllipsis()
		{
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00003704 File Offset: 0x00001904
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x5C8F810", Offset = "0x5C8E410", VA = "0x185C8F810")]
		private float CalculateTextWidth(string text)
		{
			return 0f;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x5C8FC40", Offset = "0x5C8E840", VA = "0x185C8FC40")]
		public TextEllipsis()
		{
		}

		// Token: 0x04000778 RID: 1912
		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("超出此宽度将添加省略号")]
		[Header("Configuration Options")]
		public float maxWidth;

		// Token: 0x04000779 RID: 1913
		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("省略号字符")]
		public string ellipsis;

		// Token: 0x0400077A RID: 1914
		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("检查更新频率(秒)")]
		public float updateFrequency;

		// Token: 0x0400077B RID: 1915
		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0x30")]
		private Text textComponent;

		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x38")]
		private string lastText;

		// Token: 0x0400077D RID: 1917
		[Token(Token = "0x400077D")]
		[FieldOffset(Offset = "0x40")]
		private float lastWidth;

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x44")]
		private float timer;
	}
}
