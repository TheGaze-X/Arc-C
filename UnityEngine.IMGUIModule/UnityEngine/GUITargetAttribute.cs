using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[AttributeUsage(AttributeTargets.Method)]
	public class GUITargetAttribute : Attribute
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x59AC5B0", Offset = "0x59AB1B0", VA = "0x1859AC5B0")]
		[RequiredByNativeCode]
		private static int GetGUITargetAttrValue(Type klass, string methodName)
		{
			return 0;
		}

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x10")]
		internal int displayMask;
	}
}
