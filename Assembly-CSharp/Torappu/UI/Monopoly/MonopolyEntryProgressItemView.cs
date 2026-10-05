using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047E5 RID: 18405
	[Token(Token = "0x20047E5")]
	public class MonopolyEntryProgressItemView : MonoBehaviour
	{
		// Token: 0x0601BD79 RID: 114041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD79")]
		[Address(RVA = "0x15248A0", Offset = "0x15234A0", VA = "0x1815248A0")]
		public void Render(MonopolyEntryStageModel model, bool isSelect)
		{
		}

		// Token: 0x0601BD7A RID: 114042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD7A")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MonopolyEntryProgressItemView()
		{
		}

		// Token: 0x040243B2 RID: 148402
		[Token(Token = "0x40243B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _lockPanel;

		// Token: 0x040243B3 RID: 148403
		[Token(Token = "0x40243B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _completePanel;

		// Token: 0x040243B4 RID: 148404
		[Token(Token = "0x40243B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _currentPanel;

		// Token: 0x040243B5 RID: 148405
		[Token(Token = "0x40243B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x040243B6 RID: 148406
		[Token(Token = "0x40243B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _newObj;
	}
}
