using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class HelpAttribute : Attribute, IRuntimeAttribute, IHelp
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000022F8 File Offset: 0x000004F8
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public HelpType Type
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return HelpType.None;
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public string Message
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public HelpPosition Position
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return HelpPosition.After;
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public string Regex
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4EF640", Offset = "0x4EE240", VA = "0x1804EF640", Slot = "12")]
		public IList<HelpItem> GetHelp(object[] instances, object[] values)
		{
			return null;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000037")]
		public string MethodName
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000038")]
		public Type Template
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x4F02F0", Offset = "0x4EEEF0", VA = "0x1804F02F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000039")]
		public Type TemplateStatic
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x4F0290", Offset = "0x4EEE90", VA = "0x1804F0290", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x4EFF30", Offset = "0x4EEB30", VA = "0x1804EFF30")]
		public HelpAttribute(string methodName)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x4F0270", Offset = "0x4EEE70", VA = "0x1804F0270")]
		public HelpAttribute(string methodName, HelpType type, string message)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4F0090", Offset = "0x4EEC90", VA = "0x1804F0090")]
		public HelpAttribute(HelpType type, string message)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4F01F0", Offset = "0x4EEDF0", VA = "0x1804F01F0")]
		public HelpAttribute(HelpType type, HelpPosition position, string message)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x4EFF90", Offset = "0x4EEB90", VA = "0x1804EFF90")]
		public HelpAttribute(string methodName, HelpType type, HelpPosition position, string message)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x4F0100", Offset = "0x4EED00", VA = "0x1804F0100")]
		public HelpAttribute(Delegate method)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x4EFD90", Offset = "0x4EE990", VA = "0x1804EFD90")]
		private static HelpItem IsValueNull(HelpAttribute help, object instance, object value)
		{
			return null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x4EFCA0", Offset = "0x4EE8A0", VA = "0x1804EFCA0")]
		private static HelpItem IsStringNullOrEmpty(HelpAttribute help, object instance, object value)
		{
			return null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x4EFB80", Offset = "0x4EE780", VA = "0x1804EFB80")]
		private static HelpItem IsRegexMatch(HelpAttribute help, object instance, object value)
		{
			return null;
		}

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		public const string IsNull = "HelpAttribute.IsValueNull";

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		public const string IsNullOrEmpty = "HelpAttribute.IsStringNullOrEmpty";

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		public const string IsMatch = "HelpAttribute.IsRegexMatch";

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x10")]
		private HelpType type;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x18")]
		private string message;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x20")]
		private HelpPosition position;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x28")]
		private string regex;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x30")]
		private string methodName;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x38")]
		private List<Delegate> delegates;

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000E1 RID: 225
		[Token(Token = "0x200001C")]
		public delegate HelpItem HelpDelegate();

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000E5 RID: 229
		[Token(Token = "0x200001D")]
		public delegate HelpItem HelpStaticDelegate(HelpAttribute help, object instance, object value);
	}
}
