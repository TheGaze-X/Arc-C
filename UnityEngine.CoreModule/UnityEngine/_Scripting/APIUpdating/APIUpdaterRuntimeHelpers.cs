using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine._Scripting.APIUpdating
{
	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	internal class APIUpdaterRuntimeHelpers
	{
		// Token: 0x06000C08 RID: 3080 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x5958760", Offset = "0x5957360", VA = "0x185958760")]
		[RequiredByNativeCode]
		internal static bool GetMovedFromAttributeDataForType(Type sourceType, out string assembly, out string nsp, out string klass)
		{
			return default(bool);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x5958910", Offset = "0x5957510", VA = "0x185958910")]
		[RequiredByNativeCode]
		internal static bool GetObsoleteTypeRedirection(Type sourceType, out string assemblyName, out string nsp, out string className)
		{
			return default(bool);
		}
	}
}
