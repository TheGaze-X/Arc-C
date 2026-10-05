using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class Animation
	{
		// Token: 0x0600001D RID: 29 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4E40F90", Offset = "0x4E3FB90", VA = "0x184E40F90")]
		public Animation(string name, ExposedList<Timeline> timelines, float duration)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4E41280", Offset = "0x4E3FE80", VA = "0x184E41280")]
		public Animation(string name, byte[] buffer, SkeletonBinary binary, SkeletonData data, ExposedList<string> strings)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4E40C50", Offset = "0x4E3F850", VA = "0x184E40C50")]
		private void TORA_ReadAnimation()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4E40D30", Offset = "0x4E3F930", VA = "0x184E40D30")]
		private void _SetTimelines(ExposedList<Timeline> timelines)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000006")]
		public ExposedList<Timeline> Timelines
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x4E41360", Offset = "0x4E3FF60", VA = "0x184E41360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x4E41380", Offset = "0x4E3FF80", VA = "0x184E41380")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002144 File Offset: 0x00000344
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000007")]
		public float Duration
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x7E7510", Offset = "0x7E6110", VA = "0x1807E7510")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000008")]
		public string Name
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4E40BA0", Offset = "0x4E3F7A0", VA = "0x184E40BA0")]
		public bool HasTimeline(int id)
		{
			return default(bool);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4E407E0", Offset = "0x4E3F3E0", VA = "0x184E407E0")]
		public void Apply(Skeleton skeleton, float lastTime, float time, bool loop, ExposedList<Event> events, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4E40B10", Offset = "0x4E3F710", VA = "0x184E40B10")]
		internal static int BinarySearch(float[] values, float target, int step)
		{
			return 0;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4E40AA0", Offset = "0x4E3F6A0", VA = "0x184E40AA0")]
		internal static int BinarySearch(float[] values, float target)
		{
			return 0;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4E40C00", Offset = "0x4E3F800", VA = "0x184E40C00")]
		internal static int LinearSearch(float[] values, float target, int step)
		{
			return 0;
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		internal string name;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		private ExposedList<Timeline> timelines;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x20")]
		internal HashSet<int> timelineIds;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x28")]
		internal float duration;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x30")]
		private SkeletonBinary _binary;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x38")]
		private SkeletonData _data;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x40")]
		private byte[] _buffer;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x48")]
		private ExposedList<string> _strings;
	}
}
