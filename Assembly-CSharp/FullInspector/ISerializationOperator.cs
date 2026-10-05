using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BCF RID: 31695
	[Token(Token = "0x2007BCF")]
	public interface ISerializationOperator
	{
		// Token: 0x0602C5C9 RID: 181705
		[Token(Token = "0x602C5C9")]
		UnityEngine.Object RetrieveObjectReference(int storageId);

		// Token: 0x0602C5CA RID: 181706
		[Token(Token = "0x602C5CA")]
		int StoreObjectReference(UnityEngine.Object obj);
	}
}
