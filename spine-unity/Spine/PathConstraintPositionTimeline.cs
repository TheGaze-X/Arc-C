using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class PathConstraintPositionTimeline : CurveTimeline
	{
		// Token: 0x06000098 RID: 152 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x4E49140", Offset = "0x4E47D40", VA = "0x184E49140")]
		public PathConstraintPositionTimeline(int frameCount)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x17000034")]
		public override int PropertyId
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x4E491A0", Offset = "0x4E47DA0", VA = "0x184E491A0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002444 File Offset: 0x00000644
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000035")]
		public int PathConstraintIndex
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x4E491B0", Offset = "0x4E47DB0", VA = "0x184E491B0")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000036")]
		public float[] Frames
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x4E49100", Offset = "0x4E47D00", VA = "0x184E49100")]
		public void SetFrame(int frameIndex, float time, float position)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x4E48EF0", Offset = "0x4E47AF0", VA = "0x184E48EF0", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		public const int ENTRIES = 2;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		protected const int PREV_TIME = -2;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		protected const int PREV_VALUE = -1;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		protected const int VALUE = 1;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x18")]
		internal int pathConstraintIndex;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x20")]
		internal float[] frames;
	}
}
