using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000186")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	[StructLayout(0)]
	public class Exception : System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000E46 RID: 3654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x4D1D120", Offset = "0x4D1BD20", VA = "0x184D1D120")]
		private void Init()
		{
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x4D1D790", Offset = "0x4D1C390", VA = "0x184D1D790")]
		public Exception()
		{
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x4D1DD10", Offset = "0x4D1C910", VA = "0x184D1DD10")]
		public Exception(string message)
		{
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x4D1DD50", Offset = "0x4D1C950", VA = "0x184D1DD50")]
		public Exception(string message, System.Exception innerException)
		{
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x4D1D7B0", Offset = "0x4D1C3B0", VA = "0x184D1D7B0")]
		protected Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700012D")]
		public virtual string Message
		{
			[Token(Token = "0x6000E4B")]
			[Address(RVA = "0x4D1DE40", Offset = "0x4D1CA40", VA = "0x184D1DE40", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700012E")]
		public virtual System.Collections.IDictionary Data
		{
			[Token(Token = "0x6000E4C")]
			[Address(RVA = "0x4D1DDB0", Offset = "0x4D1C9B0", VA = "0x184D1DDB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0x4D1CB50", Offset = "0x4D1B750", VA = "0x184D1CB50")]
		private string GetClassName()
		{
			return null;
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0x4D1CB30", Offset = "0x4D1B730", VA = "0x184D1CB30", Slot = "7")]
		public virtual System.Exception GetBaseException()
		{
			return null;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700012F")]
		public System.Exception InnerException
		{
			[Token(Token = "0x6000E4F")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000130")]
		public System.Reflection.MethodBase TargetSite
		{
			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x4D1E120", Offset = "0x4D1CD20", VA = "0x184D1E120", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000131")]
		public virtual string StackTrace
		{
			[Token(Token = "0x6000E51")]
			[Address(RVA = "0x4D1E0E0", Offset = "0x4D1CCE0", VA = "0x184D1E0E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x4D1D0D0", Offset = "0x4D1BCD0", VA = "0x184D1D0D0")]
		private string GetStackTrace(bool needFileInfo)
		{
			return null;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x4D1D360", Offset = "0x4D1BF60", VA = "0x184D1D360")]
		internal void SetErrorCode(int hr)
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000132")]
		public virtual string Source
		{
			[Token(Token = "0x6000E54")]
			[Address(RVA = "0x4D1DF30", Offset = "0x4D1CB30", VA = "0x184D1DF30", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x4D1D700", Offset = "0x4D1C300", VA = "0x184D1D700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x4D1D370", Offset = "0x4D1BF70", VA = "0x184D1D370")]
		private string ToString(bool needFileLineInfo, bool needMessage)
		{
			return null;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x4D1CC50", Offset = "0x4D1B850", VA = "0x184D1CC50", Slot = "12")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x4D1D1C0", Offset = "0x4D1BDC0", VA = "0x184D1D1C0")]
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210")]
		private string StripFileInfo(string stackTrace, bool isRemoteStackTrace)
		{
			return null;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x4D1D270", Offset = "0x4D1BE70", VA = "0x184D1D270")]
		internal void RestoreExceptionDispatchInfo(System.Runtime.ExceptionServices.ExceptionDispatchInfo exceptionDispatchInfo)
		{
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0000CA98 File Offset: 0x0000AC98
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000133")]
		public int HResult
		{
			[Token(Token = "0x6000E5B")]
			[Address(RVA = "0x4D1DE30", Offset = "0x4D1CA30", VA = "0x184D1DE30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000E5C")]
			[Address(RVA = "0x4D1D360", Offset = "0x4D1BF60", VA = "0x184D1D360")]
			protected set
			{
			}
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x4D04740", Offset = "0x4D03340", VA = "0x184D04740", Slot = "13")]
		public new System.Type GetType()
		{
			return null;
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x4D1CBC0", Offset = "0x4D1B7C0", VA = "0x184D1CBC0")]
		internal static string GetMessageFromNativeResources(System.Exception.ExceptionMessageKind kind)
		{
			return null;
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x4D1CA20", Offset = "0x4D1B620", VA = "0x184D1CA20")]
		internal System.Exception FixRemotingException()
		{
			return null;
		}

		// Token: 0x06000E60 RID: 3680
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x4D1D260", Offset = "0x4D1BE60", VA = "0x184D1D260")]
		[MethodImpl(4096)]
		internal static extern void ReportUnhandledException(System.Exception exception);

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[System.Runtime.Serialization.OptionalField]
		private static object s_EDILock;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _className;

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string _message;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Collections.IDictionary _data;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Exception _innerException;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _helpURL;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object _stackTrace;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _stackTraceString;

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _remoteStackTraceString;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _remoteStackIndex;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private object _dynamicMethods;

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal int _HResult;

		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string _source;

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		private SafeSerializationManager _safeSerializationManager;

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal System.Diagnostics.StackTrace[] captured_traces;

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private System.IntPtr[] native_trace_ips;

		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int caught_in_unmanaged;

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x4000621")]
		private const int _COMPlusExceptionCode = -532462766;

		// Token: 0x02000187 RID: 391
		[Token(Token = "0x2000187")]
		internal enum ExceptionMessageKind
		{
			// Token: 0x04000623 RID: 1571
			[Token(Token = "0x4000623")]
			ThreadAbort = 1,
			// Token: 0x04000624 RID: 1572
			[Token(Token = "0x4000624")]
			ThreadInterrupted,
			// Token: 0x04000625 RID: 1573
			[Token(Token = "0x4000625")]
			OutOfMemory
		}
	}
}
