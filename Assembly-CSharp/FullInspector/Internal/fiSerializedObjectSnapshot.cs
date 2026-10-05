using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007CA7 RID: 31911
	[Token(Token = "0x2007CA7")]
	public class fiSerializedObjectSnapshot
	{
		// Token: 0x0602C92A RID: 182570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C92A")]
		[Address(RVA = "0x2872A80", Offset = "0x2871680", VA = "0x182872A80")]
		public fiSerializedObjectSnapshot(ISerializedObject obj)
		{
		}

		// Token: 0x0602C92B RID: 182571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C92B")]
		[Address(RVA = "0x28728A0", Offset = "0x28714A0", VA = "0x1828728A0")]
		public void RestoreSnapshot(ISerializedObject target)
		{
		}

		// Token: 0x17006850 RID: 26704
		// (get) Token: 0x0602C92C RID: 182572 RVA: 0x000E0E20 File Offset: 0x000DF020
		[Token(Token = "0x17006850")]
		public bool IsEmpty
		{
			[Token(Token = "0x602C92C")]
			[Address(RVA = "0x2872C00", Offset = "0x2871800", VA = "0x182872C00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C92D RID: 182573 RVA: 0x000E0E38 File Offset: 0x000DF038
		[Token(Token = "0x602C92D")]
		[Address(RVA = "0x28726B0", Offset = "0x28712B0", VA = "0x1828726B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0602C92E RID: 182574 RVA: 0x000E0E50 File Offset: 0x000DF050
		[Token(Token = "0x602C92E")]
		[Address(RVA = "0x28727C0", Offset = "0x28713C0", VA = "0x1828727C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0602C92F RID: 182575 RVA: 0x000E0E68 File Offset: 0x000DF068
		[Token(Token = "0x602C92F")]
		[Address(RVA = "0x2872C60", Offset = "0x2871860", VA = "0x182872C60")]
		public static bool operator ==(fiSerializedObjectSnapshot a, fiSerializedObjectSnapshot b)
		{
			return default(bool);
		}

		// Token: 0x0602C930 RID: 182576 RVA: 0x000E0E80 File Offset: 0x000DF080
		[Token(Token = "0x602C930")]
		[Address(RVA = "0x2872C70", Offset = "0x2871870", VA = "0x182872C70")]
		public static bool operator !=(fiSerializedObjectSnapshot a, fiSerializedObjectSnapshot b)
		{
			return default(bool);
		}

		// Token: 0x0602C931 RID: 182577 RVA: 0x000E0E98 File Offset: 0x000DF098
		[Token(Token = "0x602C931")]
		private static bool AreEqual<T>(List<T> a, List<T> b)
		{
			return default(bool);
		}

		// Token: 0x040403CC RID: 263116
		[Token(Token = "0x40403CC")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<string> _keys;

		// Token: 0x040403CD RID: 263117
		[Token(Token = "0x40403CD")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<string> _values;

		// Token: 0x040403CE RID: 263118
		[Token(Token = "0x40403CE")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<UnityEngine.Object> _objectReferences;
	}
}
