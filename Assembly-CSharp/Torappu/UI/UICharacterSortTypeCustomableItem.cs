using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200354D RID: 13645
	[Token(Token = "0x200354D")]
	[RequireComponent(typeof(ThreeStateToggle))]
	public class UICharacterSortTypeCustomableItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015BE6 RID: 89062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BE6")]
		[Address(RVA = "0xE54FC0", Offset = "0xE53BC0", VA = "0x180E54FC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x06015BE7 RID: 89063 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015BE8 RID: 89064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033A4")]
		public Action<CharacterSortType> onSortTypeChanged
		{
			[Token(Token = "0x6015BE7")]
			[Address(RVA = "0xE55610", Offset = "0xE54210", VA = "0x180E55610")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6015BE8")]
			[Address(RVA = "0xE556F0", Offset = "0xE542F0", VA = "0x180E556F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x06015BE9 RID: 89065 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015BEA RID: 89066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033A5")]
		public Action onOpenCustomSortPanel
		{
			[Token(Token = "0x6015BE9")]
			[Address(RVA = "0xE555B0", Offset = "0xE541B0", VA = "0x180E555B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6015BEA")]
			[Address(RVA = "0xE55670", Offset = "0xE54270", VA = "0x180E55670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06015BEB RID: 89067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BEB")]
		[Address(RVA = "0xE550C0", Offset = "0xE53CC0", VA = "0x180E550C0")]
		private void _NotifySortTypeChanged(CharacterSortType sortType)
		{
		}

		// Token: 0x06015BEC RID: 89068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BEC")]
		[Address(RVA = "0xE55190", Offset = "0xE53D90", VA = "0x180E55190")]
		public void _OnToggleClick(ThreeStateToggle.State state)
		{
		}

		// Token: 0x06015BED RID: 89069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BED")]
		[Address(RVA = "0xE54DB0", Offset = "0xE539B0", VA = "0x180E54DB0")]
		public void SetCustomSortType(CharacterCardSortTypeViewModel viewModel)
		{
		}

		// Token: 0x06015BEE RID: 89070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BEE")]
		[Address(RVA = "0xE55370", Offset = "0xE53F70", VA = "0x180E55370")]
		private void _RenderCustomSortType(CharacterCardSortTypeViewModel viewModel)
		{
		}

		// Token: 0x06015BEF RID: 89071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BEF")]
		[Address(RVA = "0xE55550", Offset = "0xE54150", VA = "0x180E55550")]
		public UICharacterSortTypeCustomableItem()
		{
		}

		// Token: 0x0401A225 RID: 107045
		[Token(Token = "0x401A225")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text[] _sortTypeTexts;

		// Token: 0x0401A226 RID: 107046
		[Token(Token = "0x401A226")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("sort type when first clicked")]
		private CharacterSortType _firstSortType;

		// Token: 0x0401A227 RID: 107047
		[Token(Token = "0x401A227")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("sort type when clicked again")]
		private CharacterSortType _secondSortType;

		// Token: 0x0401A228 RID: 107048
		[Token(Token = "0x401A228")]
		[FieldOffset(Offset = "0x28")]
		private ThreeStateToggle m_toggle;

		// Token: 0x0401A229 RID: 107049
		[Token(Token = "0x401A229")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401A22A RID: 107050
		[Token(Token = "0x401A22A")]
		[FieldOffset(Offset = "0x31")]
		private bool m_customSortTypeSet;

		// Token: 0x0401A22D RID: 107053
		[Token(Token = "0x401A22D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A22E RID: 107054
		[Token(Token = "0x401A22E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onSortTypeChanged;

		// Token: 0x0401A22F RID: 107055
		[Token(Token = "0x401A22F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onSortTypeChanged;

		// Token: 0x0401A230 RID: 107056
		[Token(Token = "0x401A230")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onOpenCustomSortPanel;

		// Token: 0x0401A231 RID: 107057
		[Token(Token = "0x401A231")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onOpenCustomSortPanel;

		// Token: 0x0401A232 RID: 107058
		[Token(Token = "0x401A232")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__NotifySortTypeChanged;

		// Token: 0x0401A233 RID: 107059
		[Token(Token = "0x401A233")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnToggleClick;

		// Token: 0x0401A234 RID: 107060
		[Token(Token = "0x401A234")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetCustomSortType;

		// Token: 0x0401A235 RID: 107061
		[Token(Token = "0x401A235")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderCustomSortType;

		// Token: 0x0401A236 RID: 107062
		[Token(Token = "0x401A236")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
