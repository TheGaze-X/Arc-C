using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace DG.Tweening.Core
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	public static class Debugger
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x1700000F")]
		public static int logPriority
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x374A0A0", Offset = "0x3748CA0", VA = "0x18374A0A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x3749E80", Offset = "0x3748A80", VA = "0x183749E80")]
		public static void Log(object message)
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x3749C90", Offset = "0x3748890", VA = "0x183749C90")]
		public static void LogWarning(object message, [Optional] Tween t)
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x37493E0", Offset = "0x3747FE0", VA = "0x1837493E0")]
		public static void LogError(object message, [Optional] Tween t)
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x3749900", Offset = "0x3748500", VA = "0x183749900")]
		public static void LogSafeModeCapturedError(object message, [Optional] Tween t)
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x37497F0", Offset = "0x37483F0", VA = "0x1837497F0")]
		public static void LogReport(object message)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x3749B80", Offset = "0x3748780", VA = "0x183749B80")]
		public static void LogSafeModeReport(object message)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x37495D0", Offset = "0x37481D0", VA = "0x1837495D0")]
		public static void LogInvalidTween(Tween t)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x37496D0", Offset = "0x37482D0", VA = "0x1837496D0")]
		public static void LogNestedTween(Tween t)
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x3749750", Offset = "0x3748350", VA = "0x183749750")]
		public static void LogNullTween(Tween t)
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x3749710", Offset = "0x3748310", VA = "0x183749710")]
		public static void LogNonPathTween(Tween t)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x3749610", Offset = "0x3748210", VA = "0x183749610")]
		public static void LogMissingMaterialProperty(string propertyName)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x3749660", Offset = "0x3748260", VA = "0x183749660")]
		public static void LogMissingMaterialProperty(int propertyId)
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x3749790", Offset = "0x3748390", VA = "0x183749790")]
		public static void LogRemoveActiveTweenError(string errorInfo, Tween t)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x3749380", Offset = "0x3747F80", VA = "0x183749380")]
		public static void LogAddActiveTweenError(string errorInfo, Tween t)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x3749FB0", Offset = "0x3748BB0", VA = "0x183749FB0")]
		public static void SetLogPriority(LogBehaviour logBehaviour)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x374A010", Offset = "0x3748C10", VA = "0x18374A010")]
		public static bool ShouldLogSafeModeCapturedError()
		{
			return default(bool);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x3749330", Offset = "0x3747F30", VA = "0x183749330")]
		private static string GetDebugDataMessage(Tween t)
		{
			return null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x3749160", Offset = "0x3747D60", VA = "0x183749160")]
		private static void AddDebugDataToMessage(ref string message, Tween t)
		{
		}

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _logPriority;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN ► </b></color>";

		// Token: 0x020000A4 RID: 164
		[Token(Token = "0x20000A4")]
		internal static class Sequence
		{
			// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x3754390", Offset = "0x3752F90", VA = "0x183754390")]
			public static void LogAddToNullSequence()
			{
			}

			// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x3754310", Offset = "0x3752F10", VA = "0x183754310")]
			public static void LogAddToInactiveSequence()
			{
			}

			// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x3754350", Offset = "0x3752F50", VA = "0x183754350")]
			public static void LogAddToLockedSequence()
			{
			}

			// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x37542D0", Offset = "0x3752ED0", VA = "0x1837542D0")]
			public static void LogAddNullTween()
			{
			}

			// Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x3754290", Offset = "0x3752E90", VA = "0x183754290")]
			public static void LogAddInactiveTween(Tween t)
			{
			}

			// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x3754250", Offset = "0x3752E50", VA = "0x183754250")]
			public static void LogAddAlreadySequencedTween(Tween t)
			{
			}
		}
	}
}
