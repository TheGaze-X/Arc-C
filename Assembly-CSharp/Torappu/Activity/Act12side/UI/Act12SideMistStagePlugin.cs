using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A91 RID: 31377
	[Token(Token = "0x2007A91")]
	public class Act12SideMistStagePlugin : StageButtonHolderPlugin
	{
		// Token: 0x0602BF3E RID: 180030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF3E")]
		[Address(RVA = "0x27D7420", Offset = "0x27D6020", VA = "0x1827D7420", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602BF3F RID: 180031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF3F")]
		[Address(RVA = "0x27D74B0", Offset = "0x27D60B0", VA = "0x1827D74B0", Slot = "5")]
		protected override void OnRenderStage(StageViewModel nullableModel)
		{
		}

		// Token: 0x0602BF40 RID: 180032 RVA: 0x000DDC40 File Offset: 0x000DBE40
		[Token(Token = "0x602BF40")]
		[Address(RVA = "0x27D77F0", Offset = "0x27D63F0", VA = "0x1827D77F0")]
		private bool _CheckIfPluginActive(StageViewModel model)
		{
			return default(bool);
		}

		// Token: 0x0602BF41 RID: 180033 RVA: 0x000DDC58 File Offset: 0x000DBE58
		[Token(Token = "0x602BF41")]
		[Address(RVA = "0x27D78B0", Offset = "0x27D64B0", VA = "0x1827D78B0")]
		private bool _RenderLockedInfoOnInit(string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602BF42 RID: 180034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF42")]
		[Address(RVA = "0x27D7B10", Offset = "0x27D6710", VA = "0x1827D7B10")]
		private void _RenderUnlocked(StageViewModel model)
		{
		}

		// Token: 0x0602BF43 RID: 180035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF43")]
		[Address(RVA = "0x27D7CC0", Offset = "0x27D68C0", VA = "0x1827D7CC0")]
		public Act12SideMistStagePlugin()
		{
		}

		// Token: 0x0403FAA6 RID: 260774
		[Token(Token = "0x403FAA6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Lock")]
		private GameObject _panelLocked;

		// Token: 0x0403FAA7 RID: 260775
		[Token(Token = "0x403FAA7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Lock")]
		private Text _textTimeCond;

		// Token: 0x0403FAA8 RID: 260776
		[Token(Token = "0x403FAA8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Lock")]
		private Text _textStageCond;

		// Token: 0x0403FAA9 RID: 260777
		[Token(Token = "0x403FAA9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Lock")]
		private GameObject _slashTimeCond;

		// Token: 0x0403FAAA RID: 260778
		[Token(Token = "0x403FAAA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Lock")]
		private GameObject _slashStageCond;

		// Token: 0x0403FAAB RID: 260779
		[Token(Token = "0x403FAAB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Unlock")]
		private GameObject _panelUnlocked;

		// Token: 0x0403FAAC RID: 260780
		[Token(Token = "0x403FAAC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Unlock")]
		private Text _textCurCount;

		// Token: 0x0403FAAD RID: 260781
		[Token(Token = "0x403FAAD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Unlock")]
		private Text _textTargetCount;

		// Token: 0x0403FAAE RID: 260782
		[Token(Token = "0x403FAAE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Unlock")]
		private int _mistTargetCount;

		// Token: 0x0403FAAF RID: 260783
		[Token(Token = "0x403FAAF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelPlugin;

		// Token: 0x0403FAB0 RID: 260784
		[Token(Token = "0x403FAB0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Tooltip("This stage is used to locate current plugin to an activity while the stageself may be banned.")]
		private string _anchorStageId;

		// Token: 0x0403FAB1 RID: 260785
		[Token(Token = "0x403FAB1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403FAB2 RID: 260786
		[Token(Token = "0x403FAB2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderStage;

		// Token: 0x0403FAB3 RID: 260787
		[Token(Token = "0x403FAB3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfPluginActive;

		// Token: 0x0403FAB4 RID: 260788
		[Token(Token = "0x403FAB4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderLockedInfoOnInit;

		// Token: 0x0403FAB5 RID: 260789
		[Token(Token = "0x403FAB5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderUnlocked;

		// Token: 0x0403FAB6 RID: 260790
		[Token(Token = "0x403FAB6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
