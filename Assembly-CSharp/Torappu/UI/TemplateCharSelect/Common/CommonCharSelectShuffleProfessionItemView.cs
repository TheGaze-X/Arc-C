using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C19 RID: 23577
	[Token(Token = "0x2005C19")]
	public class CommonCharSelectShuffleProfessionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005030 RID: 20528
		// (get) Token: 0x060222F4 RID: 140020 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060222F5 RID: 140021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005030")]
		public Action<ProfessionCategory> onProfessionClick
		{
			[Token(Token = "0x60222F4")]
			[Address(RVA = "0x1CB0660", Offset = "0x1CAF260", VA = "0x181CB0660")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60222F5")]
			[Address(RVA = "0x1CB06C0", Offset = "0x1CAF2C0", VA = "0x181CB06C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060222F6 RID: 140022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222F6")]
		[Address(RVA = "0x1CB0340", Offset = "0x1CAEF40", VA = "0x181CB0340")]
		public void Render(ProfessionCategory profession, bool isSelect)
		{
		}

		// Token: 0x060222F7 RID: 140023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60222F7")]
		[Address(RVA = "0x1CB0510", Offset = "0x1CAF110", VA = "0x181CB0510")]
		private Sprite _GetProfessionIcon(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x060222F8 RID: 140024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222F8")]
		[Address(RVA = "0x1CB0270", Offset = "0x1CAEE70", VA = "0x181CB0270")]
		public void EventOnClick()
		{
		}

		// Token: 0x060222F9 RID: 140025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222F9")]
		[Address(RVA = "0x1CB0600", Offset = "0x1CAF200", VA = "0x181CB0600")]
		public CommonCharSelectShuffleProfessionItemView()
		{
		}

		// Token: 0x0402EE2B RID: 192043
		[Token(Token = "0x402EE2B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x0402EE2C RID: 192044
		[Token(Token = "0x402EE2C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _colorUnselect;

		// Token: 0x0402EE2D RID: 192045
		[Token(Token = "0x402EE2D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorSelect;

		// Token: 0x0402EE2E RID: 192046
		[Token(Token = "0x402EE2E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CommonCharSelectShuffleProfessionItemView.ProfessionIcon[] _professionIconList;

		// Token: 0x0402EE2F RID: 192047
		[Token(Token = "0x402EE2F")]
		[FieldOffset(Offset = "0x48")]
		private ProfessionCategory m_profession;

		// Token: 0x0402EE31 RID: 192049
		[Token(Token = "0x402EE31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onProfessionClick;

		// Token: 0x0402EE32 RID: 192050
		[Token(Token = "0x402EE32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onProfessionClick;

		// Token: 0x0402EE33 RID: 192051
		[Token(Token = "0x402EE33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EE34 RID: 192052
		[Token(Token = "0x402EE34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetProfessionIcon;

		// Token: 0x0402EE35 RID: 192053
		[Token(Token = "0x402EE35")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0402EE36 RID: 192054
		[Token(Token = "0x402EE36")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C1A RID: 23578
		[Token(Token = "0x2005C1A")]
		[Serializable]
		public class ProfessionIcon
		{
			// Token: 0x060222FA RID: 140026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60222FA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ProfessionIcon()
			{
			}

			// Token: 0x0402EE37 RID: 192055
			[Token(Token = "0x402EE37")]
			[FieldOffset(Offset = "0x10")]
			public ProfessionCategory profession;

			// Token: 0x0402EE38 RID: 192056
			[Token(Token = "0x402EE38")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;
		}
	}
}
