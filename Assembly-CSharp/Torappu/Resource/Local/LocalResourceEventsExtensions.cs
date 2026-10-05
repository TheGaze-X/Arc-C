using System;
using Il2CppDummyDll;

namespace Torappu.Resource.Local
{
	// Token: 0x02001769 RID: 5993
	[Token(Token = "0x2001769")]
	internal static class LocalResourceEventsExtensions
	{
		// Token: 0x06009704 RID: 38660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009704")]
		[Address(RVA = "0x3126BA0", Offset = "0x31257A0", VA = "0x183126BA0")]
		public static void NullableOnLoadAsset(this ILocalResourceEvents inst, string assetPath, object asset)
		{
		}

		// Token: 0x06009705 RID: 38661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009705")]
		[Address(RVA = "0x3126C90", Offset = "0x3125890", VA = "0x183126C90")]
		public static void NullableOnLoadScene(this ILocalResourceEvents inst, string scenePath)
		{
		}

		// Token: 0x06009706 RID: 38662 RVA: 0x0003AC20 File Offset: 0x00038E20
		[Token(Token = "0x6009706")]
		[Address(RVA = "0x3126D70", Offset = "0x3125970", VA = "0x183126D70")]
		public static bool NullableValidateAsset(this ILocalResourceEvents inst, string assetPath)
		{
			return default(bool);
		}
	}
}
