using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x020002EB RID: 747
	[Token(Token = "0x20002EB")]
	public static class Utils
	{
		// Token: 0x060037B2 RID: 14258 RVA: 0x000169F8 File Offset: 0x00014BF8
		[Token(Token = "0x60037B2")]
		[Address(RVA = "0x3457220", Offset = "0x3455E20", VA = "0x183457220")]
		public static bool LoadField(IntPtr L, int idx, string field_name)
		{
			return default(bool);
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x00016A10 File Offset: 0x00014C10
		[Token(Token = "0x60037B3")]
		[Address(RVA = "0x3455AF0", Offset = "0x34546F0", VA = "0x183455AF0")]
		public static IntPtr GetMainState(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037B4")]
		[Address(RVA = "0x3454B40", Offset = "0x3453740", VA = "0x183454B40")]
		public static List<Type> GetAllTypes(bool exclude_generic_definition = true)
		{
			return null;
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037B5")]
		[Address(RVA = "0x3459030", Offset = "0x3457C30", VA = "0x183459030")]
		private static lua_CSFunction genFieldGetter(Type type, FieldInfo field)
		{
			return null;
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037B6")]
		[Address(RVA = "0x3459140", Offset = "0x3457D40", VA = "0x183459140")]
		private static lua_CSFunction genFieldSetter(Type type, FieldInfo field)
		{
			return null;
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037B7")]
		[Address(RVA = "0x3459250", Offset = "0x3457E50", VA = "0x183459250")]
		private static lua_CSFunction genItemGetter(Type type, PropertyInfo[] props)
		{
			return null;
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037B8")]
		[Address(RVA = "0x3459640", Offset = "0x3458240", VA = "0x183459640")]
		private static lua_CSFunction genItemSetter(Type type, PropertyInfo[] props)
		{
			return null;
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037B9")]
		[Address(RVA = "0x3458F80", Offset = "0x3457B80", VA = "0x183458F80")]
		private static lua_CSFunction genEnumCastFrom(Type type)
		{
			return null;
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037BA")]
		[Address(RVA = "0x3454D40", Offset = "0x3453940", VA = "0x183454D40")]
		internal static IEnumerable<MethodInfo> GetExtensionMethodsOf(Type type_to_be_extend)
		{
			return null;
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BB")]
		[Address(RVA = "0x345A160", Offset = "0x3458D60", VA = "0x18345A160")]
		private static void makeReflectionWrap(IntPtr L, Type type, int cls_field, int cls_getter, int cls_setter, int obj_field, int obj_getter, int obj_setter, int obj_meta, out lua_CSFunction item_getter, out lua_CSFunction item_setter, BindingFlags access)
		{
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BC")]
		[Address(RVA = "0x3459E70", Offset = "0x3458A70", VA = "0x183459E70")]
		public static void loadUpvalue(IntPtr L, Type type, string metafunc, int num)
		{
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BD")]
		[Address(RVA = "0x3457450", Offset = "0x3456050", VA = "0x183457450")]
		public static void MakePrivateAccessible(IntPtr L, Type type)
		{
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x00016A28 File Offset: 0x00014C28
		[Token(Token = "0x60037BE")]
		[Address(RVA = "0x3456430", Offset = "0x3455030", VA = "0x183456430")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LazyReflectionCall(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BF")]
		[Address(RVA = "0x3457930", Offset = "0x3456530", VA = "0x183457930")]
		public static void ReflectionWrap(IntPtr L, Type type, bool privateAccessible)
		{
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C0")]
		[Address(RVA = "0x3453EF0", Offset = "0x3452AF0", VA = "0x183453EF0")]
		public static void BeginObjectRegister(Type type, IntPtr L, ObjectTranslator translator, int meta_count, int method_count, int getter_count, int setter_count, int type_id = -1)
		{
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00016A40 File Offset: 0x00014C40
		[Token(Token = "0x60037C1")]
		[Address(RVA = "0x3458F70", Offset = "0x3457B70", VA = "0x183458F70")]
		private static int abs_idx(int top, int idx)
		{
			return 0;
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C2")]
		[Address(RVA = "0x3454630", Offset = "0x3453230", VA = "0x183454630")]
		public static void EndObjectRegister(Type type, IntPtr L, ObjectTranslator translator, lua_CSFunction csIndexer, lua_CSFunction csNewIndexer, Type base_type, lua_CSFunction arrayIndexer, lua_CSFunction arrayNewIndexer)
		{
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C3")]
		[Address(RVA = "0x3458710", Offset = "0x3457310", VA = "0x183458710")]
		public static void RegisterFunc(IntPtr L, int idx, string name, lua_CSFunction func)
		{
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C4")]
		[Address(RVA = "0x3458780", Offset = "0x3457380", VA = "0x183458780")]
		public static void RegisterLazyFunc(IntPtr L, int idx, string name, Type type, LazyMemberTypes memberType, bool isStatic)
		{
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C5")]
		[Address(RVA = "0x3458A20", Offset = "0x3457620", VA = "0x183458A20")]
		public static void RegisterObject(IntPtr L, ObjectTranslator translator, int idx, string name, object obj)
		{
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C6")]
		[Address(RVA = "0x3453D00", Offset = "0x3452900", VA = "0x183453D00")]
		public static void BeginClassRegister(Type type, IntPtr L, lua_CSFunction creator, int class_field_count, int static_getter_count, int static_setter_count)
		{
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C7")]
		[Address(RVA = "0x3454260", Offset = "0x3452E60", VA = "0x183454260")]
		public static void EndClassRegister(Type type, IntPtr L, ObjectTranslator translator)
		{
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C8")]
		[Address(RVA = "0x3459BE0", Offset = "0x34587E0", VA = "0x183459BE0")]
		private static List<string> getPathOfType(Type type)
		{
			return null;
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C9")]
		[Address(RVA = "0x34570A0", Offset = "0x3455CA0", VA = "0x1834570A0")]
		public static void LoadCSTable(IntPtr L, Type type)
		{
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CA")]
		[Address(RVA = "0x3458AA0", Offset = "0x34576A0", VA = "0x183458AA0")]
		public static void SetCSTable(IntPtr L, Type type, int cls_table)
		{
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x00016A58 File Offset: 0x00014C58
		[Token(Token = "0x60037CB")]
		[Address(RVA = "0x3455C30", Offset = "0x3454830", VA = "0x183455C30")]
		public static bool IsParamsMatch(MethodInfo delegateMethod, MethodInfo bridgeMethod)
		{
			return default(bool);
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x00016A70 File Offset: 0x00014C70
		[Token(Token = "0x60037CC")]
		[Address(RVA = "0x3456150", Offset = "0x3454D50", VA = "0x183456150")]
		public static bool IsSupportedMethod(MethodInfo method)
		{
			return default(bool);
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037CD")]
		[Address(RVA = "0x3457290", Offset = "0x3455E90", VA = "0x183457290")]
		public static MethodInfo MakeGenericMethodWithConstraints(MethodInfo method)
		{
			return null;
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037CE")]
		[Address(RVA = "0x3459A30", Offset = "0x3458630", VA = "0x183459A30")]
		private static Type getExtendedType(MethodInfo method)
		{
			return null;
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x00016A88 File Offset: 0x00014C88
		[Token(Token = "0x60037CF")]
		[Address(RVA = "0x34560A0", Offset = "0x3454CA0", VA = "0x1834560A0")]
		public static bool IsStaticPInvokeCSFunction(lua_CSFunction csFunction)
		{
			return default(bool);
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x00016AA0 File Offset: 0x00014CA0
		[Token(Token = "0x60037D0")]
		[Address(RVA = "0x3455F60", Offset = "0x3454B60", VA = "0x183455F60")]
		public static bool IsPublic(Type type)
		{
			return default(bool);
		}

		// Token: 0x04000D99 RID: 3481
		[Token(Token = "0x4000D99")]
		public const int OBJ_META_IDX = -4;

		// Token: 0x04000D9A RID: 3482
		[Token(Token = "0x4000D9A")]
		public const int METHOD_IDX = -3;

		// Token: 0x04000D9B RID: 3483
		[Token(Token = "0x4000D9B")]
		public const int GETTER_IDX = -2;

		// Token: 0x04000D9C RID: 3484
		[Token(Token = "0x4000D9C")]
		public const int SETTER_IDX = -1;

		// Token: 0x04000D9D RID: 3485
		[Token(Token = "0x4000D9D")]
		public const int CLS_IDX = -4;

		// Token: 0x04000D9E RID: 3486
		[Token(Token = "0x4000D9E")]
		public const int CLS_META_IDX = -3;

		// Token: 0x04000D9F RID: 3487
		[Token(Token = "0x4000D9F")]
		public const int CLS_GETTER_IDX = -2;

		// Token: 0x04000DA0 RID: 3488
		[Token(Token = "0x4000DA0")]
		public const int CLS_SETTER_IDX = -1;

		// Token: 0x04000DA1 RID: 3489
		[Token(Token = "0x4000DA1")]
		public const string LuaIndexsFieldName = "LuaIndexs";

		// Token: 0x04000DA2 RID: 3490
		[Token(Token = "0x4000DA2")]
		public const string LuaNewIndexsFieldName = "LuaNewIndexs";

		// Token: 0x04000DA3 RID: 3491
		[Token(Token = "0x4000DA3")]
		public const string LuaClassIndexsFieldName = "LuaClassIndexs";

		// Token: 0x04000DA4 RID: 3492
		[Token(Token = "0x4000DA4")]
		public const string LuaClassNewIndexsFieldName = "LuaClassNewIndexs";

		// Token: 0x020002EC RID: 748
		[Token(Token = "0x20002EC")]
		private struct MethodKey
		{
			// Token: 0x04000DA5 RID: 3493
			[Token(Token = "0x4000DA5")]
			[FieldOffset(Offset = "0x0")]
			public string Name;

			// Token: 0x04000DA6 RID: 3494
			[Token(Token = "0x4000DA6")]
			[FieldOffset(Offset = "0x8")]
			public bool IsStatic;
		}
	}
}
