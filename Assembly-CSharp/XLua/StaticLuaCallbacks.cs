using System;
using Il2CppDummyDll;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x0200025E RID: 606
	[Token(Token = "0x200025E")]
	public class StaticLuaCallbacks
	{
		// Token: 0x0600353C RID: 13628 RVA: 0x000160B0 File Offset: 0x000142B0
		[Token(Token = "0x600353C")]
		[Address(RVA = "0x3330240", Offset = "0x332EE40", VA = "0x183330240")]
		internal static bool __tryArrayGet(Type type, IntPtr L, ObjectTranslator translator, object obj, int index)
		{
			return default(bool);
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x000160C8 File Offset: 0x000142C8
		[Token(Token = "0x600353D")]
		[Address(RVA = "0x33310D0", Offset = "0x332FCD0", VA = "0x1833310D0")]
		internal static bool __tryArraySet(Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx)
		{
			return default(bool);
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353E")]
		[Address(RVA = "0x3332080", Offset = "0x3330C80", VA = "0x183332080")]
		public StaticLuaCallbacks()
		{
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x000160E0 File Offset: 0x000142E0
		[Token(Token = "0x600353F")]
		[Address(RVA = "0x332C480", Offset = "0x332B080", VA = "0x18332C480")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumAnd(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x000160F8 File Offset: 0x000142F8
		[Token(Token = "0x6003540")]
		[Address(RVA = "0x332C6B0", Offset = "0x332B2B0", VA = "0x18332C6B0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumOr(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x00016110 File Offset: 0x00014310
		[Token(Token = "0x6003541")]
		[Address(RVA = "0x332E9D0", Offset = "0x332D5D0", VA = "0x18332E9D0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int StaticCSFunction(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x00016128 File Offset: 0x00014328
		[Token(Token = "0x6003542")]
		[Address(RVA = "0x332CA10", Offset = "0x332B610", VA = "0x18332CA10")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int FixCSFunction(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x00016140 File Offset: 0x00014340
		[Token(Token = "0x6003543")]
		[Address(RVA = "0x332BC30", Offset = "0x332A830", VA = "0x18332BC30")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCall(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x00016158 File Offset: 0x00014358
		[Token(Token = "0x6003544")]
		[Address(RVA = "0x332E420", Offset = "0x332D020", VA = "0x18332E420")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LuaGC(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x00016170 File Offset: 0x00014370
		[Token(Token = "0x6003545")]
		[Address(RVA = "0x332EE00", Offset = "0x332DA00", VA = "0x18332EE00")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToString(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x00016188 File Offset: 0x00014388
		[Token(Token = "0x6003546")]
		[Address(RVA = "0x332BDF0", Offset = "0x332A9F0", VA = "0x18332BDF0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCombine(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x000161A0 File Offset: 0x000143A0
		[Token(Token = "0x6003547")]
		[Address(RVA = "0x332C240", Offset = "0x332AE40", VA = "0x18332C240")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateRemove(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x000161B8 File Offset: 0x000143B8
		[Token(Token = "0x6003548")]
		[Address(RVA = "0x3332470", Offset = "0x3331070", VA = "0x183332470")]
		private static bool tryPrimitiveArrayGet(Type type, IntPtr L, object obj, int index)
		{
			return default(bool);
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x000161D0 File Offset: 0x000143D0
		[Token(Token = "0x6003549")]
		[Address(RVA = "0x332B090", Offset = "0x3329C90", VA = "0x18332B090")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayIndexer(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x000161E8 File Offset: 0x000143E8
		[Token(Token = "0x600354A")]
		[Address(RVA = "0x332EFA0", Offset = "0x332DBA0", VA = "0x18332EFA0")]
		public static bool TryPrimitiveArraySet(Type type, IntPtr L, object obj, int array_idx, int obj_idx)
		{
			return default(bool);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00016200 File Offset: 0x00014400
		[Token(Token = "0x600354B")]
		[Address(RVA = "0x332B5F0", Offset = "0x332A1F0", VA = "0x18332B5F0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayNewIndexer(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x00016218 File Offset: 0x00014418
		[Token(Token = "0x600354C")]
		[Address(RVA = "0x332B470", Offset = "0x332A070", VA = "0x18332B470")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayLength(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x00016230 File Offset: 0x00014430
		[Token(Token = "0x600354D")]
		[Address(RVA = "0x332E4F0", Offset = "0x332D0F0", VA = "0x18332E4F0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int MetaFuncIndex(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x00016248 File Offset: 0x00014448
		[Token(Token = "0x600354E")]
		[Address(RVA = "0x332E6B0", Offset = "0x332D2B0", VA = "0x18332E6B0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Panic(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x00016260 File Offset: 0x00014460
		[Token(Token = "0x600354F")]
		[Address(RVA = "0x332E730", Offset = "0x332D330", VA = "0x18332E730")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Print(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x00016278 File Offset: 0x00014478
		[Token(Token = "0x6003550")]
		[Address(RVA = "0x332E410", Offset = "0x332D010", VA = "0x18332E410")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadSocketCore(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x00016290 File Offset: 0x00014490
		[Token(Token = "0x6003551")]
		[Address(RVA = "0x332DB60", Offset = "0x332C760", VA = "0x18332DB60")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadCS(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x000162A8 File Offset: 0x000144A8
		[Token(Token = "0x6003552")]
		[Address(RVA = "0x332D9F0", Offset = "0x332C5F0", VA = "0x18332D9F0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadBuiltinLib(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x000162C0 File Offset: 0x000144C0
		[Token(Token = "0x6003553")]
		[Address(RVA = "0x332DF00", Offset = "0x332CB00", VA = "0x18332DF00")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromResource(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x000162D8 File Offset: 0x000144D8
		[Token(Token = "0x6003554")]
		[Address(RVA = "0x332E1C0", Offset = "0x332CDC0", VA = "0x18332E1C0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromStreamingAssetsPath(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x000162F0 File Offset: 0x000144F0
		[Token(Token = "0x6003555")]
		[Address(RVA = "0x332DBC0", Offset = "0x332C7C0", VA = "0x18332DBC0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromCustomLoaders(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x00016308 File Offset: 0x00014508
		[Token(Token = "0x6003556")]
		[Address(RVA = "0x332D840", Offset = "0x332C440", VA = "0x18332D840")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadAssembly(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x00016320 File Offset: 0x00014520
		[Token(Token = "0x6003557")]
		[Address(RVA = "0x332D6A0", Offset = "0x332C2A0", VA = "0x18332D6A0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportType(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x00016338 File Offset: 0x00014538
		[Token(Token = "0x6003558")]
		[Address(RVA = "0x332D2F0", Offset = "0x332BEF0", VA = "0x18332D2F0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportGenericType(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x00016350 File Offset: 0x00014550
		[Token(Token = "0x6003559")]
		[Address(RVA = "0x332BA00", Offset = "0x332A600", VA = "0x18332BA00")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Cast(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355A")]
		[Address(RVA = "0x33322B0", Offset = "0x3330EB0", VA = "0x1833322B0")]
		private static Type getType(IntPtr L, ObjectTranslator translator, int idx)
		{
			return null;
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x00016368 File Offset: 0x00014568
		[Token(Token = "0x600355B")]
		[Address(RVA = "0x332F9A0", Offset = "0x332E5A0", VA = "0x18332F9A0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaAccess(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x00016380 File Offset: 0x00014580
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x3330090", Offset = "0x332EC90", VA = "0x183330090")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaPrivateAccessible(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x00016398 File Offset: 0x00014598
		[Token(Token = "0x600355D")]
		[Address(RVA = "0x332FE30", Offset = "0x332EA30", VA = "0x18332FE30")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaMetatableOperation(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x000163B0 File Offset: 0x000145B0
		[Token(Token = "0x600355E")]
		[Address(RVA = "0x332C050", Offset = "0x332AC50", VA = "0x18332C050")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateConstructor(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x000163C8 File Offset: 0x000145C8
		[Token(Token = "0x600355F")]
		[Address(RVA = "0x332EB10", Offset = "0x332D710", VA = "0x18332EB10")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToFunction(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x000163E0 File Offset: 0x000145E0
		[Token(Token = "0x6003560")]
		[Address(RVA = "0x332CB00", Offset = "0x332B700", VA = "0x18332CB00")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GenericMethodWraper(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x000163F8 File Offset: 0x000145F8
		[Token(Token = "0x6003561")]
		[Address(RVA = "0x332CF40", Offset = "0x332BB40", VA = "0x18332CF40")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GetGenericMethod(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x00016410 File Offset: 0x00014610
		[Token(Token = "0x6003562")]
		[Address(RVA = "0x332E910", Offset = "0x332D510", VA = "0x18332E910")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ReleaseCsObject(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x00016428 File Offset: 0x00014628
		[Token(Token = "0x6003563")]
		[Address(RVA = "0x332C8E0", Offset = "0x332B4E0", VA = "0x18332C8E0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int FindTypeByName(IntPtr L)
		{
			return 0;
		}

		// Token: 0x04000CE3 RID: 3299
		[Token(Token = "0x4000CE3")]
		[FieldOffset(Offset = "0x10")]
		internal lua_CSFunction GcMeta;

		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x18")]
		internal lua_CSFunction ToStringMeta;

		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0x20")]
		internal lua_CSFunction EnumAndMeta;

		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x28")]
		internal lua_CSFunction EnumOrMeta;

		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		[FieldOffset(Offset = "0x30")]
		internal lua_CSFunction StaticCSFunctionWraper;

		// Token: 0x04000CE8 RID: 3304
		[Token(Token = "0x4000CE8")]
		[FieldOffset(Offset = "0x38")]
		internal lua_CSFunction FixCSFunctionWraper;

		// Token: 0x04000CE9 RID: 3305
		[Token(Token = "0x4000CE9")]
		[FieldOffset(Offset = "0x40")]
		internal lua_CSFunction DelegateCtor;
	}
}
