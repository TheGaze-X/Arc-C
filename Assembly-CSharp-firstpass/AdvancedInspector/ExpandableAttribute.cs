using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, Inherited = true)]
	public class ExpandableAttribute : Attribute, IExpandable, IListAttribute
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002208 File Offset: 0x00000408
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public bool Expanded
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public bool Expandable
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public bool AlwaysExpanded
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x4EEB50", Offset = "0x4ED750", VA = "0x1804EEB50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x4EEBD0", Offset = "0x4ED7D0", VA = "0x1804EEBD0")]
			set
			{
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x4E61C0", Offset = "0x4E4DC0", VA = "0x1804E61C0")]
		public ExpandableAttribute()
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x4EEBA0", Offset = "0x4ED7A0", VA = "0x1804EEBA0")]
		public ExpandableAttribute(bool expandable)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x4EEB60", Offset = "0x4ED760", VA = "0x1804EEB60")]
		public ExpandableAttribute(bool expandable, bool expanded)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310", Slot = "7")]
		public bool IsExpandable(object[] instances, object[] values)
		{
			return default(bool);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "8")]
		public bool IsExpanded(object[] instances, object[] values)
		{
			return default(bool);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4EEB50", Offset = "0x4ED750", VA = "0x1804EEB50", Slot = "9")]
		public bool IsAlwaysExpanded(object[] instances, object[] values)
		{
			return default(bool);
		}

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x10")]
		private bool expanded;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x11")]
		private bool expandable;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x12")]
		private bool alwaysExpanded;
	}
}
