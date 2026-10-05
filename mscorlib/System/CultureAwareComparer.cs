using System;
using System.Globalization;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	[System.Serializable]
	public sealed class CultureAwareComparer : System.StringComparer, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x4CF4FB0", Offset = "0x4CF3BB0", VA = "0x184CF4FB0")]
		internal CultureAwareComparer(System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options)
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x4CF5350", Offset = "0x4CF3F50", VA = "0x184CF5350")]
		internal CultureAwareComparer(System.Globalization.CompareInfo compareInfo, System.Globalization.CompareOptions options)
		{
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x4CF50D0", Offset = "0x4CF3CD0", VA = "0x184CF50D0")]
		private CultureAwareComparer(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0000A038 File Offset: 0x00008238
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x4CF4C80", Offset = "0x4CF3880", VA = "0x184CF4C80", Slot = "10")]
		public override int Compare(string x, string y)
		{
			return 0;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x4CF4CE0", Offset = "0x4CF38E0", VA = "0x184CF4CE0", Slot = "11")]
		public override bool Equals(string x, string y)
		{
			return default(bool);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0000A068 File Offset: 0x00008268
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x4CF4E50", Offset = "0x4CF3A50", VA = "0x184CF4E50", Slot = "12")]
		public override int GetHashCode(string obj)
		{
			return 0;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0000A080 File Offset: 0x00008280
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x4CF4D40", Offset = "0x4CF3940", VA = "0x184CF4D40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0000A098 File Offset: 0x00008298
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x4CF4DF0", Offset = "0x4CF39F0", VA = "0x184CF4DF0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x4CF4EE0", Offset = "0x4CF3AE0", VA = "0x184CF4EE0", Slot = "13")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x10")]
		private readonly System.Globalization.CompareInfo _compareInfo;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x18")]
		private System.Globalization.CompareOptions _options;
	}
}
