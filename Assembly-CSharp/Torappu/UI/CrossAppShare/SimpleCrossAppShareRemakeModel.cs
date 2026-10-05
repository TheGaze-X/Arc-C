using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058FD RID: 22781
	[Token(Token = "0x20058FD")]
	public class SimpleCrossAppShareRemakeModel : ISimpleCrossAppShareRemakeModelCollector, ICrossAppShareModelCollector, IHotfixable, ILuaCallCSharp
	{
		// Token: 0x06021344 RID: 136004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021344")]
		[Address(RVA = "0x1B832F0", Offset = "0x1B81EF0", VA = "0x181B832F0", Slot = "4")]
		public SimpleCrossAppShareRemakeModel GetSimpleModel()
		{
			return null;
		}

		// Token: 0x06021345 RID: 136005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021345")]
		[Address(RVA = "0x1B83290", Offset = "0x1B81E90", VA = "0x181B83290", Slot = "5")]
		public void CollectModel()
		{
		}

		// Token: 0x06021346 RID: 136006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021346")]
		[Address(RVA = "0x1B83350", Offset = "0x1B81F50", VA = "0x181B83350")]
		public SimpleCrossAppShareRemakeModel()
		{
		}

		// Token: 0x0402D3A6 RID: 185254
		[Token(Token = "0x402D3A6")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, CrossAppShareComponentBaseModel> compModelDict;

		// Token: 0x0402D3A7 RID: 185255
		[Token(Token = "0x402D3A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSimpleModel;

		// Token: 0x0402D3A8 RID: 185256
		[Token(Token = "0x402D3A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CollectModel;

		// Token: 0x0402D3A9 RID: 185257
		[Token(Token = "0x402D3A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
