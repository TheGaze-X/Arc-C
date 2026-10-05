using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	[Serializable]
	public class FlexibleValueList
	{
		// Token: 0x06000466 RID: 1126 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x54FDA60", Offset = "0x54FC660", VA = "0x1854FDA60")]
		public FlexibleValueList()
		{
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x54FDAF0", Offset = "0x54FC6F0", VA = "0x1854FDAF0")]
		public FlexibleValueList(FlexibleValueList other)
		{
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000053B4 File Offset: 0x000035B4
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x54FD370", Offset = "0x54FBF70", VA = "0x1854FD370")]
		public List<FlexibleValue>.Enumerator GetEnumerator()
		{
			return default(List<FlexibleValue>.Enumerator);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x54FD4B0", Offset = "0x54FC0B0", VA = "0x1854FD4B0")]
		public FlexibleValue GetField(string name)
		{
			return null;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x54FD3E0", Offset = "0x54FBFE0", VA = "0x1854FD3E0")]
		public FlexibleValue GetFieldOrCreate(string name)
		{
			return null;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x54FD720", Offset = "0x54FC320", VA = "0x1854FD720")]
		public void SetField(FlexibleValue field)
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x54FD8A0", Offset = "0x54FC4A0", VA = "0x1854FD8A0")]
		[ReflectMethod]
		private void _OnAddElement()
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x54FD9C0", Offset = "0x54FC5C0", VA = "0x1854FD9C0")]
		[ReflectMethod]
		private void _OnRemoveElementAt(int index)
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x54FD600", Offset = "0x54FC200", VA = "0x1854FD600")]
		public void LockDataSchemaInInspector()
		{
		}

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x10")]
		public FlexibleValueListMeta inspectorMeta;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x18")]
		public List<FlexibleValue> list;
	}
}
