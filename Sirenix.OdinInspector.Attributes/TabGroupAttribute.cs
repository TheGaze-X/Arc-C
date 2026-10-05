using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Sirenix.OdinInspector.Internal;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public class TabGroupAttribute : PropertyGroupAttribute, ISubGroupProviderAttribute
	{
		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x4E1B730", Offset = "0x4E1A330", VA = "0x184E1B730")]
		public TabGroupAttribute(string tab, bool useFixedHeight = false, float order = 0f)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x4E1B7B0", Offset = "0x4E1A3B0", VA = "0x184E1B7B0")]
		public TabGroupAttribute(string group, string tab, bool useFixedHeight = false, float order = 0f)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x4E1B8F0", Offset = "0x4E1A4F0", VA = "0x184E1B8F0")]
		public TabGroupAttribute(string group, string tab, SdfIconType icon, bool useFixedHeight = false, float order = 0f)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x4E1B110", Offset = "0x4E19D10", VA = "0x184E1B110", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x4E1B350", Offset = "0x4E19F50", VA = "0x184E1B350", Slot = "8")]
		private IList<PropertyGroupAttribute> GetSubGroupAttributes()
		{
			return null;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x4E1B660", Offset = "0x4E1A260", VA = "0x184E1B660", Slot = "9")]
		private string RepathMemberAttribute(PropertyGroupAttribute attr)
		{
			return null;
		}

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		public const string DEFAULT_NAME = "_DefaultTabGroup";

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x38")]
		public string TabName;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x40")]
		public string TabId;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x48")]
		public bool UseFixedHeight;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x49")]
		public bool Paddingless;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x4A")]
		public bool HideTabGroupIfTabGroupOnlyHasOneTab;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x50")]
		public string TextColor;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x58")]
		public SdfIconType Icon;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x5C")]
		public TabLayouting TabLayouting;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x60")]
		public List<TabGroupAttribute> Tabs;

		// Token: 0x0200006A RID: 106
		[Token(Token = "0x200006A")]
		[Conditional("UNITY_EDITOR")]
		public class TabSubGroupAttribute : PropertyGroupAttribute
		{
			// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x4E1BA40", Offset = "0x4E1A640", VA = "0x184E1BA40")]
			public TabSubGroupAttribute(TabGroupAttribute tab, string groupId, float order)
			{
			}

			// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x4E1B930", Offset = "0x4E1A530", VA = "0x184E1B930", Slot = "7")]
			protected override void CombineValuesWith(PropertyGroupAttribute other)
			{
			}

			// Token: 0x04000114 RID: 276
			[Token(Token = "0x4000114")]
			[FieldOffset(Offset = "0x38")]
			public TabGroupAttribute Tab;
		}
	}
}
