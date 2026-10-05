using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002848 RID: 10312
	[Token(Token = "0x2002848")]
	public class LevelScriptActionBase : LevelScriptNodeBase
	{
		// Token: 0x060112A8 RID: 70312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112A8")]
		[Address(RVA = "0x911A30", Offset = "0x910630", VA = "0x180911A30")]
		protected void SetResultReservedID(int value)
		{
		}

		// Token: 0x060112A9 RID: 70313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112A9")]
		[Address(RVA = "0x911870", Offset = "0x910470", VA = "0x180911870")]
		protected void SetResultDelayToNext(float value)
		{
		}

		// Token: 0x060112AA RID: 70314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112AA")]
		[Address(RVA = "0x9118E0", Offset = "0x9104E0", VA = "0x1809118E0")]
		protected void SetResultLaunchSubNodeId(int value)
		{
		}

		// Token: 0x060112AB RID: 70315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112AB")]
		[Address(RVA = "0x9119C0", Offset = "0x9105C0", VA = "0x1809119C0")]
		protected void SetResultNextId(int value)
		{
		}

		// Token: 0x060112AC RID: 70316 RVA: 0x00069AB0 File Offset: 0x00067CB0
		[Token(Token = "0x60112AC")]
		[Address(RVA = "0x911330", Offset = "0x90FF30", VA = "0x180911330")]
		public int GetResultReservedID()
		{
			return 0;
		}

		// Token: 0x060112AD RID: 70317 RVA: 0x00069AC8 File Offset: 0x00067CC8
		[Token(Token = "0x60112AD")]
		[Address(RVA = "0x9112D0", Offset = "0x90FED0", VA = "0x1809112D0")]
		public int GetResultNextID()
		{
			return 0;
		}

		// Token: 0x060112AE RID: 70318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60112AE")]
		[Address(RVA = "0x911390", Offset = "0x90FF90", VA = "0x180911390")]
		public List<int> GetResultSubENodeIdListAdd()
		{
			return null;
		}

		// Token: 0x060112AF RID: 70319 RVA: 0x00069AE0 File Offset: 0x00067CE0
		[Token(Token = "0x60112AF")]
		[Address(RVA = "0x911270", Offset = "0x90FE70", VA = "0x180911270")]
		public bool GetResultFinishNodeId()
		{
			return default(bool);
		}

		// Token: 0x060112B0 RID: 70320 RVA: 0x00069AF8 File Offset: 0x00067CF8
		[Token(Token = "0x60112B0")]
		[Address(RVA = "0x911210", Offset = "0x90FE10", VA = "0x180911210")]
		public float GetResulDelayToNext()
		{
			return 0f;
		}

		// Token: 0x060112B1 RID: 70321 RVA: 0x00069B10 File Offset: 0x00067D10
		[Token(Token = "0x60112B1")]
		[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110", Slot = "6")]
		public virtual bool Execute()
		{
			return default(bool);
		}

		// Token: 0x060112B2 RID: 70322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112B2")]
		[Address(RVA = "0x9114B0", Offset = "0x9100B0", VA = "0x1809114B0")]
		protected void Pause()
		{
		}

		// Token: 0x060112B3 RID: 70323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112B3")]
		[Address(RVA = "0x911640", Offset = "0x910240", VA = "0x180911640")]
		protected void Resume()
		{
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x060112B4 RID: 70324 RVA: 0x00069B28 File Offset: 0x00067D28
		[Token(Token = "0x170025DA")]
		public virtual LevelScriptActionBase.ExecutePolicy executePolicy
		{
			[Token(Token = "0x60112B4")]
			[Address(RVA = "0x911C30", Offset = "0x910830", VA = "0x180911C30", Slot = "7")]
			get
			{
				return LevelScriptActionBase.ExecutePolicy.PREVIOUS_SUCCESS;
			}
		}

		// Token: 0x060112B5 RID: 70325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112B5")]
		[Address(RVA = "0x9113F0", Offset = "0x90FFF0", VA = "0x1809113F0", Slot = "8")]
		protected virtual void OnEnter()
		{
		}

		// Token: 0x060112B6 RID: 70326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112B6")]
		[Address(RVA = "0x911450", Offset = "0x910050", VA = "0x180911450", Slot = "9")]
		protected virtual void OnExit()
		{
		}

		// Token: 0x060112B7 RID: 70327 RVA: 0x00069B40 File Offset: 0x00067D40
		[Token(Token = "0x60112B7")]
		[Address(RVA = "0x910BE0", Offset = "0x90F7E0", VA = "0x180910BE0")]
		public bool CheckCanExecute(bool previousResult)
		{
			return default(bool);
		}

		// Token: 0x060112B8 RID: 70328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112B8")]
		[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0", Slot = "10")]
		public virtual void CollectParams(ref List<IParamBindable> paramList)
		{
		}

		// Token: 0x060112B9 RID: 70329 RVA: 0x00069B58 File Offset: 0x00067D58
		[Token(Token = "0x60112B9")]
		[Address(RVA = "0x910E90", Offset = "0x90FA90", VA = "0x180910E90")]
		public bool Enter()
		{
			return default(bool);
		}

		// Token: 0x060112BA RID: 70330 RVA: 0x00069B70 File Offset: 0x00067D70
		[Token(Token = "0x60112BA")]
		[Address(RVA = "0x910C90", Offset = "0x90F890", VA = "0x180910C90")]
		public bool DoExecute()
		{
			return default(bool);
		}

		// Token: 0x060112BB RID: 70331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112BB")]
		[Address(RVA = "0x911AA0", Offset = "0x9106A0", VA = "0x180911AA0")]
		private void _ResetExecuteResult()
		{
		}

		// Token: 0x060112BC RID: 70332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112BC")]
		[Address(RVA = "0x911000", Offset = "0x90FC00", VA = "0x180911000")]
		public void Exit()
		{
		}

		// Token: 0x060112BD RID: 70333 RVA: 0x00069B88 File Offset: 0x00067D88
		[Token(Token = "0x60112BD")]
		[Address(RVA = "0x910B20", Offset = "0x90F720", VA = "0x180910B20")]
		public bool BeforeExit()
		{
			return default(bool);
		}

		// Token: 0x060112BE RID: 70334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112BE")]
		[Address(RVA = "0x911B30", Offset = "0x910730", VA = "0x180911B30")]
		public LevelScriptActionBase()
		{
		}

		// Token: 0x0401339C RID: 78748
		[Token(Token = "0x401339C")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public int nextId;

		// Token: 0x0401339D RID: 78749
		[Token(Token = "0x401339D")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_finishNodeId;

		// Token: 0x0401339E RID: 78750
		[Token(Token = "0x401339E")]
		[FieldOffset(Offset = "0x40")]
		private int m_nextID;

		// Token: 0x0401339F RID: 78751
		[Token(Token = "0x401339F")]
		[FieldOffset(Offset = "0x44")]
		private int m_reservedID;

		// Token: 0x040133A0 RID: 78752
		[Token(Token = "0x40133A0")]
		[FieldOffset(Offset = "0x48")]
		private float m_delayToNext;

		// Token: 0x040133A1 RID: 78753
		[Token(Token = "0x40133A1")]
		[FieldOffset(Offset = "0x50")]
		private List<int> m_extraSubNodeIdList;

		// Token: 0x040133A2 RID: 78754
		[Token(Token = "0x40133A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetResultReservedID;

		// Token: 0x040133A3 RID: 78755
		[Token(Token = "0x40133A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetResultDelayToNext;

		// Token: 0x040133A4 RID: 78756
		[Token(Token = "0x40133A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetResultLaunchSubNodeId;

		// Token: 0x040133A5 RID: 78757
		[Token(Token = "0x40133A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetResultNextId;

		// Token: 0x040133A6 RID: 78758
		[Token(Token = "0x40133A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetResultReservedID;

		// Token: 0x040133A7 RID: 78759
		[Token(Token = "0x40133A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetResultNextID;

		// Token: 0x040133A8 RID: 78760
		[Token(Token = "0x40133A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetResultSubENodeIdListAdd;

		// Token: 0x040133A9 RID: 78761
		[Token(Token = "0x40133A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetResultFinishNodeId;

		// Token: 0x040133AA RID: 78762
		[Token(Token = "0x40133AA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetResulDelayToNext;

		// Token: 0x040133AB RID: 78763
		[Token(Token = "0x40133AB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x040133AC RID: 78764
		[Token(Token = "0x40133AC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Pause;

		// Token: 0x040133AD RID: 78765
		[Token(Token = "0x40133AD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Resume;

		// Token: 0x040133AE RID: 78766
		[Token(Token = "0x40133AE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_executePolicy;

		// Token: 0x040133AF RID: 78767
		[Token(Token = "0x40133AF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040133B0 RID: 78768
		[Token(Token = "0x40133B0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040133B1 RID: 78769
		[Token(Token = "0x40133B1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckCanExecute;

		// Token: 0x040133B2 RID: 78770
		[Token(Token = "0x40133B2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CollectParams;

		// Token: 0x040133B3 RID: 78771
		[Token(Token = "0x40133B3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Enter;

		// Token: 0x040133B4 RID: 78772
		[Token(Token = "0x40133B4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x040133B5 RID: 78773
		[Token(Token = "0x40133B5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ResetExecuteResult;

		// Token: 0x040133B6 RID: 78774
		[Token(Token = "0x40133B6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Exit;

		// Token: 0x040133B7 RID: 78775
		[Token(Token = "0x40133B7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_BeforeExit;

		// Token: 0x040133B8 RID: 78776
		[Token(Token = "0x40133B8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002849 RID: 10313
		[Token(Token = "0x2002849")]
		public enum ExecutePolicy
		{
			// Token: 0x040133BA RID: 78778
			[Token(Token = "0x40133BA")]
			PREVIOUS_SUCCESS,
			// Token: 0x040133BB RID: 78779
			[Token(Token = "0x40133BB")]
			ALWAYS_EXECUTE,
			// Token: 0x040133BC RID: 78780
			[Token(Token = "0x40133BC")]
			PREVIOUS_FAILED
		}
	}
}
