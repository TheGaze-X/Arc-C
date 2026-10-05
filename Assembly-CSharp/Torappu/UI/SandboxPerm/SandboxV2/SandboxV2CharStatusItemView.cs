using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004425 RID: 17445
	[Token(Token = "0x2004425")]
	public class SandboxV2CharStatusItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x0601AA50 RID: 109136 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA51 RID: 109137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F26")]
		public Action<SandboxV2CharFilter> onItemClick
		{
			[Token(Token = "0x601AA50")]
			[Address(RVA = "0x13C24C0", Offset = "0x13C10C0", VA = "0x1813C24C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA51")]
			[Address(RVA = "0x13C2520", Offset = "0x13C1120", VA = "0x1813C2520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AA52 RID: 109138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA52")]
		[Address(RVA = "0x13C22F0", Offset = "0x13C0EF0", VA = "0x1813C22F0")]
		public void Render(int position, SandboxV2CharFilter charAvailStatus, bool isSelect)
		{
		}

		// Token: 0x0601AA53 RID: 109139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA53")]
		[Address(RVA = "0x13C21E0", Offset = "0x13C0DE0", VA = "0x1813C21E0")]
		public void EventOnBtnClick()
		{
		}

		// Token: 0x0601AA54 RID: 109140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA54")]
		[Address(RVA = "0x13C2460", Offset = "0x13C1060", VA = "0x1813C2460")]
		public SandboxV2CharStatusItemView()
		{
		}

		// Token: 0x04021FEB RID: 139243
		[Token(Token = "0x4021FEB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _topLineGo;

		// Token: 0x04021FEC RID: 139244
		[Token(Token = "0x4021FEC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectBgGo;

		// Token: 0x04021FED RID: 139245
		[Token(Token = "0x4021FED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textStatus;

		// Token: 0x04021FEE RID: 139246
		[Token(Token = "0x4021FEE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorSelect;

		// Token: 0x04021FEF RID: 139247
		[Token(Token = "0x4021FEF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorUnselect;

		// Token: 0x04021FF0 RID: 139248
		[Token(Token = "0x4021FF0")]
		[FieldOffset(Offset = "0x50")]
		private SandboxV2CharFilter m_charStatus;

		// Token: 0x04021FF2 RID: 139250
		[Token(Token = "0x4021FF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x04021FF3 RID: 139251
		[Token(Token = "0x4021FF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x04021FF4 RID: 139252
		[Token(Token = "0x4021FF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021FF5 RID: 139253
		[Token(Token = "0x4021FF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBtnClick;

		// Token: 0x04021FF6 RID: 139254
		[Token(Token = "0x4021FF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
