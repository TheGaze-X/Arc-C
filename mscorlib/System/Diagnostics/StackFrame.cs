using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x020005A9 RID: 1449
	[Token(Token = "0x20005A9")]
	[MonoTODO("Serialized objects are not compatible with MS.NET")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	[StructLayout(0)]
	public class StackFrame
	{
		// Token: 0x06002B4A RID: 11082
		[Token(Token = "0x6002B4A")]
		[Address(RVA = "0x4C6E0D0", Offset = "0x4C6CCD0", VA = "0x184C6E0D0")]
		[MethodImpl(4096)]
		private static extern bool get_frame_info(int skip, bool needFileInfo, out System.Reflection.MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column);

		// Token: 0x06002B4B RID: 11083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x4C6E060", Offset = "0x4C6CC60", VA = "0x184C6E060")]
		public StackFrame()
		{
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x4C6DFD0", Offset = "0x4C6CBD0", VA = "0x184C6DFD0")]
		[MethodImpl(8)]
		public StackFrame(int skipFrames, bool fNeedFileInfo)
		{
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00017F58 File Offset: 0x00016158
		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "4")]
		public virtual int GetFileLineNumber()
		{
			return 0;
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B4E")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "5")]
		public virtual string GetFileName()
		{
			return null;
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B4F")]
		[Address(RVA = "0x4C6DD10", Offset = "0x4C6C910", VA = "0x184C6DD10")]
		internal string GetSecureFileName()
		{
			return null;
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x00017F70 File Offset: 0x00016170
		[Token(Token = "0x6002B50")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "6")]
		public virtual int GetILOffset()
		{
			return 0;
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B51")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "7")]
		public virtual System.Reflection.MethodBase GetMethod()
		{
			return null;
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00017F88 File Offset: 0x00016188
		[Token(Token = "0x6002B52")]
		[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "8")]
		public virtual int GetNativeOffset()
		{
			return 0;
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x00017FA0 File Offset: 0x000161A0
		[Token(Token = "0x6002B53")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		internal long GetMethodAddress()
		{
			return 0L;
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x00017FB8 File Offset: 0x000161B8
		[Token(Token = "0x6002B54")]
		[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
		internal uint GetMethodIndex()
		{
			return 0U;
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B55")]
		[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
		internal string GetInternalMethodName()
		{
			return null;
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B56")]
		[Address(RVA = "0x4C6DD90", Offset = "0x4C6C990", VA = "0x184C6DD90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001936 RID: 6454
		[Token(Token = "0x4001936")]
		public const int OFFSET_UNKNOWN = -1;

		// Token: 0x04001937 RID: 6455
		[Token(Token = "0x4001937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int ilOffset;

		// Token: 0x04001938 RID: 6456
		[Token(Token = "0x4001938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int nativeOffset;

		// Token: 0x04001939 RID: 6457
		[Token(Token = "0x4001939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long methodAddress;

		// Token: 0x0400193A RID: 6458
		[Token(Token = "0x400193A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint methodIndex;

		// Token: 0x0400193B RID: 6459
		[Token(Token = "0x400193B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Reflection.MethodBase methodBase;

		// Token: 0x0400193C RID: 6460
		[Token(Token = "0x400193C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string fileName;

		// Token: 0x0400193D RID: 6461
		[Token(Token = "0x400193D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int lineNumber;

		// Token: 0x0400193E RID: 6462
		[Token(Token = "0x400193E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int columnNumber;

		// Token: 0x0400193F RID: 6463
		[Token(Token = "0x400193F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string internalMethodName;
	}
}
