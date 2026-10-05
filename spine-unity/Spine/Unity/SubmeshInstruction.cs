using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	public struct SubmeshInstruction
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x0000467C File Offset: 0x0000287C
		[Token(Token = "0x170001C2")]
		public int SlotCount
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xE05840", Offset = "0xE04440", VA = "0x180E05840")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x4E9EEB0", Offset = "0x4E9DAB0", VA = "0x184E9EEB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x0")]
		public Skeleton skeleton;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x8")]
		public int startSlot;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0xC")]
		public int endSlot;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x10")]
		public Material material;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x18")]
		public bool forceSeparate;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x1C")]
		public int preActiveClippingSlotSource;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x20")]
		public int rawTriangleCount;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x24")]
		public int rawVertexCount;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x28")]
		public int rawFirstVertexIndex;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x2C")]
		public bool hasClipping;
	}
}
