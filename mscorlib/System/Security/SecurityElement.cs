using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace System.Security
{
	// Token: 0x020002C2 RID: 706
	[Token(Token = "0x20002C2")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public sealed class SecurityElement
	{
		// Token: 0x060017B6 RID: 6070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B6")]
		[Address(RVA = "0x4B1ACC0", Offset = "0x4B198C0", VA = "0x184B1ACC0")]
		public SecurityElement(string tag)
		{
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B7")]
		[Address(RVA = "0x4B1ACD0", Offset = "0x4B198D0", VA = "0x184B1ACD0")]
		public SecurityElement(string tag, string text)
		{
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000265")]
		public System.Collections.ArrayList Children
		{
			[Token(Token = "0x60017B8")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000266")]
		public string Tag
		{
			[Token(Token = "0x60017B9")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000267 RID: 615
		// (set) Token: 0x060017BA RID: 6074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000267")]
		public string Text
		{
			[Token(Token = "0x60017BA")]
			[Address(RVA = "0x4B1AFB0", Offset = "0x4B19BB0", VA = "0x184B1AFB0")]
			set
			{
			}
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x4B192E0", Offset = "0x4B17EE0", VA = "0x184B192E0")]
		public void AddAttribute(string name, string value)
		{
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x4B194F0", Offset = "0x4B180F0", VA = "0x184B194F0")]
		public void AddChild(SecurityElement child)
		{
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x4B19600", Offset = "0x4B18200", VA = "0x184B19600")]
		public static string Escape(string str)
		{
			return null;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x4B1A900", Offset = "0x4B19500", VA = "0x184B1A900")]
		private static string Unescape(string str)
		{
			return null;
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x000111C0 File Offset: 0x0000F3C0
		[Token(Token = "0x60017BF")]
		[Address(RVA = "0x4B19A50", Offset = "0x4B18650", VA = "0x184B19A50")]
		public static bool IsValidAttributeName(string name)
		{
			return default(bool);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000111D8 File Offset: 0x0000F3D8
		[Token(Token = "0x60017C0")]
		[Address(RVA = "0x4B19AD0", Offset = "0x4B186D0", VA = "0x184B19AD0")]
		public static bool IsValidAttributeValue(string value)
		{
			return default(bool);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000111F0 File Offset: 0x0000F3F0
		[Token(Token = "0x60017C1")]
		[Address(RVA = "0x4B19B50", Offset = "0x4B18750", VA = "0x184B19B50")]
		public static bool IsValidTag(string tag)
		{
			return default(bool);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00011208 File Offset: 0x0000F408
		[Token(Token = "0x60017C2")]
		[Address(RVA = "0x4B19BD0", Offset = "0x4B187D0", VA = "0x184B19BD0")]
		public static bool IsValidText(string text)
		{
			return default(bool);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017C3")]
		[Address(RVA = "0x4B19C50", Offset = "0x4B18850", VA = "0x184B19C50")]
		public SecurityElement SearchForChildByTag(string tag)
		{
			return null;
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x4B19FE0", Offset = "0x4B18BE0", VA = "0x184B19FE0")]
		public string SearchForTextOfTag(string tag)
		{
			return null;
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x4B1A1B0", Offset = "0x4B18DB0", VA = "0x184B1A1B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x4B1A260", Offset = "0x4B18E60", VA = "0x184B1A260")]
		private void ToXml(ref System.Text.StringBuilder s, int level)
		{
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x4B19800", Offset = "0x4B18400", VA = "0x184B19800")]
		internal SecurityElement.SecurityAttribute GetAttribute(string name)
		{
			return null;
		}

		// Token: 0x17000268 RID: 616
		// (set) Token: 0x060017C8 RID: 6088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000268")]
		internal string m_strText
		{
			[Token(Token = "0x60017C8")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x4B19DF0", Offset = "0x4B189F0", VA = "0x184B19DF0")]
		internal string SearchForTextOfLocalName(string strLocalName)
		{
			return null;
		}

		// Token: 0x04000CCC RID: 3276
		[Token(Token = "0x4000CCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string text;

		// Token: 0x04000CCD RID: 3277
		[Token(Token = "0x4000CCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string tag;

		// Token: 0x04000CCE RID: 3278
		[Token(Token = "0x4000CCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Collections.ArrayList attributes;

		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Collections.ArrayList children;

		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] invalid_tag_chars;

		// Token: 0x04000CD1 RID: 3281
		[Token(Token = "0x4000CD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly char[] invalid_text_chars;

		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly char[] invalid_attr_name_chars;

		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4000CD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly char[] invalid_attr_value_chars;

		// Token: 0x04000CD4 RID: 3284
		[Token(Token = "0x4000CD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly char[] invalid_chars;

		// Token: 0x020002C3 RID: 707
		[Token(Token = "0x20002C3")]
		internal class SecurityAttribute
		{
			// Token: 0x060017CB RID: 6091 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60017CB")]
			[Address(RVA = "0x4B18580", Offset = "0x4B17180", VA = "0x184B18580")]
			public SecurityAttribute(string name, string value)
			{
			}

			// Token: 0x17000269 RID: 617
			// (get) Token: 0x060017CC RID: 6092 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000269")]
			public string Name
			{
				[Token(Token = "0x60017CC")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x060017CD RID: 6093 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700026A")]
			public string Value
			{
				[Token(Token = "0x60017CD")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x04000CD5 RID: 3285
			[Token(Token = "0x4000CD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string _name;

			// Token: 0x04000CD6 RID: 3286
			[Token(Token = "0x4000CD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string _value;
		}
	}
}
