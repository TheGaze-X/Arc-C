using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook.Editor
{
	// Token: 0x02006739 RID: 26425
	[Token(Token = "0x2006739")]
	public class HandBookV2EditorForceLogoView : MonoBehaviour
	{
		// Token: 0x06025E57 RID: 155223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E57")]
		[Address(RVA = "0x20D0AC0", Offset = "0x20CF6C0", VA = "0x1820D0AC0")]
		public void SetRaycast(bool canRaycast)
		{
		}

		// Token: 0x06025E58 RID: 155224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E58")]
		[Address(RVA = "0x20D0AE0", Offset = "0x20CF6E0", VA = "0x1820D0AE0")]
		public void SetSelect(bool isSelected)
		{
		}

		// Token: 0x06025E59 RID: 155225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E59")]
		[Address(RVA = "0x20D0910", Offset = "0x20CF510", VA = "0x1820D0910")]
		public void Render(HandBookV2ForceData forceData)
		{
		}

		// Token: 0x06025E5A RID: 155226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E5A")]
		[Address(RVA = "0x20D05F0", Offset = "0x20CF1F0", VA = "0x1820D05F0")]
		public void OnBeginMove()
		{
		}

		// Token: 0x06025E5B RID: 155227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E5B")]
		[Address(RVA = "0x20D0800", Offset = "0x20CF400", VA = "0x1820D0800")]
		public void OnMove(Vector2 delta)
		{
		}

		// Token: 0x06025E5C RID: 155228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E5C")]
		[Address(RVA = "0x20D0710", Offset = "0x20CF310", VA = "0x1820D0710")]
		public void OnClick()
		{
		}

		// Token: 0x06025E5D RID: 155229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E5D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookV2EditorForceLogoView()
		{
		}

		// Token: 0x040354CF RID: 218319
		[Token(Token = "0x40354CF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgLogo;

		// Token: 0x040354D0 RID: 218320
		[Token(Token = "0x40354D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _borderGo;

		// Token: 0x040354D1 RID: 218321
		[Token(Token = "0x40354D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040354D2 RID: 218322
		[Token(Token = "0x40354D2")]
		[FieldOffset(Offset = "0x30")]
		private HandBookV2ForceData m_forceData;

		// Token: 0x040354D3 RID: 218323
		[Token(Token = "0x40354D3")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 m_startPos;
	}
}
