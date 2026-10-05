using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020003A8 RID: 936
	[Token(Token = "0x20003A8")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class SinkProviderData
	{
		// Token: 0x06001DF8 RID: 7672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DF8")]
		[Address(RVA = "0x4B8E980", Offset = "0x4B8D580", VA = "0x184B8E980")]
		public SinkProviderData(string name)
		{
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000386")]
		public System.Collections.IList Children
		{
			[Token(Token = "0x6001DF9")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000387")]
		public System.Collections.IDictionary Properties
		{
			[Token(Token = "0x6001DFA")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string sinkName;

		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.Collections.ArrayList children;

		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Collections.Hashtable properties;
	}
}
