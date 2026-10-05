using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B49 RID: 19273
	[Token(Token = "0x2004B49")]
	public static class HomeDisplayMultiFormRawDataLoader
	{
		// Token: 0x0601D076 RID: 118902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D076")]
		[Address(RVA = "0x1671480", Offset = "0x1670080", VA = "0x181671480")]
		public static HomeDisplayMultiFormRawData Load(MultiFormLoadParam param)
		{
			return null;
		}

		// Token: 0x0601D077 RID: 118903 RVA: 0x000AA0B8 File Offset: 0x000A82B8
		[Token(Token = "0x601D077")]
		[Address(RVA = "0x16715E0", Offset = "0x16701E0", VA = "0x1816715E0")]
		public static HomeMultiFormChangeRule QueryRule(MultiFormLoadParam param)
		{
			return HomeMultiFormChangeRule.NONE;
		}

		// Token: 0x0601D078 RID: 118904 RVA: 0x000AA0D0 File Offset: 0x000A82D0
		[Token(Token = "0x601D078")]
		[Address(RVA = "0x1671330", Offset = "0x166FF30", VA = "0x181671330")]
		public static bool IsMultiForm(MultiFormLoadParam param)
		{
			return default(bool);
		}

		// Token: 0x0402614C RID: 155980
		[Token(Token = "0x402614C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, IHomeDisplayMultiFormRawDataLoader> _loaders;
	}
}
