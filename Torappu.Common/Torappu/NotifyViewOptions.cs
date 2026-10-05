using System;
using Il2CppDummyDll;
using Torappu.Notification;

namespace Torappu
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public struct NotifyViewOptions<ViewType, ParamType> where ViewType : NotifyView where ParamType : NotifyViewParam
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011B")]
		public string GenerateSignature()
		{
			return null;
		}

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x0")]
		public float duration;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x0")]
		public NotifyViewPriority priority;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x0")]
		public bool toTheFront;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x0")]
		public ParamType param;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x0")]
		public float delay;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x0")]
		public string overrideAudioSignal;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x0")]
		public string resPath;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x0")]
		public ViewType prefab;
	}
}
