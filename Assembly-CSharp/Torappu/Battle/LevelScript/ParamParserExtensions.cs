using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002874 RID: 10356
	[Token(Token = "0x2002874")]
	public static class ParamParserExtensions
	{
		// Token: 0x060113CC RID: 70604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113CC")]
		[Address(RVA = "0x922DA0", Offset = "0x9219A0", VA = "0x180922DA0")]
		public static Type GetSystemType(this ParamRealType realType)
		{
			return null;
		}

		// Token: 0x060113CD RID: 70605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113CD")]
		[Address(RVA = "0x923010", Offset = "0x921C10", VA = "0x180923010")]
		public static ParamVariable ToVariable(this ParamValue paramValue)
		{
			return null;
		}

		// Token: 0x060113CE RID: 70606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113CE")]
		[Address(RVA = "0x922EB0", Offset = "0x921AB0", VA = "0x180922EB0")]
		public static void SetRaw(this ParamValue paramValue, object value)
		{
		}

		// Token: 0x060113CF RID: 70607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113CF")]
		public static void Set<T>(this ParamValue paramValue, T value, bool force = false)
		{
		}

		// Token: 0x060113D0 RID: 70608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113D0")]
		public static void Set<T>(this ParamValue paramValue, List<T> value, bool force = false)
		{
		}

		// Token: 0x060113D1 RID: 70609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113D1")]
		public static void SetValueOfIndex<T>(this ParamValue paramValue, T value, int index)
		{
		}

		// Token: 0x060113D2 RID: 70610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113D2")]
		public static T Get<T>(this ParamValue paramValue, [Optional] T defaultValue)
		{
			return null;
		}

		// Token: 0x060113D3 RID: 70611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113D3")]
		public static T GetOrNew<T>(this ParamValue paramValue, [Optional] T defaultValue)
		{
			return null;
		}

		// Token: 0x060113D4 RID: 70612 RVA: 0x0006A3B0 File Offset: 0x000685B0
		[Token(Token = "0x60113D4")]
		public static bool TryGet<T>(this ParamValue paramValue, out T result)
		{
			return default(bool);
		}

		// Token: 0x060113D5 RID: 70613 RVA: 0x0006A3C8 File Offset: 0x000685C8
		[Token(Token = "0x60113D5")]
		public static bool TryGet<T>(this ParamValue paramValue, out List<T> result)
		{
			return default(bool);
		}

		// Token: 0x060113D6 RID: 70614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113D6")]
		public static List<T> Get<T>(this ParamValue paramValue, ref List<T> refList)
		{
			return null;
		}

		// Token: 0x060113D7 RID: 70615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113D7")]
		public static T GetListItem<T>(this ParamValue paramValue, int index, [Optional] T defaultValue, bool showWarning = false)
		{
			return null;
		}

		// Token: 0x060113D8 RID: 70616 RVA: 0x0006A3E0 File Offset: 0x000685E0
		[Token(Token = "0x60113D8")]
		public static bool TryGetListItem<T>(this ParamValue paramValue, int index, out T value, bool showWarning = false)
		{
			return default(bool);
		}

		// Token: 0x060113D9 RID: 70617 RVA: 0x0006A3F8 File Offset: 0x000685F8
		[Token(Token = "0x60113D9")]
		[MethodImpl(256)]
		public static bool Contains<T>(this T[] array, T item)
		{
			return default(bool);
		}
	}
}
