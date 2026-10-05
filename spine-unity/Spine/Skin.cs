using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Spine.Collections;

namespace Spine
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	public class Skin
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000136")]
		public string Name
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000137")]
		public OrderedDictionary<Skin.SkinEntry, Attachment> Attachments
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000138")]
		public ExposedList<BoneData> Bones
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000139")]
		public ExposedList<ConstraintData> Constraints
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x4E71570", Offset = "0x4E70170", VA = "0x184E71570")]
		public Skin(string name)
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x4E71380", Offset = "0x4E6FF80", VA = "0x184E71380")]
		public void SetAttachment(int slotIndex, string name, Attachment attachment)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x4E6FFC0", Offset = "0x4E6EBC0", VA = "0x184E6FFC0")]
		public void AddSkin(Skin skin)
		{
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x4E70840", Offset = "0x4E6F440", VA = "0x184E70840")]
		public void CopySkin(Skin skin)
		{
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x4E70E50", Offset = "0x4E6FA50", VA = "0x184E70E50")]
		public Attachment GetAttachment(int slotIndex, string name)
		{
			return null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x4E71210", Offset = "0x4E6FE10", VA = "0x184E71210")]
		public void RemoveAttachment(int slotIndex, string name)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x4E70F70", Offset = "0x4E6FB70", VA = "0x184E70F70")]
		public ICollection<Skin.SkinEntry> GetAttachments()
		{
			return null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x4E70FC0", Offset = "0x4E6FBC0", VA = "0x184E70FC0")]
		public void GetAttachments(int slotIndex, List<Skin.SkinEntry> attachments)
		{
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x4E707B0", Offset = "0x4E6F3B0", VA = "0x184E707B0")]
		public void Clear()
		{
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x4E70500", Offset = "0x4E6F100", VA = "0x184E70500")]
		internal void AttachAll(Skeleton skeleton, Skin oldSkin)
		{
		}

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x10")]
		internal string name;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x18")]
		private OrderedDictionary<Skin.SkinEntry, Attachment> attachments;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x20")]
		internal readonly ExposedList<BoneData> bones;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x28")]
		internal readonly ExposedList<ConstraintData> constraints;

		// Token: 0x0200005D RID: 93
		[Token(Token = "0x200005D")]
		public struct SkinEntry
		{
			// Token: 0x06000402 RID: 1026 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x4E6FF30", Offset = "0x4E6EB30", VA = "0x184E6FF30")]
			public SkinEntry(int slotIndex, string name, Attachment attachment)
			{
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x00003B6C File Offset: 0x00001D6C
			[Token(Token = "0x1700013A")]
			public int SlotIndex
			{
				[Token(Token = "0x6000403")]
				[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000404 RID: 1028 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x1700013B")]
			public string Name
			{
				[Token(Token = "0x6000404")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000405 RID: 1029 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x1700013C")]
			public Attachment Attachment
			{
				[Token(Token = "0x6000405")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400025F RID: 607
			[Token(Token = "0x400025F")]
			[FieldOffset(Offset = "0x0")]
			private readonly int slotIndex;

			// Token: 0x04000260 RID: 608
			[Token(Token = "0x4000260")]
			[FieldOffset(Offset = "0x8")]
			private readonly string name;

			// Token: 0x04000261 RID: 609
			[Token(Token = "0x4000261")]
			[FieldOffset(Offset = "0x10")]
			private readonly Attachment attachment;

			// Token: 0x04000262 RID: 610
			[Token(Token = "0x4000262")]
			[FieldOffset(Offset = "0x18")]
			internal readonly int hashCode;
		}

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		private class SkinEntryComparer : IEqualityComparer<Skin.SkinEntry>
		{
			// Token: 0x06000406 RID: 1030 RVA: 0x00003B84 File Offset: 0x00001D84
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x4E6FE10", Offset = "0x4E6EA10", VA = "0x184E6FE10", Slot = "4")]
			private bool Equals(Skin.SkinEntry e1, Skin.SkinEntry e2)
			{
				return default(bool);
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x00003B9C File Offset: 0x00001D9C
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x4E6FE50", Offset = "0x4E6EA50", VA = "0x184E6FE50", Slot = "5")]
			private int GetHashCode(Skin.SkinEntry e)
			{
				return 0;
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SkinEntryComparer()
			{
			}

			// Token: 0x04000263 RID: 611
			[Token(Token = "0x4000263")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly Skin.SkinEntryComparer Instance;
		}
	}
}
