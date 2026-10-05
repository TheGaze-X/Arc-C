using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004994 RID: 18836
	[Token(Token = "0x2004994")]
	public class MedalBarListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C61E RID: 116254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C61E")]
		[Address(RVA = "0x15E7F80", Offset = "0x15E6B80", VA = "0x1815E7F80")]
		private void _InitCount(int count)
		{
		}

		// Token: 0x0601C61F RID: 116255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C61F")]
		[Address(RVA = "0x15E77A0", Offset = "0x15E63A0", VA = "0x1815E77A0")]
		public void OnSetValue(int value)
		{
		}

		// Token: 0x0601C620 RID: 116256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C620")]
		[Address(RVA = "0x15E7950", Offset = "0x15E6550", VA = "0x1815E7950")]
		public void Render(MedalListViewModel listViewModel)
		{
		}

		// Token: 0x0601C621 RID: 116257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C621")]
		[Address(RVA = "0x15E7D90", Offset = "0x15E6990", VA = "0x1815E7D90")]
		public void SwitchProgressDisplay(bool showDetails)
		{
		}

		// Token: 0x0601C622 RID: 116258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C622")]
		[Address(RVA = "0x15E7C40", Offset = "0x15E6840", VA = "0x1815E7C40")]
		public void StopProgressAnim()
		{
		}

		// Token: 0x0601C623 RID: 116259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C623")]
		[Address(RVA = "0x15E7AF0", Offset = "0x15E66F0", VA = "0x1815E7AF0")]
		public void ResetProgressAnim()
		{
		}

		// Token: 0x0601C624 RID: 116260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C624")]
		[Address(RVA = "0x15E8150", Offset = "0x15E6D50", VA = "0x1815E8150")]
		public MedalBarListView()
		{
		}

		// Token: 0x040252BB RID: 152251
		[Token(Token = "0x40252BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MedalBarListItem _listItem;

		// Token: 0x040252BC RID: 152252
		[Token(Token = "0x40252BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040252BD RID: 152253
		[Token(Token = "0x40252BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStringEvent _onClickEvent;

		// Token: 0x040252BE RID: 152254
		[Token(Token = "0x40252BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _showCountFlag;

		// Token: 0x040252BF RID: 152255
		[Token(Token = "0x40252BF")]
		[FieldOffset(Offset = "0x34")]
		private int countCache;

		// Token: 0x040252C0 RID: 152256
		[Token(Token = "0x40252C0")]
		[NonSerialized]
		public const float ITEM_HEIGHT = 55.04f;

		// Token: 0x040252C1 RID: 152257
		[Token(Token = "0x40252C1")]
		[FieldOffset(Offset = "0x38")]
		private List<MedalBarListItem> m_listItem;

		// Token: 0x040252C2 RID: 152258
		[Token(Token = "0x40252C2")]
		[FieldOffset(Offset = "0x40")]
		private float m_maxHeight;

		// Token: 0x040252C3 RID: 152259
		[Token(Token = "0x40252C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitCount;

		// Token: 0x040252C4 RID: 152260
		[Token(Token = "0x40252C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSetValue;

		// Token: 0x040252C5 RID: 152261
		[Token(Token = "0x40252C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040252C6 RID: 152262
		[Token(Token = "0x40252C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SwitchProgressDisplay;

		// Token: 0x040252C7 RID: 152263
		[Token(Token = "0x40252C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StopProgressAnim;

		// Token: 0x040252C8 RID: 152264
		[Token(Token = "0x40252C8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetProgressAnim;

		// Token: 0x040252C9 RID: 152265
		[Token(Token = "0x40252C9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
