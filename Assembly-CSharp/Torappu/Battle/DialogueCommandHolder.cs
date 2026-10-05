using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200262B RID: 9771
	[Token(Token = "0x200262B")]
	[CreateAssetMenu(menuName = "Torappu/Level/Dialogue Command Holder")]
	public class DialogueCommandHolder : ScriptableObject
	{
		// Token: 0x0600FFDF RID: 65503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFDF")]
		[Address(RVA = "0x77BC80", Offset = "0x77A880", VA = "0x18077BC80")]
		public Dictionary<string, DialogueActionCommand> GetCommandDic()
		{
			return null;
		}

		// Token: 0x0600FFE0 RID: 65504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFE0")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public DialogueCommandHolder()
		{
		}

		// Token: 0x04011C2E RID: 72750
		[Token(Token = "0x4011C2E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<DialogueActionCommand> _actionCommands;
	}
}
