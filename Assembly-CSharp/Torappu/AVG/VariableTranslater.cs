using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001EE9 RID: 7913
	[Token(Token = "0x2001EE9")]
	public class VariableTranslater : IAVGTextTranslater
	{
		// Token: 0x0600C459 RID: 50265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C459")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public VariableTranslater(VariableTranslater.VariableGetterDelegate varGetter)
		{
		}

		// Token: 0x0600C45A RID: 50266 RVA: 0x000480C0 File Offset: 0x000462C0
		[Token(Token = "0x600C45A")]
		[Address(RVA = "0x3436E90", Offset = "0x3435A90", VA = "0x183436E90", Slot = "4")]
		public bool TryTranslate(string content, out string result)
		{
			return default(bool);
		}

		// Token: 0x0600C45B RID: 50267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C45B")]
		[Address(RVA = "0x3437180", Offset = "0x3435D80", VA = "0x183437180")]
		private string _ParseVariable(string varName)
		{
			return null;
		}

		// Token: 0x0400C8DC RID: 51420
		[Token(Token = "0x400C8DC")]
		[FieldOffset(Offset = "0x10")]
		private VariableTranslater.VariableGetterDelegate m_varGetter;

		// Token: 0x02001EEA RID: 7914
		// (Invoke) Token: 0x0600C45D RID: 50269
		[Token(Token = "0x2001EEA")]
		public delegate string VariableGetterDelegate(string varName);
	}
}
