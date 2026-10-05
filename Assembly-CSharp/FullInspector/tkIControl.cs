using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007C4E RID: 31822
	[Token(Token = "0x2007C4E")]
	public interface tkIControl
	{
		// Token: 0x0602C7BA RID: 182202
		[Token(Token = "0x602C7BA")]
		object Edit(Rect rect, object obj, object context, fiGraphMetadata metadata);

		// Token: 0x0602C7BB RID: 182203
		[Token(Token = "0x602C7BB")]
		float GetHeight(object obj, object context, fiGraphMetadata metadata);

		// Token: 0x0602C7BC RID: 182204
		[Token(Token = "0x602C7BC")]
		void InitializeId(ref int nextId);

		// Token: 0x1700681B RID: 26651
		// (get) Token: 0x0602C7BD RID: 182205
		[Token(Token = "0x1700681B")]
		Type ContextType { [Token(Token = "0x602C7BD")] get; }
	}
}
