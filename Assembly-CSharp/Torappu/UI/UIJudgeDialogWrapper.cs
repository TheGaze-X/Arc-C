using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003914 RID: 14612
	[Token(Token = "0x2003914")]
	[LuaCallCSharp(GenFlag.No)]
	public static class UIJudgeDialogWrapper
	{
		// Token: 0x0601718E RID: 94606 RVA: 0x00094DD0 File Offset: 0x00092FD0
		[Token(Token = "0x601718E")]
		[Address(RVA = "0xF761F0", Offset = "0xF74DF0", VA = "0x180F761F0")]
		public static bool IsNoNextTimeChecked(string param)
		{
			return default(bool);
		}

		// Token: 0x0601718F RID: 94607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601718F")]
		[Address(RVA = "0xF765C0", Offset = "0xF751C0", VA = "0x180F765C0")]
		public static void SetNoNextTimeChecked(string param)
		{
		}

		// Token: 0x06017190 RID: 94608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017190")]
		[Address(RVA = "0xF76210", Offset = "0xF74E10", VA = "0x180F76210")]
		public static UIJudgeDialog OpenSimpleNoNextTimeCheckJudgeDialog(string desc, Action onPositive, string checkParam)
		{
			return null;
		}
	}
}
