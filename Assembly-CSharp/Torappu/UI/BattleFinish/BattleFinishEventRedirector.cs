using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006204 RID: 25092
	[Token(Token = "0x2006204")]
	public class BattleFinishEventRedirector : MonoBehaviour
	{
		// Token: 0x0602434E RID: 148302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602434E")]
		[Address(RVA = "0x1F143F0", Offset = "0x1F12FF0", VA = "0x181F143F0")]
		public void UpLevel()
		{
		}

		// Token: 0x0602434F RID: 148303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602434F")]
		[Address(RVA = "0x1F143F0", Offset = "0x1F12FF0", VA = "0x181F143F0")]
		private void _SendMessageToReceiver(int msg)
		{
		}

		// Token: 0x06024350 RID: 148304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024350")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BattleFinishEventRedirector()
		{
		}

		// Token: 0x04032572 RID: 206194
		[Token(Token = "0x4032572")]
		public const int EVT_LEVEL_UP = 1;

		// Token: 0x04032573 RID: 206195
		[Token(Token = "0x4032573")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Component _receiver;
	}
}
