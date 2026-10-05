using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C38 RID: 7224
	[Token(Token = "0x2001C38")]
	public class BuildingTradingNegotiationItem : MonoBehaviour
	{
		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x0600B3C5 RID: 46021 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B3C6 RID: 46022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700158F")]
		public Action<TradingOrderViewType> onItemClicked
		{
			[Token(Token = "0x600B3C5")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600B3C6")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600B3C7 RID: 46023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C7")]
		[Address(RVA = "0x32D6A90", Offset = "0x32D5690", VA = "0x1832D6A90")]
		public void Render(TradingOrderViewType type)
		{
		}

		// Token: 0x0600B3C8 RID: 46024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C8")]
		[Address(RVA = "0x32D6A70", Offset = "0x32D5670", VA = "0x1832D6A70")]
		public void EventOnItemClicked()
		{
		}

		// Token: 0x0600B3C9 RID: 46025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C9")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingTradingNegotiationItem()
		{
		}

		// Token: 0x0400AF47 RID: 44871
		[Token(Token = "0x400AF47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TradingOrderViewType _type;

		// Token: 0x0400AF48 RID: 44872
		[Token(Token = "0x400AF48")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _selectedObjs;

		// Token: 0x0400AF49 RID: 44873
		[Token(Token = "0x400AF49")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _unselectedObjs;

		// Token: 0x0400AF4A RID: 44874
		[Token(Token = "0x400AF4A")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0400AF4B RID: 44875
		[Token(Token = "0x400AF4B")]
		[FieldOffset(Offset = "0x31")]
		private bool m_isSelected;
	}
}
