using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001F18 RID: 7960
	[Token(Token = "0x2001F18")]
	public class TutorialObjectHolder : MonoBehaviour
	{
		// Token: 0x0600C583 RID: 50563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C583")]
		[Address(RVA = "0x3473040", Offset = "0x3471C40", VA = "0x183473040")]
		public void SetTutorialInvolved(bool enabled)
		{
		}

		// Token: 0x0600C584 RID: 50564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C584")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public TutorialObjectHolder()
		{
		}

		// Token: 0x0400CA48 RID: 51784
		[Token(Token = "0x400CA48")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _tutorialObjs;
	}
}
