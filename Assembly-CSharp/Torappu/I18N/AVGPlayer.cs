using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.I18N
{
	// Token: 0x0200161C RID: 5660
	[Token(Token = "0x200161C")]
	public class AVGPlayer : MonoBehaviour
	{
		// Token: 0x0600808C RID: 32908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600808C")]
		[Address(RVA = "0x28860B0", Offset = "0x2884CB0", VA = "0x1828860B0")]
		private void Start()
		{
		}

		// Token: 0x0600808D RID: 32909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600808D")]
		[Address(RVA = "0x2886000", Offset = "0x2884C00", VA = "0x182886000")]
		private void OnGUI()
		{
		}

		// Token: 0x0600808E RID: 32910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600808E")]
		[Address(RVA = "0x28862F0", Offset = "0x2884EF0", VA = "0x1828862F0")]
		public AVGPlayer()
		{
		}

		// Token: 0x040081AD RID: 33197
		[Token(Token = "0x40081AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _okColor;

		// Token: 0x040081AE RID: 33198
		[Token(Token = "0x40081AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _errorColor;

		// Token: 0x040081AF RID: 33199
		[Token(Token = "0x40081AF")]
		[FieldOffset(Offset = "0x38")]
		private string m_content;

		// Token: 0x040081B0 RID: 33200
		[Token(Token = "0x40081B0")]
		[FieldOffset(Offset = "0x40")]
		private bool m_error;
	}
}
