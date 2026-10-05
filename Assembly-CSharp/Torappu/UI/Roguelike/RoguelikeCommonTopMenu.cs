using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051CD RID: 20941
	[Token(Token = "0x20051CD")]
	public class RoguelikeCommonTopMenu : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004833 RID: 18483
		// (get) Token: 0x0601EEDB RID: 126683 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EEDC RID: 126684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004833")]
		public Action onBackClicked
		{
			[Token(Token = "0x601EEDB")]
			[Address(RVA = "0x18B08D0", Offset = "0x18AF4D0", VA = "0x1818B08D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EEDC")]
			[Address(RVA = "0x18B0B70", Offset = "0x18AF770", VA = "0x1818B0B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004834 RID: 18484
		// (get) Token: 0x0601EEDD RID: 126685 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EEDE RID: 126686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004834")]
		public Action onInfoClicked
		{
			[Token(Token = "0x601EEDD")]
			[Address(RVA = "0x18B0930", Offset = "0x18AF530", VA = "0x1818B0930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EEDE")]
			[Address(RVA = "0x18B0BF0", Offset = "0x18AF7F0", VA = "0x1818B0BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004835 RID: 18485
		// (get) Token: 0x0601EEDF RID: 126687 RVA: 0x000B0298 File Offset: 0x000AE498
		// (set) Token: 0x0601EEE0 RID: 126688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004835")]
		public bool isShowBackButton
		{
			[Token(Token = "0x601EEDF")]
			[Address(RVA = "0x18B07B0", Offset = "0x18AF3B0", VA = "0x1818B07B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601EEE0")]
			[Address(RVA = "0x18B0990", Offset = "0x18AF590", VA = "0x1818B0990")]
			set
			{
			}
		}

		// Token: 0x17004836 RID: 18486
		// (get) Token: 0x0601EEE1 RID: 126689 RVA: 0x000B02B0 File Offset: 0x000AE4B0
		// (set) Token: 0x0601EEE2 RID: 126690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004836")]
		public bool isShowReturnButton
		{
			[Token(Token = "0x601EEE1")]
			[Address(RVA = "0x18B0870", Offset = "0x18AF470", VA = "0x1818B0870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601EEE2")]
			[Address(RVA = "0x18B0AD0", Offset = "0x18AF6D0", VA = "0x1818B0AD0")]
			set
			{
			}
		}

		// Token: 0x17004837 RID: 18487
		// (get) Token: 0x0601EEE3 RID: 126691 RVA: 0x000B02C8 File Offset: 0x000AE4C8
		// (set) Token: 0x0601EEE4 RID: 126692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004837")]
		public bool isShowInfoButton
		{
			[Token(Token = "0x601EEE3")]
			[Address(RVA = "0x18B0810", Offset = "0x18AF410", VA = "0x1818B0810")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601EEE4")]
			[Address(RVA = "0x18B0A30", Offset = "0x18AF630", VA = "0x1818B0A30")]
			set
			{
			}
		}

		// Token: 0x0601EEE5 RID: 126693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEE5")]
		[Address(RVA = "0x18B0450", Offset = "0x18AF050", VA = "0x1818B0450")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601EEE6 RID: 126694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEE6")]
		[Address(RVA = "0x18B0560", Offset = "0x18AF160", VA = "0x1818B0560")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x0601EEE7 RID: 126695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEE7")]
		[Address(RVA = "0x18B0630", Offset = "0x18AF230", VA = "0x1818B0630")]
		public void EventOnInfoClicked()
		{
		}

		// Token: 0x0601EEE8 RID: 126696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEE8")]
		[Address(RVA = "0x18B0740", Offset = "0x18AF340", VA = "0x1818B0740")]
		public RoguelikeCommonTopMenu()
		{
		}

		// Token: 0x040297FE RID: 169982
		[Token(Token = "0x40297FE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _backButton;

		// Token: 0x040297FF RID: 169983
		[Token(Token = "0x40297FF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _returnButton;

		// Token: 0x04029800 RID: 169984
		[Token(Token = "0x4029800")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _infoButton;

		// Token: 0x04029801 RID: 169985
		[Token(Token = "0x4029801")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isShowBackButton;

		// Token: 0x04029802 RID: 169986
		[Token(Token = "0x4029802")]
		[FieldOffset(Offset = "0x31")]
		private bool m_isShowReturnButton;

		// Token: 0x04029803 RID: 169987
		[Token(Token = "0x4029803")]
		[FieldOffset(Offset = "0x32")]
		private bool m_isShowInfoButton;

		// Token: 0x04029806 RID: 169990
		[Token(Token = "0x4029806")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBackClicked;

		// Token: 0x04029807 RID: 169991
		[Token(Token = "0x4029807")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBackClicked;

		// Token: 0x04029808 RID: 169992
		[Token(Token = "0x4029808")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onInfoClicked;

		// Token: 0x04029809 RID: 169993
		[Token(Token = "0x4029809")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onInfoClicked;

		// Token: 0x0402980A RID: 169994
		[Token(Token = "0x402980A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isShowBackButton;

		// Token: 0x0402980B RID: 169995
		[Token(Token = "0x402980B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isShowBackButton;

		// Token: 0x0402980C RID: 169996
		[Token(Token = "0x402980C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isShowReturnButton;

		// Token: 0x0402980D RID: 169997
		[Token(Token = "0x402980D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isShowReturnButton;

		// Token: 0x0402980E RID: 169998
		[Token(Token = "0x402980E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isShowInfoButton;

		// Token: 0x0402980F RID: 169999
		[Token(Token = "0x402980F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isShowInfoButton;

		// Token: 0x04029810 RID: 170000
		[Token(Token = "0x4029810")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04029811 RID: 170001
		[Token(Token = "0x4029811")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x04029812 RID: 170002
		[Token(Token = "0x4029812")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnInfoClicked;

		// Token: 0x04029813 RID: 170003
		[Token(Token = "0x4029813")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
