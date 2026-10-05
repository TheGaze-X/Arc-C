using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200286F RID: 10351
	[Token(Token = "0x200286F")]
	public static class ParamOutputExtensions
	{
		// Token: 0x0601137A RID: 70522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601137A")]
		public static void SetValue<T>(this ParamOutput<T> param, T value)
		{
		}

		// Token: 0x0601137B RID: 70523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601137B")]
		public static T GetValue<T>(this ParamOutput<T> param, [Optional] T defaultValue, bool showWarning = true)
		{
			return null;
		}

		// Token: 0x0601137C RID: 70524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601137C")]
		public static List<T> GetValue<T>(this ParamOutput<List<T>> param, [Optional] List<T> defaultValue, bool showWarning = true)
		{
			return null;
		}

		// Token: 0x0601137D RID: 70525 RVA: 0x0006A1D0 File Offset: 0x000683D0
		[Token(Token = "0x601137D")]
		public static bool TryGetValue<T>(this ParamOutput<T> param, out T result, bool showWarning = true)
		{
			return default(bool);
		}

		// Token: 0x0601137E RID: 70526 RVA: 0x0006A1E8 File Offset: 0x000683E8
		[Token(Token = "0x601137E")]
		public static bool TryGetValue<T>(this ParamOutput<List<T>> param, out List<T> result, bool showWarning = true)
		{
			return default(bool);
		}
	}
}
