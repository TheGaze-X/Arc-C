using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A95 RID: 31381
	[Token(Token = "0x2007A95")]
	public abstract class Act12sideGenericState : PopupFadeState
	{
		// Token: 0x0602BF5C RID: 180060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF5C")]
		[Address(RVA = "0x27DA5D0", Offset = "0x27D91D0", VA = "0x1827DA5D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BF5D RID: 180061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF5D")]
		[Address(RVA = "0x27DA570", Offset = "0x27D9170", VA = "0x1827DA570", Slot = "31")]
		protected virtual void InitIfNot()
		{
		}

		// Token: 0x17006708 RID: 26376
		// (get) Token: 0x0602BF5E RID: 180062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006708")]
		protected string activityId
		{
			[Token(Token = "0x602BF5E")]
			[Address(RVA = "0x27DAA90", Offset = "0x27D9690", VA = "0x1827DAA90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006709 RID: 26377
		// (get) Token: 0x0602BF5F RID: 180063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006709")]
		protected Act12sideStageController actController
		{
			[Token(Token = "0x602BF5F")]
			[Address(RVA = "0x27DA9F0", Offset = "0x27D95F0", VA = "0x1827DA9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BF60 RID: 180064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF60")]
		[Address(RVA = "0x27DA720", Offset = "0x27D9320", VA = "0x1827DA720")]
		private void _FetchStageController()
		{
		}

		// Token: 0x0602BF61 RID: 180065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF61")]
		[Address(RVA = "0x27DA880", Offset = "0x27D9480", VA = "0x1827DA880")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BF62 RID: 180066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF62")]
		[Address(RVA = "0x27DA990", Offset = "0x27D9590", VA = "0x1827DA990")]
		protected Act12sideGenericState()
		{
		}

		// Token: 0x0602BF64 RID: 180068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF64")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403FADA RID: 260826
		[Token(Token = "0x403FADA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403FADB RID: 260827
		[Token(Token = "0x403FADB")]
		[FieldOffset(Offset = "0x78")]
		private Act12sideStageController m_stageController;

		// Token: 0x0403FADC RID: 260828
		[Token(Token = "0x403FADC")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403FADD RID: 260829
		[Token(Token = "0x403FADD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FADE RID: 260830
		[Token(Token = "0x403FADE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0403FADF RID: 260831
		[Token(Token = "0x403FADF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403FAE0 RID: 260832
		[Token(Token = "0x403FAE0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_actController;

		// Token: 0x0403FAE1 RID: 260833
		[Token(Token = "0x403FAE1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FetchStageController;

		// Token: 0x0403FAE2 RID: 260834
		[Token(Token = "0x403FAE2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FAE3 RID: 260835
		[Token(Token = "0x403FAE3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
