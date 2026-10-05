using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	public sealed class ValidateInputAttribute : Attribute
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the Condition member instead.", false)]
		public string MemberName
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the ContinuousValidationCheck member instead.")]
		public bool ContiniousValidationCheck
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x4EA870", Offset = "0x4E9470", VA = "0x1804EA870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x4EAC00", Offset = "0x4E9800", VA = "0x1804EAC00")]
			set
			{
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x4E1C530", Offset = "0x4E1B130", VA = "0x184E1C530")]
		public ValidateInputAttribute(string condition, [Optional] string defaultMessage, InfoMessageType messageType = InfoMessageType.Error)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4E1C530", Offset = "0x4E1B130", VA = "0x184E1C530")]
		[Obsolete("Rejecting invalid input is no longer supported. Use the other constructor instead.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ValidateInputAttribute(string condition, string message, InfoMessageType messageType, bool rejectedInvalidInput)
		{
		}

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string DefaultMessage;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Condition;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InfoMessageType MessageType;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IncludeChildren;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool ContinuousValidationCheck;
	}
}
