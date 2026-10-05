using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act17side
{
	// Token: 0x020079AB RID: 31147
	[Token(Token = "0x20079AB")]
	public class Act17sideEntryButtonPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602BB11 RID: 178961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB11")]
		[Address(RVA = "0x27A2F90", Offset = "0x27A1B90", VA = "0x1827A2F90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BB12 RID: 178962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB12")]
		[Address(RVA = "0x27A2D90", Offset = "0x27A1990", VA = "0x1827A2D90")]
		public void OpenArchive()
		{
		}

		// Token: 0x0602BB13 RID: 178963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB13")]
		[Address(RVA = "0x27A2B50", Offset = "0x27A1750", VA = "0x1827A2B50", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602BB14 RID: 178964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB14")]
		[Address(RVA = "0x27A3070", Offset = "0x27A1C70", VA = "0x1827A3070")]
		public Act17sideEntryButtonPlugin()
		{
		}

		// Token: 0x0403F360 RID: 258912
		[Token(Token = "0x403F360")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _newArchiveTrackPoint;

		// Token: 0x0403F361 RID: 258913
		[Token(Token = "0x403F361")]
		[FieldOffset(Offset = "0x30")]
		private TrackPointViewProperty m_newProperty;

		// Token: 0x0403F362 RID: 258914
		[Token(Token = "0x403F362")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0403F363 RID: 258915
		[Token(Token = "0x403F363")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F364 RID: 258916
		[Token(Token = "0x403F364")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenArchive;

		// Token: 0x0403F365 RID: 258917
		[Token(Token = "0x403F365")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403F366 RID: 258918
		[Token(Token = "0x403F366")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
