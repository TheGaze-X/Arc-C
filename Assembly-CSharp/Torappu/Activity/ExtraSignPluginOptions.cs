using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Activity
{
	// Token: 0x02006DBB RID: 28091
	[Token(Token = "0x2006DBB")]
	public class ExtraSignPluginOptions
	{
		// Token: 0x06027FF7 RID: 163831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FF7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ExtraSignPluginOptions()
		{
		}

		// Token: 0x04038B4D RID: 232269
		[Token(Token = "0x4038B4D")]
		[FieldOffset(Offset = "0x10")]
		public ActivityCommonCheckinViewModel commonViewModel;

		// Token: 0x04038B4E RID: 232270
		[Token(Token = "0x4038B4E")]
		[FieldOffset(Offset = "0x18")]
		public Action<int, string> confirmRewardEvent;

		// Token: 0x04038B4F RID: 232271
		[Token(Token = "0x4038B4F")]
		[FieldOffset(Offset = "0x20")]
		public Func<string, string, Sprite> loadSpriteFromAutoPackHub;

		// Token: 0x04038B50 RID: 232272
		[Token(Token = "0x4038B50")]
		[FieldOffset(Offset = "0x28")]
		public string[] countDowns;
	}
}
