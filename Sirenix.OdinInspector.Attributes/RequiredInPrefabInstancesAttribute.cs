using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Obsolete("Use [RequiredIn(PrefabKind.PrefabInstance)] instead.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class RequiredInPrefabInstancesAttribute : Attribute
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x4E19B80", Offset = "0x4E18780", VA = "0x184E19B80")]
		public RequiredInPrefabInstancesAttribute()
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x37442C0", Offset = "0x3742EC0", VA = "0x1837442C0")]
		public RequiredInPrefabInstancesAttribute(string errorMessage, InfoMessageType messageType)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x4E19BA0", Offset = "0x4E187A0", VA = "0x184E19BA0")]
		public RequiredInPrefabInstancesAttribute(string errorMessage)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x4E17F70", Offset = "0x4E16B70", VA = "0x184E17F70")]
		public RequiredInPrefabInstancesAttribute(InfoMessageType messageType)
		{
		}

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x10")]
		public string ErrorMessage;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x18")]
		public InfoMessageType MessageType;
	}
}
