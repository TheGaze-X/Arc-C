using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	public class SpineAttachment : SpineAttributeBase
	{
		// Token: 0x060006DE RID: 1758 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x4E9E930", Offset = "0x4E9D530", VA = "0x184E9E930")]
		public SpineAttachment(bool currentSkinOnly = true, bool returnAttachmentPath = false, bool placeholdersOnly = false, string slotField = "", string dataField = "", string skinField = "", bool includeNone = true, bool fallbackToTextField = false)
		{
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00004694 File Offset: 0x00002894
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x4E9E900", Offset = "0x4E9D500", VA = "0x184E9E900")]
		public static SpineAttachment.Hierarchy GetHierarchy(string fullPath)
		{
			return default(SpineAttachment.Hierarchy);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x4E9E860", Offset = "0x4E9D460", VA = "0x184E9E860")]
		public static Attachment GetAttachment(string attachmentPath, SkeletonData skeletonData)
		{
			return null;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x4E9E7A0", Offset = "0x4E9D3A0", VA = "0x184E9E7A0")]
		public static Attachment GetAttachment(string attachmentPath, SkeletonDataAsset skeletonDataAsset)
		{
			return null;
		}

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x28")]
		public bool returnAttachmentPath;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x29")]
		public bool currentSkinOnly;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x2A")]
		public bool placeholdersOnly;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x30")]
		public string skinField;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x38")]
		public string slotField;

		// Token: 0x020000C0 RID: 192
		[Token(Token = "0x20000C0")]
		public struct Hierarchy
		{
			// Token: 0x060006E2 RID: 1762 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x4E8E960", Offset = "0x4E8D560", VA = "0x184E8E960")]
			public Hierarchy(string fullPath)
			{
			}

			// Token: 0x04000460 RID: 1120
			[Token(Token = "0x4000460")]
			[FieldOffset(Offset = "0x0")]
			public string skin;

			// Token: 0x04000461 RID: 1121
			[Token(Token = "0x4000461")]
			[FieldOffset(Offset = "0x8")]
			public string slot;

			// Token: 0x04000462 RID: 1122
			[Token(Token = "0x4000462")]
			[FieldOffset(Offset = "0x10")]
			public string name;
		}
	}
}
