using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Prime31.Reflection
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public class CacheResolver
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x4E03810", Offset = "0x4E02410", VA = "0x184E03810")]
		public CacheResolver(MemberMapLoader memberMapLoader)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x4E03C60", Offset = "0x4E02860", VA = "0x184E03C60")]
		public static object getNewInstance(Type type)
		{
			return null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4E03F20", Offset = "0x4E02B20", VA = "0x184E03F20")]
		public SafeDictionary<string, CacheResolver.MemberMap> loadMaps(Type type)
		{
			return null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x4E038B0", Offset = "0x4E024B0", VA = "0x184E038B0")]
		private static GetHandler createGetHandler(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4E03A60", Offset = "0x4E02660", VA = "0x184E03A60")]
		private static SetHandler createSetHandler(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4E03960", Offset = "0x4E02560", VA = "0x184E03960")]
		private static GetHandler createGetHandler(PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4E03B60", Offset = "0x4E02760", VA = "0x184E03B60")]
		private static SetHandler createSetHandler(PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x10")]
		private readonly MemberMapLoader _memberMapLoader;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x18")]
		private readonly SafeDictionary<Type, SafeDictionary<string, CacheResolver.MemberMap>> _memberMapsCache;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SafeDictionary<Type, CacheResolver.CtorDelegate> constructorCache;

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x0600010C RID: 268
		[Token(Token = "0x200002B")]
		private delegate object CtorDelegate();

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		public sealed class MemberMap
		{
			// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x4E076A0", Offset = "0x4E062A0", VA = "0x184E076A0")]
			public MemberMap(PropertyInfo propertyInfo)
			{
			}

			// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x4E07470", Offset = "0x4E06070", VA = "0x184E07470")]
			public MemberMap(FieldInfo fieldInfo)
			{
			}

			// Token: 0x0400007A RID: 122
			[Token(Token = "0x400007A")]
			[FieldOffset(Offset = "0x10")]
			public readonly MemberInfo MemberInfo;

			// Token: 0x0400007B RID: 123
			[Token(Token = "0x400007B")]
			[FieldOffset(Offset = "0x18")]
			public readonly Type Type;

			// Token: 0x0400007C RID: 124
			[Token(Token = "0x400007C")]
			[FieldOffset(Offset = "0x20")]
			public readonly GetHandler Getter;

			// Token: 0x0400007D RID: 125
			[Token(Token = "0x400007D")]
			[FieldOffset(Offset = "0x28")]
			public readonly SetHandler Setter;
		}
	}
}
