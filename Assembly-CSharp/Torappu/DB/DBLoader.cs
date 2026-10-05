using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.DB
{
	// Token: 0x02001695 RID: 5781
	[Token(Token = "0x2001695")]
	public static class DBLoader
	{
		// Token: 0x0600927D RID: 37501 RVA: 0x00039000 File Offset: 0x00037200
		[Token(Token = "0x600927D")]
		[Address(RVA = "0x2B30440", Offset = "0x2B2F040", VA = "0x182B30440")]
		public static bool LoadTablesSync(bool force, bool initialOnly)
		{
			return default(bool);
		}

		// Token: 0x0600927E RID: 37502 RVA: 0x00039018 File Offset: 0x00037218
		[Token(Token = "0x600927E")]
		[Address(RVA = "0x2B303C0", Offset = "0x2B2EFC0", VA = "0x182B303C0")]
		public static bool LoadTable(AbstractTable table)
		{
			return default(bool);
		}

		// Token: 0x0600927F RID: 37503 RVA: 0x00039030 File Offset: 0x00037230
		[Token(Token = "0x600927F")]
		[Address(RVA = "0x2B30D70", Offset = "0x2B2F970", VA = "0x182B30D70")]
		private static bool _DoLoadTable(AbstractTable table, IConverter converter, bool force)
		{
			return default(bool);
		}

		// Token: 0x06009280 RID: 37504 RVA: 0x00039048 File Offset: 0x00037248
		[Token(Token = "0x6009280")]
		[Address(RVA = "0x2B30EA0", Offset = "0x2B2FAA0", VA = "0x182B30EA0")]
		private static bool _DoLoadTable(AbstractTable table, IConverter[] converters, bool force)
		{
			return default(bool);
		}

		// Token: 0x06009281 RID: 37505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009281")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private static void _DISPOSED_AlertDBFailedAndHalt()
		{
		}

		// Token: 0x06009282 RID: 37506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009282")]
		[Address(RVA = "0x2B306A0", Offset = "0x2B2F2A0", VA = "0x182B306A0")]
		public static void ReloadAllTablesAfterHotupdate(Func<IEnumerator, Coroutine> startCoroutineFunc)
		{
		}

		// Token: 0x06009283 RID: 37507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009283")]
		[Address(RVA = "0x2B31110", Offset = "0x2B2FD10", VA = "0x182B31110")]
		private static void _StartHypridDBLoading(Action syncLoad, Action asyncLoad, bool enableParallel)
		{
		}

		// Token: 0x06009284 RID: 37508 RVA: 0x00039060 File Offset: 0x00037260
		[Token(Token = "0x6009284")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		private static bool _EnableParallelHypridLoading()
		{
			return default(bool);
		}

		// Token: 0x06009285 RID: 37509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009285")]
		[Address(RVA = "0x2B30A90", Offset = "0x2B2F690", VA = "0x182B30A90")]
		public static IEnumerator WaitForDBAsyncLoading(bool abortCurrentTask)
		{
			return null;
		}

		// Token: 0x06009286 RID: 37510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009286")]
		[Address(RVA = "0x2B31190", Offset = "0x2B2FD90", VA = "0x182B31190")]
		private static IEnumerator _WaitAsyncSequentialLoading(DBLoader.AsyncLoadTask task)
		{
			return null;
		}

		// Token: 0x06009287 RID: 37511 RVA: 0x00039078 File Offset: 0x00037278
		[Token(Token = "0x6009287")]
		[Address(RVA = "0x2B30B00", Offset = "0x2B2F700", VA = "0x182B30B00")]
		private static KeyValuePair<ConverterInput, AbstractTable.IAsyncLoadRequest> _CreateAsyncLoadRequest(AbstractTable table, IConverter[] converters)
		{
			return default(KeyValuePair<ConverterInput, AbstractTable.IAsyncLoadRequest>);
		}

		// Token: 0x06009288 RID: 37512 RVA: 0x00039090 File Offset: 0x00037290
		[Token(Token = "0x6009288")]
		[Address(RVA = "0x2B30FD0", Offset = "0x2B2FBD0", VA = "0x182B30FD0")]
		private static ConverterInput _LoadTableRawData(AbstractTable table)
		{
			return default(ConverterInput);
		}

		// Token: 0x04008833 RID: 34867
		[Token(Token = "0x4008833")]
		[FieldOffset(Offset = "0x0")]
		private static DBLoader.AsyncLoadTask s_asyncLoadTask;

		// Token: 0x02001696 RID: 5782
		[Token(Token = "0x2001696")]
		private class AsyncLoadTask : IDisposable
		{
			// Token: 0x17000F8F RID: 3983
			// (get) Token: 0x06009289 RID: 37513 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600928A RID: 37514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F8F")]
			public WaitForAsyncTask<int> worker
			{
				[Token(Token = "0x6009289")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600928A")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600928B RID: 37515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600928B")]
			[Address(RVA = "0x2B259F0", Offset = "0x2B245F0", VA = "0x182B259F0")]
			public void StartWork(IList<KeyValuePair<ConverterInput, AbstractTable.IAsyncLoadRequest>> tasks)
			{
			}

			// Token: 0x0600928C RID: 37516 RVA: 0x000390A8 File Offset: 0x000372A8
			[Token(Token = "0x600928C")]
			[Address(RVA = "0x2B25C50", Offset = "0x2B24850", VA = "0x182B25C50")]
			public bool TryGetNextResult(out AbstractTable.AsyncLoadResult data, out AbstractTable.IAsyncLoadRequest handler)
			{
				return default(bool);
			}

			// Token: 0x0600928D RID: 37517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600928D")]
			[Address(RVA = "0x2B258A0", Offset = "0x2B244A0", VA = "0x182B258A0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0600928E RID: 37518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600928E")]
			[Address(RVA = "0x2B25880", Offset = "0x2B24480", VA = "0x182B25880")]
			public void Abort()
			{
			}

			// Token: 0x0600928F RID: 37519 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600928F")]
			[Address(RVA = "0x2B25970", Offset = "0x2B24570", VA = "0x182B25970")]
			public IEnumerator KeepWorking()
			{
				return null;
			}

			// Token: 0x17000F90 RID: 3984
			// (get) Token: 0x06009290 RID: 37520 RVA: 0x000390C0 File Offset: 0x000372C0
			[Token(Token = "0x17000F90")]
			public bool isWorking
			{
				[Token(Token = "0x6009290")]
				[Address(RVA = "0x2B26080", Offset = "0x2B24C80", VA = "0x182B26080")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06009291 RID: 37521 RVA: 0x000390D8 File Offset: 0x000372D8
			[Token(Token = "0x6009291")]
			[Address(RVA = "0x2B25920", Offset = "0x2B24520", VA = "0x182B25920")]
			public bool HasResultToGet()
			{
				return default(bool);
			}

			// Token: 0x06009292 RID: 37522 RVA: 0x000390F0 File Offset: 0x000372F0
			[Token(Token = "0x6009292")]
			[Address(RVA = "0x2B25D70", Offset = "0x2B24970", VA = "0x182B25D70")]
			private int _AsyncWork()
			{
				return 0;
			}

			// Token: 0x06009293 RID: 37523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009293")]
			[Address(RVA = "0x2B25FA0", Offset = "0x2B24BA0", VA = "0x182B25FA0")]
			public AsyncLoadTask()
			{
			}

			// Token: 0x04008834 RID: 34868
			[Token(Token = "0x4008834")]
			[FieldOffset(Offset = "0x10")]
			private ThreadSafeQueue<KeyValuePair<ConverterInput, AbstractTable.IAsyncLoadRequest>> m_pendingTasks;

			// Token: 0x04008835 RID: 34869
			[Token(Token = "0x4008835")]
			[FieldOffset(Offset = "0x18")]
			private ThreadSafeQueue<KeyValuePair<AbstractTable.AsyncLoadResult, AbstractTable.IAsyncLoadRequest>> m_finishedTasks;

			// Token: 0x04008836 RID: 34870
			[Token(Token = "0x4008836")]
			[FieldOffset(Offset = "0x20")]
			private bool m_keepWorking;

			// Token: 0x04008837 RID: 34871
			[Token(Token = "0x4008837")]
			[FieldOffset(Offset = "0x21")]
			private bool m_isValid;
		}
	}
}
