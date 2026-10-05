using System;
using FullInspector.Internal;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007C00 RID: 31744
	[Token(Token = "0x2007C00")]
	public interface fiIPersistentMetadataProvider
	{
		// Token: 0x0602C69A RID: 181914
		[Token(Token = "0x602C69A")]
		void RestoreData(fiUnityObjectReference target);

		// Token: 0x0602C69B RID: 181915
		[Token(Token = "0x602C69B")]
		void Reset(fiUnityObjectReference target);

		// Token: 0x1700680B RID: 26635
		// (get) Token: 0x0602C69C RID: 181916
		[Token(Token = "0x1700680B")]
		Type MetadataType { [Token(Token = "0x602C69C")] get; }
	}
}
