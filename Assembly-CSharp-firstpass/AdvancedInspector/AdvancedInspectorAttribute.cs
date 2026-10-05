using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, Inherited = true)]
	public class AdvancedInspectorAttribute : Attribute
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public static event AdvancedInspectorForceRefresh OnForceRefresh
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x4E6240", Offset = "0x4E4E40", VA = "0x1804E6240")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x4E6320", Offset = "0x4E4F20", VA = "0x1804E6320")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4E6160", Offset = "0x4E4D60", VA = "0x1804E6160")]
		public static void Refresh(bool rebuild = false)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public bool InspectDefaultItems
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public bool ShowScript
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
			set
			{
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4E61C0", Offset = "0x4E4DC0", VA = "0x1804E61C0")]
		public AdvancedInspectorAttribute()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4E6210", Offset = "0x4E4E10", VA = "0x1804E6210")]
		public AdvancedInspectorAttribute(bool inspectDefaultItems)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4E61D0", Offset = "0x4E4DD0", VA = "0x1804E61D0")]
		public AdvancedInspectorAttribute(bool inspectDefaultItems, bool showScript)
		{
		}

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		private bool inspectDefaultItems;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x11")]
		private bool showScript;
	}
}
