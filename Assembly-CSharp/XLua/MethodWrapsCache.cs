using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x020002CF RID: 719
	[Token(Token = "0x20002CF")]
	public class MethodWrapsCache
	{
		// Token: 0x06003732 RID: 14130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003732")]
		[Address(RVA = "0x3447BD0", Offset = "0x34467D0", VA = "0x183447BD0")]
		public MethodWrapsCache(ObjectTranslator translator, ObjectCheckers objCheckers, ObjectCasters objCasters)
		{
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003733")]
		[Address(RVA = "0x34468E0", Offset = "0x34454E0", VA = "0x1834468E0")]
		public lua_CSFunction GetConstructorWrap(Type type)
		{
			return null;
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003734")]
		[Address(RVA = "0x3447550", Offset = "0x3446150", VA = "0x183447550")]
		public lua_CSFunction GetMethodWrap(Type type, string methodName)
		{
			return null;
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003735")]
		[Address(RVA = "0x34473F0", Offset = "0x3445FF0", VA = "0x1834473F0")]
		public lua_CSFunction GetMethodWrapInCache(Type type, string methodName)
		{
			return null;
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003736")]
		[Address(RVA = "0x3446CA0", Offset = "0x34458A0", VA = "0x183446CA0")]
		public lua_CSFunction GetDelegateWrap(Type type)
		{
			return null;
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003737")]
		[Address(RVA = "0x3446F20", Offset = "0x3445B20", VA = "0x183446F20")]
		public lua_CSFunction GetEventWrap(Type type, string eventName)
		{
			return null;
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003738")]
		[Address(RVA = "0x34477E0", Offset = "0x34463E0", VA = "0x1834477E0")]
		public MethodWrap _GenMethodWrap(Type type, string methodName, IEnumerable<MemberInfo> methodBases, bool forceCheck = false)
		{
			return null;
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x00016638 File Offset: 0x00014838
		[Token(Token = "0x6003739")]
		[Address(RVA = "0x3447D30", Offset = "0x3446930", VA = "0x183447D30")]
		private static bool tryMakeGenericMethod(ref MethodBase method)
		{
			return default(bool);
		}

		// Token: 0x04000D40 RID: 3392
		[Token(Token = "0x4000D40")]
		[FieldOffset(Offset = "0x10")]
		private ObjectTranslator translator;

		// Token: 0x04000D41 RID: 3393
		[Token(Token = "0x4000D41")]
		[FieldOffset(Offset = "0x18")]
		private ObjectCheckers objCheckers;

		// Token: 0x04000D42 RID: 3394
		[Token(Token = "0x4000D42")]
		[FieldOffset(Offset = "0x20")]
		private ObjectCasters objCasters;

		// Token: 0x04000D43 RID: 3395
		[Token(Token = "0x4000D43")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Type, lua_CSFunction> constructorCache;

		// Token: 0x04000D44 RID: 3396
		[Token(Token = "0x4000D44")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Type, Dictionary<string, lua_CSFunction>> methodsCache;

		// Token: 0x04000D45 RID: 3397
		[Token(Token = "0x4000D45")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Type, lua_CSFunction> delegateCache;
	}
}
