using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003479 RID: 13433
	[Token(Token = "0x2003479")]
	public class BuildingBuffedValueView : MonoBehaviour
	{
		// Token: 0x1700329F RID: 12959
		// (set) Token: 0x060156F6 RID: 87798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700329F")]
		public Color bkgColor
		{
			[Token(Token = "0x60156F6")]
			[Address(RVA = "0xDE6830", Offset = "0xDE5430", VA = "0x180DE6830")]
			set
			{
			}
		}

		// Token: 0x170032A0 RID: 12960
		// (set) Token: 0x060156F7 RID: 87799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170032A0")]
		public Color textColor
		{
			[Token(Token = "0x60156F7")]
			[Address(RVA = "0xDE6890", Offset = "0xDE5490", VA = "0x180DE6890")]
			set
			{
			}
		}

		// Token: 0x060156F8 RID: 87800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156F8")]
		[Address(RVA = "0xDE67E0", Offset = "0xDE53E0", VA = "0x180DE67E0")]
		public void Render(string text)
		{
		}

		// Token: 0x060156F9 RID: 87801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156F9")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingBuffedValueView()
		{
		}

		// Token: 0x04019AA0 RID: 105120
		[Token(Token = "0x4019AA0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04019AA1 RID: 105121
		[Token(Token = "0x4019AA1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _text;

		// Token: 0x0200347A RID: 13434
		[Token(Token = "0x200347A")]
		public struct BuffedValue
		{
			// Token: 0x04019AA2 RID: 105122
			[Token(Token = "0x4019AA2")]
			[FieldOffset(Offset = "0x0")]
			public string content;

			// Token: 0x04019AA3 RID: 105123
			[Token(Token = "0x4019AA3")]
			[FieldOffset(Offset = "0x8")]
			public Color bkgColor;

			// Token: 0x04019AA4 RID: 105124
			[Token(Token = "0x4019AA4")]
			[FieldOffset(Offset = "0x18")]
			public Color textColor;
		}

		// Token: 0x0200347B RID: 13435
		[Token(Token = "0x200347B")]
		public class ListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060156FA RID: 87802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60156FA")]
			[Address(RVA = "0xDEA920", Offset = "0xDE9520", VA = "0x180DEA920", Slot = "8")]
			public sealed override void NotifyDataSetChanged()
			{
			}

			// Token: 0x060156FB RID: 87803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60156FB")]
			[Address(RVA = "0xDEAC80", Offset = "0xDE9880", VA = "0x180DEAC80")]
			public void StartChange()
			{
			}

			// Token: 0x060156FC RID: 87804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60156FC")]
			[Address(RVA = "0xDEA760", Offset = "0xDE9360", VA = "0x180DEA760")]
			public void Add(BuildingBuffedValueView.BuffedValue content)
			{
			}

			// Token: 0x060156FD RID: 87805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60156FD")]
			[Address(RVA = "0xDEA8B0", Offset = "0xDE94B0", VA = "0x180DEA8B0")]
			public void CommitChange()
			{
			}

			// Token: 0x170032A1 RID: 12961
			// (get) Token: 0x060156FE RID: 87806 RVA: 0x0008BED8 File Offset: 0x0008A0D8
			[Token(Token = "0x170032A1")]
			public override int count
			{
				[Token(Token = "0x60156FE")]
				[Address(RVA = "0xDEADE0", Offset = "0xDE99E0", VA = "0x180DEADE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060156FF RID: 87807 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60156FF")]
			[Address(RVA = "0xDEA980", Offset = "0xDE9580", VA = "0x180DEA980", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06015700 RID: 87808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015700")]
			[Address(RVA = "0xDEAD30", Offset = "0xDE9930", VA = "0x180DEAD30")]
			public ListAdapter()
			{
			}

			// Token: 0x06015701 RID: 87809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015701")]
			[Address(RVA = "0xDEAD20", Offset = "0xDE9920", VA = "0x180DEAD20")]
			private void <>xLuaBaseProxy_NotifyDataSetChanged()
			{
			}

			// Token: 0x04019AA5 RID: 105125
			[Token(Token = "0x4019AA5")]
			[FieldOffset(Offset = "0x20")]
			private List<BuildingBuffedValueView.BuffedValue> m_contentList;

			// Token: 0x04019AA6 RID: 105126
			[Token(Token = "0x4019AA6")]
			[FieldOffset(Offset = "0x28")]
			private bool m_isChanging;

			// Token: 0x04019AA7 RID: 105127
			[Token(Token = "0x4019AA7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NotifyDataSetChanged;

			// Token: 0x04019AA8 RID: 105128
			[Token(Token = "0x4019AA8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_StartChange;

			// Token: 0x04019AA9 RID: 105129
			[Token(Token = "0x4019AA9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Add;

			// Token: 0x04019AAA RID: 105130
			[Token(Token = "0x4019AAA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CommitChange;

			// Token: 0x04019AAB RID: 105131
			[Token(Token = "0x4019AAB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04019AAC RID: 105132
			[Token(Token = "0x4019AAC")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04019AAD RID: 105133
			[Token(Token = "0x4019AAD")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
