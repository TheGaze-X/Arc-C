using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Torappu.UI
{
	// Token: 0x0200347D RID: 13437
	[Token(Token = "0x200347D")]
	public class FullScreenScrollListener
	{
		// Token: 0x06015708 RID: 87816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015708")]
		[Address(RVA = "0xDEA1C0", Offset = "0xDE8DC0", VA = "0x180DEA1C0")]
		private void OnHandlerFullScreenScroll(PointerEventData eventData)
		{
		}

		// Token: 0x06015709 RID: 87817 RVA: 0x0008BF38 File Offset: 0x0008A138
		[Token(Token = "0x6015709")]
		[Address(RVA = "0xDEA2C0", Offset = "0xDE8EC0", VA = "0x180DEA2C0")]
		private bool _CheckScrollAvail(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x0601570A RID: 87818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601570A")]
		[Address(RVA = "0xDEA3D0", Offset = "0xDE8FD0", VA = "0x180DEA3D0")]
		public FullScreenScrollListener(Action<PointerEventData> onTrigger, [Optional] GameObject content)
		{
		}

		// Token: 0x0601570B RID: 87819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601570B")]
		[Address(RVA = "0xDEA0A0", Offset = "0xDE8CA0", VA = "0x180DEA0A0")]
		public void Clear()
		{
		}

		// Token: 0x04019AB3 RID: 105139
		[Token(Token = "0x4019AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Action<PointerEventData> m_onTrigger;

		// Token: 0x04019AB4 RID: 105140
		[Token(Token = "0x4019AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject m_content;
	}
}
