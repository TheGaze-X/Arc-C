using System;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200065F RID: 1631
	[Token(Token = "0x200065F")]
	[System.Serializable]
	public abstract class TextWriter : System.MarshalByRefObject, System.IDisposable
	{
		// Token: 0x06003101 RID: 12545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003101")]
		[Address(RVA = "0x4C8B040", Offset = "0x4C89C40", VA = "0x184C8B040")]
		protected TextWriter()
		{
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003102")]
		[Address(RVA = "0x4C8B0E0", Offset = "0x4C89CE0", VA = "0x184C8B0E0")]
		protected TextWriter(System.IFormatProvider formatProvider)
		{
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007D7")]
		public virtual System.IFormatProvider FormatProvider
		{
			[Token(Token = "0x6003103")]
			[Address(RVA = "0x4C8B180", Offset = "0x4C89D80", VA = "0x184C8B180", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003104")]
		[Address(RVA = "0x4C8A520", Offset = "0x4C89120", VA = "0x184C8A520", Slot = "8")]
		public virtual void Close()
		{
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003105")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003106")]
		[Address(RVA = "0x4C8A590", Offset = "0x4C89190", VA = "0x184C8A590", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003107")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		public virtual void Flush()
		{
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06003108 RID: 12552
		[Token(Token = "0x170007D8")]
		public abstract System.Text.Encoding Encoding { [Token(Token = "0x6003108")] get; }

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007D9")]
		public virtual string NewLine
		{
			[Token(Token = "0x6003109")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
		public virtual void Write(char value)
		{
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310B")]
		[Address(RVA = "0x4C8AB60", Offset = "0x4C89760", VA = "0x184C8AB60", Slot = "14")]
		public virtual void Write(char[] buffer)
		{
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310C")]
		[Address(RVA = "0x4C8ABC0", Offset = "0x4C897C0", VA = "0x184C8ABC0", Slot = "15")]
		public virtual void Write(char[] buffer, int index, int count)
		{
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310D")]
		[Address(RVA = "0x4C8AAE0", Offset = "0x4C896E0", VA = "0x184C8AAE0", Slot = "16")]
		public virtual void Write(long value)
		{
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310E")]
		[Address(RVA = "0x4C8AE00", Offset = "0x4C89A00", VA = "0x184C8AE00", Slot = "17")]
		public virtual void Write(string value)
		{
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310F")]
		[Address(RVA = "0x4C8AE60", Offset = "0x4C89A60", VA = "0x184C8AE60", Slot = "18")]
		public virtual void Write(string format, object arg0, object arg1, object arg2)
		{
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003110")]
		[Address(RVA = "0x4C8A7C0", Offset = "0x4C893C0", VA = "0x184C8A7C0", Slot = "19")]
		public virtual void WriteLine()
		{
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003111")]
		[Address(RVA = "0x4C8A810", Offset = "0x4C89410", VA = "0x184C8A810", Slot = "20")]
		public virtual void WriteLine(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003112")]
		[Address(RVA = "0x4C8A740", Offset = "0x4C89340", VA = "0x184C8A740", Slot = "21")]
		public virtual void WriteLine(string value)
		{
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003113")]
		[Address(RVA = "0x4C8A930", Offset = "0x4C89530", VA = "0x184C8A930", Slot = "22")]
		public virtual void WriteLine(object value)
		{
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003114")]
		[Address(RVA = "0x4C8A8A0", Offset = "0x4C894A0", VA = "0x184C8A8A0", Slot = "23")]
		public virtual void WriteLine(string format, object arg0)
		{
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003115")]
		[Address(RVA = "0x4C8A600", Offset = "0x4C89200", VA = "0x184C8A600")]
		public static TextWriter Synchronized(TextWriter writer)
		{
			return null;
		}

		// Token: 0x04001B13 RID: 6931
		[Token(Token = "0x4001B13")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TextWriter Null;

		// Token: 0x04001B14 RID: 6932
		[Token(Token = "0x4001B14")]
		[FieldOffset(Offset = "0x8")]
		private static readonly char[] s_coreNewLine;

		// Token: 0x04001B15 RID: 6933
		[Token(Token = "0x4001B15")]
		[FieldOffset(Offset = "0x18")]
		protected char[] CoreNewLine;

		// Token: 0x04001B16 RID: 6934
		[Token(Token = "0x4001B16")]
		[FieldOffset(Offset = "0x20")]
		private string CoreNewLineStr;

		// Token: 0x04001B17 RID: 6935
		[Token(Token = "0x4001B17")]
		[FieldOffset(Offset = "0x28")]
		private System.IFormatProvider _internalFormatProvider;

		// Token: 0x02000660 RID: 1632
		[Token(Token = "0x2000660")]
		[System.Serializable]
		private sealed class NullTextWriter : TextWriter
		{
			// Token: 0x06003117 RID: 12567 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003117")]
			[Address(RVA = "0x4C7FD00", Offset = "0x4C7E900", VA = "0x184C7FD00")]
			internal NullTextWriter()
			{
			}

			// Token: 0x170007DA RID: 2010
			// (get) Token: 0x06003118 RID: 12568 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007DA")]
			public override System.Text.Encoding Encoding
			{
				[Token(Token = "0x6003118")]
				[Address(RVA = "0x4C7F3E0", Offset = "0x4C7DFE0", VA = "0x184C7F3E0", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003119 RID: 12569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003119")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
			public override void Write(char[] buffer, int index, int count)
			{
			}

			// Token: 0x0600311A RID: 12570 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600311A")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
			public override void Write(string value)
			{
			}

			// Token: 0x0600311B RID: 12571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600311B")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
			public override void WriteLine()
			{
			}

			// Token: 0x0600311C RID: 12572 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600311C")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
			public override void WriteLine(string value)
			{
			}

			// Token: 0x0600311D RID: 12573 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600311D")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
			public override void WriteLine(object value)
			{
			}

			// Token: 0x0600311E RID: 12574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600311E")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
			public override void Write(char value)
			{
			}
		}

		// Token: 0x02000661 RID: 1633
		[Token(Token = "0x2000661")]
		[System.Serializable]
		internal sealed class SyncTextWriter : TextWriter, System.IDisposable
		{
			// Token: 0x0600311F RID: 12575 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600311F")]
			[Address(RVA = "0x4C89550", Offset = "0x4C88150", VA = "0x184C89550")]
			internal SyncTextWriter(TextWriter t)
			{
			}

			// Token: 0x170007DB RID: 2011
			// (get) Token: 0x06003120 RID: 12576 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007DB")]
			public override System.Text.Encoding Encoding
			{
				[Token(Token = "0x6003120")]
				[Address(RVA = "0x4A6E560", Offset = "0x4A6D160", VA = "0x184A6E560", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x170007DC RID: 2012
			// (get) Token: 0x06003121 RID: 12577 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007DC")]
			public override System.IFormatProvider FormatProvider
			{
				[Token(Token = "0x6003121")]
				[Address(RVA = "0x4A6E470", Offset = "0x4A6D070", VA = "0x184A6E470", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x170007DD RID: 2013
			// (get) Token: 0x06003122 RID: 12578 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007DD")]
			public override string NewLine
			{
				[Token(Token = "0x6003122")]
				[Address(RVA = "0x4A6E5B0", Offset = "0x4A6D1B0", VA = "0x184A6E5B0", Slot = "12")]
				[MethodImpl(32)]
				get
				{
					return null;
				}
			}

			// Token: 0x06003123 RID: 12579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003123")]
			[Address(RVA = "0x4C89160", Offset = "0x4C87D60", VA = "0x184C89160", Slot = "8")]
			[MethodImpl(32)]
			public override void Close()
			{
			}

			// Token: 0x06003124 RID: 12580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003124")]
			[Address(RVA = "0x4C891A0", Offset = "0x4C87DA0", VA = "0x184C891A0", Slot = "9")]
			[MethodImpl(32)]
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x06003125 RID: 12581 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003125")]
			[Address(RVA = "0x4C89200", Offset = "0x4C87E00", VA = "0x184C89200", Slot = "10")]
			[MethodImpl(32)]
			public override void Flush()
			{
			}

			// Token: 0x06003126 RID: 12582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003126")]
			[Address(RVA = "0x4BB1760", Offset = "0x4BB0360", VA = "0x184BB1760", Slot = "13")]
			[MethodImpl(32)]
			public override void Write(char value)
			{
			}

			// Token: 0x06003127 RID: 12583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003127")]
			[Address(RVA = "0x4BB17B0", Offset = "0x4BB03B0", VA = "0x184BB17B0", Slot = "14")]
			[MethodImpl(32)]
			public override void Write(char[] buffer)
			{
			}

			// Token: 0x06003128 RID: 12584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003128")]
			[Address(RVA = "0x4C89480", Offset = "0x4C88080", VA = "0x184C89480", Slot = "15")]
			[MethodImpl(32)]
			public override void Write(char[] buffer, int index, int count)
			{
			}

			// Token: 0x06003129 RID: 12585 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003129")]
			[Address(RVA = "0x4C893B0", Offset = "0x4C87FB0", VA = "0x184C893B0", Slot = "16")]
			[MethodImpl(32)]
			public override void Write(long value)
			{
			}

			// Token: 0x0600312A RID: 12586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312A")]
			[Address(RVA = "0x4C89500", Offset = "0x4C88100", VA = "0x184C89500", Slot = "17")]
			[MethodImpl(32)]
			public override void Write(string value)
			{
			}

			// Token: 0x0600312B RID: 12587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312B")]
			[Address(RVA = "0x4C89400", Offset = "0x4C88000", VA = "0x184C89400", Slot = "18")]
			[MethodImpl(32)]
			public override void Write(string format, object arg0, object arg1, object arg2)
			{
			}

			// Token: 0x0600312C RID: 12588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312C")]
			[Address(RVA = "0x4C89320", Offset = "0x4C87F20", VA = "0x184C89320", Slot = "19")]
			[MethodImpl(32)]
			public override void WriteLine()
			{
			}

			// Token: 0x0600312D RID: 12589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312D")]
			[Address(RVA = "0x4C892A0", Offset = "0x4C87EA0", VA = "0x184C892A0", Slot = "20")]
			[MethodImpl(32)]
			public override void WriteLine(char[] buffer, int index, int count)
			{
			}

			// Token: 0x0600312E RID: 12590 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312E")]
			[Address(RVA = "0x4BB3890", Offset = "0x4BB2490", VA = "0x184BB3890", Slot = "21")]
			[MethodImpl(32)]
			public override void WriteLine(string value)
			{
			}

			// Token: 0x0600312F RID: 12591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312F")]
			[Address(RVA = "0x4C89360", Offset = "0x4C87F60", VA = "0x184C89360", Slot = "22")]
			[MethodImpl(32)]
			public override void WriteLine(object value)
			{
			}

			// Token: 0x06003130 RID: 12592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003130")]
			[Address(RVA = "0x4C89240", Offset = "0x4C87E40", VA = "0x184C89240", Slot = "23")]
			[MethodImpl(32)]
			public override void WriteLine(string format, object arg0)
			{
			}

			// Token: 0x04001B18 RID: 6936
			[Token(Token = "0x4001B18")]
			[FieldOffset(Offset = "0x30")]
			private readonly TextWriter _out;
		}
	}
}
