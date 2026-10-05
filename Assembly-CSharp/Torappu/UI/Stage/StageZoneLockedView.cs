using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Stage
{
	// Token: 0x0200698A RID: 27018
	[Token(Token = "0x200698A")]
	public class StageZoneLockedView : MonoBehaviour
	{
		// Token: 0x06026A98 RID: 158360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A98")]
		[Address(RVA = "0xD231C0", Offset = "0xD21DC0", VA = "0x180D231C0")]
		public void Render(string lockedText)
		{
		}

		// Token: 0x06026A99 RID: 158361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A99")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StageZoneLockedView()
		{
		}

		// Token: 0x0403694E RID: 223566
		[Token(Token = "0x403694E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _lockedText;
	}
}
