using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004426 RID: 17446
	[Token(Token = "0x2004426")]
	public class SandboxV2ProfessionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003F27 RID: 16167
		// (get) Token: 0x0601AA55 RID: 109141 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA56 RID: 109142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F27")]
		public Action<ProfessionCategory> onProfessionClick
		{
			[Token(Token = "0x601AA55")]
			[Address(RVA = "0x13C2990", Offset = "0x13C1590", VA = "0x1813C2990")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA56")]
			[Address(RVA = "0x13C29F0", Offset = "0x13C15F0", VA = "0x1813C29F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AA57 RID: 109143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA57")]
		[Address(RVA = "0x13C2670", Offset = "0x13C1270", VA = "0x1813C2670")]
		public void Render(ProfessionCategory profession, bool isSelect)
		{
		}

		// Token: 0x0601AA58 RID: 109144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AA58")]
		[Address(RVA = "0x13C2840", Offset = "0x13C1440", VA = "0x1813C2840")]
		private Sprite _GetProfessionIcon(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x0601AA59 RID: 109145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA59")]
		[Address(RVA = "0x13C25A0", Offset = "0x13C11A0", VA = "0x1813C25A0")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601AA5A RID: 109146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA5A")]
		[Address(RVA = "0x13C2930", Offset = "0x13C1530", VA = "0x1813C2930")]
		public SandboxV2ProfessionItemView()
		{
		}

		// Token: 0x04021FF7 RID: 139255
		[Token(Token = "0x4021FF7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x04021FF8 RID: 139256
		[Token(Token = "0x4021FF8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _colorUnselect;

		// Token: 0x04021FF9 RID: 139257
		[Token(Token = "0x4021FF9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorSelect;

		// Token: 0x04021FFA RID: 139258
		[Token(Token = "0x4021FFA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SandboxV2ProfessionItemView.ProfessionIcon[] _professionIconList;

		// Token: 0x04021FFB RID: 139259
		[Token(Token = "0x4021FFB")]
		[FieldOffset(Offset = "0x48")]
		private ProfessionCategory m_profession;

		// Token: 0x04021FFD RID: 139261
		[Token(Token = "0x4021FFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onProfessionClick;

		// Token: 0x04021FFE RID: 139262
		[Token(Token = "0x4021FFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onProfessionClick;

		// Token: 0x04021FFF RID: 139263
		[Token(Token = "0x4021FFF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022000 RID: 139264
		[Token(Token = "0x4022000")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetProfessionIcon;

		// Token: 0x04022001 RID: 139265
		[Token(Token = "0x4022001")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04022002 RID: 139266
		[Token(Token = "0x4022002")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004427 RID: 17447
		[Token(Token = "0x2004427")]
		[Serializable]
		public class ProfessionIcon
		{
			// Token: 0x0601AA5B RID: 109147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AA5B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ProfessionIcon()
			{
			}

			// Token: 0x04022003 RID: 139267
			[Token(Token = "0x4022003")]
			[FieldOffset(Offset = "0x10")]
			public ProfessionCategory profession;

			// Token: 0x04022004 RID: 139268
			[Token(Token = "0x4022004")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;
		}
	}
}
