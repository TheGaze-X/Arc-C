using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All)]
	public class HideInAttribute : Attribute
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public HideInAttribute(PrefabKind prefabKind)
		{
		}

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x10")]
		public PrefabKind PrefabKind;
	}
}
