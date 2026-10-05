using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public abstract class SpineAttributeBase : PropertyAttribute
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x4E9EA90", Offset = "0x4E9D690", VA = "0x184E9EA90")]
		protected SpineAttributeBase()
		{
		}

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x10")]
		public string dataField;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x18")]
		public string startsWith;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x20")]
		public bool includeNone;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x21")]
		public bool fallbackToTextField;
	}
}
