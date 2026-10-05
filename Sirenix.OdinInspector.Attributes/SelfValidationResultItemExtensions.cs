using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public static class SelfValidationResultItemExtensions
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x4E1A7B0", Offset = "0x4E193B0", VA = "0x184E1A7B0")]
		public static ref SelfValidationResult.ResultItem WithFix(this SelfValidationResult.ResultItem item, string title, Action fix, bool offerInInspector = true)
		{
			return null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A7")]
		public static ref SelfValidationResult.ResultItem WithFix<T>(this SelfValidationResult.ResultItem item, string title, Action<T> fix, bool offerInInspector = true) where T : new()
		{
			return null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4E1A6B0", Offset = "0x4E192B0", VA = "0x184E1A6B0")]
		public static ref SelfValidationResult.ResultItem WithFix(this SelfValidationResult.ResultItem item, Action fix, bool offerInInspector = true)
		{
			return null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A9")]
		public static ref SelfValidationResult.ResultItem WithFix<T>(this SelfValidationResult.ResultItem item, Action<T> fix, bool offerInInspector = true) where T : new()
		{
			return null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4E1A620", Offset = "0x4E19220", VA = "0x184E1A620")]
		public static ref SelfValidationResult.ResultItem WithFix(this SelfValidationResult.ResultItem item, SelfFix fix)
		{
			return null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x3736A70", Offset = "0x3735670", VA = "0x183736A70")]
		public static ref SelfValidationResult.ResultItem WithContextClick(this SelfValidationResult.ResultItem item, Func<IEnumerable<SelfValidationResult.ContextMenuItem>> onContextClick)
		{
			return null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4E1A350", Offset = "0x4E18F50", VA = "0x184E1A350")]
		public static ref SelfValidationResult.ResultItem WithContextClick(this SelfValidationResult.ResultItem item, string path, Action onClick)
		{
			return null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4E1A520", Offset = "0x4E19120", VA = "0x184E1A520")]
		public static ref SelfValidationResult.ResultItem WithContextClick(this SelfValidationResult.ResultItem item, string path, bool on, Action onClick)
		{
			return null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4E1A440", Offset = "0x4E19040", VA = "0x184E1A440")]
		public static ref SelfValidationResult.ResultItem WithContextClick(this SelfValidationResult.ResultItem item, SelfValidationResult.ContextMenuItem onContextClick)
		{
			return null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x3736A30", Offset = "0x3735630", VA = "0x183736A30")]
		public static ref SelfValidationResult.ResultItem WithSceneGUI(this SelfValidationResult.ResultItem item, Action onSceneGUI)
		{
			return null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x3736A50", Offset = "0x3735650", VA = "0x183736A50")]
		public static ref SelfValidationResult.ResultItem SetSelectionObject(this SelfValidationResult.ResultItem item, UnityEngine.Object uObj)
		{
			return null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x4E1A1E0", Offset = "0x4E18DE0", VA = "0x184E1A1E0")]
		public static ref SelfValidationResult.ResultItem EnableRichText(this SelfValidationResult.ResultItem item)
		{
			return null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x4E1A9E0", Offset = "0x4E195E0", VA = "0x184E1A9E0")]
		public static ref SelfValidationResult.ResultItem WithMetaData(this SelfValidationResult.ResultItem resultItem, string name, object value, params Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x4E1A8A0", Offset = "0x4E194A0", VA = "0x184E1A8A0")]
		public static ref SelfValidationResult.ResultItem WithMetaData(this SelfValidationResult.ResultItem resultItem, object value, params Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4E1A1F0", Offset = "0x4E18DF0", VA = "0x184E1A1F0")]
		public static ref SelfValidationResult.ResultItem WithButton(this SelfValidationResult.ResultItem resultItem, string name, Action onClick)
		{
			return null;
		}
	}
}
