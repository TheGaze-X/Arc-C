using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class ContextMenu : Attribute
	{
		// Token: 0x06000910 RID: 2320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x594A8C0", Offset = "0x59494C0", VA = "0x18594A8C0")]
		public ContextMenu(string itemName)
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x594A870", Offset = "0x5949470", VA = "0x18594A870")]
		public ContextMenu(string itemName, bool isValidateFunction)
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x4E18C60", Offset = "0x4E17860", VA = "0x184E18C60")]
		public ContextMenu(string itemName, bool isValidateFunction, int priority)
		{
		}

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x10")]
		public readonly string menuItem;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool validate;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x1C")]
		public readonly int priority;
	}
}
