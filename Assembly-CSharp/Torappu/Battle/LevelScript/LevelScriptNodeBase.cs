using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200283F RID: 10303
	[Token(Token = "0x200283F")]
	public class LevelScriptNodeBase : IHotfixable
	{
		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x06011280 RID: 70272 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06011281 RID: 70273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025CF")]
		[JsonIgnore]
		public ActionContext context
		{
			[Token(Token = "0x6011280")]
			[Address(RVA = "0x915F50", Offset = "0x914B50", VA = "0x180915F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6011281")]
			[Address(RVA = "0x9160F0", Offset = "0x914CF0", VA = "0x1809160F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x06011282 RID: 70274 RVA: 0x000699C0 File Offset: 0x00067BC0
		// (set) Token: 0x06011283 RID: 70275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025D0")]
		[JsonIgnore]
		public ObjectPtr<ActionExecutor> executor
		{
			[Token(Token = "0x6011282")]
			[Address(RVA = "0x915FB0", Offset = "0x914BB0", VA = "0x180915FB0")]
			[CompilerGenerated]
			get
			{
				return default(ObjectPtr<ActionExecutor>);
			}
			[Token(Token = "0x6011283")]
			[Address(RVA = "0x916170", Offset = "0x914D70", VA = "0x180916170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x06011284 RID: 70276 RVA: 0x000699D8 File Offset: 0x00067BD8
		// (set) Token: 0x06011285 RID: 70277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025D1")]
		[JsonIgnore]
		public LevelScriptNodeBase.State state
		{
			[Token(Token = "0x6011284")]
			[Address(RVA = "0x916090", Offset = "0x914C90", VA = "0x180916090")]
			[CompilerGenerated]
			get
			{
				return LevelScriptNodeBase.State.Default;
			}
			[Token(Token = "0x6011285")]
			[Address(RVA = "0x916260", Offset = "0x914E60", VA = "0x180916260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x06011286 RID: 70278 RVA: 0x000699F0 File Offset: 0x00067BF0
		// (set) Token: 0x06011287 RID: 70279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025D2")]
		[JsonIgnore]
		public int runTime
		{
			[Token(Token = "0x6011286")]
			[Address(RVA = "0x916030", Offset = "0x914C30", VA = "0x180916030")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6011287")]
			[Address(RVA = "0x9161F0", Offset = "0x914DF0", VA = "0x1809161F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06011288 RID: 70280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011288")]
		[Address(RVA = "0x915D10", Offset = "0x914910", VA = "0x180915D10")]
		public void SetupExecutor(ActionExecutor executor)
		{
		}

		// Token: 0x06011289 RID: 70281 RVA: 0x00069A08 File Offset: 0x00067C08
		[Token(Token = "0x6011289")]
		[Address(RVA = "0x9156A0", Offset = "0x9142A0", VA = "0x1809156A0")]
		public LevelScriptNodeBase.EnterResult BeforeEnter()
		{
			return LevelScriptNodeBase.EnterResult.FirstTime;
		}

		// Token: 0x0601128A RID: 70282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601128A")]
		[Address(RVA = "0x915C60", Offset = "0x914860", VA = "0x180915C60")]
		public void SetupContext(ActionContext context)
		{
		}

		// Token: 0x0601128B RID: 70283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601128B")]
		[Address(RVA = "0x9159F0", Offset = "0x9145F0", VA = "0x1809159F0", Slot = "4")]
		protected virtual void DoClean()
		{
		}

		// Token: 0x0601128C RID: 70284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601128C")]
		[Address(RVA = "0x915C00", Offset = "0x914800", VA = "0x180915C00", Slot = "5")]
		protected virtual void OnRelease()
		{
		}

		// Token: 0x0601128D RID: 70285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601128D")]
		[Address(RVA = "0x915A50", Offset = "0x914650", VA = "0x180915A50")]
		public void ExecutorFinished()
		{
		}

		// Token: 0x0601128E RID: 70286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601128E")]
		[Address(RVA = "0x9157B0", Offset = "0x9143B0", VA = "0x1809157B0")]
		public void Clean()
		{
		}

		// Token: 0x0601128F RID: 70287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601128F")]
		[Address(RVA = "0x915E00", Offset = "0x914A00", VA = "0x180915E00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06011290 RID: 70288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011290")]
		[Address(RVA = "0x915EF0", Offset = "0x914AF0", VA = "0x180915EF0")]
		public LevelScriptNodeBase()
		{
		}

		// Token: 0x06011291 RID: 70289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011291")]
		[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x04013364 RID: 78692
		[Token(Token = "0x4013364")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[JsonProperty(DefaultValueHandling = 1, Order = -10)]
		public bool _releaseWhenExecutionFinished;

		// Token: 0x04013365 RID: 78693
		[Token(Token = "0x4013365")]
		[FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public int _ID;

		// Token: 0x0401336A RID: 78698
		[Token(Token = "0x401336A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_context;

		// Token: 0x0401336B RID: 78699
		[Token(Token = "0x401336B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_context;

		// Token: 0x0401336C RID: 78700
		[Token(Token = "0x401336C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_executor;

		// Token: 0x0401336D RID: 78701
		[Token(Token = "0x401336D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_executor;

		// Token: 0x0401336E RID: 78702
		[Token(Token = "0x401336E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0401336F RID: 78703
		[Token(Token = "0x401336F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x04013370 RID: 78704
		[Token(Token = "0x4013370")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_runTime;

		// Token: 0x04013371 RID: 78705
		[Token(Token = "0x4013371")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_runTime;

		// Token: 0x04013372 RID: 78706
		[Token(Token = "0x4013372")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetupExecutor;

		// Token: 0x04013373 RID: 78707
		[Token(Token = "0x4013373")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_BeforeEnter;

		// Token: 0x04013374 RID: 78708
		[Token(Token = "0x4013374")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetupContext;

		// Token: 0x04013375 RID: 78709
		[Token(Token = "0x4013375")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoClean;

		// Token: 0x04013376 RID: 78710
		[Token(Token = "0x4013376")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnRelease;

		// Token: 0x04013377 RID: 78711
		[Token(Token = "0x4013377")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ExecutorFinished;

		// Token: 0x04013378 RID: 78712
		[Token(Token = "0x4013378")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Clean;

		// Token: 0x04013379 RID: 78713
		[Token(Token = "0x4013379")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ToString;

		// Token: 0x0401337A RID: 78714
		[Token(Token = "0x401337A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002840 RID: 10304
		[Token(Token = "0x2002840")]
		public enum State
		{
			// Token: 0x0401337C RID: 78716
			[Token(Token = "0x401337C")]
			Default,
			// Token: 0x0401337D RID: 78717
			[Token(Token = "0x401337D")]
			Running,
			// Token: 0x0401337E RID: 78718
			[Token(Token = "0x401337E")]
			Error
		}

		// Token: 0x02002841 RID: 10305
		[Token(Token = "0x2002841")]
		public enum EnterResult
		{
			// Token: 0x04013380 RID: 78720
			[Token(Token = "0x4013380")]
			FirstTime,
			// Token: 0x04013381 RID: 78721
			[Token(Token = "0x4013381")]
			Running,
			// Token: 0x04013382 RID: 78722
			[Token(Token = "0x4013382")]
			BreakPoint
		}
	}
}
