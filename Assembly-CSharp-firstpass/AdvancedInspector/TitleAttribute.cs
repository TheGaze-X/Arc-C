using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedInspector
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class TitleAttribute : Attribute, IRuntimeAttribute<TitleAttribute>, IRuntimeAttribute
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000068")]
		public string Message
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002568 File Offset: 0x00000768
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000069")]
		public FontStyle Style
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return FontStyle.Normal;
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006A")]
		public string MethodName
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006B")]
		public Type Template
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x4F5E30", Offset = "0x4F4A30", VA = "0x1804F5E30", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006C")]
		public Type TemplateStatic
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x4F5DD0", Offset = "0x4F49D0", VA = "0x1804F5DD0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006D")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4F57B0", Offset = "0x4F43B0", VA = "0x1804F57B0", Slot = "7")]
		public TitleAttribute Invoke(int index, object instance, object value)
		{
			return null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4F5CF0", Offset = "0x4F48F0", VA = "0x1804F5CF0")]
		public TitleAttribute(string methodName)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4F5C10", Offset = "0x4F4810", VA = "0x1804F5C10")]
		public TitleAttribute(FontStyle style, string message)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x4F5B20", Offset = "0x4F4720", VA = "0x1804F5B20")]
		public TitleAttribute(Delegate method)
		{
		}

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x10")]
		private string message;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x18")]
		private FontStyle style;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x20")]
		private string methodName;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x28")]
		private List<Delegate> delegates;

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x060001B1 RID: 433
		[Token(Token = "0x200003A")]
		public delegate TitleAttribute TitleDelegate();

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x060001B5 RID: 437
		[Token(Token = "0x200003B")]
		public delegate TitleAttribute TitleStaticDelegate(TitleAttribute title, object instance, object value);
	}
}
