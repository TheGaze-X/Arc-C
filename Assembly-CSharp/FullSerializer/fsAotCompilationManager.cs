using System;
using System.Collections.Generic;
using FullSerializer.Internal;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B64 RID: 31588
	[Token(Token = "0x2007B64")]
	public class fsAotCompilationManager
	{
		// Token: 0x17006792 RID: 26514
		// (get) Token: 0x0602C35E RID: 181086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006792")]
		public static Dictionary<Type, string> AvailableAotCompilations
		{
			[Token(Token = "0x602C35E")]
			[Address(RVA = "0x2820F50", Offset = "0x281FB50", VA = "0x182820F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C35F RID: 181087 RVA: 0x000DE630 File Offset: 0x000DC830
		[Token(Token = "0x602C35F")]
		[Address(RVA = "0x2820BC0", Offset = "0x281F7C0", VA = "0x182820BC0")]
		public static bool TryToPerformAotCompilation(fsConfig config, Type type, out string aotCompiledClassInCSharp)
		{
			return default(bool);
		}

		// Token: 0x0602C360 RID: 181088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C360")]
		[Address(RVA = "0x281F710", Offset = "0x281E310", VA = "0x18281F710")]
		public static void AddAotCompilation(Type type, fsMetaProperty[] members, bool isConstructorPublic)
		{
		}

		// Token: 0x0602C361 RID: 181089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C361")]
		[Address(RVA = "0x2820B10", Offset = "0x281F710", VA = "0x182820B10")]
		private static string GetConverterString(fsMetaProperty member)
		{
			return null;
		}

		// Token: 0x0602C362 RID: 181090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C362")]
		[Address(RVA = "0x281F860", Offset = "0x281E460", VA = "0x18281F860")]
		private static string GenerateDirectConverterForTypeInCSharp(Type type, fsMetaProperty[] members, bool isConstructorPublic)
		{
			return null;
		}

		// Token: 0x0602C363 RID: 181091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C363")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsAotCompilationManager()
		{
		}

		// Token: 0x04040185 RID: 262533
		[Token(Token = "0x4040185")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, string> _computedAotCompilations;

		// Token: 0x04040186 RID: 262534
		[Token(Token = "0x4040186")]
		[FieldOffset(Offset = "0x8")]
		private static List<fsAotCompilationManager.AotCompilation> _uncomputedAotCompilations;

		// Token: 0x02007B65 RID: 31589
		[Token(Token = "0x2007B65")]
		private struct AotCompilation
		{
			// Token: 0x04040187 RID: 262535
			[Token(Token = "0x4040187")]
			[FieldOffset(Offset = "0x0")]
			public Type Type;

			// Token: 0x04040188 RID: 262536
			[Token(Token = "0x4040188")]
			[FieldOffset(Offset = "0x8")]
			public fsMetaProperty[] Members;

			// Token: 0x04040189 RID: 262537
			[Token(Token = "0x4040189")]
			[FieldOffset(Offset = "0x10")]
			public bool IsConstructorPublic;
		}
	}
}
