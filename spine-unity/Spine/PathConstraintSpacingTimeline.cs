using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class PathConstraintSpacingTimeline : PathConstraintPositionTimeline
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x4E49140", Offset = "0x4E47D40", VA = "0x184E49140")]
		public PathConstraintSpacingTimeline(int frameCount)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x17000037")]
		public override int PropertyId
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x4E49430", Offset = "0x4E48030", VA = "0x184E49430", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x4E49220", Offset = "0x4E47E20", VA = "0x184E49220", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> events, float alpha, MixBlend blend, MixDirection direction)
		{
		}
	}
}
