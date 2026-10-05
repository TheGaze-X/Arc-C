using System;
using FullInspector.Rotorz.ReorderableList;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BF3 RID: 31731
	[Token(Token = "0x2007BF3")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorCollectionRotorzFlagsAttribute : Attribute
	{
		// Token: 0x170067FF RID: 26623
		// (get) Token: 0x0602C660 RID: 181856 RVA: 0x000DFFC8 File Offset: 0x000DE1C8
		// (set) Token: 0x0602C661 RID: 181857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067FF")]
		public bool DisableReordering
		{
			[Token(Token = "0x602C660")]
			[Address(RVA = "0x2861370", Offset = "0x285FF70", VA = "0x182861370")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C661")]
			[Address(RVA = "0x2861380", Offset = "0x285FF80", VA = "0x182861380")]
			set
			{
			}
		}

		// Token: 0x17006800 RID: 26624
		// (get) Token: 0x0602C662 RID: 181858 RVA: 0x000DFFE0 File Offset: 0x000DE1E0
		// (set) Token: 0x0602C663 RID: 181859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006800")]
		public bool HideAddButton
		{
			[Token(Token = "0x602C662")]
			[Address(RVA = "0xF5B8C0", Offset = "0xF5A4C0", VA = "0x180F5B8C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C663")]
			[Address(RVA = "0x28613A0", Offset = "0x285FFA0", VA = "0x1828613A0")]
			set
			{
			}
		}

		// Token: 0x17006801 RID: 26625
		// (get) Token: 0x0602C664 RID: 181860 RVA: 0x000DFFF8 File Offset: 0x000DE1F8
		// (set) Token: 0x0602C665 RID: 181861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006801")]
		public bool HideRemoveButtons
		{
			[Token(Token = "0x602C664")]
			[Address(RVA = "0xF5B900", Offset = "0xF5A500", VA = "0x180F5B900")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C665")]
			[Address(RVA = "0x28613C0", Offset = "0x285FFC0", VA = "0x1828613C0")]
			set
			{
			}
		}

		// Token: 0x17006802 RID: 26626
		// (get) Token: 0x0602C666 RID: 181862 RVA: 0x000E0010 File Offset: 0x000DE210
		// (set) Token: 0x0602C667 RID: 181863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006802")]
		public bool ShowIndices
		{
			[Token(Token = "0x602C666")]
			[Address(RVA = "0xF5B910", Offset = "0xF5A510", VA = "0x180F5B910")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C667")]
			[Address(RVA = "0x28613E0", Offset = "0x285FFE0", VA = "0x1828613E0")]
			set
			{
			}
		}

		// Token: 0x0602C668 RID: 181864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C668")]
		[Address(RVA = "0x2861350", Offset = "0x285FF50", VA = "0x182861350")]
		private void UpdateFlag(bool shouldSet, ReorderableListFlags flag)
		{
		}

		// Token: 0x0602C669 RID: 181865 RVA: 0x000E0028 File Offset: 0x000DE228
		[Token(Token = "0x602C669")]
		[Address(RVA = "0x2861340", Offset = "0x285FF40", VA = "0x182861340")]
		private bool HasFlag(ReorderableListFlags flag)
		{
			return default(bool);
		}

		// Token: 0x0602C66A RID: 181866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C66A")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public InspectorCollectionRotorzFlagsAttribute()
		{
		}

		// Token: 0x04040293 RID: 262803
		[Token(Token = "0x4040293")]
		[FieldOffset(Offset = "0x10")]
		public ReorderableListFlags Flags;
	}
}
