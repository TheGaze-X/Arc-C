using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharacterRepo;
using UnityEngine;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050E9 RID: 20713
	[Token(Token = "0x20050E9")]
	public class CharEditorViewController : MonoBehaviour
	{
		// Token: 0x0601E9E9 RID: 125417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9E9")]
		[Address(RVA = "0x184F160", Offset = "0x184DD60", VA = "0x18184F160")]
		public CharEditorViewController()
		{
		}

		// Token: 0x040290AA RID: 168106
		[Token(Token = "0x40290AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterRepoGridAdapter _listAdapter;

		// Token: 0x040290AB RID: 168107
		[Token(Token = "0x40290AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharEditorEditView _editorView;

		// Token: 0x040290AC RID: 168108
		[Token(Token = "0x40290AC")]
		[FieldOffset(Offset = "0x28")]
		private List<CharacterCardViewModel> m_allCharsData;

		// Token: 0x040290AD RID: 168109
		[Token(Token = "0x40290AD")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, int> m_charIdWithInstId;
	}
}
