using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public class ShearTimeline : TranslateTimeline, IBoneTimeline
	{
		// Token: 0x0600004C RID: 76 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4E49F00", Offset = "0x4E48B00", VA = "0x184E49F00")]
		public ShearTimeline(int frameCount)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x17000015")]
		public override int PropertyId
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x4E4A280", Offset = "0x4E48E80", VA = "0x184E4A280", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4E49F70", Offset = "0x4E48B70", VA = "0x184E49F70", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}
	}
}
