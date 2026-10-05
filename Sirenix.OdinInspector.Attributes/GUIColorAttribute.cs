using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class GUIColorAttribute : Attribute
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x4E18240", Offset = "0x4E16E40", VA = "0x184E18240")]
		public GUIColorAttribute(float r, float g, float b, float a = 1f)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x4E182C0", Offset = "0x4E16EC0", VA = "0x184E182C0")]
		public GUIColorAttribute(string getColor)
		{
		}

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x10")]
		public Color Color;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x20")]
		public string GetColor;
	}
}
