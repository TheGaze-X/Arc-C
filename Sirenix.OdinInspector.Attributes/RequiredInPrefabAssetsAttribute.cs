using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[Obsolete("Use [RequiredIn(PrefabKind.PrefabAsset)] instead.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class RequiredInPrefabAssetsAttribute : Attribute
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4E19B80", Offset = "0x4E18780", VA = "0x184E19B80")]
		public RequiredInPrefabAssetsAttribute()
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x37442C0", Offset = "0x3742EC0", VA = "0x1837442C0")]
		public RequiredInPrefabAssetsAttribute(string errorMessage, InfoMessageType messageType)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x4E19BA0", Offset = "0x4E187A0", VA = "0x184E19BA0")]
		public RequiredInPrefabAssetsAttribute(string errorMessage)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x4E17F70", Offset = "0x4E16B70", VA = "0x184E17F70")]
		public RequiredInPrefabAssetsAttribute(InfoMessageType messageType)
		{
		}

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x10")]
		public string ErrorMessage;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x18")]
		public InfoMessageType MessageType;
	}
}
