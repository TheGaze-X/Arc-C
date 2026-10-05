using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.ExceptionServices;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000274 RID: 628
	[Token(Token = "0x2000274")]
	internal class TaskExceptionHolder
	{
		// Token: 0x060014E3 RID: 5347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal TaskExceptionHolder(Task task)
		{
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		[Token(Token = "0x60014E4")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		private static bool ShouldFailFastOnUnobservedException()
		{
			return default(bool);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E5")]
		[Address(RVA = "0x4AE2430", Offset = "0x4AE1030", VA = "0x184AE2430", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		[Token(Token = "0x17000209")]
		internal bool ContainsFaultList
		{
			[Token(Token = "0x60014E6")]
			[Address(RVA = "0x4AE2970", Offset = "0x4AE1570", VA = "0x184AE2970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x4AE2110", Offset = "0x4AE0D10", VA = "0x184AE2110")]
		internal void Add(object exceptionObject, bool representsCancellation)
		{
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x4AE2810", Offset = "0x4AE1410", VA = "0x184AE2810")]
		private void SetCancellationException(object exceptionObject)
		{
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x4AE1C80", Offset = "0x4AE0880", VA = "0x184AE1C80")]
		private void AddFaultException(object exceptionObject)
		{
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x4AE27A0", Offset = "0x4AE13A0", VA = "0x184AE27A0")]
		private void MarkAsUnhandled()
		{
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x4AE2720", Offset = "0x4AE1320", VA = "0x184AE2720")]
		internal void MarkAsHandled(bool calledFromFinalizer)
		{
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x4AE2240", Offset = "0x4AE0E40", VA = "0x184AE2240")]
		internal System.AggregateException CreateExceptionObject(bool calledFromFinalizer, System.Exception includeThisException)
		{
			return null;
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x4AE2640", Offset = "0x4AE1240", VA = "0x184AE2640")]
		internal System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.ExceptionServices.ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			return null;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
		internal System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			return null;
		}

		// Token: 0x04000BAC RID: 2988
		[Token(Token = "0x4000BAC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool s_failFastOnUnobservedException;

		// Token: 0x04000BAD RID: 2989
		[Token(Token = "0x4000BAD")]
		[FieldOffset(Offset = "0x10")]
		private readonly Task m_task;

		// Token: 0x04000BAE RID: 2990
		[Token(Token = "0x4000BAE")]
		[FieldOffset(Offset = "0x18")]
		private LowLevelListWithIList<System.Runtime.ExceptionServices.ExceptionDispatchInfo> m_faultExceptions;

		// Token: 0x04000BAF RID: 2991
		[Token(Token = "0x4000BAF")]
		[FieldOffset(Offset = "0x20")]
		private System.Runtime.ExceptionServices.ExceptionDispatchInfo m_cancellationException;

		// Token: 0x04000BB0 RID: 2992
		[Token(Token = "0x4000BB0")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isHandled;
	}
}
