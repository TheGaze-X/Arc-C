using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007C18 RID: 31768
	[Token(Token = "0x2007C18")]
	public class SharedInstance<TInstance, TSerializer> : BaseScriptableObject<TSerializer> where TSerializer : BaseSerializer
	{
		// Token: 0x0602C6D9 RID: 181977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C6D9")]
		public SharedInstance()
		{
		}

		// Token: 0x040402AF RID: 262831
		[Token(Token = "0x40402AF")]
		[FieldOffset(Offset = "0x0")]
		public TInstance Instance;
	}
}
