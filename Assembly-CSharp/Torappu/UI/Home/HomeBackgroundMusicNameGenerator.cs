using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BFE RID: 19454
	[Token(Token = "0x2004BFE")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class HomeBackgroundMusicNameGenerator
	{
		// Token: 0x0601D3B0 RID: 119728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D3B0")]
		[Address(RVA = "0x16C95E0", Offset = "0x16C81E0", VA = "0x1816C95E0")]
		public static string GenMusicName(List<HomeBackgroundMultiFormData> multiFormList, string textPre, string textSplit)
		{
			return null;
		}

		// Token: 0x0601D3B1 RID: 119729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D3B1")]
		[Address(RVA = "0x16C99A0", Offset = "0x16C85A0", VA = "0x1816C99A0")]
		private static string _GetMusicName(string musicId)
		{
			return null;
		}

		// Token: 0x04026680 RID: 157312
		[Token(Token = "0x4026680")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenMusicName;

		// Token: 0x04026681 RID: 157313
		[Token(Token = "0x4026681")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetMusicName;
	}
}
