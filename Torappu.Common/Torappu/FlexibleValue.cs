using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	[Serializable]
	public class FlexibleValue
	{
		// Token: 0x0600046F RID: 1135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x54FDD80", Offset = "0x54FC980", VA = "0x1854FDD80")]
		public FlexibleValue Copy()
		{
			return null;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x54FDD40", Offset = "0x54FC940", VA = "0x1854FDD40")]
		public void ClearValues()
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FlexibleValue()
		{
		}

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public FlexibleValueMeta inspectorMeta;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public FlexibleValueType valueType;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x20")]
		public int intVal;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x24")]
		public float floatVal;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x28")]
		public string strVal;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x30")]
		public UnityEngine.Object objVal;
	}
}
