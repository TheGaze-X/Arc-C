using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006929 RID: 26921
	[Token(Token = "0x2006929")]
	public class StagePreviewInfoSixStarPanelHolder : StagePreviewDynHolder<SixStarStagePreviewView>
	{
		// Token: 0x060268EE RID: 157934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268EE")]
		[Address(RVA = "0x21B4090", Offset = "0x21B2C90", VA = "0x1821B4090", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x060268EF RID: 157935 RVA: 0x000CBAD8 File Offset: 0x000C9CD8
		[Token(Token = "0x60268EF")]
		[Address(RVA = "0x21B4210", Offset = "0x21B2E10", VA = "0x1821B4210", Slot = "8")]
		protected override bool SelectStageViewModel(ZoneViewModel zoneModel, out StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x060268F0 RID: 157936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60268F0")]
		[Address(RVA = "0x21B4030", Offset = "0x21B2C30", VA = "0x1821B4030", Slot = "9")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060268F1 RID: 157937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268F1")]
		[Address(RVA = "0x21B42F0", Offset = "0x21B2EF0", VA = "0x1821B42F0")]
		public StagePreviewInfoSixStarPanelHolder()
		{
		}

		// Token: 0x0403661C RID: 222748
		[Token(Token = "0x403661C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403661D RID: 222749
		[Token(Token = "0x403661D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectStageViewModel;

		// Token: 0x0403661E RID: 222750
		[Token(Token = "0x403661E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x0403661F RID: 222751
		[Token(Token = "0x403661F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
