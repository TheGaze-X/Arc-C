using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200286C RID: 10348
	[Token(Token = "0x200286C")]
	public static class ParamExtensions
	{
		// Token: 0x06011363 RID: 70499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011363")]
		public static T GetValue<T>(this Param<T> param, [Optional] T defaultValue, bool showWarning = true)
		{
			return null;
		}

		// Token: 0x06011364 RID: 70500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011364")]
		[Address(RVA = "0x919880", Offset = "0x918480", VA = "0x180919880")]
		public static void DeepCopyAllParamValue(this ParamBlackboard a, ParamBlackboard b)
		{
		}

		// Token: 0x06011365 RID: 70501 RVA: 0x0006A140 File Offset: 0x00068340
		[Token(Token = "0x6011365")]
		public static bool TryGetValue<T>(this Param<T> param, out T result, bool showWarning = true)
		{
			return default(bool);
		}
	}
}
