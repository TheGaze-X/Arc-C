using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public abstract class PropertyGroupAttribute : Attribute
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x4E17B10", Offset = "0x4E16710", VA = "0x184E17B10")]
		public PropertyGroupAttribute(string groupId, float order)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x4E19950", Offset = "0x4E18550", VA = "0x184E19950")]
		public PropertyGroupAttribute(string groupId)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x4E196F0", Offset = "0x4E182F0", VA = "0x184E196F0")]
		public PropertyGroupAttribute Combine(PropertyGroupAttribute other)
		{
			return null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x10")]
		public string GroupID;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x18")]
		public string GroupName;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x20")]
		public float Order;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x24")]
		public bool HideWhenChildrenAreInvisible;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x28")]
		public string VisibleIf;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x30")]
		public bool AnimateVisibility;
	}
}
