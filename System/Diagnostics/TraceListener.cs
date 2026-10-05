using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	public abstract class TraceListener : MarshalByRefObject, IDisposable
	{
		// Token: 0x06000672 RID: 1650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x511BD70", Offset = "0x511A970", VA = "0x18511BD70")]
		protected TraceListener(string name)
		{
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x1700010C")]
		public virtual bool IsThreadSafe
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x511B0E0", Offset = "0x5119CE0", VA = "0x18511B0E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public virtual void Flush()
		{
		}

		// Token: 0x1700010D RID: 269
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700010D")]
		public int IndentLevel
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x511BDB0", Offset = "0x511A9B0", VA = "0x18511BDB0")]
			set
			{
			}
		}

		// Token: 0x1700010E RID: 270
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700010E")]
		public int IndentSize
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x511BDD0", Offset = "0x511A9D0", VA = "0x18511BDD0")]
			set
			{
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010F")]
		[ComVisible(false)]
		public TraceFilter Filter
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00004980 File Offset: 0x00002B80
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000110")]
		protected bool NeedIndent
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x4EA980", Offset = "0x4E9580", VA = "0x1804EA980")]
			set
			{
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x17000111")]
		[ComVisible(false)]
		public TraceOptions TraceOutputOptions
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return TraceOptions.None;
			}
		}

		// Token: 0x0600067D RID: 1661
		[Token(Token = "0x600067D")]
		public abstract void Write(string message);

		// Token: 0x0600067E RID: 1662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x511BCC0", Offset = "0x511A8C0", VA = "0x18511BCC0", Slot = "11")]
		protected virtual void WriteIndent()
		{
		}

		// Token: 0x0600067F RID: 1663
		[Token(Token = "0x600067F")]
		public abstract void WriteLine(string message);

		// Token: 0x06000680 RID: 1664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x511B160", Offset = "0x5119D60", VA = "0x18511B160", Slot = "13")]
		[ComVisible(false)]
		public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x511BBA0", Offset = "0x511A7A0", VA = "0x18511BBA0")]
		private void WriteHeader(string source, TraceEventType eventType, int id)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x511B340", Offset = "0x5119F40", VA = "0x18511B340")]
		private void WriteFooter(TraceEventCache eventCache)
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x511B150", Offset = "0x5119D50", VA = "0x18511B150")]
		internal bool IsEnabled(TraceOptions opts)
		{
			return default(bool);
		}

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int indentLevel;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int indentSize;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TraceOptions traceOptions;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool needIndent;

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string listenerName;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TraceFilter filter;
	}
}
