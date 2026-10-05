using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200765B RID: 30299
	[Token(Token = "0x200765B")]
	public class Act20sideCampaignStagePlugin : StageButtonHolderPlugin
	{
		// Token: 0x0602A9E3 RID: 174563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9E3")]
		[Address(RVA = "0x264F780", Offset = "0x264E380", VA = "0x18264F780", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602A9E4 RID: 174564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9E4")]
		[Address(RVA = "0x264F860", Offset = "0x264E460", VA = "0x18264F860", Slot = "5")]
		protected override void OnRenderStage(StageViewModel model)
		{
		}

		// Token: 0x0602A9E5 RID: 174565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9E5")]
		[Address(RVA = "0x264FA50", Offset = "0x264E650", VA = "0x18264FA50")]
		public Act20sideCampaignStagePlugin()
		{
		}

		// Token: 0x0403D604 RID: 251396
		[Token(Token = "0x403D604")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtCount;

		// Token: 0x0403D605 RID: 251397
		[Token(Token = "0x403D605")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _mistTargetCount;

		// Token: 0x0403D606 RID: 251398
		[Token(Token = "0x403D606")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelPlugin;

		// Token: 0x0403D607 RID: 251399
		[Token(Token = "0x403D607")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Graphic _selectedGraphic;

		// Token: 0x0403D608 RID: 251400
		[Token(Token = "0x403D608")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403D609 RID: 251401
		[Token(Token = "0x403D609")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderStage;

		// Token: 0x0403D60A RID: 251402
		[Token(Token = "0x403D60A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
