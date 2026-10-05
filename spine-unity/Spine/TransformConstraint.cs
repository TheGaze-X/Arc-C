using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	public class TransformConstraint : IUpdatable
	{
		// Token: 0x06000442 RID: 1090 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x4E73640", Offset = "0x4E72240", VA = "0x184E73640")]
		public TransformConstraint(TransformConstraintData data, Skeleton skeleton)
		{
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x4E73960", Offset = "0x4E72560", VA = "0x184E73960")]
		public TransformConstraint(TransformConstraint constraint, Skeleton skeleton)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x4E735F0", Offset = "0x4E721F0", VA = "0x184E735F0")]
		public void Apply()
		{
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x4E735F0", Offset = "0x4E721F0", VA = "0x184E735F0", Slot = "4")]
		public void Update()
		{
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x4E72550", Offset = "0x4E71150", VA = "0x184E72550")]
		private void ApplyAbsoluteWorld()
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x4E72F50", Offset = "0x4E71B50", VA = "0x184E72F50")]
		private void ApplyRelativeWorld()
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x4E72220", Offset = "0x4E70E20", VA = "0x184E72220")]
		private void ApplyAbsoluteLocal()
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x4E72CE0", Offset = "0x4E718E0", VA = "0x184E72CE0")]
		private void ApplyRelativeLocal()
		{
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000158")]
		public ExposedList<Bone> Bones
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000159")]
		public Bone Target
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00003D7C File Offset: 0x00001F7C
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700015A")]
		public float RotateMix
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x7E7510", Offset = "0x7E6110", VA = "0x1807E7510")]
			set
			{
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00003D94 File Offset: 0x00001F94
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700015B")]
		public float TranslateMix
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x4E4C110", Offset = "0x4E4AD10", VA = "0x184E4C110")]
			set
			{
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00003DAC File Offset: 0x00001FAC
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700015C")]
		public float ScaleMix
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
			set
			{
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00003DC4 File Offset: 0x00001FC4
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700015D")]
		public float ShearMix
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x16923F0", Offset = "0x1690FF0", VA = "0x1816923F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x16928C0", Offset = "0x16914C0", VA = "0x1816928C0")]
			set
			{
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00003DDC File Offset: 0x00001FDC
		[Token(Token = "0x1700015E")]
		public bool Active
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700015F")]
		public TransformConstraintData Data
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x319C1D0", Offset = "0x319ADD0", VA = "0x18319C1D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x10")]
		internal TransformConstraintData data;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x18")]
		internal ExposedList<Bone> bones;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x20")]
		internal Bone target;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x28")]
		internal float rotateMix;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x2C")]
		internal float translateMix;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x30")]
		internal float scaleMix;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x34")]
		internal float shearMix;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x38")]
		internal bool active;
	}
}
