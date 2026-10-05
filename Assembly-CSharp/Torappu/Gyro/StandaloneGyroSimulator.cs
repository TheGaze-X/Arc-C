using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Gyro
{
	// Token: 0x020016F3 RID: 5875
	[Token(Token = "0x20016F3")]
	public class StandaloneGyroSimulator : IHotfixable
	{
		// Token: 0x060094BD RID: 38077 RVA: 0x00039F78 File Offset: 0x00038178
		[Token(Token = "0x60094BD")]
		[Address(RVA = "0x3114090", Offset = "0x3112C90", VA = "0x183114090")]
		public static bool IsSupported()
		{
			return default(bool);
		}

		// Token: 0x060094BE RID: 38078 RVA: 0x00039F90 File Offset: 0x00038190
		[Token(Token = "0x60094BE")]
		[Address(RVA = "0x3113F70", Offset = "0x3112B70", VA = "0x183113F70")]
		public static Vector2 GetSimpleAttitude()
		{
			return default(Vector2);
		}

		// Token: 0x060094BF RID: 38079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094BF")]
		[Address(RVA = "0x31140E0", Offset = "0x3112CE0", VA = "0x1831140E0")]
		public StandaloneGyroSimulator()
		{
		}

		// Token: 0x04008ACB RID: 35531
		[Token(Token = "0x4008ACB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsSupported;

		// Token: 0x04008ACC RID: 35532
		[Token(Token = "0x4008ACC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSimpleAttitude;

		// Token: 0x04008ACD RID: 35533
		[Token(Token = "0x4008ACD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
