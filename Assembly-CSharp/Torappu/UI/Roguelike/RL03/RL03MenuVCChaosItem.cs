using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200583B RID: 22587
	[Token(Token = "0x200583B")]
	public class RL03MenuVCChaosItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021030 RID: 135216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021030")]
		[Address(RVA = "0x1B4B230", Offset = "0x1B49E30", VA = "0x181B4B230")]
		public void Render(RL03MenuVisionAndChaosViewModel.VCWindowViewModel.ChaosItemModel itemModel, ILoadAsset loader, string topicId)
		{
		}

		// Token: 0x06021031 RID: 135217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021031")]
		[Address(RVA = "0x1B4B460", Offset = "0x1B4A060", VA = "0x181B4B460")]
		public RL03MenuVCChaosItem()
		{
		}

		// Token: 0x0402CE4C RID: 183884
		[Token(Token = "0x402CE4C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402CE4D RID: 183885
		[Token(Token = "0x402CE4D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402CE4E RID: 183886
		[Token(Token = "0x402CE4E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402CE4F RID: 183887
		[Token(Token = "0x402CE4F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _levelIcons;

		// Token: 0x0402CE50 RID: 183888
		[Token(Token = "0x402CE50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CE51 RID: 183889
		[Token(Token = "0x402CE51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
