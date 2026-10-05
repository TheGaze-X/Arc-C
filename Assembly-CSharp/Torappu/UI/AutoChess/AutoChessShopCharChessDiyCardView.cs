using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200635D RID: 25437
	[Token(Token = "0x200635D")]
	public class AutoChessShopCharChessDiyCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170056A5 RID: 22181
		// (get) Token: 0x06024B28 RID: 150312 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024B29 RID: 150313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056A5")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x6024B28")]
			[Address(RVA = "0x1F828A0", Offset = "0x1F814A0", VA = "0x181F828A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024B29")]
			[Address(RVA = "0x1F82900", Offset = "0x1F81500", VA = "0x181F82900")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024B2A RID: 150314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B2A")]
		[Address(RVA = "0x1F826A0", Offset = "0x1F812A0", VA = "0x181F826A0")]
		public void Render(AutoChessShopCharChessDiyCardViewModel diyCardViewModel)
		{
		}

		// Token: 0x06024B2B RID: 150315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B2B")]
		[Address(RVA = "0x1F82590", Offset = "0x1F81190", VA = "0x181F82590")]
		public void OnItemCardClick()
		{
		}

		// Token: 0x06024B2C RID: 150316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B2C")]
		[Address(RVA = "0x1F82810", Offset = "0x1F81410", VA = "0x181F82810")]
		public AutoChessShopCharChessDiyCardView()
		{
		}

		// Token: 0x040333C4 RID: 209860
		[Token(Token = "0x40333C4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _diyCountInfo;

		// Token: 0x040333C5 RID: 209861
		[Token(Token = "0x40333C5")]
		[FieldOffset(Offset = "0x20")]
		private string m_cachedChessSlotId;

		// Token: 0x040333C7 RID: 209863
		[Token(Token = "0x40333C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x040333C8 RID: 209864
		[Token(Token = "0x40333C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x040333C9 RID: 209865
		[Token(Token = "0x40333C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040333CA RID: 209866
		[Token(Token = "0x40333CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemCardClick;

		// Token: 0x040333CB RID: 209867
		[Token(Token = "0x40333CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
