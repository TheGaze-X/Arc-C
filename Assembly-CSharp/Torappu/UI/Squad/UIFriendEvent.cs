using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DCE RID: 15822
	[Token(Token = "0x2003DCE")]
	[Serializable]
	public class UIFriendEvent : UnityEvent<SquadAssistData, bool>
	{
		// Token: 0x060189CE RID: 100814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189CE")]
		[Address(RVA = "0x1134FF0", Offset = "0x1133BF0", VA = "0x181134FF0")]
		public void Callback(SquadAssistData param, bool isFriend)
		{
		}

		// Token: 0x060189CF RID: 100815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189CF")]
		[Address(RVA = "0x1135050", Offset = "0x1133C50", VA = "0x181135050")]
		public UIFriendEvent()
		{
		}
	}
}
