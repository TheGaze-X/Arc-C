using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200605D RID: 24669
	[Token(Token = "0x200605D")]
	public class CarvingMainCardTransferView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023AB3 RID: 146099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AB3")]
		[Address(RVA = "0x1E4C720", Offset = "0x1E4B320", VA = "0x181E4C720")]
		public void Render(List<CarvingMainCardMaterialViewModel> inputMaterials, List<CarvingMainCardMaterialViewModel> outputMaterials)
		{
		}

		// Token: 0x06023AB4 RID: 146100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AB4")]
		[Address(RVA = "0x1E4C860", Offset = "0x1E4B460", VA = "0x181E4C860")]
		private void _RenderSlots(List<CarvingMainCardMaterialViewModel> matList, List<CarvingMainCardMaterialItemView> slots)
		{
		}

		// Token: 0x06023AB5 RID: 146101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AB5")]
		[Address(RVA = "0x1E4C9D0", Offset = "0x1E4B5D0", VA = "0x181E4C9D0")]
		public CarvingMainCardTransferView()
		{
		}

		// Token: 0x040316B5 RID: 202421
		[Token(Token = "0x40316B5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CarvingMainCardMaterialItemView> _inputSlots;

		// Token: 0x040316B6 RID: 202422
		[Token(Token = "0x40316B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<CarvingMainCardMaterialItemView> _outputSlots;

		// Token: 0x040316B7 RID: 202423
		[Token(Token = "0x40316B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040316B8 RID: 202424
		[Token(Token = "0x40316B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderSlots;

		// Token: 0x040316B9 RID: 202425
		[Token(Token = "0x40316B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
