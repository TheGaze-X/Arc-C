using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035E4 RID: 13796
	[Token(Token = "0x20035E4")]
	public class CommonSquadResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x06015F8C RID: 89996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034CA")]
		public CommonCharCardView cardRes
		{
			[Token(Token = "0x6015F8C")]
			[Address(RVA = "0xE77940", Offset = "0xE76540", VA = "0x180E77940")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x06015F8D RID: 89997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034CB")]
		public CommonSquadLayoutViewBase layoutView
		{
			[Token(Token = "0x6015F8D")]
			[Address(RVA = "0xE77A00", Offset = "0xE76600", VA = "0x180E77A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x06015F8E RID: 89998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034CC")]
		public CommonSquadFloatViewBase floatView
		{
			[Token(Token = "0x6015F8E")]
			[Address(RVA = "0xE779A0", Offset = "0xE765A0", VA = "0x180E779A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x06015F8F RID: 89999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034CD")]
		public CommonSquadTopMenuViewBase topMenuView
		{
			[Token(Token = "0x6015F8F")]
			[Address(RVA = "0xE77A60", Offset = "0xE76660", VA = "0x180E77A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015F90 RID: 90000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F90")]
		[Address(RVA = "0xE778E0", Offset = "0xE764E0", VA = "0x180E778E0")]
		public CommonSquadResHolder()
		{
		}

		// Token: 0x0401A65A RID: 108122
		[Token(Token = "0x401A65A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CommonCharCardView _cardRes;

		// Token: 0x0401A65B RID: 108123
		[Token(Token = "0x401A65B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CommonSquadLayoutViewBase _layoutView;

		// Token: 0x0401A65C RID: 108124
		[Token(Token = "0x401A65C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CommonSquadFloatViewBase _floatView;

		// Token: 0x0401A65D RID: 108125
		[Token(Token = "0x401A65D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CommonSquadTopMenuViewBase _topMenuView;

		// Token: 0x0401A65E RID: 108126
		[Token(Token = "0x401A65E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardRes;

		// Token: 0x0401A65F RID: 108127
		[Token(Token = "0x401A65F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_layoutView;

		// Token: 0x0401A660 RID: 108128
		[Token(Token = "0x401A660")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_floatView;

		// Token: 0x0401A661 RID: 108129
		[Token(Token = "0x401A661")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_topMenuView;

		// Token: 0x0401A662 RID: 108130
		[Token(Token = "0x401A662")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
