using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class PathConstraintData : ConstraintData
	{
		// Token: 0x0600031A RID: 794 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x4E50EA0", Offset = "0x4E4FAA0", VA = "0x184E50EA0")]
		public PathConstraintData(string name)
		{
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170000F4")]
		public ExposedList<BoneData> Bones
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600031D RID: 797 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000F5")]
		public SlotData Target
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000362C File Offset: 0x0000182C
		// (set) Token: 0x0600031F RID: 799 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000F6")]
		public PositionMode PositionMode
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return PositionMode.Fixed;
			}
			[Token(Token = "0x600031F")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			set
			{
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00003644 File Offset: 0x00001844
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000F7")]
		public SpacingMode SpacingMode
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return SpacingMode.Length;
			}
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x4A83F60", Offset = "0x4A82B60", VA = "0x184A83F60")]
			set
			{
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000365C File Offset: 0x0000185C
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000F8")]
		public RotateMode RotateMode
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return RotateMode.Tangent;
			}
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
			set
			{
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00003674 File Offset: 0x00001874
		// (set) Token: 0x06000325 RID: 805 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000F9")]
		public float OffsetRotation
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x7CEE20", Offset = "0x7CDA20", VA = "0x1807CEE20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1692880", Offset = "0x1691480", VA = "0x181692880")]
			set
			{
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000368C File Offset: 0x0000188C
		// (set) Token: 0x06000327 RID: 807 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000FA")]
		public float Position
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x42B1310", Offset = "0x42AFF10", VA = "0x1842B1310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x4469FE0", Offset = "0x4468BE0", VA = "0x184469FE0")]
			set
			{
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000036A4 File Offset: 0x000018A4
		// (set) Token: 0x06000329 RID: 809 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000FB")]
		public float Spacing
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x4E48960", Offset = "0x4E47560", VA = "0x184E48960")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1DE3EA0", Offset = "0x1DE2AA0", VA = "0x181DE3EA0")]
			set
			{
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000036BC File Offset: 0x000018BC
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000FC")]
		public float RotateMix
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x17DB8C0", Offset = "0x17DA4C0", VA = "0x1817DB8C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x17DB8D0", Offset = "0x17DA4D0", VA = "0x1817DB8D0")]
			set
			{
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000036D4 File Offset: 0x000018D4
		// (set) Token: 0x0600032D RID: 813 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000FD")]
		public float TranslateMix
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x17DB8E0", Offset = "0x17DA4E0", VA = "0x1817DB8E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x17DB8F0", Offset = "0x17DA4F0", VA = "0x1817DB8F0")]
			set
			{
			}
		}

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x20")]
		internal ExposedList<BoneData> bones;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x28")]
		internal SlotData target;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x30")]
		internal PositionMode positionMode;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x34")]
		internal SpacingMode spacingMode;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x38")]
		internal RotateMode rotateMode;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x3C")]
		internal float offsetRotation;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x40")]
		internal float position;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x44")]
		internal float spacing;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x48")]
		internal float rotateMix;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x4C")]
		internal float translateMix;
	}
}
