using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E80 RID: 20096
	[Token(Token = "0x2004E80")]
	public class FireworkCraftAvgAdapter : ExecutorComponent
	{
		// Token: 0x0601DFD3 RID: 122835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFD3")]
		[Address(RVA = "0x179C8A0", Offset = "0x179B4A0", VA = "0x18179C8A0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0601DFD4 RID: 122836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DFD4")]
		[Address(RVA = "0x179C900", Offset = "0x179B500", VA = "0x18179C900", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0601DFD5 RID: 122837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFD5")]
		[Address(RVA = "0x179CB90", Offset = "0x179B790", VA = "0x18179CB90")]
		private void Start()
		{
		}

		// Token: 0x0601DFD6 RID: 122838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFD6")]
		[Address(RVA = "0x179CA90", Offset = "0x179B690", VA = "0x18179CA90")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601DFD7 RID: 122839 RVA: 0x000AD1C0 File Offset: 0x000AB3C0
		[Token(Token = "0x601DFD7")]
		[Address(RVA = "0x179CCF0", Offset = "0x179B8F0", VA = "0x18179CCF0")]
		private bool _ExecuteWaitForCraftPageStable(Command command)
		{
			return default(bool);
		}

		// Token: 0x0601DFD8 RID: 122840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DFD8")]
		[Address(RVA = "0x179CC40", Offset = "0x179B840", VA = "0x18179CC40")]
		private IEnumerator _CoroutineWaitForCraftPageStable()
		{
			return null;
		}

		// Token: 0x0601DFD9 RID: 122841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFD9")]
		[Address(RVA = "0x179CE30", Offset = "0x179BA30", VA = "0x18179CE30")]
		public FireworkCraftAvgAdapter()
		{
		}

		// Token: 0x04027D5F RID: 163167
		[Token(Token = "0x4027D5F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private FireworkCraftState _state;

		// Token: 0x04027D60 RID: 163168
		[Token(Token = "0x4027D60")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04027D61 RID: 163169
		[Token(Token = "0x4027D61")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine m_coroutine;

		// Token: 0x04027D62 RID: 163170
		[Token(Token = "0x4027D62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x04027D63 RID: 163171
		[Token(Token = "0x4027D63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x04027D64 RID: 163172
		[Token(Token = "0x4027D64")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04027D65 RID: 163173
		[Token(Token = "0x4027D65")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04027D66 RID: 163174
		[Token(Token = "0x4027D66")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteWaitForCraftPageStable;

		// Token: 0x04027D67 RID: 163175
		[Token(Token = "0x4027D67")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CoroutineWaitForCraftPageStable;

		// Token: 0x04027D68 RID: 163176
		[Token(Token = "0x4027D68")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
