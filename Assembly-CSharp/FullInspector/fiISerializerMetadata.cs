using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BD3 RID: 31699
	[Token(Token = "0x2007BD3")]
	public interface fiISerializerMetadata
	{
		// Token: 0x170067DF RID: 26591
		// (get) Token: 0x0602C5DE RID: 181726
		[Token(Token = "0x170067DF")]
		Guid SerializerGuid { [Token(Token = "0x602C5DE")] get; }

		// Token: 0x170067E0 RID: 26592
		// (get) Token: 0x0602C5DF RID: 181727
		[Token(Token = "0x170067E0")]
		Type SerializerType { [Token(Token = "0x602C5DF")] get; }

		// Token: 0x170067E1 RID: 26593
		// (get) Token: 0x0602C5E0 RID: 181728
		[Token(Token = "0x170067E1")]
		Type[] SerializationOptInAnnotationTypes { [Token(Token = "0x602C5E0")] get; }

		// Token: 0x170067E2 RID: 26594
		// (get) Token: 0x0602C5E1 RID: 181729
		[Token(Token = "0x170067E2")]
		Type[] SerializationOptOutAnnotationTypes { [Token(Token = "0x602C5E1")] get; }
	}
}
