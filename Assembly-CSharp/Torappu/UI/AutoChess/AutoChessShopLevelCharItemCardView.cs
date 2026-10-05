using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006368 RID: 25448
	[Token(Token = "0x2006368")]
	public class AutoChessShopLevelCharItemCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170056B0 RID: 22192
		// (get) Token: 0x06024B72 RID: 150386 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024B73 RID: 150387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056B0")]
		public IDragHandler parentScrollHandler
		{
			[Token(Token = "0x6024B72")]
			[Address(RVA = "0x1F89640", Offset = "0x1F88240", VA = "0x181F89640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024B73")]
			[Address(RVA = "0x1F896A0", Offset = "0x1F882A0", VA = "0x181F896A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170056B1 RID: 22193
		// (get) Token: 0x06024B74 RID: 150388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056B1")]
		public GameObject objClickPart
		{
			[Token(Token = "0x6024B74")]
			[Address(RVA = "0x1F89550", Offset = "0x1F88150", VA = "0x181F89550")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024B75 RID: 150389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B75")]
		[Address(RVA = "0x1F885F0", Offset = "0x1F871F0", VA = "0x181F885F0")]
		public void Render(AutoChessShopLevelCharItemCardViewModel itemCardViewModel)
		{
		}

		// Token: 0x06024B76 RID: 150390 RVA: 0x000C54F0 File Offset: 0x000C36F0
		[Token(Token = "0x6024B76")]
		[Address(RVA = "0x1F89030", Offset = "0x1F87C30", VA = "0x181F89030")]
		private ValueBundle _GenClickParams()
		{
			return default(ValueBundle);
		}

		// Token: 0x06024B77 RID: 150391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B77")]
		[Address(RVA = "0x1F89370", Offset = "0x1F87F70", VA = "0x181F89370")]
		private void _SetCharNewTrackPoint(bool isShow)
		{
		}

		// Token: 0x06024B78 RID: 150392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B78")]
		[Address(RVA = "0x1F891D0", Offset = "0x1F87DD0", VA = "0x181F891D0")]
		private void _OnCharDiyItemClick(string chessId)
		{
		}

		// Token: 0x06024B79 RID: 150393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B79")]
		[Address(RVA = "0x1F892A0", Offset = "0x1F87EA0", VA = "0x181F892A0")]
		private void _OnCharItemClick(string chessId)
		{
		}

		// Token: 0x06024B7A RID: 150394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B7A")]
		[Address(RVA = "0x1F890E0", Offset = "0x1F87CE0", VA = "0x181F890E0")]
		private void _OnCharCancelClick(string chessId)
		{
		}

		// Token: 0x06024B7B RID: 150395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B7B")]
		[Address(RVA = "0x1F894F0", Offset = "0x1F880F0", VA = "0x181F894F0")]
		public AutoChessShopLevelCharItemCardView()
		{
		}

		// Token: 0x04033439 RID: 209977
		[Token(Token = "0x4033439")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rectCharViewContainer;

		// Token: 0x0403343A RID: 209978
		[Token(Token = "0x403343A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _rectDiyViewContainer;

		// Token: 0x0403343B RID: 209979
		[Token(Token = "0x403343B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AutoChessShopCharChessCardView _chessCardViewPrefab;

		// Token: 0x0403343C RID: 209980
		[Token(Token = "0x403343C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessShopCharChessDiyCardView _chessDiyCardViewPrefab;

		// Token: 0x0403343D RID: 209981
		[Token(Token = "0x403343D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rectSkillAndModuleEditContainer;

		// Token: 0x0403343E RID: 209982
		[Token(Token = "0x403343E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AutoChessShopLevelSkillAndModuleEditItemView _skillAndModuleEditItemViewPrefab;

		// Token: 0x0403343F RID: 209983
		[Token(Token = "0x403343F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _trackPointContainer;

		// Token: 0x04033440 RID: 209984
		[Token(Token = "0x4033440")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objNewPrefab;

		// Token: 0x04033441 RID: 209985
		[Token(Token = "0x4033441")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04033442 RID: 209986
		[Token(Token = "0x4033442")]
		[FieldOffset(Offset = "0x68")]
		private AutoChessShopCharChessCardView m_charChessCardView;

		// Token: 0x04033443 RID: 209987
		[Token(Token = "0x4033443")]
		[FieldOffset(Offset = "0x70")]
		private AutoChessShopCharChessDiyCardView m_diyCardView;

		// Token: 0x04033444 RID: 209988
		[Token(Token = "0x4033444")]
		[FieldOffset(Offset = "0x78")]
		private AutoChessShopLevelSkillAndModuleEditItemView m_skillAndModuleEditItemView;

		// Token: 0x04033445 RID: 209989
		[Token(Token = "0x4033445")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedChessId;

		// Token: 0x04033446 RID: 209990
		[Token(Token = "0x4033446")]
		[FieldOffset(Offset = "0x88")]
		private int m_cachedChessLv;

		// Token: 0x04033447 RID: 209991
		[Token(Token = "0x4033447")]
		[FieldOffset(Offset = "0x90")]
		private GameObject m_trackPointObj;

		// Token: 0x04033449 RID: 209993
		[Token(Token = "0x4033449")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_parentScrollHandler;

		// Token: 0x0403344A RID: 209994
		[Token(Token = "0x403344A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_parentScrollHandler;

		// Token: 0x0403344B RID: 209995
		[Token(Token = "0x403344B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_objClickPart;

		// Token: 0x0403344C RID: 209996
		[Token(Token = "0x403344C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403344D RID: 209997
		[Token(Token = "0x403344D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenClickParams;

		// Token: 0x0403344E RID: 209998
		[Token(Token = "0x403344E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetCharNewTrackPoint;

		// Token: 0x0403344F RID: 209999
		[Token(Token = "0x403344F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnCharDiyItemClick;

		// Token: 0x04033450 RID: 210000
		[Token(Token = "0x4033450")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnCharItemClick;

		// Token: 0x04033451 RID: 210001
		[Token(Token = "0x4033451")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnCharCancelClick;

		// Token: 0x04033452 RID: 210002
		[Token(Token = "0x4033452")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
