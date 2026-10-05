using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public class IkConstraint : IUpdatable
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x4E4F840", Offset = "0x4E4E440", VA = "0x184E4F840")]
		public IkConstraint(IkConstraintData data, Skeleton skeleton)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x4E4FBC0", Offset = "0x4E4E7C0", VA = "0x184E4FBC0")]
		public IkConstraint(IkConstraint constraint, Skeleton skeleton)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x4E4F730", Offset = "0x4E4E330", VA = "0x184E4F730")]
		public void Apply()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x4E4F730", Offset = "0x4E4E330", VA = "0x184E4F730", Slot = "4")]
		public void Update()
		{
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170000D9")]
		public ExposedList<Bone> Bones
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000DA")]
		public Bone Target
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000032FC File Offset: 0x000014FC
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000DB")]
		public float Mix
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
			set
			{
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00003314 File Offset: 0x00001514
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000DC")]
		public float Softness
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x16923F0", Offset = "0x1690FF0", VA = "0x1816923F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x16928C0", Offset = "0x16914C0", VA = "0x1816928C0")]
			set
			{
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000332C File Offset: 0x0000152C
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000DD")]
		public int BendDirection
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00003344 File Offset: 0x00001544
		// (set) Token: 0x060002CF RID: 719 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000DE")]
		public bool Compress
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x4EF620", Offset = "0x4EE220", VA = "0x1804EF620")]
			set
			{
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000335C File Offset: 0x0000155C
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000DF")]
		public bool Stretch
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x106F290", Offset = "0x106DE90", VA = "0x18106F290")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x106F2A0", Offset = "0x106DEA0", VA = "0x18106F2A0")]
			set
			{
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00003374 File Offset: 0x00001574
		[Token(Token = "0x170000E0")]
		public bool Active
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170000E1")]
		public IkConstraintData Data
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x319C1D0", Offset = "0x319ADD0", VA = "0x18319C1D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x4E4E460", Offset = "0x4E4D060", VA = "0x184E4E460")]
		public static void Apply(Bone bone, float targetX, float targetY, bool compress, bool stretch, bool uniform, float alpha)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x4E4E9B0", Offset = "0x4E4D5B0", VA = "0x184E4E9B0")]
		public static void Apply(Bone parent, Bone child, float targetX, float targetY, int bendDir, bool stretch, float softness, float alpha)
		{
		}

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x10")]
		internal IkConstraintData data;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x18")]
		internal ExposedList<Bone> bones;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x20")]
		internal Bone target;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x28")]
		internal int bendDirection;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x2C")]
		internal bool compress;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x2D")]
		internal bool stretch;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x30")]
		internal float mix;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x34")]
		internal float softness;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x38")]
		internal bool active;
	}
}
