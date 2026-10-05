using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[DontApplyToListElements]
	public sealed class DisableContextMenuAttribute : Attribute
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4E17D50", Offset = "0x4E16950", VA = "0x184E17D50")]
		public DisableContextMenuAttribute(bool disableForMember = true, bool disableCollectionElements = false)
		{
		}

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x10")]
		public bool DisableForMember;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x11")]
		public bool DisableForCollectionElements;
	}
}
