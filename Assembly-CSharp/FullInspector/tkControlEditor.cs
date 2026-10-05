using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007C55 RID: 31829
	[Token(Token = "0x2007C55")]
	public class tkControlEditor
	{
		// Token: 0x0602C7E0 RID: 182240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7E0")]
		[Address(RVA = "0x28782B0", Offset = "0x2876EB0", VA = "0x1828782B0")]
		public tkControlEditor(tkIControl control)
		{
		}

		// Token: 0x0602C7E1 RID: 182241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7E1")]
		[Address(RVA = "0x28781B0", Offset = "0x2876DB0", VA = "0x1828781B0")]
		public tkControlEditor(bool debug, tkIControl control)
		{
		}

		// Token: 0x04040325 RID: 262949
		[Token(Token = "0x4040325")]
		[FieldOffset(Offset = "0x10")]
		public bool Debug;

		// Token: 0x04040326 RID: 262950
		[Token(Token = "0x4040326")]
		[FieldOffset(Offset = "0x18")]
		public tkIControl Control;

		// Token: 0x04040327 RID: 262951
		[Token(Token = "0x4040327")]
		[FieldOffset(Offset = "0x20")]
		public object Context;
	}
}
