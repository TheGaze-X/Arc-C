using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006927 RID: 26919
	[Token(Token = "0x2006927")]
	public class StagePreviewInfoHardPanelHolder : StagePreviewDynHolder<StagePreviewHardView>
	{
		// Token: 0x060268E6 RID: 157926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60268E6")]
		[Address(RVA = "0x21B3680", Offset = "0x21B2280", VA = "0x1821B3680", Slot = "9")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060268E7 RID: 157927 RVA: 0x000CBAA8 File Offset: 0x000C9CA8
		[Token(Token = "0x60268E7")]
		[Address(RVA = "0x21B3860", Offset = "0x21B2460", VA = "0x1821B3860", Slot = "8")]
		protected override bool SelectStageViewModel(ZoneViewModel zoneModel, out StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x060268E8 RID: 157928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268E8")]
		[Address(RVA = "0x21B36E0", Offset = "0x21B22E0", VA = "0x1821B36E0", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x060268E9 RID: 157929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268E9")]
		[Address(RVA = "0x21B3940", Offset = "0x21B2540", VA = "0x1821B3940")]
		public StagePreviewInfoHardPanelHolder()
		{
		}

		// Token: 0x04036614 RID: 222740
		[Token(Token = "0x4036614")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x04036615 RID: 222741
		[Token(Token = "0x4036615")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectStageViewModel;

		// Token: 0x04036616 RID: 222742
		[Token(Token = "0x4036616")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036617 RID: 222743
		[Token(Token = "0x4036617")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
