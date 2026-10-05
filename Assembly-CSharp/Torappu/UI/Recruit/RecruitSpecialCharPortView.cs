using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200474B RID: 18251
	[Token(Token = "0x200474B")]
	public class RecruitSpecialCharPortView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA41 RID: 113217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA41")]
		[Address(RVA = "0x1504A60", Offset = "0x1503660", VA = "0x181504A60")]
		public void Render(string poolId)
		{
		}

		// Token: 0x0601BA42 RID: 113218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BA42")]
		[Address(RVA = "0x1504DB0", Offset = "0x15039B0", VA = "0x181504DB0")]
		private static RecruitSpecialCharPortGroupView.Input _GenerateCharGroupInput(RarityRank rank, JObjectWrapper charDict, string title)
		{
			return null;
		}

		// Token: 0x0601BA43 RID: 113219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA43")]
		[Address(RVA = "0x1504EF0", Offset = "0x1503AF0", VA = "0x181504EF0")]
		public RecruitSpecialCharPortView()
		{
		}

		// Token: 0x04023DC2 RID: 146882
		[Token(Token = "0x4023DC2")]
		private const string STAR_5_TITLE = "star5ChooseRule";

		// Token: 0x04023DC3 RID: 146883
		[Token(Token = "0x4023DC3")]
		private const string STAR_6_TITLE = "star6ChooseRule";

		// Token: 0x04023DC4 RID: 146884
		[Token(Token = "0x4023DC4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04023DC5 RID: 146885
		[Token(Token = "0x4023DC5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RecruitSpecialCharPortGroupView _prefabGroupView;

		// Token: 0x04023DC6 RID: 146886
		[Token(Token = "0x4023DC6")]
		[FieldOffset(Offset = "0x28")]
		private RecruitSpecialCharPortGroupView m_star6GroupView;

		// Token: 0x04023DC7 RID: 146887
		[Token(Token = "0x4023DC7")]
		[FieldOffset(Offset = "0x30")]
		private RecruitSpecialCharPortGroupView m_star5GroupView;

		// Token: 0x04023DC8 RID: 146888
		[Token(Token = "0x4023DC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023DC9 RID: 146889
		[Token(Token = "0x4023DC9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenerateCharGroupInput;

		// Token: 0x04023DCA RID: 146890
		[Token(Token = "0x4023DCA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
