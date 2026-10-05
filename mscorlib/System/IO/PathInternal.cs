using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000650 RID: 1616
	[Token(Token = "0x2000650")]
	internal static class PathInternal
	{
		// Token: 0x06003077 RID: 12407 RVA: 0x0001A3E8 File Offset: 0x000185E8
		[Token(Token = "0x6003077")]
		[Address(RVA = "0x4C809D0", Offset = "0x4C7F5D0", VA = "0x184C809D0")]
		internal static bool IsValidDriveChar(char value)
		{
			return default(bool);
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x0001A400 File Offset: 0x00018600
		[Token(Token = "0x6003078")]
		[Address(RVA = "0x4C7FE20", Offset = "0x4C7EA20", VA = "0x184C7FE20")]
		internal static bool EndsWithPeriodOrSpace(string path)
		{
			return default(bool);
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003079")]
		[Address(RVA = "0x4C7FE80", Offset = "0x4C7EA80", VA = "0x184C7FE80")]
		internal static string EnsureExtendedPrefixIfNeeded(string path)
		{
			return null;
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600307A")]
		[Address(RVA = "0x4C7FF30", Offset = "0x4C7EB30", VA = "0x184C7FF30")]
		internal static string EnsureExtendedPrefix(string path)
		{
			return null;
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x0001A418 File Offset: 0x00018618
		[Token(Token = "0x600307B")]
		[Address(RVA = "0x4C80700", Offset = "0x4C7F300", VA = "0x184C80700")]
		internal static bool IsDevice(System.ReadOnlySpan<char> path)
		{
			return default(bool);
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x0001A430 File Offset: 0x00018630
		[Token(Token = "0x600307C")]
		[Address(RVA = "0x4C80630", Offset = "0x4C7F230", VA = "0x184C80630")]
		internal static bool IsDeviceUNC(System.ReadOnlySpan<char> path)
		{
			return default(bool);
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x0001A448 File Offset: 0x00018648
		[Token(Token = "0x600307D")]
		[Address(RVA = "0x4C808E0", Offset = "0x4C7F4E0", VA = "0x184C808E0")]
		internal static bool IsExtended(System.ReadOnlySpan<char> path)
		{
			return default(bool);
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x0001A460 File Offset: 0x00018660
		[Token(Token = "0x600307E")]
		[Address(RVA = "0x4C80250", Offset = "0x4C7EE50", VA = "0x184C80250")]
		internal static int GetRootLength(System.ReadOnlySpan<char> path)
		{
			return 0;
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x0001A478 File Offset: 0x00018678
		[Token(Token = "0x600307F")]
		[Address(RVA = "0x4C808C0", Offset = "0x4C7F4C0", VA = "0x184C808C0")]
		[MethodImpl(256)]
		internal static bool IsDirectorySeparator(char c)
		{
			return default(bool);
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x0001A490 File Offset: 0x00018690
		[Token(Token = "0x6003080")]
		[Address(RVA = "0x4C7FD90", Offset = "0x4C7E990", VA = "0x184C7FD90")]
		internal static bool EndsInDirectorySeparator(System.ReadOnlySpan<char> path)
		{
			return default(bool);
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x0001A4A8 File Offset: 0x000186A8
		[Token(Token = "0x6003081")]
		[Address(RVA = "0x4C809F0", Offset = "0x4C7F5F0", VA = "0x184C809F0")]
		internal static bool StartsWithDirectorySeparator(System.ReadOnlySpan<char> path)
		{
			return default(bool);
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003082")]
		[Address(RVA = "0x4C80A70", Offset = "0x4C7F670", VA = "0x184C80A70")]
		internal static string TrimEndingDirectorySeparator(string path)
		{
			return null;
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x0001A4C0 File Offset: 0x000186C0
		[Token(Token = "0x6003083")]
		[Address(RVA = "0x4C80C70", Offset = "0x4C7F870", VA = "0x184C80C70")]
		internal static System.ReadOnlySpan<char> TrimEndingDirectorySeparator(System.ReadOnlySpan<char> path)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x0001A4D8 File Offset: 0x000186D8
		[Token(Token = "0x6003084")]
		[Address(RVA = "0x4C80960", Offset = "0x4C7F560", VA = "0x184C80960")]
		internal static bool IsRoot(System.ReadOnlySpan<char> path)
		{
			return default(bool);
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x0001A4F0 File Offset: 0x000186F0
		[Token(Token = "0x170007CC")]
		internal static bool IsCaseSensitive
		{
			[Token(Token = "0x6003085")]
			[Address(RVA = "0x4C80E70", Offset = "0x4C7FA70", VA = "0x184C80E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x0001A508 File Offset: 0x00018708
		[Token(Token = "0x6003086")]
		[Address(RVA = "0x4C80080", Offset = "0x4C7EC80", VA = "0x184C80080")]
		private static bool GetIsCaseSensitive()
		{
			return default(bool);
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x0001A520 File Offset: 0x00018720
		[Token(Token = "0x6003087")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public static bool IsPartiallyQualified(string path)
		{
			return default(bool);
		}

		// Token: 0x04001ACA RID: 6858
		[Token(Token = "0x4001ACA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool s_isCaseSensitive;
	}
}
