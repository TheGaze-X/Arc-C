using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200396C RID: 14700
	[Token(Token = "0x200396C")]
	public class LoopRequestSender : IHotfixable
	{
		// Token: 0x06017381 RID: 95105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017381")]
		[Address(RVA = "0xF8EB40", Offset = "0xF8D740", VA = "0x180F8EB40")]
		public LoopRequestSender(LoopRequestSender.SenderContext context)
		{
		}

		// Token: 0x06017382 RID: 95106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017382")]
		[Address(RVA = "0xF8E480", Offset = "0xF8D080", VA = "0x180F8E480")]
		public void StartRequest()
		{
		}

		// Token: 0x06017383 RID: 95107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017383")]
		[Address(RVA = "0xF8EA60", Offset = "0xF8D660", VA = "0x180F8EA60")]
		private IEnumerator _StartNewTaskSafely(LoopRequestSender.RequestTask prevTask, LoopRequestSender.RequestTask newTask)
		{
			return null;
		}

		// Token: 0x06017384 RID: 95108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017384")]
		[Address(RVA = "0xF8E830", Offset = "0xF8D430", VA = "0x180F8E830")]
		public void TryRequestCancel()
		{
		}

		// Token: 0x06017385 RID: 95109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017385")]
		[Address(RVA = "0xF8E9B0", Offset = "0xF8D5B0", VA = "0x180F8E9B0")]
		private static IEnumerator _LoopSendRequest(LoopRequestSender.RequestTask currTask)
		{
			return null;
		}

		// Token: 0x06017386 RID: 95110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017386")]
		[Address(RVA = "0xF8E900", Offset = "0xF8D500", VA = "0x180F8E900")]
		private static IEnumerator _CancelIfNeed(LoopRequestSender.RequestTask currTask)
		{
			return null;
		}

		// Token: 0x0401C06A RID: 114794
		[Token(Token = "0x401C06A")]
		private const float TICK_INTERVAL = 1f;

		// Token: 0x0401C06B RID: 114795
		[Token(Token = "0x401C06B")]
		[FieldOffset(Offset = "0x10")]
		private LoopRequestSender.SenderContext m_context;

		// Token: 0x0401C06C RID: 114796
		[Token(Token = "0x401C06C")]
		[FieldOffset(Offset = "0x18")]
		private LoopRequestSender.ICoroutineHost m_coroutineHost;

		// Token: 0x0401C06D RID: 114797
		[Token(Token = "0x401C06D")]
		[FieldOffset(Offset = "0x20")]
		private LoopRequestSender.RequestTask m_activeTask;

		// Token: 0x0401C06E RID: 114798
		[Token(Token = "0x401C06E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C06F RID: 114799
		[Token(Token = "0x401C06F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StartRequest;

		// Token: 0x0401C070 RID: 114800
		[Token(Token = "0x401C070")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__StartNewTaskSafely;

		// Token: 0x0401C071 RID: 114801
		[Token(Token = "0x401C071")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryRequestCancel;

		// Token: 0x0401C072 RID: 114802
		[Token(Token = "0x401C072")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoopSendRequest;

		// Token: 0x0401C073 RID: 114803
		[Token(Token = "0x401C073")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CancelIfNeed;

		// Token: 0x0200396D RID: 14701
		[Token(Token = "0x200396D")]
		public struct RequestWaitParam
		{
			// Token: 0x0401C074 RID: 114804
			[Token(Token = "0x401C074")]
			[FieldOffset(Offset = "0x0")]
			public float waitSecFromPrev;

			// Token: 0x0401C075 RID: 114805
			[Token(Token = "0x401C075")]
			[FieldOffset(Offset = "0x4")]
			public float totalSec;
		}

		// Token: 0x0200396E RID: 14702
		[Token(Token = "0x200396E")]
		public interface IRequestWaitStrategy : IHotfixable
		{
			// Token: 0x06017387 RID: 95111
			[Token(Token = "0x6017387")]
			bool IsWaitEnough(LoopRequestSender.RequestWaitParam waitParam);
		}

		// Token: 0x0200396F RID: 14703
		[Token(Token = "0x200396F")]
		public interface ICoroutineHost : IHotfixable
		{
			// Token: 0x06017388 RID: 95112
			[Token(Token = "0x6017388")]
			Coroutine StartCoroutine(IEnumerator routine);
		}

		// Token: 0x02003970 RID: 14704
		[Token(Token = "0x2003970")]
		public class RequestResult
		{
			// Token: 0x06017389 RID: 95113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017389")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RequestResult()
			{
			}

			// Token: 0x0401C076 RID: 114806
			[Token(Token = "0x401C076")]
			[FieldOffset(Offset = "0x10")]
			public bool isRequesting;

			// Token: 0x0401C077 RID: 114807
			[Token(Token = "0x401C077")]
			[FieldOffset(Offset = "0x11")]
			public bool isComplete;
		}

		// Token: 0x02003971 RID: 14705
		[Token(Token = "0x2003971")]
		public interface IRequestSendHandler : IHotfixable
		{
			// Token: 0x0601738A RID: 95114
			[Token(Token = "0x601738A")]
			LoopRequestSender.RequestResult SendRequest();
		}

		// Token: 0x02003972 RID: 14706
		[Token(Token = "0x2003972")]
		public class SenderContext
		{
			// Token: 0x0601738B RID: 95115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601738B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SenderContext()
			{
			}

			// Token: 0x0401C078 RID: 114808
			[Token(Token = "0x401C078")]
			[FieldOffset(Offset = "0x10")]
			public LoopRequestSender.IRequestSendHandler queryRequestHandler;

			// Token: 0x0401C079 RID: 114809
			[Token(Token = "0x401C079")]
			[FieldOffset(Offset = "0x18")]
			public LoopRequestSender.IRequestSendHandler cancelRequestHandler;

			// Token: 0x0401C07A RID: 114810
			[Token(Token = "0x401C07A")]
			[FieldOffset(Offset = "0x20")]
			public LoopRequestSender.IRequestSendHandler initRequestHandler;

			// Token: 0x0401C07B RID: 114811
			[Token(Token = "0x401C07B")]
			[FieldOffset(Offset = "0x28")]
			public LoopRequestSender.IRequestWaitStrategy waitStrategy;

			// Token: 0x0401C07C RID: 114812
			[Token(Token = "0x401C07C")]
			[FieldOffset(Offset = "0x30")]
			public LoopRequestSender.ICoroutineHost coroutineHost;

			// Token: 0x0401C07D RID: 114813
			[Token(Token = "0x401C07D")]
			[FieldOffset(Offset = "0x38")]
			public Action<float> onTick;
		}

		// Token: 0x02003973 RID: 14707
		[Token(Token = "0x2003973")]
		private class RequestTask : IHotfixable
		{
			// Token: 0x17003777 RID: 14199
			// (get) Token: 0x0601738C RID: 95116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003777")]
			public LoopRequestSender.IRequestSendHandler initRequestHandler
			{
				[Token(Token = "0x601738C")]
				[Address(RVA = "0xF8FC30", Offset = "0xF8E830", VA = "0x180F8FC30")]
				get
				{
					return null;
				}
			}

			// Token: 0x17003778 RID: 14200
			// (get) Token: 0x0601738D RID: 95117 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003778")]
			public LoopRequestSender.IRequestSendHandler queryRequestHandler
			{
				[Token(Token = "0x601738D")]
				[Address(RVA = "0xF8FC90", Offset = "0xF8E890", VA = "0x180F8FC90")]
				get
				{
					return null;
				}
			}

			// Token: 0x17003779 RID: 14201
			// (get) Token: 0x0601738E RID: 95118 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003779")]
			public LoopRequestSender.IRequestSendHandler cancelRequestHandler
			{
				[Token(Token = "0x601738E")]
				[Address(RVA = "0xF8FBD0", Offset = "0xF8E7D0", VA = "0x180F8FBD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601738F RID: 95119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601738F")]
			[Address(RVA = "0xF8FB70", Offset = "0xF8E770", VA = "0x180F8FB70")]
			private RequestTask()
			{
			}

			// Token: 0x06017390 RID: 95120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017390")]
			[Address(RVA = "0xF8F680", Offset = "0xF8E280", VA = "0x180F8F680")]
			public static LoopRequestSender.RequestTask Create(LoopRequestSender.SenderContext context)
			{
				return null;
			}

			// Token: 0x06017391 RID: 95121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017391")]
			[Address(RVA = "0xF8FAF0", Offset = "0xF8E6F0", VA = "0x180F8FAF0")]
			public void TriggerTick(float totalSec)
			{
			}

			// Token: 0x06017392 RID: 95122 RVA: 0x00095580 File Offset: 0x00093780
			[Token(Token = "0x6017392")]
			[Address(RVA = "0xF8F8D0", Offset = "0xF8E4D0", VA = "0x180F8F8D0")]
			public bool IsWaitEnough(float waitSecFromPrev, float totalSec)
			{
				return default(bool);
			}

			// Token: 0x06017393 RID: 95123 RVA: 0x00095598 File Offset: 0x00093798
			[Token(Token = "0x6017393")]
			[Address(RVA = "0xF8F870", Offset = "0xF8E470", VA = "0x180F8F870")]
			public bool IsFinish()
			{
				return default(bool);
			}

			// Token: 0x06017394 RID: 95124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017394")]
			[Address(RVA = "0xF8FA90", Offset = "0xF8E690", VA = "0x180F8FA90")]
			public void MarkFinish()
			{
			}

			// Token: 0x06017395 RID: 95125 RVA: 0x000955B0 File Offset: 0x000937B0
			[Token(Token = "0x6017395")]
			[Address(RVA = "0xF8F810", Offset = "0xF8E410", VA = "0x180F8F810")]
			public bool IsCancel()
			{
				return default(bool);
			}

			// Token: 0x06017396 RID: 95126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017396")]
			[Address(RVA = "0xF8FA20", Offset = "0xF8E620", VA = "0x180F8FA20")]
			public void MarkCancel()
			{
			}

			// Token: 0x0401C07E RID: 114814
			[Token(Token = "0x401C07E")]
			[FieldOffset(Offset = "0x10")]
			private LoopRequestSender.IRequestSendHandler m_initRequestHandler;

			// Token: 0x0401C07F RID: 114815
			[Token(Token = "0x401C07F")]
			[FieldOffset(Offset = "0x18")]
			private LoopRequestSender.IRequestSendHandler m_queryRequestHandler;

			// Token: 0x0401C080 RID: 114816
			[Token(Token = "0x401C080")]
			[FieldOffset(Offset = "0x20")]
			private LoopRequestSender.IRequestSendHandler m_cancelRequestHandler;

			// Token: 0x0401C081 RID: 114817
			[Token(Token = "0x401C081")]
			[FieldOffset(Offset = "0x28")]
			private LoopRequestSender.IRequestWaitStrategy m_waitStrategy;

			// Token: 0x0401C082 RID: 114818
			[Token(Token = "0x401C082")]
			[FieldOffset(Offset = "0x30")]
			private bool m_hasCancelOp;

			// Token: 0x0401C083 RID: 114819
			[Token(Token = "0x401C083")]
			[FieldOffset(Offset = "0x31")]
			private bool m_isFinish;

			// Token: 0x0401C084 RID: 114820
			[Token(Token = "0x401C084")]
			[FieldOffset(Offset = "0x38")]
			private Action<float> m_onTick;

			// Token: 0x0401C085 RID: 114821
			[Token(Token = "0x401C085")]
			[FieldOffset(Offset = "0x40")]
			public Coroutine taskCoroutine;

			// Token: 0x0401C086 RID: 114822
			[Token(Token = "0x401C086")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_initRequestHandler;

			// Token: 0x0401C087 RID: 114823
			[Token(Token = "0x401C087")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_queryRequestHandler;

			// Token: 0x0401C088 RID: 114824
			[Token(Token = "0x401C088")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_cancelRequestHandler;

			// Token: 0x0401C089 RID: 114825
			[Token(Token = "0x401C089")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401C08A RID: 114826
			[Token(Token = "0x401C08A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Create;

			// Token: 0x0401C08B RID: 114827
			[Token(Token = "0x401C08B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_TriggerTick;

			// Token: 0x0401C08C RID: 114828
			[Token(Token = "0x401C08C")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_IsWaitEnough;

			// Token: 0x0401C08D RID: 114829
			[Token(Token = "0x401C08D")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_IsFinish;

			// Token: 0x0401C08E RID: 114830
			[Token(Token = "0x401C08E")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_MarkFinish;

			// Token: 0x0401C08F RID: 114831
			[Token(Token = "0x401C08F")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_IsCancel;

			// Token: 0x0401C090 RID: 114832
			[Token(Token = "0x401C090")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_MarkCancel;
		}
	}
}
