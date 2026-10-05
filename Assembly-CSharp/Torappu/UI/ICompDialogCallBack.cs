using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003A69 RID: 14953
	[Token(Token = "0x2003A69")]
	public interface ICompDialogCallBack
	{
		// Token: 0x06017A59 RID: 96857
		[Token(Token = "0x6017A59")]
		void HandleCallBack(int instId, ValueBundle output);

		// Token: 0x06017A5A RID: 96858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017A5A")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "1")]
		CustomYieldInstruction HandleCallBackAsync(int instId, ValueBundle output)
		{
			return null;
		}
	}
}
