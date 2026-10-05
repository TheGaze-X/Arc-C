using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act35side
{
	// Token: 0x02007476 RID: 29814
	[Token(Token = "0x2007476")]
	public class Act35sideMistStagePlugin : SimpleActivityStageButtonOnMapPlugin, IHotfixable
	{
		// Token: 0x0602A0DB RID: 172251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0DB")]
		[Address(RVA = "0x2598A20", Offset = "0x2597620", VA = "0x182598A20", Slot = "4")]
		public override void RenderStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
		}

		// Token: 0x0602A0DC RID: 172252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0DC")]
		[Address(RVA = "0x2598BD0", Offset = "0x25977D0", VA = "0x182598BD0")]
		public Act35sideMistStagePlugin()
		{
		}

		// Token: 0x0403C57B RID: 247163
		[Token(Token = "0x403C57B")]
		private const string MIST_TARGET_FORMAT = "/{0}";

		// Token: 0x0403C57C RID: 247164
		[Token(Token = "0x403C57C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _mistCountText;

		// Token: 0x0403C57D RID: 247165
		[Token(Token = "0x403C57D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _mistTargetText;

		// Token: 0x0403C57E RID: 247166
		[Token(Token = "0x403C57E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x0403C57F RID: 247167
		[Token(Token = "0x403C57F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
