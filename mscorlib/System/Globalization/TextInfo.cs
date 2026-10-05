using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000588 RID: 1416
	[Token(Token = "0x2000588")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class TextInfo : System.ICloneable, System.Runtime.Serialization.IDeserializationCallback
	{
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700065C")]
		internal static TextInfo Invariant
		{
			[Token(Token = "0x6002A24")]
			[Address(RVA = "0x4C3A710", Offset = "0x4C39310", VA = "0x184C3A710")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x4C3A660", Offset = "0x4C39260", VA = "0x184C3A660")]
		internal TextInfo(CultureData cultureData)
		{
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x4C38EE0", Offset = "0x4C37AE0", VA = "0x184C38EE0")]
		[System.Runtime.Serialization.OnDeserializing]
		private void OnDeserializing(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x4C38D90", Offset = "0x4C37990", VA = "0x184C38D90")]
		private void OnDeserialized()
		{
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x4C38ED0", Offset = "0x4C37AD0", VA = "0x184C38ED0")]
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserialized(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x4C38F20", Offset = "0x4C37B20", VA = "0x184C38F20")]
		[System.Runtime.Serialization.OnSerializing]
		private void OnSerializing(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x00017748 File Offset: 0x00015948
		[Token(Token = "0x1700065D")]
		public virtual int OEMCodePage
		{
			[Token(Token = "0x6002A2A")]
			[Address(RVA = "0x4C3A920", Offset = "0x4C39520", VA = "0x184C3A920", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700065E")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public string CultureName
		{
			[Token(Token = "0x6002A2B")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x00017760 File Offset: 0x00015960
		[Token(Token = "0x1700065F")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public bool IsReadOnly
		{
			[Token(Token = "0x6002A2C")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x4C38B20", Offset = "0x4C37720", VA = "0x184C38B20", Slot = "7")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual object Clone()
		{
			return null;
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x4C38FD0", Offset = "0x4C37BD0", VA = "0x184C38FD0")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public static TextInfo ReadOnly(TextInfo textInfo)
		{
			return null;
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
		internal void SetReadOnlyState(bool readOnly)
		{
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x00017778 File Offset: 0x00015978
		[Token(Token = "0x6002A30")]
		[Address(RVA = "0x4C39710", Offset = "0x4C38310", VA = "0x184C39710", Slot = "8")]
		public virtual char ToLower(char c)
		{
			return '\0';
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x4C39770", Offset = "0x4C38370", VA = "0x184C39770", Slot = "9")]
		public virtual string ToLower(string str)
		{
			return null;
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00017790 File Offset: 0x00015990
		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x4C390F0", Offset = "0x4C37CF0", VA = "0x184C390F0")]
		private static char ToLowerAsciiInvariant(char c)
		{
			return '\0';
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000177A8 File Offset: 0x000159A8
		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x4C3A600", Offset = "0x4C39200", VA = "0x184C3A600", Slot = "10")]
		public virtual char ToUpper(char c)
		{
			return '\0';
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A34")]
		[Address(RVA = "0x4C3A4A0", Offset = "0x4C390A0", VA = "0x184C3A4A0", Slot = "11")]
		public virtual string ToUpper(string str)
		{
			return null;
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x000177C0 File Offset: 0x000159C0
		[Token(Token = "0x6002A35")]
		[Address(RVA = "0x4C39D90", Offset = "0x4C38990", VA = "0x184C39D90")]
		internal static char ToUpperAsciiInvariant(char c)
		{
			return '\0';
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000177D8 File Offset: 0x000159D8
		[Token(Token = "0x6002A36")]
		[Address(RVA = "0x4C38D50", Offset = "0x4C37950", VA = "0x184C38D50")]
		private static bool IsAscii(char c)
		{
			return default(bool);
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x000177F0 File Offset: 0x000159F0
		[Token(Token = "0x17000660")]
		private bool IsAsciiCasingSameAsInvariant
		{
			[Token(Token = "0x6002A37")]
			[Address(RVA = "0x4C3A830", Offset = "0x4C39430", VA = "0x184C3A830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x00017808 File Offset: 0x00015A08
		[Token(Token = "0x6002A38")]
		[Address(RVA = "0x4C38C50", Offset = "0x4C37850", VA = "0x184C38C50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x00017820 File Offset: 0x00015A20
		[Token(Token = "0x6002A39")]
		[Address(RVA = "0x4C38D00", Offset = "0x4C37900", VA = "0x184C38D00", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A3A")]
		[Address(RVA = "0x4C398D0", Offset = "0x4C384D0", VA = "0x184C398D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A3B")]
		[Address(RVA = "0x4C39920", Offset = "0x4C38520", VA = "0x184C39920")]
		public string ToTitleCase(string str)
		{
			return null;
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00017838 File Offset: 0x00015A38
		[Token(Token = "0x6002A3C")]
		[Address(RVA = "0x4C38720", Offset = "0x4C37320", VA = "0x184C38720")]
		private static int AddNonLetter(ref System.Text.StringBuilder result, ref string input, int inputIndex, int charLen)
		{
			return 0;
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00017850 File Offset: 0x00015A50
		[Token(Token = "0x6002A3D")]
		[Address(RVA = "0x4C387C0", Offset = "0x4C373C0", VA = "0x184C387C0")]
		private int AddTitlecaseLetter(ref System.Text.StringBuilder result, ref string input, int inputIndex, int charLen)
		{
			return 0;
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00017868 File Offset: 0x00015A68
		[Token(Token = "0x6002A3E")]
		[Address(RVA = "0x4C38D70", Offset = "0x4C37970", VA = "0x184C38D70")]
		private static bool IsWordSeparator(UnicodeCategory category)
		{
			return default(bool);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x00017880 File Offset: 0x00015A80
		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0x4C38D60", Offset = "0x4C37960", VA = "0x184C38D60")]
		private static bool IsLetterCategory(UnicodeCategory uc)
		{
			return default(bool);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A40")]
		[Address(RVA = "0x4C38ED0", Offset = "0x4C37AD0", VA = "0x184C38ED0", Slot = "5")]
		private void OnDeserialization(object sender)
		{
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A41")]
		[Address(RVA = "0x4C3A380", Offset = "0x4C38F80", VA = "0x184C3A380")]
		private string ToUpperInternal(string str)
		{
			return null;
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A42")]
		[Address(RVA = "0x4C395F0", Offset = "0x4C381F0", VA = "0x184C395F0")]
		private string ToLowerInternal(string str)
		{
			return null;
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00017898 File Offset: 0x00015A98
		[Token(Token = "0x6002A43")]
		[Address(RVA = "0x4C39DB0", Offset = "0x4C389B0", VA = "0x184C39DB0")]
		private char ToUpperInternal(char c)
		{
			return '\0';
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x000178B0 File Offset: 0x00015AB0
		[Token(Token = "0x6002A44")]
		[Address(RVA = "0x4C39110", Offset = "0x4C37D10", VA = "0x184C39110")]
		private char ToLowerInternal(char c)
		{
			return '\0';
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A45")]
		[Address(RVA = "0x4C39CE0", Offset = "0x4C388E0", VA = "0x184C39CE0")]
		internal void ToUpperAsciiInvariant(System.ReadOnlySpan<char> source, System.Span<char> destination)
		{
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A46")]
		[Address(RVA = "0x4C38990", Offset = "0x4C37590", VA = "0x184C38990")]
		internal void ChangeCase(System.ReadOnlySpan<char> source, System.Span<char> destination, bool toUpper)
		{
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A47")]
		[Address(RVA = "0x4C3A6E0", Offset = "0x4C392E0", VA = "0x184C3A6E0")]
		internal TextInfo()
		{
		}

		// Token: 0x0400187A RID: 6266
		[Token(Token = "0x400187A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private string m_listSeparator;

		// Token: 0x0400187B RID: 6267
		[Token(Token = "0x400187B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly;

		// Token: 0x0400187C RID: 6268
		[Token(Token = "0x400187C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 3)]
		private string m_cultureName;

		// Token: 0x0400187D RID: 6269
		[Token(Token = "0x400187D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[System.NonSerialized]
		private CultureData m_cultureData;

		// Token: 0x0400187E RID: 6270
		[Token(Token = "0x400187E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[System.NonSerialized]
		private string m_textInfoName;

		// Token: 0x0400187F RID: 6271
		[Token(Token = "0x400187F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[System.NonSerialized]
		private bool? m_IsAsciiCasingSameAsInvariant;

		// Token: 0x04001880 RID: 6272
		[Token(Token = "0x4001880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static TextInfo s_Invariant;

		// Token: 0x04001881 RID: 6273
		[Token(Token = "0x4001881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private string customCultureName;

		// Token: 0x04001882 RID: 6274
		[Token(Token = "0x4001882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal int m_nDataItem;

		// Token: 0x04001883 RID: 6275
		[Token(Token = "0x4001883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal bool m_useUserOverride;

		// Token: 0x04001884 RID: 6276
		[Token(Token = "0x4001884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal int m_win32LangID;

		// Token: 0x04001885 RID: 6277
		[Token(Token = "0x4001885")]
		private const int wordSeparatorMask = 536672256;
	}
}
