using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200609A RID: 24730
	[Token(Token = "0x200609A")]
	public class CarvingInputMaterialModel : IHotfixable
	{
		// Token: 0x17005492 RID: 21650
		// (get) Token: 0x06023C8B RID: 146571 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023C8C RID: 146572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005492")]
		public List<CarvingMaterialModel> inputMaterials
		{
			[Token(Token = "0x6023C8B")]
			[Address(RVA = "0x1E78E80", Offset = "0x1E77A80", VA = "0x181E78E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023C8C")]
			[Address(RVA = "0x1E78EE0", Offset = "0x1E77AE0", VA = "0x181E78EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06023C8D RID: 146573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C8D")]
		[Address(RVA = "0x1E78990", Offset = "0x1E77590", VA = "0x181E78990")]
		public void LoadData(PlayerActivity.PlayerAct35SideActivity.PlayerAct35SideCarving carving, Act35SideData actData)
		{
		}

		// Token: 0x06023C8E RID: 146574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C8E")]
		[Address(RVA = "0x1E78E20", Offset = "0x1E77A20", VA = "0x181E78E20")]
		public CarvingInputMaterialModel()
		{
		}

		// Token: 0x040319D2 RID: 203218
		[Token(Token = "0x40319D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inputMaterials;

		// Token: 0x040319D3 RID: 203219
		[Token(Token = "0x40319D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_inputMaterials;

		// Token: 0x040319D4 RID: 203220
		[Token(Token = "0x40319D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040319D5 RID: 203221
		[Token(Token = "0x40319D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
