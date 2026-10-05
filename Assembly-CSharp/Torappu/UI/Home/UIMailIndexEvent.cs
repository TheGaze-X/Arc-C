using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace Torappu.UI.Home
{
	// Token: 0x02004C32 RID: 19506
	[Token(Token = "0x2004C32")]
	[Serializable]
	public class UIMailIndexEvent : UnityEvent<HomeMailIndex>
	{
		// Token: 0x0601D4A9 RID: 119977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4A9")]
		[Address(RVA = "0x16DCD00", Offset = "0x16DB900", VA = "0x1816DCD00")]
		public void Callback(HomeMailIndex param)
		{
		}

		// Token: 0x0601D4AA RID: 119978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4AA")]
		[Address(RVA = "0x16DCD60", Offset = "0x16DB960", VA = "0x1816DCD60")]
		public UIMailIndexEvent()
		{
		}
	}
}
