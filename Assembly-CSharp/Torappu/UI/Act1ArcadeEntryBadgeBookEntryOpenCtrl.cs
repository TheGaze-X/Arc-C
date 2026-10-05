using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003431 RID: 13361
	[Token(Token = "0x2003431")]
	public class Act1ArcadeEntryBadgeBookEntryOpenCtrl : CustomPageActivityComponent
	{
		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x06015649 RID: 87625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003297")]
		public override string param
		{
			[Token(Token = "0x6015649")]
			[Address(RVA = "0xDDB630", Offset = "0xDDA230", VA = "0x180DDB630", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601564A RID: 87626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601564A")]
		[Address(RVA = "0xDDB4B0", Offset = "0xDDA0B0", VA = "0x180DDB4B0", Slot = "6")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0601564B RID: 87627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601564B")]
		[Address(RVA = "0xDDB5A0", Offset = "0xDDA1A0", VA = "0x180DDB5A0")]
		public Act1ArcadeEntryBadgeBookEntryOpenCtrl()
		{
		}

		// Token: 0x0401998D RID: 104845
		[Token(Token = "0x401998D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ReadOnly]
		private string _param;

		// Token: 0x0401998E RID: 104846
		[Token(Token = "0x401998E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _openToggle;

		// Token: 0x0401998F RID: 104847
		[Token(Token = "0x401998F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_param;

		// Token: 0x04019990 RID: 104848
		[Token(Token = "0x4019990")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x04019991 RID: 104849
		[Token(Token = "0x4019991")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
