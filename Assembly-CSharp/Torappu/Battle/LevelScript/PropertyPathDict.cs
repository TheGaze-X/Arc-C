using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200288C RID: 10380
	[Token(Token = "0x200288C")]
	public class PropertyPathDict : Singleton<PropertyPathDict>
	{
		// Token: 0x060114AC RID: 70828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114AC")]
		[Address(RVA = "0x927670", Offset = "0x926270", VA = "0x180927670")]
		private PropertyPathDict()
		{
		}

		// Token: 0x060114AD RID: 70829 RVA: 0x0006A878 File Offset: 0x00068A78
		[Token(Token = "0x60114AD")]
		[Address(RVA = "0x927060", Offset = "0x925C60", VA = "0x180927060")]
		public static PropertyPath GetPath(string path)
		{
			return default(PropertyPath);
		}

		// Token: 0x040134FA RID: 79098
		[Token(Token = "0x40134FA")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, PropertyPath> m_lookupTable;

		// Token: 0x040134FB RID: 79099
		[Token(Token = "0x40134FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040134FC RID: 79100
		[Token(Token = "0x40134FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPath;
	}
}
