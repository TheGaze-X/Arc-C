using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005228 RID: 21032
	[Token(Token = "0x2005228")]
	public abstract class RoguelikeTopicDialogPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F084 RID: 127108
		[Token(Token = "0x601F084")]
		public abstract KeyValuePair<string, RoguelikeDialogMgr> GetDialogMgr();

		// Token: 0x0601F085 RID: 127109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F085")]
		[Address(RVA = "0x18C3100", Offset = "0x18C1D00", VA = "0x1818C3100")]
		protected RoguelikeTopicDialogPlugin()
		{
		}

		// Token: 0x04029A28 RID: 170536
		[Token(Token = "0x4029A28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
