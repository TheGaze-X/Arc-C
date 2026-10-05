using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class OnValueChangedAttribute : Attribute
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the Action member instead.", false)]
		public string MethodName
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x4E19170", Offset = "0x4E17D70", VA = "0x184E19170")]
		public OnValueChangedAttribute(string action, bool includeChildren = false)
		{
		}

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x10")]
		public string Action;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x18")]
		public bool IncludeChildren;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x19")]
		public bool InvokeOnUndoRedo;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x1A")]
		public bool InvokeOnInitialize;
	}
}
