using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	public sealed class OnInspectorGUIAttribute : ShowInInspectorAttribute
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public OnInspectorGUIAttribute()
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x4E19110", Offset = "0x4E17D10", VA = "0x184E19110")]
		public OnInspectorGUIAttribute(string action, bool append = true)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2637490", Offset = "0x2636090", VA = "0x182637490")]
		public OnInspectorGUIAttribute(string prepend, string append)
		{
		}

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x10")]
		public string Prepend;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x18")]
		public string Append;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x20")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the Prepend member instead.", false)]
		public string PrependMethodName;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x28")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the Append member instead.", false)]
		public string AppendMethodName;
	}
}
