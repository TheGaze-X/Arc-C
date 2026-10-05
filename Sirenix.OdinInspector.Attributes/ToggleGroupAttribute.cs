using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class ToggleGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x4E1BF10", Offset = "0x4E1AB10", VA = "0x184E1BF10")]
		public ToggleGroupAttribute(string toggleMemberName, float order = 0f, [Optional] string groupTitle)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x4E1BFC0", Offset = "0x4E1ABC0", VA = "0x184E1BFC0")]
		public ToggleGroupAttribute(string toggleMemberName, string groupTitle)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x4E1BF10", Offset = "0x4E1AB10", VA = "0x184E1BF10")]
		[Obsolete("Use [ToggleGroup(\"toggleMemberName\", groupTitle: \"$titleStringMemberName\")] instead")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ToggleGroupAttribute(string toggleMemberName, float order, string groupTitle, string titleStringMemberName)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000056")]
		public string ToggleMemberName
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		[Obsolete("Add a $ infront of group title instead, i.e: \"$MyStringMember\".")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string TitleStringMemberName
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x4E1BE60", Offset = "0x4E1AA60", VA = "0x184E1BE60", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string ToggleGroupTitle;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool CollapseOthersOnExpand;
	}
}
