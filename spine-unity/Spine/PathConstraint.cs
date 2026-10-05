using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public class PathConstraint : IUpdatable
	{
		// Token: 0x06000305 RID: 773 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x4E53440", Offset = "0x4E52040", VA = "0x184E53440")]
		public PathConstraint(PathConstraintData data, Skeleton skeleton)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x4E53980", Offset = "0x4E52580", VA = "0x184E53980")]
		public PathConstraint(PathConstraint constraint, Skeleton skeleton)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x4E517B0", Offset = "0x4E503B0", VA = "0x184E517B0")]
		public void Apply()
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x4E529C0", Offset = "0x4E515C0", VA = "0x184E529C0", Slot = "4")]
		public void Update()
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x4E517C0", Offset = "0x4E503C0", VA = "0x184E517C0")]
		private float[] ComputeWorldPositions(PathAttachment path, int spacesCount, bool tangents, bool percentPosition, bool percentSpacing)
		{
			return null;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x4E511E0", Offset = "0x4E4FDE0", VA = "0x184E511E0")]
		private static void AddBeforePosition(float p, float[] temp, int i, float[] output, int o)
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x4E50FB0", Offset = "0x4E4FBB0", VA = "0x184E50FB0")]
		private static void AddAfterPosition(float p, float[] temp, int i, float[] output, int o)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x4E51400", Offset = "0x4E50000", VA = "0x184E51400")]
		private static void AddCurvePosition(float p, float x1, float y1, float cx1, float cy1, float cx2, float cy2, float x2, float y2, float[] output, int o, bool tangents)
		{
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000035B4 File Offset: 0x000017B4
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000EC")]
		public float Position
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x7E7510", Offset = "0x7E6110", VA = "0x1807E7510")]
			set
			{
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600030F RID: 783 RVA: 0x000035CC File Offset: 0x000017CC
		// (set) Token: 0x06000310 RID: 784 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000ED")]
		public float Spacing
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x4E4C110", Offset = "0x4E4AD10", VA = "0x184E4C110")]
			set
			{
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000035E4 File Offset: 0x000017E4
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000EE")]
		public float RotateMix
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
			set
			{
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000313 RID: 787 RVA: 0x000035FC File Offset: 0x000017FC
		// (set) Token: 0x06000314 RID: 788 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000EF")]
		public float TranslateMix
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x16923F0", Offset = "0x1690FF0", VA = "0x1816923F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x16928C0", Offset = "0x16914C0", VA = "0x1816928C0")]
			set
			{
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170000F0")]
		public ExposedList<Bone> Bones
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000F1")]
		public Slot Target
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00003614 File Offset: 0x00001814
		[Token(Token = "0x170000F2")]
		public bool Active
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170000F3")]
		public PathConstraintData Data
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		private const int NONE = -1;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		private const int BEFORE = -2;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		private const int AFTER = -3;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		private const float Epsilon = 1E-05f;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x10")]
		internal PathConstraintData data;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x18")]
		internal ExposedList<Bone> bones;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x20")]
		internal Slot target;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x28")]
		internal float position;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x2C")]
		internal float spacing;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x30")]
		internal float rotateMix;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x34")]
		internal float translateMix;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x38")]
		internal bool active;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x40")]
		internal ExposedList<float> spaces;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x48")]
		internal ExposedList<float> positions;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x50")]
		internal ExposedList<float> world;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x58")]
		internal ExposedList<float> curves;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x60")]
		internal ExposedList<float> lengths;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x68")]
		internal float[] segments;
	}
}
