using System;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x020017C8 RID: 6088
	[Token(Token = "0x20017C8")]
	public static class BuildingContextProvider
	{
		// Token: 0x060099A7 RID: 39335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A7")]
		[Address(RVA = "0x3135D10", Offset = "0x3134910", VA = "0x183135D10")]
		public static void Attach(ref RefCountReference refer)
		{
		}

		// Token: 0x060099A8 RID: 39336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A8")]
		[Address(RVA = "0x3135E80", Offset = "0x3134A80", VA = "0x183135E80")]
		public static void Detach(RefCountReference refer)
		{
		}

		// Token: 0x060099A9 RID: 39337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A9")]
		[Address(RVA = "0x3135FB0", Offset = "0x3134BB0", VA = "0x183135FB0")]
		public static void Unreference(RefCountReference refer)
		{
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060099AA RID: 39338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001094")]
		public static IBuildingContext context
		{
			[Token(Token = "0x60099AA")]
			[Address(RVA = "0x31361F0", Offset = "0x3134DF0", VA = "0x1831361F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400902A RID: 36906
		[Token(Token = "0x400902A")]
		[FieldOffset(Offset = "0x0")]
		private static DynamicBuildingContext s_dynamicContext;
	}
}
