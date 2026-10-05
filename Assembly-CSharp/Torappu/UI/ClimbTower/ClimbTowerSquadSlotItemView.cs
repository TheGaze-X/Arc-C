using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D63 RID: 23907
	[Token(Token = "0x2005D63")]
	public class ClimbTowerSquadSlotItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170051A2 RID: 20898
		// (get) Token: 0x06022A2A RID: 141866 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A2B RID: 141867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051A2")]
		public Action<int> onCardClick
		{
			[Token(Token = "0x6022A2A")]
			[Address(RVA = "0x1D2BAC0", Offset = "0x1D2A6C0", VA = "0x181D2BAC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022A2B")]
			[Address(RVA = "0x1D2BBE0", Offset = "0x1D2A7E0", VA = "0x181D2BBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170051A3 RID: 20899
		// (get) Token: 0x06022A2C RID: 141868 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A2D RID: 141869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051A3")]
		public Action<int> onClearAssistClick
		{
			[Token(Token = "0x6022A2C")]
			[Address(RVA = "0x1D2BB20", Offset = "0x1D2A720", VA = "0x181D2BB20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022A2D")]
			[Address(RVA = "0x1D2BC60", Offset = "0x1D2A860", VA = "0x181D2BC60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170051A4 RID: 20900
		// (get) Token: 0x06022A2E RID: 141870 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A2F RID: 141871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051A4")]
		public Action<int> onGetAssistClick
		{
			[Token(Token = "0x6022A2E")]
			[Address(RVA = "0x1D2BB80", Offset = "0x1D2A780", VA = "0x181D2BB80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022A2F")]
			[Address(RVA = "0x1D2BCE0", Offset = "0x1D2A8E0", VA = "0x181D2BCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022A30 RID: 141872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A30")]
		[Address(RVA = "0x1D2B650", Offset = "0x1D2A250", VA = "0x181D2B650")]
		public void Render(int position, CharacterCardViewModel cardViewModel, bool isAssist)
		{
		}

		// Token: 0x06022A31 RID: 141873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A31")]
		[Address(RVA = "0x1D2B980", Offset = "0x1D2A580", VA = "0x181D2B980")]
		private void _OnItemClick()
		{
		}

		// Token: 0x06022A32 RID: 141874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A32")]
		[Address(RVA = "0x1D2B560", Offset = "0x1D2A160", VA = "0x181D2B560")]
		public void OnEmptyClick()
		{
		}

		// Token: 0x06022A33 RID: 141875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A33")]
		[Address(RVA = "0x1D2B5C0", Offset = "0x1D2A1C0", VA = "0x181D2B5C0")]
		public void OnReplaceAssistClick()
		{
		}

		// Token: 0x06022A34 RID: 141876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A34")]
		[Address(RVA = "0x1D2B4D0", Offset = "0x1D2A0D0", VA = "0x181D2B4D0")]
		public void OnClearAssistClick()
		{
		}

		// Token: 0x06022A35 RID: 141877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A35")]
		[Address(RVA = "0x1D2BA50", Offset = "0x1D2A650", VA = "0x181D2BA50")]
		public ClimbTowerSquadSlotItemView()
		{
		}

		// Token: 0x0402F99E RID: 194974
		[Token(Token = "0x402F99E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _charPanelGo;

		// Token: 0x0402F99F RID: 194975
		[Token(Token = "0x402F99F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyPanelGo;

		// Token: 0x0402F9A0 RID: 194976
		[Token(Token = "0x402F9A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _displayPanelGo;

		// Token: 0x0402F9A1 RID: 194977
		[Token(Token = "0x402F9A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _assistPanelGo;

		// Token: 0x0402F9A2 RID: 194978
		[Token(Token = "0x402F9A2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x0402F9A3 RID: 194979
		[Token(Token = "0x402F9A3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _charCardScale;

		// Token: 0x0402F9A7 RID: 194983
		[Token(Token = "0x402F9A7")]
		[FieldOffset(Offset = "0x60")]
		private int m_index;

		// Token: 0x0402F9A8 RID: 194984
		[Token(Token = "0x402F9A8")]
		[FieldOffset(Offset = "0x64")]
		private bool m_isEmpty;

		// Token: 0x0402F9A9 RID: 194985
		[Token(Token = "0x402F9A9")]
		[FieldOffset(Offset = "0x65")]
		private bool m_isAssist;

		// Token: 0x0402F9AA RID: 194986
		[Token(Token = "0x402F9AA")]
		[FieldOffset(Offset = "0x68")]
		private UICharacterCardPanel m_characterCard;

		// Token: 0x0402F9AB RID: 194987
		[Token(Token = "0x402F9AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCardClick;

		// Token: 0x0402F9AC RID: 194988
		[Token(Token = "0x402F9AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCardClick;

		// Token: 0x0402F9AD RID: 194989
		[Token(Token = "0x402F9AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onClearAssistClick;

		// Token: 0x0402F9AE RID: 194990
		[Token(Token = "0x402F9AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onClearAssistClick;

		// Token: 0x0402F9AF RID: 194991
		[Token(Token = "0x402F9AF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onGetAssistClick;

		// Token: 0x0402F9B0 RID: 194992
		[Token(Token = "0x402F9B0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onGetAssistClick;

		// Token: 0x0402F9B1 RID: 194993
		[Token(Token = "0x402F9B1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F9B2 RID: 194994
		[Token(Token = "0x402F9B2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x0402F9B3 RID: 194995
		[Token(Token = "0x402F9B3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnEmptyClick;

		// Token: 0x0402F9B4 RID: 194996
		[Token(Token = "0x402F9B4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnReplaceAssistClick;

		// Token: 0x0402F9B5 RID: 194997
		[Token(Token = "0x402F9B5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClearAssistClick;

		// Token: 0x0402F9B6 RID: 194998
		[Token(Token = "0x402F9B6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
