using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006928 RID: 26920
	[Token(Token = "0x2006928")]
	public class StagePreviewInfoNormalPanelHolder : StagePreviewDynHolder<StagePreviewNormalView>
	{
		// Token: 0x060268EA RID: 157930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60268EA")]
		[Address(RVA = "0x21B3D10", Offset = "0x21B2910", VA = "0x1821B3D10", Slot = "9")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060268EB RID: 157931 RVA: 0x000CBAC0 File Offset: 0x000C9CC0
		[Token(Token = "0x60268EB")]
		[Address(RVA = "0x21B3EF0", Offset = "0x21B2AF0", VA = "0x1821B3EF0", Slot = "8")]
		protected override bool SelectStageViewModel(ZoneViewModel zoneModel, out StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x060268EC RID: 157932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268EC")]
		[Address(RVA = "0x21B3D70", Offset = "0x21B2970", VA = "0x1821B3D70", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x060268ED RID: 157933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268ED")]
		[Address(RVA = "0x21B3FC0", Offset = "0x21B2BC0", VA = "0x1821B3FC0")]
		public StagePreviewInfoNormalPanelHolder()
		{
		}

		// Token: 0x04036618 RID: 222744
		[Token(Token = "0x4036618")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x04036619 RID: 222745
		[Token(Token = "0x4036619")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectStageViewModel;

		// Token: 0x0403661A RID: 222746
		[Token(Token = "0x403661A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403661B RID: 222747
		[Token(Token = "0x403661B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
