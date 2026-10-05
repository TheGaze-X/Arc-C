using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	internal class AttributeHelperEngine
	{
		// Token: 0x060008FF RID: 2303 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x5947910", Offset = "0x5946510", VA = "0x185947910")]
		[RequiredByNativeCode]
		private static Type GetParentTypeDisallowingMultipleInclusion(Type type)
		{
			return null;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x59479F0", Offset = "0x59465F0", VA = "0x1859479F0")]
		[RequiredByNativeCode]
		private static Type[] GetRequiredComponents(Type klass)
		{
			return null;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x59477D0", Offset = "0x59463D0", VA = "0x1859477D0")]
		private static int GetExecuteMode(Type klass)
		{
			return 0;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x5947580", Offset = "0x5946180", VA = "0x185947580")]
		[RequiredByNativeCode]
		private static int CheckIsEditorScript(Type klass)
		{
			return 0;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x5947760", Offset = "0x5946360", VA = "0x185947760")]
		[RequiredByNativeCode]
		private static int GetDefaultExecutionOrderFor(Type klass)
		{
			return 0;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000904")]
		private static T GetCustomAttributeOfType<T>(Type klass) where T : Attribute
		{
			return null;
		}

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x0")]
		public static DisallowMultipleComponent[] _disallowMultipleComponentArray;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x8")]
		public static ExecuteInEditMode[] _executeInEditModeArray;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x10")]
		public static RequireComponent[] _requireComponentArray;
	}
}
