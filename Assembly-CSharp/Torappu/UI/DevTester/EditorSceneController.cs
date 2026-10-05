using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050EE RID: 20718
	[Token(Token = "0x20050EE")]
	public class EditorSceneController : MonoBehaviour
	{
		// Token: 0x0601E9F0 RID: 125424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9F0")]
		[Address(RVA = "0x1860F10", Offset = "0x185FB10", VA = "0x181860F10")]
		private void Start()
		{
		}

		// Token: 0x0601E9F1 RID: 125425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9F1")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public EditorSceneController()
		{
		}

		// Token: 0x040290B9 RID: 168121
		[Token(Token = "0x40290B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelCharacter;

		// Token: 0x040290BA RID: 168122
		[Token(Token = "0x40290BA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelItem;

		// Token: 0x040290BB RID: 168123
		[Token(Token = "0x40290BB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CommonTopMenu _topMenu;

		// Token: 0x040290BC RID: 168124
		[Token(Token = "0x40290BC")]
		[FieldOffset(Offset = "0x30")]
		private string fromScene;
	}
}
