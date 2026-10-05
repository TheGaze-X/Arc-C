using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007285 RID: 29317
	[Token(Token = "0x2007285")]
	public class Act4D0EntryStageObjContainer : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029861 RID: 170081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029861")]
		[Address(RVA = "0x24DBA80", Offset = "0x24DA680", VA = "0x1824DBA80")]
		public void InitData(Act4D0Data actData)
		{
		}

		// Token: 0x06029862 RID: 170082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029862")]
		[Address(RVA = "0x24DBD60", Offset = "0x24DA960", VA = "0x1824DBD60")]
		public Act4D0EntryStageObjContainer()
		{
		}

		// Token: 0x0403B544 RID: 243012
		[Token(Token = "0x403B544")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act4D0EntryStageObj _stageObj;

		// Token: 0x0403B545 RID: 243013
		[Token(Token = "0x403B545")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act4D0EntryStageObj[] _stageObjects;

		// Token: 0x0403B546 RID: 243014
		[Token(Token = "0x403B546")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403B547 RID: 243015
		[Token(Token = "0x403B547")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403B548 RID: 243016
		[Token(Token = "0x403B548")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
