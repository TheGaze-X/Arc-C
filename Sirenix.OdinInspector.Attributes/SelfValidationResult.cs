using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public class SelfValidationResult
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x1700005C")]
		public int Count
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700005D RID: 93
		[Token(Token = "0x1700005D")]
		public SelfValidationResult.ResultItem this[int index]
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x4E1AF80", Offset = "0x4E19B80", VA = "0x184E1AF80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x4E1AB20", Offset = "0x4E19720", VA = "0x184E1AB20")]
		public ref SelfValidationResult.ResultItem AddError(string error)
		{
			return null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x4E1ABD0", Offset = "0x4E197D0", VA = "0x184E1ABD0")]
		public ref SelfValidationResult.ResultItem AddWarning(string warning)
		{
			return null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x4E1AE40", Offset = "0x4E19A40", VA = "0x184E1AE40")]
		public ref SelfValidationResult.ResultItem Add(ValidatorSeverity severity, string message)
		{
			return null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x4E1AC80", Offset = "0x4E19880", VA = "0x184E1AC80")]
		public ref SelfValidationResult.ResultItem Add(SelfValidationResult.ResultItem item)
		{
			return null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SelfValidationResult()
		{
		}

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x0")]
		private static SelfValidationResult.ResultItem NoResultItem;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x10")]
		private SelfValidationResult.ResultItem[] items;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x18")]
		private int itemsCount;

		// Token: 0x02000090 RID: 144
		[Token(Token = "0x2000090")]
		public struct ContextMenuItem
		{
			// Token: 0x0400027E RID: 638
			[Token(Token = "0x400027E")]
			[FieldOffset(Offset = "0x0")]
			public string Path;

			// Token: 0x0400027F RID: 639
			[Token(Token = "0x400027F")]
			[FieldOffset(Offset = "0x8")]
			public bool On;

			// Token: 0x04000280 RID: 640
			[Token(Token = "0x4000280")]
			[FieldOffset(Offset = "0x9")]
			public bool AddSeparatorBefore;

			// Token: 0x04000281 RID: 641
			[Token(Token = "0x4000281")]
			[FieldOffset(Offset = "0x10")]
			public Action OnClick;
		}

		// Token: 0x02000091 RID: 145
		[Token(Token = "0x2000091")]
		public enum ResultType
		{
			// Token: 0x04000283 RID: 643
			[Token(Token = "0x4000283")]
			Error,
			// Token: 0x04000284 RID: 644
			[Token(Token = "0x4000284")]
			Warning,
			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000285")]
			Valid
		}

		// Token: 0x02000092 RID: 146
		[Token(Token = "0x2000092")]
		public struct ResultItem
		{
			// Token: 0x04000286 RID: 646
			[Token(Token = "0x4000286")]
			[FieldOffset(Offset = "0x0")]
			public string Message;

			// Token: 0x04000287 RID: 647
			[Token(Token = "0x4000287")]
			[FieldOffset(Offset = "0x8")]
			public SelfValidationResult.ResultType ResultType;

			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000288")]
			[FieldOffset(Offset = "0x10")]
			public SelfFix? Fix;

			// Token: 0x04000289 RID: 649
			[Token(Token = "0x4000289")]
			[FieldOffset(Offset = "0x30")]
			public SelfValidationResult.ResultItemMetaData[] MetaData;

			// Token: 0x0400028A RID: 650
			[Token(Token = "0x400028A")]
			[FieldOffset(Offset = "0x38")]
			public Func<IEnumerable<SelfValidationResult.ContextMenuItem>> OnContextClick;

			// Token: 0x0400028B RID: 651
			[Token(Token = "0x400028B")]
			[FieldOffset(Offset = "0x40")]
			public Action OnSceneGUI;

			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400028C")]
			[FieldOffset(Offset = "0x48")]
			public UnityEngine.Object SelectionObject;

			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400028D")]
			[FieldOffset(Offset = "0x50")]
			public bool RichText;
		}

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		public struct ResultItemMetaData
		{
			// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x17F8010", Offset = "0x17F6C10", VA = "0x1817F8010")]
			public ResultItemMetaData(string name, object value, params Attribute[] attributes)
			{
			}

			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			[FieldOffset(Offset = "0x0")]
			public string Name;

			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			[FieldOffset(Offset = "0x8")]
			public object Value;

			// Token: 0x04000290 RID: 656
			[Token(Token = "0x4000290")]
			[FieldOffset(Offset = "0x10")]
			public Attribute[] Attributes;
		}
	}
}
