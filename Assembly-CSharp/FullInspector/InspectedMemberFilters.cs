using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BD7 RID: 31703
	[Token(Token = "0x2007BD7")]
	public static class InspectedMemberFilters
	{
		// Token: 0x0602C5EF RID: 181743 RVA: 0x000DFBF0 File Offset: 0x000DDDF0
		[Token(Token = "0x602C5EF")]
		[Address(RVA = "0x285AFC0", Offset = "0x2859BC0", VA = "0x18285AFC0")]
		private static bool ShouldDisplayProperty(InspectedProperty property)
		{
			return default(bool);
		}

		// Token: 0x0602C5F0 RID: 181744 RVA: 0x000DFC08 File Offset: 0x000DDE08
		[Token(Token = "0x602C5F0")]
		[Address(RVA = "0x285ACC0", Offset = "0x28598C0", VA = "0x18285ACC0")]
		private static bool IsPropertyTypeInspectable(InspectedProperty property)
		{
			return default(bool);
		}

		// Token: 0x0404024C RID: 262732
		[Token(Token = "0x404024C")]
		[FieldOffset(Offset = "0x0")]
		public static IInspectedMemberFilter All;

		// Token: 0x0404024D RID: 262733
		[Token(Token = "0x404024D")]
		[FieldOffset(Offset = "0x8")]
		public static IInspectedMemberFilter FullInspectorSerializedProperties;

		// Token: 0x0404024E RID: 262734
		[Token(Token = "0x404024E")]
		[FieldOffset(Offset = "0x10")]
		public static IInspectedMemberFilter InspectableMembers;

		// Token: 0x0404024F RID: 262735
		[Token(Token = "0x404024F")]
		[FieldOffset(Offset = "0x18")]
		public static IInspectedMemberFilter StaticInspectableMembers;

		// Token: 0x04040250 RID: 262736
		[Token(Token = "0x4040250")]
		[FieldOffset(Offset = "0x20")]
		public static IInspectedMemberFilter ButtonMembers;

		// Token: 0x02007BD8 RID: 31704
		[Token(Token = "0x2007BD8")]
		private class AllFilter : IInspectedMemberFilter
		{
			// Token: 0x0602C5F2 RID: 181746 RVA: 0x000DFC20 File Offset: 0x000DDE20
			[Token(Token = "0x602C5F2")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
			public bool IsInterested(InspectedProperty property)
			{
				return default(bool);
			}

			// Token: 0x0602C5F3 RID: 181747 RVA: 0x000DFC38 File Offset: 0x000DDE38
			[Token(Token = "0x602C5F3")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
			public bool IsInterested(InspectedMethod method)
			{
				return default(bool);
			}

			// Token: 0x0602C5F4 RID: 181748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C5F4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AllFilter()
			{
			}
		}

		// Token: 0x02007BD9 RID: 31705
		[Token(Token = "0x2007BD9")]
		private class FullInspectorSerializedPropertiesFilter : IInspectedMemberFilter
		{
			// Token: 0x0602C5F5 RID: 181749 RVA: 0x000DFC50 File Offset: 0x000DDE50
			[Token(Token = "0x602C5F5")]
			[Address(RVA = "0x2857700", Offset = "0x2856300", VA = "0x182857700", Slot = "4")]
			public bool IsInterested(InspectedProperty property)
			{
				return default(bool);
			}

			// Token: 0x0602C5F6 RID: 181750 RVA: 0x000DFC68 File Offset: 0x000DDE68
			[Token(Token = "0x602C5F6")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
			public bool IsInterested(InspectedMethod method)
			{
				return default(bool);
			}

			// Token: 0x0602C5F7 RID: 181751 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C5F7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FullInspectorSerializedPropertiesFilter()
			{
			}
		}

		// Token: 0x02007BDA RID: 31706
		[Token(Token = "0x2007BDA")]
		private class InspectableMembersFilter : IInspectedMemberFilter
		{
			// Token: 0x0602C5F8 RID: 181752 RVA: 0x000DFC80 File Offset: 0x000DDE80
			[Token(Token = "0x602C5F8")]
			[Address(RVA = "0x285AC40", Offset = "0x2859840", VA = "0x18285AC40", Slot = "4")]
			public bool IsInterested(InspectedProperty property)
			{
				return default(bool);
			}

			// Token: 0x0602C5F9 RID: 181753 RVA: 0x000DFC98 File Offset: 0x000DDE98
			[Token(Token = "0x602C5F9")]
			[Address(RVA = "0x285AB90", Offset = "0x2859790", VA = "0x18285AB90", Slot = "5")]
			public bool IsInterested(InspectedMethod method)
			{
				return default(bool);
			}

			// Token: 0x0602C5FA RID: 181754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C5FA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InspectableMembersFilter()
			{
			}
		}

		// Token: 0x02007BDB RID: 31707
		[Token(Token = "0x2007BDB")]
		private class StaticInspectableMembersFilter : IInspectedMemberFilter
		{
			// Token: 0x0602C5FB RID: 181755 RVA: 0x000DFCB0 File Offset: 0x000DDEB0
			[Token(Token = "0x602C5FB")]
			[Address(RVA = "0x2863DC0", Offset = "0x28629C0", VA = "0x182863DC0", Slot = "4")]
			public bool IsInterested(InspectedProperty property)
			{
				return default(bool);
			}

			// Token: 0x0602C5FC RID: 181756 RVA: 0x000DFCC8 File Offset: 0x000DDEC8
			[Token(Token = "0x602C5FC")]
			[Address(RVA = "0x2863E30", Offset = "0x2862A30", VA = "0x182863E30", Slot = "5")]
			public bool IsInterested(InspectedMethod method)
			{
				return default(bool);
			}

			// Token: 0x0602C5FD RID: 181757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C5FD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StaticInspectableMembersFilter()
			{
			}
		}

		// Token: 0x02007BDC RID: 31708
		[Token(Token = "0x2007BDC")]
		private class ButtonMembersFilter : IInspectedMemberFilter
		{
			// Token: 0x0602C5FE RID: 181758 RVA: 0x000DFCE0 File Offset: 0x000DDEE0
			[Token(Token = "0x602C5FE")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			public bool IsInterested(InspectedProperty property)
			{
				return default(bool);
			}

			// Token: 0x0602C5FF RID: 181759 RVA: 0x000DFCF8 File Offset: 0x000DDEF8
			[Token(Token = "0x602C5FF")]
			[Address(RVA = "0x2855300", Offset = "0x2853F00", VA = "0x182855300", Slot = "5")]
			public bool IsInterested(InspectedMethod method)
			{
				return default(bool);
			}

			// Token: 0x0602C600 RID: 181760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C600")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ButtonMembersFilter()
			{
			}
		}
	}
}
