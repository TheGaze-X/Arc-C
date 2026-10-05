using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055A9 RID: 21929
	[Token(Token = "0x20055A9")]
	public class RL05CopperPackageListGrpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602033F RID: 131903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602033F")]
		[Address(RVA = "0x1A4D150", Offset = "0x1A4BD50", VA = "0x181A4D150")]
		public void Render(ILoadAsset assetLoader, IList<RoguelikePlayerCopperItemViewModel> copperList, int begin, bool isFirst, string selectInstId)
		{
		}

		// Token: 0x06020340 RID: 131904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020340")]
		[Address(RVA = "0x1A4D010", Offset = "0x1A4BC10", VA = "0x181A4D010")]
		public void PlaySelectAnim(string selectInstId)
		{
		}

		// Token: 0x06020341 RID: 131905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020341")]
		[Address(RVA = "0x1A4D560", Offset = "0x1A4C160", VA = "0x181A4D560")]
		public RL05CopperPackageListGrpView()
		{
		}

		// Token: 0x0402B8BA RID: 178362
		[Token(Token = "0x402B8BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] _cellHooks;

		// Token: 0x0402B8BB RID: 178363
		[Token(Token = "0x402B8BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL05CopperPackageItemView _itemViewPrefab;

		// Token: 0x0402B8BC RID: 178364
		[Token(Token = "0x402B8BC")]
		[FieldOffset(Offset = "0x28")]
		private RL05CopperPackageItemView[] m_items;

		// Token: 0x0402B8BD RID: 178365
		[Token(Token = "0x402B8BD")]
		[FieldOffset(Offset = "0x30")]
		public Action<string> onItemClick;

		// Token: 0x0402B8BE RID: 178366
		[Token(Token = "0x402B8BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B8BF RID: 178367
		[Token(Token = "0x402B8BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlaySelectAnim;

		// Token: 0x0402B8C0 RID: 178368
		[Token(Token = "0x402B8C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
