using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200669B RID: 26267
	[Token(Token = "0x200669B")]
	public class HandbookInfoTextView : MonoBehaviour
	{
		// Token: 0x06025BAC RID: 154540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BAC")]
		[Address(RVA = "0x20B32D0", Offset = "0x20B1ED0", VA = "0x1820B32D0")]
		public void SetTitle(string title)
		{
		}

		// Token: 0x06025BAD RID: 154541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BAD")]
		[Address(RVA = "0x20B33D0", Offset = "0x20B1FD0", VA = "0x1820B33D0")]
		public void SetTitle(HandBookStoryViewData.StoryText _view)
		{
		}

		// Token: 0x06025BAE RID: 154542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BAE")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandbookInfoTextView()
		{
		}

		// Token: 0x0403503F RID: 217151
		[Token(Token = "0x403503F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _title;

		// Token: 0x04035040 RID: 217152
		[Token(Token = "0x4035040")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _detail;

		// Token: 0x04035041 RID: 217153
		[Token(Token = "0x4035041")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _titleBackGround;
	}
}
