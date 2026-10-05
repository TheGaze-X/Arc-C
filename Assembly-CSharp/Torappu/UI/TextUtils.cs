using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003483 RID: 13443
	[Token(Token = "0x2003483")]
	[LuaCallCSharp(GenFlag.No)]
	[Hotfix(HotfixFlag.Stateless)]
	public class TextUtils
	{
		// Token: 0x06015729 RID: 87849 RVA: 0x0008BF50 File Offset: 0x0008A150
		[Token(Token = "0x6015729")]
		[Address(RVA = "0xDECF00", Offset = "0xDEBB00", VA = "0x180DECF00")]
		public static float CalcTextHeight(Text text, string content, ref TextGenerator textGenerate)
		{
			return 0f;
		}

		// Token: 0x0601572A RID: 87850 RVA: 0x0008BF68 File Offset: 0x0008A168
		[Token(Token = "0x601572A")]
		[Address(RVA = "0xDED100", Offset = "0xDEBD00", VA = "0x180DED100")]
		public static float CalcTextWeight(Text text, string content, ref TextGenerator textGenerate)
		{
			return 0f;
		}

		// Token: 0x0601572B RID: 87851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601572B")]
		[Address(RVA = "0xDED300", Offset = "0xDEBF00", VA = "0x180DED300")]
		public TextUtils()
		{
		}

		// Token: 0x04019AD1 RID: 105169
		[Token(Token = "0x4019AD1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CalcTextHeight;

		// Token: 0x04019AD2 RID: 105170
		[Token(Token = "0x4019AD2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CalcTextWeight;

		// Token: 0x04019AD3 RID: 105171
		[Token(Token = "0x4019AD3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
