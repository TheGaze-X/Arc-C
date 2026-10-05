using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.TerrainUtils
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
	public static class TerrainUtility
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x59CF150", Offset = "0x59CDD50", VA = "0x1859CF150")]
		internal static bool ValidTerrainsExist()
		{
			return default(bool);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x59CED40", Offset = "0x59CD940", VA = "0x1859CED40")]
		internal static void ClearConnectivity()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x59CEE30", Offset = "0x59CDA30", VA = "0x1859CEE30")]
		internal static Dictionary<int, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = true)
		{
			return null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x59CE940", Offset = "0x59CD540", VA = "0x1859CE940")]
		[RequiredByNativeCode]
		public static void AutoConnect()
		{
		}
	}
}
