using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	internal sealed class XmlChildEnumerator : IEnumerator
	{
		// Token: 0x060004A4 RID: 1188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x4FA8A50", Offset = "0x4FA7650", VA = "0x184FA8A50")]
		internal XmlChildEnumerator(XmlNode container)
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x4FA8890", Offset = "0x4FA7490", VA = "0x184FA8890", Slot = "4")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x4FA8890", Offset = "0x4FA7490", VA = "0x184FA8890")]
		internal bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x4FA8960", Offset = "0x4FA7560", VA = "0x184FA8960", Slot = "6")]
		private void Reset()
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FE")]
		private object Current
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x4FA89C0", Offset = "0x4FA75C0", VA = "0x184FA89C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FF")]
		internal XmlNode Current
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x4FA89C0", Offset = "0x4FA75C0", VA = "0x184FA89C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x10")]
		internal XmlNode container;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x18")]
		internal XmlNode child;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x20")]
		internal bool isFirst;
	}
}
