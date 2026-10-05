using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class PropertySpaceAttribute : Attribute
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x4E19B60", Offset = "0x4E18760", VA = "0x184E19B60")]
		public PropertySpaceAttribute()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x4E19B30", Offset = "0x4E18730", VA = "0x184E19B30")]
		public PropertySpaceAttribute(float spaceBefore)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x4F1E70", Offset = "0x4F0A70", VA = "0x1804F1E70")]
		public PropertySpaceAttribute(float spaceBefore, float spaceAfter)
		{
		}

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x10")]
		public float SpaceBefore;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x14")]
		public float SpaceAfter;
	}
}
