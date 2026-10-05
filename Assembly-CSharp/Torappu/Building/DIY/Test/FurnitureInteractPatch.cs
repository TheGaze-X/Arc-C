using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x020018FC RID: 6396
	[Token(Token = "0x20018FC")]
	[Serializable]
	public class FurnitureInteractPatch
	{
		// Token: 0x0600A13D RID: 41277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A13D")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A13E RID: 41278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A13E")]
		[Address(RVA = "0x31CB400", Offset = "0x31CA000", VA = "0x1831CB400")]
		public FurnitureInteractPatch()
		{
		}

		// Token: 0x04009778 RID: 38776
		[Token(Token = "0x4009778")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public string furnitureId;

		// Token: 0x04009779 RID: 38777
		[Token(Token = "0x4009779")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public string entityPath;

		// Token: 0x0400977A RID: 38778
		[Token(Token = "0x400977A")]
		[FieldOffset(Offset = "0x20")]
		public List<FurnitureInteractPatch.Point> points;

		// Token: 0x020018FD RID: 6397
		[Token(Token = "0x20018FD")]
		[Serializable]
		public class Point
		{
			// Token: 0x0600A13F RID: 41279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A13F")]
			[Address(RVA = "0x31D1BC0", Offset = "0x31D07C0", VA = "0x1831D1BC0")]
			public static FurnitureInteractPatch.Point CreateFromAttachPoint(FurnitureEntity.AttachPoint attachPoint)
			{
				return null;
			}

			// Token: 0x0600A140 RID: 41280 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A140")]
			[Address(RVA = "0x31D1F30", Offset = "0x31D0B30", VA = "0x1831D1F30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600A141 RID: 41281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A141")]
			[Address(RVA = "0x31D1F90", Offset = "0x31D0B90", VA = "0x1831D1F90")]
			public Point()
			{
			}

			// Token: 0x0400977B RID: 38779
			[Token(Token = "0x400977B")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public string nodeName;

			// Token: 0x0400977C RID: 38780
			[Token(Token = "0x400977C")]
			[FieldOffset(Offset = "0x18")]
			[Restrict("_SelectableInteracts")]
			public string animationKey;

			// Token: 0x0400977D RID: 38781
			[Token(Token = "0x400977D")]
			[FieldOffset(Offset = "0x20")]
			public SharedConsts.LeftOrRight leftOrRight;

			// Token: 0x0400977E RID: 38782
			[Token(Token = "0x400977E")]
			[FieldOffset(Offset = "0x24")]
			public bool specifyDir;

			// Token: 0x0400977F RID: 38783
			[Token(Token = "0x400977F")]
			[FieldOffset(Offset = "0x28")]
			public Vector2 interactTime;

			// Token: 0x04009780 RID: 38784
			[Token(Token = "0x4009780")]
			[FieldOffset(Offset = "0x30")]
			[Restrict("EditorSelectableInteractIds")]
			public string interactId;

			// Token: 0x04009781 RID: 38785
			[Token(Token = "0x4009781")]
			[FieldOffset(Offset = "0x38")]
			public FurnitureEntity.IntPair[] entries;

			// Token: 0x04009782 RID: 38786
			[Token(Token = "0x4009782")]
			[FieldOffset(Offset = "0x40")]
			public Vector3 targetPos;
		}
	}
}
