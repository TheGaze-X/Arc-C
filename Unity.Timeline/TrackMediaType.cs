using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("TrackMediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
	public class TrackMediaType : Attribute
	{
		// Token: 0x06000308 RID: 776 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public TrackMediaType(TimelineAsset.MediaType mt)
		{
		}

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x10")]
		public readonly TimelineAsset.MediaType m_MediaType;
	}
}
