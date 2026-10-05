using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Torappu.ObjectPool;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200282F RID: 10287
	[Token(Token = "0x200282F")]
	public class ActionExecutor : IReusableObject, IReusable, IPtrObject
	{
		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x060111F9 RID: 70137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025BC")]
		public ActionContext context
		{
			[Token(Token = "0x60111F9")]
			[Address(RVA = "0x906950", Offset = "0x905550", VA = "0x180906950")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x060111FA RID: 70138 RVA: 0x00069780 File Offset: 0x00067980
		// (set) Token: 0x060111FB RID: 70139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025BD")]
		public ObjectPtr<ActionContext> contextPtr
		{
			[Token(Token = "0x60111FA")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			[CompilerGenerated]
			get
			{
				return default(ObjectPtr<ActionContext>);
			}
			[Token(Token = "0x60111FB")]
			[Address(RVA = "0x906A40", Offset = "0x905640", VA = "0x180906A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170025BE RID: 9662
		// (get) Token: 0x060111FC RID: 70140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025BE")]
		public LevelScriptRuntime levelScriptRuntime
		{
			[Token(Token = "0x60111FC")]
			[Address(RVA = "0x9069C0", Offset = "0x9055C0", VA = "0x1809069C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x060111FD RID: 70141 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060111FE RID: 70142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025BF")]
		public EventParams eventParams
		{
			[Token(Token = "0x60111FD")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60111FE")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x060111FF RID: 70143 RVA: 0x00069798 File Offset: 0x00067998
		// (set) Token: 0x06011200 RID: 70144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025C0")]
		public uint instanceUid
		{
			[Token(Token = "0x60111FF")]
			[Address(RVA = "0x9069A0", Offset = "0x9055A0", VA = "0x1809069A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6011200")]
			[Address(RVA = "0x906A60", Offset = "0x905660", VA = "0x180906A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x06011201 RID: 70145 RVA: 0x000697B0 File Offset: 0x000679B0
		// (set) Token: 0x06011202 RID: 70146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025C1")]
		public bool ticking
		{
			[Token(Token = "0x6011201")]
			[Address(RVA = "0x906A30", Offset = "0x905630", VA = "0x180906A30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6011202")]
			[Address(RVA = "0x906A90", Offset = "0x905690", VA = "0x180906A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x06011203 RID: 70147 RVA: 0x000697C8 File Offset: 0x000679C8
		// (set) Token: 0x06011204 RID: 70148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025C2")]
		public bool ticked
		{
			[Token(Token = "0x6011203")]
			[Address(RVA = "0x906A20", Offset = "0x905620", VA = "0x180906A20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6011204")]
			[Address(RVA = "0x906A80", Offset = "0x905680", VA = "0x180906A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x06011205 RID: 70149 RVA: 0x000697E0 File Offset: 0x000679E0
		// (set) Token: 0x06011206 RID: 70150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025C3")]
		public bool isActive
		{
			[Token(Token = "0x6011205")]
			[Address(RVA = "0x9069B0", Offset = "0x9055B0", VA = "0x1809069B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6011206")]
			[Address(RVA = "0x906A70", Offset = "0x905670", VA = "0x180906A70")]
			set
			{
			}
		}

		// Token: 0x06011207 RID: 70151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011207")]
		[Address(RVA = "0x903890", Offset = "0x902490", VA = "0x180903890")]
		public static ActionExecutor NewExecutor()
		{
			return null;
		}

		// Token: 0x06011208 RID: 70152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011208")]
		[Address(RVA = "0x9038E0", Offset = "0x9024E0", VA = "0x1809038E0", Slot = "7")]
		public virtual void OnAllocate()
		{
		}

		// Token: 0x06011209 RID: 70153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011209")]
		[Address(RVA = "0x9039A0", Offset = "0x9025A0", VA = "0x1809039A0", Slot = "8")]
		public virtual void OnRecycle()
		{
		}

		// Token: 0x0601120A RID: 70154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601120A")]
		[Address(RVA = "0x903FD0", Offset = "0x902BD0", VA = "0x180903FD0")]
		public void Setup(ActionContext context)
		{
		}

		// Token: 0x0601120B RID: 70155 RVA: 0x000697F8 File Offset: 0x000679F8
		[Token(Token = "0x601120B")]
		[Address(RVA = "0x903CD0", Offset = "0x9028D0", VA = "0x180903CD0")]
		public ScopeStack<ParamBlackboard>.Scope<ParamBlackboard> PushContext()
		{
			return default(ScopeStack<ParamBlackboard>.Scope<ParamBlackboard>);
		}

		// Token: 0x0601120C RID: 70156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601120C")]
		[Address(RVA = "0x904BA0", Offset = "0x9037A0", VA = "0x180904BA0")]
		private void _AssignEventParams([Optional] EventParams inputEventParams)
		{
		}

		// Token: 0x0601120D RID: 70157 RVA: 0x00069810 File Offset: 0x00067A10
		[Token(Token = "0x601120D")]
		[Address(RVA = "0x904100", Offset = "0x902D00", VA = "0x180904100")]
		public bool TryToInvoke(EventParams inputEventParams)
		{
			return default(bool);
		}

		// Token: 0x0601120E RID: 70158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601120E")]
		[Address(RVA = "0x906200", Offset = "0x904E00", VA = "0x180906200")]
		private void _OnStart()
		{
		}

		// Token: 0x0601120F RID: 70159 RVA: 0x00069828 File Offset: 0x00067A28
		[Token(Token = "0x601120F")]
		[Address(RVA = "0x906140", Offset = "0x904D40", VA = "0x180906140")]
		private bool _IsTimerLessThanExecuteTimeStamp()
		{
			return default(bool);
		}

		// Token: 0x06011210 RID: 70160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011210")]
		[Address(RVA = "0x903830", Offset = "0x902430", VA = "0x180903830")]
		public void ManualTick()
		{
		}

		// Token: 0x06011211 RID: 70161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011211")]
		[Address(RVA = "0x9040A0", Offset = "0x902CA0", VA = "0x1809040A0")]
		public void Tick(FP deltaTime)
		{
		}

		// Token: 0x06011212 RID: 70162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011212")]
		[Address(RVA = "0x904E50", Offset = "0x903A50", VA = "0x180904E50")]
		private void _DoLogicTick(FP deltaTime)
		{
		}

		// Token: 0x06011213 RID: 70163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011213")]
		[Address(RVA = "0x906490", Offset = "0x905090", VA = "0x180906490")]
		private void _RunSubActionExecutor(int actionID)
		{
		}

		// Token: 0x06011214 RID: 70164 RVA: 0x00069840 File Offset: 0x00067A40
		[Token(Token = "0x6011214")]
		[Address(RVA = "0x906560", Offset = "0x905160", VA = "0x180906560")]
		private bool _TryToRemoveInvalidStackLayer(int depth)
		{
			return default(bool);
		}

		// Token: 0x06011215 RID: 70165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011215")]
		[Address(RVA = "0x903C80", Offset = "0x902880", VA = "0x180903C80")]
		public void PauseAction()
		{
		}

		// Token: 0x06011216 RID: 70166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011216")]
		[Address(RVA = "0x903EC0", Offset = "0x902AC0", VA = "0x180903EC0")]
		public void ResumeAction()
		{
		}

		// Token: 0x06011217 RID: 70167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011217")]
		[Address(RVA = "0x9062D0", Offset = "0x904ED0", VA = "0x1809062D0")]
		private void _OnSubExecutorFinished(ActionExecutor executor)
		{
		}

		// Token: 0x06011218 RID: 70168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011218")]
		[Address(RVA = "0x9061F0", Offset = "0x904DF0", VA = "0x1809061F0")]
		private void _NormalReachEnd()
		{
		}

		// Token: 0x06011219 RID: 70169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011219")]
		[Address(RVA = "0x903320", Offset = "0x901F20", VA = "0x180903320")]
		public void FinishExecution(bool force = false)
		{
		}

		// Token: 0x0601121A RID: 70170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601121A")]
		[Address(RVA = "0x9032D0", Offset = "0x901ED0", VA = "0x1809032D0")]
		public void Dispose()
		{
		}

		// Token: 0x0601121B RID: 70171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601121B")]
		[Address(RVA = "0x903E40", Offset = "0x902A40", VA = "0x180903E40", Slot = "9")]
		public virtual void Recycle()
		{
		}

		// Token: 0x0601121C RID: 70172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601121C")]
		[Address(RVA = "0x904CC0", Offset = "0x9038C0", VA = "0x180904CC0")]
		private void _ClearRunningInfo()
		{
		}

		// Token: 0x0601121D RID: 70173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601121D")]
		[Address(RVA = "0x904DE0", Offset = "0x9039E0", VA = "0x180904DE0")]
		private void _Clear()
		{
		}

		// Token: 0x0601121E RID: 70174 RVA: 0x00069858 File Offset: 0x00067A58
		[Token(Token = "0x601121E")]
		[Address(RVA = "0x906330", Offset = "0x904F30", VA = "0x180906330")]
		private static ScopeStack<ActionExecutor>.Scope<ActionExecutor> _PushScope(ActionExecutor context)
		{
			return default(ScopeStack<ActionExecutor>.Scope<ActionExecutor>);
		}

		// Token: 0x0601121F RID: 70175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601121F")]
		[Address(RVA = "0x905FB0", Offset = "0x904BB0", VA = "0x180905FB0")]
		private void _InitLoggerIfNeeded()
		{
		}

		// Token: 0x06011220 RID: 70176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011220")]
		[Address(RVA = "0x9063E0", Offset = "0x904FE0", VA = "0x1809063E0")]
		private void _RecycleLoggerIfNeeded()
		{
		}

		// Token: 0x06011221 RID: 70177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011221")]
		[Address(RVA = "0x906780", Offset = "0x905380", VA = "0x180906780")]
		public ActionExecutor()
		{
		}

		// Token: 0x040132FE RID: 78590
		[Token(Token = "0x40132FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint s_globalCounter;

		// Token: 0x040132FF RID: 78591
		[Token(Token = "0x40132FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int startNodeID;

		// Token: 0x04013302 RID: 78594
		[Token(Token = "0x4013302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Dictionary<int, int> iteratedNodeSet;

		// Token: 0x04013303 RID: 78595
		[Token(Token = "0x4013303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<int> m_cursorStack;

		// Token: 0x04013304 RID: 78596
		[Token(Token = "0x4013304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<bool> m_previousExecuteResultStack;

		// Token: 0x04013305 RID: 78597
		[Token(Token = "0x4013305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ObjectPtr<ActionExecutor> parentExecutorPtr;

		// Token: 0x04013306 RID: 78598
		[Token(Token = "0x4013306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ScopeStack<ActionExecutor> s_scopeStack;

		// Token: 0x04013307 RID: 78599
		[Token(Token = "0x4013307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly List<ObjectPtr<ActionExecutor>> subExecutorList;

		// Token: 0x04013308 RID: 78600
		[Token(Token = "0x4013308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool isStarted;

		// Token: 0x04013309 RID: 78601
		[Token(Token = "0x4013309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool isFinished;

		// Token: 0x0401330A RID: 78602
		[Token(Token = "0x401330A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public FP timer;

		// Token: 0x0401330B RID: 78603
		[Token(Token = "0x401330B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LevelScriptActionBase currentAction;

		// Token: 0x0401330C RID: 78604
		[Token(Token = "0x401330C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FP executeTimeStamp;

		// Token: 0x0401330D RID: 78605
		[Token(Token = "0x401330D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool needRecycle;

		// Token: 0x04013311 RID: 78609
		[Token(Token = "0x4013311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int m_executionSafer;

		// Token: 0x04013312 RID: 78610
		[Token(Token = "0x4013312")]
		private const int SAFER_MAX_COUNT = 1024;

		// Token: 0x04013313 RID: 78611
		[Token(Token = "0x4013313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Action onFinishCallback;

		// Token: 0x04013314 RID: 78612
		[Token(Token = "0x4013314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool m_isActive;

		// Token: 0x04013315 RID: 78613
		[Token(Token = "0x4013315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<int> s_toRemoveList;

		// Token: 0x04013316 RID: 78614
		[Token(Token = "0x4013316")]
		private const TraceLevel LOG_LEVEL = TraceLevel.Message;

		// Token: 0x04013317 RID: 78615
		[Token(Token = "0x4013317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ActionExecutor.LevelActionExecutorTracer m_tracer;

		// Token: 0x02002830 RID: 10288
		[Token(Token = "0x2002830")]
		public class LevelActionExecutorTracer : IReusable
		{
			// Token: 0x06011223 RID: 70179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011223")]
			[Address(RVA = "0x90F9F0", Offset = "0x90E5F0", VA = "0x18090F9F0")]
			public static ActionExecutor.LevelActionExecutorTracer NewLevelActionExecutorTracer()
			{
				return null;
			}

			// Token: 0x06011224 RID: 70180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011224")]
			[Address(RVA = "0x90FAA0", Offset = "0x90E6A0", VA = "0x18090FAA0", Slot = "4")]
			public void OnAllocate()
			{
			}

			// Token: 0x06011225 RID: 70181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011225")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public void OnRecycle()
			{
			}

			// Token: 0x06011226 RID: 70182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011226")]
			[Address(RVA = "0x90F910", Offset = "0x90E510", VA = "0x18090F910")]
			public void Init(uint uid, uint parentUid)
			{
			}

			// Token: 0x06011227 RID: 70183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011227")]
			[Address(RVA = "0x90FB20", Offset = "0x90E720", VA = "0x18090FB20")]
			private void _BeginExecuteStep(TraceLevel level, TraceType stepName, object[] context)
			{
			}

			// Token: 0x06011228 RID: 70184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011228")]
			[Address(RVA = "0x90FED0", Offset = "0x90EAD0", VA = "0x18090FED0")]
			private void _Trace(TraceLevel level, string info)
			{
			}

			// Token: 0x06011229 RID: 70185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011229")]
			[Address(RVA = "0x90FE20", Offset = "0x90EA20", VA = "0x18090FE20")]
			[Conditional("UNITY_EDITOR")]
			private void _TraceInEditor(TraceLevel level, string info)
			{
			}

			// Token: 0x0601122A RID: 70186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601122A")]
			[Address(RVA = "0x90FDD0", Offset = "0x90E9D0", VA = "0x18090FDD0")]
			private void _EndExecuteStep()
			{
			}

			// Token: 0x0601122B RID: 70187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601122B")]
			[Address(RVA = "0x90FAD0", Offset = "0x90E6D0", VA = "0x18090FAD0")]
			public string TraceContent()
			{
				return null;
			}

			// Token: 0x0601122C RID: 70188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601122C")]
			[Address(RVA = "0x90FF00", Offset = "0x90EB00", VA = "0x18090FF00")]
			public LevelActionExecutorTracer()
			{
			}

			// Token: 0x04013318 RID: 78616
			[Token(Token = "0x4013318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string strId;

			// Token: 0x04013319 RID: 78617
			[Token(Token = "0x4013319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private StringBuilder m_builder;

			// Token: 0x0401331A RID: 78618
			[Token(Token = "0x401331A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TraceLevel m_logLevel;

			// Token: 0x0401331B RID: 78619
			[Token(Token = "0x401331B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private TraceType m_lastStepType;

			// Token: 0x0401331C RID: 78620
			[Token(Token = "0x401331C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int? m_lastDepth;

			// Token: 0x02002831 RID: 10289
			[Token(Token = "0x2002831")]
			public struct ScopedExecuteStep : IDisposable
			{
				// Token: 0x0601122D RID: 70189 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601122D")]
				[Address(RVA = "0x91A3D0", Offset = "0x918FD0", VA = "0x18091A3D0")]
				internal ScopedExecuteStep(TraceLevel level, TraceType type, ActionExecutor.LevelActionExecutorTracer tracer, params object[] context)
				{
				}

				// Token: 0x0601122E RID: 70190 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601122E")]
				[Address(RVA = "0x91A380", Offset = "0x918F80", VA = "0x18091A380", Slot = "4")]
				private void Dispose()
				{
				}

				// Token: 0x0401331D RID: 78621
				[Token(Token = "0x401331D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private ActionExecutor.LevelActionExecutorTracer m_executorTracer;
			}
		}
	}
}
