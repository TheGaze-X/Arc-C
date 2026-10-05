using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	// Token: 0x02000251 RID: 593
	[Token(Token = "0x2000251")]
	internal static class DebuggerSupport
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		[Token(Token = "0x170001E3")]
		public static bool LoggingOn
		{
			[Token(Token = "0x60013DD")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext)
		{
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status)
		{
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation)
		{
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work)
		{
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x4ADB660", Offset = "0x4ADA260", VA = "0x184ADB660")]
		[MethodImpl(256)]
		public static void AddToActiveTasks(Task task)
		{
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x4ADB520", Offset = "0x4ADA120", VA = "0x184ADB520")]
		[MethodImpl(8)]
		private static void AddToActiveTasksNonInlined(Task task)
		{
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x4ADB820", Offset = "0x4ADA420", VA = "0x184ADB820")]
		[MethodImpl(256)]
		public static void RemoveFromActiveTasks(Task task)
		{
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x4ADB6F0", Offset = "0x4ADA2F0", VA = "0x184ADB6F0")]
		[MethodImpl(8)]
		private static void RemoveFromActiveTasksNonInlined(Task task)
		{
		}

		// Token: 0x04000B21 RID: 2849
		[Token(Token = "0x4000B21")]
		[FieldOffset(Offset = "0x0")]
		private static readonly LowLevelDictionary<int, Task> s_activeTasks;

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object s_activeTasksLock;
	}
}
