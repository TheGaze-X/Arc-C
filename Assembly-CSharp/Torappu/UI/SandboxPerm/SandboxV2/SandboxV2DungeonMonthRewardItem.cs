using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041C7 RID: 16839
	[Token(Token = "0x20041C7")]
	public class SandboxV2DungeonMonthRewardItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019F54 RID: 106324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F54")]
		[Address(RVA = "0x12DB9A0", Offset = "0x12DA5A0", VA = "0x1812DB9A0")]
		public void Render(SandboxV2DungeonMonthRewardItem.Param renderParam)
		{
		}

		// Token: 0x06019F55 RID: 106325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F55")]
		[Address(RVA = "0x12DBC80", Offset = "0x12DA880", VA = "0x1812DBC80")]
		public SandboxV2DungeonMonthRewardItem()
		{
		}

		// Token: 0x04020B1F RID: 133919
		[Token(Token = "0x4020B1F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x04020B20 RID: 133920
		[Token(Token = "0x4020B20")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelCoinTimeNode;

		// Token: 0x04020B21 RID: 133921
		[Token(Token = "0x4020B21")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtCoinTime;

		// Token: 0x04020B22 RID: 133922
		[Token(Token = "0x4020B22")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04020B23 RID: 133923
		[Token(Token = "0x4020B23")]
		[FieldOffset(Offset = "0x38")]
		private UIItemCard m_itemCard;

		// Token: 0x04020B24 RID: 133924
		[Token(Token = "0x4020B24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020B25 RID: 133925
		[Token(Token = "0x4020B25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041C8 RID: 16840
		[Token(Token = "0x20041C8")]
		public struct Param
		{
			// Token: 0x04020B26 RID: 133926
			[Token(Token = "0x4020B26")]
			[FieldOffset(Offset = "0x0")]
			public UIItemViewModel itemViewModel;

			// Token: 0x04020B27 RID: 133927
			[Token(Token = "0x4020B27")]
			[FieldOffset(Offset = "0x8")]
			public string timeStr;

			// Token: 0x04020B28 RID: 133928
			[Token(Token = "0x4020B28")]
			[FieldOffset(Offset = "0x10")]
			public bool showCoinTime;
		}
	}
}
