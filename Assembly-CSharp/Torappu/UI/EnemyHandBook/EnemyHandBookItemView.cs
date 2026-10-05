using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F2E RID: 20270
	[Token(Token = "0x2004F2E")]
	public class EnemyHandBookItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170046C9 RID: 18121
		// (get) Token: 0x0601E31E RID: 123678 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E31F RID: 123679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046C9")]
		public Action<string> onClick
		{
			[Token(Token = "0x601E31E")]
			[Address(RVA = "0x17E9A90", Offset = "0x17E8690", VA = "0x1817E9A90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601E31F")]
			[Address(RVA = "0x17E9AF0", Offset = "0x17E86F0", VA = "0x1817E9AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E320 RID: 123680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E320")]
		[Address(RVA = "0x17E9580", Offset = "0x17E8180", VA = "0x1817E9580")]
		public void OnClick()
		{
		}

		// Token: 0x0601E321 RID: 123681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E321")]
		[Address(RVA = "0x17E9880", Offset = "0x17E8480", VA = "0x1817E9880")]
		public void SetSelectState(string enemyId)
		{
		}

		// Token: 0x0601E322 RID: 123682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E322")]
		[Address(RVA = "0x17E9990", Offset = "0x17E8590", VA = "0x1817E9990")]
		private void _UpdateNewFlag()
		{
		}

		// Token: 0x0601E323 RID: 123683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E323")]
		[Address(RVA = "0x17E96A0", Offset = "0x17E82A0", VA = "0x1817E96A0")]
		public void Render(int index, EnemyHandBookEverViewModel viewModel, bool disableNewFlag)
		{
		}

		// Token: 0x0601E324 RID: 123684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E324")]
		[Address(RVA = "0x17E9A30", Offset = "0x17E8630", VA = "0x1817E9A30")]
		public EnemyHandBookItemView()
		{
		}

		// Token: 0x040283BE RID: 164798
		[Token(Token = "0x40283BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectPart;

		// Token: 0x040283BF RID: 164799
		[Token(Token = "0x40283BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x040283C0 RID: 164800
		[Token(Token = "0x40283C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _viewPart;

		// Token: 0x040283C1 RID: 164801
		[Token(Token = "0x40283C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _newPart;

		// Token: 0x040283C2 RID: 164802
		[Token(Token = "0x40283C2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _bossLogo;

		// Token: 0x040283C3 RID: 164803
		[Token(Token = "0x40283C3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _idPart;

		// Token: 0x040283C4 RID: 164804
		[Token(Token = "0x40283C4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _idText;

		// Token: 0x040283C6 RID: 164806
		[Token(Token = "0x40283C6")]
		[FieldOffset(Offset = "0x58")]
		private EnemyHandBookEverViewModel m_viewModel;

		// Token: 0x040283C7 RID: 164807
		[Token(Token = "0x40283C7")]
		[FieldOffset(Offset = "0x60")]
		private bool m_disableNewFlag;

		// Token: 0x040283C8 RID: 164808
		[Token(Token = "0x40283C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x040283C9 RID: 164809
		[Token(Token = "0x40283C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x040283CA RID: 164810
		[Token(Token = "0x40283CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040283CB RID: 164811
		[Token(Token = "0x40283CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSelectState;

		// Token: 0x040283CC RID: 164812
		[Token(Token = "0x40283CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateNewFlag;

		// Token: 0x040283CD RID: 164813
		[Token(Token = "0x40283CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040283CE RID: 164814
		[Token(Token = "0x40283CE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
