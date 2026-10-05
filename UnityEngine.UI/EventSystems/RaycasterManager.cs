using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	internal static class RaycasterManager
	{
		// Token: 0x060007AC RID: 1964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x5B92580", Offset = "0x5B91180", VA = "0x185B92580")]
		public static void AddRaycaster(BaseRaycaster baseRaycaster)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x5B92650", Offset = "0x5B91250", VA = "0x185B92650")]
		public static List<BaseRaycaster> GetRaycasters()
		{
			return null;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x5B926A0", Offset = "0x5B912A0", VA = "0x185B926A0")]
		public static void RemoveRaycasters(BaseRaycaster baseRaycaster)
		{
		}

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<BaseRaycaster> s_Raycasters;
	}
}
