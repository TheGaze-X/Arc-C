using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.I18N
{
	// Token: 0x0200023F RID: 575
	[Token(Token = "0x200023F")]
	public class I18nUtils : Singleton<I18nUtils>
	{
		// Token: 0x06000D21 RID: 3361 RVA: 0x000086E4 File Offset: 0x000068E4
		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x55832E0", Offset = "0x5581EE0", VA = "0x1855832E0")]
		private bool _TryGetTextAndCheck(string textId, out string text)
		{
			return default(bool);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x5583210", Offset = "0x5581E10", VA = "0x185583210")]
		private static void _LogMissingTextId(string textId)
		{
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x5582CF0", Offset = "0x55818F0", VA = "0x185582CF0")]
		public void RegisterTextProvider(I18nUtils.ITextProvider provider)
		{
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x5583170", Offset = "0x5581D70", VA = "0x185583170")]
		public void UnregisterTextProvider(I18nUtils.ITextProvider provider)
		{
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x55827D0", Offset = "0x55813D0", VA = "0x1855827D0")]
		public static string GetText(string textId)
		{
			return null;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x000086FC File Offset: 0x000068FC
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x55830D0", Offset = "0x5581CD0", VA = "0x1855830D0")]
		public static bool TryGetText(string textId, out string text)
		{
			return default(bool);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x5582490", Offset = "0x5581090", VA = "0x185582490")]
		public static string FormatTextByKey(string key, object arg0)
		{
			return null;
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x55826B0", Offset = "0x55812B0", VA = "0x1855826B0")]
		public static string FormatTextByKey(string key, object arg0, object arg1)
		{
			return null;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x5582590", Offset = "0x5581190", VA = "0x185582590")]
		public static string FormatTextByKey(string key, object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x5582D90", Offset = "0x5581990", VA = "0x185582D90")]
		public static string SerializeWithoutScientificNotation(object obj)
		{
			return null;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x55828E0", Offset = "0x55814E0", VA = "0x1855828E0")]
		public static void NormalizeFloatsInJToken(JToken token)
		{
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x5583610", Offset = "0x5582210", VA = "0x185583610")]
		private I18nUtils()
		{
		}

		// Token: 0x04000D3B RID: 3387
		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<I18nUtils.ITextProvider> s_activeProviders;

		// Token: 0x04000D3C RID: 3388
		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate202 __Hotfix0__TryGetTextAndCheck;

		// Token: 0x04000D3D RID: 3389
		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0__LogMissingTextId;

		// Token: 0x04000D3E RID: 3390
		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate0 __Hotfix0_RegisterTextProvider;

		// Token: 0x04000D3F RID: 3391
		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate0 __Hotfix0_UnregisterTextProvider;

		// Token: 0x04000D40 RID: 3392
		[Token(Token = "0x4000D40")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate19 __Hotfix0_GetText;

		// Token: 0x04000D41 RID: 3393
		[Token(Token = "0x4000D41")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate270 __Hotfix0_TryGetText;

		// Token: 0x04000D42 RID: 3394
		[Token(Token = "0x4000D42")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate3 __Hotfix0_FormatTextByKey;

		// Token: 0x04000D43 RID: 3395
		[Token(Token = "0x4000D43")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate20 __Hotfix1_FormatTextByKey;

		// Token: 0x04000D44 RID: 3396
		[Token(Token = "0x4000D44")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate271 __Hotfix2_FormatTextByKey;

		// Token: 0x04000D45 RID: 3397
		[Token(Token = "0x4000D45")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate19 __Hotfix0_SerializeWithoutScientificNotation;

		// Token: 0x04000D46 RID: 3398
		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate1 __Hotfix0_NormalizeFloatsInJToken;

		// Token: 0x04000D47 RID: 3399
		[Token(Token = "0x4000D47")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000240 RID: 576
		[Token(Token = "0x2000240")]
		public interface ITextProvider
		{
			// Token: 0x06000D2D RID: 3373
			[Token(Token = "0x6000D2D")]
			bool TryGetText(string textId, out string text);
		}
	}
}
