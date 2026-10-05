using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public class ScaleTimeline : TranslateTimeline, IBoneTimeline
	{
		// Token: 0x06000049 RID: 73 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4E49F00", Offset = "0x4E48B00", VA = "0x184E49F00")]
		public ScaleTimeline(int frameCount)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x17000014")]
		public override int PropertyId
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x4E49F60", Offset = "0x4E48B60", VA = "0x184E49F60", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x4E49890", Offset = "0x4E48490", VA = "0x184E49890", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}
	}
}
