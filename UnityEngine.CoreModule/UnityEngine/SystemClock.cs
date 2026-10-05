using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	[VisibleToOtherModules]
	internal class SystemClock
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x1700022E")]
		public static DateTime now
		{
			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0x5970040", Offset = "0x596EC40", VA = "0x185970040")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime s_Epoch;
	}
}
