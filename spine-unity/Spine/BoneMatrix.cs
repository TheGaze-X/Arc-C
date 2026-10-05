using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public struct BoneMatrix
	{
		// Token: 0x0600047A RID: 1146 RVA: 0x00003F5C File Offset: 0x0000215C
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x4E5E9C0", Offset = "0x4E5D5C0", VA = "0x184E5E9C0")]
		public static BoneMatrix CalculateSetupWorld(BoneData boneData)
		{
			return default(BoneMatrix);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00003F74 File Offset: 0x00002174
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x4E5EA90", Offset = "0x4E5D690", VA = "0x184E5EA90")]
		private static BoneMatrix GetInheritedInternal(BoneData boneData, BoneMatrix parentMatrix)
		{
			return default(BoneMatrix);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x4E5F360", Offset = "0x4E5DF60", VA = "0x184E5F360")]
		public BoneMatrix(BoneData boneData)
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x4E5F450", Offset = "0x4E5E050", VA = "0x184E5F450")]
		public BoneMatrix(Bone bone)
		{
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00003F8C File Offset: 0x0000218C
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x4E5F280", Offset = "0x4E5DE80", VA = "0x184E5F280")]
		public BoneMatrix TransformMatrix(BoneMatrix local)
		{
			return default(BoneMatrix);
		}

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x0")]
		public float a;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x4")]
		public float b;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x8")]
		public float c;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0xC")]
		public float d;

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x10")]
		public float x;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x14")]
		public float y;
	}
}
