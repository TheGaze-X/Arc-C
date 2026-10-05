using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001ECE RID: 7886
	[Token(Token = "0x2001ECE")]
	[RequireComponent(typeof(CanvasGroup))]
	public class DecisionPanel : ExecutorComponent
	{
		// Token: 0x0600C372 RID: 50034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C372")]
		[Address(RVA = "0x340E760", Offset = "0x340D360", VA = "0x18340E760", Slot = "10")]
		protected override ICommandExecutor GenerateExecutorWrapper(ExecutorComponent.WrapperOptions options)
		{
			return null;
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x0600C373 RID: 50035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001762")]
		private DecisionCommandPredicator m_decisionCommandPredicator
		{
			[Token(Token = "0x600C373")]
			[Address(RVA = "0x340F9C0", Offset = "0x340E5C0", VA = "0x18340F9C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C374 RID: 50036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C374")]
		[Address(RVA = "0x340E930", Offset = "0x340D530", VA = "0x18340E930", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C375 RID: 50037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C375")]
		[Address(RVA = "0x340EBD0", Offset = "0x340D7D0", VA = "0x18340EBD0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C376 RID: 50038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C376")]
		[Address(RVA = "0x340EB50", Offset = "0x340D750", VA = "0x18340EB50")]
		public void OnOptionButtonPressed(int index)
		{
		}

		// Token: 0x0600C377 RID: 50039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C377")]
		[Address(RVA = "0x340F470", Offset = "0x340E070", VA = "0x18340F470")]
		private void _SetOptionButtonSelect(int index, bool needFinishCommand = true)
		{
		}

		// Token: 0x0600C378 RID: 50040 RVA: 0x00047BF8 File Offset: 0x00045DF8
		[Token(Token = "0x600C378")]
		[Address(RVA = "0x340EC80", Offset = "0x340D880", VA = "0x18340EC80")]
		private bool _ExecuteDecision(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C379 RID: 50041 RVA: 0x00047C10 File Offset: 0x00045E10
		[Token(Token = "0x600C379")]
		[Address(RVA = "0x340EFA0", Offset = "0x340DBA0", VA = "0x18340EFA0")]
		private bool _ExecutePredicate(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C37A RID: 50042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C37A")]
		[Address(RVA = "0x340F740", Offset = "0x340E340", VA = "0x18340F740")]
		private void _SetupOptionText(string[] optionString)
		{
		}

		// Token: 0x0600C37B RID: 50043 RVA: 0x00047C28 File Offset: 0x00045E28
		[Token(Token = "0x600C37B")]
		[Address(RVA = "0x340F1C0", Offset = "0x340DDC0", VA = "0x18340F1C0")]
		private int _GetOptionValue(string valueString, int index)
		{
			return 0;
		}

		// Token: 0x0600C37C RID: 50044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C37C")]
		[Address(RVA = "0x340F340", Offset = "0x340DF40", VA = "0x18340F340")]
		private int[] _GetReferenceValue(string valueString)
		{
			return null;
		}

		// Token: 0x0600C37D RID: 50045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C37D")]
		[Address(RVA = "0x340EAC0", Offset = "0x340D6C0", VA = "0x18340EAC0", Slot = "11")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600C37E RID: 50046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C37E")]
		[Address(RVA = "0x340E700", Offset = "0x340D300", VA = "0x18340E700", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C37F RID: 50047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C37F")]
		[Address(RVA = "0x340E480", Offset = "0x340D080", VA = "0x18340E480")]
		private void Awake()
		{
		}

		// Token: 0x0600C380 RID: 50048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C380")]
		[Address(RVA = "0x340F960", Offset = "0x340E560", VA = "0x18340F960")]
		public DecisionPanel()
		{
		}

		// Token: 0x0600C381 RID: 50049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C381")]
		[Address(RVA = "0x340EC50", Offset = "0x340D850", VA = "0x18340EC50")]
		private ICommandExecutor <>xLuaBaseProxy_GenerateExecutorWrapper(ExecutorComponent.WrapperOptions P0)
		{
			return null;
		}

		// Token: 0x0600C382 RID: 50050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C382")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C383 RID: 50051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C383")]
		[Address(RVA = "0x33F4E00", Offset = "0x33F3A00", VA = "0x1833F4E00")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400C5A5 RID: 50597
		[Token(Token = "0x400C5A5")]
		private const string PARAM_NAME_OPTIONS = "options";

		// Token: 0x0400C5A6 RID: 50598
		[Token(Token = "0x400C5A6")]
		private const string PARAM_NAME_VALUES = "values";

		// Token: 0x0400C5A7 RID: 50599
		[Token(Token = "0x400C5A7")]
		private const string PARAM_NAME_REFERENCES = "references";

		// Token: 0x0400C5A8 RID: 50600
		[Token(Token = "0x400C5A8")]
		private const string COMMAND_NAME_DECISION = "decision";

		// Token: 0x0400C5A9 RID: 50601
		[Token(Token = "0x400C5A9")]
		private const string COMMAND_NAME_PREDICATE = "predicate";

		// Token: 0x0400C5AA RID: 50602
		[Token(Token = "0x400C5AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject[] _optionRoots;

		// Token: 0x0400C5AB RID: 50603
		[Token(Token = "0x400C5AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Text[] m_optionTexts;

		// Token: 0x0400C5AC RID: 50604
		[Token(Token = "0x400C5AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Button[] m_optionButtons;

		// Token: 0x0400C5AD RID: 50605
		[Token(Token = "0x400C5AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Command m_command;

		// Token: 0x0400C5AE RID: 50606
		[Token(Token = "0x400C5AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateExecutorWrapper;

		// Token: 0x0400C5AF RID: 50607
		[Token(Token = "0x400C5AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_m_decisionCommandPredicator;

		// Token: 0x0400C5B0 RID: 50608
		[Token(Token = "0x400C5B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C5B1 RID: 50609
		[Token(Token = "0x400C5B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C5B2 RID: 50610
		[Token(Token = "0x400C5B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnOptionButtonPressed;

		// Token: 0x0400C5B3 RID: 50611
		[Token(Token = "0x400C5B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetOptionButtonSelect;

		// Token: 0x0400C5B4 RID: 50612
		[Token(Token = "0x400C5B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExecuteDecision;

		// Token: 0x0400C5B5 RID: 50613
		[Token(Token = "0x400C5B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExecutePredicate;

		// Token: 0x0400C5B6 RID: 50614
		[Token(Token = "0x400C5B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetupOptionText;

		// Token: 0x0400C5B7 RID: 50615
		[Token(Token = "0x400C5B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetOptionValue;

		// Token: 0x0400C5B8 RID: 50616
		[Token(Token = "0x400C5B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetReferenceValue;

		// Token: 0x0400C5B9 RID: 50617
		[Token(Token = "0x400C5B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400C5BA RID: 50618
		[Token(Token = "0x400C5BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C5BB RID: 50619
		[Token(Token = "0x400C5BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400C5BC RID: 50620
		[Token(Token = "0x400C5BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001ECF RID: 7887
		[Token(Token = "0x2001ECF")]
		private class InternalCommand : CommandExecutorWrapper, IUIInputCommand
		{
			// Token: 0x0600C384 RID: 50052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C384")]
			[Address(RVA = "0x3412ED0", Offset = "0x3411AD0", VA = "0x183412ED0")]
			public InternalCommand(string command, CommandExecuteDelegate executor, [Optional] Action forceEnd, [Optional] RaiseSignalDelegate signalReceiver)
			{
			}

			// Token: 0x0400C5BD RID: 50621
			[Token(Token = "0x400C5BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
