using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public class TypeFilterAttribute : Attribute
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the FilterGetter member instead.", false)]
		public string MemberName
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public TypeFilterAttribute(string filterGetter)
		{
		}

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x10")]
		public string FilterGetter;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x18")]
		public string DropdownTitle;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x20")]
		public bool DrawValueNormally;
	}
}
