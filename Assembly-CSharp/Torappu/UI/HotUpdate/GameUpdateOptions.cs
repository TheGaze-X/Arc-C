using System;
using Il2CppDummyDll;
using Torappu.Resource;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004ACD RID: 19149
	[Token(Token = "0x2004ACD")]
	public struct GameUpdateOptions
	{
		// Token: 0x04025BCF RID: 154575
		[Token(Token = "0x4025BCF")]
		[FieldOffset(Offset = "0x0")]
		public HotUpdater.NetUsagePolicy netUsagePolicy;

		// Token: 0x04025BD0 RID: 154576
		[Token(Token = "0x4025BD0")]
		[FieldOffset(Offset = "0x8")]
		public Action onDownloadStart;

		// Token: 0x04025BD1 RID: 154577
		[Token(Token = "0x4025BD1")]
		[FieldOffset(Offset = "0x10")]
		public Action<long, long> onDonwloadProgress;

		// Token: 0x04025BD2 RID: 154578
		[Token(Token = "0x4025BD2")]
		[FieldOffset(Offset = "0x18")]
		public Action<string> onDisplayHint;

		// Token: 0x04025BD3 RID: 154579
		[Token(Token = "0x4025BD3")]
		[FieldOffset(Offset = "0x20")]
		public HotUpdateWorkflow workflow;

		// Token: 0x04025BD4 RID: 154580
		[Token(Token = "0x4025BD4")]
		[FieldOffset(Offset = "0x28")]
		public bool enableGameUpdateV2;
	}
}
