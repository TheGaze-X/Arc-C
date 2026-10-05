using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003586 RID: 13702
	[Token(Token = "0x2003586")]
	public abstract class CommonCharCardDecoBase : MonoBehaviour
	{
		// Token: 0x06015CD9 RID: 89305
		[Token(Token = "0x6015CD9")]
		public abstract void RenderDeco(ICharacterCardViewModel characterCardViewModel);

		// Token: 0x06015CDA RID: 89306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015CDA")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected CommonCharCardDecoBase()
		{
		}
	}
}
