using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x020005AA RID: 1450
	[Token(Token = "0x20005AA")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[MonoTODO("Serialized objects are not compatible with .NET")]
	[System.Serializable]
	public class StackTrace
	{
		// Token: 0x06002B57 RID: 11095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B57")]
		[Address(RVA = "0x4C6F650", Offset = "0x4C6E250", VA = "0x184C6F650")]
		[MethodImpl(8)]
		public StackTrace()
		{
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B58")]
		[Address(RVA = "0x4C6F3E0", Offset = "0x4C6DFE0", VA = "0x184C6F3E0")]
		[MethodImpl(8)]
		public StackTrace(bool fNeedFileInfo)
		{
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B59")]
		[Address(RVA = "0x4C6F550", Offset = "0x4C6E150", VA = "0x184C6F550")]
		[MethodImpl(8)]
		public StackTrace(int skipFrames, bool fNeedFileInfo)
		{
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5A")]
		[Address(RVA = "0x4C6F690", Offset = "0x4C6E290", VA = "0x184C6F690")]
		[MethodImpl(8)]
		private void init_frames(int skipFrames, bool fNeedFileInfo)
		{
		}

		// Token: 0x06002B5B RID: 11099
		[Token(Token = "0x6002B5B")]
		[Address(RVA = "0x4C6F680", Offset = "0x4C6E280", VA = "0x184C6F680")]
		[MethodImpl(4096)]
		private static extern StackFrame[] get_trace(System.Exception e, int skipFrames, bool fNeedFileInfo);

		// Token: 0x06002B5C RID: 11100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5C")]
		[Address(RVA = "0x4C6F590", Offset = "0x4C6E190", VA = "0x184C6F590")]
		public StackTrace(System.Exception e, bool fNeedFileInfo)
		{
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5D")]
		[Address(RVA = "0x4C6F420", Offset = "0x4C6E020", VA = "0x184C6F420")]
		public StackTrace(System.Exception e, int skipFrames, bool fNeedFileInfo)
		{
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x00017FD0 File Offset: 0x000161D0
		[Token(Token = "0x170006A7")]
		public virtual int FrameCount
		{
			[Token(Token = "0x6002B5E")]
			[Address(RVA = "0x441B9D0", Offset = "0x441A5D0", VA = "0x18441B9D0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B5F")]
		[Address(RVA = "0x4C6E9F0", Offset = "0x4C6D5F0", VA = "0x184C6E9F0", Slot = "5")]
		public virtual StackFrame GetFrame(int index)
		{
			return null;
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B60")]
		[Address(RVA = "0x4C6E900", Offset = "0x4C6D500", VA = "0x184C6E900")]
		private static string GetAotId()
		{
			return null;
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00017FE8 File Offset: 0x000161E8
		[Token(Token = "0x6002B61")]
		[Address(RVA = "0x4C6E0E0", Offset = "0x4C6CCE0", VA = "0x184C6E0E0")]
		private bool AddFrames(System.Text.StringBuilder sb, bool separator, out bool isAsync)
		{
			return default(bool);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B62")]
		[Address(RVA = "0x4C6EA70", Offset = "0x4C6D670", VA = "0x184C6EA70")]
		private void GetFullNameForStackTrace(System.Text.StringBuilder sb, System.Reflection.MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync)
		{
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B63")]
		[Address(RVA = "0x4C6E5F0", Offset = "0x4C6D1F0", VA = "0x184C6E5F0")]
		private static void ConvertAsyncStateMachineMethod(ref System.Reflection.MethodBase method, ref System.Type declaringType)
		{
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B64")]
		[Address(RVA = "0x4C6F210", Offset = "0x4C6DE10", VA = "0x184C6F210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B65")]
		[Address(RVA = "0x4C6F3A0", Offset = "0x4C6DFA0", VA = "0x184C6F3A0")]
		internal string ToString(StackTrace.TraceFormat traceFormat)
		{
			return null;
		}

		// Token: 0x04001940 RID: 6464
		[Token(Token = "0x4001940")]
		public const int METHODS_TO_SKIP = 0;

		// Token: 0x04001941 RID: 6465
		[Token(Token = "0x4001941")]
		private const string prefix = "  at ";

		// Token: 0x04001942 RID: 6466
		[Token(Token = "0x4001942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private StackFrame[] frames;

		// Token: 0x04001943 RID: 6467
		[Token(Token = "0x4001943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly StackTrace[] captured_traces;

		// Token: 0x04001944 RID: 6468
		[Token(Token = "0x4001944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool debug_info;

		// Token: 0x04001945 RID: 6469
		[Token(Token = "0x4001945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool isAotidSet;

		// Token: 0x04001946 RID: 6470
		[Token(Token = "0x4001946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string aotid;

		// Token: 0x020005AB RID: 1451
		[Token(Token = "0x20005AB")]
		internal enum TraceFormat
		{
			// Token: 0x04001948 RID: 6472
			[Token(Token = "0x4001948")]
			Normal,
			// Token: 0x04001949 RID: 6473
			[Token(Token = "0x4001949")]
			TrailingNewLine,
			// Token: 0x0400194A RID: 6474
			[Token(Token = "0x400194A")]
			NoResourceLookup
		}
	}
}
