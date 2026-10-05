using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E1B RID: 15899
	[Token(Token = "0x2003E1B")]
	public class SquadFriendProfessionTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018B99 RID: 101273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B99")]
		[Address(RVA = "0x113C930", Offset = "0x113B530", VA = "0x18113C930")]
		public void Render(SquadFriendProfessionTabView.Param param)
		{
		}

		// Token: 0x06018B9A RID: 101274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B9A")]
		[Address(RVA = "0x113CA70", Offset = "0x113B670", VA = "0x18113CA70")]
		public void SetSelected(bool isSelected)
		{
		}

		// Token: 0x06018B9B RID: 101275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B9B")]
		[Address(RVA = "0x113C8C0", Offset = "0x113B4C0", VA = "0x18113C8C0")]
		public void OnClick()
		{
		}

		// Token: 0x06018B9C RID: 101276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B9C")]
		[Address(RVA = "0x113CAF0", Offset = "0x113B6F0", VA = "0x18113CAF0")]
		public SquadFriendProfessionTabView()
		{
		}

		// Token: 0x0401E5D9 RID: 124377
		[Token(Token = "0x401E5D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _selectStateToggle;

		// Token: 0x0401E5DA RID: 124378
		[Token(Token = "0x401E5DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _selectedProfessionImg;

		// Token: 0x0401E5DB RID: 124379
		[Token(Token = "0x401E5DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _unselectedProfessionImg;

		// Token: 0x0401E5DC RID: 124380
		[Token(Token = "0x401E5DC")]
		[FieldOffset(Offset = "0x30")]
		private Action<ProfessionCategory> m_clickEvent;

		// Token: 0x0401E5DD RID: 124381
		[Token(Token = "0x401E5DD")]
		[FieldOffset(Offset = "0x38")]
		private ProfessionCategory m_professionCategory;

		// Token: 0x0401E5DE RID: 124382
		[Token(Token = "0x401E5DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E5DF RID: 124383
		[Token(Token = "0x401E5DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelected;

		// Token: 0x0401E5E0 RID: 124384
		[Token(Token = "0x401E5E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401E5E1 RID: 124385
		[Token(Token = "0x401E5E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E1C RID: 15900
		[Token(Token = "0x2003E1C")]
		public class Param
		{
			// Token: 0x06018B9D RID: 101277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018B9D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0401E5E2 RID: 124386
			[Token(Token = "0x401E5E2")]
			[FieldOffset(Offset = "0x10")]
			public ProfessionCategory professionCategory;

			// Token: 0x0401E5E3 RID: 124387
			[Token(Token = "0x401E5E3")]
			[FieldOffset(Offset = "0x14")]
			public bool isSelected;

			// Token: 0x0401E5E4 RID: 124388
			[Token(Token = "0x401E5E4")]
			[FieldOffset(Offset = "0x18")]
			public Action<ProfessionCategory> clickEvent;
		}
	}
}
