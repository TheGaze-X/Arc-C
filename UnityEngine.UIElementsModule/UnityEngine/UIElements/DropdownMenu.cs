using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class DropdownMenu
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
		public List<DropdownMenuItem> MenuItems()
		{
			return null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x5A2BE70", Offset = "0x5A2AA70", VA = "0x185A2BE70")]
		public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, [Optional] object userData)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x5A2BF60", Offset = "0x5A2AB60", VA = "0x185A2BF60")]
		public void InsertSeparator(string subMenuPath, int atIndex)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x5A2C0D0", Offset = "0x5A2ACD0", VA = "0x185A2C0D0")]
		public void PrepareForDisplay(EventBase e)
		{
		}

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<DropdownMenuItem> m_MenuItems;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DropdownMenuEventInfo m_DropdownMenuEventInfo;
	}
}
