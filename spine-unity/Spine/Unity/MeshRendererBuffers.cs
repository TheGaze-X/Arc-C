using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	public class MeshRendererBuffers : IDisposable
	{
		// Token: 0x060006B8 RID: 1720 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x4E94FF0", Offset = "0x4E93BF0", VA = "0x184E94FF0")]
		public void Initialize()
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x4E94F60", Offset = "0x4E93B60", VA = "0x184E94F60")]
		public Material[] GetUpdatedSharedMaterialsArray()
		{
			return null;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0000464C File Offset: 0x0000284C
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x4E95140", Offset = "0x4E93D40", VA = "0x184E95140")]
		public bool MaterialsChangedInLastUpdate()
		{
			return default(bool);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x4E951C0", Offset = "0x4E93DC0", VA = "0x184E951C0")]
		public void UpdateSharedMaterials(ExposedList<SubmeshInstruction> instructions)
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x4E94F10", Offset = "0x4E93B10", VA = "0x184E94F10")]
		public MeshRendererBuffers.SmartMesh GetNextMesh()
		{
			return null;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x4E94E00", Offset = "0x4E93A00", VA = "0x184E94E00")]
		public void Clear()
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x4E94E70", Offset = "0x4E93A70", VA = "0x184E94E70", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x4E95310", Offset = "0x4E93F10", VA = "0x184E95310")]
		public MeshRendererBuffers()
		{
		}

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x10")]
		private DoubleBuffered<MeshRendererBuffers.SmartMesh> doubleBufferedMesh;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x18")]
		internal readonly ExposedList<Material> submeshMaterials;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x20")]
		internal Material[] sharedMaterials;

		// Token: 0x020000B0 RID: 176
		[Token(Token = "0x20000B0")]
		public class SmartMesh : IDisposable
		{
			// Token: 0x060006C0 RID: 1728 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x4E9E4C0", Offset = "0x4E9D0C0", VA = "0x184E9E4C0")]
			public void Clear()
			{
			}

			// Token: 0x060006C1 RID: 1729 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x4E9E500", Offset = "0x4E9D100", VA = "0x184E9E500", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060006C2 RID: 1730 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x4E9E5A0", Offset = "0x4E9D1A0", VA = "0x184E9E5A0")]
			public SmartMesh()
			{
			}

			// Token: 0x0400043C RID: 1084
			[Token(Token = "0x400043C")]
			[FieldOffset(Offset = "0x10")]
			public Mesh mesh;

			// Token: 0x0400043D RID: 1085
			[Token(Token = "0x400043D")]
			[FieldOffset(Offset = "0x18")]
			public SkeletonRendererInstruction instructionUsed;
		}
	}
}
