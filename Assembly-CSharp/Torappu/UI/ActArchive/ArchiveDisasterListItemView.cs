using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B63 RID: 27491
	[Token(Token = "0x2006B63")]
	public class ArchiveDisasterListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005CD4 RID: 23764
		// (get) Token: 0x06027483 RID: 160899 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027484 RID: 160900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CD4")]
		public ArchiveDisasterController controller
		{
			[Token(Token = "0x6027483")]
			[Address(RVA = "0x227AB20", Offset = "0x2279720", VA = "0x18227AB20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027484")]
			[Address(RVA = "0x227AB90", Offset = "0x2279790", VA = "0x18227AB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027485 RID: 160901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027485")]
		[Address(RVA = "0x227A490", Offset = "0x2279090", VA = "0x18227A490")]
		public void ItemClickEvent()
		{
		}

		// Token: 0x06027486 RID: 160902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027486")]
		[Address(RVA = "0x227A590", Offset = "0x2279190", VA = "0x18227A590")]
		public void Render(DisasterTypeModel typeModel, string selectedTypeId, bool showSwitchAnim)
		{
		}

		// Token: 0x06027487 RID: 160903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027487")]
		[Address(RVA = "0x227A910", Offset = "0x2279510", VA = "0x18227A910")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027488 RID: 160904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027488")]
		[Address(RVA = "0x227AAA0", Offset = "0x22796A0", VA = "0x18227AAA0")]
		public ArchiveDisasterListItemView()
		{
		}

		// Token: 0x040379D7 RID: 227799
		[Token(Token = "0x40379D7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color ATTAINED_COLOR;

		// Token: 0x040379D8 RID: 227800
		[Token(Token = "0x40379D8")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color UNATTAINED_COLOR;

		// Token: 0x040379D9 RID: 227801
		[Token(Token = "0x40379D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x040379DA RID: 227802
		[Token(Token = "0x40379DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _selectedGroup;

		// Token: 0x040379DB RID: 227803
		[Token(Token = "0x40379DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _newPanel;

		// Token: 0x040379DC RID: 227804
		[Token(Token = "0x40379DC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _button;

		// Token: 0x040379DD RID: 227805
		[Token(Token = "0x40379DD")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x040379DE RID: 227806
		[Token(Token = "0x40379DE")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween m_switchTween;

		// Token: 0x040379DF RID: 227807
		[Token(Token = "0x40379DF")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedDisasterTypeId;

		// Token: 0x040379E1 RID: 227809
		[Token(Token = "0x40379E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040379E2 RID: 227810
		[Token(Token = "0x40379E2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040379E3 RID: 227811
		[Token(Token = "0x40379E3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ItemClickEvent;

		// Token: 0x040379E4 RID: 227812
		[Token(Token = "0x40379E4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040379E5 RID: 227813
		[Token(Token = "0x40379E5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040379E6 RID: 227814
		[Token(Token = "0x40379E6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B64 RID: 27492
		[Token(Token = "0x2006B64")]
		private class ArchiveDisasterListItemSwitchTween : UISwitchTween
		{
			// Token: 0x0602748A RID: 160906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602748A")]
			[Address(RVA = "0x227A410", Offset = "0x2279010", VA = "0x18227A410")]
			public ArchiveDisasterListItemSwitchTween(ArchiveDisasterListItemView closure)
			{
			}

			// Token: 0x0602748B RID: 160907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602748B")]
			[Address(RVA = "0x227A0C0", Offset = "0x2278CC0", VA = "0x18227A0C0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602748C RID: 160908 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602748C")]
			[Address(RVA = "0x227A1E0", Offset = "0x2278DE0", VA = "0x18227A1E0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602748D RID: 160909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602748D")]
			[Address(RVA = "0x227A330", Offset = "0x2278F30", VA = "0x18227A330", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602748E RID: 160910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602748E")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040379E7 RID: 227815
			[Token(Token = "0x40379E7")]
			[FieldOffset(Offset = "0x48")]
			private ArchiveDisasterListItemView m_closure;

			// Token: 0x040379E8 RID: 227816
			[Token(Token = "0x40379E8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040379E9 RID: 227817
			[Token(Token = "0x40379E9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040379EA RID: 227818
			[Token(Token = "0x40379EA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040379EB RID: 227819
			[Token(Token = "0x40379EB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
