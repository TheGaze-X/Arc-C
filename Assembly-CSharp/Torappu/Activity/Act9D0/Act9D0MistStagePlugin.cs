using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007144 RID: 28996
	[Token(Token = "0x2007144")]
	public class Act9D0MistStagePlugin : SimpleActivityStageButtonOnMapPlugin, IHotfixable
	{
		// Token: 0x060292A2 RID: 168610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292A2")]
		[Address(RVA = "0x247B620", Offset = "0x247A220", VA = "0x18247B620", Slot = "4")]
		public override void RenderStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
		}

		// Token: 0x060292A3 RID: 168611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292A3")]
		[Address(RVA = "0x247B940", Offset = "0x247A540", VA = "0x18247B940")]
		public Act9D0MistStagePlugin()
		{
		}

		// Token: 0x0403AC99 RID: 240793
		[Token(Token = "0x403AC99")]
		private const string MIST_TARGET_FORMAT = "/{0}";

		// Token: 0x0403AC9A RID: 240794
		[Token(Token = "0x403AC9A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Mist Panel")]
		private GameObject _panelMist;

		// Token: 0x0403AC9B RID: 240795
		[Token(Token = "0x403AC9B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Mist Panel")]
		private Text _mistCountText;

		// Token: 0x0403AC9C RID: 240796
		[Token(Token = "0x403AC9C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Mist Panel")]
		private Text _mistTargetText;

		// Token: 0x0403AC9D RID: 240797
		[Token(Token = "0x403AC9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x0403AC9E RID: 240798
		[Token(Token = "0x403AC9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
