using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DB
{
	// Token: 0x02001682 RID: 5762
	[Token(Token = "0x2001682")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ConverterFactory
	{
		// Token: 0x06009221 RID: 37409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009221")]
		[Address(RVA = "0x2B2D550", Offset = "0x2B2C150", VA = "0x182B2D550")]
		public static IConverter Create(ConverterFactory.ConverterType converterType)
		{
			return null;
		}

		// Token: 0x06009222 RID: 37410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009222")]
		[Address(RVA = "0x2B2DA60", Offset = "0x2B2C660", VA = "0x182B2DA60")]
		public static string GetTypeHash(ConverterFactory.ConverterType converterType, ConverterFactory.TypeMeta meta)
		{
			return null;
		}

		// Token: 0x04008803 RID: 34819
		[Token(Token = "0x4008803")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04008804 RID: 34820
		[Token(Token = "0x4008804")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTypeHash;

		// Token: 0x02001683 RID: 5763
		[Token(Token = "0x2001683")]
		public enum ConverterType
		{
			// Token: 0x04008806 RID: 34822
			[Token(Token = "0x4008806")]
			JSON_DOT_NET,
			// Token: 0x04008807 RID: 34823
			[Token(Token = "0x4008807")]
			BSON_DOT_NET,
			// Token: 0x04008808 RID: 34824
			[Token(Token = "0x4008808")]
			CRYPTIC_A,
			// Token: 0x04008809 RID: 34825
			[Token(Token = "0x4008809")]
			CRYPTIC_B,
			// Token: 0x0400880A RID: 34826
			[Token(Token = "0x400880A")]
			CRYPTIC_WITH_SIGN,
			// Token: 0x0400880B RID: 34827
			[Token(Token = "0x400880B")]
			BSON_CRYPTIC_WITH_SIGN,
			// Token: 0x0400880C RID: 34828
			[Token(Token = "0x400880C")]
			BSON_WITH_SIGN,
			// Token: 0x0400880D RID: 34829
			[Token(Token = "0x400880D")]
			FLAT_BUFFER,
			// Token: 0x0400880E RID: 34830
			[Token(Token = "0x400880E")]
			UNITY_SERIALIZER_BSON,
			// Token: 0x0400880F RID: 34831
			[Token(Token = "0x400880F")]
			UNITY_SERIALIZER_JSON
		}

		// Token: 0x02001684 RID: 5764
		[Token(Token = "0x2001684")]
		public struct TypeMeta
		{
			// Token: 0x04008810 RID: 34832
			[Token(Token = "0x4008810")]
			[FieldOffset(Offset = "0x0")]
			public Type dataType;
		}
	}
}
