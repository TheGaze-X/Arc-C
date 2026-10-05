using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Network;
using UnityEngine;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004ABF RID: 19135
	[Token(Token = "0x2004ABF")]
	public class HotUpdateWorkflow : IHotfixable, IDisposable
	{
		// Token: 0x170043C8 RID: 17352
		// (get) Token: 0x0601CBB5 RID: 117685 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CBB6 RID: 117686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043C8")]
		public NetworkRouterConfig.Content clientOutOfDateReason
		{
			[Token(Token = "0x601CBB5")]
			[Address(RVA = "0x162B420", Offset = "0x162A020", VA = "0x18162B420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CBB6")]
			[Address(RVA = "0x162B500", Offset = "0x162A100", VA = "0x18162B500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170043C9 RID: 17353
		// (get) Token: 0x0601CBB7 RID: 117687 RVA: 0x000A9428 File Offset: 0x000A7628
		// (set) Token: 0x0601CBB8 RID: 117688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043C9")]
		public bool isDisposed
		{
			[Token(Token = "0x601CBB7")]
			[Address(RVA = "0x162B490", Offset = "0x162A090", VA = "0x18162B490")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601CBB8")]
			[Address(RVA = "0x162B590", Offset = "0x162A190", VA = "0x18162B590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601CBB9 RID: 117689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CBB9")]
		[Address(RVA = "0x162B270", Offset = "0x1629E70", VA = "0x18162B270")]
		private HotUpdateWorkflow()
		{
		}

		// Token: 0x0601CBBA RID: 117690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CBBA")]
		[Address(RVA = "0x1629580", Offset = "0x1628180", VA = "0x181629580")]
		public static HotUpdateWorkflow Create(HotUpdateWorkflow.Options options)
		{
			return null;
		}

		// Token: 0x0601CBBB RID: 117691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CBBB")]
		[Address(RVA = "0x162A9E0", Offset = "0x16295E0", VA = "0x18162A9E0")]
		public Coroutine StartWorkflow()
		{
			return null;
		}

		// Token: 0x0601CBBC RID: 117692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CBBC")]
		[Address(RVA = "0x162AC50", Offset = "0x1629850", VA = "0x18162AC50")]
		private IEnumerator _DoWorkFlowRoutine()
		{
			return null;
		}

		// Token: 0x0601CBBD RID: 117693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CBBD")]
		[Address(RVA = "0x1629A80", Offset = "0x1628680", VA = "0x181629A80", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0601CBBE RID: 117694 RVA: 0x000A9440 File Offset: 0x000A7640
		[Token(Token = "0x601CBBE")]
		[Address(RVA = "0x162A420", Offset = "0x1629020", VA = "0x18162A420")]
		public bool PeekFallbackStatus(out HotUpdateWorkflow.ENode fallbackNode)
		{
			return default(bool);
		}

		// Token: 0x0601CBBF RID: 117695 RVA: 0x000A9458 File Offset: 0x000A7658
		[Token(Token = "0x601CBBF")]
		[Address(RVA = "0x1629DE0", Offset = "0x16289E0", VA = "0x181629DE0")]
		public bool Fallback(HotUpdateWorkflow.ENode target, bool validCheck = true)
		{
			return default(bool);
		}

		// Token: 0x0601CBC0 RID: 117696 RVA: 0x000A9470 File Offset: 0x000A7670
		[Token(Token = "0x601CBC0")]
		[Address(RVA = "0x1629470", Offset = "0x1628070", VA = "0x181629470")]
		public bool CancelAndFallback(HotUpdateWorkflow.ENode target, bool validCheck = true)
		{
			return default(bool);
		}

		// Token: 0x0601CBC1 RID: 117697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CBC1")]
		[Address(RVA = "0x162A560", Offset = "0x1629160", VA = "0x18162A560")]
		public void SendEvent(ViewEvent evt)
		{
		}

		// Token: 0x0601CBC2 RID: 117698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CBC2")]
		[Address(RVA = "0x162A640", Offset = "0x1629240", VA = "0x18162A640")]
		public void SendEvent(ViewEvent evt, ValueBundle param)
		{
		}

		// Token: 0x0601CBC3 RID: 117699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CBC3")]
		[Address(RVA = "0x16293C0", Offset = "0x1627FC0", VA = "0x1816293C0")]
		public void AddEventReceiver(HotUpdateWorkflow.IEventReceiver receiver)
		{
		}

		// Token: 0x0601CBC4 RID: 117700 RVA: 0x000A9488 File Offset: 0x000A7688
		[Token(Token = "0x601CBC4")]
		[Address(RVA = "0x162AB70", Offset = "0x1629770", VA = "0x18162AB70")]
		public bool UpdateOnce(HotUpdateWorkflow.IWorkerUpdateOnce inst)
		{
			return default(bool);
		}

		// Token: 0x0601CBC5 RID: 117701 RVA: 0x000A94A0 File Offset: 0x000A76A0
		[Token(Token = "0x601CBC5")]
		[Address(RVA = "0x162A170", Offset = "0x1628D70", VA = "0x18162A170")]
		public static bool IsBeforeWork(HotUpdateWorkflow.ENode curNode, HotUpdateWorkflow.ENode check)
		{
			return default(bool);
		}

		// Token: 0x0601CBC6 RID: 117702 RVA: 0x000A94B8 File Offset: 0x000A76B8
		[Token(Token = "0x601CBC6")]
		[Address(RVA = "0x162A310", Offset = "0x1628F10", VA = "0x18162A310")]
		public static bool IsOnOrAfterWork(HotUpdateWorkflow.ENode curNode, HotUpdateWorkflow.ENode check)
		{
			return default(bool);
		}

		// Token: 0x0601CBC7 RID: 117703 RVA: 0x000A94D0 File Offset: 0x000A76D0
		[Token(Token = "0x601CBC7")]
		[Address(RVA = "0x162A080", Offset = "0x1628C80", VA = "0x18162A080")]
		public static bool IsAfterWork(HotUpdateWorkflow.ENode target, HotUpdateWorkflow.ENode check)
		{
			return default(bool);
		}

		// Token: 0x0601CBC8 RID: 117704 RVA: 0x000A94E8 File Offset: 0x000A76E8
		[Token(Token = "0x601CBC8")]
		[Address(RVA = "0x162AD10", Offset = "0x1629910", VA = "0x18162AD10")]
		private bool _HandleGlobalEvent(ViewEvent evt, ValueBundle param)
		{
			return default(bool);
		}

		// Token: 0x04025B70 RID: 154480
		[Token(Token = "0x4025B70")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HotUpdateWorkflow.ENode[] NODE_ORDER;

		// Token: 0x04025B71 RID: 154481
		[Token(Token = "0x4025B71")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<HotUpdateWorkflow.Node> m_nodes;

		// Token: 0x04025B72 RID: 154482
		[Token(Token = "0x4025B72")]
		[FieldOffset(Offset = "0x18")]
		private HotUpdateWorkflow.IContext m_context;

		// Token: 0x04025B73 RID: 154483
		[Token(Token = "0x4025B73")]
		[FieldOffset(Offset = "0x20")]
		private HotUpdateWorkflow.FWork m_work;

		// Token: 0x04025B74 RID: 154484
		[Token(Token = "0x4025B74")]
		[FieldOffset(Offset = "0x30")]
		private HotUpdateWorkflow.Worker m_worker;

		// Token: 0x04025B75 RID: 154485
		[Token(Token = "0x4025B75")]
		[FieldOffset(Offset = "0x38")]
		private IEnumerator m_mainRoutine;

		// Token: 0x04025B76 RID: 154486
		[Token(Token = "0x4025B76")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<HotUpdateWorkflow.IEventReceiver> m_evtRecvrs;

		// Token: 0x04025B77 RID: 154487
		[Token(Token = "0x4025B77")]
		[FieldOffset(Offset = "0x48")]
		private List<HotUpdateWorkflow.IEventReceiver> m_recvrBuffer;

		// Token: 0x04025B7A RID: 154490
		[Token(Token = "0x4025B7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_clientOutOfDateReason;

		// Token: 0x04025B7B RID: 154491
		[Token(Token = "0x4025B7B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_clientOutOfDateReason;

		// Token: 0x04025B7C RID: 154492
		[Token(Token = "0x4025B7C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isDisposed;

		// Token: 0x04025B7D RID: 154493
		[Token(Token = "0x4025B7D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_isDisposed;

		// Token: 0x04025B7E RID: 154494
		[Token(Token = "0x4025B7E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04025B7F RID: 154495
		[Token(Token = "0x4025B7F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04025B80 RID: 154496
		[Token(Token = "0x4025B80")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_StartWorkflow;

		// Token: 0x04025B81 RID: 154497
		[Token(Token = "0x4025B81")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoWorkFlowRoutine;

		// Token: 0x04025B82 RID: 154498
		[Token(Token = "0x4025B82")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04025B83 RID: 154499
		[Token(Token = "0x4025B83")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_PeekFallbackStatus;

		// Token: 0x04025B84 RID: 154500
		[Token(Token = "0x4025B84")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Fallback;

		// Token: 0x04025B85 RID: 154501
		[Token(Token = "0x4025B85")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CancelAndFallback;

		// Token: 0x04025B86 RID: 154502
		[Token(Token = "0x4025B86")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SendEvent;

		// Token: 0x04025B87 RID: 154503
		[Token(Token = "0x4025B87")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_SendEvent;

		// Token: 0x04025B88 RID: 154504
		[Token(Token = "0x4025B88")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_AddEventReceiver;

		// Token: 0x04025B89 RID: 154505
		[Token(Token = "0x4025B89")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdateOnce;

		// Token: 0x04025B8A RID: 154506
		[Token(Token = "0x4025B8A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_IsBeforeWork;

		// Token: 0x04025B8B RID: 154507
		[Token(Token = "0x4025B8B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_IsOnOrAfterWork;

		// Token: 0x04025B8C RID: 154508
		[Token(Token = "0x4025B8C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_IsAfterWork;

		// Token: 0x04025B8D RID: 154509
		[Token(Token = "0x4025B8D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandleGlobalEvent;

		// Token: 0x02004AC0 RID: 19136
		[Token(Token = "0x2004AC0")]
		public interface IContext
		{
			// Token: 0x0601CBCA RID: 117706
			[Token(Token = "0x601CBCA")]
			Coroutine StartCoroutine(IEnumerator routine);

			// Token: 0x0601CBCB RID: 117707
			[Token(Token = "0x601CBCB")]
			void StopCoroutineNested(IEnumerator routine);

			// Token: 0x0601CBCC RID: 117708
			[Token(Token = "0x601CBCC")]
			HotUpdateViewProp GetViewProp();

			// Token: 0x0601CBCD RID: 117709
			[Token(Token = "0x601CBCD")]
			HotUpdateViewController GetViewCtrl();
		}

		// Token: 0x02004AC1 RID: 19137
		[Token(Token = "0x2004AC1")]
		public struct Options
		{
			// Token: 0x04025B8E RID: 154510
			[Token(Token = "0x4025B8E")]
			[FieldOffset(Offset = "0x0")]
			public HotUpdateWorkflow.IContext context;

			// Token: 0x04025B8F RID: 154511
			[Token(Token = "0x4025B8F")]
			[FieldOffset(Offset = "0x8")]
			public List<HotUpdateWorkflow.Node> nodes;
		}

		// Token: 0x02004AC2 RID: 19138
		[Token(Token = "0x2004AC2")]
		public abstract class Node : IHotfixable
		{
			// Token: 0x170043CA RID: 17354
			// (get) Token: 0x0601CBCE RID: 117710 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601CBCF RID: 117711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170043CA")]
			private protected HotUpdateWorkflow.IContext context
			{
				[Token(Token = "0x601CBCE")]
				[Address(RVA = "0x162F780", Offset = "0x162E380", VA = "0x18162F780")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x601CBCF")]
				[Address(RVA = "0x162F840", Offset = "0x162E440", VA = "0x18162F840")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170043CB RID: 17355
			// (get) Token: 0x0601CBD0 RID: 117712 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601CBD1 RID: 117713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170043CB")]
			private protected HotUpdateWorkflow workflow
			{
				[Token(Token = "0x601CBD0")]
				[Address(RVA = "0x162F7E0", Offset = "0x162E3E0", VA = "0x18162F7E0")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x601CBD1")]
				[Address(RVA = "0x162F8C0", Offset = "0x162E4C0", VA = "0x18162F8C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601CBD2 RID: 117714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBD2")]
			[Address(RVA = "0x162F4C0", Offset = "0x162E0C0", VA = "0x18162F4C0")]
			public void Init(HotUpdateWorkflow.IContext context, HotUpdateWorkflow workflow)
			{
			}

			// Token: 0x0601CBD3 RID: 117715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBD3")]
			[Address(RVA = "0x162F2A0", Offset = "0x162DEA0", VA = "0x18162F2A0")]
			public void Dispose()
			{
			}

			// Token: 0x170043CC RID: 17356
			// (get) Token: 0x0601CBD4 RID: 117716
			[Token(Token = "0x170043CC")]
			public abstract HotUpdateWorkflow.ENode type { [Token(Token = "0x601CBD4")] get; }

			// Token: 0x0601CBD5 RID: 117717
			[Token(Token = "0x601CBD5")]
			public abstract CustomYieldInstruction Work();

			// Token: 0x0601CBD6 RID: 117718 RVA: 0x000A9500 File Offset: 0x000A7700
			[Token(Token = "0x601CBD6")]
			[Address(RVA = "0x162F1E0", Offset = "0x162DDE0", VA = "0x18162F1E0", Slot = "6")]
			public virtual bool CanCancel()
			{
				return default(bool);
			}

			// Token: 0x0601CBD7 RID: 117719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CBD7")]
			[Address(RVA = "0x162F240", Offset = "0x162DE40", VA = "0x18162F240", Slot = "7")]
			public virtual CustomYieldInstruction Cancel()
			{
				return null;
			}

			// Token: 0x0601CBD8 RID: 117720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBD8")]
			[Address(RVA = "0x162F6C0", Offset = "0x162E2C0", VA = "0x18162F6C0", Slot = "8")]
			protected virtual void OnInit()
			{
			}

			// Token: 0x0601CBD9 RID: 117721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBD9")]
			[Address(RVA = "0x1620860", Offset = "0x161F460", VA = "0x181620860", Slot = "9")]
			public virtual void OnDispose()
			{
			}

			// Token: 0x0601CBDA RID: 117722 RVA: 0x000A9518 File Offset: 0x000A7718
			[Token(Token = "0x601CBDA")]
			[Address(RVA = "0x162F620", Offset = "0x162E220", VA = "0x18162F620", Slot = "10")]
			public virtual bool OnEvent(ViewEvent evt, ValueBundle param)
			{
				return default(bool);
			}

			// Token: 0x0601CBDB RID: 117723 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CBDB")]
			[Address(RVA = "0x162F0F0", Offset = "0x162DCF0", VA = "0x18162F0F0")]
			protected IEnumerator AlertNetErrorAndFallback(string message, HotUpdateWorkflow.ENode fallback)
			{
				return null;
			}

			// Token: 0x0601CBDC RID: 117724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBDC")]
			[Address(RVA = "0x162F320", Offset = "0x162DF20", VA = "0x18162F320")]
			public void FallbackToGameVersionUpgrading(NetworkRouterConfig.Content reason)
			{
			}

			// Token: 0x0601CBDD RID: 117725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBDD")]
			[Address(RVA = "0x162F720", Offset = "0x162E320", VA = "0x18162F720")]
			protected Node()
			{
			}

			// Token: 0x04025B92 RID: 154514
			[Token(Token = "0x4025B92")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_context;

			// Token: 0x04025B93 RID: 154515
			[Token(Token = "0x4025B93")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_context;

			// Token: 0x04025B94 RID: 154516
			[Token(Token = "0x4025B94")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_workflow;

			// Token: 0x04025B95 RID: 154517
			[Token(Token = "0x4025B95")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_workflow;

			// Token: 0x04025B96 RID: 154518
			[Token(Token = "0x4025B96")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04025B97 RID: 154519
			[Token(Token = "0x4025B97")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x04025B98 RID: 154520
			[Token(Token = "0x4025B98")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CanCancel;

			// Token: 0x04025B99 RID: 154521
			[Token(Token = "0x4025B99")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_Cancel;

			// Token: 0x04025B9A RID: 154522
			[Token(Token = "0x4025B9A")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04025B9B RID: 154523
			[Token(Token = "0x4025B9B")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnDispose;

			// Token: 0x04025B9C RID: 154524
			[Token(Token = "0x4025B9C")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnEvent;

			// Token: 0x04025B9D RID: 154525
			[Token(Token = "0x4025B9D")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_AlertNetErrorAndFallback;

			// Token: 0x04025B9E RID: 154526
			[Token(Token = "0x4025B9E")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_FallbackToGameVersionUpgrading;

			// Token: 0x04025B9F RID: 154527
			[Token(Token = "0x4025B9F")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004AC4 RID: 19140
		[Token(Token = "0x2004AC4")]
		public enum ENode
		{
			// Token: 0x04025BA6 RID: 154534
			[Token(Token = "0x4025BA6")]
			NONE,
			// Token: 0x04025BA7 RID: 154535
			[Token(Token = "0x4025BA7")]
			GAME_UDT_SDK,
			// Token: 0x04025BA8 RID: 154536
			[Token(Token = "0x4025BA8")]
			CLIENT_UPGRADE,
			// Token: 0x04025BA9 RID: 154537
			[Token(Token = "0x4025BA9")]
			FETCH_CONFIG,
			// Token: 0x04025BAA RID: 154538
			[Token(Token = "0x4025BAA")]
			DOWNLOAD_INIT,
			// Token: 0x04025BAB RID: 154539
			[Token(Token = "0x4025BAB")]
			DOWNLOAD_MAIN,
			// Token: 0x04025BAC RID: 154540
			[Token(Token = "0x4025BAC")]
			RES_CHECK_INIT,
			// Token: 0x04025BAD RID: 154541
			[Token(Token = "0x4025BAD")]
			RES_CHECK_MAIN,
			// Token: 0x04025BAE RID: 154542
			[Token(Token = "0x4025BAE")]
			WRITE_CONFIG,
			// Token: 0x04025BAF RID: 154543
			[Token(Token = "0x4025BAF")]
			READY_TO_LOGIN,
			// Token: 0x04025BB0 RID: 154544
			[Token(Token = "0x4025BB0")]
			FINISH
		}

		// Token: 0x02004AC5 RID: 19141
		[Token(Token = "0x2004AC5")]
		public interface IWorkerUpdateOnce
		{
			// Token: 0x0601CBE4 RID: 117732
			[Token(Token = "0x601CBE4")]
			void Worker_UpdateOnce();
		}

		// Token: 0x02004AC6 RID: 19142
		[Token(Token = "0x2004AC6")]
		public interface IEventReceiver
		{
			// Token: 0x0601CBE5 RID: 117733
			[Token(Token = "0x601CBE5")]
			void OnEvent(ViewEvent evt, ValueBundle param);
		}

		// Token: 0x02004AC7 RID: 19143
		[Token(Token = "0x2004AC7")]
		private class Worker : IDisposable
		{
			// Token: 0x170043CF RID: 17359
			// (get) Token: 0x0601CBE6 RID: 117734 RVA: 0x000A9548 File Offset: 0x000A7748
			// (set) Token: 0x0601CBE7 RID: 117735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170043CF")]
			public bool isCancelled
			{
				[Token(Token = "0x601CBE6")]
				[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x601CBE7")]
				[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170043D0 RID: 17360
			// (get) Token: 0x0601CBE8 RID: 117736 RVA: 0x000A9560 File Offset: 0x000A7760
			// (set) Token: 0x0601CBE9 RID: 117737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170043D0")]
			public bool isDisposed
			{
				[Token(Token = "0x601CBE8")]
				[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x601CBE9")]
				[Address(RVA = "0x1636A20", Offset = "0x1635620", VA = "0x181636A20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170043D1 RID: 17361
			// (get) Token: 0x0601CBEA RID: 117738 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601CBEB RID: 117739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170043D1")]
			public HotUpdateWorkflow.Node curNode
			{
				[Token(Token = "0x601CBEA")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601CBEB")]
				[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601CBEC RID: 117740 RVA: 0x000A9578 File Offset: 0x000A7778
			[Token(Token = "0x601CBEC")]
			[Address(RVA = "0x16364F0", Offset = "0x16350F0", VA = "0x1816364F0")]
			public bool Cancel()
			{
				return default(bool);
			}

			// Token: 0x0601CBED RID: 117741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBED")]
			[Address(RVA = "0x1636550", Offset = "0x1635150", VA = "0x181636550", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0601CBEE RID: 117742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBEE")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			public void SetCurNode(HotUpdateWorkflow.Node node)
			{
			}

			// Token: 0x0601CBEF RID: 117743 RVA: 0x000A9590 File Offset: 0x000A7790
			[Token(Token = "0x601CBEF")]
			[Address(RVA = "0x16365D0", Offset = "0x16351D0", VA = "0x1816365D0")]
			public bool UpdateOnce(HotUpdateWorkflow.IWorkerUpdateOnce inst)
			{
				return default(bool);
			}

			// Token: 0x0601CBF0 RID: 117744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBF0")]
			[Address(RVA = "0x16365C0", Offset = "0x16351C0", VA = "0x1816365C0")]
			public void TickInEmptyFrame()
			{
			}

			// Token: 0x0601CBF1 RID: 117745 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CBF1")]
			[Address(RVA = "0x1636640", Offset = "0x1635240", VA = "0x181636640")]
			public IEnumerator Work(CustomYieldInstruction work)
			{
				return null;
			}

			// Token: 0x0601CBF2 RID: 117746 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBF2")]
			[Address(RVA = "0x16366D0", Offset = "0x16352D0", VA = "0x1816366D0")]
			private void _InternalTick()
			{
			}

			// Token: 0x0601CBF3 RID: 117747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBF3")]
			[Address(RVA = "0x1636940", Offset = "0x1635540", VA = "0x181636940")]
			public Worker()
			{
			}

			// Token: 0x04025BB1 RID: 154545
			[Token(Token = "0x4025BB1")]
			[FieldOffset(Offset = "0x10")]
			private HashSet<HotUpdateWorkflow.IWorkerUpdateOnce> m_updateOnce;

			// Token: 0x04025BB2 RID: 154546
			[Token(Token = "0x4025BB2")]
			[FieldOffset(Offset = "0x18")]
			private List<HotUpdateWorkflow.IWorkerUpdateOnce> m_buffer;

			// Token: 0x04025BB3 RID: 154547
			[Token(Token = "0x4025BB3")]
			[FieldOffset(Offset = "0x20")]
			private CustomYieldInstruction m_curWork;
		}

		// Token: 0x02004AC9 RID: 19145
		[Token(Token = "0x2004AC9")]
		private struct FWork
		{
			// Token: 0x170043D4 RID: 17364
			// (get) Token: 0x0601CBFA RID: 117754 RVA: 0x000A95C0 File Offset: 0x000A77C0
			// (set) Token: 0x0601CBFB RID: 117755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170043D4")]
			public bool didFallback
			{
				[Token(Token = "0x601CBFA")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x601CBFB")]
				[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170043D5 RID: 17365
			// (get) Token: 0x0601CBFC RID: 117756 RVA: 0x000A95D8 File Offset: 0x000A77D8
			// (set) Token: 0x0601CBFD RID: 117757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170043D5")]
			public int nodeIndex
			{
				[Token(Token = "0x601CBFC")]
				[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x601CBFD")]
				[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170043D6 RID: 17366
			// (get) Token: 0x0601CBFE RID: 117758 RVA: 0x000A95F0 File Offset: 0x000A77F0
			// (set) Token: 0x0601CBFF RID: 117759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170043D6")]
			public bool isWorking
			{
				[Token(Token = "0x601CBFE")]
				[Address(RVA = "0xFEDEC0", Offset = "0xFECAC0", VA = "0x180FEDEC0")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x601CBFF")]
				[Address(RVA = "0xFEDEE0", Offset = "0xFECAE0", VA = "0x180FEDEE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601CC00 RID: 117760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CC00")]
			[Address(RVA = "0x1621580", Offset = "0x1620180", VA = "0x181621580")]
			public void MarkFallback(int newIndex)
			{
			}

			// Token: 0x0601CC01 RID: 117761 RVA: 0x000A9608 File Offset: 0x000A7808
			[Token(Token = "0x601CC01")]
			[Address(RVA = "0x1621530", Offset = "0x1620130", VA = "0x181621530")]
			public bool ConsumeFallback()
			{
				return default(bool);
			}

			// Token: 0x0601CC02 RID: 117762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CC02")]
			[Address(RVA = "0x16215E0", Offset = "0x16201E0", VA = "0x1816215E0")]
			public void MoveNextIndex()
			{
			}

			// Token: 0x0601CC03 RID: 117763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CC03")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			public void TriggerController()
			{
			}

			// Token: 0x0601CC04 RID: 117764 RVA: 0x000A9620 File Offset: 0x000A7820
			[Token(Token = "0x601CC04")]
			[Address(RVA = "0x1621630", Offset = "0x1620230", VA = "0x181621630")]
			public static HotUpdateWorkflow.FWork Start()
			{
				return default(HotUpdateWorkflow.FWork);
			}

			// Token: 0x170043D7 RID: 17367
			// (get) Token: 0x0601CC05 RID: 117765 RVA: 0x000A9638 File Offset: 0x000A7838
			[Token(Token = "0x170043D7")]
			public HotUpdateWorkflow.ENode curNode
			{
				[Token(Token = "0x601CC05")]
				[Address(RVA = "0x1621720", Offset = "0x1620320", VA = "0x181621720")]
				get
				{
					return HotUpdateWorkflow.ENode.NONE;
				}
			}

			// Token: 0x0601CC06 RID: 117766 RVA: 0x000A9650 File Offset: 0x000A7850
			[Token(Token = "0x601CC06")]
			[Address(RVA = "0x1621690", Offset = "0x1620290", VA = "0x181621690")]
			public bool WorkEnd()
			{
				return default(bool);
			}

			// Token: 0x04025BBC RID: 154556
			[Token(Token = "0x4025BBC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly HotUpdateWorkflow.FWork IDLE;
		}
	}
}
